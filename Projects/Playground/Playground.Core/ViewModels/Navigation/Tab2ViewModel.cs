﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Playground.Core.ViewModels
{
    public class Tab2ViewModel : MvxViewModel
    {
        public Tab2ViewModel()
        {
            ShowRootViewModelCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<RootViewModel>());

            CloseViewModelCommand = new MvxAsyncCommand(async () => await NavigationService.Close(this));
        }

        public IMvxAsyncCommand ShowRootViewModelCommand { get; private set; }

        public IMvxAsyncCommand CloseViewModelCommand { get; private set; }
    }
}
