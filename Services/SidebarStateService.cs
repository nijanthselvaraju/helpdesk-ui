namespace TicketingSystem.UI.Services
{
    public class SidebarStateService
    {
        public bool IsPinned { get; private set; } = false;
        public bool IsExpanded { get; private set; } = false;

        public event Action? OnStateChanged;

        public void SetPinned(bool pinned)
        {
            IsPinned = pinned;
            IsExpanded = pinned;
            OnStateChanged?.Invoke();
        }

        public void SetExpanded(bool expanded)
        {
            if (!IsPinned)
            {
                IsExpanded = expanded;
                OnStateChanged?.Invoke();
            }
        }
    }
}