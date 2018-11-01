using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public int hSpeed;
    public int vSpeed;
    public Rigidbody bullet;
    public int score = 0;
    public UnityEngine.UI.Text scoreText;

    // Use this for initialization
    void Start () {

       
	}

    public void IncreaseScore()
    {
        score = score + 10;
        scoreText.text = "Score " + score;
    }
	
	// Update is called once per frame
	void Update () {

        //kuunnellaan oikea-vasen input
        float h = Input.GetAxis("Horizontal");
        //liikutetaan kameraa oikea-vasen-suunnassa
        //neutraloidaan frame raten vaikutus
        transform.Translate(h * Time.deltaTime * hSpeed, 0, 0);

        //kuunnellan ylös-alas input
        float v = Input.GetAxis("Vertical");
        transform.Rotate(v * Time.deltaTime * vSpeed, 0, 0);

        //kuunnellaan fire1-painikkeen input
        if (Input.GetButtonDown("Fire1"))
        {
            //instantioidaan uusi tykinkuula
            Rigidbody r = Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
