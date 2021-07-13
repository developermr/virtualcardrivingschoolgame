using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartscene : MonoBehaviour
{
    // Start is called before the first frame update

        public void restartgame()
        {
            playermovement.points = 20;
            playermovement.collisions = 0;
            playermovement.rulename = "Start Game";
            int getsceen = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(getsceen);

        }
  

    // Update is called once per frame

}
