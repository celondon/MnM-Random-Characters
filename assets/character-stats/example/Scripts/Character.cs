using UnityEngine;
using UnityEngine.UI;
using Kryz.CharacterStats;

public class Character : MonoBehaviour
{
	public static Character character;
	//[SerializeField] Character[] statArray;

	//Attributes
	public CharacterStat Strength;
	public CharacterStat Agility;
	public CharacterStat Fighting;
	public CharacterStat Awareness;
	public CharacterStat Stamina;
	public CharacterStat Dexterity;
	public CharacterStat Intelligence;
	public CharacterStat Presence;
	public CharacterStat Dodge;
	public CharacterStat Parry;
	public CharacterStat Fortitude;
	public CharacterStat Toughness;
	public CharacterStat Will;

	//Advantages
	public CharacterStat AccurateAttack;
	public CharacterStat AgileFeint;
	public CharacterStat AlloutAttack;
	public CharacterStat AnimalEmpathy;
	public CharacterStat Artificer;
	public CharacterStat Assessment;
	public CharacterStat Attractive;
	public CharacterStat BeginnersLuck;
	public CharacterStat Benefit0;
	//public CharacterStat Benefit0Description;
	public CharacterStat Benefit1;
	//public CharacterStat Benefit1Description;
	public CharacterStat Benefit2;
	//public CharacterStat Benefit2Description;
	public CharacterStat Benefit3;
	//public CharacterStat Benefit3Description;
	public CharacterStat Chokehold;
	public CharacterStat CloseAttack;
	public CharacterStat Connected;
	public CharacterStat Contacts;
	public CharacterStat Daze;
	public CharacterStat DefensiveAttack;
	public CharacterStat DefensiveRoll;
	public CharacterStat Diehard;
	public CharacterStat EideticMemory;
	public CharacterStat EquipmentAdvantage;
	//public CharacterStat EquipmentDescription;
	public CharacterStat Evasion;
	public CharacterStat ExtraordinaryEffort;
	public CharacterStat Fascinate;
	public CharacterStat FastGrab;
	public CharacterStat FavoredEnvironment;
	public CharacterStat FavoredFoe;
	public CharacterStat Fearless;
	public CharacterStat GrabbingFinesse;
	public CharacterStat GreatEndurance;
	public CharacterStat HideinPlainSight;
	public CharacterStat ImprovedAim;
	public CharacterStat ImprovedCritical;
	public CharacterStat ImprovedDefense;
	public CharacterStat ImprovedDisarm;
	public CharacterStat ImprovedGrab;
	public CharacterStat ImprovedHold;
	public CharacterStat ImprovedInitiative;
	public CharacterStat ImprovedSmash;
	public CharacterStat ImprovedTrip;
	public CharacterStat ImprovisedTools;
	public CharacterStat ImprovisedWeapon;
	public CharacterStat Inspire;
	public CharacterStat InstantUp;
	public CharacterStat Interpose;
	public CharacterStat Inventor;
	public CharacterStat Jackofalltrades;
	public CharacterStat Languages;
	//public CharacterStat LanguagesDescription;
	public CharacterStat Leadership;
	public CharacterStat Luck;
	public CharacterStat Minion;
	public CharacterStat MovebyAction;
	public CharacterStat PowerAttack;
	public CharacterStat PreciseAttack;
	public CharacterStat ProneFighting;
	public CharacterStat QuickDraw;
	public CharacterStat RangedAttack;
	public CharacterStat Redirect;
	public CharacterStat Ritualist;
	public CharacterStat SecondChance;
	public CharacterStat SeizeInitiative;
	public CharacterStat Setup;
	public CharacterStat Sidekick;
	public CharacterStat SkillMastery0;
	public CharacterStat SkillMastery1;
	public CharacterStat SkillMastery2;
	public CharacterStat SkillMastery3;
	//public CharacterStat SkillMasteryDescription;
	public CharacterStat Startle;
	public CharacterStat Takedown;
	public CharacterStat Taunt;
	public CharacterStat Teamwork;
	public CharacterStat ThrowingMastery;
	public CharacterStat Tracking;
	public CharacterStat Trance;
	public CharacterStat UltimateEffort;
//	public CharacterStat UltimateEffortDescription;
	public CharacterStat UncannyDodge;
	public CharacterStat WeaponBind;
	public CharacterStat WeaponBreak;
	public CharacterStat Wellinformed;

	//skills
	public CharacterStat Acrobatics;
	public CharacterStat Athletics;
	public CharacterStat CloseCombat0;
	public CharacterStat CloseCombat1;
	public CharacterStat CloseCombat2;
	public CharacterStat CloseCombat3;
	public CharacterStat Deception;
	public CharacterStat Expertise0;
	public CharacterStat Expertise1;
	public CharacterStat Expertise2;
	public CharacterStat Expertise3;
	public CharacterStat Insight;
	public CharacterStat Intimidation;
	public CharacterStat Investigation;
	public CharacterStat Perception;
	public CharacterStat Persuasion;
	public CharacterStat RangedCombat0;
	public CharacterStat RangedCombat1;
	public CharacterStat RangedCombat2;
	public CharacterStat RangedCombat3;
	public CharacterStat SleightOfHand;
	public CharacterStat Stealth;
	public CharacterStat Technology;
	public CharacterStat Treatment;
	public CharacterStat Vehicles;

