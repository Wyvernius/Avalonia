﻿using System;
using Avalonia.Controls.ApplicationLifetimes;

namespace Avalonia.Android;

public interface IAvaloniaActivity : IActivityResultHandler, IActivityNavigationService, IActivityConfigurationService
{
    event EventHandler<ActivatedEventArgs> Activated;
    event EventHandler<ActivatedEventArgs> Deactivated;
}
