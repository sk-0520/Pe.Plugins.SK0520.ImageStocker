using System;
using System.Collections.Generic;
using System.Text;
using ContentTypeTextNet.Pe.Bridge.Plugin;
using ContentTypeTextNet.Pe.Bridge.Plugin.Addon;
using ContentTypeTextNet.Pe.Bridge.Plugin.Preferences;
using ContentTypeTextNet.Pe.Embedded.Abstract;
using ContentTypeTextNet.Pe.Plugins.Original.ImageStocker.Addon;

namespace ContentTypeTextNet.Pe.Plugins.Original.ImageStocker
{
    public class ImageStocker: PluginBase, IAddon//, ITheme, IPreferences
    {
        #region variable

        private ImageStockerAddon _addon;

        #endregion

        public ImageStocker(IPluginConstructorContext pluginConstructorContext)
            : base(pluginConstructorContext)
        {
            //
            this._addon = new ImageStockerAddon(pluginConstructorContext, this);
        }

        #region PluginBase

        internal override AddonBase Addon => this._addon;

        protected override void InitializeImpl(IPluginInitializeContext pluginInitializeContext)
        { }

        protected override void UninitializeImpl(IPluginUninitializeContext pluginUninitializeContext)
        { }


        #endregion

    }
}
