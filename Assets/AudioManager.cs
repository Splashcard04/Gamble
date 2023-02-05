using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public void muteAudio(bool muted)
    {
        if(muted)
        {
            AudioListener.volume = 0;
        } else
        {
            AudioListener.volume = 1;
        }
    }
}
