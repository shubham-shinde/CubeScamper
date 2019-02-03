using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {

    public Button m_YourFirstButton;

    private void Start()
    {
        m_YourFirstButton.onClick.AddListener(onClick);
    }

    // Update is called once per frame
    void onClick () {
        SceneManager.LoadScene("SampleScene");
    }
}
