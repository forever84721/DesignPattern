﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            //throw new NotImplementedException();
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine($"Playing vlc file. Name:{fileName}");
            //throw new NotImplementedException();
        }
    }
}
