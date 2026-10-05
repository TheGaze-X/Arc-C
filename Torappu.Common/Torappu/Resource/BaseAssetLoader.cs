using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	public class BaseAssetLoader : IHotfixable, IDisposable
	{
		// Token: 0x06000A5F RID: 2655 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x554CE00", Offset = "0x554BA00", VA = "0x18554CE00")]
		private BaseAssetLoader()
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EF")]
		public static BaseAssetLoader instanceOrNull
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x554D040", Offset = "0x554BC40", VA = "0x18554D040")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x554BDD0", Offset = "0x554A9D0", VA = "0x18554BDD0")]
		public static void PolicyOnly_CreateInstance()
		{
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x554C050", Offset = "0x554AC50", VA = "0x18554C050")]
		public static void PolicyOnly_DestroyInstance()
		{
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00007844 File Offset: 0x00005A44
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000F0")]
		public bool disableDelayedUnload
		{
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x554CFE0", Offset = "0x554BBE0", VA = "0x18554CFE0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x554D0A0", Offset = "0x554BCA0", VA = "0x18554D0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A65")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A66")]
		public T LoadAsset<T>(string path, int group) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A67")]
		private T _LoadAsset<T>(string path, int group) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0000785C File Offset: 0x00005A5C
		[Token(Token = "0x6000A68")]
		public bool TryLoad<T>(string path, out T obj, int group = 0) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00007874 File Offset: 0x00005A74
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x554C270", Offset = "0x554AE70", VA = "0x18554C270")]
		public bool TryLoad(string path, out UnityEngine.Object obj, int group = 0)
		{
			return default(bool);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x554C940", Offset = "0x554B540", VA = "0x18554C940")]
		private void _OnAssetLoaded(string path, UnityEngine.Object asset, int group)
		{
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x554C6B0", Offset = "0x554B2B0", VA = "0x18554C6B0")]
		public void UnloadAsset(UnityEngine.Object asset, int group = 0)
		{
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x554C3A0", Offset = "0x554AFA0", VA = "0x18554C3A0")]
		public void UnloadAssetGroup(int group)
		{
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x554BB40", Offset = "0x554A740", VA = "0x18554BB40")]
		public void Legacy_RemoveAsset(string path)
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x554B970", Offset = "0x554A570", VA = "0x18554B970")]
		public void ForceUnloadPending()
		{
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x554BD10", Offset = "0x554A910", VA = "0x18554BD10")]
		public void NotifyCurrentTime(long curTs)
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x554C760", Offset = "0x554B360", VA = "0x18554C760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0000788C File Offset: 0x00005A8C
		[Token(Token = "0x6000A71")]
		public static GenericPool<List<T>>.Ref GetPoolListRef<T>()
		{
			return default(GenericPool<List<T>>.Ref);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x554B7B0", Offset = "0x554A3B0", VA = "0x18554B7B0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x554B750", Offset = "0x554A350", VA = "0x18554B750")]
		public BaseAssetLoader.EditorInterface CreateEditorInterface()
		{
			return null;
		}

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		public const int DEFAULT_GROUP = 0;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, UnityEngine.Object> m_pathToAsset;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		[FieldOffset(Offset = "0x18")]
		private BaseAssetLoader.AssetGroupRecord m_groupRecord;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, BaseAssetLoader.AssetWrapper> m_loadedAssets;

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		[FieldOffset(Offset = "0x28")]
		private BaseAssetLoader.UnloadManager m_unloadManager;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0x0")]
		private static BaseAssetLoader s_baseAssetLoader;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate241 __Hotfix0_get_instanceOrNull;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate14 __Hotfix0_PolicyOnly_CreateInstance;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate14 __Hotfix0_PolicyOnly_DestroyInstance;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_disableDelayedUnload;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_disableDelayedUnload;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate242 __Hotfix0_TryLoad;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate243 __Hotfix0__OnAssetLoaded;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate117 __Hotfix0_UnloadAsset;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate26 __Hotfix0_UnloadAssetGroup;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate0 __Hotfix0_Legacy_RemoveAsset;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ForceUnloadPending;

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate236 __Hotfix0_NotifyCurrentTime;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate1 __Hotfix0__InitIfNot;

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate244 __Hotfix0_CreateEditorInterface;

		// Token: 0x020001BF RID: 447
		[Token(Token = "0x20001BF")]
		private class AssetWrapper : IHotfixable
		{
			// Token: 0x06000A74 RID: 2676 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x554A640", Offset = "0x5549240", VA = "0x18554A640")]
			public AssetWrapper(int instId, string path, BaseAssetLoader.AssetGroupRecord record, int initGroup)
			{
			}

			// Token: 0x06000A75 RID: 2677 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x554A340", Offset = "0x5548F40", VA = "0x18554A340")]
			public void AddGroupRef(int group)
			{
			}

			// Token: 0x06000A76 RID: 2678 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x554A590", Offset = "0x5549190", VA = "0x18554A590")]
			public void RemoveGroupRef(int group)
			{
			}

			// Token: 0x06000A77 RID: 2679 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x554A410", Offset = "0x5549010", VA = "0x18554A410")]
			public void ClearAllRefs()
			{
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000A78 RID: 2680 RVA: 0x000078A4 File Offset: 0x00005AA4
			[Token(Token = "0x170000F1")]
			public bool isRefered
			{
				[Token(Token = "0x6000A78")]
				[Address(RVA = "0x554A7F0", Offset = "0x55493F0", VA = "0x18554A7F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000A25 RID: 2597
			[Token(Token = "0x4000A25")]
			[FieldOffset(Offset = "0x10")]
			private List<int> m_referGroups;

			// Token: 0x04000A26 RID: 2598
			[Token(Token = "0x4000A26")]
			[FieldOffset(Offset = "0x18")]
			private BaseAssetLoader.AssetGroupRecord m_globalGroupRecord;

			// Token: 0x04000A27 RID: 2599
			[Token(Token = "0x4000A27")]
			[FieldOffset(Offset = "0x20")]
			public int instId;

			// Token: 0x04000A28 RID: 2600
			[Token(Token = "0x4000A28")]
			[FieldOffset(Offset = "0x28")]
			public string path;

			// Token: 0x04000A29 RID: 2601
			[Token(Token = "0x4000A29")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate232 _c__Hotfix0_ctor;

			// Token: 0x04000A2A RID: 2602
			[Token(Token = "0x4000A2A")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate26 __Hotfix0_AddGroupRef;

			// Token: 0x04000A2B RID: 2603
			[Token(Token = "0x4000A2B")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate26 __Hotfix0_RemoveGroupRef;

			// Token: 0x04000A2C RID: 2604
			[Token(Token = "0x4000A2C")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate1 __Hotfix0_ClearAllRefs;

			// Token: 0x04000A2D RID: 2605
			[Token(Token = "0x4000A2D")]
			[FieldOffset(Offset = "0x20")]
			private static __XLua_Gen_Delegate21 __Hotfix0_get_isRefered;
		}

		// Token: 0x020001C0 RID: 448
		[Token(Token = "0x20001C0")]
		private class AssetGroupRecord : IHotfixable, IDisposable
		{
			// Token: 0x06000A79 RID: 2681 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x5549E40", Offset = "0x5548A40", VA = "0x185549E40")]
			public void AddRef(int group, int asset)
			{
			}

			// Token: 0x06000A7A RID: 2682 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x554A100", Offset = "0x5548D00", VA = "0x18554A100")]
			public void RemoveRef(int group, int asset)
			{
			}

			// Token: 0x06000A7B RID: 2683 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x554A030", Offset = "0x5548C30", VA = "0x18554A030")]
			public IEnumerator<int> GetRefedAssets(int group)
			{
				return null;
			}

			// Token: 0x06000A7C RID: 2684 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x5549FB0", Offset = "0x5548BB0", VA = "0x185549FB0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000A7D RID: 2685 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x554A280", Offset = "0x5548E80", VA = "0x18554A280")]
			public AssetGroupRecord()
			{
			}

			// Token: 0x04000A2E RID: 2606
			[Token(Token = "0x4000A2E")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<int, HashSet<int>> m_groupToAssets;

			// Token: 0x04000A2F RID: 2607
			[Token(Token = "0x4000A2F")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate233 __Hotfix0_AddRef;

			// Token: 0x04000A30 RID: 2608
			[Token(Token = "0x4000A30")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate233 __Hotfix0_RemoveRef;

			// Token: 0x04000A31 RID: 2609
			[Token(Token = "0x4000A31")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate234 __Hotfix0_GetRefedAssets;

			// Token: 0x04000A32 RID: 2610
			[Token(Token = "0x4000A32")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;

			// Token: 0x04000A33 RID: 2611
			[Token(Token = "0x4000A33")]
			[FieldOffset(Offset = "0x20")]
			private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
		}

		// Token: 0x020001C2 RID: 450
		[Token(Token = "0x20001C2")]
		private class UnloadManager : IHotfixable, IDisposable
		{
			// Token: 0x06000A86 RID: 2694 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x55625C0", Offset = "0x55611C0", VA = "0x1855625C0")]
			public UnloadManager(BaseAssetLoader baseAssetLoader)
			{
			}

			// Token: 0x06000A87 RID: 2695 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x55610E0", Offset = "0x555FCE0", VA = "0x1855610E0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000A88 RID: 2696 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x5561500", Offset = "0x5560100", VA = "0x185561500")]
			public void NotifyLoadAsset(string path, int group)
			{
			}

			// Token: 0x06000A89 RID: 2697 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x5561310", Offset = "0x555FF10", VA = "0x185561310")]
			public void Legacy_RemoveAsset(string path)
			{
			}

			// Token: 0x06000A8A RID: 2698 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x55615C0", Offset = "0x55601C0", VA = "0x1855615C0")]
			public void UnloadAsset(UnityEngine.Object asset, int group)
			{
			}

			// Token: 0x06000A8B RID: 2699 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x5561480", Offset = "0x5560080", VA = "0x185561480")]
			public void NotifyCurrentTs(long curTs)
			{
			}

			// Token: 0x06000A8C RID: 2700 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x5562450", Offset = "0x5561050", VA = "0x185562450")]
			private void _UnloadAssetImpl(BaseAssetLoader.UnloadManager.UnloadRequest request)
			{
			}

			// Token: 0x06000A8D RID: 2701 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x5561B50", Offset = "0x5560750", VA = "0x185561B50")]
			private void _DoReleaseAsset(string path, int assetId, UnityEngine.Object asset)
			{
			}

			// Token: 0x06000A8E RID: 2702 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x5561180", Offset = "0x555FD80", VA = "0x185561180")]
			public void ForceUnloadPendingAssets()
			{
			}

			// Token: 0x06000A8F RID: 2703 RVA: 0x000078EC File Offset: 0x00005AEC
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x5561CD0", Offset = "0x55608D0", VA = "0x185561CD0")]
			private long _GetNextUnloadTs()
			{
				return 0L;
			}

			// Token: 0x06000A90 RID: 2704 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x5562130", Offset = "0x5560D30", VA = "0x185562130")]
			private void _TryUnloadPendingRequests()
			{
			}

			// Token: 0x06000A91 RID: 2705 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x5561D40", Offset = "0x5560940", VA = "0x185561D40")]
			private void _RemovePendingRequestsByPath(string path)
			{
			}

			// Token: 0x06000A92 RID: 2706 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x55619F0", Offset = "0x55605F0", VA = "0x1855619F0")]
			private void _ClearAllAssets()
			{
			}

			// Token: 0x04000A3B RID: 2619
			[Token(Token = "0x4000A3B")]
			private const long INVALID_TS_DELTA = 60L;

			// Token: 0x04000A3C RID: 2620
			[Token(Token = "0x4000A3C")]
			private const long UNLOAD_DELAY = 10L;

			// Token: 0x04000A3D RID: 2621
			[Token(Token = "0x4000A3D")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, BaseAssetLoader.UnloadManager.UnloadRequest> m_pendingUnloadRequests;

			// Token: 0x04000A3E RID: 2622
			[Token(Token = "0x4000A3E")]
			[FieldOffset(Offset = "0x18")]
			private List<string> m_stringListCache;

			// Token: 0x04000A3F RID: 2623
			[Token(Token = "0x4000A3F")]
			[FieldOffset(Offset = "0x20")]
			private BaseAssetLoader m_loader;

			// Token: 0x04000A40 RID: 2624
			[Token(Token = "0x4000A40")]
			[FieldOffset(Offset = "0x28")]
			private long m_currentTs;

			// Token: 0x04000A41 RID: 2625
			[Token(Token = "0x4000A41")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate0 _c__Hotfix0_ctor;

			// Token: 0x04000A42 RID: 2626
			[Token(Token = "0x4000A42")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;

			// Token: 0x04000A43 RID: 2627
			[Token(Token = "0x4000A43")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate117 __Hotfix0_NotifyLoadAsset;

			// Token: 0x04000A44 RID: 2628
			[Token(Token = "0x4000A44")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate0 __Hotfix0_Legacy_RemoveAsset;

			// Token: 0x04000A45 RID: 2629
			[Token(Token = "0x4000A45")]
			[FieldOffset(Offset = "0x20")]
			private static __XLua_Gen_Delegate117 __Hotfix0_UnloadAsset;

			// Token: 0x04000A46 RID: 2630
			[Token(Token = "0x4000A46")]
			[FieldOffset(Offset = "0x28")]
			private static __XLua_Gen_Delegate236 __Hotfix0_NotifyCurrentTs;

			// Token: 0x04000A47 RID: 2631
			[Token(Token = "0x4000A47")]
			[FieldOffset(Offset = "0x30")]
			private static __XLua_Gen_Delegate237 __Hotfix0__DoReleaseAsset;

			// Token: 0x04000A48 RID: 2632
			[Token(Token = "0x4000A48")]
			[FieldOffset(Offset = "0x38")]
			private static __XLua_Gen_Delegate1 __Hotfix0_ForceUnloadPendingAssets;

			// Token: 0x04000A49 RID: 2633
			[Token(Token = "0x4000A49")]
			[FieldOffset(Offset = "0x40")]
			private static __XLua_Gen_Delegate238 __Hotfix0__GetNextUnloadTs;

			// Token: 0x04000A4A RID: 2634
			[Token(Token = "0x4000A4A")]
			[FieldOffset(Offset = "0x48")]
			private static __XLua_Gen_Delegate1 __Hotfix0__TryUnloadPendingRequests;

			// Token: 0x04000A4B RID: 2635
			[Token(Token = "0x4000A4B")]
			[FieldOffset(Offset = "0x50")]
			private static __XLua_Gen_Delegate0 __Hotfix0__RemovePendingRequestsByPath;

			// Token: 0x04000A4C RID: 2636
			[Token(Token = "0x4000A4C")]
			[FieldOffset(Offset = "0x58")]
			private static __XLua_Gen_Delegate1 __Hotfix0__ClearAllAssets;

			// Token: 0x020001C3 RID: 451
			[Token(Token = "0x20001C3")]
			private struct UnloadRequest : IHotfixable
			{
				// Token: 0x06000A93 RID: 2707 RVA: 0x00007904 File Offset: 0x00005B04
				[Token(Token = "0x6000A93")]
				[Address(RVA = "0x55627D0", Offset = "0x55613D0", VA = "0x1855627D0")]
				public bool IsEmpty()
				{
					return default(bool);
				}

				// Token: 0x06000A94 RID: 2708 RVA: 0x0000791C File Offset: 0x00005B1C
				[Token(Token = "0x6000A94")]
				[Address(RVA = "0x5562840", Offset = "0x5561440", VA = "0x185562840")]
				public bool IsSameRequest(UnityEngine.Object asset, int group)
				{
					return default(bool);
				}

				// Token: 0x06000A95 RID: 2709 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x6000A95")]
				[Address(RVA = "0x5562720", Offset = "0x5561320", VA = "0x185562720")]
				public static string GetRequestID(string path, int group)
				{
					return null;
				}

				// Token: 0x04000A4D RID: 2637
				[Token(Token = "0x4000A4D")]
				[FieldOffset(Offset = "0x0")]
				public string path;

				// Token: 0x04000A4E RID: 2638
				[Token(Token = "0x4000A4E")]
				[FieldOffset(Offset = "0x8")]
				public int group;

				// Token: 0x04000A4F RID: 2639
				[Token(Token = "0x4000A4F")]
				[FieldOffset(Offset = "0x10")]
				public BaseAssetLoader.AssetWrapper wrapper;

				// Token: 0x04000A50 RID: 2640
				[Token(Token = "0x4000A50")]
				[FieldOffset(Offset = "0x18")]
				public UnityEngine.Object asset;

				// Token: 0x04000A51 RID: 2641
				[Token(Token = "0x4000A51")]
				[FieldOffset(Offset = "0x20")]
				public int assetId;

				// Token: 0x04000A52 RID: 2642
				[Token(Token = "0x4000A52")]
				[FieldOffset(Offset = "0x28")]
				public long unloadTs;

				// Token: 0x04000A53 RID: 2643
				[Token(Token = "0x4000A53")]
				[FieldOffset(Offset = "0x0")]
				private static __XLua_Gen_Delegate235 __Hotfix0_GetRequestID;
			}
		}

		// Token: 0x020001C4 RID: 452
		[Token(Token = "0x20001C4")]
		public interface IAssets
		{
			// Token: 0x06000A96 RID: 2710
			[Token(Token = "0x6000A96")]
			T LoadAsset<T>(string path) where T : UnityEngine.Object;
		}

		// Token: 0x020001C5 RID: 453
		[Token(Token = "0x20001C5")]
		public class Assets : BaseAssetLoader.IAssets, ILoadAsset, IHotfixable
		{
			// Token: 0x06000A97 RID: 2711 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x554ABC0", Offset = "0x55497C0", VA = "0x18554ABC0")]
			private Assets()
			{
			}

			// Token: 0x06000A98 RID: 2712 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x554A870", Offset = "0x5549470", VA = "0x18554A870")]
			public static BaseAssetLoader.Assets Create(int groupId)
			{
				return null;
			}

			// Token: 0x06000A99 RID: 2713 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000A99")]
			public T LoadAsset<T>(string path) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x06000A9A RID: 2714 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x554A9A0", Offset = "0x55495A0", VA = "0x18554A9A0", Slot = "6")]
			public UnityEngine.Object LoadAsset(string path)
			{
				return null;
			}

			// Token: 0x06000A9B RID: 2715 RVA: 0x00007934 File Offset: 0x00005B34
			[Token(Token = "0x6000A9B")]
			public bool TryLoadAsset<T>(string path, out T obj) where T : UnityEngine.Object
			{
				return default(bool);
			}

			// Token: 0x06000A9C RID: 2716 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x554AA30", Offset = "0x5549630", VA = "0x18554AA30", Slot = "7")]
			public void UnloadAsset(UnityEngine.Object asset)
			{
			}

			// Token: 0x06000A9D RID: 2717 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x554AB00", Offset = "0x5549700", VA = "0x18554AB00")]
			public void UnloadAssets()
			{
			}

			// Token: 0x04000A54 RID: 2644
			[Token(Token = "0x4000A54")]
			[FieldOffset(Offset = "0x10")]
			private int m_groupId;

			// Token: 0x04000A55 RID: 2645
			[Token(Token = "0x4000A55")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

			// Token: 0x04000A56 RID: 2646
			[Token(Token = "0x4000A56")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate239 __Hotfix0_Create;

			// Token: 0x04000A57 RID: 2647
			[Token(Token = "0x4000A57")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate240 __Hotfix0_LoadAsset;

			// Token: 0x04000A58 RID: 2648
			[Token(Token = "0x4000A58")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate0 __Hotfix0_UnloadAsset;

			// Token: 0x04000A59 RID: 2649
			[Token(Token = "0x4000A59")]
			[FieldOffset(Offset = "0x20")]
			private static __XLua_Gen_Delegate1 __Hotfix0_UnloadAssets;
		}

		// Token: 0x020001C6 RID: 454
		[Token(Token = "0x20001C6")]
		public class EditorInterface
		{
			// Token: 0x06000A9E RID: 2718 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EditorInterface()
			{
			}
		}
	}
}
