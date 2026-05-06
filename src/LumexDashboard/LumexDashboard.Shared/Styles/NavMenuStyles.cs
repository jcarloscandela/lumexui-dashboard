using LumexUI.Common;
using LumexUI.Utilities;

namespace LumexDashboard.Shared.Styles;

internal readonly record struct NavMenuStyles
{
    private static readonly string _itemBase = ElementClass.Empty()
        .Add("flex")
        .Add("items-center")
        .Add("rounded-lg")
        .Add("text-default-500")
        .Add("hover:bg-default-100")
        .Add("hover:text-foreground")
        .Add("transition-colors")
        .ToString();

    private static readonly string _itemExpanded = ElementClass.Empty()
        .Add("nav-item")
        .Add("gap-3")
        .ToString();

    private static readonly string _itemCollapsed = ElementClass.Empty()
        .Add("nav-item-collapsed")
        .Add("justify-center")
        .Add("mx-auto")
        .ToString();

    private static readonly string _icon = ElementClass.Empty()
        .Add("nav-icon")
        .Add("shrink-0")
        .ToString();

    private static readonly string _label = ElementClass.Empty()
        .Add("font-medium")
        .ToString();

    public static string GetItemStyles(bool collapsed, string? additionalClass = null)
        => ElementClass.Empty()
            .Add(_itemBase)
            .Add(_itemCollapsed, when: collapsed)
            .Add(_itemExpanded, when: !collapsed)
            .Add(additionalClass)
            .ToString();

    public static string GetIconStyles() => _icon;

    public static string GetLabelStyles() => _label;
}
