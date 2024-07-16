using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanelButtons : MonoBehaviour
{
    public void TryAgainBtnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuBtnClick()
    {
        SceneManager.LoadScene(0);
    }

}
