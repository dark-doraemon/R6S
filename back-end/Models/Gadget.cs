namespace back_end;

public class Gadget
{
    public string GadgetId { get; set; }
    public string GadgetName { get; set;}
    public int Damage { get; set; }

    public IList<Operator> Operators { get; set; }

}
