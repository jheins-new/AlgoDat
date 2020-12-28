using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsToNumber : MonoBehaviour
{

    
    GameObject[] items;
    public Hashtable itemsList = new Hashtable();
    
    // Start is called before the first frame update
    void Start()
    {
       
        items = GameObject.FindGameObjectsWithTag("item");  //search GameObject for tag item and put them into a array
        
        for(int i = 0; i<items.Length; i++)             
        {
          
            Debug.Log("Item Number " + i + " is named " + items[i].name);

            if (items[i].name == "TV")                  //if the names are found in the array, the co2 number is added to the item names here
            {

                itemsList.Add("TV", 300);
                int tv = (int)itemsList["TV"];
                Debug.Log(tv);
            }
            
            if (items[i].name == "Auto")
            {
                itemsList.Add("Auto", 7000);
            }
        }

        if (itemsList.Contains("Auto"))
        {
            Debug.Log((int)itemsList["Auto"]);          //output of the numbers
        }
        else
        {
            Debug.Log("Auto isnt stored");
        }

        
    }

   
}

