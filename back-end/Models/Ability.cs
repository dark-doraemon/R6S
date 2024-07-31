namespace back_end;

public class Ability
{
    public string AbilityId { get; set; }
    public string AbilityName { get; set; }
    public string Damage { get; set; }
    public string Description { get; set; }
    //unique ability is possessed by a operator
    public string OperatorId { get; set; }
    public Operator Operator { get; set; }
}
