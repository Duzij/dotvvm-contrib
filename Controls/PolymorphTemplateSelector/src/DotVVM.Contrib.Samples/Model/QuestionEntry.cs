﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace DotVVM.Contrib.Samples.Model
{
    public class QuestionEntry
    {

        public int Id { get; set; }

        public YesNoQuestion YesNo { get; set; }

        public NumberQuestion Number { get; set; }

        public ChoiceQuestion Choice { get; set; }

        public OpenTextQuestion OpenText { get; set; }

    }
}
