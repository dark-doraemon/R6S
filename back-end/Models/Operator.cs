namespace back_end;

public class Operator
{
    public string OperatorId { get; set; }  
    public string OperatorName { get; set; }
    public string Icon { get; set; }    
    public Ability Ability { get; set; }
    public Side Side { get; set; }
    public int Health { get; set; }  
    public int Speed { get; set; }
    public int Difficult { get; set; }
    public IList<Weapon> Weapons { get; set; }
    public IList<Gadget> Gadgets { get; set; }
    public Biography Biography { get; set; }
    public Squad Squad { get; set; }

}
