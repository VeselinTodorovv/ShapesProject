using System.ComponentModel;
using Infrastructure.Converters;
using ShapesProject.Domain.Primitives;
using ShapesProject.Forms;
using ShapesProject.Utils;

namespace ShapesProject;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        TypeDescriptor.AddAttributes(typeof(CustomPoint), new TypeConverterAttribute(typeof(CustomPointConverter)));
        ProviderRegistration.RegisterProvider();
        
        Application.Run(new MainForm());
    }
}