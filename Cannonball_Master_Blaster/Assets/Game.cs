using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game: MonoBehaviour {

    public int hSpeed;
    public int vSpeed;
    public Rigidbody bullet;
    public int score = 0;
    public UnityEngine.UI.Text scoreText;

    // Use this for initialization
    void Start () {
        
	}

    public void increaseScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
	
	// Update is called once per frame
	void Update () {

        //kuunnellaan oikea-vasen inputtia
        float h = Input.GetAxis("Horizontal");
        //liikutetaan kameraa inputin mukaan
        //neutraloidaan frame raten vaikutus
        transform.Translate(h * Time.deltaTime * hSpeed, 0, 0);

        //kuunnellaa ylös-alas inputtia
        float v = Input.GetAxis("Vertical");
        //käännetään kameran kulmaan inputin mukaan
        transform.Rotate(v * Time.deltaTime * vSpeed, 0, 0);

        //kuunnellaan fire1-painikkeen inputtia
        if (Input.GetButtonDown("Fire1"))
        {
            //instantoidaan uusi tykinkuula
            Rigidbody r = Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
