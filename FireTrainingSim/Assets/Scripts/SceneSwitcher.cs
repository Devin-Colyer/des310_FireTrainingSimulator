using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

  

    public void ChangingSceneBtn(string NextScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(NextScene);
        Debug.Log("LoadingScene");
        Time.timeScale = 1;

    }
	

    public void ExitGameBtn()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
}
