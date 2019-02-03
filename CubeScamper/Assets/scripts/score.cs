using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform Player;
    public Text scoreText;
    private float scr = 0;
    private string stext = "0";

	// Update is called once per frame
	void Update () {
        scr = (Player.position.z / 100);
        int max = PlayerPrefs.GetInt("Score", 0);
        if((int)scr > max)
        {
            PlayerPrefs.SetInt("Score", (int)scr);
        }
        stext = scr.ToString("0");
        scoreText.text = stext;
	}
    
    public string scoreUpdate ()
    {
        return stext;
    }
    public int scoreUpdateInt ()
    {
        return (int)scr;
    }
}
