using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameAction : MonoBehaviour {


    public int check = 0;
  
    public Enemy enemy;



    public bool SetButtonInfo(bool info)
    {
        return info;
    }

     

    // Use this for initialization

    void Start()
    {
        
        Hero.floor++;
        Hero.curHp = Hero.startHp+(Hero.vitality*10);
        Hero.addEnd = Hero.armorPower;
        Hero.addStr = Hero.swordPower;

    Button AddEndButton = AddEndScript.singleton.yourButton.GetComponent<Button>();
    AddEndButton.onClick.AddListener(() => AddEnd());

    Button BigAttackB = BigAttackController.singleton.yourButton.GetComponent<Button>();
    BigAttackB.onClick.AddListener(() => BigAttack());

    Button AddAgiButton = AddSpdScript.singleton.yourButton.GetComponent<Button>();
    AddAgiButton.onClick.AddListener(() => AddAgi());

    Button AddStrButton = AddStrScript.singleton.yourButton.GetComponent<Button>();
    AddStrButton.onClick.AddListener(() => AddStr());





        enemy.startHp = Random.Range(100, 200);
        enemy.curHp = enemy.startHp ;
        float valueRange = Hero.floor;
        valueRange= checkValue(valueRange);

        enemy.endurance = Random.Range(1, valueRange);
        valueRange = valueRange - enemy.endurance;
        valueRange = checkValue(valueRange);

        enemy.charisma = Random.Range(1, valueRange);
        valueRange = valueRange - enemy.charisma;
        valueRange = checkValue(valueRange);

        enemy.strenght = Random.Range(1, valueRange);
        valueRange = valueRange - enemy.strenght;
        valueRange = checkValue(valueRange);

        enemy.agility = Random.Range(1, valueRange);
        valueRange = valueRange - enemy.agility;
        valueRange = checkValue(valueRange);

        enemy.luck = Random.Range(1, valueRange);
        valueRange = valueRange - enemy.luck;
        valueRange = checkValue(valueRange);

        enemy.fencing = Random.Range(1, valueRange);
        valueRange = valueRange - enemy.fencing;
        valueRange = checkValue(valueRange);

        enemy.vitality = Random.Range(1, valueRange);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (check == -1)
        {
            SceneManager.LoadScene("inside", LoadSceneMode.Single);
        }
        if (check == 1)
        {
            SceneManager.LoadScene("outside", LoadSceneMode.Single);
        }

    }

    public void BigAttack()
    {
      if(((Hero.addAgl+Hero.agility)/2)>enemy.agility)
        {
            HeroAttack();
            checkStatus();
            HeroAttack();
            checkStatus();
            EnemyAttack();
            checkStatus();
        }
      else if(enemy.agility/2 > (Hero.addAgl + Hero.agility))
        {
            EnemyAttack();
            checkStatus();
            EnemyAttack();
            checkStatus();
            HeroAttack();
            checkStatus();
        }
        else
        {
            HeroAttack();
            checkStatus();
            EnemyAttack();
            checkStatus();
        }

    }
    public void AddEnd()
    {
        if (((Hero.addAgl + Hero.agility) / 2) > enemy.agility)
        {
            Hero.addEnd++;
            Hero.addEnd++;
            EnemyAttack();
            checkStatus();
        }
        else if (enemy.agility / 2 > (Hero.addAgl + Hero.agility))
        {
            EnemyAttack();
            checkStatus();
            EnemyAttack();
            checkStatus();
            Hero.addEnd++;
        }
        else
        {
            Hero.addEnd++;
            EnemyAttack();
            checkStatus();
        }
    }

    public void AddStr()
    {
        if (((Hero.addAgl + Hero.agility) / 2) > enemy.agility)
        {
            Hero.addStr++;
            Hero.addStr++;
            EnemyAttack();
            checkStatus();
        }
        else if (enemy.agility / 2 > (Hero.addAgl + Hero.agility))
        {
            EnemyAttack();
            checkStatus();
            EnemyAttack();
            checkStatus();
            Hero.addStr++;
        }
        else
        {
            Hero.addStr++;
            EnemyAttack();
            checkStatus();
        }
    }

    public void AddAgi()
    {
        if (((Hero.addAgl + Hero.agility) / 2) > enemy.agility)
        {
            Hero.addAgl++;
            Hero.addAgl++;
            EnemyAttack();
            checkStatus();
        }
        else if (enemy.agility / 2 > (Hero.addAgl + Hero.agility))
        {
            EnemyAttack();
            checkStatus();
            EnemyAttack();
            checkStatus();
            Hero.addAgl++;
        }
        else
        {
            Hero.addAgl++;
            EnemyAttack();
            checkStatus();
        }
    }
   

    public void EnemyAttack()
    {
        float enemyLuck= Random.Range(1, enemy.luck);
        if(((Hero.endurance + Hero.addEnd + Hero.armorPower) - enemy.charisma)>0)
        Hero.curHp = Hero.curHp -((enemyLuck/2)*((10/Mathf.Abs((Hero.endurance+Hero.addEnd+Hero.armorPower)-enemy.charisma))*(enemy.strenght + enemy.strenght*(enemy.fencing/10))));
        else
            Hero.curHp = Hero.curHp - ((enemyLuck / 2) * (enemy.strenght + enemy.strenght * (enemy.fencing / 10)));
        print(Hero.curHp);
    }
    public void HeroAttack()
    {
        float heroLuck = Random.Range(1, Hero.luck);
        if((( ((enemy.endurance) - Hero.charisma))>0))
        enemy.curHp = enemy.curHp - ((heroLuck / 2) * ((1 /((enemy.endurance ) - Hero.charisma)) * (Hero.strenght+Hero.swordPower + Hero.strenght * (Hero.fencing / 10))));
        else
            enemy.curHp = enemy.curHp - ((heroLuck / 2) * (Hero.strenght + Hero.swordPower + Hero.strenght * (Hero.fencing / 10)));
        print(enemy.curHp);
    }
    public float checkValue(float value)
    {
        if(value>=0)
        {
            value = 1;
        }
        return value;
    }
   public void checkStatus()
    {
        if (enemy.curHp <= 0)
        {
            Hero.gold = Hero.gold + 1;
            Hero.points = Hero.points + 1;
            check = -1;
            
        }
        if(Hero.curHp<=0)
        {
            check = 1;
           
        }
    }
}
