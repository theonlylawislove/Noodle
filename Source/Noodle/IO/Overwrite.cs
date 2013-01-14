﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Noodle.IO
{
    /// <summary>
    /// Overwriting policy.
    /// </summary>
    public enum Overwrite
    {
        /// <summary>
        /// Always overwrite the destination if it exists.
        /// </summary>
        Always,
        /// <summary>
        /// Never overwrite the destination and leave existing files as they are.
        /// <remarks>
        /// Methods should not throw if the destination file exists and
        /// do nothing instead. There is a throw value for that.
        /// </remarks>
        /// </summary>
        Never,
        /// <summary>
        /// Only overwrite an existing destination file with the same name
        /// if the source file is newer.
        /// <remarks>This value is recommended as the default.</remarks>
        /// </summary>
        IfNewer,
        /// <summary>
        /// Throw if the destination file already exists.
        /// </summary>
        Throw
    }
}
