using UnityEngine;

public class BulletProperties : MonoBehaviour
{
    [SerializeField] int count = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        count++;
        if (count == 5)
        {
            Destroy(gameObject);
            count = 0;
        }
    }

}
