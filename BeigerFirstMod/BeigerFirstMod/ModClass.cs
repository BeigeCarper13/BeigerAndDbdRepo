﻿using System;
using System.Collections;
using System.Collections.Generic;
using Modding;
using UnityEngine;
using UObject = UnityEngine.Object;

namespace BeigerFirstMod
{
    public class BeigerFirstMod : Mod
    {
        internal static BeigerFirstMod Instance;

        //public override List<ValueTuple<string, string>> GetPreloadNames()
        //{
        //    return new List<ValueTuple<string, string>>
        //    {
        //        new ValueTuple<string, string>("White_Palace_18", "White Palace Fly")
        //    };
        //}

        //public BeigerFirstMod() : base("BeigerFirstMod")
        //{
        //    Instance = this;
        //}

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
        {
            Log("Initializing");

            Instance = this;

            Log("Initialized");
        }
    }
}