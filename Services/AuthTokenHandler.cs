namespace TicketingSystem.UI.Services
{
    public class AuthTokenHandler : DelegatingHandler
    {
        private readonly IServiceProvider _serviceProvider;

        public AuthTokenHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Resolve AuthService from the current scope to get the correct instance
            using var scope = _serviceProvider.CreateScope();
            var authService = scope.ServiceProvider.GetRequiredService<AuthService>();

            if (!string.IsNullOrEmpty(authService.Token))
            {
                request.Headers.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authService.Token);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
