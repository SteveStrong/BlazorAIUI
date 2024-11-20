
using System.ComponentModel;
using System.Linq;

namespace Plugin_710.Model;

//     target.SetValueIfNotNull("SourceURL", sourceURL);
//     target.SetValueIfNotNull("Address", address);
//     target.SetValueIfNotNull("SerializedAssembly", serializedAssembly);
//     target.SetValueIfNotNull("MakeBuy", make_buy);
//     target.SetValueIfNotNull("LruSru", lru_sru);
//     target.SetValueIfNotNull("Quantity", qtyReq);
//     target.SetValueIfNotNull("Supplier", supplier);

public record Hyperlink(string name, string tag, string url);

public class SystemBlock_710
{

    public string SerializedAssembly => "";
    public string MakeBuy => "M";
    public string Name => "AC SUPPLY ENCLOSURE (ASE)";
    public string LruSru => "L";
    public string Quantity => "1";
    public string Supplier => "Supplier";
    public string SourceURL => "SourceURL";
    public string Address => "Address";
    public string Description => "AC SUPPLY ENCLOSURE ASSY";
    public string ReferenceDesignator => "UNIT 15";
    public string PartNumber => "8626496";



    public SystemBlock_710()
    {

    }


    public void ZoomTo()
    {
        //model?.ZoomTo(this);
    }

    public void DoHorizontal()
    {

    }

    public void DoVertical()
    {

    }
    public void GoToRoot()
    {

    }
    public void GoToParent()
    {

    }
    public bool IsCurrentRoot()
    {
        return true;
    }

    public bool HasChildren()
    {
        return false;
    }








}
