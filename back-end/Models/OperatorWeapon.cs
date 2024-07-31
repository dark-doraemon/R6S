namespace back_end;

public class OperatorWeapon
{
    public string OperatorId { get; set; }
    public Operator Operator { get; set; }
    public string WeaponId { get; set; }
    public Weapon Weapon { get; set; }
}
