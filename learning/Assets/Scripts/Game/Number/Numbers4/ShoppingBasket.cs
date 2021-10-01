using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingBasket : MonoBehaviour
{
    Rigidbody2D basketRB;

    public float moveSpeed = 10f, move;

    bool facingRight = true;

    GameObject tempMaterial;

    public List<GameObject> materials = new List<GameObject>();
    float materialCreatTime = 1.2f;
    float timer = 0f;

    public GameObject star1, star2, star3, board;

    private int number4Star, randomNumber = 0, material1 = 0 , material2 = 0, material3 = 0;
    public Text material1text, material2text, material3text;
    public GameObject material1Img, material2Img, material3Img;

    void Start()
    {
        basketRB = this.GetComponent<Rigidbody2D>();
        number4Star = PlayerPrefs.GetInt("number4Star");
        starGet(number4Star);
        materials[0].transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));
        materials[1].transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));
        materials[2].transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));
        materials[3].transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));
    }

    void Update()
    {
        basketRB.velocity = new Vector2(move * moveSpeed *250* Time.deltaTime,basketRB.velocity.y);

        if (basketRB.velocity.x < 0 && facingRight)
        {
            FlipFace();
        }
        else if (basketRB.velocity.x > 0 && !facingRight)
        {
            FlipFace();
        }

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GameObject go = Instantiate(materials[randomNumber], new Vector3(Random.Range(-7.5f, 7.5f), 5f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;

            go.SetActive(true);

            go.transform.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f, 80f), 0));

            if (randomNumber == 0 || randomNumber == 1)
            {
                randomNumber = Random.Range(2, 4);
            }
            else
            {
                randomNumber = Random.Range(0, 2);
            }
            timer = materialCreatTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "eggNumber4" && material1 < 12)
        {
            material1++;
            material1text.text = "" + material1;
            Destroy(other.gameObject);

            if(material1 == 12)
            {
                material1text.color = Color.green;
                material1Img.SetActive(true);
                number4Star += 1;
                starGet(number4Star);
            }
        }

        if (other.tag == "milkNumber4" && material2 < 8)
        {
            material2++;
            material2text.text = "" + material2;
            Destroy(other.gameObject);

            if (material2 == 8)
            {
                material2text.color = Color.green;
                material2Img.SetActive(true);
                number4Star += 1;
                starGet(number4Star);
            }
        }

        if (other.tag == "breadNumber4" && material3 < 7)
        {
            material3++;
            material3text.text = "" + material3;
            Destroy(other.gameObject);

            if (material3 == 7)
            {
                material3text.color = Color.green;
                material3Img.SetActive(true);
                number4Star += 1;
                starGet(number4Star);
            }
        }
    }
    private void starGet(int number4Star)
    {
        if (number4Star == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            board.SetActive(true);
            material1 = 12;
            material2 = 8;
            material3 = 7;

            material1text.color = Color.green;
            material1Img.SetActive(true);
            material1text.text = "" + material1;

            material2text.color = Color.green;
            material2Img.SetActive(true);
            material2text.text = "" + material2;

            material3text.color = Color.green;
            material3Img.SetActive(true);
            material3text.text = "" + material3;


        }
        else if (number4Star == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);

        }
        else if (number4Star == 1)
        {
            star1.SetActive(true);
        }
    }

    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }

    public void RightBasket()
    {
        move = 1;
    }

    public void LeftBasket()
    {
        move = -1;
    }

    public void StopBasket()
    {
        move = 0;
    }
}
