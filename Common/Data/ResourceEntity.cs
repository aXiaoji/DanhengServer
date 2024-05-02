﻿using System;

namespace EggLink.DanhengServer.Data
{

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    internal class ResourceEntity : Attribute
    {
        public List<string> FileName { get; private set; }

        [Obsolete("No effect")]
        public bool IsCritical { get; private set; }  // deprecated

        [Obsolete("No effect")]
        public ResourceEntity(string fileName, bool isCritical = false, bool isMultifile = false)
        {
            if (isMultifile)
            {
                FileName = new List<string>(fileName.Split(','));
            }
            else
                FileName = [fileName];
            IsCritical = isCritical;
        }

        
        public ResourceEntity(string fileName, bool isMultifile = false)
        {
            if (isMultifile)
            {
                FileName = new List<string>(fileName.Split(','));
            }
            else
                FileName = [fileName];
        }

        public ResourceEntity(string fileName)
        {
             FileName = [fileName];
        }
    }
}
