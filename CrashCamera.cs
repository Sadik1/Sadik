//
// File : CrashCamera.cs
//
// Author: Simon Corsin <>
//
// Copyright (c) 2014 Ever SAS
//
// Using or modifying this source code is strictly reserved to Ever SAS.
using System;
using SCorsin;
using System.Collections.Generic;
using MonoTouch.AVFoundation;
using MonoTouch.Foundation;
using MonoTouch.CoreMedia;

namespace Xamarin.Crash {
    public class CrashCamera : SCCamera {

        ////////////////////////////////////
        // PROPERTIES
        ////////////////////

        ////////////////////////////////////
        // CONSTRUCTORS
        ////////////////////

        public CrashCamera(Action<CrashCamera> onReadyCallback) : base(AVCaptureSession.PresetiFrame1280x720) {
            this.Initialize(delegate(NSError audioError, NSError videoError) {
                if (onReadyCallback != null) {
                    onReadyCallback(this);
                }
            });
        }

        ////////////////////////////////////
        // METHODS
        ////////////////////


    }
}

