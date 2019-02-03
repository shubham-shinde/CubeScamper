using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float retartDelay = 2f;

	public void EndGame()
    {
        if(!gameHasEnded)
        {
            Debug.Log("End Game");
            gameHasEnded = true;
            //call the function of name given as
            //first parameter and second delay time
            Invoke("RestartScene", retartDelay);
        }
    }

    void RestartScene()
    {
        //FindObjectOfType<AdsManagerScriptGame>().showInterstitialAd();
        SceneManager.LoadScene("Starting");
    }

    public void restart()
    {
        //LoadScene will load scene of given name from starting
        //GetActiveScene().name will give the name of current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
