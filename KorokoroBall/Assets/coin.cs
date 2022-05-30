using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    private void Start()
    {
        GameObject managerObject = GameObject.Find("GameManager");

        gameManager = managerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
       
    }
}
