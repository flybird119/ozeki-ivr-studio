﻿using System;

namespace IVRStudio.Util
{
    class FileOperationMessage
    {
        public Action<string> Callback { get; private set; }

        public FileOperationMessage(Action<string> callback)
        {
            Callback = callback;
        }
    }
}
