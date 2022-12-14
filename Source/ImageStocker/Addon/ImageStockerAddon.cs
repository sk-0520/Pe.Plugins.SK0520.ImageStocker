using ContentTypeTextNet.Pe.Bridge.Plugin;
using ContentTypeTextNet.Pe.Bridge.Plugin.Addon;
using ContentTypeTextNet.Pe.Embedded.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentTypeTextNet.Pe.Plugins.Original.ImageStocker.Addon
{
    internal class ImageStockerAddon : AddonBase
    {
        public ImageStockerAddon(IPluginConstructorContext pluginConstructorContext, PluginBase plugin)
            : base(pluginConstructorContext, plugin)
        { }

        #region AddonBase

        protected override IReadOnlyCollection<AddonKind> SupportedKinds => new[] { AddonKind.LauncherItem, };

        protected internal override void Load(IPluginLoadContext pluginLoadContext)
        {
            //throw new NotImplementedException();
        }

        protected internal override void Unload(IPluginUnloadContext pluginUnloadContext)
        {
            //throw new NotImplementedException();
        }

        public override ILauncherItemExtension CreateLauncherItemExtension(ILauncherItemExtensionCreateParameter parameter)
        {
            return new ImageStockerLauncherItemExtension(parameter, PluginInformations);
        }

        #endregion
    }
}
