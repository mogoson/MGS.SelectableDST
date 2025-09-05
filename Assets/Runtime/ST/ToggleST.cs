/*************************************************************************
 *  Copyright © 2025 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ToggleST.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  9/5/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.SelectableDST
{
    [AddComponentMenu("MGS/SelectableDST/ToggleST")]

    public class ToggleST : Toggle
    {
        protected IDST[] dsts = new IDST[0];

        protected override void Awake()
        {
            base.Awake();
            dsts = GetComponentsInChildren<IDST>();
            onValueChanged.AddListener(OnValueChanged);
        }

        protected virtual void OnValueChanged(bool isOn)
        {
            var state = isOn ? SelectionState.Selected : SelectionState.Normal;
            DoStateTransition(state, false);
        }

        protected override void DoStateTransition(SelectionState state, bool instant)
        {
            state = isOn ? SelectionState.Selected : state;
            base.DoStateTransition(state, instant);
            foreach (var dst in dsts)
            {
                dst.DoStateTransition((int)state, instant);
            }
        }
    }
}