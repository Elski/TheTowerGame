using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameAction : MonoBehaviour {

  

   
    public Enemy enemy;



    public bool SetButtonInfo(bool info)
    {
        return info;
    }



    // Use this for initialization

    void Start()
    {
    Button thatButton = GuiController.singleton.yourButton.GetComponent<Button>();
    thatButton.onClick.AddListener(() => Attack());

    Button BigAttackB = BigAttackController.singleton.yourButton.GetComponent<Button>();
    BigAttackB.onClick.AddListener(() => BigAttack());



        enemy.startHp = Random.Range(100, 200);
        enemy.curHp = enemy.startHp;
        enemy.endurance = Random.Range(1, 10);
        enemy.charisma = Random.Range(1, 10);
        enemy.strenght = Random.Range(1, 10);
        enemy.agility = Random.Range(1, 10);
        enemy.luck = Random.Range(1, 10);
        enemy.fencing = Random.Range(1, 10);
        enemy.vitality = Random.Range(1, 10);
     
    }

    // Update is called once per frame
    void Update()
    {

       

    }
    public void Attack()
    {
        if (Hero.agility >= enemy.agility)
        {

        }
        else
        {


        }
        print(Hero.agility);
        Hero.curHp = Hero.curHp - 50;
        print(Hero.curHp);

    }
    public void BigAttack()
    {
        print(Hero.agility);
        Hero.curHp = Hero.curHp - 233;
        print(Hero.curHp);

    }
    
}
