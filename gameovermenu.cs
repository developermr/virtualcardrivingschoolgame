using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameovermenu : MonoBehaviour
{
    private List<string> sceneHistory = new List<string>();


    // Start is called before the first frame update
    public void openmenu()
    {
        playermovement.points=20;
        playermovement.collisions=0;
        playermovement.rulename = "Start Game";

        SceneManager.LoadScene(0);
    }

    public void playagain()
    {
        playermovement.points = 20;
        playermovement.collisions = 0;
        playermovement.rulename = "Start Game";
        int getsceen = playermovement.gameloadscen;
        SceneManager.LoadScene(getsceen);
    }
    public void quitgame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
