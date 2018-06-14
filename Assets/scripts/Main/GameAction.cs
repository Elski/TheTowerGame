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
  

    Button AddEndButton = AddEndScript.singleton.yourButton.GetComponent<Button>();
    AddEndButton.onClick.AddListener(() => AddEnd());

    Button BigAttackB = BigAttackController.singleton.yourButton.GetComponent<Button>();
    BigAttackB.onClick.AddListener(() => BigAttack());

    Button AddAgiButton = AddSpdScript.singleton.yourButton.GetComponent<Button>();
    AddAgiButton.onClick.AddListener(() => AddAgi());

    Button AddStrButton = AddStrScript.singleton.yourButton.GetComponent<Button>();
    AddStrButton.onClick.AddListener(() => AddStr());





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
    public void AddEnd()
    {
        print(Hero.agility);
    }

    public void AddStr()
    {
        print(Hero.agility);
    }

    public void AddAgi()
    {
        print(Hero.agility);
    }

}
