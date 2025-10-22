using System.Collections.Generic;
using UnityEngine;

public class AlmanacManager : MonoBehaviour
{
    [Header("Display Panels - Drag ALL display panels here")]
    public List<GameObject> displayPanels = new List<GameObject>();

    void Start()
    {
        // Disable all panels when the game starts
        DisableAllPanels();
    }

    public void ShowPanel(GameObject panelToShow)
    {
        // If clicking the same panel that's already active, close it
        if (panelToShow.activeInHierarchy)
        {
            panelToShow.SetActive(false);
            return;
        }

        // Otherwise, close all panels and open the requested one
        DisableAllPanels();
        panelToShow.SetActive(true);
    }

    public void DisableAllPanels()
    {
        foreach (GameObject panel in displayPanels)
        {
            if (panel != null)
                panel.SetActive(false);
        }
    }
}