using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationCS : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [SerializeField]
    private float rotSpeed;
    [SerializeField]
    private GameObject popup;
    [SerializeField]
    private InputField miseInput;
    [SerializeField]
    private Button pairButton;
    [SerializeField]
    private Button impairButton;
    [Header("Scirpt de la logique")]
    [SerializeField]
    private LogiqueCS logique;

    private float currentRotation;

    private List<int> nombreRoue = new List<int> { 0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };

    private void Start()
    {
        rotSpeed = UnityEngine.Random.Range(gp.rotSpeedMin, gp.rotSpeedMax);
    }

    private void Update()
    {
        if (gp.mustRoll && gp.canRoll)
        {
            popup.SetActive(false);
            miseInput.enabled = false;
            pairButton.onClick.RemoveAllListeners();
            impairButton.onClick.RemoveAllListeners();

            if (rotSpeed >= 0)
            {
                rotate(rotSpeed);
                rotSpeed--;
            }
            else
            {
                getNumber();
                gp.mustRoll = false;
                rotSpeed = UnityEngine.Random.Range(gp.rotSpeedMin, gp.rotSpeedMax);
                logique.Play();
            }
        }

        float rotation = transform.rotation.eulerAngles.z;


    }

    private void rotate(float speed)
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }

    private void getNumber()
    {
        currentRotation = transform.rotation.eulerAngles.z;
        float positionListToRound = (currentRotation * 37 / 360);
        int positionList = Mathf.RoundToInt(positionListToRound);
        gp.nombreTire = nombreRoue[positionList];
    }
}