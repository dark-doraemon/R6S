using back_end.Models;

namespace back_end;

public class WeaponType
{
    public string WeaponTypeId { get; set; }
    public string WeaponTypeName { get; set; }  

    public ICollection<PrimaryWeapon> PrimaryWeapons{ get; set; }
    public ICollection<SecondaryWeapon> SecondaryWeapon { get; set; }
}