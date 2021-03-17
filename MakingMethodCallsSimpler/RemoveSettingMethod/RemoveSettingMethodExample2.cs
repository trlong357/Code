using System;

namespace MakingMethodCallsSimpler.RemoveSettingMethod
{
    public class RemoveSettingMethodExample2
    {
        private String id;

        RemoveSettingMethodExample2(String id)
        {
            SetId(id);
        }

        void SetId(String arg)
        {
            id = "ZZ" + arg;
        }
    }
}
