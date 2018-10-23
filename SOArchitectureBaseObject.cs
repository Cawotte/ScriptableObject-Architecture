﻿using UnityEngine;

/// <summary>
/// Base class for SOArchitecture assets
/// Implements developer descriptions
/// </summary>
public abstract class SOArchitectureBaseObject : ScriptableObject
{
#if UNITY_EDITOR
#pragma warning disable 0414
    [SerializeField]
    private DeveloperDescription DeveloperDescription = new DeveloperDescription();
#pragma warning restore
#endif
}