	//powers
	public CharacterStat Power0;
	public CharacterStat Power1;
	public CharacterStat Power2;
	public CharacterStat Power3;
	public CharacterStat Power4;
	public CharacterStat Power5;
	public CharacterStat Power6;
	public CharacterStat Power7;
	public CharacterStat Power8;
	public CharacterStat Power9;
	public CharacterStat Power10;
	public CharacterStat Power11;

	public string nextTable;
	public string currentTable;
	public string previousTable;
	public EquippableItem lastItem;
	public string lastItemString;
	public string familyTree;
	public string subFamily;

	[SerializeField] Archetype archetype;
	[SerializeField] EquipmentPanel equipmentPanel;
	[SerializeField] StatsPanel statPanel;
	[SerializeField] AdvantagePanel advantagePanel;
	[SerializeField] SkillPanel skillPanel;
	[SerializeField] PowerPanel powerPanel;
	[SerializeField] ItemTooltip itemTooltip;
	[SerializeField] Image draggableItem;
	//[SerializeField] Image destinationSlotImage;

	private ItemSlot draggedSlot;

	private void OnValidate()
	{
		if (itemTooltip == null)
			itemTooltip = FindObjectOfType<ItemTooltip>();
	}

	private void Awake()
	{
		if (character == null)
		{
			DontDestroyOnLoad(gameObject);
			character = this;
		}
		else if (character != this)
		{
			Destroy(gameObject);
		}

		statPanel.SetStats(Strength, Agility, Fighting, Awareness, Stamina, Dexterity, Intelligence, Presence, Dodge, Parry, Fortitude, Toughness, Will);
		statPanel.UpdateStatValues();

		advantagePanel.SetStats(AccurateAttack, AgileFeint, AlloutAttack, AnimalEmpathy, Artificer, Assessment, Attractive, BeginnersLuck, Benefit0, Benefit1, Benefit2, Benefit3, Chokehold, CloseAttack, Connected, Contacts, Daze, DefensiveAttack, DefensiveRoll, Diehard, EideticMemory, EquipmentAdvantage, Evasion, ExtraordinaryEffort, Fascinate, FastGrab, FavoredEnvironment, FavoredFoe, Fearless, GrabbingFinesse, GreatEndurance, HideinPlainSight, ImprovedAim, ImprovedCritical, ImprovedDefense, ImprovedDisarm, ImprovedGrab, ImprovedHold, ImprovedInitiative, ImprovedSmash, ImprovedTrip, ImprovisedTools, ImprovisedWeapon, Inspire, InstantUp, Interpose, Inventor, Jackofalltrades, Languages, Leadership, Luck, Minion, MovebyAction, PowerAttack, PreciseAttack, ProneFighting, QuickDraw, RangedAttack, Redirect, Ritualist, SecondChance, SeizeInitiative, Setup, Sidekick, SkillMastery0, SkillMastery1, SkillMastery2, SkillMastery3, Startle, Takedown, Taunt, Teamwork, ThrowingMastery, Tracking, Trance, UltimateEffort, UncannyDodge, WeaponBind, WeaponBreak, Wellinformed);
		advantagePanel.UpdateStatValues();

		skillPanel.SetStats(Acrobatics, Athletics, CloseCombat0, CloseCombat1, CloseCombat2, CloseCombat3, Deception, Expertise0, Expertise1, Expertise2, Expertise3, Insight, Intimidation, Investigation, Perception, Persuasion, RangedCombat0, RangedCombat1, RangedCombat2, RangedCombat3, SleightOfHand, Stealth, Technology, Treatment, Vehicles);
		advantagePanel.UpdateStatValues();

		powerPanel.SetStats(Power0, Power1, Power2, Power3, Power4, Power5, Power6, Power7, Power8, Power9, Power10, Power11);
		powerPanel.UpdateStatValues();
		//powerPanel.UpdateStatDescriptions();

		// Setup Events:
		// Right Click:
		archetype.OnRightClickEvent += Equip;
		equipmentPanel.OnRightClickEvent += Unequip;
		// Show Tooltip:
		archetype.OnPointerEnterEvent += ShowToolTip;
		equipmentPanel.OnPointerEnterEvent += ShowToolTip;
		// Hide Tooltip:
		archetype.OnPointerExitEvent += HideToolTip;
		equipmentPanel.OnPointerExitEvent += HideToolTip;
		//// Begin Drag
		//archetype.OnBeginDragEvent += BeginDrag;
		//equipmentPanel.OnBeginDragEvent+= BeginDrag;
		//// End Drag
		//archetype.OnEndDragEvent += EndDrag;
		//equipmentPanel.OnEndDragEvent += EndDrag;
		//// Drag
		//archetype.OnDragEvent += Drag;
		//equipmentPanel.OnDragEvent += Drag;
		//// Drop
		//archetype.OnDropEvent += Drop;
		//equipmentPanel.OnDropEvent += Drop;
		
		currentTable = "Archetypes";
	}

