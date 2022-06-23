﻿// --------------------------------------------------------------- 
// Copyright (c) Microsoft Corporation. All rights reserved. 
// ---------------------------------------------------------------

using Xeptions;

namespace DMX.Portal.Web.Models.Labs.Exceptions
{
    public class NullLabException : Xeption
    {
        public NullLabException()
            : base(message: "Lab is null.")
        { }
    }
}
