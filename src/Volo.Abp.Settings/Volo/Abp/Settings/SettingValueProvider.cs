﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.Settings
{
    public abstract class SettingValueProvider : ISettingValueProvider, ISingletonDependency
    {
        public abstract string EntityType { get; }

        protected ISettingStore SettingStore { get; }

        protected SettingValueProvider(ISettingStore settingStore)
        {
            SettingStore = settingStore;
        }

        public abstract Task<string> GetOrNullAsync(SettingDefinition setting, string entityId);

        public abstract Task SetAsync(SettingDefinition setting, string value, string entityId);

        public abstract Task ClearAsync(SettingDefinition setting, string entityId);
    }
}