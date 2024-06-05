using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    private int foodPoints = 25;
    private int food2Points = 50;
    private int obstaclePoints = -25;
    private int enemyPoints = -50;
    public AudioSource crunch1;
    public AudioSource crunch2;
    public AudioSource hurt;





    // Start is called before the first frame update
    void Start()
    {
        crunch1 = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food")) {
            score += foodPoints;
            Destroy(other.gameObject);
            UpdateScoreDisplay();
            crunch1.Play();
        }
        else if (other.CompareTag("Obstacle")) {
            score += obstaclePoints;
            UpdateScoreDisplay();
            hurt.Play();
        }
        else if (other.CompareTag("Food2"))
        {
            score += food2Points;
            Destroy(other.gameObject);
            UpdateScoreDisplay();
            if(other.gameObject.name == "Crayfish_Prefab(Clone)")
            {
                crunch2.Play(); 
            }
        }
        else if (other.CompareTag("Enemy"))
        {
            score += enemyPoints;
            UpdateScoreDisplay();
            hurt.Play();
        }
    }

    public TextMeshProUGUI ScoreDisplay;

    public void UpdateScoreDisplay()
    {
        ScoreDisplay.text = "Score: " + score;
    }
}
