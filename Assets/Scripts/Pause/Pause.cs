using System.Collections;
using UnityEngine;


public class Pause : MonoBehaviour,ICommandTranslator
{
    private void Start()
    {
        GameSession.Instance.AddCommandTranslator(this);    
    }

    public void TranslateCommand(ECommand command, PressedState state)
    {

    }
}
