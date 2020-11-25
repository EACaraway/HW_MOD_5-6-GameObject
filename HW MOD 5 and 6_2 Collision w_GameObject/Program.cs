using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;


namespace HW_MOD_5_and_6_2_Collision_w_GameObject
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    //GameObject needs to have properties for X and Y velocities and the following method:
    //public virtual void Collision(GameObject HitObj) {…}
    //velocities change after collisions
    //The Ghost class should be a GameObject that only changes velocity if it collides with another Ghost.


    // class called GameObject
    public class GameObject
    {
        public int X_Velocity { get; set; }
        public int Y_Velocity { get; set; }      
        public double X { get; set; }
        public double Y { get; set; }
        

        public virtual void Collision(GameObject hitObj)
        {   //change velocity if a collision occurs.
            if (X == hitObj.X && Y == hitObj.Y)
            {
                X_Velocity = 0;
                Y_Velocity = 0;
                hitObj.X_Velocity = 0;
                hitObj.Y_Velocity = 0;
            }
           
        }

    }

    // class called Ghost
    public class Ghost: GameObject 
    {
        public override void Collision(GameObject hitObj)
        {
            //change velocity if a collision occurs with another ghost.
            if (hitObj is Ghost && X == hitObj.X && Y == hitObj.Y)
            {
                X_Velocity = 0;
                Y_Velocity = 0;
                hitObj.X_Velocity = 0;
                hitObj.Y_Velocity = 0;
            }
        }

       
    }

}