using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed { get; set; } = 3f;
    public bool useDeltaTime { get; set; }
    public bool autoStep { get; set; }

    public float resetDistance = 90f;

    void Update()
    {
        if (autoStep)
        {
            PerformStep(1f);
        }
    }

    public void PerformStep(float distance)
    {
        transform.position += (useDeltaTime ? Time.deltaTime : 1f) * distance * speed * Vector3.forward;
        if (transform.position.z >= resetDistance)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - resetDistance);
        }
    }

    public void ResetPosition()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
    }
}
