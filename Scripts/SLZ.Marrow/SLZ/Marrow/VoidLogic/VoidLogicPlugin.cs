﻿using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[MarrowPlugin("SLZ.Marrow.VoidLogic", "VoidLogicPlugin", "0.0.1")]
	public class VoidLogicPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		public static VoidLogicManager CurrentManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		UniTask IMarrowPluginLevelCallbacks.OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		public UniTask OnAfterLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		public VoidLogicPlugin()
		{
		}

		[PublicAPI]
		public const string PluginNamespace = "SLZ.Marrow.VoidLogic";

		[PublicAPI]
		public const string PluginName = "VoidLogicPlugin";

		[PublicAPI]
		public const string PluginVersion = "0.0.1";

		private GameObject _holder;
	}
}
