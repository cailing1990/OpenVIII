﻿using System;

namespace OpenVIII
{
    public partial class Module_main_menu_debug
    {

        #region Enums

        /// <summary>
        /// Flags for cursor behavior
        /// </summary>
        /// <remarks>Defaults to disabled.</remarks>
        [Flags]
        public enum Cursor_Status
        {
            /// <summary>
            /// Hide Cursor and disable all code that uses it.
            /// </summary>
            Disabled = 0x0,

            /// <summary>
            /// Show Cursor
            /// </summary>
            Enabled = 0x1,

            /// <summary>
            /// Triggers blinking
            /// </summary>
            Blinking = 0x2,

            /// <summary>
            /// Makes it react to left and right instead of up and down.
            /// </summary>
            Horizontal = 0x4,

            /// <summary>
            /// This is the default but if you want both directions you need to set the flag.
            /// </summary>
            Vertical = 0x8,

            /// <summary>
            /// Just draw.
            /// </summary>
            Draw = 0x10,
        }

        #endregion Enums

    }
}