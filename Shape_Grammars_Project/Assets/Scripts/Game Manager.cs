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

    int doRepeat = 1;

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
            //Debug.Log("Building = " + randNum);

            Instantiate(Buildings[randNum], new Vector3(0, 0, repeatAmount * 5.5f), new Quaternion(0, 0, 0, 0));

            doRepeat = Random.Range(0, 10);
            repeatAmount++;
            /*
            if (randNum == 4)
            {
                doRepeat = 0;
            }
            */
                
            Debug.Log("Repeat = " + doRepeat);
        }
        while (doRepeat != 0);
    }

    
    private void Update()
    {

        

    }


}
