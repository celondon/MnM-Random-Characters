using UnityEngine;
using Kryz.CharacterStats;

public enum EquipmentType
{
	Archetype,
	ATSubType,
	Advantage0,
	Advantage1,
	Advantage2,
	Advantage3,
	Advantage4,
	Advantage5,
	Skills0,
	Skills1,
	Skills2,
	Skills3,
	Powers0,
	Powers1,
	Powers2,
	Powers3,
	Powers4,
	Powers5,
	Powers6,
	Powers7,
	Powers8,
	Powers9,
	Powers10,
	Powers11,
}
// Reference Table
//              Subtype   Advantages  Skills Powers
//Battlesuit	    1	    2	        2   	2
//Construct	        1   	1       	2   	4
//Crime_Fighter	    1   	4       	1   	2
//Elemental	        1   	2       	1	    4
//Energy_Controller	1   	2       	3   	7
//Gadgeteer	        1   	1       	1   	5
//Martial_Artist	1   	3       	2   	3
//Mimic	            1	    3       	2   	1
//Mystic	        1   	1   	    1   	7
//Paragon	        1   	1       	2   	3
//Powerhouse	    1	    2   	    2   	8
//Psychic	        1   	1       	2   	4
//Shapeshifter	    1   	1   	    2   	3
//Speedster	        1   	1       	2   	5
//Summoner	        1   	0   	    0      	5
//Supernatural_Cr	1   	1       	1   	5
//Totem         	1	    2       	2   	3
//Warrior	        1   	2       	1   	2
//Weapon_Master 	1   	4       	4   	3
//Weather_Controll	1	    2       	1   	8
//	1	4	4	8


