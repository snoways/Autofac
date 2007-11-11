﻿// This software is part of the Autofac IoC container
// Copyright (c) 2007 Nicholas Blumhardt
// nicholas.blumhardt@gmail.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autofac
{
    /// <summary>
    /// Allows registrations to be accessed by the resolve infrastructure.
    /// </summary>
    interface IContainer
    {
        /// <summary>
        /// Gets a registration from the container by key.
        /// </summary>
        /// <param name="key">The key for the registration (name or generated service key.)</param>
        /// <param name="registration">The registration result.</param>
        /// <param name="disposer">The disposer that should be used to dispose of instances activated by
        /// the registration.</param>
        /// <param name="context">The context that should be used when activating instances from the
        /// registration.</param>
        /// <returns></returns>
        bool TryGetRegistration(
            string key, 
            out IComponentRegistration registration, 
            out IDisposer disposer,
            out IContext context);
    }
}