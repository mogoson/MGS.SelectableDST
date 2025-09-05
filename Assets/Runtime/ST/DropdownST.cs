/*************************************************************************
 *  Copyright © 2025 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  DropdownST.cs
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
    [AddComponentMenu("MGS/SelectableDST/DropdownST")]

    public class DropdownST : Dropdown
    {
        protected IDST[] dsts = new IDST[0];

        protected override void Awake()
        {
            base.Awake();
            dsts = GetComponentsInChildren<IDST>();
        }

        protected override void DoStateTransition(SelectionState state, bool instant)
        {
            base.DoStateTransition(state, instant);
            foreach (var dst in dsts)
            {
                dst.DoStateTransition((int)state, instant);
            }
        }
    }
}