[CreateAssetMenu]
public class EquippableItem : Item
{
	public int StrengthBonus;
	public string StrengthBonusDescription;
	public int AgilityBonus;
	public string AgilityBonusDescription;
	public int FightingBonus;
	public string FightingBonusDescription;
	public int AwarenessBonus;
	public string AwarenessBonusDescription;
	public int StaminaBonus;
	public string StaminaBonusDescription;
	public int DexterityBonus;
	public string DexterityBonusDescription;
	public int IntelligenceBonus;
	public string IntelligenceBonusDescription;
	public int PresenceBonus;
	public string PresenceBonusDescription;
	public int DodgeBonus;
	public string DodgeBonusDescription;
	public int ParryBonus;
	public string ParryBonusDescription;
	public int FortitudeBonus;
	public string FortitudeBonusDescription;
	public int ToughnessBonus;
	public string ToughnessBonusDescription;
	public int WillBonus;
	public string WillBonusDescription;
	[Space]
	public EquipmentType EquipmentType;
	[Space]
	public int AccurateAttackRanks;
	public string AccurateAttackDescription;
	public int AgileFeintRanks;
	public string AgileFeintDescription;
	public int AlloutAttackRanks;
	public string AlloutAttackDescription;
	public int AnimalEmpathyRanks;
	public string AnimalEmpathyDescription;
	public int ArtificerRanks;
	public string ArtificerDescription;
	public int AssessmentRanks;
	public string AssessmentDescription;
	public int AttractiveRanks;
	public string AttractiveDescription;
	public int BeginnersLuckRanks;
	public string BeginnersLuckDescription;
	public int Benefit0Ranks;
	public string Benefit0Description;
	public int Benefit1Ranks;
	public string Benefit1Description;
	public int Benefit2Ranks;
	public string Benefit2Description;
	public int Benefit3Ranks;
	public string Benefit3Description;
	public int ChokeholdRanks;
	public string ChokeholdDescription;
	public int CloseAttackRanks;
	public string CloseAttackDescription;
	public int ConnectedRanks;
	public string ConnectedDescription;
	public int ContactsRanks;
	public string ContactsDescription;
	public int DazeRanks;
	public string DazeDescription;
	public int DefensiveAttackRanks;
	public string DefensiveAttackDescription;
	public int DefensiveRollRanks;
	public string DefensiveRollDescription;
	public int DiehardRanks;
	public string DiehardDescription;
	public int EideticMemoryRanks;
	public string EideticMemoryDescription;
	public int EquipmentAdvantageRanks;
	public string EquipmentAdvantageDescription;
	public int EvasionRanks;
	public string EvasionDescription;
	public int ExtraordinaryEffortRanks;
	public string ExtraordinaryEffortDescription;
	public int FascinateRanks;
	public string FascinateDescription;
	public int FastGrabRanks;
	public string FastGrabDescription;
	public int FavoredEnvironmentRanks;
	public string FavoredEnvironmentDescription;
	public int FavoredFoeRanks;
	public string FavoredFoeDescription;
	public int FearlessRanks;
	public string FearlessDescription;
	public int GrabbingFinesseRanks;
	public string GrabbingFinesseDescription;
	public int GreatEnduranceRanks;
	public string GreatEnduranceDescription;
	public int HideinPlainSightRanks;
	public string HideinPlainSightDescription;
	public int ImprovedAimRanks;
	public string ImprovedAimDescription;
	public int ImprovedCriticalRanks;
	public string ImprovedCriticalDescription;
	public int ImprovedDefenseRanks;
	public string ImprovedDefenseDescription;
	public int ImprovedDisarmRanks;
	public string ImprovedDisarmDescription;
	public int ImprovedGrabRanks;
	public string ImprovedGrabDescription;
	public int ImprovedHoldRanks;
	public string ImprovedHoldDescription;
	public int ImprovedInitiativeRanks;
	public string ImprovedInitiativeDescription;
	public int ImprovedSmashRanks;
	public string ImprovedSmashDescription;
	public int ImprovedTripRanks;
	public string ImprovedTripDescription;
	public int ImprovisedToolsRanks;
	public string ImprovisedToolsDescription;
	public int ImprovisedWeaponRanks;
	public string ImprovisedWeaponDescription;
	public int InspireRanks;
	public string InspireDescription;
	public int InstantUpRanks;
	public string InstantUpDescription;
	public int InterposeRanks;
	public string InterposeDescription;
	public int InventorRanks;
	public string InventorDescription;
	public int JackofalltradesRanks;
	public string JackofalltradesDescription;
	public int LanguagesRanks;
	public string LanguagesDescription;
	public int LeadershipRanks;
	public string LeadershipDescription;
	public int LuckRanks;
	public string LuckDescription;
	public int MinionRanks;
	public string MinionDescription;
	public int MovebyActionRanks;
	public string MovebyActionDescription;
	public int PowerAttackRanks;
	public string PowerAttackDescription;
	public int PreciseAttackRanks;
	public string PreciseAttackDescription;
	public int ProneFightingRanks;
	public string ProneFightingDescription;
	public int QuickDrawRanks;
	public string QuickDrawDescription;
	public int RangedAttackRanks;
	public string RangedAttackDescription;
	public int RedirectRanks;
	public string RedirectDescription;
	public int RitualistRanks;
	public string RitualistDescription;
	public int SecondChanceRanks;
	public string SecondChanceDescription;
	public int SeizeInitiativeRanks;
	public string SeizeInitiativeDescription;
	public int SetupRanks;
	public string SetupDescription;
	public int SidekickRanks;
	public string SidekickDescription;
	public int SkillMastery0Ranks;
	public string SkillMastery0Description;
	public int SkillMastery1Ranks;
	public string SkillMastery1Description;
	public int SkillMastery2Ranks;
	public string SkillMastery2Description;
	public int SkillMastery3Ranks;
	public string SkillMastery3Description;
	public int StartleRanks;
	public string StartleDescription;
	public int TakedownRanks;
	public string TakedownDescription;
	public int TauntRanks;
	public string TauntDescription;
	public int TeamworkRanks;
	public string TeamworkDescription;
	public int ThrowingMasteryRanks;
	public string ThrowingMasteryDescription;
	public int TrackingRanks;
	public string TrackingDescription;
	public int TranceRanks;
	public string TranceDescription;
	public int UltimateEffortRanks;
	public string UltimateEffortDescription;
	public int UncannyDodgeRanks;
	public string UncannyDodgeDescription;
	public int WeaponBindRanks;
	public string WeaponBindDescription;
	public int WeaponBreakRanks;
	public string WeaponBreakDescription;
	public int WellinformedRanks;
	public string WellinformedDescription;
	[Space]
	public int AcrobaticsRanks;
	public string AcrobaticsDescription;
	public int AthleticsRanks;
	public string AthleticsDescription;
	public int CloseCombat0Ranks;
	public string CloseCombat0Description;
	public int CloseCombat1Ranks;
	public string CloseCombat1Description;
	public int CloseCombat2Ranks;
	public string CloseCombat2Description;
	public int CloseCombat3Ranks;
	public string CloseCombat3Description;
	public int DeceptionRanks;
	public string DeceptionDescription;
	public int Expertise0Ranks;
	public string Expertise0Description;
	public int Expertise1Ranks;
	public string Expertise1Description;
	public int Expertise2Ranks;
	public string Expertise2Description;
	public int Expertise3Ranks;
	public string Expertise3Description;
	public int InsightRanks;
	public string InsightDescription;
	public int IntimidationRanks;
	public string IntimidationDescription;
	public int InvestigationRanks;
	public string InvestigationDescription;
	public int PerceptionRanks;
	public string PerceptionDescription;
	public int PersuasionRanks;
	public string PersuasionDescription;
	public int RangedCombat0Ranks;
	public string RangedCombat0Description;
	public int RangedCombat1Ranks;
	public string RangedCombat1Description;
	public int RangedCombat2Ranks;
	public string RangedCombat2Description;
	public int RangedCombat3Ranks;
	public string RangedCombat3Description;
	public int SleightOfHandRanks;
	public string SleightOfHandDescription;
	public int StealthRanks;
	public string StealthDescription;
	public int TechnologyRanks;
	public string TechnologyDescription;
	public int TreatmentRanks;
	public string TreatmentDescription;
	public int VehiclesRanks;
	public string VehiclesDescription;
	[Space]
	public int Power0Ranks;
	public string Power0Description;
	public int Power1Ranks;
	public string Power1Description;
	public int Power2Ranks;
	public string Power2Description;
	public int Power3Ranks;
	public string Power3Description;
	public int Power4Ranks;
	public string Power4Description;
	public int Power5Ranks;
	public string Power5Description;
	public int Power6Ranks;
	public string Power6Description;
	public int Power7Ranks;
	public string Power7Description;
	public int Power8Ranks;
	public string Power8Description;
	public int Power9Ranks;
	public string Power9Description;
	public int Power10Ranks;
	public string Power10Description;
	public int Power11Ranks;
	public string Power11Description;
	
