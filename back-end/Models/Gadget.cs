namespace back_end;

public class Gadget
{
    public string GadgetId { get; set; }
    public string GadgetName { get; set;}
    public int Damage { get; set; }
    public ICollection<OperatorGadget> OperatorGadget { get; set; }


}
