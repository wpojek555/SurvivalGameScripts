using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarController : MonoBehaviour
{
    private SwitchBetweenHotbarTilesTheme Tile1;
    private SwitchBetweenHotbarTilesTheme Tile2;
    private SwitchBetweenHotbarTilesTheme Tile3;
    private SwitchBetweenHotbarTilesTheme Tile4;
    private SwitchBetweenHotbarTilesTheme Tile5;
    private SwitchBetweenHotbarTilesTheme Tile6;
    private SwitchBetweenHotbarTilesTheme Tile7;
    private SwitchBetweenHotbarTilesTheme Tile8;
    private SwitchBetweenHotbarTilesTheme Tile9;

    private int indexOfTileInUse = 1;

    private void Start()
    {
        Tile1 = GameObject.Find("1").GetComponent<SwitchBetweenHotbarTilesTheme>();
        Tile2 = GameObject.Find("2").GetComponent<SwitchBetweenHotbarTilesTheme>();
        Tile3 = GameObject.Find("3").GetComponent<SwitchBetweenHotbarTilesTheme>();
        Tile4 = GameObject.Find("4").GetComponent<SwitchBetweenHotbarTilesTheme>();
        Tile5 = GameObject.Find("5").GetComponent<SwitchBetweenHotbarTilesTheme>();
        Tile6 = GameObject.Find("6").GetComponent<SwitchBetweenHotbarTilesTheme>();
        Tile7 = GameObject.Find("7").GetComponent<SwitchBetweenHotbarTilesTheme>();
        Tile8 = GameObject.Find("8").GetComponent<SwitchBetweenHotbarTilesTheme>();
        Tile9 = GameObject.Find("9").GetComponent<SwitchBetweenHotbarTilesTheme>();
    }
    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(indexOfTileInUse == 9) {
            indexOfTileInUse = 1;
            } 
            else
            {
                indexOfTileInUse += 1;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) {
            if (indexOfTileInUse == 1)
            {
                indexOfTileInUse = 9;
            }
            else
            {
                indexOfTileInUse -= 1;
            }
        }
        CheckNumbersOnKeyboardPressed();
        OnBeforeTransformParentChanged();
        
    }

    private void CheckNumbersOnKeyboardPressed()
    {
        if (Input.GetKey("1"))
        {
            indexOfTileInUse = 1;
        }
        if (Input.GetKey("2"))
        {
            indexOfTileInUse = 2;
        }
        if (Input.GetKey("3"))
        {
            indexOfTileInUse = 3;
        }
        if (Input.GetKey("4"))
        {
            indexOfTileInUse = 4;
        }
        if (Input.GetKey("5"))
        {
            indexOfTileInUse = 5;
        }
        if (Input.GetKey("6"))
        {
            indexOfTileInUse = 6;
        }
        if (Input.GetKey("7"))
        {
            indexOfTileInUse = 7;
        }
        if (Input.GetKey("8"))
        {
            indexOfTileInUse = 8;
        }
        if (Input.GetKey("9"))
        {
            indexOfTileInUse = 9;
        }
    }
    private void OnBeforeTransformParentChanged()
    {
        if(indexOfTileInUse == 1) 
        {
            Tile1.isInHand = true;
            Tile2.isInHand = false;
            Tile3.isInHand = false;
            Tile4.isInHand = false;
            Tile5.isInHand = false;
            Tile6.isInHand = false;
            Tile7.isInHand = false;
            Tile8.isInHand = false;
            Tile9.isInHand = false;
        }
        if (indexOfTileInUse == 2)
        {
            Tile1.isInHand = false;
            Tile2.isInHand = true;
            Tile3.isInHand = false;
            Tile4.isInHand = false;
            Tile5.isInHand = false;
            Tile6.isInHand = false;
            Tile7.isInHand = false;
            Tile8.isInHand = false;
            Tile9.isInHand = false;
        }
        if (indexOfTileInUse == 3)
        {
            Tile1.isInHand = false;
            Tile2.isInHand = false;
            Tile3.isInHand = true;
            Tile4.isInHand = false;
            Tile5.isInHand = false;
            Tile6.isInHand = false;
            Tile7.isInHand = false;
            Tile8.isInHand = false;
            Tile9.isInHand = false;
        }
        if (indexOfTileInUse == 4)
        {
            Tile1.isInHand = false;
            Tile2.isInHand = false;
            Tile3.isInHand = false;
            Tile4.isInHand = true;
            Tile5.isInHand = false;
            Tile6.isInHand = false;
            Tile7.isInHand = false;
            Tile8.isInHand = false;
            Tile9.isInHand = false;
        }
        if (indexOfTileInUse == 5)
        {
            Tile1.isInHand = false;
            Tile2.isInHand = false;
            Tile3.isInHand = false;
            Tile4.isInHand = false;
            Tile5.isInHand = true;
            Tile6.isInHand = false;
            Tile7.isInHand = false;
            Tile8.isInHand = false;
            Tile9.isInHand = false;
        }
        if (indexOfTileInUse == 6)
        {
            Tile1.isInHand = false;
            Tile2.isInHand = false;
            Tile3.isInHand = false;
            Tile4.isInHand = false;
            Tile5.isInHand = false;
            Tile6.isInHand = true;
            Tile7.isInHand = false;
            Tile8.isInHand = false;
            Tile9.isInHand = false;
        }
        if (indexOfTileInUse == 7)
        {
            Tile1.isInHand = false;
            Tile2.isInHand = false;
            Tile3.isInHand = false;
            Tile4.isInHand = false;
            Tile5.isInHand = false;
            Tile6.isInHand = false;
            Tile7.isInHand = true;
            Tile8.isInHand = false;
            Tile9.isInHand = false;
        }
        if (indexOfTileInUse == 8)
        {
            Tile1.isInHand = false;
            Tile2.isInHand = false;
            Tile3.isInHand = false;
            Tile4.isInHand = false;
            Tile5.isInHand = false;
            Tile6.isInHand = false;
            Tile7.isInHand = false;
            Tile8.isInHand = true;
            Tile9.isInHand = false;
        }
        if (indexOfTileInUse == 9)
        {
            Tile1.isInHand = false;
            Tile2.isInHand = false;
            Tile3.isInHand = false;
            Tile4.isInHand = false;
            Tile5.isInHand = false;
            Tile6.isInHand = false;
            Tile7.isInHand = false;
            Tile8.isInHand = false;
            Tile9.isInHand = true;
        }

    }
}
