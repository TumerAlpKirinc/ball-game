using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene(1);
        CharacterMovement.IsAlive = true;
        Time.timeScale = 1;
    }
    public void StopGame() {
        Application.Quit();
    }
    public void ToMainMenu() {
        SceneManager.LoadScene(0);
    }

}
