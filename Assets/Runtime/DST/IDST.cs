/*************************************************************************
 *  Copyright © 2025 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IDST.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  9/5/2025
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.SelectableDST
{
    public interface IDST
    {
        void DoStateTransition(int state, bool instant);
    }
}