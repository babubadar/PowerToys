﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.Tracing;
using Microsoft.PowerToys.Telemetry;
using Microsoft.PowerToys.Telemetry.Events;

namespace SvgPreviewHandler.Telemetry.Events
{
    /// <summary>
    /// A telemetry event to be raised when an error has occured in the preview pane.
    /// </summary>
    [EventData]
    public class SvgFilePreviewError : IEvent
    {
        /// <summary>
        /// Gets or sets the error messsage to log as part of the telemetry event.
        /// </summary>
        public string Message { get; set; }

        /// <inheritdoc/>
        public PartA_PrivTags PartA_PrivTags => PartA_PrivTags.ProductAndServicePerformance;
    }
}
