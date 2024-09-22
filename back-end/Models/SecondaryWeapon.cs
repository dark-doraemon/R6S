using System;

namespace back_end.Models;

public class SecondaryWeapon : Weapon
{ 
    public ICollection<OperatorSecondaryWeapon> Operators { get; set; } 
}
