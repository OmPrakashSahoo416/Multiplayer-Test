using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<BulletProperties>())
        {
            gameOverCanvas.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
