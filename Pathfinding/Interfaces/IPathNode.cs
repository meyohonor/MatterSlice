﻿// Copyright(c) 2012 Erik Svedäng, Johannes Gotlén, 2017 Lars Brubaker
// 
// This software is provided 'as-is', without any express or implied
// warranty.In no event will the authors be held liable for any damages
// arising from the use of this software.
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it
// freely, subject to the following restrictions:
// 1. The origin of this software must not be misrepresented; you must not
//    claim that you wrote the original software.If you use this software
//    in a product, an acknowledgment in the product documentation would be
//    appreciated but is not required.
// 2. Altered source versions must be plainly marked as such, and must not be
//    misrepresented as being the original software.
// 3. This notice may not be removed or altered from any source distribution.

using System;
using System.Collections.Generic;

namespace Pathfinding
{
    public interface IPathNode : IPoint, IComparable
    {
        float CostMultiplier {
            get;
        }

        float PathCostHere {
            get;
            set;
        }

        float DistanceToGoal {
            get;
            set;
        }

        bool IsStartNode {
            get;
            set;
        }

        bool IsGoalNode {
            set;
            get;
        }

        bool Visited {
            get;
            set;
        }

        void AddLink(PathLink pLink);

        void RemoveLink(PathLink pLink);

        List<PathLink> Links {
            get;
        }

        PathLink GetLinkTo(IPathNode pNode);

        PathLink LinkLeadingHere {
            get;
            set;
        }

        long GetUniqueID();
    }
}
