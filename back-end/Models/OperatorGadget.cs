namespace back_end;

//this model is created by many-many relationship of Operator and Gadge
public class OperatorGadget
{
    public string OperatorId { get; set; }  
    public Operator Operator { get; set; }
    public string GadgetId { get; set; }
    public Gadget Gadget { get; set; }    
    public int QuantityOfGadget { get; set; }
}
