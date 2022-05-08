using ContentTypeTextNet.Pe.Bridge.Models.Data;
using ContentTypeTextNet.Pe.Bridge.Plugin;
using ContentTypeTextNet.Pe.Bridge.Plugin.Addon;
using ContentTypeTextNet.Pe.Bridge.Plugin.Preferences;
using ContentTypeTextNet.Pe.Embedded.Abstract;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ContentTypeTextNet.Pe.Plugins.Original.ImageStocker.Addon
{
    internal class ImageStockerLauncherItemExtension : LauncherItemExtensionBase
    {
        public ImageStockerLauncherItemExtension(ILauncherItemExtensionCreateParameter parameter, IPluginInformations pluginInformations)
            : base(parameter, pluginInformations)
        { }

        #region LauncherItemExtensionBase

        public override bool CustomDisplayText => false;

        public override string DisplayText => PluginInformations.PluginIdentifiers.PluginName;

        public override bool CustomLauncherIcon => false;

        public override bool SupportedPreferences => false;

        public override void ChangeDisplay(LauncherItemIconMode iconMode, bool isVisible, object callerObject)
        { }

        public override ILauncherItemPreferences CreatePreferences(ILauncherItemAddonContext launcherItemAddonContext)
        {
            throw new NotSupportedException();
        }

        public override void Execute(string? argument, ICommandExecuteParameter commandExecuteParameter, ILauncherItemExtensionExecuteParameter launcherItemExtensionExecuteParameter, ILauncherItemAddonContext launcherItemAddonContext)
        {
            throw new NotImplementedException();
        }

        public override object GetIcon(LauncherItemIconMode iconMode, in IconScale iconScale)
        {
            var asm = Assembly.GetExecutingAssembly();
            var asmName = asm.GetName().Name;
            var uri = new Uri("pack://application:,,,/" + asmName + ";component/Plugin.ico");
            try
            {
                var decoder = BitmapDecoder.Create(uri, BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
                var bitmap = ImageLoader.GetImageFromFrames(decoder.Frames, iconScale);
                //var bitmap = new BitmapImage(uri);
                var image = new System.Windows.Controls.Image()
                {
                    Source = bitmap,
                };
                return image;
            }
            catch (IOException ex)
            {
                Logger.LogError(ex, ex.Message);
            }
            return null!;
        }

        #endregion
    }
}
