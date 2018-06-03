using UnityEngine;
using UnityEngine.Experimental.UIElements;

//Made By Anthony Romrell
public class TextKeyEvent : MonoBehaviour
{
    private readonly KeyDownEvent KeyEvent = new KeyDownEvent();


    public void Update()
    {
        if (KeyEvent.keyCode == KeyCode.A) print("Cool");
    }
}