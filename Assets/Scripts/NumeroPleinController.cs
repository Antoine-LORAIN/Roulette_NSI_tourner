using UnityEngine;
using UnityEngine.UI;

public class NumeroPleinController : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [Header("Objects")]
    [SerializeField]
    private Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(switchMustRoll);
    }

    private void switchMustRoll()
    {
        gp.mustRoll = true;
    }
}