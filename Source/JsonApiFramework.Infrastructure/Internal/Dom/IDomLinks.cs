﻿// Copyright (c) 2015–Present Scott McDonald. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using JsonApiFramework.JsonApi;

namespace JsonApiFramework.Internal.Dom
{
    internal interface IDomLinks : IGetIsReadOnly
    {
        // PUBLIC PROPERTIES ////////////////////////////////////////////////
        #region Properties
        Links Links { get; }
        #endregion
    }
}