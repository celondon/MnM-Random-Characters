using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
	public string ItemName;
	public Sprite Icon;
	public string ItemDescription;
	public string Parent;
	public string Family;
	public string subFamily;
	public string NextTable;
	public string CurrentTable;
	public bool Unique;
}