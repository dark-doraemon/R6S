namespace back_end;

public class Weapon
{
    public string WeaponId { get; set; }
    public string WeaponName { get; set;}
    public string WeaponTypeId { get; set;}   
    public WeaponType WeaponType { get; set;}
    public string Img { get; set; }
    public int QuantityOfAmmo { get; set; }
    public int Damage { get; set; }
}
