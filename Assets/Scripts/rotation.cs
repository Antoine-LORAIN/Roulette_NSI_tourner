using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField]
    private GameProperties gp;
    [SerializeField]
    private float rotSpeed;

    private void Start()
    {
        rotSpeed = Random.Range(gp.rotSpeedMin, gp.rotSpeedMax);
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
                gp.mustRoll = false;
                rotSpeed = Random.Range(gp.rotSpeedMin, gp.rotSpeedMax);
            }
        }
    }

    private void rotate(float speed)
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}