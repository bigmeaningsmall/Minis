using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRecieverExample : MonoBehaviour
{
    private void OnEnable(){
        NoteCallback.OnNoteAction += NoteCallbackOnNoteAction;
    }
    private void OnDisable(){
        NoteCallback.OnNoteAction -= NoteCallbackOnNoteAction;
    }
    private void NoteCallbackOnNoteAction(bool on, int num, string name, float vel){
        Debug.Log(on + " : " + num + " : " + name + " : " + vel);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
