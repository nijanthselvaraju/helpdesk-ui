using Microsoft.JSInterop;
using System.Text.Json;

namespace TicketingSystem.UI.Services
{
    public class AuthService
    {
        private readonly IJSRuntime _js;

        public AuthService(IJSRuntime js)
        {
            _js = js;
        }

        public event Action? OnAuthStateChanged;

        public bool IsAuthenticated { get; private set; }
        public string Token { get; private set; } = "";
        public UserAuthInfo CurrentUser { get; private set; } = new();

        public async Task InitializeAsync()
        {
            // Already loaded this session — skip
            if (!string.IsNullOrEmpty(Token))
            {
                IsAuthenticated = true;
                return;
            }

            // Try rehydrating from localStorage after a page refresh
            try
            {
                var token = await _js.InvokeAsync<string?>("localStorage.getItem", "authToken");
                var userJson = await _js.InvokeAsync<string?>("localStorage.getItem", "authUser");

                if (!string.IsNullOrEmpty(token) && !string.IsNullOrEmpty(userJson))
                {
                    Token = token;
                    CurrentUser = JsonSerializer.Deserialize<UserAuthInfo>(userJson) ?? new();
                    IsAuthenticated = true;
                }
                else
                {
                    IsAuthenticated = false;
                }
            }
            catch
            {
                // JS interop not available during prerender — stay unauthenticated
                IsAuthenticated = false;
            }
        }

        public async Task Login(string token, LoginUserInfo user)
        {
            Token = token;
            IsAuthenticated = true;

            CurrentUser = new UserAuthInfo
            {
                Id = user.Id,
                Email = user.Email,
                Name = $"{user.FirstName} {user.LastName}".Trim(),
                EntityId = user.EntityId,
                Roles = user.Roles,
                Permissions = user.Permissions
            };

            // Persist to localStorage so refresh doesn't log the user out
            await _js.InvokeVoidAsync("localStorage.setItem", "authToken", token);
            await _js.InvokeVoidAsync("localStorage.setItem", "authUser",
                JsonSerializer.Serialize(CurrentUser));

            OnAuthStateChanged?.Invoke();
        }

        public async Task Logout()
        {
            Token = "";
            IsAuthenticated = false;
            CurrentUser = new();

            await _js.InvokeVoidAsync("localStorage.removeItem", "authToken");
            await _js.InvokeVoidAsync("localStorage.removeItem", "authUser");

            OnAuthStateChanged?.Invoke();
        }

        public bool HasPermission(string permission) =>
            CurrentUser.Permissions.Contains(permission);

        public bool HasRole(string role) =>
            CurrentUser.Roles.Contains(role);

        public bool IsSuperAdmin() =>
            HasRole("SuperAdmin");
    }

    // Used when logging in (matches what Login.razor passes)
    public class LoginUserInfo
    {
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int EntityId { get; set; }
        public List<string> Roles { get; set; } = new();
        public List<string> Permissions { get; set; } = new();
    }

    // Used throughout the app
    public class UserAuthInfo
    {
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string Name { get; set; } = "";
        public int EntityId { get; set; }
        public List<string> Roles { get; set; } = new();
        public List<string> Permissions { get; set; } = new();
    }
}