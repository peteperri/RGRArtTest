using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool spinning = true;

    void Update()
    {
        if (spinning)
        {
            transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleSpeed();
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += 15f *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed -= 15f * Time.deltaTime;
        }
    }

    private void ToggleSpeed()
    {
        spinning = !spinning;
    }
}
