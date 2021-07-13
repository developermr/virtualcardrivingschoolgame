using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    private const float CAMERA_TRANSITION_SPEED = 3.0f;
    public GameObject LevelButtonPrefeb;
    public GameObject LevelButtonContainer;
    public GameObject shopprefectbutton;
    public GameObject shopitemContainer;

    private Transform cameraTransform;
    private Transform cameraDesiredLookAt;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        Sprite[] thumnails = Resources.LoadAll<Sprite>("Levels");
        foreach (Sprite thumnail in thumnails)
        {
            GameObject container = Instantiate(LevelButtonPrefeb) as GameObject;
            container.GetComponent<Image>().sprite = thumnail;
            container.transform.SetParent(LevelButtonContainer.transform, false);

            string scenName = thumnail.name;
            container.GetComponent<Button>().onClick.AddListener(() => LoadLevel(scenName));
        }


        Sprite[] textures = Resources.LoadAll<Sprite>("Player");
        foreach (Sprite texture in textures)
        {
            GameObject container = Instantiate(shopprefectbutton) as GameObject;
            container.GetComponent<Image>().sprite = texture;
            container.transform.SetParent(shopitemContainer.transform, false);

    
        }

    }

   // private void Update()
    //{
      //  if (cameraDesiredLookAt != null)
        //{
          //  cameraTransform.rotation = Quaternion.Slerp (cameraTransform.rotation, cameraDesiredLookAt.rotation, CAMERA_TRANSITION_SPEED * Time.deltaTime);
        //}
    //}

    private void LoadLevel(string scenName)
    {
        SceneManager.LoadScene(scenName);
    }

//    public void LookAtMenu(Transform menuTransform)
  //  {
    //    cameraDesiredLookAt = menuTransform;
    //}
}
