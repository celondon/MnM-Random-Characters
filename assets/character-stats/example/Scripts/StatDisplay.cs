using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Kryz.CharacterStats;

public class StatDisplay : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	private CharacterStat _stat;
	public CharacterStat Stat { 
		get { return _stat; }
		set {
			_stat = value;
			UpdateStatValue ();
			}
	}

	private string _name;
	public string Name { 
		get { return _name; } 
		set {
			_name = value;
			nameText.text = _name;
		}
	}

	[SerializeField] Text nameText;
	[SerializeField] Text descriptionText;
	[SerializeField] Text valueText;
	[SerializeField] StatTooltip tooltip;

	private CharacterStat[] stats;

	private void OnValidate()
	{
		Text[] texts = GetComponentsInChildren<Text> ();
		nameText = texts [0];
		valueText = texts [1];
		descriptionText = texts[2];

		if (tooltip == null)
			tooltip = FindObjectOfType<StatTooltip> ();
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		tooltip.ShowTooltip(Stat, Name);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		tooltip.HideTooltip();	
	}

	public void UpdateStatValue()
	{
		valueText.text = _stat.Value.ToString ();
	}
	public void UpdateStatDesc()
	{
		descriptionText.text = _stat.statDescription;
		//print("Power = " + name + " Value = " + _stat.Value.ToString() + " " + _stat.statDescription);
	}
}