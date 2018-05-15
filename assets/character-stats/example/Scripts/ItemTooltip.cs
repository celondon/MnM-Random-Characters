using UnityEngine;
using UnityEngine.UI;
using System.Text;
using Kryz.CharacterStats;

public class ItemTooltip : MonoBehaviour
{
	public static ItemTooltip Instance;

	[SerializeField] Text nameText;
	[SerializeField] Text slotTypeText;
	[SerializeField] Text itemDesciptionText;
	[SerializeField] Text statsText;

	private StringBuilder sb = new StringBuilder();

	private void Awake()
	{
		if (Instance == null) {
			Instance = this;
		} else {
			Destroy(this);
		}
		gameObject.SetActive(false);
	}

	public void ShowTooltip(Item itemToShow)
	{
		if (!(itemToShow is EquippableItem))
		{
			Debug.Log("Not an Equippable Item");
			return;
		}

		EquippableItem item = (EquippableItem)itemToShow;

		gameObject.SetActive(true);

		nameText.text = item.ItemName;
		slotTypeText.text = item.EquipmentType.ToString();
		itemDesciptionText.text = item.ItemDescription;

		sb.Length = 0;

		AddStatText(item.StrengthBonus, " Strength");
		AddStatText(item.AgilityBonus, " Agility");
		AddStatText(item.FightingBonus, " Fighting");
		AddStatText(item.AwarenessBonus, " Awareness");
		AddStatText(item.StaminaBonus, " Stamina");
		AddStatText(item.DexterityBonus, " Dexterity");
		AddStatText(item.IntelligenceBonus, " Intelligence");
		AddStatText(item.PresenceBonus, " Presence");
		AddStatText(item.DodgeBonus, " Dodge");
		AddStatText(item.ParryBonus, " Parry");
		AddStatText(item.FortitudeBonus, " Fortitude");
		AddStatText(item.ToughnessBonus, " Toughness");
		AddStatText(item.WillBonus, " Will");

		AddStatText(item.AccurateAttackRanks, " Accurate Attack");
		AddStatText(item.AgileFeintRanks, " Agile Feint");
		AddStatText(item.AlloutAttackRanks, " Allout Attack");
		AddStatText(item.AnimalEmpathyRanks, " Animal Empathy");
		AddStatText(item.ArtificerRanks, " Artificer");
		AddStatText(item.AssessmentRanks, " Assessment");
		AddStatText(item.AttractiveRanks, " Attractive");
		AddStatText(item.BeginnersLuckRanks, " Beginners Luck");
		AddStatText(item.Benefit0Ranks, " Benefit");
		//AddStatText(item.BenefitDescriptionRanks, " Benefit Description");
		AddStatText(item.Benefit1Ranks, " Benefit");
		AddStatText(item.Benefit2Ranks, " Benefit");
		AddStatText(item.Benefit3Ranks, " Benefit");
		AddStatText(item.ChokeholdRanks, " Chokehold");
		AddStatText(item.CloseAttackRanks, " Close Attack");
		AddStatText(item.ConnectedRanks, " Connected");
		AddStatText(item.ContactsRanks, " Contacts");
		AddStatText(item.DazeRanks, " Daze");
		AddStatText(item.DefensiveAttackRanks, " Defensive Attack");
		AddStatText(item.DefensiveRollRanks, " Defensive Roll");
		AddStatText(item.DiehardRanks, " Diehard");
		AddStatText(item.EideticMemoryRanks, " Eidetic Memory");
		AddStatText(item.EquipmentAdvantageRanks, " Equipment Advantage");
		//AddStatText(item.EquipmentDescriptionRanks, " Equipment Description");
		AddStatText(item.EvasionRanks, " Evasion");
		AddStatText(item.ExtraordinaryEffortRanks, " Extraordinary Effort");
		AddStatText(item.FascinateRanks, " Fascinate");
		AddStatText(item.FastGrabRanks, " Fast Grab");
		AddStatText(item.FavoredEnvironmentRanks, " Favored Environment");
		AddStatText(item.FavoredFoeRanks, " Favored Foe");
		AddStatText(item.FearlessRanks, " Fearless");
		AddStatText(item.GrabbingFinesseRanks, " Grabbing Finesse");
		AddStatText(item.GreatEnduranceRanks, " Great Endurance");
		AddStatText(item.HideinPlainSightRanks, " Hidein Sight");
		AddStatText(item.ImprovedAimRanks, " Improved Aim");
		AddStatText(item.ImprovedCriticalRanks, " Improved Critical");
		AddStatText(item.ImprovedDefenseRanks, " Improved Defense");
		AddStatText(item.ImprovedDisarmRanks, " Improved Disarm");
		AddStatText(item.ImprovedGrabRanks, " Improved Grab");
		AddStatText(item.ImprovedHoldRanks, " Improved Hold");
		AddStatText(item.ImprovedInitiativeRanks, " Improved Initiative");
		AddStatText(item.ImprovedSmashRanks, " Improved Smash");
		AddStatText(item.ImprovedTripRanks, " Improved Trip");
		AddStatText(item.ImprovisedToolsRanks, " Improvised Tools");
		AddStatText(item.ImprovisedWeaponRanks, " Improvised Weapon");
		AddStatText(item.InspireRanks, " Inspire");
		AddStatText(item.InstantUpRanks, " Instant Up");
		AddStatText(item.InterposeRanks, " Interpose");
		AddStatText(item.InventorRanks, " Inventor");
		AddStatText(item.JackofalltradesRanks, " Jack of all trades");
		AddStatText(item.LanguagesRanks, " Languages");
		//AddStatText(item.LanguagesDescriptionRanks, " Languages Description");
		AddStatText(item.LeadershipRanks, " Leadership");
		AddStatText(item.LuckRanks, " Luck");
		AddStatText(item.MinionRanks, " Minion");
		AddStatText(item.MovebyActionRanks, " Move by Action");
		AddStatText(item.PowerAttackRanks, " Power Attack");
		AddStatText(item.PreciseAttackRanks, " Precise Attack");
		AddStatText(item.ProneFightingRanks, " Prone Fighting");
		AddStatText(item.QuickDrawRanks, " Quick Draw");
		AddStatText(item.RangedAttackRanks, " Ranged Attack");
		AddStatText(item.RedirectRanks, " Redirect");
		AddStatText(item.RitualistRanks, " Ritualist");
		AddStatText(item.SecondChanceRanks, " Second Chance");
		AddStatText(item.SeizeInitiativeRanks, " Seize Initiative");
		AddStatText(item.SetupRanks, " Setup");
		AddStatText(item.SidekickRanks, " Sidekick");
		AddStatText(item.SkillMastery0Ranks, " Skill Mastery");
		AddStatText(item.SkillMastery1Ranks, " Skill Mastery");
		AddStatText(item.SkillMastery2Ranks, " Skill Mastery");
		AddStatText(item.SkillMastery3Ranks, " Skill Mastery");
		//AddStatText(item.SkillMasteryDescriptionRanks, " Skill Description");
		AddStatText(item.StartleRanks, " Startle");
		AddStatText(item.TakedownRanks, " Takedown");
		AddStatText(item.TauntRanks, " Taunt");
		AddStatText(item.TeamworkRanks, " Teamwork");
		AddStatText(item.ThrowingMasteryRanks, " Throwing Mastery");
		AddStatText(item.TrackingRanks, " Tracking");
		AddStatText(item.TranceRanks, " Trance");
		AddStatText(item.UltimateEffortRanks, " Ultimate Effort");
		AddStatText(item.UncannyDodgeRanks, " Uncanny Dodge");
		AddStatText(item.WeaponBindRanks, " Weapon Bind");
		AddStatText(item.WeaponBreakRanks, " Weapon Break");
		AddStatText(item.WellinformedRanks, " Well Informed");

		AddStatText(item.AcrobaticsRanks, " Acrobatics");
		AddStatText(item.AthleticsRanks, " Athletics");
		AddStatText(item.CloseCombat0Ranks, " CloseCombat0");
		AddStatText(item.CloseCombat1Ranks, " CloseCombat1");
		AddStatText(item.CloseCombat2Ranks, " CloseCombat2");
		AddStatText(item.CloseCombat3Ranks, " CloseCombat3");
		AddStatText(item.DeceptionRanks, " Deception");
		AddStatText(item.Expertise0Ranks, " Expertise0");
		AddStatText(item.Expertise1Ranks, " Expertise1");
		AddStatText(item.Expertise2Ranks, " Expertise2");
		AddStatText(item.Expertise3Ranks, " Expertise3");
		AddStatText(item.InsightRanks, " Insight");
		AddStatText(item.IntimidationRanks, " Intimidation");
		AddStatText(item.InvestigationRanks, " Investigation");
		AddStatText(item.PerceptionRanks, " Perception");
		AddStatText(item.PersuasionRanks, " Persuasion");
		AddStatText(item.RangedCombat0Ranks, " RangedCombat0");
		AddStatText(item.RangedCombat1Ranks, " RangedCombat1");
		AddStatText(item.RangedCombat2Ranks, " RangedCombat2");
		AddStatText(item.RangedCombat3Ranks, " RangedCombat3");
		AddStatText(item.SleightOfHandRanks, " SleightOfHand");
		AddStatText(item.StealthRanks, " Stealth");
		AddStatText(item.TechnologyRanks, " Technology");
		AddStatText(item.TreatmentRanks, " Treatment");
		AddStatText(item.VehiclesRanks, " Vehicles");

		statsText.text = sb.ToString();
	}

	public void HideTooltip()
	{
		gameObject.SetActive(false);
	}

	private void AddStatText(float statBonus, string statName)
	{
		if (statBonus != 0)
		{
			if (sb.Length > 0)
				sb.AppendLine();

			if (statBonus > 0)
				sb.Append("+");

			sb.Append(statBonus);
			sb.Append(statName);
		}
	}

//	public Vector3 offset;
//	// Update is called once per frame
//	void Update () 
//	{
//		transform.position = Input.mousePosition + offset;
//	}
}