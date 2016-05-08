using System;
using UnityEngine;
using CnControls;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
    public class StandaloneInput : VirtualInput
    {
        public override float GetAxis(string name, bool raw)
        {
            return raw ? CnInputManager.GetAxisRaw(name) : CnInputManager.GetAxis(name);
        }


        public override bool GetButton(string name)
        {
            return CnInputManager.GetButton(name);
        }


        public override bool GetButtonDown(string name)
        {
            return CnInputManager.GetButtonDown(name);
        }


        public override bool GetButtonUp(string name)
        {
            return CnInputManager.GetButtonUp(name);
        }


        public override void SetButtonDown(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetButtonUp(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisPositive(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisNegative(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisZero(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxis(string name, float value)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override Vector3 MousePosition()
        {
            return Input.mousePosition;
        }
    }
}