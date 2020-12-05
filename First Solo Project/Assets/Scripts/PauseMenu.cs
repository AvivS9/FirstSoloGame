using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    private Toggle m_MenuToggle;
	private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    private bool m_Paused;
    public GameObject menu;
    public GameObject fpsController;
    private UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpsControllerScript;

    public Sprite[] PoemParts;
    public GameObject Letters;
    private Button[] SlotButtons;
    public Image[] SlotImages;

    public GameObject LetterToShowPanel;
    public Image LetterToShowImage;

    bool LetterOpened = false;
    

    public static PauseMenu instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one pause menu instance found");
            return;
        }
        instance = this;
        LetterToShowPanel.SetActive(false);
        SlotButtons = Letters.GetComponentsInChildren<Button>();

        
        for (int i = 0; i < SlotButtons.Length; i++)
        {
            SlotImages[i].enabled = false;
            SlotButtons[i].interactable = false;
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
        if (Input.anyKeyDown && LetterOpened == true)
        {
            LetterOpened = false;
            LetterToShowPanel.SetActive(false);
        }

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

        SlotButtons[letterID-1].interactable = true;
        SlotImages[letterID - 1].enabled = true;

    }

    public void showLetter(int id)
    {
        LetterToShowImage.sprite = PoemParts[id - 1];
        LetterOpened = true;
        LetterToShowPanel.SetActive(true);
        //Debug.Log("showing letter with button " + id);
    }

    
}
