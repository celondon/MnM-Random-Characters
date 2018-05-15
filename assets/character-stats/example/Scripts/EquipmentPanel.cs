using System;
using UnityEngine;
using UnityEngine.UI;
using Kryz.CharacterStats;


public class EquipmentPanel : MonoBehaviour
{
	[SerializeField] Transform equipmentSlotsParent;
	[SerializeField] EquipmentSlot[] equipmentSlots;
	[SerializeField] Text[] nameText;
	[SerializeField] StatsPanel statPanel;

	public event Action<ItemSlot> OnPointerEnterEvent;
	public event Action<ItemSlot> OnPointerExitEvent;
	public event Action<ItemSlot> OnRightClickEvent;
	//public event Action<ItemSlot> OnBeginDragEvent;
	//public event Action<ItemSlot> OnEndDragEvent;
	//public event Action<ItemSlot> OnDragEvent;
	//public event Action<ItemSlot> OnDropEvent;

	public Character character;

	public void Start()
	{
		for (int i = 0; i < equipmentSlots.Length; i++) 
		{
			equipmentSlots[i].OnPointerEnterEvent += OnPointerEnterEvent;
			equipmentSlots[i].OnPointerExitEvent += OnPointerExitEvent;
			equipmentSlots[i].OnRightClickEvent += OnRightClickEvent;
			//equipmentSlots[i].OnBeginDragEvent += OnBeginDragEvent;
			//equipmentSlots[i].OnEndDragEvent += OnEndDragEvent;
			//equipmentSlots[i].OnDragEvent += OnDragEvent;
			//equipmentSlots[i].OnDropEvent += OnDropEvent;
		}
	}

	public void OnValidate()
	{
		equipmentSlots = equipmentSlotsParent.GetComponentsInChildren<EquipmentSlot>();
		nameText = equipmentSlotsParent.GetComponentsInChildren<Text>();
	}

	//public void ListEquipped()
	//{
	//	for (int i = 0; i < equipmentSlots.Length; i++)
	//	{
	//		if (equipmentSlots[i].Item != null)
	//		{
	//			print("Item Equipped " + i + " " + equipmentSlots[i].Item.ItemDescription);
	//		}
	//	}
	//}

	public void ClearEquipped()
	{
		for (int i = 0; i < equipmentSlots.Length; i++)
		{
			if (equipmentSlots[i].Item != null)
			{
				character.Unequip((EquippableItem)equipmentSlots[i].Item);
				equipmentSlots[i].Item = null;
			}
		}
	}

	public void ClearLastEquipped(Item item)
	{
		character.Unequip(character.lastItem);
		for (int i = 0; i < equipmentSlots.Length; i++)
		{
			if (equipmentSlots[i].Item == character.lastItem)
			{
				equipmentSlots[i].Item = null;
			}
		}
		character.lastItem = null;
	}

	public bool AddItem(EquippableItem item, out EquippableItem previousItem)
	{
		for (int i = 0; i < equipmentSlots.Length; i++)
		{
			if (equipmentSlots[i].EquipmentType == item.EquipmentType)
			{
				previousItem = (EquippableItem)equipmentSlots[i].Item;
				equipmentSlots[i].Item = item;
				nameText[i].text = item.ItemName;
				return true;
			}
		}
		previousItem = null;
		return false;
	}

	public bool RemoveItem(EquippableItem item)
	{
		for (int i = 0; i < equipmentSlots.Length; i++) 
		{
			if (equipmentSlots[i].Item == item) 
			{
				equipmentSlots[i].Item = null;
				nameText[i].text = null;
				return true;
			}
		}
		return false;
	}
}