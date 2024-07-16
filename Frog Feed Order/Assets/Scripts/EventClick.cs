using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class EventClick : MonoBehaviour, IPointerDownHandler
{
    private Frog frog;
    private void Awake()
    {
        frog = GetComponent<Frog>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            frog.isClicked();
        }
    }

    
}
