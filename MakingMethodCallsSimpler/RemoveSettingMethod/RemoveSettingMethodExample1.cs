using System;

namespace MakingMethodCallsSimpler.RemoveSettingMethod
{
    public class RemoveSettingMethodExample1
    {
        private String id;

        RemoveSettingMethodExample1(String id)
        {
            SetId(id);
        }

        void SetId(String arg)
        {
            id = arg;
        }
    }
}
