/*************************************************************************
 *  Copyright © 2025 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SelectableDST.cs
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
    [AddComponentMenu("MGS/SelectableDST/SelectableDST")]
    public class SelectableDST : Selectable, IDST
    {
        protected override void Reset()
        {
            base.Reset();
            enabled = false;
        }

        public void DoStateTransition(int state, bool instant)
        {
            DoStateTransition((SelectionState)state, instant);
        }
    }
}