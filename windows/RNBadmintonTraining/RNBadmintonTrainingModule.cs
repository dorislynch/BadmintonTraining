using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Badminton.Training.RNBadmintonTraining
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBadmintonTrainingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBadmintonTrainingModule"/>.
        /// </summary>
        internal RNBadmintonTrainingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBadmintonTraining";
            }
        }
    }
}
