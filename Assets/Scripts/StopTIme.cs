using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTIme : MonoBehaviour
{
    public CatMoveAway cat;
    public CatMoveAway cat1;
    public CatMoveAway cat2;

    bool timerCheck;
    // Start is called before the first frame update
    void Start()
    {
        cat.GetComponent<CatMoveAway>();
        cat1.GetComponent<CatMoveAway>();
        cat2.GetComponent<CatMoveAway>();

        timerCheck = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerCheck) {
            if (Input.GetKeyDown("z")) {
                cat.distancePerSecond = 0f;
                cat1.distancePerSecond = 0f;
                cat2.distancePerSecond = 0f;

                StartCoroutine(Countdown());
            }
        }
    }
    
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(5);
        
        if (cat.outsideHouse) {
            cat.distancePerSecond = 0.5f;
        }
        if (cat1.outsideHouse) {
            cat1.distancePerSecond = 0.5f;
        }
        if (cat2.outsideHouse) {
            cat2.distancePerSecond = 0.5f;
        }
        timerCheck = false;
    }  
}
