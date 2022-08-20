using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MeatCooking : MonoBehaviour
{
    public Sprite meatCooking;
    public Sprite meatBurning;
    public DragDrop dragDrop;
    


    [SerializeField]private float timeForntCooking = 10f;
    [SerializeField] private float timeBehineCooking = 10f;

    private bool isForntCooking, isBehineCooking;
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }


    void Update()
    {
        if (FlipMeat.isFornt)
        {
            ForntCooking();
        }
        else if(FlipMeat.isFornt == false)
        {
            BehineCooking();
        }

    }

    private void ForntCooking()
    {
        if (isForntCooking)
        {
            timeForntCooking -= Time.deltaTime;
        }


        if (timeForntCooking <= 0f && timeForntCooking >= -6f)
        {
            image.sprite = meatCooking;
        }
        else if (timeForntCooking <= -7f && timeForntCooking >= -9f)
        {
            image.sprite = meatBurning;
        }
        else if (timeForntCooking <= -10f)
        {
            Destroy(gameObject);
        }
    }

    private void BehineCooking()
    {
        if (isBehineCooking)
        {
            timeBehineCooking -= Time.deltaTime;
        }


        if (timeBehineCooking <= 0f && timeBehineCooking >= -6f)
        {
            image.sprite = meatCooking;
        }
        else if (timeBehineCooking <= -7f && timeBehineCooking >= -9f)
        {
            image.sprite = meatBurning;
        }
        else if (timeBehineCooking <= -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Cooking");
        isForntCooking = true;
        isForntCooking = true;
    }

    protected void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("is not Cooking");
        isForntCooking = false;
        isForntCooking = false;
    }
}
