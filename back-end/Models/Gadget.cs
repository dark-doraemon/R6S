using back_end.Models;

namespace back_end;

public class Gadget  
{
    public string GadgetId { get; set; }
    public string GadgetName { get; set; }
    public string Img {get; set; }
    public string Description { get; set; }
    public string Damage { get; set; }
    public ICollection<OperatorGadget> Operators { get; set; }

}
