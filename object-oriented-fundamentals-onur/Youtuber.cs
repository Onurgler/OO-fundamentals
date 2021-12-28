using System;

namespace object_oriented_fundamentals_onur
{
    public class Youtuber : Creator
    {
        public override void Create()
        {
            if(base.CreativityLevel >=50 && base.Energy >= 50)
            {
                this.BrainstormVideoIdeas();
                this.CreateScript();
                this.VideotapeScript();
                this.EditVideo();
                this.RenderVideo();
            }
            else
            {
                throw new Exception("Cannot create a video. Out of ideas and/or tiered.");
            }
        }
        
        private void BrainstormVideoIdeas()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Brainstorming video ideas...");
        }
        
        private void CreateScript()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Creating a video script...");
        }
        
        private void VideotapeScript()
        {
            base.CreativityLevel = base.CreativityLevel - 1;
            base.Energy = base.Energy - 10;
            Console.WriteLine("Videotaping myself executing the script...");
        }
        
        private void EditVideo()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Editing the video...");
        }
        
        private void RenderVideo()
        {
            base.CreativityLevel = base.CreativityLevel - 1;
            base.Energy = base.Energy - 1;
            Console.WriteLine("Rendering the video...");
        }
    }
}