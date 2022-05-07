using ContentTypeTextNet.Pe.Bridge.Models.Data;
using ContentTypeTextNet.Pe.Bridge.Plugin;
using ContentTypeTextNet.Pe.Bridge.Plugin.Addon;
using ContentTypeTextNet.Pe.Bridge.Plugin.Preferences;
using ContentTypeTextNet.Pe.Embedded.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTypeTextNet.Pe.Plugins.Original.ImageStocker.Models
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
        {
            throw new NotImplementedException();
        }

        public override ILauncherItemPreferences CreatePreferences(ILauncherItemAddonContext launcherItemAddonContext)
        {
            throw new NotImplementedException();
        }

        public override void Execute(string? argument, ICommandExecuteParameter commandExecuteParameter, ILauncherItemExtensionExecuteParameter launcherItemExtensionExecuteParameter, ILauncherItemAddonContext launcherItemAddonContext)
        {
            throw new NotImplementedException();
        }

        public override object GetIcon(LauncherItemIconMode iconMode, in IconScale iconScale)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
