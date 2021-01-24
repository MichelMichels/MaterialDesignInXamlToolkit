using System.Windows;

namespace MaterialDesignThemes.Wpf
{
    public static class ButtonAssist
    {
        private static readonly CornerRadius DefaultCornerRadius = new CornerRadius(2.0);
        private static readonly bool DefaultHasLeadingIcon = false;
        private static readonly PackIconKind DefaultLeadingIcon = PackIconKind.Null;
        

        #region AttachedProperty : CornerRadiusProperty
        /// <summary>
        /// Controls the corner radius of the surrounding box.
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty
            = DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ButtonAssist), new PropertyMetadata(DefaultCornerRadius));

        public static CornerRadius GetCornerRadius(DependencyObject element) => (CornerRadius)element.GetValue(CornerRadiusProperty);
        public static void SetCornerRadius(DependencyObject element, CornerRadius value) => element.SetValue(CornerRadiusProperty, value);
        #endregion

        #region AttachedProperty : HasLeadingIconProperty
        public static readonly DependencyProperty HasLeadingIconProperty
            = DependencyProperty.RegisterAttached("HasLeadingIcon", typeof(bool), typeof(ButtonAssist), new PropertyMetadata(DefaultHasLeadingIcon));

        public static bool GetHasLeadingIcon(DependencyObject element) => (bool)element.GetValue(HasLeadingIconProperty);
        public static void SetHasLeadingIcon(DependencyObject element, bool value) => element.SetValue(HasLeadingIconProperty, value);
        #endregion

        #region AttachedProperty : LeadingIconProperty
        public static readonly DependencyProperty LeadingIconProperty
            = DependencyProperty.RegisterAttached("LeadingIcon", typeof(PackIconKind), typeof(ButtonAssist), new PropertyMetadata(DefaultLeadingIcon));

        public static PackIconKind GetLeadingIcon(DependencyObject element) => (PackIconKind)element.GetValue(LeadingIconProperty);
        public static void SetLeadingIcon(DependencyObject element, PackIconKind value) => element.SetValue(LeadingIconProperty, value);
        #endregion
    }
}