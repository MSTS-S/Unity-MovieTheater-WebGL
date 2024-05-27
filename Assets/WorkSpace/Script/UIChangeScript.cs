using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChangeScript : MonoBehaviour
{
    public GameObject SeatPanel;
    public GameObject SeatIcon;

    private void Awake()
    {
        SeatPanel.SetActive(true);
        SeatIcon.SetActive(false);
    }

    public void DisplaySeatPanel()
    {
        SeatPanel.SetActive(true);
        SeatIcon.SetActive(false);
    }

    public void DiscloseSeatPanel()
    {
        SeatPanel.SetActive(false);
        SeatIcon.SetActive(true);
    }
}
