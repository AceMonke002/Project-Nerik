using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMagic : MonoBehaviour
{
    [Header("Colors")]
    public Color Blue; 
    public Color Red;
    public Color Green; 
    public Color Yellow;
    public Color Grey;

     private Renderer blockRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Shift)){
            if(Input.GetKeyDown(KeyCode.1)){
                 
                ChangeColor(Blue);

            }
        }   
        
    }

    void ChangeColor(Color newColor)
    {
        if (blockRenderer != null)
        {
            blockRenderer.material.color = newColor;
        }
    }
}
