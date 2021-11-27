using UnityEngine;

public class BulletProperties : MonoBehaviour
{
    [SerializeField] int count = 0;
    [SerializeField] ParticleSystem bulletHitEffect;

    private void Start()
    {
        bulletHitEffect = gameObject.GetComponentInChildren<ParticleSystem>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        count++;
        if (count == 4)
        {
            bulletHitEffect.Play();
            Destroy(gameObject);
            count = 0;
        }
    }

}
