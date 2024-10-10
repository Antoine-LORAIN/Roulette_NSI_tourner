using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private Button numeroPlein;
    [SerializeField]
    private Button chanceSimple;

    void Start()
    {
        numeroPlein.onClick.AddListener(NumeroPlein);
        chanceSimple.onClick.AddListener(ChanceSimple);
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