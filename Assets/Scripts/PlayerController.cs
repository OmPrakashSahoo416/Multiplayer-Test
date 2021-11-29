using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRb;
    Vector2 mousePos;
    float speed = 2.5f;
    Vector2 movePos;
    float angle;
    [SerializeField] Camera mainCam;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        mainCam = GameObject.FindObjectOfType<Camera>();
    }
    private void Update()
    {
        movePos.x = Input.GetAxis("Horizontal");
        movePos.y = Input.GetAxis("Vertical");

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

    }
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movePos * speed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - playerRb.position;
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        playerRb.rotation = angle - 90f;

    }
}