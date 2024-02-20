
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class CharacterMovement : MonoBehaviour
{
    private float jumpForce = 9f;
    Rigidbody2D rb;
    public static bool IsAlive = true;
    private Score score;
    public AudioSource jump;
    public AudioSource audioScore;
    
    


    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        
     
        score = GameObject.FindGameObjectWithTag("GameController").GetComponent<Score>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }



    private void Movement() {
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0) ){

            jump.Play();
            rb.velocity = Vector2.up*jumpForce;
            
       
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "pipe") {
            IsAlive = false;
            Time.timeScale = 0f;
            if(score.getScore()>score.getHighScore()) {
                score.setHighScore(score.getScore());
            }
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "scoreLine") {
            audioScore.Play();
            score.updateScore(1);
        }
    }
    





}
