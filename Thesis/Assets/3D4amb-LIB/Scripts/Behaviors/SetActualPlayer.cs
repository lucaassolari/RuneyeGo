﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simple script used to reload the player settings while the panels of the mainmenu
/// are opened/closed
/// </summary>
public class SetActualPlayer : MonoBehaviour
{
    public GameObject PrefManager;

    /// <summary>
    /// Reload the PlayerSettings form the PrefManager
    /// </summary>
    public void ReloadPlayerSettings()
    {
        PrefManager prefManager = PrefManager.GetComponent<PrefManager>();
        prefManager.actualPlayerSettings = prefManager.LoadPlayerSettings();
    }
}
