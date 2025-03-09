using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*
     * creat the first object
     * 
     * loop---------------------------------------
     * pick from random pool of objects
     *  creat chosen objects
     *  
     *  choose to contiune building Y/N
     *  -----------------------------------------
    */

    public GameObject[] Buildings;

    int randNum;

    int repeatAmount = 1;

    //create the first object
    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            //Instantiate(Buildings[i], new Vector3(0, 0, i * 5.5f), new Quaternion(0, 0, 0, 0));
        }

        Instantiate(Buildings[0], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));

        creatBuildings();
    }


    private void creatBuildings()
    {
        do
        {
            //pick from random pool of objects
            randNum = Random.Range(1, 4);

            //creat chosen objects
            Instantiate(Buildings[randNum], new Vector3(0, 0, repeatAmount * 5.5f), new Quaternion(0, 0, 0, 0));

            repeatAmount++;

        }
        //choose to contine building
        while (randNum != 3);
    }

    
    private void Update()
    {

        

    }


}
