namespace TicketingSystem.UI.Services
{
    public class AuthService
    {
        public event Action? OnAuthStateChanged;

        public bool IsAuthenticated { get; private set; }
        public string Token { get; private set; } = "";
        public UserAuthInfo CurrentUser { get; private set; } = new();

        public Task InitializeAsync()
        {
            // Token lives in memory — already set if user logged in this session
            IsAuthenticated = !string.IsNullOrEmpty(Token);
            return Task.CompletedTask;
        }

        public Task Login(string token, LoginUserInfo user)
        {
            Token = token;
            IsAuthenticated = true;

            CurrentUser = new UserAuthInfo
            {
                Id = user.Id,
                Email = user.Email,
                Name = $"{user.FirstName} {user.LastName}".Trim(),
                Roles = user.Roles,
                Permissions = user.Permissions
            };

            OnAuthStateChanged?.Invoke();
            return Task.CompletedTask;
        }

        public Task Logout()
        {
            Token = "";
            IsAuthenticated = false;
            CurrentUser = new();

            OnAuthStateChanged?.Invoke();
            return Task.CompletedTask;
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
        public List<string> Roles { get; set; } = new();
        public List<string> Permissions { get; set; } = new();
    }

    // Used throughout the app
    public class UserAuthInfo
    {
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string Name { get; set; } = "";
        public List<string> Roles { get; set; } = new();
        public List<string> Permissions { get; set; } = new();
    }
}