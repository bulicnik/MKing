using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public CharacterScriptableObject characterData;

    float currentMoveSpeed;
    float currentHealth;
    float currentProjectileSpeed;
    float currentRecovery;
    float currentMight;

    //Experience and level of player
    public int experience = 0;
    public int level = 1;
    public int experienceCap;

    [System.Serializable]
    public class LevelRange
    {
        public int startLevel;
        public int endLevel;
        public int experienceCapIncrease;
    }

    public List<LevelRange> levelRanges;

    void Awake()
    {
        //Assign the variables
        currentMoveSpeed = characterData.MoveSpeed;
        currentHealth = characterData.MaxHealth;
        currentRecovery = characterData.Recovery;
        currentProjectileSpeed = characterData.ProjectileSpeed;
        currentMight = characterData.Might;
    }



    void Start()
    {
        //Initialize the experience cap as the first experience cap increase
        experienceCap = levelRanges[0].experienceCapIncrease;
    }

    public void IncreaseExperience(int amount)
    {
        experience += amount;

        LevelUpChecker();
    }

    void LevelUpChecker()
    {
        if (experience >= experienceCap)
        {
            level++;
            experience -= experienceCap;

            int experienceCapIncrease = 0;
            foreach (LevelRange range in levelRanges) 
            {
                if(level >= range.startLevel && level <= range.endLevel)
                {
                    experienceCapIncrease = range.experienceCapIncrease;
                    break;
                }
            }
            experienceCap += experienceCapIncrease;
        }
    }
}