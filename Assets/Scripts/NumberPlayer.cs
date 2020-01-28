using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberPlayer : MonoBehaviour
{
    public int playerNumber;
    // Start is called before the first frame update
    void Start()
    {
        playerNumber = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        switch (playerNumber)
        {
            case 1:
                gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("/marakame_idle_0");//"marakame_idle_0";
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("/serpiente4_0");
                break;
            case 3:
                gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("/jaguar_0");
                break;
            case 4:
                gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("/jabali_corriendo_0");
                break;
        }
    }
}
