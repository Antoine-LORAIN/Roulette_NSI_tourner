using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotation : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [SerializeField]
    private float rotSpeed;
    private float currentRotation;

    [SerializeField]
    private Text rotText;
    [SerializeField]
    private Text rotTextDiv;

    private List<int> nombreRoue = new List<int>() {0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14 ,31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };

    private void Start()
    {
        rotSpeed = UnityEngine.Random.Range(gp.rotSpeedMin, gp.rotSpeedMax);
    }

    private void Update()
    {
        if (gp.mustRoll)
        {
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
            }
        }

        float rotation = transform.rotation.eulerAngles.z;
        rotText.text = rotation.ToString();
        rotTextDiv.text = (rotation * 37 / 360).ToString();
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
        Debug.Log(positionList);
        Debug.Log(nombreRoue[positionList]);
    }
}