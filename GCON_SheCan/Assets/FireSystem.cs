using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FireSystem : MonoBehaviour
{
    private int numOfFire;
    private int maxNumberOfFire;
    private int numOfFireTuredOff;
    private float timer = 5;
    public List<GameObject> fireList;
    private bool canAddFire;
   
    void Start()
    {
        numOfFire = 5;
        numOfFireTuredOff = 0;
        fireList = new List< GameObject> ();
        canAddFire = false;
        maxNumberOfFire = 14;
        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Fire"))
        {

            fireList.Add(fooObj);
        }

        for (int index = 5; index < fireList.Count; index++)
        {
            fireList[index].SetActive(false);
                
        }


    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (maxNumberOfFire != numOfFire && timer <=0)
        {
            canAddFire = true;
            SetFireActive();
        }
        CheckIfTheAllFireTurendOff();
    }

    public void AddToList()
    {
        numOfFireTuredOff += 1;

        CheckIfTheAllFireTurendOff();
    }

    private void CheckIfTheAllFireTurendOff()
    {
        if (numOfFire == numOfFireTuredOff && timer > 0)
        {
            Debug.Log("You win");
            SceneManager.LoadScene(2);

        }
        else if (maxNumberOfFire == numOfFire && numOfFire != numOfFireTuredOff &&  timer <=0)
        {
            //lose
            SceneManager.LoadScene(3);
        }
    }

    private void SetFireActive()
    {
        int rangeNum;
        while (canAddFire == true)
        {
            rangeNum = Random.Range(0, fireList.Count - 1) ;
            Debug.Log(rangeNum);
            Debug.Log(fireList.Count);
            GameObject randomFire = fireList[rangeNum];
            bool isACtive = randomFire.activeSelf;
           if  ( isACtive == false)
            {
                fireList[rangeNum].SetActive(true);
                numOfFire += 1;
                timer += 5;
                canAddFire = false;
                break;
            }
        }
    }
}
