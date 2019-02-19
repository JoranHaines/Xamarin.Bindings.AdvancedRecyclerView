﻿using System;
namespace MvvmCross.AdvancedRecyclerView.Data
{
    public class MvxAdvancedRecyclerViewAttributes
    {
        public MvxAdvancedRecyclerViewAttributes()
        {
        }

		public string TemplateSelectorClassName { get; set; }

		public int FooterLayoutId { get; set; }
        public int HeaderLayoutId { get; set; }
 
        public string GroupedDataConverterClassName { get; set; }

        public string GroupExpandControllerClassName { get; set; }
        
        public string GroupSwipeableTemplateClassName { get; set; }
        
        public string ChildSwipeableTemplateClassName { get; set; }

        public string SwipeableTemplateClassName { get; set; }

        public string UniqueItemIdProviderClassName { get; set; }
        
        public int ItemTemplateLayoutId { get; set; }
    }
}
