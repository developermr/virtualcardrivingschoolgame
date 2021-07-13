using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playermovement : MonoBehaviour
{
    public static int points  = 20;
    public static int collisions = 0;
    public static string rulename = "Game Start";
    public bool showStatus = true;

    void OnCollisionEnter(Collision collisionInfo)
    {

        Debug.Log(collisionInfo.collider.tag);

        if (collisionInfo.collider.tag == "roadboundary")
         {
            //Debug.Log("hit");
            rulename = "Hit Road Boundary";
                points--;
               collisions++;
        }

        if (collisionInfo.collider.tag == "Player")
        {
           // Debug.Log("hit player");
        }


        if (collisionInfo.collider.name == "roadpatch")
        {
           
           // Debug.Log("roadpatch is here!");
            rulename = "Hit Road Boundary";
            points--;
            collisions++;
        }

        if (collisionInfo.collider.tag == "Vehicle")
        {
            //Debug.Log("Hit The Car");
            rulename = "Hit Vehical";
            points--;
            collisions++;
        }


        if (collisionInfo.collider.name == "RoadBlocker")
        {
            //Debug.Log("Hit The Car");
            rulename = "Hit Blocker";
            points--;
            collisions++;
        }


        if (collisionInfo.collider.tag == "bike")
        {
            rulename = "Hit Bike";
            points--;
            collisions++;
        }

        if (collisionInfo.collider.name == "boundary.001")
        {
            rulename = "Hit Metro Boundary";
            //Debug.Log("Hit The Metro Boundary");
            points--;
            collisions++;
        }

        //game over with points
        if (points <= 0)
        {
   
            rulename = "Game Over";
            Debug.Log("Game Over");
            gameloadscen = SceneManager.GetActiveScene().buildIndex;
            GameOver();


        }
    }
    public static int gameloadscen;

    void OnGUI()
    {
        if (showStatus)
        {

            GUIStyle headStyle = new GUIStyle();
            headStyle.fontSize = 15;

            GUI.color = Color.black;
            
          
            GUI.Label(new Rect(10, 60, 200, 20), "Remaining Chances: " + points + "/" + 20, headStyle);
            GUI.Label(new Rect(10, 90, 200, 20), "Rule Break Detail: " + rulename, headStyle);
        }
    }





    //for coutdown timer
    public float timeRemaining = 90;
    public bool timerIsRunning = false;
    public Text timeText;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

   
    void GameOver()
    {

        SceneManager.LoadScene(3);
    }

}
