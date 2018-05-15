//using UnityEngine;
//using Kryz.CharacterStats;

//[CreateAssetMenu]
//public class AdvantageItem : EquippableItem
//{
//    public int AccurateAttackRanks;
//    public int AgileFeint;
//    public int AlloutAttack;
//    public int AnimalEmpathy;
//    public int Artificer;
//    public int Assessment;
//    public int Attractive;
//    public int BeginnersLuck;
//    public int Benefit;
//    public string BenefitDescription;
//    public int Chokehold;
//    public int CloseAttack;
//    public int Connected;
//    public int Contacts;
//    public int Daze;
//    public int DefensiveAttack;
//    public int DefensiveRoll;
//    public int Diehard;
//    public int EideticMemory;
//    public int EquipmentAdvantage;
//    public string EquipmentDescription;
//    public int Evasion;
//    public int ExtraordinaryEffort;
//    public int Fascinate;
//    public int FastGrab;
//    public int FavoredEnvironment;
//    public int FavoredFoe;
//    public int Fearless;
//    public int GrabbingFinesse;
//    public int GreatEndurance;
//    public int HideinPlainSight;
//    public int ImprovedAim;
//    public int ImprovedCritical;
//    public int ImprovedDefense;
//    public int ImprovedDisarm;
//    public int ImprovedGrab;
//    public int ImprovedHold;
//    public int ImprovedInitiative;
//    public int ImprovedSmash;
//    public int ImprovedTrip;
//    public int ImprovisedTools;
//    public int ImprovisedWeapon;
//    public int Inspire;
//    public int InstantUp;
//    public int Interpose;
//    public int Inventor;
//    public int Jackofalltrades;
//    public int Languages;
//    public string LanguagesDescription;
//    public int Leadership;
//    public int Luck;
//    public int Minion;
//    public int MovebyAction;
//    public int PowerAttack;
//    public int PreciseAttack;
//    public int ProneFighting;
//    public int QuickDraw;
//    public int RangedAttack;
//    public int Redirect;
//    public int Ritualist;
//    public int SecondChance;
//    public int SeizeInitiative;
//    public int Setup;
//    public int Sidekick;
//    public int SkillMastery;
//    public string SkillMasteryDescription;
//    public int Startle;
//    public int Takedown;
//    public int Taunt;
//    public int Teamwork;
//    public int ThrowingMastery;
//    public int Tracking;
//    public int Trance;
//    public int UltimateEffort;
//    public int UncannyDodge;
//    public int WeaponBind;
//    public int WeaponBreak;
//    public int Wellinformed;

//    public void AdvEquip(Character c)
//    {
//        if (AccurateAttackRanks != 0)
//            c.AccurateAttack.AddModifier(new StatModifier(AccurateAttackRanks, StatModType.Flat, this));
//        Debug.Log("Accurate Attack = " + AccurateAttackRanks);
//    }
//}