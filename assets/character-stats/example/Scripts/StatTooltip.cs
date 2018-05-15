using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Kryz.CharacterStats;

public class StatTooltip : MonoBehaviour
{
	public static StatTooltip Instance;

	[SerializeField] Text StatNameText;
	[SerializeField] Text StatModifiersLabelText;
	[SerializeField] Text StatModifiersText;
	[SerializeField] Text StatDesciptionText;

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

	public void ShowTooltip(CharacterStat stat, string statName)
	{
		gameObject.SetActive(true);

		StatNameText.text = GetStatTopText (stat, statName);
		StatModifiersText.text = GetStatModifiersText(stat);
		StatDesciptionText.text = GetValueDescriptionText(stat);
	}

	public void HideTooltip()
	{
		gameObject.SetActive(false);
	}

	private string GetStatTopText(CharacterStat stat, string statName)
	{
		sb.Length = 0;
		sb.Append (statName);
		sb.Append (" ");
		sb.Append (stat.Value);
		if (stat.Value != stat.BaseValue) 
		{
			sb.Append (" (");
			sb.Append (stat.BaseValue);

			if (stat.Value > stat.BaseValue)
				sb.Append ("+");

			sb.Append (System.Math.Round(stat.Value - stat.BaseValue,4));
			sb.Append (")");
		}
		return sb.ToString ();
	}


	private string GetValueText(CharacterStat stat)
	{
		sb.Length = 0;

		sb.Append(stat.Value);
		sb.Append(" (");
		sb.Append(stat.BaseValue);
		sb.Append(" + ");
		sb.Append((float)System.Math.Round(stat.Value - stat.BaseValue, 4));
		sb.Append(")");

		return sb.ToString();
	}

	private string GetValueDescriptionText(CharacterStat stat)
	{
		return stat.statDescription;
	}

	private string GetStatModifiersText(CharacterStat stat)
	{
		sb.Length = 0;

		foreach (StatModifier mod in stat.StatModifiers) 
		{
			if (sb.Length > 0)
				sb.AppendLine ();

			if (mod.Value > 0)
				sb.Append ("+");

			if (mod.Type == StatModType.Flat) 
			{
				sb.Append (mod.Value);	
			} 
			else
			{
				sb.Append (mod.Value * 100);
				sb.Append ("%");
			}

			EquippableItem item = mod.Source as EquippableItem;

			if (item != null) 
			{
				sb.Append (" ");
				sb.Append (item.ItemName);
			}
			else 
			{
				Debug.LogError ("Modifier is not an EquippableItem!");
			}
		}
		return sb.ToString ();
	}

	private string FirstLetterToUpper(string s)
	{
		if (string.IsNullOrEmpty(s))
			return null;

		char[] a = s.ToCharArray();
		a[0] = char.ToUpper(a[0]);
		return new string(a);
	}

//	public Vector3 offset;
//	// Update is called once per frame
//	void Update () {
//		transform.position = Input.mousePosition + offset;
//	}
}