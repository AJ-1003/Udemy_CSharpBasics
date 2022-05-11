﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Exercises
{
    public class TextExercises
    {
        public void ExecuteExercise(string exerciseName)
        {
            if (GetType().GetMethod(exerciseName) != null)
            {
                MethodInfo method = GetType().GetMethod(exerciseName);
                method.Invoke(this, null);
            }
        }

        public void Exercise1()
        {

        }

        public void Exercise2()
        {

        }

        public void Exercise3()
        {

        }

        public void Exercise4()
        {

        }

        public void Exercise5()
        {

        }
    }
}