namespace LumexDashboard.Shared.Services;

public class AppStateService
{
    public event Action? OnChange;

    public bool SidebarCollapsed
    {
        get;
        set
        {
            if (field != value)
            {
                field = value;
                NotifyStateChanged();
            }
        }
    } = false;

    public bool SidebarOpen
    {
        get;
        set
        {
            if (field != value)
            {
                field = value;
                NotifyStateChanged();
            }
        }
    } = false;

    public bool CommandPaletteOpen
    {
        get;
        set
        {
            if (field != value)
            {
                field = value;
                NotifyStateChanged();
            }
        }
    } = false;

    public string ThemeMode
    {
        get;
        set
        {
            if (field != value)
            {
                field = value;
                NotifyStateChanged();
            }
        }
    } = "system";

    public string ThemeColor
    {
        get;
        set
        {
            if (field != value)
            {
                field = value;
                NotifyStateChanged();
            }
        }
    } = "blue";

    public void ToggleSidebar() => SidebarOpen = !SidebarOpen;
    public void ToggleSidebarCollapse() => SidebarCollapsed = !SidebarCollapsed;
    public void OpenCommandPalette() => CommandPaletteOpen = true;
    public void CloseCommandPalette() => CommandPaletteOpen = false;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
