using UnityEngine;
using Kryz.CharacterStats;

public class PowerPanel : MonoBehaviour
{
	[SerializeField] StatDisplay[] statDisplays;
	[SerializeField] string[] statNames;
	[SerializeField] string[] statDesc;

	private CharacterStat[] stats;

	private void OnValidate()
	{
		statDisplays = GetComponentsInChildren<StatDisplay>();
		UpdateStatNames();
	}

	public void SetStats(params CharacterStat[] charStats)
	{
		stats = charStats;
	
		if (stats.Length > statDisplays.Length) 
		{
			Debug.LogError ("Not Enough Stat Displays!");
			return;
		}

		// Disable any stats that are outside the array
		for (int i = 0; i < statDisplays.Length; i++)
		{
			statDisplays[i].gameObject.SetActive(i < stats.Length);
			if (i < stats.Length) 
			{
				statDisplays [i].Stat = stats [i];
			}

			//if (stats[i].Value == 0)
			//{
			//	statDisplays[i].gameObject.SetActive(false);
			//}
		}
	}

	public void UpdateStatValues()
	{
		for (int i = 0; i < stats.Length; i++)
		{
			statDisplays[i].UpdateStatValue();
			statDisplays[i].UpdateStatDesc();
			if (statDisplays[i].Stat.Value > 0)
			{
				statDisplays[i].gameObject.SetActive(true);
			}
			else
			{
				statDisplays[i].gameObject.SetActive(false);
			}
		}
	}

	//public void UpdateStatDescriptions()
	//{
	//	for (int i = 0; i < stats.Length; i++)
	//	{
	//		statDisplays[i].UpdateStatDesc();
	//	}
	//}

	public void UpdateStatNames()
	{
		for (int i = 0; i < statNames.Length; i++)
		{
			statDisplays[i].Name = statNames[i];
		}
	}

}
