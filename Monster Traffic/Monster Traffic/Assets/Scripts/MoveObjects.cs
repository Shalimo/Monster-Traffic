using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float speedEnemyCar = 2.3f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speedEnemyCar * Time.deltaTime);
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
