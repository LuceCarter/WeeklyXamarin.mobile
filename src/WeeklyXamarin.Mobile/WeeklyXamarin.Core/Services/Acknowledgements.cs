﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeeklyXamarin.Core.Services
{
    public enum Activity
    {
        Follow,
        Subscribe,
        Raid,
        PullRequest,
        Bitties,
        DerailedEverything,
        GiftSub,
        WriteTheThemeTune
    }

    public class Acknowledgement
    {
        public string Person { get; set; }
        public Activity Activity { get; set; }
    }

    public class Acknowledgements
    {
        public IList<Acknowledgement> Thanks = new List<Acknowledgement>();

        public Acknowledgements()
        {
            Thanks = new List<Acknowledgement>()
            {
                // new Acknowledgement() {Person="", Activity=Activity.Follow},

                // 16 September 2020
                new Acknowledgement() {Person="smokinGears", Activity=Activity.Follow},
                new Acknowledgement() {Person="funcdev", Activity=Activity.Follow},
                new Acknowledgement() {Person="Uraitz_Olaizola", Activity=Activity.Follow},
                new Acknowledgement() {Person="jorginhobanana", Activity=Activity.Follow},
                new Acknowledgement() {Person="bigglid", Activity=Activity.Follow},
                new Acknowledgement() {Person="TimBeaudet", Activity=Activity.Raid},
                new Acknowledgement() {Person="TimBeaudet", Activity=Activity.Raid},
                new Acknowledgement() {Person="DavidWengier", Activity=Activity.Raid},
                new Acknowledgement() {Person="KevinQAnderson", Activity=Activity.Bitties},
                new Acknowledgement() {Person="r2_au", Activity=Activity.Bitties},
                new Acknowledgement() {Person="blackclaw404", Activity=Activity.Follow},
                new Acknowledgement() {Person="yuvarajcena26", Activity=Activity.Follow},
                new Acknowledgement() {Person="johandeveloper", Activity=Activity.Follow},
                new Acknowledgement() {Person="mandragoraX", Activity=Activity.Follow},
                new Acknowledgement() {Person="m_2_", Activity=Activity.Follow},

                // 9 September 2020
                new Acknowledgement() {Person="ThisIsDavid", Activity=Activity.Follow},
                new Acknowledgement() {Person="KlausDevWalker", Activity=Activity.Follow},
                new Acknowledgement() {Person="TheXtremePerson", Activity=Activity.Follow},
                new Acknowledgement() {Person="KickInThePocket", Activity=Activity.Follow},
                new Acknowledgement() {Person="FBoucheros", Activity=Activity.Raid},
                new Acknowledgement() {Person="xami3shah", Activity=Activity.Follow},
                new Acknowledgement() {Person="functionjarvis20", Activity=Activity.Follow},
                new Acknowledgement() {Person="Willairways", Activity=Activity.Follow},
                new Acknowledgement() {Person="BjornOveBremmnes", Activity=Activity.Follow},
                new Acknowledgement() {Person="Scratch2k", Activity=Activity.Follow},
                new Acknowledgement() {Person="lubdubw", Activity=Activity.Follow},
                new Acknowledgement() {Person="r2_au", Activity=Activity.Bitties},

                new Acknowledgement() {Person="RMauroDev", Activity=Activity.Follow},
                new Acknowledgement() {Person="SurlyDev", Activity=Activity.Follow},
                new Acknowledgement() {Person="TheGrumpyGameDev", Activity=Activity.Raid},
                new Acknowledgement() {Person="LachlanWGordon", Activity=Activity.Bitties},
                new Acknowledgement() {Person="InquisitorJax", Activity=Activity.Follow},
                new Acknowledgement() {Person="AdenEarnshaw", Activity=Activity.Subscribe},


                // 2 September 2020
                new Acknowledgement() {Person="TendedDinosaur2", Activity=Activity.Follow },
                new Acknowledgement() {Person="AndikaRizary", Activity=Activity.Follow },
                new Acknowledgement() {Person="jazteng2", Activity=Activity.Follow },
                new Acknowledgement() {Person="GlennStephens", Activity=Activity.WriteTheThemeTune },
                new Acknowledgement() {Person="Iceist", Activity=Activity.Follow },
                new Acknowledgement() {Person="ScottDev", Activity=Activity.DerailedEverything },
                new Acknowledgement() {Person="ScottDev", Activity=Activity.GiftSub },
                new Acknowledgement() {Person="ScottDev", Activity=Activity.Subscribe },
                new Acknowledgement() {Person="varrathien", Activity=Activity.Subscribe },
                new Acknowledgement() {Person="jhsebas", Activity=Activity.Follow },
                new Acknowledgement() {Person="varrathien", Activity=Activity.Follow },
                new Acknowledgement() {Person="DavidWengier", Activity=Activity.Raid},
                new Acknowledgement() {Person="BitwyzeGaming", Activity=Activity.Follow},
                new Acknowledgement() {Person="eldoen", Activity=Activity.Follow},


                // 26 August 2020
                new Acknowledgement() {Person="kenthtet", Activity=Activity.Follow},
                new Acknowledgement() {Person="zetawop", Activity=Activity.Follow},
                new Acknowledgement() {Person="DavidWengier", Activity=Activity.Raid},
                new Acknowledgement() {Person="scarlettcode", Activity=Activity.Follow},

                // 12 August 2020
                new Acknowledgement() {Person="agentesimoes", Activity=Activity.Follow},
                new Acknowledgement() {Person="xxxless", Activity=Activity.Follow },
                new Acknowledgement() {Person="Tondi", Activity=Activity.Follow },
                new Acknowledgement() {Person="nativelinux", Activity=Activity.Follow },
                new Acknowledgement() {Person="tbdgamer", Activity=Activity.DerailedEverything },
                new Acknowledgement() {Person="BenBtg", Activity=Activity.Follow},
                new Acknowledgement() {Person="Simontaga", Activity=Activity.Follow},
                new Acknowledgement() {Person="Simontaga", Activity=Activity.Follow},
                new Acknowledgement() {Person="le_BigSid", Activity=Activity.Follow},
                new Acknowledgement() {Person="EdNascimento31", Activity=Activity.Follow},
                new Acknowledgement() {Person="bricemarcelkouadio", Activity=Activity.Follow},
                new Acknowledgement() {Person="Asterisix", Activity=Activity.Subscribe},
                new Acknowledgement() {Person="zaploator", Activity=Activity.Follow},
                new Acknowledgement() {Person="marcosapoggi", Activity=Activity.Follow},
                new Acknowledgement() {Person="skullteria", Activity=Activity.Follow},
                new Acknowledgement() {Person="elianax_2000", Activity=Activity.Follow},
                new Acknowledgement() {Person="r2_au", Activity=Activity.Bitties},
                new Acknowledgement() {Person="jfversluis", Activity=Activity.Bitties},
                new Acknowledgement() {Person="jfversluis", Activity=Activity.Subscribe},
                new Acknowledgement() {Person="mdebruin93", Activity=Activity.Follow},
                new Acknowledgement() {Person="@vortexcdn", Activity=Activity.Follow},
                new Acknowledgement() {Person="@programmetajs", Activity=Activity.Follow},
                new Acknowledgement() {Person="@KevinQAnderson", Activity=Activity.Subscribe},


                // 5 August 2020
                new Acknowledgement() {Person="riallymundane", Activity=Activity.Raid},
                new Acknowledgement() {Person="Superbeer1994", Activity=Activity.Follow},
                new Acknowledgement() {Person="informationrocket", Activity=Activity.Follow},
                new Acknowledgement() {Person="STuaRTRuLes", Activity=Activity.Follow},
                new Acknowledgement() {Person="StevenThewissen", Activity=Activity.Follow},
                new Acknowledgement() {Person="fr33k3r", Activity=Activity.Follow},
                new Acknowledgement() {Person="DavidWengier", Activity=Activity.Raid},
                new Acknowledgement() {Person="deva73", Activity=Activity.Follow},
                new Acknowledgement() {Person="pickpie", Activity=Activity.Follow},
                new Acknowledgement() {Person="vishop_vishwa", Activity=Activity.Follow},
                new Acknowledgement() {Person="codingwithLuce", Activity=Activity.PullRequest},
            };
        }
    }
}
