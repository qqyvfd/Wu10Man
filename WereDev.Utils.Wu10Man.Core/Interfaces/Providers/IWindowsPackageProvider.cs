﻿using WereDev.Utils.Wu10Man.Core.Models;

namespace WereDev.Utils.Wu10Man.Core.Interfaces.Providers
{
    public interface IWindowsPackageProvider
    {
        PackageInfo[] ListInstalledPackages();

        void RemovePackage(string packageName);
    }
}
