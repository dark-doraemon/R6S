namespace back_end;

public class WeaponType
{
    public string WeaponTypeId { get; set; }
    public string WeaponTypeName { get; set; }  

    public ICollection<Weapon> Weapons { get; set; }
}