using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TheaterDirector_WebGL : MonoBehaviour
{
    const int FRAME_RATE = 60;
    const int INITIAL_ALPHA = 255;

    const float INTERVAL = 1.0f;

    const int RANGE_VALUE_OF_CEILING_LIGHT = 50;
    const int RANGE_VALUE_OF_CEILING_DARK = 7;

    const int RANGE_VALUE_OF_SIDE_LIGHT = 10;
    const int RANGE_VALUE_OF_SIDE_DARK = 0;

    const int RANGE_VALUE_OF_DOOR_LIGHT = 30;
    const int RANGE_VALUE_OF_DOOR_DARK = 0;

    /* Ceiling Light Object */
    public GameObject CeilingLight;
    public GameObject BarLight_L;
    public GameObject BarLight_R;
    public GameObject BarLight_F;
    public GameObject BarLight_B;

    /* Side Light Object */
    public GameObject SideLight_L0;
    public GameObject SideLight_L1;
    public GameObject SideLight_L2;
    public GameObject SideLight_L3;
    public GameObject SideLight_L4;
    public GameObject SideLight_L5;
    public GameObject SideLight_R0;
    public GameObject SideLight_R1;
    public GameObject SideLight_R2;
    public GameObject SideLight_R3;
    public GameObject SideLight_R4;
    public GameObject SideLight_R5;

    /* Video Player */
    public GameObject VideoPlayer;

    /* Video UI*/
    public GameObject PlayButton;
    public GameObject AudioUI_Mute;
    public GameObject AudioUI_Play;

    /* Light Setting */
    private float Time_to_Change_CeilingLight = 3.0f;
    private float Time_to_Change_SideLight = 1.5f;
    private float Time_to_TurnLightOn = 1.5f;

    public enum STATE
    {
        INITIAL,
        TURN_OFF1_START,
        TURN_OFF1_FINISH,
        TURN_OFF2_START,
        TURN_OFF2_FINISH,
        PLAYING,
        TURN_ON_START,
        TURN_ON_FINISH,
    }

    public STATE state = STATE.INITIAL;



    private void Awake()
    {
        Application.targetFrameRate = FRAME_RATE;

        CeilingLight.GetComponent<Light>().range = RANGE_VALUE_OF_CEILING_LIGHT;
        AudioUI_Mute.SetActive(false);
        AudioUI_Play.SetActive(true);
    }


    IEnumerator CeilingLightFadeOut()
    {
        for (int i = 0; i < INITIAL_ALPHA; i++)
        {
            CeilingLight.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_CEILING_LIGHT - RANGE_VALUE_OF_CEILING_DARK) / (float)INITIAL_ALPHA;

            BarLight_L.GetComponent<Renderer>().material.color = BarLight_L.GetComponent<Renderer>().material.color - new Color32(0, 0, 0, 1);
            BarLight_R.GetComponent<Renderer>().material.color = BarLight_L.GetComponent<Renderer>().material.color - new Color32(0, 0, 0, 1);
            BarLight_F.GetComponent<Renderer>().material.color = BarLight_L.GetComponent<Renderer>().material.color - new Color32(0, 0, 0, 1);
            BarLight_B.GetComponent<Renderer>().material.color = BarLight_L.GetComponent<Renderer>().material.color - new Color32(0, 0, 0, 1);

            yield return new WaitForSeconds(Time_to_Change_CeilingLight / INITIAL_ALPHA);
        }

        CeilingLight.GetComponent<Light>().range = RANGE_VALUE_OF_CEILING_DARK;

        state = STATE.TURN_OFF1_FINISH;
    }

    IEnumerator SideLightFadeOut()
    {
        yield return new WaitForSeconds(INTERVAL);

        for (int i = 0; i < INITIAL_ALPHA; i++)
        {
            SideLight_L0.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_DOOR_LIGHT - RANGE_VALUE_OF_DOOR_DARK) / (float)INITIAL_ALPHA;
            SideLight_R0.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_DOOR_LIGHT - RANGE_VALUE_OF_DOOR_DARK) / (float)INITIAL_ALPHA;

            SideLight_L1.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_L2.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_L3.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_L4.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_L5.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R1.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R2.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R3.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R4.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R5.GetComponent<Light>().range -= (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;


            yield return new WaitForSeconds(Time_to_Change_SideLight / INITIAL_ALPHA);
        }

        CeilingLight.GetComponent<Light>().range = RANGE_VALUE_OF_CEILING_DARK;

        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(INTERVAL);
        }

        state = STATE.TURN_OFF2_FINISH;
    }

    IEnumerator LightOn()
    {
        /* Wait For 3 Seconds */
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(INTERVAL);
        }

        for (int i = 0; i < INITIAL_ALPHA; i++)
        {
            CeilingLight.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_CEILING_LIGHT - RANGE_VALUE_OF_CEILING_DARK) / (float)INITIAL_ALPHA;

            BarLight_L.GetComponent<Renderer>().material.color = BarLight_L.GetComponent<Renderer>().material.color + new Color32(0, 0, 0, 1);
            BarLight_R.GetComponent<Renderer>().material.color = BarLight_L.GetComponent<Renderer>().material.color + new Color32(0, 0, 0, 1);
            BarLight_F.GetComponent<Renderer>().material.color = BarLight_L.GetComponent<Renderer>().material.color + new Color32(0, 0, 0, 1);
            BarLight_B.GetComponent<Renderer>().material.color = BarLight_L.GetComponent<Renderer>().material.color + new Color32(0, 0, 0, 1);

            SideLight_L0.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_DOOR_LIGHT - RANGE_VALUE_OF_DOOR_DARK) / (float)INITIAL_ALPHA;
            SideLight_R0.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_DOOR_LIGHT - RANGE_VALUE_OF_DOOR_DARK) / (float)INITIAL_ALPHA;

            SideLight_L1.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_L2.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_L3.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_L4.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_L5.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R1.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R2.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R3.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R4.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;
            SideLight_R5.GetComponent<Light>().range += (float)(RANGE_VALUE_OF_SIDE_LIGHT - RANGE_VALUE_OF_SIDE_DARK) / (float)INITIAL_ALPHA;

            yield return new WaitForSeconds(Time_to_TurnLightOn / INITIAL_ALPHA);
        }

        CeilingLight.GetComponent<Light>().range = RANGE_VALUE_OF_CEILING_LIGHT;

        state = STATE.TURN_ON_FINISH;
    }

    private void FixedUpdate()
    {
        if (state == STATE.TURN_OFF1_FINISH)
        {
            StartCoroutine("SideLightFadeOut");
            state = STATE.TURN_OFF2_START;
        }

        if (state == STATE.TURN_OFF2_FINISH)
        {
            VideoPlayer.GetComponent<VideoPlayer>().Play();
            state = STATE.PLAYING;
        }

        if (state == STATE.PLAYING)
        {
            if (!VideoPlayer.GetComponent<VideoPlayer>().isPlaying)
            {
                StartCoroutine("LightOn");
                state = STATE.TURN_ON_START;
            }
        }

        if (state == STATE.TURN_ON_FINISH)
        {
            state = STATE.INITIAL;
            PlayButton.SetActive(true);
        }
    }

    public void StartPlaying()
    {
        if (state == STATE.INITIAL)
        {
            StartCoroutine("CeilingLightFadeOut");
            state = STATE.TURN_OFF1_START;
            PlayButton.SetActive(false);
        }
    }

    public void AudioMute()
    {
        VideoPlayer.GetComponent<VideoPlayer>().SetDirectAudioMute(0, true);
        AudioUI_Mute.SetActive(true);
        AudioUI_Play.SetActive(false);
    }

    public void AudioPlay()
    {
        VideoPlayer.GetComponent<VideoPlayer>().SetDirectAudioMute(0, false);
        AudioUI_Mute.SetActive(false);
        AudioUI_Play.SetActive(true);
    }
}
