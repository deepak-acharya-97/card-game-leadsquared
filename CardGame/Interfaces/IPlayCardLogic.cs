﻿using CardGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Interfaces
{
    public interface IPlayCardLogic
    {
        CardBase PlayCard(List<CardBase> cards);
    }
}
