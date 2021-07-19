using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class entername : MonoBehaviour
{

    public GameObject Ruleviolationcontainer;
    public GameObject Namecontainer;
    public static string userentername;
    //  public Text Username;
 

    // Start is called before the first frame update


    public void readtext(string s)
    {
        userentername = s;
        Namecontainer.SetActive(false);
        Ruleviolationcontainer.SetActive(true);
    }

    public void onpressok()
    {
        Namecontainer.SetActive(false);
      //  Debug.Log(userentername);
        Ruleviolationcontainer.SetActive(true);
    }


}
