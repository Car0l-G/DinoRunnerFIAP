using UnityEngine;

public class cactus : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float positionXtoDestroy = -12.0f;
    
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < positionXtoDestroy)
        {
            Destroy(gameObject);
        }
    }
}
