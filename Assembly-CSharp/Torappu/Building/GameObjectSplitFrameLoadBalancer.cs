using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x02001843 RID: 6211
	[Token(Token = "0x2001843")]
	public class GameObjectSplitFrameLoadBalancer
	{
		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06009D09 RID: 40201 RVA: 0x0003D668 File Offset: 0x0003B868
		// (set) Token: 0x06009D0A RID: 40202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700113C")]
		public bool isPaused
		{
			[Token(Token = "0x6009D09")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6009D0A")]
			[Address(RVA = "0x3186A80", Offset = "0x3185680", VA = "0x183186A80")]
			set
			{
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06009D0B RID: 40203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700113D")]
		public AbstractAssetLoader internalAssetLoader
		{
			[Token(Token = "0x6009D0B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009D0C RID: 40204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D0C")]
		[Address(RVA = "0x31868B0", Offset = "0x31854B0", VA = "0x1831868B0")]
		public GameObjectSplitFrameLoadBalancer(AbstractAssetLoader assetLoader)
		{
		}

		// Token: 0x06009D0D RID: 40205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D0D")]
		[Address(RVA = "0x3186720", Offset = "0x3185320", VA = "0x183186720")]
		public GameObjectSplitFrameLoadBalancer(AbstractAssetLoader assetLoader, GameObjectSplitFrameLoadBalancer.Options options)
		{
		}

		// Token: 0x06009D0E RID: 40206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D0E")]
		[Address(RVA = "0x3185E00", Offset = "0x3184A00", VA = "0x183185E00")]
		public void LoadAsync(string path, IDynamicAssetWrapper assetWrapper, Action<bool, GameObject> callback)
		{
		}

		// Token: 0x06009D0F RID: 40207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D0F")]
		[Address(RVA = "0x3185BE0", Offset = "0x31847E0", VA = "0x183185BE0")]
		public IDynamicAssetHandler LoadAsset(string path, IDynamicAssetWrapper assetWrapper)
		{
			return null;
		}

		// Token: 0x06009D10 RID: 40208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D10")]
		[Address(RVA = "0x3185F00", Offset = "0x3184B00", VA = "0x183185F00")]
		public void UpdateFrame()
		{
		}

		// Token: 0x06009D11 RID: 40209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D11")]
		[Address(RVA = "0x31864D0", Offset = "0x31850D0", VA = "0x1831864D0")]
		private void _UpdateTasks(Heap<GameObjectSplitFrameLoadBalancer.AsyncTask> target)
		{
		}

		// Token: 0x06009D12 RID: 40210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D12")]
		[Address(RVA = "0x3185B80", Offset = "0x3184780", VA = "0x183185B80")]
		public void ClearTasks()
		{
		}

		// Token: 0x06009D13 RID: 40211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D13")]
		[Address(RVA = "0x3185AF0", Offset = "0x31846F0", VA = "0x183185AF0")]
		public void ClearAll()
		{
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x0003D680 File Offset: 0x0003B880
		[Token(Token = "0x6009D14")]
		[Address(RVA = "0x3186400", Offset = "0x3185000", VA = "0x183186400")]
		private bool _TryProcessOneReleaseTask()
		{
			return default(bool);
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x0003D698 File Offset: 0x0003B898
		[Token(Token = "0x6009D15")]
		[Address(RVA = "0x3186200", Offset = "0x3184E00", VA = "0x183186200")]
		private GameObjectSplitFrameLoadBalancer.TaskStatus _TryProcessOneLoadTask()
		{
			return GameObjectSplitFrameLoadBalancer.TaskStatus.FAILED;
		}

		// Token: 0x06009D16 RID: 40214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D16")]
		[Address(RVA = "0x31860F0", Offset = "0x3184CF0", VA = "0x1831860F0")]
		private void _PickAndProcessTask(GameObjectSplitFrameLoadBalancer.AsyncTask task)
		{
		}

		// Token: 0x040093D2 RID: 37842
		[Token(Token = "0x40093D2")]
		[FieldOffset(Offset = "0x10")]
		private AbstractAssetLoader m_assetLoader;

		// Token: 0x040093D3 RID: 37843
		[Token(Token = "0x40093D3")]
		[FieldOffset(Offset = "0x18")]
		private GameObjectSplitFrameLoadBalancer.Options m_loadOptions;

		// Token: 0x040093D4 RID: 37844
		[Token(Token = "0x40093D4")]
		[FieldOffset(Offset = "0x28")]
		private List<GameObjectSplitFrameLoadBalancer.AsyncTask> m_cachedTasks;

		// Token: 0x040093D5 RID: 37845
		[Token(Token = "0x40093D5")]
		[FieldOffset(Offset = "0x30")]
		private Heap<GameObjectSplitFrameLoadBalancer.AsyncTask> m_pendingTasks;

		// Token: 0x040093D6 RID: 37846
		[Token(Token = "0x40093D6")]
		[FieldOffset(Offset = "0x38")]
		private Heap<GameObjectSplitFrameLoadBalancer.AsyncTask> m_completeTasks;

		// Token: 0x040093D7 RID: 37847
		[Token(Token = "0x40093D7")]
		[FieldOffset(Offset = "0x40")]
		private PeriodicTicker m_idleTicker;

		// Token: 0x040093D8 RID: 37848
		[Token(Token = "0x40093D8")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isPaused;

		// Token: 0x02001844 RID: 6212
		[Token(Token = "0x2001844")]
		private enum TaskStatus
		{
			// Token: 0x040093DA RID: 37850
			[Token(Token = "0x40093DA")]
			FAILED,
			// Token: 0x040093DB RID: 37851
			[Token(Token = "0x40093DB")]
			SUCCESS,
			// Token: 0x040093DC RID: 37852
			[Token(Token = "0x40093DC")]
			LOADED
		}

		// Token: 0x02001845 RID: 6213
		[Token(Token = "0x2001845")]
		public struct Options
		{
			// Token: 0x040093DD RID: 37853
			[Token(Token = "0x40093DD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GameObjectSplitFrameLoadBalancer.Options DEFAULT;

			// Token: 0x040093DE RID: 37854
			[Token(Token = "0x40093DE")]
			[FieldOffset(Offset = "0x0")]
			public int maxCntInSingleFrame;

			// Token: 0x040093DF RID: 37855
			[Token(Token = "0x40093DF")]
			[FieldOffset(Offset = "0x4")]
			public int maxCntReleaseInSingleFrame;

			// Token: 0x040093E0 RID: 37856
			[Token(Token = "0x40093E0")]
			[FieldOffset(Offset = "0x8")]
			public int idleTicksForNextLoadFrame;

			// Token: 0x040093E1 RID: 37857
			[Token(Token = "0x40093E1")]
			[FieldOffset(Offset = "0xC")]
			public bool isInitialPaused;
		}

		// Token: 0x02001846 RID: 6214
		[Token(Token = "0x2001846")]
		private class AsyncTask : IComparable<GameObjectSplitFrameLoadBalancer.AsyncTask>, IDynamicAssetHandler
		{
			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x06009D18 RID: 40216 RVA: 0x0003D6B0 File Offset: 0x0003B8B0
			// (set) Token: 0x06009D19 RID: 40217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700113E")]
			public bool isLoaded
			{
				[Token(Token = "0x6009D18")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6009D19")]
				[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700113F RID: 4415
			// (get) Token: 0x06009D1A RID: 40218 RVA: 0x0003D6C8 File Offset: 0x0003B8C8
			// (set) Token: 0x06009D1B RID: 40219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700113F")]
			public bool isReleased
			{
				[Token(Token = "0x6009D1A")]
				[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6009D1B")]
				[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001140 RID: 4416
			// (get) Token: 0x06009D1C RID: 40220 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009D1D RID: 40221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001140")]
			public GameObject prefab
			{
				[Token(Token = "0x6009D1C")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6009D1D")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06009D1E RID: 40222 RVA: 0x0003D6E0 File Offset: 0x0003B8E0
			[Token(Token = "0x6009D1E")]
			[Address(RVA = "0x316A220", Offset = "0x3168E20", VA = "0x18316A220", Slot = "4")]
			public int CompareTo(GameObjectSplitFrameLoadBalancer.AsyncTask other)
			{
				return 0;
			}

			// Token: 0x06009D1F RID: 40223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009D1F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AsyncTask()
			{
			}

			// Token: 0x040093E5 RID: 37861
			[Token(Token = "0x40093E5")]
			[FieldOffset(Offset = "0x20")]
			public string path;

			// Token: 0x040093E6 RID: 37862
			[Token(Token = "0x40093E6")]
			[FieldOffset(Offset = "0x28")]
			public int priority;

			// Token: 0x040093E7 RID: 37863
			[Token(Token = "0x40093E7")]
			[FieldOffset(Offset = "0x30")]
			public IDynamicAssetWrapper assetWrapper;

			// Token: 0x040093E8 RID: 37864
			[Token(Token = "0x40093E8")]
			[FieldOffset(Offset = "0x38")]
			public Action<bool, GameObject> callback;
		}

		// Token: 0x02001847 RID: 6215
		[Token(Token = "0x2001847")]
		private struct SyncTask : IDynamicAssetHandler
		{
			// Token: 0x17001141 RID: 4417
			// (get) Token: 0x06009D20 RID: 40224 RVA: 0x0003D6F8 File Offset: 0x0003B8F8
			// (set) Token: 0x06009D21 RID: 40225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001141")]
			public bool isLoaded
			{
				[Token(Token = "0x6009D20")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x6009D21")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x06009D22 RID: 40226 RVA: 0x0003D710 File Offset: 0x0003B910
			// (set) Token: 0x06009D23 RID: 40227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001142")]
			public bool isReleased
			{
				[Token(Token = "0x6009D22")]
				[Address(RVA = "0x217A7B0", Offset = "0x21793B0", VA = "0x18217A7B0", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x6009D23")]
				[Address(RVA = "0x3188710", Offset = "0x3187310", VA = "0x183188710")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001143 RID: 4419
			// (get) Token: 0x06009D24 RID: 40228 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06009D25 RID: 40229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001143")]
			public GameObject prefab
			{
				[Token(Token = "0x6009D24")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "6")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6009D25")]
				[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
				[CompilerGenerated]
				set
				{
				}
			}
		}
	}
}
