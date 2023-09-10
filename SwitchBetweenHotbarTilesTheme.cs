using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBetweenHotbarTilesTheme : MonoBehaviour
{
    [SerializeField] private GameObject inUse;
    [SerializeField] private GameObject inHand;

    public bool isInHand;

    private void Update()
    {
        if (isInHand)
        {
            inHand.SetActive(true);
            inUse.SetActive(false);
        } else
        {
            inHand.SetActive(false);
            inUse.SetActive(true);
        }
    }
}
