﻿using System.IO;

namespace Drive
{
    public class DriveInfoChecker
    {
        public static long GetFreeSpace(string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return drive.TotalFreeSpace;
        }

        public static long GetFreeSpace(string driveLetter, string unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(drive.TotalFreeSpace, unitOut);
            return freeSpace;
        }

        public static byte GetFreeSpacePercentage (string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            long freeSpace = GetFreeSpace(driveLetter);
            long totalSpace = GetTotalSpace(driveLetter);

            double totalPercentage = (freeSpace / totalSpace) * 100;
            totalPercentage = Math.Round(totalPercentage, 0, MidpointRounding.AwayFromZero);

            return (byte)totalPercentage;
        }

        public static long GetAvailableSpace(string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return drive.AvailableFreeSpace;
        }

        public static long GetAvailableSpace(string driveLetter, string unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long availableSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, unitOut);
            return availableSpace;
        }

        public static long GetTotalSpace(string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return drive.TotalSize;
        }

        public static long GetTotalSpace(string driveLetter, string unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long totalSize = BytesToBinaryUnits.Convert(drive.TotalSize, unitOut));
            return totalSize;
        }

        }
    }
}
