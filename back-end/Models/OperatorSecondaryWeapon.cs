using System;

namespace back_end.Models;

//this model is created by many-many relationship of Operator and SecondaryWeapon 
public class OperatorSecondaryWeapon
{
    public string OperatorId {get;set;}
    public Operator Operator {get;set;}

    public string SecondaryWeaponId {get;set;}
    public SecondaryWeapon SecondaryWeapon { get; set; }
}
