using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureSolitaire.Core.Enumerations
{
    public enum CategorySorting
    {
        [Display(Name = "Родното и чуждото")]
        TheNativeAndTheForeign = 0,

        [Display(Name = "Миналото и паметта")]
        ThePastAndMemory = 1,

        [Display(Name = "Обществото и властта")]
        SocietyAndPower = 2,

        [Display(Name = "Животът и смъртта")]
        LifeAndDeath = 3,

        [Display(Name = "Природата")]
        Nature = 4,

        [Display(Name = "Любовта")]
        Love = 5,

        [Display(Name = "Вярата и надеждата")]
        FaithAndHope = 6,

        [Display(Name = "Трудът и творчеството")]
        LaborAndCreativity = 7,

        [Display(Name = "Изборът и раздвоението")]
        ChoiceAndInnerConflict = 8
    }
}
