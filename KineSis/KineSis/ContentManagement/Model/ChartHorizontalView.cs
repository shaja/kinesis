﻿/*
   Copyright 2012 Alexandru Albu - sandu.albu@gmail.com

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace KineSis.ContentManagement.Model
{

    /// <summary>
    /// Represents a chart horizontal view with more vertical views
    /// </summary>
    [Serializable]
    public class ChartHorizontalView
    {
        private String imageUrl;

        private List<ChartVerticalView> up = new List<ChartVerticalView>();
        private List<ChartVerticalView> down = new List<ChartVerticalView>();

        /// <summary>
        /// Image url
        /// </summary>
        public String ImageUrl
        {
            get
            {
                return imageUrl;
            }

            set
            {
                imageUrl = value;
            }
        }

        /// <summary>
        /// Logically up views list
        /// </summary>
        public List<ChartVerticalView> Up
        {
            get
            {
                return up;
            }

            set
            {
                up = value;
            }
        }

        /// <summary>
        /// Logically down views list
        /// </summary>
        public List<ChartVerticalView> Down
        {
            get
            {
                return down;
            }

            set
            {
                down = value;
            }
        }
    }
}
