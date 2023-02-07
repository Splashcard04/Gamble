using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamble : MonoBehaviour
{

    public float rnd = 0f;

    public Text changingText;
    public int textPoints;
    public Text points;
    public GameObject inputFeild;
    public Text warning;

    void Start()
    {
        textPoints = 20;
    }

    public AudioSource succeed;
    public AudioClip succeedSounds;

    public AudioSource fail;
    public AudioClip failSounds;

    public void gameGenerate()
    {
        rnd = Random.Range(0, 50);

        string amount = inputFeild.GetComponent<Text>().text;

        int parsedInt = int.Parse(amount);

        if(parsedInt > textPoints)
        {
            fail.PlayOneShot(failSounds);
            warning.text = "Not Enough Points!!";
        }

        if(parsedInt == 0)
        {
            fail.PlayOneShot(failSounds);
            warning.text = "You can't bet 0!";
        }

        if(parsedInt == 6969420) /*ignore this*/
        {
            warning.text = "Funny Number!!!!!!",
            textPoints = 69696969
        } else { 
                    if(parsedInt < 0)
        {
            fail.PlayOneShot(failSounds);
            warning.text = "You can't bet a negative number!";
        } else
        {
            if (parsedInt <= textPoints)
            {
                warning.text = "No Error!";

                if (rnd < 22)
                {
                    succeed.PlayOneShot(succeedSounds);
                    changingText.text = "Win!";
                    textPoints = textPoints + parsedInt;
                }
                else
                {
                    fail.PlayOneShot(failSounds);
                    changingText.text = "Loss";
                    textPoints = textPoints - parsedInt;
                }
            }
        }
        }

    }

    public void FixedUpdate()
    {
        points.text = "Score:"+textPoints.ToString();

        if(textPoints < 0) 
        {
            //back to start manager if user loses all points
            SceneManager.LoadScene(0);
        }
    }

}
