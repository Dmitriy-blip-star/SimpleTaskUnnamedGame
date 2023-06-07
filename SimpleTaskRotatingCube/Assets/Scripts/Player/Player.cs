using Assets.Scripts.Player;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour, IControllable, IGunControllable
{
    public float speedRotate = 1.0f;
    public float speed = 1.0f;
    public float speedJump = 5f;

    Rigidbody rb;
    public float gravityScale = -10;
    public float fallingGravityScale = -20;    

    public int score= 0;

    public float rayDistance = 1f;
    bool ground = true;

    [SerializeField] Gun gun;

    [SerializeField] public UnityEvent<int> scoreChanged;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ChangedGravityScale();
        CheckGround();
    }

    private void CheckGround()
    {
        ground = Physics.Raycast(transform.position, -transform.up, rayDistance);
    }

    private void ChangedGravityScale()
    {
        if (rb.velocity.y >= 0)
        {
            Physics.gravity = new Vector3(0,gravityScale,0);
        }
        else if (rb.velocity.y < 0)
        {
            Physics.gravity = new Vector3(0, fallingGravityScale, 0);
        }
    }

    public void Jump()
    {
        if (ground)
        {
            rb.AddForce(transform.up * speedJump, ForceMode.Impulse);
        }
    }

    public void Move()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    public void Rotate(string direction)
    {
        switch (direction)
        {
            case "left":
                transform.Rotate(0, -speedRotate, 0);
                break;
            case "right":
                transform.Rotate(0, speedRotate, 0);
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.tag == "Finish")
        {
            Destroy(other.gameObject);
            score++;
            scoreChanged?.Invoke(score);
        }
    }

    public void SwitchGun(Gun gun)
    {
        this.gun = gun;
    }

    public void Shoot()
    {
        this.gun.Shoot();
    }
}
