using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity.Examples;
using TMPro;


public class SpritesHandler : MonoBehaviour
{

  public int Melee;
  public int Shield;
  public int Armor;
  public int Helmet;
  public int Shoulder;
  public int Arm;
  public int Feet;
  public int Hair;
  public int Face;
  public int OffHand;
  public int Quiver;

  public TMP_Text Melee_tx, Shield_tx, Armor_tx, Helmet_tx, Shoulder_tx, Arm_tx, Feet_tx, Hair_tx, Face_tx, OffHand_tx, Quiver_tx;

  // Controller
    public Part[] part;
    public SpriteAttacher TheAttacher;
    public GameObject Body;
    public int CurrentArmor = 0;

    void Start(){
        
        for (int i = 0; i < part.Length; i++){
          if (part[i].sprite[0] != null){
           TheAttacher = Body.AddComponent<SpriteAttacher>();
           TheAttacher.sprite = part[i].sprite[0];
           TheAttacher.slot = part[i].Slot;
           TheAttacher.GoNow();
           Destroy (TheAttacher);
          }
        }

        Melee_tx.text = "Melee " + Melee.ToString();
        Shield_tx.text = "Shield " + Shield.ToString();
        Armor_tx.text = "Armor " + Armor.ToString();
        Helmet_tx.text = "Helmet " + Helmet.ToString();
        Shoulder_tx.text = "Shoulder " + Shoulder.ToString();
        Arm_tx.text = "Arm " + Arm.ToString();
        Feet_tx.text = "Feet " + Feet.ToString();
        Hair_tx.text = "Hair " + Hair.ToString();
        Face_tx.text = "Face " + Face.ToString();
        OffHand_tx.text = "OffHand " + OffHand.ToString();
        Quiver_tx.text = "Quiver " + Quiver.ToString();
      /*
        Change_Weapon(0);
        Change_Shield(0);
        Change_Armor(0);
        Change_Helmet(0);
        Change_Shoulder(0);
        Change_Arm(0);
        Change_Feet(0);
        Change_Hair(0);
        Change_Face(0);
        Change_OffHand(0);
        Change_Quiver(0);
        */
    }

    public void Change_Weapon(int value){
      Melee += value;
      if (Melee < 0) Melee = 0;
      if (Melee >= part[28].sprite.Length) Melee = part[28].sprite.Length - 1;
      Melee_tx.text = "Melee " + Melee.ToString();
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[28].sprite[Melee];
      TheAttacher.slot = "WEAPON";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }

    public void Change_Shield(int value){
      Shield += value;
      if (Shield < 0) Shield = 0;
      if (Shield >= part[24].sprite.Length) Shield = part[24].sprite.Length - 1;
      Shield_tx.text = "Shield " + Shield.ToString();
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[24].sprite[Shield];
      TheAttacher.slot = "SHIELD";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }

    public void Change_Armor(int value){
      Armor += value;
      if (Armor < 0) Armor = 0;
      if (Armor >= part[8].sprite.Length) Armor = part[8].sprite.Length - 1;
      Armor_tx.text = "Armor " + Armor.ToString();
      // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[8].sprite[Armor];
      TheAttacher.slot = "BODY";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      
    }

    public void Change_Helmet(int value){
      Helmet += value;
      if (Helmet < 0) Helmet = 0;
      if (Helmet >= part[12].sprite.Length) Helmet = part[12].sprite.Length - 1;
      Helmet_tx.text = "Helmet " + Helmet.ToString();
      // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[12].sprite[Helmet];
      TheAttacher.slot = "HELMET";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 2
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[13].sprite[Helmet];
      TheAttacher.slot = "HELMETCLIP";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }

    public void Change_Shoulder(int value){
      Shoulder += value;
      if (Shoulder < 0) Shoulder = 0;
      if (Shoulder >= part[25].sprite.Length) Shoulder = part[25].sprite.Length - 1;
      Shoulder_tx.text = "Shoulder " + Shoulder.ToString();
      // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[25].sprite[Shoulder];
      TheAttacher.slot = "SHOULDER A";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 2
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[26].sprite[Shoulder];
      TheAttacher.slot = "SHOULDER B";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }



    public void Change_Arm(int value){
     Arm += value;
     if (Arm < 0) Arm = 0;
     if (Arm >= part[0].sprite.Length) Arm = part[0].sprite.Length - 1;
     Arm_tx.text = "Arm " + Arm.ToString();
     // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[0].sprite[Arm];
      TheAttacher.slot = "ARM A1";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 2
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[1].sprite[Arm];
      TheAttacher.slot = "ARM A2";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 3
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[2].sprite[Arm];
      TheAttacher.slot = "ARM A3";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 4
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[3].sprite[Arm];
      TheAttacher.slot = "ARM B1";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 5
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[4].sprite[Arm];
      TheAttacher.slot = "ARM B2";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 6
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[5].sprite[Arm];
      TheAttacher.slot = "ARM B3B";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 7
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[6].sprite[Arm];
      TheAttacher.slot = "ARM B3F";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }



    public void Change_Feet(int value){
     Feet += value;
     if (Feet < 0) Feet = 0;
     if (Feet >= part[15].sprite.Length) Feet = part[15].sprite.Length - 1;
     Feet_tx.text = "Feet " + Feet.ToString();
      // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[15].sprite[Feet];
      TheAttacher.slot = "LEG A1";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 2
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[16].sprite[Feet];
      TheAttacher.slot = "LEG A2";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 3
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[17].sprite[Feet];
      TheAttacher.slot = "LEG A3";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 4
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[18].sprite[Feet];
      TheAttacher.slot = "LEG B1";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 5
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[19].sprite[Feet];
      TheAttacher.slot = "LEG B2";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
      // 6
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[20].sprite[Feet];
      TheAttacher.slot = "LEG B3";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }

    public void Change_Hair(int value){
     Hair += value;
     if (Hair < 0) Hair = 0;
     if (Hair >= part[9].sprite.Length) Hair = part[9].sprite.Length - 1;
     Hair_tx.text = "Hair " + Hair.ToString();
     // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[9].sprite[Hair];
      TheAttacher.slot = "HAIR";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }

    public void Change_Face(int value){
     Face += value;
     if (Face < 0) Face = 0;
     if (Face >= part[10].sprite.Length) Face = part[10].sprite.Length - 1;
     Face_tx.text = "Face " + Face.ToString();
     // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[10].sprite[Face];
      TheAttacher.slot = "HEAD EYES OPEN";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }

    public void Change_OffHand(int value){
     OffHand += value;
     if (OffHand < 0) OffHand = 0;
     if (OffHand >= part[22].sprite.Length) OffHand = part[22].sprite.Length - 1;
     OffHand_tx.text = "OffHand " + OffHand.ToString();
     // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[22].sprite[OffHand];
      TheAttacher.slot = "OFFHAND1";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }

    public void Change_Quiver(int value){
     Quiver += value;
     if (Quiver < 0) Face = 0;
     if (Quiver >= part[23].sprite.Length) Quiver = part[23].sprite.Length - 1;
     Quiver_tx.text = "Quiver " + Quiver.ToString();
     // 1
      TheAttacher = Body.AddComponent<SpriteAttacher>();
      TheAttacher.sprite = part[23].sprite[Quiver];
      TheAttacher.slot = "QUIVER";
      TheAttacher.GoNow();
      Destroy (TheAttacher);
    }
}
