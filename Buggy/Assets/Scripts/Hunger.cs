using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : MonoBehaviour
{
    //private foodScript _foodScr;
    //private CurrencyScript _currencyScript;
    //private int _money = 10;
    //_currency
    int increase_score;
    public GameObject _objectWithCurrencyScript;
    public GameObject _objectWithButtonInteractionScript;
    public GameObject _objectWithCollisionScript;
 
    
    void Start() 
    {
      

    }

    public void OnCollisionEnter(Collision collision)
    {    
        if (collision.collider.CompareTag("Food")) 
        {
            Destroy(collision.gameObject);
            Debug.Log("Food Collected");

            
            //_currencyScript.ModifyMoney(_money); // Calls currency update
            // new WaitForSeconds(5); // Delay

        }
            
    }  

}
