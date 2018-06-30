using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Converters;
using Xamarin.Forms;

namespace MvvmCross.Forms.Converters
{
    public class MvxFormsValueConverter : MvxValueConverter, IValueConverter
    {
    }

    public class MvxFormsValueConverter<TFrom> : MvxValueConverter<TFrom>, IValueConverter
    {
    }

    public class MvxFormsValueConverter<TFrom,TTo> : MvxValueConverter<TFrom,TTo>, IValueConverter
    {
    }
}
