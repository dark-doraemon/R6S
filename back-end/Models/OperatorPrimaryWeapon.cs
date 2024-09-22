using System;

namespace back_end.Models;

//this model is created by many-many relationship of Operator and PrimaryWeapon
public class OperatorPrimaryWeapon
{
    public string OperatorId { get; set; }
    public Operator Operator { get; set; }
    public string PrimaryWeaponId { get; set; }
    public PrimaryWeapon PrimaryWeapon { get; set; }
}
