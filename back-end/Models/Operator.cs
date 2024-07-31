namespace back_end;

public class Operator
{
    public string OperatorId { get; set; }  
    public string OperatorName { get; set; }
    public string Icon { get; set; }    

    public string AbilityId { get; set; }
    public Ability Ability { get; set; }
    public string SideId { get; set; }
    public Side Side { get; set; }
    public int Health { get; set; }  
    public int Speed { get; set; }
    public int Difficult { get; set; }
    public ICollection<OperatorWeapon> OperatorWeapon { get; set; }
    public ICollection<OperatorGadget> OperatorGadget { get; set; }
    public string BiographyId { get; set; }
    public Biography Biography { get; set; }
    public string SquadId { get; set; }
    public Squad Squad { get; set; }

}
