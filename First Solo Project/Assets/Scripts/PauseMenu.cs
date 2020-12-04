using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private Toggle m_MenuToggle;
	private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;
    public GameObject menu;
    public GameObject fpsController;
    private UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpsControllerScript;

    //public List<Sprite> Letters;

    public GameObject Letters;
    private Button[] LetterButtons;
    public Image[] LetterImages;
    //private int[] lettersfound = new int[9];

    public static PauseMenu instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one pause menu instance found");
            return;
        }
        instance = this;

        LetterButtons = Letters.GetComponentsInChildren<Button>();

        
        for (int i = 0; i < LetterButtons.Length; i++)
        {
            LetterImages[i].enabled = false;
            LetterButtons[i].interactable = false;
        }
        
        fpsControllerScript = fpsController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
    }


    #region menu on/off
    private void MenuOn ()
    {

        PlayerManager.instance.playing = false;

        fpsControllerScript.enabled = false;
        m_TimeScaleRef = Time.timeScale;
        Time.timeScale = 0f;

        m_VolumeRef = AudioListener.volume;
        AudioListener.volume = 0f;

        m_Paused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        menu.SetActive(true);
    }


    public void MenuOff ()
    {
        PlayerManager.instance.playing = true;

        fpsControllerScript.enabled = true;
        Time.timeScale = m_TimeScaleRef;
        AudioListener.volume = m_VolumeRef;
        m_Paused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        menu.SetActive(false);
    }


    

    void Update()
	{
		if(Input.GetKeyDown(KeyCode.Tab))
		{
            if (!m_Paused)
            {
                MenuOn();
            }
            else if (m_Paused)
            {
                MenuOff();
            }
        }
	}
    #endregion
    

    public void addLetter(int letterID)
    {
        //Debug.Log("letter before " + lettersfound[letterID - 1]);
        //lettersfound[letterID - 1] = 1;

        LetterButtons[letterID-1].interactable = true;
        LetterImages[letterID - 1].enabled = true;

        //Image img = 

        //Debug.Log("adding letter");

        //Debug.Log("letter after " + lettersfound[letterID - 1]);
    }
}