	private void Equip(ItemSlot itemSlot)
	{
		EquippableItem equippableItem = itemSlot.Item as EquippableItem;
		if (equippableItem != null)
			Equip(equippableItem);
	}

	private void Unequip(ItemSlot itemSlot)
	{
		EquippableItem equippableItem = itemSlot.Item as EquippableItem;
		if (equippableItem != null)
			Unequip(equippableItem);
	}

	private void ShowToolTip(ItemSlot itemSlot)
	{
		EquippableItem equippableItem = itemSlot.Item as EquippableItem;
		if (equippableItem != null)
		{
			itemTooltip.ShowTooltip(equippableItem);
		}
	}

	private void HideToolTip(ItemSlot itemSlot)
	{
		itemTooltip.HideTooltip();
	}

	//private void BeginDrag(ItemSlot itemSlot)
	//{
	//	if (itemSlot.Item != null)
	//	{
	//		draggedSlot = itemSlot;
	//		draggableItem.sprite = draggedSlot.Item.Icon;
	//		draggableItem.transform.position = Input.mousePosition;
	//		draggableItem.enabled = true;
			
	//		if(itemSlot.Item is EquippableItem)
	//			for(int i=0; i<EquipmentPanel.quip
			
	//		//destinationSlot = itemSlot.

	//		//	destinationSlotImage.color = destinationHighlight;
	//	}
	//}

	//private void EndDrag(ItemSlot itemSlot)
	//{
	//	draggedSlot = null;
	//	draggableItem.enabled = false;
	//	//destinationSlotImage.color = destinationNormal;
	//}

	//private void Drag(ItemSlot itemSlot)
	//{
	//	if (draggableItem.enabled)
	//	{
	//		draggableItem.transform.position = Input.mousePosition;
	//	}
	//}

	//private void Drop(ItemSlot dropItemSlot)
	//{
	//	if (dropItemSlot.CanReceiveItem(draggedSlot.Item) && draggedSlot.CanReceiveItem(dropItemSlot.Item))
	//	{
	//		EquippableItem dragItem = draggedSlot.Item as EquippableItem;
	//		EquippableItem dropItem = dropItemSlot.Item as EquippableItem;

	//		if (draggedSlot is EquipmentSlot)
	//		{
	//			if (dragItem != null) dragItem.Unequip(this);
	//			if (dropItem != null)
	//			{
	//				nextTable = dropItem.NextTable;
	//				familyTree = dropItem.Family;
	//				archetype.nextButton.enabled = true;
	//				dropItem.Equip(this);
	//			}
	//		}

	//		if (dropItemSlot is EquipmentSlot)
	//		{
	//			if (dragItem != null)
	//			{
	//				nextTable = dragItem.NextTable;
	//				familyTree = dragItem.Family;
	//				archetype.nextButton.enabled = true;
	//			}
	//			dragItem.Equip(this);
	//			if (dropItem != null)
	//			{
	//				nextTable = dropItem.NextTable;
	//				familyTree = dropItem.Family;
	//				archetype.nextButton.enabled = true;
	//				dropItem.Unequip(this);
	//			}
				
	//		}
			
	//		statPanel.UpdateStatValues();
	//		advantagePanel.UpdateStatValues();
	//		skillPanel.UpdateStatValues();

	//		Item draggedItem = draggedSlot.Item;
	//		draggedSlot.Item = dropItemSlot.Item;
	//		dropItemSlot.Item = draggedItem;
	//	}
	//}

	public void Equip(EquippableItem item)
	{
		if (archetype.RemoveItem(item)) 
		{
			EquippableItem previousItem;
			if (equipmentPanel.AddItem(item, out previousItem)) 
			{
				if (previousItem != null) 
				{
					archetype.AddItem (previousItem);
					previousItem.Unequip(this);
					statPanel.UpdateStatValues();
				}
				item.Equip(this);
				lastItem = item;
				lastItemString = item.ToString();
				//previousTable = item.Parent;
				nextTable = item.NextTable;
				familyTree = item.Family;
				subFamily = item.subFamily;

				archetype.nextButton.enabled = true;
				statPanel.UpdateStatValues();
				advantagePanel.UpdateStatValues();
				skillPanel.UpdateStatValues();
				powerPanel.UpdateStatValues();
				//powerPanel.UpdateStatDescriptions();
			} 
			else 
			{
				archetype.AddItem(item);
			}
		}
	}
	
	public void Unequip(EquippableItem item)
	{
		if (!archetype.IsFull() && equipmentPanel.RemoveItem(item)) 
		{
			nextTable = item.CurrentTable;
			archetype.nextButton.enabled = false;
			item.Unequip(this);
			statPanel.UpdateStatValues ();
			advantagePanel.UpdateStatValues();
			archetype.AddItem(item);
			skillPanel.UpdateStatValues();
			powerPanel.UpdateStatValues();
			//powerPanel.UpdateStatDescriptions();
		}
	}
}