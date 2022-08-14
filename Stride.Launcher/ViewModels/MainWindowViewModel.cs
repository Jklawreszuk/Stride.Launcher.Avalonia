using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reactive;
using ReactiveUI;
using Stride.Launcher.Assets.Localization;

namespace Stride.Launcher.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        public ReactiveCommand<string, Unit> OpenUrlCommand { get; }
        public ReactiveCommand<Unit, Unit>  StartStudioCommand { get; }
        public string CurrentToolTip { get; } = Strings.ToolTipDefault;
        public VsixVersionViewModel VsixPackage2019 { get; }
        public VsixVersionViewModel VsixPackage2022 { get; }
        public List<DocumentationPageViewModel> ActiveDocumentationPages;


        private StrideVersionViewModel activeVersion;
        private readonly ObservableCollection<StrideVersionViewModel> strideVersions = new();
        

        public MainWindowViewModel()
        {
            OpenUrlCommand = ReactiveCommand.Create<string>(OpenUrl);
            StartStudioCommand = ReactiveCommand.Create(StartStudio);
        }
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            // FIXME: catch only specific exceptions?
            catch (Exception)
            {
                
            }
        }
        public void StartStudio()
        {
           

        }
    }
}
