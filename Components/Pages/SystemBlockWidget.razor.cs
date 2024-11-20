using Microsoft.AspNetCore.Components;

using Plugin_710.Model;
using Radzen.Blazor.Rendering;

namespace Plugin_710.DiagramComponents;

//https://blazor-diagrams.zhaytam.com/documentation/groups-customization

public class SystemBlockWidgetBase : ComponentBase
{
    [Parameter] public SystemBlock_710 Node { get; set; } = new SystemBlock_710();


    public SystemBlock_710 GetSystemBlock()
    {
        return Node;
    }

    public bool HasSubcomponents()
    {
        return false;
    }


    public List<Hyperlink> GetHyperlinks()
    {
        var list = new List<Hyperlink>();
        {
            list.Add(new Hyperlink("Source URL", Node.SourceURL, Node.SourceURL));
            list.Add(new Hyperlink("Address", Node.Address, Node.Address));
        }
        return list;
    }

    public bool HasParent()
    {
        return false;
    }


    public bool IsRoot()
    {
        var comp = GetSystemBlock();
        return comp.IsCurrentRoot();
    }

    public bool HasChildren()
    {
        var comp = GetSystemBlock();
        return comp.HasChildren();
    }
    public string GetTitle()
    {
        return "The title";
    }
    public string BlockStyle()
    {
        var style = "background-color: green";
        return style;
    }

    public string OuterStyle()
    {
        var style = "width:250px;border: 1px solid black;background-color: lightgray";
        return style;
    }

    public string GenerateClasses()
    {
        return ClassList.Create("value-text").Add("danger", true)
                                 .Add("info", false)
                                 .Add("warning", false)
                                 .Add("success", false)
                                 .Add("neutral", false)
                                 .Add("rz-panel-titlebar")
                                 .ToString();

    }


    protected void DoHorizontal()
    {
        var comp = GetSystemBlock();
        comp.DoHorizontal();
    }

    protected void DoVertical()
    {
        var comp = GetSystemBlock();
        comp.DoVertical();
    }

    protected void GoToRoot()
    {
        var comp = GetSystemBlock();
        comp.GoToRoot();
    }
    protected void GoToParent()
    {
        var comp = GetSystemBlock();
        comp.GoToParent();
    }
    protected void ToggleChildren()
    {
        var comp = GetSystemBlock();
    }

    public string SerializedAssembly => GetSystemBlock().SerializedAssembly;
    public string MakeBuy => GetSystemBlock().MakeBuy;
    public string Name => GetSystemBlock().Name;
    public string LruSru => GetSystemBlock().LruSru;
    public string Quantity => GetSystemBlock().Quantity;
    public string Supplier => GetSystemBlock().Supplier;
    public string SourceURL => GetSystemBlock().SourceURL;
    public string Address => GetSystemBlock().Address;
    public string Description => GetSystemBlock().Description;
    public string ReferenceDesignator => GetSystemBlock().ReferenceDesignator;
    public string PartNumber => GetSystemBlock().PartNumber;

}
