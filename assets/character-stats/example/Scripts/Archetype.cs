using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Archetype : MonoBehaviour
{
	[SerializeField] List<Item> items;
	[SerializeField] Transform itemsParent;
	[SerializeField] ItemSlot[] itemSlots;
	[SerializeField] EquipmentSlot[] equipmentSlots;
	[SerializeField] StatsPanel statPanel;
	[SerializeField] EquippableItem previousItem;
	[SerializeField] Text[] nameText;
	[SerializeField] EquipmentType equipmentType;
	[SerializeField] Image image;
	private EquipmentSlot destinationSlot;
	private Color destinationHighlight = new Color(1, 1, 1, 60);
	//private Color destinationNormal = new Color(1, 1, 1, 0);
	
	public Character character;
	public Button nextButton;
	public Button previousButton;
	public Button startOverButton;
	public EquipmentPanel equipmentPanel;
	public PowerPanel powerPanel;

	public event Action<ItemSlot> OnPointerEnterEvent;
	public event Action<ItemSlot> OnPointerExitEvent;
	public event Action<ItemSlot> OnRightClickEvent;
	//public event Action<ItemSlot> OnBeginDragEvent;
	//public event Action<ItemSlot> OnEndDragEvent;
	//public event Action<ItemSlot> OnDragEvent;
	//public event Action<ItemSlot> OnDropEvent;
	//public event Action<ItemSlot> 


	private void Start()
	{
		// Setting up Mouse Listeners so that the various events are passed along into the script
		nextButton.onClick.AddListener(NextInventory);
		//previousButton.onClick.AddListener (PreviousInventory);
		startOverButton.onClick.AddListener(OriginalInventory);
		nextButton.enabled = false;
		previousButton.enabled = false;
		OriginalInventory();

		for (int i = 0; i < itemSlots.Length; i++)
		{
			itemSlots[i].OnPointerEnterEvent += OnPointerEnterEvent;
			itemSlots[i].OnPointerExitEvent += OnPointerExitEvent;
			itemSlots[i].OnRightClickEvent += OnRightClickEvent;
			//itemSlots[i].OnBeginDragEvent += OnBeginDragEvent;
			//itemSlots[i].OnEndDragEvent += OnEndDragEvent;
			//itemSlots[i].OnDragEvent += OnDragEvent;
			//itemSlots[i].OnDropEvent += OnDropEvent;
		}
	}

	private void OnValidate()
	{
		// This allows setting up on Inventory in Editor mode
		if (itemsParent != null)
			itemSlots = itemsParent.GetComponentsInChildren<ItemSlot>();
		RefreshUI();
	}

	private void OriginalInventory()
	{
		// Remove any Equipped Items, clear the Inventory and load the Archetypes into Inventory.
		equipmentPanel.ClearEquipped();
		items.Clear();
		foreach (Item g in Resources.LoadAll<Item>("Items/Archetypes"))
		{
			items.Add(g);
		}
		nextButton.enabled = false;
		character.currentTable = "Archetypes";
		RefreshUI();
	}

	private void NextInventory()
	{
		// Clear the current inventory and load in the nextTable items
		items.Clear();
		if (character.nextTable != "End")
		{
			// If there is a sub-family, use that for loading items, otherwise use the family. 
			// This is needed because some Archetypes have different skill and power layouts depending on ATSubType.
			foreach (Item g in Resources.LoadAll<Item>("Items/" + character.nextTable))
			{
				if (character.subFamily == null || character.subFamily == "")
				{
					if (g.Family == character.familyTree)
					{
						items.Add(g);
					}
				}
				else
				{
					if (g.subFamily == character.subFamily)
					{
						items.Add(g);
					}
				}
			}
			character.currentTable = character.nextTable;
			RefreshUI();
			nextButton.enabled = false;
		}
		else
		{
			nextButton.enabled = false;
			equipmentPanel.gameObject.SetActive(false);
			powerPanel.gameObject.SetActive(true);
		}
	}

	//private void PreviousInventory()
	//{
	//	equipmentPanel.ClearLastEquipped(character.lastItem);
	//	items.Clear();

	//	foreach (Item g in Resources.LoadAll<Item>("Items/" + character.previousTable)) 
	//	{
	//		items.Add (g);
	//	}
	//	RefreshUI();
	//	nextButton.enabled = false;
	//	previousButton.enabled = false;
	//}	

	private void RefreshUI()
	{
		int i = 0;
		for (; i < items.Count && i < itemSlots.Length; i++)
		{
			itemSlots[i].Item = items[i];
		}

		// This loop is for is we have more items than item slots.
		for (; i < itemSlots.Length; i++)
		{
			itemSlots[i].Item = null;
		}
		for (; i < equipmentSlots.Length; i++)
		{
			if (equipmentSlots[i].EquipmentType == equipmentType + 1)
			{
				print("True");
				image.color = destinationHighlight;
			}
			else
			{
				print("False");
			}
		}
		equipmentPanel.gameObject.SetActive(true);
		powerPanel.gameObject.SetActive(false);
	}

	public bool AddItem(Item item)
	{
		for (int i = 0; i < itemSlots.Length; i++)
		{
			if (itemSlots[i].Item == null)
			{
				itemSlots[i].Item = item;
				return true;
			}
		}
		return false;
	}

	public bool RemoveItem(Item item)
	{
		for (int i = 0; i < itemSlots.Length; i++)
		{
			if (itemSlots[i].Item == item)
			{
				itemSlots[i].Item = null;
				return true;
			}
		}
		return false;
	}


	public bool IsFull()
	{
		for (int i = 0; i < itemSlots.Length; i++)
		{
			if (itemSlots[i].Item == null)
			{
				return false;
			}
		}
		return true;

	}

	void Update()
	{
		if (nextButton.enabled == true)
		{
			if (Input.GetKeyDown("return") || Input.GetKeyDown("enter") || Input.GetKeyDown("space"))
				NextInventory();
		}
	}
}