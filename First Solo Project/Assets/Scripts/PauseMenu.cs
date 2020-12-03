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

    public List<Sprite> Letters = new List<Sprite>(9);

    public int[] foundLetters = new int[9];

    public static PauseMenu instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one pause menu instance found");
            return;
        }
        instance = this;

        fpsControllerScript = fpsController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
    }


    #region menu on/off
    private void MenuOn ()
    {

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
        Debug.Log("adding letter");
    }
}
