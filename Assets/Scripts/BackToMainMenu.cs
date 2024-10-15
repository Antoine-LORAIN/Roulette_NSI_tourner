using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainMenu : MonoBehaviour
{
    [SerializeField]
    private Button back;

    private void Start()
    {
        back.onClick.AddListener(backTMM);
    }

    void backTMM()
    {
        SceneManager.LoadScene("MainMenu");
    }
}