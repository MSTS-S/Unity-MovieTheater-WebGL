using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeatChangeScript : MonoBehaviour
{
    const float DX = 0.0f;
    const float DY = 1.1f;
    const float DZ = 0.1f;

    const int ROW_SIZE = 8;
    const int COLUMN_SIZE = 11; 

    public GameObject MainCamera;

    /* Object : Seat */
    public GameObject[] SA = new GameObject[COLUMN_SIZE];
    public GameObject[] SB = new GameObject[COLUMN_SIZE];
    public GameObject[] SC = new GameObject[COLUMN_SIZE];
    public GameObject[] SD = new GameObject[COLUMN_SIZE];
    public GameObject[] SE = new GameObject[COLUMN_SIZE];
    public GameObject[] SF = new GameObject[COLUMN_SIZE];
    public GameObject[] SG = new GameObject[COLUMN_SIZE];
    public GameObject[] SH = new GameObject[COLUMN_SIZE];

    /* Object : Button */
    public GameObject[] BA = new GameObject[COLUMN_SIZE];
    public GameObject[] BB = new GameObject[COLUMN_SIZE];
    public GameObject[] BC = new GameObject[COLUMN_SIZE];
    public GameObject[] BD = new GameObject[COLUMN_SIZE];
    public GameObject[] BE = new GameObject[COLUMN_SIZE];
    public GameObject[] BF = new GameObject[COLUMN_SIZE];
    public GameObject[] BG = new GameObject[COLUMN_SIZE];
    public GameObject[] BH = new GameObject[COLUMN_SIZE];

    private int[] SeatPosition = {5, 5};

    private void Awake()
    {
        G06();
    }

    private void SetSeatPosition(int row, int col)
    {
        /* Change Previous Seat Color : White */
        if (SeatPosition[0] == 0) BA[SeatPosition[1]].GetComponent<Image>().color = Color.white;
        if (SeatPosition[0] == 1) BB[SeatPosition[1]].GetComponent<Image>().color = Color.white;
        if (SeatPosition[0] == 2) BC[SeatPosition[1]].GetComponent<Image>().color = Color.white;
        if (SeatPosition[0] == 3) BD[SeatPosition[1]].GetComponent<Image>().color = Color.white;
        if (SeatPosition[0] == 4) BE[SeatPosition[1]].GetComponent<Image>().color = Color.white;
        if (SeatPosition[0] == 5) BF[SeatPosition[1]].GetComponent<Image>().color = Color.white;
        if (SeatPosition[0] == 6) BG[SeatPosition[1]].GetComponent<Image>().color = Color.white;
        if (SeatPosition[0] == 7) BH[SeatPosition[1]].GetComponent<Image>().color = Color.white;

        /* Change Current Seat Color : Red */
        if (row == 0)
        {
            MainCamera.transform.position = SA[col].transform.position + new Vector3(DX, DY, DZ);
            BA[col].GetComponent<Image>().color = Color.red;
        }
        if (row == 1)
        {
            MainCamera.transform.position = SB[col].transform.position + new Vector3(DX, DY, DZ);
            BB[col].GetComponent<Image>().color = Color.red;
        }
        if (row == 2)
        {
            MainCamera.transform.position = SC[col].transform.position + new Vector3(DX, DY, DZ);
            BC[col].GetComponent<Image>().color = Color.red;
        }
        if (row == 3)
        {
            MainCamera.transform.position = SD[col].transform.position + new Vector3(DX, DY, DZ);
            BD[col].GetComponent<Image>().color = Color.red;
        }
        if (row == 4)
        {
            MainCamera.transform.position = SE[col].transform.position + new Vector3(DX, DY, DZ);
            BE[col].GetComponent<Image>().color = Color.red;
        }
        if (row == 5)
        {
            MainCamera.transform.position = SF[col].transform.position + new Vector3(DX, DY, DZ);
            BF[col].GetComponent<Image>().color = Color.red;
        }
        if (row == 6)
        {
            MainCamera.transform.position = SG[col].transform.position + new Vector3(DX, DY, DZ);
            BG[col].GetComponent<Image>().color = Color.red;
        }
        if (row == 7)
        {
            MainCamera.transform.position = SH[col].transform.position + new Vector3(DX, DY, DZ);
            BH[col].GetComponent<Image>().color = Color.red;
        }

        SeatPosition[0] = row;
        SeatPosition[1] = col;
    }

    public void A01() { SetSeatPosition(0, 0); }
    public void A02() { SetSeatPosition(0, 1); }
    public void A03() { SetSeatPosition(0, 2); }
    public void A04() { SetSeatPosition(0, 3); }
    public void A05() { SetSeatPosition(0, 4); }
    public void A06() { SetSeatPosition(0, 5); }
    public void A07() { SetSeatPosition(0, 6); }
    public void A08() { SetSeatPosition(0, 7); }
    public void A09() { SetSeatPosition(0, 8); }
    public void A10() { SetSeatPosition(0, 9); }
    public void A11() { SetSeatPosition(0, 10); }
    public void B01() { SetSeatPosition(1, 0); }
    public void B02() { SetSeatPosition(1, 1); }
    public void B03() { SetSeatPosition(1, 2); }
    public void B04() { SetSeatPosition(1, 3); }
    public void B05() { SetSeatPosition(1, 4); }
    public void B06() { SetSeatPosition(1, 5); }
    public void B07() { SetSeatPosition(1, 6); }
    public void B08() { SetSeatPosition(1, 7); }
    public void B09() { SetSeatPosition(1, 8); }
    public void B10() { SetSeatPosition(1, 9); }
    public void B11() { SetSeatPosition(1, 10); }
    public void C01() { SetSeatPosition(2, 0); }
    public void C02() { SetSeatPosition(2, 1); }
    public void C03() { SetSeatPosition(2, 2); }
    public void C04() { SetSeatPosition(2, 3); }
    public void C05() { SetSeatPosition(2, 4); }
    public void C06() { SetSeatPosition(2, 5); }
    public void C07() { SetSeatPosition(2, 6); }
    public void C08() { SetSeatPosition(2, 7); }
    public void C09() { SetSeatPosition(2, 8); }
    public void C10() { SetSeatPosition(2, 9); }
    public void C11() { SetSeatPosition(2, 10); }
    public void D01() { SetSeatPosition(3, 0); }
    public void D02() { SetSeatPosition(3, 1); }
    public void D03() { SetSeatPosition(3, 2); }
    public void D04() { SetSeatPosition(3, 3); }
    public void D05() { SetSeatPosition(3, 4); }
    public void D06() { SetSeatPosition(3, 5); }
    public void D07() { SetSeatPosition(3, 6); }
    public void D08() { SetSeatPosition(3, 7); }
    public void D09() { SetSeatPosition(3, 8); }
    public void D10() { SetSeatPosition(3, 9); }
    public void D11() { SetSeatPosition(3, 10); }
    public void E01() { SetSeatPosition(4, 0); }
    public void E02() { SetSeatPosition(4, 1); }
    public void E03() { SetSeatPosition(4, 2); }
    public void E04() { SetSeatPosition(4, 3); }
    public void E05() { SetSeatPosition(4, 4); }
    public void E06() { SetSeatPosition(4, 5); }
    public void E07() { SetSeatPosition(4, 6); }
    public void E08() { SetSeatPosition(4, 7); }
    public void E09() { SetSeatPosition(4, 8); }
    public void E10() { SetSeatPosition(4, 9); }
    public void E11() { SetSeatPosition(4, 10); }
    public void F01() { SetSeatPosition(5, 0); }
    public void F02() { SetSeatPosition(5, 1); }
    public void F03() { SetSeatPosition(5, 2); }
    public void F04() { SetSeatPosition(5, 3); }
    public void F05() { SetSeatPosition(5, 4); }
    public void F06() { SetSeatPosition(5, 5); }
    public void F07() { SetSeatPosition(5, 6); }
    public void F08() { SetSeatPosition(5, 7); }
    public void F09() { SetSeatPosition(5, 8); }
    public void F10() { SetSeatPosition(5, 9); }
    public void F11() { SetSeatPosition(5, 10); }
    public void G01() { SetSeatPosition(6, 0); }
    public void G02() { SetSeatPosition(6, 1); }
    public void G03() { SetSeatPosition(6, 2); }
    public void G04() { SetSeatPosition(6, 3); }
    public void G05() { SetSeatPosition(6, 4); }
    public void G06() { SetSeatPosition(6, 5); }
    public void G07() { SetSeatPosition(6, 6); }
    public void G08() { SetSeatPosition(6, 7); }
    public void G09() { SetSeatPosition(6, 8); }
    public void G10() { SetSeatPosition(6, 9); }
    public void G11() { SetSeatPosition(6, 10); }
    public void H01() { SetSeatPosition(7, 0); }
    public void H02() { SetSeatPosition(7, 1); }
    public void H03() { SetSeatPosition(7, 2); }
    public void H04() { SetSeatPosition(7, 3); }
    public void H05() { SetSeatPosition(7, 4); }
    public void H06() { SetSeatPosition(7, 5); }
    public void H07() { SetSeatPosition(7, 6); }
    public void H08() { SetSeatPosition(7, 7); }
    public void H09() { SetSeatPosition(7, 8); }
    public void H10() { SetSeatPosition(7, 9); }
    public void H11() { SetSeatPosition(7, 10); }
}
