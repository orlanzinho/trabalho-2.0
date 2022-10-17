using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CriaMoeda : MonoBehaviour
{
    public GameObject moeda;
    
    // Start is called before the first frame update
    void Start()
    {
        
        CriaReta();
        CriaReta2();
        CriaVertical();
       CriaVertical2();
    }
    void CriaReta(){
        float y;
        for (float x = 0.0f; x < 5.0f; x += 1.25f)
        {
            // reta
            y = 0.0f * x + 5.0f;
                Instantiate(moeda, new Vector3(y,x,-2), Quaternion.identity);
        }
    }
    void CriaReta2()
    {
        float y;
        for (float x = 0.0f; x < 5.0f; x += 1.25f)
        {
            // reta
            y = 0.0f * x - 2.4f;
            Instantiate(moeda, new Vector3(y, x, -2), Quaternion.identity);
        }
    }
        void CriaVertical(){
            float y;
        for (float x = -1.2f; x < 5.0f; x += 0.9f)
            {
            // reta
            y = 0.0f * x - 0.0f;
                    Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
            }
        }
    void CriaVertical2()
    {
        float y;
        for (float x = -1.2f; x < 5.0f; x += 0.9f)
        {
            // reta
            y = 0.0f * x + 3.75f;
            Instantiate(moeda, new Vector3(x, y, -2), Quaternion.identity);
        }
    }


    void CriaParabola(){
        float y;

        for (float x = -10; x < 10; x+=0.9f)
        {
            
                // parábola
                y = (float)(-0.1*x*x+2*x+0);
            
                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
                
            
        }
    }
    void CriaCircunferencia(){
        float y,x;
        float raio = 2.5f;

        for (double teta = 0; teta <  Math.PI; teta+=0.3)
        {
            
                //circunferência
                x = (float)(raio*Math.Cos(teta));
                y = (float)(raio*Math.Sin(teta));

                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}