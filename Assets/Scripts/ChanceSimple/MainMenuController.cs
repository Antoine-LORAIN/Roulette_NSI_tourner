using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private Button numeroPlein;
    [SerializeField]
    private Button chanceSimple;
    [SerializeField]
    private Text versionLabel;
    [SerializeField]
    private GameProperties gp;

    void Start()
    {
        numeroPlein.onClick.AddListener(NumeroPlein);
        chanceSimple.onClick.AddListener(ChanceSimple);
        versionLabel.text = "Version : " + gp.version;
    }

    void NumeroPlein()
    {
        SceneManager.LoadScene("NumeroPlein");
    }

    void ChanceSimple()
    {
        Debug.Log("Chance Simple");
    }
}