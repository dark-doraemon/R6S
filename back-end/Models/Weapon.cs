namespace back_end;

public class Weapon
{
    public string WeaponId { get; set; }
    public string WeaponName { get; set;}
    public string WeaponType { get; set;}
    public string QuantityOfAmmo { get; set; }
    public int Damage { get; set; }
    public IList<Operator> Operators { get; set; }
}
