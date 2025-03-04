﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Health playerHealt;

    private void Start()
    {
        SetMaxHealt(playerHealt.maxHealth);
    }
    private void Update()
    {
        SetHealth(playerHealt.health);
    }

    public void SetMaxHealt(int Health)
    {
        slider.maxValue = Health;
        slider.value = Health;
    }
    public void SetHealth(int Health)
    {
        slider.value = Health;
    }
}