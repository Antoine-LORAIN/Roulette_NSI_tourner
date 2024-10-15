using UnityEngine;
using UnityEngine.UI;

public class NumeroPleinController : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [Header("Objects")]
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Transform triangle;
    [SerializeField]
    private Text argentTotal;

    private void Start()
    {
        startButton.onClick.AddListener(switchMustRoll);
        refreshArgent();
    }

    void Update()
    {
        refreshArgent();
    }

    private void switchMustRoll()
    {
        gp.mustRoll = true;
    }

    private void refreshArgent()
    {
        argentTotal.text = "Argent total : " + gp.argentTotal + "€";
    }
}