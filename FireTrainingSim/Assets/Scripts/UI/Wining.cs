using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wining : MonoBehaviour {

    [SerializeField]
    private GameObject ChickenDinner;
    [SerializeField]
    private GameObject NextBtn;
    [SerializeField]
    private GameObject RetryBtn;
    [SerializeField]
    private GameObject PlayBtn;
    [SerializeField]
    private GameObject PauseBtn;
    [SerializeField]
    private GameObject GameUI;
    [SerializeField]
    private GameObject Menu;
  


    public float GameSpeed = 0.1f;

    Animator anim;

    public void Win()
    {
        ChickenDinner.SetActive(true);
        GameUI.SetActive(false);
        PlayBtn.SetActive(false);
        PauseBtn.SetActive(false);
        Menu.SetActive(false);
        Time.timeScale = GameSpeed;
        anim = GetComponent<Animator>();
    }

    public void Next(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
        Time.timeScale = 1;
    }


    public void Retry(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
        Time.timeScale = 1;
    }


}
