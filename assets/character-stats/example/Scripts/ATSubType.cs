using System;
using System.Collections.Generic;
using UnityEngine;

public class ATSubType : MonoBehaviour 
{
	[SerializeField] List<Item> items;
	[SerializeField] Transform itemsParent;
	[SerializeField] ItemSlot[] itemSlots;

	public event Action<ItemSlot> OnPointerEnterEvent;
	public event Action<ItemSlot> OnPointerExitEvent;
	public event Action<ItemSlot> OnRightClickEvent;
	public event Action<ItemSlot> OnBeginDragEvent;
	public event Action<ItemSlot> OnEndDragEvent;
	public event Action<ItemSlot> OnDragEvent;
	public event Action<ItemSlot> OnDropEvent;


	private void Start()
	{
		for (int i = 0; i < itemSlots.Length; i++) 
		{
			itemSlots[i].OnPointerEnterEvent += OnPointerEnterEvent;
			itemSlots[i].OnPointerExitEvent += OnPointerExitEvent;
			itemSlots[i].OnRightClickEvent += OnRightClickEvent;
			itemSlots[i].OnBeginDragEvent += OnBeginDragEvent;
			itemSlots[i].OnEndDragEvent += OnEndDragEvent;
			itemSlots[i].OnDragEvent += OnDragEvent;
			itemSlots[i].OnDropEvent += OnDropEvent;
		}
	}

	private void OnValidate()
	{
		if (itemsParent != null)
			itemSlots = itemsParent.GetComponentsInChildren<ItemSlot>();

		RefreshUI ();
	}

	private void RefreshUI()
	{
		int i = 0;
		for (; i < items.Count && i < itemSlots.Length; i++) 
		{
			itemSlots [i].Item = items [i];
//			print(items [i]);
		}

		for (; i < itemSlots.Length; i++) 
		{
			itemSlots [i].Item = null;
		}
	}

	public bool AddItem(Item item)
	{
		if (IsFull())
			return false;

		items.Add(item);
		RefreshUI();
		return true;
	}

	public bool RemoveItem(Item item)
	{
		if (items.Remove(item))
		{
			RefreshUI();
			return true;
		}
		return false;
	}


	public bool IsFull()
	{
		return items.Count >= itemSlots.Length;
	}
}
