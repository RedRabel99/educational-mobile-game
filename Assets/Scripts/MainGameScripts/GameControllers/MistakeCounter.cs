using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MistakeCounter : MonoBehaviour
{
    [SerializeField] GameController gameController;
    [SerializeField] Image [] crosses;
    short mistakeCounter;
    void Start()
    {
        CrossInit();
    }
    public void IncreaseMistakeValue()
    {
        crosses[++mistakeCounter - 1].color = new Color(1f, 1f, 1f, 1f);
        if (mistakeCounter == 3) gameController.pauseMenu.ActivateEndMenu();

        //musicManager.UpdateMusicPlayer(mistakeCounter);
    }

    public void DecreaseMistakeValue()
    {
        if (mistakeCounter > 0) crosses[--mistakeCounter].color = new Color(50f / 255f, 45f / 255f, 45f / 255f, 255f / 255f);
    }

    public bool AreThereMistakes()
    {
        return mistakeCounter > 0;
    }

    void CrossInit()
    {
        Color color = new Color(50f / 255f, 45f / 255f, 45f / 255f, 255f / 255f);
        for (int i = 0; i < crosses.Length; i++) crosses[i].color = color;
    }
}
