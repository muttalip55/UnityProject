using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalsMove : MonoBehaviour
{
    public GameObject animal1, animal2, animal3;
    Rigidbody2D animalRB1, animalRB2, animalRB3;

    public GameObject bait1, bait2, bait3;
    Collider2D animalColl1, animalColl2, animalColl3;
    public GameObject door,finish;

    public float moveSpeed = 1f, move1, move2;

    private float time,time2;
    public Slider timeSlider;

     Animator anim;
    bool animRun1 = true, animRun2 = true, animRun3 = true, animBitti = false, run = false;

    public GameObject star1, star2, star3;
    private int animal3Star;
    public GameObject board;
    //  private Animation animm;

    void Start()
    {
      //  PlayerPrefs.SetInt("animal3Star", 0);
        animal3Star = PlayerPrefs.GetInt("animal3Star");
        // starGet(animal3Star);

        animalRB1 = animal1.GetComponent<Rigidbody2D>();
        animalRB2 = animal2.GetComponent<Rigidbody2D>();
        animalRB3 = animal3.GetComponent<Rigidbody2D>();
        animalColl2 = animal2.GetComponent<Collider2D>();
        animalColl3 = animal3.GetComponent<Collider2D>();

        animalColl2.isTrigger = true;
        animalColl3.isTrigger = true;

        time = 60;
        time2 = 7;
        timeSlider.maxValue = time;
        timeSlider.value = timeSlider.maxValue;

        starGet(animal3Star);
    }

    void Update()
    {
        animal3Star = PlayerPrefs.GetInt("animal3Star");
        timeSlider.value = time;

        if (animal3Star == 0 && animRun1)
        {
            timeSlider.value = timeSlider.maxValue;
            anim = animal1.gameObject.GetComponent<Animator>();
            anim.enabled = true;
            anim.Play("Animal1");
            animRun1 = false;
            finish.SetActive(false);
            
            animBitti = !animBitti;
        }

        else if (animal3Star == 1 && animRun2)
        {
            animal1.SetActive(false);
            animalColl2.isTrigger = false;
            timeSlider.value = timeSlider.maxValue;
            run = false;
            anim = animal2.gameObject.GetComponent<Animator>();
            anim.enabled = true;
            anim.Play("Animal2");
            animRun2 = false;
            finish.SetActive(false);
            
            animBitti = !animBitti;
        }

        else if (animal3Star == 2 && animRun3)
        {
            animal2.SetActive(false);
            animalColl3.isTrigger = false;
            timeSlider.value = timeSlider.maxValue;
            run = false;
            anim = animal3.gameObject.GetComponent<Animator>();
            anim.enabled = true;
            anim.Play("Animal3");
            animRun3 = false;
            finish.SetActive(false);
            
            animBitti = !animBitti;
        }

        if(animBitti)
            time2 -= Time.deltaTime;


        if (time2 <= 0 && animBitti)
        {
            Debug.Log("animBitti");
            anim.StopPlayback();
            anim.enabled = false;
            door.SetActive(true);
            time2 = 7;
            animBitti = !animBitti;
            run = true;
        }

        if (!run)
        {
            timeSlider.value = timeSlider.maxValue;
            time = timeSlider.maxValue;
        }
            

        if (timeSlider.value >= 0 && animal3Star == 0 && run)
        {
        animalRB1.velocity = new Vector2(move1 * moveSpeed * 100 * Time.deltaTime, move2 * moveSpeed * 100 * Time.deltaTime);
        
            if (animalRB1.velocity.x < 0)
            {
                animal1.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (animalRB1.velocity.x > 0)
            {
                animal1.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (animalRB1.velocity.y < 0)
            {
                animal1.transform.rotation = Quaternion.Euler(0, 0, 270 );
            }
            if (animalRB1.velocity.y > 0)
            {
                animal1.transform.rotation = Quaternion.Euler(0, 0, 90);
            }

            time -= Time.deltaTime;

            if (timeSlider.value <= 0)
            {
                time = timeSlider.maxValue;
                animRun1 = true;
                door.SetActive(false);
                finish.SetActive(false);
                run = !run;
            }
            timeSlider.value = time;
        }
        
       

        if (timeSlider.value >= 0 && animal3Star == 1 && run)
        {
            

            animalRB2.velocity = new Vector2(move1 * moveSpeed * 100 * Time.deltaTime, move2 * moveSpeed * 100 * Time.deltaTime);

            if (animalRB2.velocity.x < 0)
            {
                animalRB2.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (animalRB2.velocity.x > 0)
            {
                animalRB2.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (animalRB2.velocity.y < 0)
            {
                animalRB2.transform.rotation = Quaternion.Euler(0, 0, 270);
            }
            if (animalRB2.velocity.y > 0)
            {
                animalRB2.transform.rotation = Quaternion.Euler(0, 0, 90);
            }

            time -= Time.deltaTime;

            if (timeSlider.value <= 0)
            {
                time = timeSlider.maxValue;
                animRun2 = true;
                door.SetActive(false);
                finish.SetActive(false);
            }
            timeSlider.value = time;
        }


        if (timeSlider.value >= 0 && animal3Star == 2 && run)
        {
            animalRB3.velocity = new Vector2(move1 * moveSpeed * 100 * Time.deltaTime, move2 * moveSpeed * 100 * Time.deltaTime);

            if (animalRB3.velocity.x < 0)
            {
                animal3.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (animalRB3.velocity.x > 0)
            {
                animal3.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (animalRB3.velocity.y < 0)
            {
                animal3.transform.rotation = Quaternion.Euler(0, 0, 270);
            }
            if (animalRB3.velocity.y > 0)
            {
                animal3.transform.rotation = Quaternion.Euler(0, 0, 90);
            }

            time -= Time.deltaTime;

            if (timeSlider.value <= 0)
            {
                time = timeSlider.maxValue;
                animRun1 = true;
                door.SetActive(false);
                finish.SetActive(false);
            }
            timeSlider.value = time;
        }
    }


    private void starGet(int animal3Star)
    {
        if (animal3Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            board.SetActive(true);

        }
        else if (animal3Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        }
        else if (animal3Star == 1)
        {
            star1.SetActive(true);
        }
    }

    public void RightAnimal()
    {
        move1 = 1;
    }

    public void LeftAnimal()
    {
        move1 = -1;
    }

    public void UpAnimal()
    {
        move2 = 1;
    }

    public void DownAnimal()
    {
        move2 = -1;
    }

    public void StopAnimal()
    {
        move1 = 0;
        move2 = 0;
    }
}
