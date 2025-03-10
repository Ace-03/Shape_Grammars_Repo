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

    public GameObject[] Tiles;
    public GameObject[] Rocks;

    public GameObject Camera;

    public Transform startMarker;
    public Transform endMarker;

    int randTileNum;

    int randRockNum;

    int repeatAmount = 1;

    float startTime;

    float journeyLength;

    public float CamSpeed = 1f;

    //create the first object
    private void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);

        for (int i = 0; i < 4; i++)
        {
            //Instantiate(Buildings[i], new Vector3(0, 0, i * 5.5f), new Quaternion(0, 0, 0, 0));
        }

        Instantiate(Tiles[0], new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));

        creatTiles();
    }


    private void creatTiles()
    {
        do
        {
            //pick from random pool of objects
            randTileNum = Random.Range(1, 4);

            //creat chosen objects
            Instantiate(Tiles[randTileNum], new Vector3(0, 0, repeatAmount * 8f), new Quaternion(0, 0, 0, 0));

            repeatAmount++;

            if(randTileNum !=3)
            creatRocks(repeatAmount);
        }
        //choose to contine building
        while (randTileNum != 3);
    }

    private void creatRocks(float repeatAmount)
    {
        randRockNum = Random.Range(0, 4);

        int shouldMakeRock = Random.Range(0, 3);

        if(shouldMakeRock == 0)
            Instantiate(Rocks[randRockNum], new Vector3(0, 0, ((repeatAmount -1) * 8f) +2), new Quaternion(0, 0, 0, 0));
        else if(shouldMakeRock == 1)
            Instantiate(Rocks[randRockNum], new Vector3(4, 0, ((repeatAmount - 1) * 8f) + 2), new Quaternion(0, 0, 0, 0));
    }
    
    private void Update()
    {
        float distCovered = (Time.time - startTime) * CamSpeed;

        float fractionOfJourney = distCovered / journeyLength;

        Camera.transform.position = Vector3.Lerp(startMarker.position, new Vector3(startMarker.position.x, startMarker.position.y, (repeatAmount - 1) * 8f), fractionOfJourney);
    }




}
