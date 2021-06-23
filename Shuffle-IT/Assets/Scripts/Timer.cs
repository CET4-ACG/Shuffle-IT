using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   public float timeValue = 180;
   public Text timerText;
   public GameObject GameOver;
   
   void EnableText()
   {
       timerText.enabled = true;
   }

   void Update ()
   {
       if (timeValue > 0)
       {
           timeValue -= Time.deltaTime;
       }
       else
       {
           timeValue = 0;
		   timerText.enabled = false;
           GameOver.SetActive(true);
       }
       
       DisplayTime(timeValue);
   }
   
   void DisplayTime(float timeToDisplay)
   {
       if (timeToDisplay < 0)
       {
           timeToDisplay = 0;
       }

       float minutes = Mathf.FloorToInt(timeToDisplay / 60);
       float seconds = Mathf.FloorToInt(timeToDisplay % 60);

       timerText.text = string.Format("{0:0} : {1:00}", minutes, seconds);     
   }

}
