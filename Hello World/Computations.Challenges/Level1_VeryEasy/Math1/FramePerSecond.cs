using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy.Math
{
    /*
     * ===  Frames Per Second ===
     
                Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.

                Examples
                Frames(1, 1) ➞ 60
                Frames(10, 1) ➞ 600
                Frames(10, 25) ➞ 15000

                Notes
                FPS stands for "frames per second" and it's the number of frames a computer screen shows every second.
     */
    public interface IFramePerSecond
    {
        int Frames(int minutes, int fps);
    }
    public class FramePerSecond : IFramePerSecond
    {
        public int Frames(int minutes, int fps)
        {
            var frames = minutes * (fps * 60);
            return frames;
        }
    }
}
