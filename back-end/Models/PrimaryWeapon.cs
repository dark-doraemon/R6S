using System;

namespace back_end.Models;

public class PrimaryWeapon : Weapon
{
    public ICollection<OperatorPrimaryWeapon> Operators { get; set; } 
}