	public void Equip(Character c)
	{
		if (StrengthBonus != 0)
			c.Strength.AddModifier(new StatModifier(StrengthBonus, StrengthBonusDescription, StatModType.Flat, this));
		if (AgilityBonus != 0)
			c.Agility.AddModifier(new StatModifier(AgilityBonus, AgilityBonusDescription, StatModType.Flat, this));
		if (FightingBonus != 0)
			c.Fighting.AddModifier(new StatModifier(FightingBonus, FightingBonusDescription, StatModType.Flat, this));
		if (AwarenessBonus != 0)
			c.Awareness.AddModifier(new StatModifier(AwarenessBonus, AwarenessBonusDescription, StatModType.Flat, this));
		if (StaminaBonus != 0)
			c.Stamina.AddModifier(new StatModifier(StaminaBonus, StaminaBonusDescription, StatModType.Flat, this));
		if (DexterityBonus != 0)
			c.Dexterity.AddModifier(new StatModifier(DexterityBonus, DexterityBonusDescription, StatModType.Flat, this));
		if (IntelligenceBonus != 0)
			c.Intelligence.AddModifier(new StatModifier(IntelligenceBonus, IntelligenceBonusDescription, StatModType.Flat, this));
		if (PresenceBonus != 0)
			c.Presence.AddModifier(new StatModifier(PresenceBonus, PresenceBonusDescription, StatModType.Flat, this));
		if (DodgeBonus != 0)
			c.Dodge.AddModifier(new StatModifier(DodgeBonus, DodgeBonusDescription, StatModType.Flat, this));
		if (ParryBonus != 0)
			c.Parry.AddModifier(new StatModifier(ParryBonus, ParryBonusDescription, StatModType.Flat, this));
		if (FortitudeBonus != 0)
			c.Fortitude.AddModifier(new StatModifier(FortitudeBonus, FortitudeBonusDescription, StatModType.Flat, this));
		if (ToughnessBonus != 0)
			c.Toughness.AddModifier(new StatModifier(ToughnessBonus, ToughnessBonusDescription, StatModType.Flat, this));
		if (WillBonus != 0)
			c.Will.AddModifier(new StatModifier(WillBonus, WillBonusDescription, StatModType.Flat, this));

		if (AccurateAttackRanks != 0)
			c.AccurateAttack.AddModifier(new StatModifier(AccurateAttackRanks, AccurateAttackDescription, StatModType.Flat, this));
		if (AccurateAttackRanks != 0)
			c.AccurateAttack.AddModifier(new StatModifier(AccurateAttackRanks, AccurateAttackDescription, StatModType.Flat, this));
		if (AgileFeintRanks != 0)
			c.AgileFeint.AddModifier(new StatModifier(AgileFeintRanks, AgileFeintDescription, StatModType.Flat, this));
		if (AlloutAttackRanks != 0)
			c.AlloutAttack.AddModifier(new StatModifier(AlloutAttackRanks, AlloutAttackDescription, StatModType.Flat, this));
		if (AnimalEmpathyRanks != 0)
			c.AnimalEmpathy.AddModifier(new StatModifier(AnimalEmpathyRanks, AnimalEmpathyDescription, StatModType.Flat, this));
		if (ArtificerRanks != 0)
			c.Artificer.AddModifier(new StatModifier(ArtificerRanks, ArtificerDescription, StatModType.Flat, this));
		if (AssessmentRanks != 0)
			c.Assessment.AddModifier(new StatModifier(AssessmentRanks, AssessmentDescription, StatModType.Flat, this));
		if (AttractiveRanks != 0)
			c.Attractive.AddModifier(new StatModifier(AttractiveRanks, AttractiveDescription, StatModType.Flat, this));
		if (BeginnersLuckRanks != 0)
			c.BeginnersLuck.AddModifier(new StatModifier(BeginnersLuckRanks, BeginnersLuckDescription, StatModType.Flat, this));
		if (Benefit0Ranks != 0)
			c.Benefit0.AddModifier(new StatModifier(Benefit0Ranks, Benefit0Description, StatModType.Flat, this));
		if (Benefit1Ranks != 0)
			c.Benefit1.AddModifier(new StatModifier(Benefit1Ranks, Benefit1Description, StatModType.Flat, this));
		if (Benefit2Ranks != 0)
			c.Benefit2.AddModifier(new StatModifier(Benefit2Ranks, Benefit2Description, StatModType.Flat, this));
		if (Benefit3Ranks != 0)
			c.Benefit3.AddModifier(new StatModifier(Benefit3Ranks, Benefit3Description, StatModType.Flat, this));
		if (ChokeholdRanks != 0)
			c.Chokehold.AddModifier(new StatModifier(ChokeholdRanks, ChokeholdDescription, StatModType.Flat, this));
		if (CloseAttackRanks != 0)
			c.CloseAttack.AddModifier(new StatModifier(CloseAttackRanks, CloseAttackDescription, StatModType.Flat, this));
		if (ConnectedRanks != 0)
			c.Connected.AddModifier(new StatModifier(ConnectedRanks, ConnectedDescription, StatModType.Flat, this));
		if (ContactsRanks != 0)
			c.Contacts.AddModifier(new StatModifier(ContactsRanks, ContactsDescription, StatModType.Flat, this));
		if (DazeRanks != 0)
			c.Daze.AddModifier(new StatModifier(DazeRanks, DazeDescription, StatModType.Flat, this));
		if (DefensiveAttackRanks != 0)
			c.DefensiveAttack.AddModifier(new StatModifier(DefensiveAttackRanks, DefensiveAttackDescription, StatModType.Flat, this));
		if (DefensiveRollRanks != 0)
			c.DefensiveRoll.AddModifier(new StatModifier(DefensiveRollRanks, DefensiveRollDescription, StatModType.Flat, this));
		if (DiehardRanks != 0)
			c.Diehard.AddModifier(new StatModifier(DiehardRanks, DiehardDescription, StatModType.Flat, this));
		if (EideticMemoryRanks != 0)
			c.EideticMemory.AddModifier(new StatModifier(EideticMemoryRanks, EideticMemoryDescription, StatModType.Flat, this));
		if (EquipmentAdvantageRanks != 0)
			c.EquipmentAdvantage.AddModifier(new StatModifier(EquipmentAdvantageRanks, EquipmentAdvantageDescription, StatModType.Flat, this));
		if (EvasionRanks != 0)
			c.Evasion.AddModifier(new StatModifier(EvasionRanks, EvasionDescription, StatModType.Flat, this));
		if (ExtraordinaryEffortRanks != 0)
			c.ExtraordinaryEffort.AddModifier(new StatModifier(ExtraordinaryEffortRanks, ExtraordinaryEffortDescription, StatModType.Flat, this));
		if (FascinateRanks != 0)
			c.Fascinate.AddModifier(new StatModifier(FascinateRanks, FascinateDescription, StatModType.Flat, this));
		if (FastGrabRanks != 0)
			c.FastGrab.AddModifier(new StatModifier(FastGrabRanks, FastGrabDescription, StatModType.Flat, this));
		if (FavoredEnvironmentRanks != 0)
			c.FavoredEnvironment.AddModifier(new StatModifier(FavoredEnvironmentRanks, FavoredEnvironmentDescription, StatModType.Flat, this));
		if (FavoredFoeRanks != 0)
			c.FavoredFoe.AddModifier(new StatModifier(FavoredFoeRanks, FavoredFoeDescription, StatModType.Flat, this));
		if (FearlessRanks != 0)
			c.Fearless.AddModifier(new StatModifier(FearlessRanks, FearlessDescription, StatModType.Flat, this));
		if (GrabbingFinesseRanks != 0)
			c.GrabbingFinesse.AddModifier(new StatModifier(GrabbingFinesseRanks, GrabbingFinesseDescription, StatModType.Flat, this));
		if (GreatEnduranceRanks != 0)
			c.GreatEndurance.AddModifier(new StatModifier(GreatEnduranceRanks, GreatEnduranceDescription, StatModType.Flat, this));
		if (HideinPlainSightRanks != 0)
			c.HideinPlainSight.AddModifier(new StatModifier(HideinPlainSightRanks, HideinPlainSightDescription, StatModType.Flat, this));
		if (ImprovedAimRanks != 0)
			c.ImprovedAim.AddModifier(new StatModifier(ImprovedAimRanks, ImprovedAimDescription, StatModType.Flat, this));
		if (ImprovedCriticalRanks != 0)
			c.ImprovedCritical.AddModifier(new StatModifier(ImprovedCriticalRanks, ImprovedCriticalDescription, StatModType.Flat, this));
		if (ImprovedDefenseRanks != 0)
			c.ImprovedDefense.AddModifier(new StatModifier(ImprovedDefenseRanks, ImprovedDefenseDescription, StatModType.Flat, this));
		if (ImprovedDisarmRanks != 0)
			c.ImprovedDisarm.AddModifier(new StatModifier(ImprovedDisarmRanks, ImprovedDisarmDescription, StatModType.Flat, this));
		if (ImprovedGrabRanks != 0)
			c.ImprovedGrab.AddModifier(new StatModifier(ImprovedGrabRanks, ImprovedGrabDescription, StatModType.Flat, this));
		if (ImprovedHoldRanks != 0)
			c.ImprovedHold.AddModifier(new StatModifier(ImprovedHoldRanks, ImprovedHoldDescription, StatModType.Flat, this));
		if (ImprovedInitiativeRanks != 0)
			c.ImprovedInitiative.AddModifier(new StatModifier(ImprovedInitiativeRanks, ImprovedInitiativeDescription, StatModType.Flat, this));
		if (ImprovedSmashRanks != 0)
			c.ImprovedSmash.AddModifier(new StatModifier(ImprovedSmashRanks, ImprovedSmashDescription, StatModType.Flat, this));
		if (ImprovedTripRanks != 0)
			c.ImprovedTrip.AddModifier(new StatModifier(ImprovedTripRanks, ImprovedTripDescription, StatModType.Flat, this));
		if (ImprovisedToolsRanks != 0)
			c.ImprovisedTools.AddModifier(new StatModifier(ImprovisedToolsRanks, ImprovisedToolsDescription, StatModType.Flat, this));
		if (ImprovisedWeaponRanks != 0)
			c.ImprovisedWeapon.AddModifier(new StatModifier(ImprovisedWeaponRanks, ImprovisedWeaponDescription, StatModType.Flat, this));
		if (InspireRanks != 0)
			c.Inspire.AddModifier(new StatModifier(InspireRanks, InspireDescription, StatModType.Flat, this));
		if (InstantUpRanks != 0)
			c.InstantUp.AddModifier(new StatModifier(InstantUpRanks, InstantUpDescription, StatModType.Flat, this));
		if (InterposeRanks != 0)
			c.Interpose.AddModifier(new StatModifier(InterposeRanks, InterposeDescription, StatModType.Flat, this));
		if (InventorRanks != 0)
			c.Inventor.AddModifier(new StatModifier(InventorRanks, InventorDescription, StatModType.Flat, this));
		if (JackofalltradesRanks != 0)
			c.Jackofalltrades.AddModifier(new StatModifier(JackofalltradesRanks, JackofalltradesDescription, StatModType.Flat, this));
		if (LanguagesRanks != 0)
			c.Languages.AddModifier(new StatModifier(LanguagesRanks, LanguagesDescription, StatModType.Flat, this));
		if (LeadershipRanks != 0)
			c.Leadership.AddModifier(new StatModifier(LeadershipRanks, LeadershipDescription, StatModType.Flat, this));
		if (LuckRanks != 0)
			c.Luck.AddModifier(new StatModifier(LuckRanks, LuckDescription, StatModType.Flat, this));
		if (MinionRanks != 0)
			c.Minion.AddModifier(new StatModifier(MinionRanks, MinionDescription, StatModType.Flat, this));
		if (MovebyActionRanks != 0)
			c.MovebyAction.AddModifier(new StatModifier(MovebyActionRanks, MovebyActionDescription, StatModType.Flat, this));
		if (PowerAttackRanks != 0)
			c.PowerAttack.AddModifier(new StatModifier(PowerAttackRanks, PowerAttackDescription, StatModType.Flat, this));
		if (PreciseAttackRanks != 0)
			c.PreciseAttack.AddModifier(new StatModifier(PreciseAttackRanks, PreciseAttackDescription, StatModType.Flat, this));
		if (ProneFightingRanks != 0)
			c.ProneFighting.AddModifier(new StatModifier(ProneFightingRanks, ProneFightingDescription, StatModType.Flat, this));
		if (QuickDrawRanks != 0)
			c.QuickDraw.AddModifier(new StatModifier(QuickDrawRanks, QuickDrawDescription, StatModType.Flat, this));
		if (RangedAttackRanks != 0)
			c.RangedAttack.AddModifier(new StatModifier(RangedAttackRanks, RangedAttackDescription, StatModType.Flat, this));
		if (RedirectRanks != 0)
			c.Redirect.AddModifier(new StatModifier(RedirectRanks, RedirectDescription, StatModType.Flat, this));
		if (RitualistRanks != 0)
			c.Ritualist.AddModifier(new StatModifier(RitualistRanks, RitualistDescription, StatModType.Flat, this));
		if (SecondChanceRanks != 0)
			c.SecondChance.AddModifier(new StatModifier(SecondChanceRanks, SecondChanceDescription, StatModType.Flat, this));
		if (SeizeInitiativeRanks != 0)
			c.SeizeInitiative.AddModifier(new StatModifier(SeizeInitiativeRanks, SeizeInitiativeDescription, StatModType.Flat, this));
		if (SetupRanks != 0)
			c.Setup.AddModifier(new StatModifier(SetupRanks, SetupDescription, StatModType.Flat, this));
		if (SidekickRanks != 0)
			c.Sidekick.AddModifier(new StatModifier(SidekickRanks, SidekickDescription, StatModType.Flat, this));
		if (SkillMastery0Ranks != 0)
			c.SkillMastery0.AddModifier(new StatModifier(SkillMastery0Ranks, SkillMastery0Description, StatModType.Flat, this));
		if (SkillMastery1Ranks != 0)
			c.SkillMastery1.AddModifier(new StatModifier(SkillMastery1Ranks, SkillMastery1Description, StatModType.Flat, this));
		if (SkillMastery2Ranks != 0)
			c.SkillMastery2.AddModifier(new StatModifier(SkillMastery2Ranks, SkillMastery2Description, StatModType.Flat, this));
		if (SkillMastery3Ranks != 0)
			c.SkillMastery3.AddModifier(new StatModifier(SkillMastery3Ranks, SkillMastery3Description, StatModType.Flat, this));
		if (StartleRanks != 0)
			c.Startle.AddModifier(new StatModifier(StartleRanks, StartleDescription, StatModType.Flat, this));
		if (TakedownRanks != 0)
			c.Takedown.AddModifier(new StatModifier(TakedownRanks, TakedownDescription, StatModType.Flat, this));
		if (TauntRanks != 0)
			c.Taunt.AddModifier(new StatModifier(TauntRanks, TauntDescription, StatModType.Flat, this));
		if (TeamworkRanks != 0)
			c.Teamwork.AddModifier(new StatModifier(TeamworkRanks, TeamworkDescription, StatModType.Flat, this));
		if (ThrowingMasteryRanks != 0)
			c.ThrowingMastery.AddModifier(new StatModifier(ThrowingMasteryRanks, ThrowingMasteryDescription, StatModType.Flat, this));
		if (TrackingRanks != 0)
			c.Tracking.AddModifier(new StatModifier(TrackingRanks, TrackingDescription, StatModType.Flat, this));
		if (TranceRanks != 0)
			c.Trance.AddModifier(new StatModifier(TranceRanks, TranceDescription, StatModType.Flat, this));
		if (UltimateEffortRanks != 0)
			c.UltimateEffort.AddModifier(new StatModifier(UltimateEffortRanks, UltimateEffortDescription, StatModType.Flat, this));
		if (UncannyDodgeRanks != 0)
			c.UncannyDodge.AddModifier(new StatModifier(UncannyDodgeRanks, UncannyDodgeDescription, StatModType.Flat, this));
		if (WeaponBindRanks != 0)
			c.WeaponBind.AddModifier(new StatModifier(WeaponBindRanks, WeaponBindDescription, StatModType.Flat, this));
		if (WeaponBreakRanks != 0)
			c.WeaponBreak.AddModifier(new StatModifier(WeaponBreakRanks, WeaponBreakDescription, StatModType.Flat, this));
		if (WellinformedRanks != 0)
			c.Wellinformed.AddModifier(new StatModifier(WellinformedRanks, WellinformedDescription, StatModType.Flat, this));

		if (AcrobaticsRanks != 0)
			c.Acrobatics.AddModifier(new StatModifier(AcrobaticsRanks, AcrobaticsDescription, StatModType.Flat, this));
		if (AthleticsRanks != 0)
			c.Athletics.AddModifier(new StatModifier(AthleticsRanks, AthleticsDescription, StatModType.Flat, this));
		if (CloseCombat0Ranks != 0)
			c.CloseCombat0.AddModifier(new StatModifier(CloseCombat0Ranks, CloseCombat0Description, StatModType.Flat, this));
		if (CloseCombat1Ranks != 0)
			c.CloseCombat1.AddModifier(new StatModifier(CloseCombat1Ranks, CloseCombat1Description, StatModType.Flat, this));
		if (CloseCombat2Ranks != 0)
			c.CloseCombat2.AddModifier(new StatModifier(CloseCombat2Ranks, CloseCombat2Description, StatModType.Flat, this));
		if (CloseCombat3Ranks != 0)
			c.CloseCombat3.AddModifier(new StatModifier(CloseCombat3Ranks, CloseCombat3Description, StatModType.Flat, this));
		if (DeceptionRanks != 0)
			c.Deception.AddModifier(new StatModifier(DeceptionRanks, DeceptionDescription, StatModType.Flat, this));
		if (Expertise0Ranks != 0)
			c.Expertise0.AddModifier(new StatModifier(Expertise0Ranks, Expertise0Description, StatModType.Flat, this));
		if (Expertise1Ranks != 0)
			c.Expertise1.AddModifier(new StatModifier(Expertise1Ranks, Expertise1Description, StatModType.Flat, this));
		if (Expertise2Ranks != 0)
			c.Expertise2.AddModifier(new StatModifier(Expertise2Ranks, Expertise2Description, StatModType.Flat, this));
		if (Expertise3Ranks != 0)
			c.Expertise3.AddModifier(new StatModifier(Expertise3Ranks, Expertise3Description, StatModType.Flat, this));
		if (InsightRanks != 0)
			c.Insight.AddModifier(new StatModifier(InsightRanks, InsightDescription, StatModType.Flat, this));
		if (IntimidationRanks != 0)
			c.Intimidation.AddModifier(new StatModifier(IntimidationRanks, IntimidationDescription, StatModType.Flat, this));
		if (InvestigationRanks != 0)
			c.Investigation.AddModifier(new StatModifier(InvestigationRanks, InvestigationDescription, StatModType.Flat, this));
		if (PerceptionRanks != 0)
			c.Perception.AddModifier(new StatModifier(PerceptionRanks, PerceptionDescription, StatModType.Flat, this));
		if (PersuasionRanks != 0)
			c.Persuasion.AddModifier(new StatModifier(PersuasionRanks, PersuasionDescription, StatModType.Flat, this));
		if (RangedCombat0Ranks != 0)
			c.RangedCombat0.AddModifier(new StatModifier(RangedCombat0Ranks, RangedCombat0Description, StatModType.Flat, this));
		if (RangedCombat1Ranks != 0)
			c.RangedCombat1.AddModifier(new StatModifier(RangedCombat1Ranks, RangedCombat1Description, StatModType.Flat, this));
		if (RangedCombat2Ranks != 0)
			c.RangedCombat2.AddModifier(new StatModifier(RangedCombat2Ranks, RangedCombat2Description, StatModType.Flat, this));
		if (RangedCombat3Ranks != 0)
			c.RangedCombat3.AddModifier(new StatModifier(RangedCombat3Ranks, RangedCombat3Description, StatModType.Flat, this));
		if (SleightOfHandRanks != 0)
			c.SleightOfHand.AddModifier(new StatModifier(SleightOfHandRanks, SleightOfHandDescription, StatModType.Flat, this));
		if (StealthRanks != 0)
			c.Stealth.AddModifier(new StatModifier(StealthRanks, StealthDescription, StatModType.Flat, this));
		if (TechnologyRanks != 0)
			c.Technology.AddModifier(new StatModifier(TechnologyRanks, TechnologyDescription, StatModType.Flat, this));
		if (TreatmentRanks != 0)
			c.Treatment.AddModifier(new StatModifier(TreatmentRanks, TreatmentDescription, StatModType.Flat, this));
		if (VehiclesRanks != 0)
			c.Vehicles.AddModifier(new StatModifier(VehiclesRanks, VehiclesDescription, StatModType.Flat, this));

		if (Power0Ranks != 0)
			c.Power0.AddModifier(new StatModifier(Power0Ranks, Power0Description, StatModType.Flat, this));
		if (Power1Ranks != 0)
			c.Power1.AddModifier(new StatModifier(Power1Ranks, Power1Description, StatModType.Flat, this));
		if (Power2Ranks != 0)
			c.Power2.AddModifier(new StatModifier(Power2Ranks, Power2Description, StatModType.Flat, this));
		if (Power3Ranks != 0)
			c.Power3.AddModifier(new StatModifier(Power3Ranks, Power3Description, StatModType.Flat, this));
		if (Power4Ranks != 0)
			c.Power4.AddModifier(new StatModifier(Power4Ranks, Power4Description, StatModType.Flat, this));
		if (Power5Ranks != 0)
			c.Power5.AddModifier(new StatModifier(Power5Ranks, Power5Description, StatModType.Flat, this));
		if (Power6Ranks != 0)
			c.Power6.AddModifier(new StatModifier(Power6Ranks, Power6Description, StatModType.Flat, this));
		if (Power7Ranks != 0)
			c.Power7.AddModifier(new StatModifier(Power7Ranks, Power7Description, StatModType.Flat, this));
		if (Power8Ranks != 0)
			c.Power8.AddModifier(new StatModifier(Power8Ranks, Power8Description, StatModType.Flat, this));
		if (Power9Ranks != 0)
			c.Power9.AddModifier(new StatModifier(Power9Ranks, Power9Description, StatModType.Flat, this));
		if (Power10Ranks != 0)
			c.Power10.AddModifier(new StatModifier(Power10Ranks, Power10Description, StatModType.Flat, this));
		if (Power11Ranks != 0)
			c.Power11.AddModifier(new StatModifier(Power11Ranks, Power11Description, StatModType.Flat, this));
	}

