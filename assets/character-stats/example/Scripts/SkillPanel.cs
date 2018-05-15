using UnityEngine;
using Kryz.CharacterStats;

public class SkillPanel : MonoBehaviour
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
            Debug.LogError("Not Enough Stat Displays!");
            return;
        }

        // Disable any stats that are outside the array
        for (int i = 0; i < statDisplays.Length; i++)
        {
            statDisplays[i].gameObject.SetActive(i < stats.Length);
            if (i < stats.Length)
            {
                statDisplays[i].Stat = stats[i];
            }

            if (stats[i].Value == 0)
            {
                statDisplays[i].gameObject.SetActive(false);
            }
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
        //statDisplays[0].Name = "Acrobatics";
        //statDisplays[0].Name = "Athletics";
        //statDisplays[0].Name = "CloseCombat0";
        //statDisplays[0].Name = "CloseCombat1";
        //statDisplays[0].Name = "CloseCombat2";
        //statDisplays[0].Name = "CloseCombat3";
        //statDisplays[0].Name = "Deception";
        //statDisplays[0].Name = "Expertise0";
        //statDisplays[0].Name = "Expertise1";
        //statDisplays[0].Name = "Expertise2";
        //statDisplays[0].Name = "Expertise3";
        //statDisplays[0].Name = "Insight";
        //statDisplays[0].Name = "Intimidation";
        //statDisplays[0].Name = "Investigation";
        //statDisplays[0].Name = "Perception";
        //statDisplays[0].Name = "Persuasion";
        //statDisplays[0].Name = "RangedCombat0";
        //statDisplays[0].Name = "RangedCombat1";
        //statDisplays[0].Name = "RangedCombat2";
        //statDisplays[0].Name = "RangedCombat3";
        //statDisplays[0].Name = "SleightOfHand";
        //statDisplays[0].Name = "Stealth";
        //statDisplays[0].Name = "Technology";
        //statDisplays[0].Name = "Treatment";
        //statDisplays[0].Name = "Vehicles";
    }
}
