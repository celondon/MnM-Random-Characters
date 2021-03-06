using UnityEngine;
using Kryz.CharacterStats;

public class AdvantagePanel : MonoBehaviour
{
	[SerializeField] StatDisplay[] statDisplays;
	[SerializeField] string[] statNames;

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

	public void UpdateStatNames()
	{
		for (int i = 0; i < statNames.Length; i++)
		{
			statDisplays[i].Name = statNames[i];
		}
		//statDisplays[0].Name = "Accurate Attack";
		//statDisplays[1].Name = "Agile Feint";
		//statDisplays[2].Name = "All-Out Attack";
		//statDisplays[3].Name = "Animal Empathy";
		//statDisplays[4].Name = "Artificer";
		//statDisplays[5].Name = "Assessment";
		//statDisplays[6].Name = "Attractive";
		//statDisplays[7].Name = "Beginner's Luck";
		//statDisplays[8].Name = "Benefit";
		//statDisplays[8].Name = "Benefit";
		//statDisplays[8].Name = "Benefit";
		//statDisplays[8].Name = "Benefit";
		//statDisplays[10].Name = "Chokehold";
		//statDisplays[11].Name = "Close Attack";
		//statDisplays[12].Name = "Connected";
		//statDisplays[13].Name = "Contacts";
		//statDisplays[14].Name = "Daze";
		//statDisplays[15].Name = "Defensive Attack";
		//statDisplays[16].Name = "Defensive Roll";
		//statDisplays[17].Name = "Diehard";
		//statDisplays[18].Name = "Eidetic Memory";
		//statDisplays[19].Name = "Equipment Advantage";
		//statDisplays[21].Name = "Evasion";
		//statDisplays[22].Name = "Extraordinary Effort";
		//statDisplays[23].Name = "Fascinate";
		//statDisplays[24].Name = "FastGrab";
		//statDisplays[25].Name = "Favored Environment";
		//statDisplays[26].Name = "FavoredFoe";
		//statDisplays[27].Name = "Fearless";
		//statDisplays[28].Name = "Grabbing Finesse";
		//statDisplays[29].Name = "Great Endurance";
		//statDisplays[30].Name = "Hide in Plain Sight";
		//statDisplays[31].Name = "Improved Aim";
		//statDisplays[32].Name = "Improved Critical";
		//statDisplays[33].Name = "Improved Defense";
		//statDisplays[34].Name = "Improved Disarm";
		//statDisplays[35].Name = "Improved Grab";
		//statDisplays[36].Name = "Improved Hold";
		//statDisplays[37].Name = "Improved Initiative";
		//statDisplays[38].Name = "Improved Smash";
		//statDisplays[39].Name = "Improved Trip";
		//statDisplays[40].Name = "Improvised Tools";
		//statDisplays[41].Name = "Improvised Weapon";
		//statDisplays[42].Name = "Inspire";
		//statDisplays[43].Name = "Instant Up";
		//statDisplays[44].Name = "Interpose";
		//statDisplays[45].Name = "Inventor";
		//statDisplays[46].Name = "Jack of All Trades";
		//statDisplays[47].Name = "Languages";
		//statDisplays[49].Name = "Leadership";
		//statDisplays[50].Name = "Luck";
		//statDisplays[51].Name = "Minion";
		//statDisplays[52].Name = "Move-by Action";
		//statDisplays[53].Name = "Power Attack";
		//statDisplays[54].Name = "Precise Attack";
		//statDisplays[55].Name = "Prone Fighting";
		//statDisplays[56].Name = "Quick Draw";
		//statDisplays[57].Name = "Ranged Attack";
		//statDisplays[58].Name = "Redirect";
		//statDisplays[59].Name = "Ritualist";
		//statDisplays[60].Name = "Second Chance";
		//statDisplays[61].Name = "Seize Initiative";
		//statDisplays[62].Name = "Setup";
		//statDisplays[63].Name = "Sidekick";
		//statDisplays[64].Name = "Skill Mastery";
		//statDisplays[64].Name = "Skill Mastery";
		//statDisplays[64].Name = "Skill Mastery";
		//statDisplays[64].Name = "Skill Mastery";
		//statDisplays[66].Name = "Startle";
		//statDisplays[67].Name = "Takedown";
		//statDisplays[68].Name = "Taunt";
		//statDisplays[69].Name = "Teamwork";
		//statDisplays[70].Name = "Throwing Mastery";
		//statDisplays[71].Name = "Tracking";
		//statDisplays[72].Name = "Trance";
		//statDisplays[73].Name = "Ultimate Effort";
		//statDisplays[74].Name = "Uncanny Dodge";
		//statDisplays[75].Name = "Weapon Bind";
		//statDisplays[76].Name = "Weapon Break";
		//statDisplays[77].Name = "Well informed";
	}
}
