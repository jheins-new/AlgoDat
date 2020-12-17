using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BuildHeap : MonoBehaviour
{
    [SerializeField]
    public Transform[] target = new Transform[15];
    
  //  public Vector3[] targetPos = new Vector3[15];
    [SerializeField]
    public Transform[] curr = new Transform[15];
   
    
    public Transform collTarget;
   
    public bool done = false;
   
    
    public Button yourButton;

    public int k = 0;

   

    public float speed = 2.0f;

    void Awake()
    {
        
    }

        void Start()
        {
            Button btn = yourButton.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
            StartCoroutine(MoveToColl());               //Starts routine to move objects
         }




        void Update()
        {
            if (done)
            {
                StartCoroutine(MoveToTarget());        //Not good, read comments at line 72/73
                
            }

         }


    IEnumerator MoveToColl()            //TEST > Move to collision cube 
    {
        foreach(Transform cp in curr) { 
            while (cp.position != collTarget.position)
            {
                cp.position = Vector3.MoveTowards(cp.position, collTarget.position, speed * Time.deltaTime);
                yield return null;
              
            }
            
        }
        done = true;
    }


    IEnumerator MoveToTarget()  //TEST > Move from collision cube to targetpoints
                                //need to find a way to loop over both arrays via foreach, like in MoveToColl so one element at a time moves.
    {
       for(int i = 0; i<target.Length; i++) {
               curr[i].position = Vector3.MoveTowards(curr[i].position, target[i].position, speed * Time.deltaTime);
                 yield return null;
        }

}


    void TaskOnClick()  //For test purposes not needed
        {
        
        }

}
