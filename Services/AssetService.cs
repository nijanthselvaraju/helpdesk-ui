namespace TicketingSystem.UI.Services
{
    public class AssetService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private Dictionary<string, string?> _assets = new();
        public event Action? OnAssetsChanged;

        public AssetService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public string? LogoUrl => _assets.GetValueOrDefault("logo");
        public string? LoginBgUrl => _assets.GetValueOrDefault("login-bg");
        public string? FaviconUrl => _assets.GetValueOrDefault("favicon");

        public async Task LoadAssetsAsync()
        {
            try
            {
                var client = _httpClientFactory.CreateClient("API");
                var result = await client.GetFromJsonAsync<Dictionary<string, string?>>("api/assets/list");
                _assets = result ?? new();
                OnAssetsChanged?.Invoke();
            }
            catch
            {
                _assets = new();
            }
        }

        public void NotifyChanged() => OnAssetsChanged?.Invoke();
    }
}
