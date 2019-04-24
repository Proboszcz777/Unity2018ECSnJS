﻿using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[Serializable]
public struct MoveOffset : IComponentData
{
    public float3 Value;
}

public class MoveOffsetComponent : ComponentDataProxy<MoveOffset> { }
