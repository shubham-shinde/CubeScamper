using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

    public Button m_YourFirstButton2;

    private void Start()
    {
        m_YourFirstButton2.onClick.AddListener(onClick);
    }

    // Update is called once per frame
    private void onClick () {
        SceneManager.LoadScene("SampleScene");
    }
}
