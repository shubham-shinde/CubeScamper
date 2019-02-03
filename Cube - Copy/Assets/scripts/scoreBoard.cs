using UnityEngine;
using UnityEngine.UI;

public class scoreBoard : MonoBehaviour {

    public Text scoreText;
    private string stext;

    void pp () {
        stext = FindObjectOfType<score>().scoreUpdate();
        scoreText.text = stext;
    }
	
}
