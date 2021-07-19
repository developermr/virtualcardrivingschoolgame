using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ruledetails : MonoBehaviour
{

    public Text r1text;
    public Text r2text;
    public Text r3text;
    public Text r4text;
    public Text r5text;
    public Text r6text;
    public Text username;
    public Text score;
  
    // Start is called before the first frame update
    void Start()
    {
        r1text.text = playermovement.r1;
        r2text.text = playermovement.r2;
        r3text.text = playermovement.r3;
        r4text.text = playermovement.r4;
        r5text.text = playermovement.r5;
        r6text.text = GameUI.r6;
        username.text = entername.userentername;
        int userscore = playermovement.userscore;
        score.text = userscore.ToString();

    }

    // Update is called once per frame
    public GameObject highscorecontainer;
    public GameObject ruleviewcontainer;
    public void onnextpress()
    {

        ruleviewcontainer.SetActive(false);
        highscorecontainer.SetActive(true);
    }
}
