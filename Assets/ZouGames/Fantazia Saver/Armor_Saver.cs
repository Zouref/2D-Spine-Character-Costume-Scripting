using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor_Saver : MonoBehaviour
{

    private GearEquipper gearEquipper;

    void Start(){
        gearEquipper = this.GetComponent<GearEquipper>();
        GetStats();
    }

    public void GetStats(){
    gearEquipper.Melee = PlayerPrefs.GetInt("Melee" + "Fan");
    gearEquipper.Shield = PlayerPrefs.GetInt("Shield" + "Fan");
    gearEquipper.Bow = PlayerPrefs.GetInt("Bow" + "Fan");
    gearEquipper.Quiver = PlayerPrefs.GetInt("Quiver" + "Fan");
    gearEquipper.Staff = PlayerPrefs.GetInt("Staff" + "Fan");
    gearEquipper.DuelistOffhand = PlayerPrefs.GetInt("DuelistOffhand" + "Fan");
    gearEquipper.Armor = PlayerPrefs.GetInt("Armor" + "Fan");
    gearEquipper.Helmet = PlayerPrefs.GetInt("Helmet" + "Fan");
    gearEquipper.Shoulder = PlayerPrefs.GetInt("Shoulder" + "Fan");
    gearEquipper.Arm = PlayerPrefs.GetInt("Arm" + "Fan");
    gearEquipper.Feet = PlayerPrefs.GetInt("Feet" + "Fan");
    gearEquipper.Hair = PlayerPrefs.GetInt("Hair" + "Fan");
    gearEquipper.Face = PlayerPrefs.GetInt("Face" + "Fan");
    gearEquipper.ApplySkinChanges();
    }

    public void SaveStats(){
      PlayerPrefs.SetInt("Melee" + "Fan", gearEquipper.Melee);
      PlayerPrefs.SetInt("Shield" + "Fan", gearEquipper.Shield);
      PlayerPrefs.SetInt("Bow" + "Fan", gearEquipper.Bow);
      PlayerPrefs.SetInt("Quiver" + "Fan", gearEquipper.Quiver);
      PlayerPrefs.SetInt("Staff" + "Fan", gearEquipper.Staff);
      PlayerPrefs.SetInt("DuelistOffhand" + "Fan", gearEquipper.DuelistOffhand);
      PlayerPrefs.SetInt("Armor" + "Fan", gearEquipper.Armor);
      PlayerPrefs.SetInt("Helmet" + "Fan", gearEquipper.Helmet);
      PlayerPrefs.SetInt("Shoulder" + "Fan", gearEquipper.Shoulder);
      PlayerPrefs.SetInt("Arm" + "Fan", gearEquipper.Arm);
      PlayerPrefs.SetInt("Feet" + "Fan", gearEquipper.Feet);
      PlayerPrefs.SetInt("Hair" + "Fan", gearEquipper.Hair);
      PlayerPrefs.SetInt("Face" + "Fan", gearEquipper.Face);
    }
}