	public void Unequip(Character c)
	{
		c.Strength.RemoveAllModifiersFromSource(this);
		c.Agility.RemoveAllModifiersFromSource(this);
		c.Fighting.RemoveAllModifiersFromSource(this);
		c.Awareness.RemoveAllModifiersFromSource(this);
		c.Stamina.RemoveAllModifiersFromSource(this);
		c.Dexterity.RemoveAllModifiersFromSource(this);
		c.Intelligence.RemoveAllModifiersFromSource(this);
		c.Presence.RemoveAllModifiersFromSource(this);
		c.Dodge.RemoveAllModifiersFromSource(this);
		c.Parry.RemoveAllModifiersFromSource(this);
		c.Fortitude.RemoveAllModifiersFromSource(this);
		c.Toughness.RemoveAllModifiersFromSource(this);
		c.Will.RemoveAllModifiersFromSource(this);

		c.AccurateAttack.RemoveAllModifiersFromSource(this);
		c.AgileFeint.RemoveAllModifiersFromSource(this);
		c.AlloutAttack.RemoveAllModifiersFromSource(this);
		c.AnimalEmpathy.RemoveAllModifiersFromSource(this);
		c.Artificer.RemoveAllModifiersFromSource(this);
		c.Assessment.RemoveAllModifiersFromSource(this);
		c.Attractive.RemoveAllModifiersFromSource(this);
		c.BeginnersLuck.RemoveAllModifiersFromSource(this);
		c.Benefit0.RemoveAllModifiersFromSource(this);
		//c.Benefit0Description.RemoveAllModifiersFromSource(this);
		c.Benefit1.RemoveAllModifiersFromSource(this);
		//c.Benefit1Description.RemoveAllModifiersFromSource(this);
		c.Benefit2.RemoveAllModifiersFromSource(this);
		//c.Benefit2Description.RemoveAllModifiersFromSource(this);
		c.Benefit3.RemoveAllModifiersFromSource(this);
		//c.Benefit3Description.RemoveAllModifiersFromSource(this);
		c.Chokehold.RemoveAllModifiersFromSource(this);
		c.CloseAttack.RemoveAllModifiersFromSource(this);
		c.Connected.RemoveAllModifiersFromSource(this);
		c.Contacts.RemoveAllModifiersFromSource(this);
		c.Daze.RemoveAllModifiersFromSource(this);
		c.DefensiveAttack.RemoveAllModifiersFromSource(this);
		c.DefensiveRoll.RemoveAllModifiersFromSource(this);
		c.Diehard.RemoveAllModifiersFromSource(this);
		c.EideticMemory.RemoveAllModifiersFromSource(this);
		c.EquipmentAdvantage.RemoveAllModifiersFromSource(this);
		//c.EquipmentDescription.RemoveAllModifiersFromSource(this);
		c.Evasion.RemoveAllModifiersFromSource(this);
		c.ExtraordinaryEffort.RemoveAllModifiersFromSource(this);
		c.Fascinate.RemoveAllModifiersFromSource(this);
		c.FastGrab.RemoveAllModifiersFromSource(this);
		c.FavoredEnvironment.RemoveAllModifiersFromSource(this);
		c.FavoredFoe.RemoveAllModifiersFromSource(this);
		c.Fearless.RemoveAllModifiersFromSource(this);
		c.GrabbingFinesse.RemoveAllModifiersFromSource(this);
		c.GreatEndurance.RemoveAllModifiersFromSource(this);
		c.HideinPlainSight.RemoveAllModifiersFromSource(this);
		c.ImprovedAim.RemoveAllModifiersFromSource(this);
		c.ImprovedCritical.RemoveAllModifiersFromSource(this);
		c.ImprovedDefense.RemoveAllModifiersFromSource(this);
		c.ImprovedDisarm.RemoveAllModifiersFromSource(this);
		c.ImprovedGrab.RemoveAllModifiersFromSource(this);
		c.ImprovedHold.RemoveAllModifiersFromSource(this);
		c.ImprovedInitiative.RemoveAllModifiersFromSource(this);
		c.ImprovedSmash.RemoveAllModifiersFromSource(this);
		c.ImprovedTrip.RemoveAllModifiersFromSource(this);
		c.ImprovisedTools.RemoveAllModifiersFromSource(this);
		c.ImprovisedWeapon.RemoveAllModifiersFromSource(this);
		c.Inspire.RemoveAllModifiersFromSource(this);
		c.InstantUp.RemoveAllModifiersFromSource(this);
		c.Interpose.RemoveAllModifiersFromSource(this);
		c.Inventor.RemoveAllModifiersFromSource(this);
		c.Jackofalltrades.RemoveAllModifiersFromSource(this);
		c.Languages.RemoveAllModifiersFromSource(this);
		//c.LanguagesDescription.RemoveAllModifiersFromSource(this);
		c.Leadership.RemoveAllModifiersFromSource(this);
		c.Luck.RemoveAllModifiersFromSource(this);
		c.Minion.RemoveAllModifiersFromSource(this);
		c.MovebyAction.RemoveAllModifiersFromSource(this);
		c.PowerAttack.RemoveAllModifiersFromSource(this);
		c.PreciseAttack.RemoveAllModifiersFromSource(this);
		c.ProneFighting.RemoveAllModifiersFromSource(this);
		c.QuickDraw.RemoveAllModifiersFromSource(this);
		c.RangedAttack.RemoveAllModifiersFromSource(this);
		c.Redirect.RemoveAllModifiersFromSource(this);
		c.Ritualist.RemoveAllModifiersFromSource(this);
		c.SecondChance.RemoveAllModifiersFromSource(this);
		c.SeizeInitiative.RemoveAllModifiersFromSource(this);
		c.Setup.RemoveAllModifiersFromSource(this);
		c.Sidekick.RemoveAllModifiersFromSource(this);
		c.SkillMastery0.RemoveAllModifiersFromSource(this);
		c.SkillMastery1.RemoveAllModifiersFromSource(this);
		c.SkillMastery2.RemoveAllModifiersFromSource(this);
		c.SkillMastery3.RemoveAllModifiersFromSource(this);
		//c.SkillMasteryDescription.RemoveAllModifiersFromSource(this);
		c.Startle.RemoveAllModifiersFromSource(this);
		c.Takedown.RemoveAllModifiersFromSource(this);
		c.Taunt.RemoveAllModifiersFromSource(this);
		c.Teamwork.RemoveAllModifiersFromSource(this);
		c.ThrowingMastery.RemoveAllModifiersFromSource(this);
		c.Tracking.RemoveAllModifiersFromSource(this);
		c.Trance.RemoveAllModifiersFromSource(this);
		c.UltimateEffort.RemoveAllModifiersFromSource(this);
		//c.UltimateEffortDescription.RemoveAllModifiersFromSource(this);
		c.UncannyDodge.RemoveAllModifiersFromSource(this);
		c.WeaponBind.RemoveAllModifiersFromSource(this);
		c.WeaponBreak.RemoveAllModifiersFromSource(this);
		c.Wellinformed.RemoveAllModifiersFromSource(this);

		c.Acrobatics.RemoveAllModifiersFromSource(this);
		c.Athletics.RemoveAllModifiersFromSource(this);
		c.CloseCombat0.RemoveAllModifiersFromSource(this);
		c.CloseCombat1.RemoveAllModifiersFromSource(this);
		c.CloseCombat2.RemoveAllModifiersFromSource(this);
		c.CloseCombat3.RemoveAllModifiersFromSource(this);
		c.Deception.RemoveAllModifiersFromSource(this);
		c.Expertise0.RemoveAllModifiersFromSource(this);
		c.Expertise1.RemoveAllModifiersFromSource(this);
		c.Expertise2.RemoveAllModifiersFromSource(this);
		c.Expertise3.RemoveAllModifiersFromSource(this);
		c.Insight.RemoveAllModifiersFromSource(this);
		c.Intimidation.RemoveAllModifiersFromSource(this);
		c.Investigation.RemoveAllModifiersFromSource(this);
		c.Perception.RemoveAllModifiersFromSource(this);
		c.Persuasion.RemoveAllModifiersFromSource(this);
		c.RangedCombat0.RemoveAllModifiersFromSource(this);
		c.RangedCombat1.RemoveAllModifiersFromSource(this);
		c.RangedCombat2.RemoveAllModifiersFromSource(this);
		c.RangedCombat3.RemoveAllModifiersFromSource(this);
		c.SleightOfHand.RemoveAllModifiersFromSource(this);
		c.Stealth.RemoveAllModifiersFromSource(this);
		c.Technology.RemoveAllModifiersFromSource(this);
		c.Treatment.RemoveAllModifiersFromSource(this);
		c.Vehicles.RemoveAllModifiersFromSource(this);

		c.Power0.RemoveAllModifiersFromSource(this);
		c.Power1.RemoveAllModifiersFromSource(this);
		c.Power2.RemoveAllModifiersFromSource(this);
		c.Power3.RemoveAllModifiersFromSource(this);
		c.Power4.RemoveAllModifiersFromSource(this);
		c.Power5.RemoveAllModifiersFromSource(this);
		c.Power6.RemoveAllModifiersFromSource(this);
		c.Power7.RemoveAllModifiersFromSource(this);
		c.Power8.RemoveAllModifiersFromSource(this);
		c.Power9.RemoveAllModifiersFromSource(this);
		c.Power10.RemoveAllModifiersFromSource(this);
		c.Power11.RemoveAllModifiersFromSource(this);
	}
}