﻿using System.IO;

namespace Drive
{
    public class DriveInfoChecker
    {

        public long GetFreeSpace(string Driveletter)
        {
            var drive = new DriveInfo(Driveletter);
            long freeSpace;

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            freeSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, new string("MB"));
            return freeSpace;
        }


    }
}
