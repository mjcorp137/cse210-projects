using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Morningstar: The Hunt - Part One", "Project Morningstar", 590);

        Comment video1Comment1 = new Comment("TheMadmanAndre", "Exodite crawled so Morningstar could run.");
        Comment video1Comment2 = new Comment("ViewTube_Emperor_of_Mankind", "I can feel the Games Workshop lawyers howling in pain.");
        Comment video1Comment3 = new Comment("Dasistrite", "You can't kill an idea. Decentralization is the way forward. Onwards with glory!");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("I Spent 100 Days In Skyrim Legendary Difficulty Becoming A Master Conjuration Mage (Skyrim Movie)", "Tizzy", 6480);

        Comment video2Comment1 = new Comment("custurddanish9375", "You should definitely make this a series using the other schools of magic");
        Comment video2Comment2 = new Comment("Grim-xk2ko", "This was a fun video. Just a thought, maybe you can use the ordinator mod to add even more perks to the challenge. Either way it be fun to see this with other schools or magic or perk trees.");
        Comment video2Comment3 = new Comment("txma.", "Just hopped back into Skyrim after several years and immediately went for a conjuration build. Its so funny having all the enemies aggro onto something other than yourself while you get to either whack them for free or go around looting");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("POV: Busy Dinner Service at Top London Restaurant", "Fallow", 1620);

        Comment video3Comment1 = new Comment("corbinpearce7686", "What always amazes me about your POV videos, both for the kitchen and bar, is how unrushed it all feels. You guys are crazy busy, and you're completing orders to match, but at no point does it feel like you're in a serious hurry to do anything.  It demonstrates really impressive technical and logistical skill to make that level of productivity appear so casual.");
        Comment video3Comment2 = new Comment("RescueNW", "I love how you present our traditional dishes. I definitely need to try them all.Jack just could not resist eating those beans. He just kept going at it over a good 2 minutes haha");
        Comment video3Comment3 = new Comment("KeKejax", "Can I just say. The way you help and guided the chef with the bean dish was refreshing to see. With any job making mistakes can be scary because you may not know the leadership style, and it can truly ruin you with anxiety of failing!!. Thank you for teaching and showing him in a way that wasn't babying but in a way as if to say I know you can do it, you got this. :) ");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}