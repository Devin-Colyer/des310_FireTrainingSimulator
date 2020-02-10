using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {

    [SerializeField]
    private GameObject GameUI;
    [SerializeField]
    private GameObject Menu;
    [SerializeField]
    private GameObject Btn;
    [SerializeField]
    private GameObject Btn1;
    [SerializeField]
    private bool isPaused = false;
    public Button PressPause;
    public Button PressUnpause;

    //public AK.Wwise.Event pauseSound = new AK.Wwise.Event();

    public void Pause()
    {
        GameUI.SetActive(false);
        Menu.SetActive(true);
        Btn.SetActive(false);
        Btn1.SetActive(true);

        isPaused = true;
        Time.timeScale = 0;

        Debug.Log("pause");
    }

    public void unPause()
    {
        GameUI.SetActive(true);
        Menu.SetActive(false);
        Btn.SetActive(true);
        Btn1.SetActive(false);


        isPaused = false;
        Time.timeScale = 1;

        Debug.Log("unPause");
    }

    //public void SwitchPause()
    //{
    //    if (isPaused == false)
    //    {

    //            GameUI.SetActive(false);
    //            Menu.SetActive(true);

    //            Time.timeScale = 0;
    //            //pauseSound.Post(gameObject);
    //        isPaused = true;
    //    }

    //    else if (isPaused == true)
    //    {
    //            GameUI.SetActive(true);
    //            Menu.SetActive(false);

    //            Time.timeScale = 1;
    //            //pauseSound.Stop(gameObject);
    //        isPaused = false;
    //    }
    //}

    private void Start()
    {
        //PressPause.onClick.AddListener(Pause);
        //PressUnpause.onClick.AddListener(unPause);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) & isPaused == false)
        {
            Pause();
            //SwitchPause();
    }
        else if (Input.GetKeyDown(KeyCode.Escape)& isPaused == true)
        {
            unPause();
            //SwitchPause();
        }
    }

}
