using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;

namespace Torappu.Resource.AB
{
	// Token: 0x0200176A RID: 5994
	[Token(Token = "0x200176A")]
	public class ABResourceManager : PersistentSingleton<ABResourceManager>, IResourceManager
	{
		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06009707 RID: 38663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001022")]
		private IConverter manifestDecrypter
		{
			[Token(Token = "0x6009707")]
			[Address(RVA = "0x311EE40", Offset = "0x311DA40", VA = "0x18311EE40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06009708 RID: 38664 RVA: 0x0003AC38 File Offset: 0x00038E38
		[Token(Token = "0x17001023")]
		[Inspect]
		[ReadOnly]
		public bool inited
		{
			[Token(Token = "0x6009708")]
			[Address(RVA = "0x311EB60", Offset = "0x311D760", VA = "0x18311EB60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06009709 RID: 38665 RVA: 0x0003AC50 File Offset: 0x00038E50
		[Token(Token = "0x17001024")]
		[Inspect]
		[ReadOnly]
		public int loadedBundleCnt
		{
			[Token(Token = "0x6009709")]
			[Address(RVA = "0x311EC40", Offset = "0x311D840", VA = "0x18311EC40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x0600970A RID: 38666 RVA: 0x0003AC68 File Offset: 0x00038E68
		[Token(Token = "0x17001025")]
		[Inspect]
		[ReadOnly]
		public int loadedAssetCnt
		{
			[Token(Token = "0x600970A")]
			[Address(RVA = "0x311EBC0", Offset = "0x311D7C0", VA = "0x18311EBC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x0600970B RID: 38667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001026")]
		internal IEnumerable<string> allAssets
		{
			[Token(Token = "0x600970B")]
			[Address(RVA = "0x311EAE0", Offset = "0x311D6E0", VA = "0x18311EAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x0600970C RID: 38668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001027")]
		internal IEnumerable<BundleHolder> loadedBundles
		{
			[Token(Token = "0x600970C")]
			[Address(RVA = "0x311EDA0", Offset = "0x311D9A0", VA = "0x18311EDA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x0600970D RID: 38669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001028")]
		internal IEnumerable<string> loadedBundleNames
		{
			[Token(Token = "0x600970D")]
			[Address(RVA = "0x311ECE0", Offset = "0x311D8E0", VA = "0x18311ECE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600970E RID: 38670 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600970F RID: 38671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001029")]
		private ResourceOptions options
		{
			[Token(Token = "0x600970E")]
			[Address(RVA = "0x311EEC0", Offset = "0x311DAC0", VA = "0x18311EEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600970F")]
			[Address(RVA = "0x311EFE0", Offset = "0x311DBE0", VA = "0x18311EFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06009710 RID: 38672 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009711 RID: 38673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700102A")]
		private BundleRouter router
		{
			[Token(Token = "0x6009710")]
			[Address(RVA = "0x311EF80", Offset = "0x311DB80", VA = "0x18311EF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009711")]
			[Address(RVA = "0x311F0E0", Offset = "0x311DCE0", VA = "0x18311F0E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06009712 RID: 38674 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009713 RID: 38675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700102B")]
		private ResourceManifest resManifest
		{
			[Token(Token = "0x6009712")]
			[Address(RVA = "0x311EF20", Offset = "0x311DB20", VA = "0x18311EF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009713")]
			[Address(RVA = "0x311F060", Offset = "0x311DC60", VA = "0x18311F060")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06009714 RID: 38676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009714")]
		[Address(RVA = "0x311E6C0", Offset = "0x311D2C0", VA = "0x18311E6C0")]
		private ABResourceManager()
		{
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009715")]
		[Address(RVA = "0x3119270", Offset = "0x3117E70", VA = "0x183119270", Slot = "9")]
		public void InitIfNot()
		{
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009716")]
		[Address(RVA = "0x3118EE0", Offset = "0x3117AE0", VA = "0x183118EE0", Slot = "10")]
		public void ForceReInit()
		{
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009717")]
		[Address(RVA = "0x31190C0", Offset = "0x3117CC0", VA = "0x1831190C0", Slot = "11")]
		public string GetDebugStr()
		{
			return null;
		}

		// Token: 0x06009718 RID: 38680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009718")]
		[Address(RVA = "0x311A320", Offset = "0x3118F20", VA = "0x18311A320")]
		public ResourceManifest LoadResourceManifest(out string manifestName, out bool isStreaming)
		{
			return null;
		}

		// Token: 0x06009719 RID: 38681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009719")]
		[Address(RVA = "0x3118D20", Offset = "0x3117920", VA = "0x183118D20")]
		internal void FetchLoadedAssets(List<string> results)
		{
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600971A")]
		public T Load<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600971B")]
		[Address(RVA = "0x311B650", Offset = "0x311A250", VA = "0x18311B650", Slot = "13")]
		public UnityEngine.Object Load(string path)
		{
			return null;
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600971C")]
		public AsyncResource LoadAsync<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600971D")]
		[Address(RVA = "0x3119B10", Offset = "0x3118710", VA = "0x183119B10", Slot = "17")]
		public AsyncResource LoadAsync(string path)
		{
			return null;
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600971E")]
		public void LoadAsync<T>(string path, Action<bool, T> cb) where T : UnityEngine.Object
		{
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600971F")]
		[Address(RVA = "0x31199B0", Offset = "0x31185B0", VA = "0x1831199B0", Slot = "19")]
		public void LoadAsync(string path, Action<bool, UnityEngine.Object> cb)
		{
		}

		// Token: 0x06009720 RID: 38688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009720")]
		public T[] LoadAll<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06009721 RID: 38689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009721")]
		[Address(RVA = "0x31192D0", Offset = "0x3117ED0", VA = "0x1831192D0", Slot = "15")]
		public UnityEngine.Object[] LoadAll(string path)
		{
			return null;
		}

		// Token: 0x06009722 RID: 38690 RVA: 0x0003AC80 File Offset: 0x00038E80
		[Token(Token = "0x6009722")]
		public bool TryLoad<T>(string path, out T obj) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06009723 RID: 38691 RVA: 0x0003AC98 File Offset: 0x00038E98
		[Token(Token = "0x6009723")]
		[Address(RVA = "0x311C0D0", Offset = "0x311ACD0", VA = "0x18311C0D0", Slot = "21")]
		public bool TryLoad(string path, out UnityEngine.Object obj)
		{
			return default(bool);
		}

		// Token: 0x06009724 RID: 38692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009724")]
		[Address(RVA = "0x311C550", Offset = "0x311B150", VA = "0x18311C550", Slot = "22")]
		public void UnloadAsset(UnityEngine.Object obj)
		{
		}

		// Token: 0x06009725 RID: 38693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009725")]
		[Address(RVA = "0x311C4D0", Offset = "0x311B0D0", VA = "0x18311C4D0", Slot = "23")]
		public void UnloadAssetByInstanceId(int instanceId)
		{
		}

		// Token: 0x06009726 RID: 38694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009726")]
		[Address(RVA = "0x311E470", Offset = "0x311D070", VA = "0x18311E470")]
		private void _UnloadAssetImpl(int instanceId)
		{
		}

		// Token: 0x06009727 RID: 38695 RVA: 0x0003ACB0 File Offset: 0x00038EB0
		[Token(Token = "0x6009727")]
		[Address(RVA = "0x3118C30", Offset = "0x3117830", VA = "0x183118C30", Slot = "24")]
		public bool CheckExists(string path)
		{
			return default(bool);
		}

		// Token: 0x06009728 RID: 38696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009728")]
		[Address(RVA = "0x311A890", Offset = "0x3119490", VA = "0x18311A890", Slot = "25")]
		public AsyncOperation LoadSceneAsync(string path, LoadSceneMode mode)
		{
			return null;
		}

		// Token: 0x06009729 RID: 38697 RVA: 0x0003ACC8 File Offset: 0x00038EC8
		[Token(Token = "0x6009729")]
		[Address(RVA = "0x311AF70", Offset = "0x3119B70", VA = "0x18311AF70", Slot = "26")]
		public bool LoadScene(string path, LoadSceneMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600972A RID: 38698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600972A")]
		[Address(RVA = "0x311C610", Offset = "0x311B210", VA = "0x18311C610", Slot = "27")]
		public void UnloadScene(string path, bool forceUnloadEvenUsed)
		{
		}

		// Token: 0x0600972B RID: 38699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600972B")]
		[Address(RVA = "0x311C840", Offset = "0x311B440", VA = "0x18311C840", Slot = "28")]
		public AsyncOperation UnloadUnusedAssets()
		{
			return null;
		}

		// Token: 0x0600972C RID: 38700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600972C")]
		[Address(RVA = "0x311C400", Offset = "0x311B000", VA = "0x18311C400", Slot = "29")]
		public IEnumerator UnloadAllAssets(bool forceUnloadEvenUsed)
		{
			return null;
		}

		// Token: 0x0600972D RID: 38701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600972D")]
		[Address(RVA = "0x311DFD0", Offset = "0x311CBD0", VA = "0x18311DFD0")]
		private void _RemoveAssetsWithoutBundle()
		{
		}

		// Token: 0x0600972E RID: 38702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600972E")]
		[Address(RVA = "0x311C310", Offset = "0x311AF10", VA = "0x18311C310", Slot = "30")]
		public IEnumerator UnloadAllAssetsExcept(string[] excludedPrefixes, bool forceUnloadEvenUsed)
		{
			return null;
		}

		// Token: 0x0600972F RID: 38703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600972F")]
		[Address(RVA = "0x311C030", Offset = "0x311AC30", VA = "0x18311C030", Slot = "31")]
		public void RegisterListener(IResourceListener listener)
		{
		}

		// Token: 0x06009730 RID: 38704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009730")]
		[Address(RVA = "0x311C8C0", Offset = "0x311B4C0", VA = "0x18311C8C0", Slot = "32")]
		public void UnregisterListener(IResourceListener listener)
		{
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009731")]
		[Address(RVA = "0x311BE20", Offset = "0x311AA20", VA = "0x18311BE20", Slot = "33")]
		public void MarkAssetInvalid(string path)
		{
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009732")]
		[Address(RVA = "0x3118F40", Offset = "0x3117B40", VA = "0x183118F40", Slot = "34")]
		public string GenerateAssetFullPath(string path, out bool isStreaming)
		{
			return null;
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009733")]
		[Address(RVA = "0x311D8A0", Offset = "0x311C4A0", VA = "0x18311D8A0")]
		private IEnumerator _LoadAsync(string path, Action<bool, UnityEngine.Object> cb)
		{
			return null;
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009734")]
		private IEnumerator _LoadAsync<T>(string path, Action<bool, T> cb) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009735")]
		[Address(RVA = "0x311E610", Offset = "0x311D210", VA = "0x18311E610")]
		private IEnumerator _WaitForUnfinishedAsyncResources()
		{
			return null;
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009736")]
		[Address(RVA = "0x311CE90", Offset = "0x311BA90", VA = "0x18311CE90")]
		private void _HandleAsyncResource(AsyncResource asyncRes, BundleHolder bundle, string path)
		{
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009737")]
		[Address(RVA = "0x311DB00", Offset = "0x311C700", VA = "0x18311DB00")]
		private void _OnAssetLoaded(UnityEngine.Object asset, BundleHolder bundle, string path)
		{
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009738")]
		[Address(RVA = "0x311CA10", Offset = "0x311B610", VA = "0x18311CA10")]
		private void _DoInitIfNot(bool isFirstInit)
		{
		}

		// Token: 0x06009739 RID: 38713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009739")]
		[Address(RVA = "0x311D4A0", Offset = "0x311C0A0", VA = "0x18311D4A0")]
		private void _InitResLangFolder(ResourceOptions options)
		{
		}

		// Token: 0x0600973A RID: 38714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600973A")]
		[Address(RVA = "0x311D590", Offset = "0x311C190", VA = "0x18311D590")]
		private void _InitResourceManifest()
		{
		}

		// Token: 0x0600973B RID: 38715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600973B")]
		[Address(RVA = "0x311D090", Offset = "0x311BC90", VA = "0x18311D090")]
		private void _InitBundleManager()
		{
		}

		// Token: 0x0600973C RID: 38716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600973C")]
		[Address(RVA = "0x311C1F0", Offset = "0x311ADF0", VA = "0x18311C1F0")]
		public static void UnloadABAsset(UnityEngine.Object asset, bool allowDestroyingAssets)
		{
		}

		// Token: 0x0600973D RID: 38717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600973D")]
		[Address(RVA = "0x311DE20", Offset = "0x311CA20", VA = "0x18311DE20")]
		private string _PreprocessAssetPath(string path)
		{
			return null;
		}

		// Token: 0x0600973E RID: 38718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600973E")]
		[Address(RVA = "0x311D9A0", Offset = "0x311C5A0", VA = "0x18311D9A0")]
		private void _LogWhenLoadBundleFailed(string path, ABResourceManager.BundleInfo info)
		{
		}

		// Token: 0x0600973F RID: 38719 RVA: 0x0003ACE0 File Offset: 0x00038EE0
		[Token(Token = "0x600973F")]
		[Address(RVA = "0x311D7D0", Offset = "0x311C3D0", VA = "0x18311D7D0")]
		private static bool _IsAuditMode()
		{
			return default(bool);
		}

		// Token: 0x06009740 RID: 38720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009740")]
		[Address(RVA = "0x311C960", Offset = "0x311B560", VA = "0x18311C960")]
		private static IEnumerator _DeleteABFileDelayed(string abFilePath)
		{
			return null;
		}

		// Token: 0x04008D41 RID: 36161
		[Token(Token = "0x4008D41")]
		[FieldOffset(Offset = "0x18")]
		private bool m_inited;

		// Token: 0x04008D42 RID: 36162
		[Token(Token = "0x4008D42")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, ABResourceManager.BundleInfo> m_assetNameToBundleInfoMap;

		// Token: 0x04008D43 RID: 36163
		[Token(Token = "0x4008D43")]
		[FieldOffset(Offset = "0x28")]
		private LocalGenericPool<ABResourceManager.LoadedAssetEntry> m_assetEntryPool;

		// Token: 0x04008D44 RID: 36164
		[Token(Token = "0x4008D44")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, ABResourceManager.LoadedAssetEntry> m_loadedAssetInstanceIdMap;

		// Token: 0x04008D45 RID: 36165
		[Token(Token = "0x4008D45")]
		[FieldOffset(Offset = "0x38")]
		private ABResourceManager.BundleManager m_manager;

		// Token: 0x04008D46 RID: 36166
		[Token(Token = "0x4008D46")]
		[FieldOffset(Offset = "0x40")]
		private ListSet<IResourceListener> m_listeners;

		// Token: 0x04008D47 RID: 36167
		[Token(Token = "0x4008D47")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<AsyncResource> m_unfinishedAsyncResources;

		// Token: 0x04008D48 RID: 36168
		[Token(Token = "0x4008D48")]
		[FieldOffset(Offset = "0x50")]
		private List<AsyncResource> m_tempAsyncResList;

		// Token: 0x04008D49 RID: 36169
		[Token(Token = "0x4008D49")]
		[FieldOffset(Offset = "0x58")]
		private IConverter m_manifestDecrypter;

		// Token: 0x04008D4A RID: 36170
		[Token(Token = "0x4008D4A")]
		[FieldOffset(Offset = "0x60")]
		private string m_resLangFolder;

		// Token: 0x04008D4B RID: 36171
		[Token(Token = "0x4008D4B")]
		[FieldOffset(Offset = "0x68")]
		private string m_commonLangFolder;

		// Token: 0x04008D4E RID: 36174
		[Token(Token = "0x4008D4E")]
		[FieldOffset(Offset = "0x80")]
		private RuntimeAssetMeta.Manager assetMetas;

		// Token: 0x04008D50 RID: 36176
		[Token(Token = "0x4008D50")]
		[FieldOffset(Offset = "0x90")]
		private bool isStreamingManifest;

		// Token: 0x04008D51 RID: 36177
		[Token(Token = "0x4008D51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_manifestDecrypter;

		// Token: 0x04008D52 RID: 36178
		[Token(Token = "0x4008D52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x04008D53 RID: 36179
		[Token(Token = "0x4008D53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_loadedBundleCnt;

		// Token: 0x04008D54 RID: 36180
		[Token(Token = "0x4008D54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_loadedAssetCnt;

		// Token: 0x04008D55 RID: 36181
		[Token(Token = "0x4008D55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_allAssets;

		// Token: 0x04008D56 RID: 36182
		[Token(Token = "0x4008D56")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_loadedBundles;

		// Token: 0x04008D57 RID: 36183
		[Token(Token = "0x4008D57")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_loadedBundleNames;

		// Token: 0x04008D58 RID: 36184
		[Token(Token = "0x4008D58")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x04008D59 RID: 36185
		[Token(Token = "0x4008D59")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_options;

		// Token: 0x04008D5A RID: 36186
		[Token(Token = "0x4008D5A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_router;

		// Token: 0x04008D5B RID: 36187
		[Token(Token = "0x4008D5B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_router;

		// Token: 0x04008D5C RID: 36188
		[Token(Token = "0x4008D5C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_resManifest;

		// Token: 0x04008D5D RID: 36189
		[Token(Token = "0x4008D5D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_resManifest;

		// Token: 0x04008D5E RID: 36190
		[Token(Token = "0x4008D5E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008D5F RID: 36191
		[Token(Token = "0x4008D5F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04008D60 RID: 36192
		[Token(Token = "0x4008D60")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ForceReInit;

		// Token: 0x04008D61 RID: 36193
		[Token(Token = "0x4008D61")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetDebugStr;

		// Token: 0x04008D62 RID: 36194
		[Token(Token = "0x4008D62")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadResourceManifest;

		// Token: 0x04008D63 RID: 36195
		[Token(Token = "0x4008D63")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FetchLoadedAssets;

		// Token: 0x04008D64 RID: 36196
		[Token(Token = "0x4008D64")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04008D65 RID: 36197
		[Token(Token = "0x4008D65")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1_Load;

		// Token: 0x04008D66 RID: 36198
		[Token(Token = "0x4008D66")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadAsync;

		// Token: 0x04008D67 RID: 36199
		[Token(Token = "0x4008D67")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix1_LoadAsync;

		// Token: 0x04008D68 RID: 36200
		[Token(Token = "0x4008D68")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix2_LoadAsync;

		// Token: 0x04008D69 RID: 36201
		[Token(Token = "0x4008D69")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix3_LoadAsync;

		// Token: 0x04008D6A RID: 36202
		[Token(Token = "0x4008D6A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_LoadAll;

		// Token: 0x04008D6B RID: 36203
		[Token(Token = "0x4008D6B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix1_LoadAll;

		// Token: 0x04008D6C RID: 36204
		[Token(Token = "0x4008D6C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_TryLoad;

		// Token: 0x04008D6D RID: 36205
		[Token(Token = "0x4008D6D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix1_TryLoad;

		// Token: 0x04008D6E RID: 36206
		[Token(Token = "0x4008D6E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x04008D6F RID: 36207
		[Token(Token = "0x4008D6F")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_UnloadAssetByInstanceId;

		// Token: 0x04008D70 RID: 36208
		[Token(Token = "0x4008D70")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UnloadAssetImpl;

		// Token: 0x04008D71 RID: 36209
		[Token(Token = "0x4008D71")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckExists;

		// Token: 0x04008D72 RID: 36210
		[Token(Token = "0x4008D72")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_LoadSceneAsync;

		// Token: 0x04008D73 RID: 36211
		[Token(Token = "0x4008D73")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_LoadScene;

		// Token: 0x04008D74 RID: 36212
		[Token(Token = "0x4008D74")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_UnloadScene;

		// Token: 0x04008D75 RID: 36213
		[Token(Token = "0x4008D75")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_UnloadUnusedAssets;

		// Token: 0x04008D76 RID: 36214
		[Token(Token = "0x4008D76")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_UnloadAllAssets;

		// Token: 0x04008D77 RID: 36215
		[Token(Token = "0x4008D77")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__RemoveAssetsWithoutBundle;

		// Token: 0x04008D78 RID: 36216
		[Token(Token = "0x4008D78")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_UnloadAllAssetsExcept;

		// Token: 0x04008D79 RID: 36217
		[Token(Token = "0x4008D79")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_RegisterListener;

		// Token: 0x04008D7A RID: 36218
		[Token(Token = "0x4008D7A")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_UnregisterListener;

		// Token: 0x04008D7B RID: 36219
		[Token(Token = "0x4008D7B")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_MarkAssetInvalid;

		// Token: 0x04008D7C RID: 36220
		[Token(Token = "0x4008D7C")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GenerateAssetFullPath;

		// Token: 0x04008D7D RID: 36221
		[Token(Token = "0x4008D7D")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__LoadAsync;

		// Token: 0x04008D7E RID: 36222
		[Token(Token = "0x4008D7E")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix1__LoadAsync;

		// Token: 0x04008D7F RID: 36223
		[Token(Token = "0x4008D7F")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__WaitForUnfinishedAsyncResources;

		// Token: 0x04008D80 RID: 36224
		[Token(Token = "0x4008D80")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__HandleAsyncResource;

		// Token: 0x04008D81 RID: 36225
		[Token(Token = "0x4008D81")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__OnAssetLoaded;

		// Token: 0x04008D82 RID: 36226
		[Token(Token = "0x4008D82")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__DoInitIfNot;

		// Token: 0x04008D83 RID: 36227
		[Token(Token = "0x4008D83")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__InitResLangFolder;

		// Token: 0x04008D84 RID: 36228
		[Token(Token = "0x4008D84")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__InitResourceManifest;

		// Token: 0x04008D85 RID: 36229
		[Token(Token = "0x4008D85")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__InitBundleManager;

		// Token: 0x04008D86 RID: 36230
		[Token(Token = "0x4008D86")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_UnloadABAsset;

		// Token: 0x04008D87 RID: 36231
		[Token(Token = "0x4008D87")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__PreprocessAssetPath;

		// Token: 0x04008D88 RID: 36232
		[Token(Token = "0x4008D88")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__LogWhenLoadBundleFailed;

		// Token: 0x04008D89 RID: 36233
		[Token(Token = "0x4008D89")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__IsAuditMode;

		// Token: 0x04008D8A RID: 36234
		[Token(Token = "0x4008D8A")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__DeleteABFileDelayed;

		// Token: 0x0200176B RID: 5995
		[Token(Token = "0x200176B")]
		public class BundleInfo
		{
			// Token: 0x06009741 RID: 38721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009741")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BundleInfo()
			{
			}

			// Token: 0x04008D8B RID: 36235
			[Token(Token = "0x4008D8B")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04008D8C RID: 36236
			[Token(Token = "0x4008D8C")]
			[FieldOffset(Offset = "0x18")]
			public bool isCacheable;

			// Token: 0x04008D8D RID: 36237
			[Token(Token = "0x4008D8D")]
			[FieldOffset(Offset = "0x1C")]
			public int sccIndex;

			// Token: 0x04008D8E RID: 36238
			[Token(Token = "0x4008D8E")]
			[FieldOffset(Offset = "0x20")]
			public bool isRetained;
		}

		// Token: 0x0200176C RID: 5996
		[Token(Token = "0x200176C")]
		private class LoadedAssetEntry
		{
			// Token: 0x06009742 RID: 38722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009742")]
			[Address(RVA = "0x3126AD0", Offset = "0x31256D0", VA = "0x183126AD0")]
			public void Alloc(string path, UnityEngine.Object asset)
			{
			}

			// Token: 0x06009743 RID: 38723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009743")]
			[Address(RVA = "0x3126B10", Offset = "0x3125710", VA = "0x183126B10")]
			public static void Release(ABResourceManager.LoadedAssetEntry inst)
			{
			}

			// Token: 0x06009744 RID: 38724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009744")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LoadedAssetEntry()
			{
			}

			// Token: 0x04008D8F RID: 36239
			[Token(Token = "0x4008D8F")]
			[FieldOffset(Offset = "0x10")]
			public string path;

			// Token: 0x04008D90 RID: 36240
			[Token(Token = "0x4008D90")]
			[FieldOffset(Offset = "0x18")]
			public int refCnt;

			// Token: 0x04008D91 RID: 36241
			[Token(Token = "0x4008D91")]
			[FieldOffset(Offset = "0x20")]
			public UnityEngine.Object asset;
		}

		// Token: 0x0200176D RID: 5997
		[Token(Token = "0x200176D")]
		private class BundleManager : IEnumerable<KeyValuePair<string, BundleHolder>>, IEnumerable
		{
			// Token: 0x1700102C RID: 4140
			// (get) Token: 0x06009745 RID: 38725 RVA: 0x0003ACF8 File Offset: 0x00038EF8
			[Token(Token = "0x1700102C")]
			public int activeBundleCnt
			{
				[Token(Token = "0x6009745")]
				[Address(RVA = "0x3122A80", Offset = "0x3121680", VA = "0x183122A80")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700102D RID: 4141
			// (get) Token: 0x06009746 RID: 38726 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700102D")]
			public Dictionary<string, BundleHolder> activeBundles
			{
				[Token(Token = "0x6009746")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700102E RID: 4142
			// (get) Token: 0x06009747 RID: 38727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700102E")]
			private ResourceManifest resManifest
			{
				[Token(Token = "0x6009747")]
				[Address(RVA = "0x3122B40", Offset = "0x3121740", VA = "0x183122B40")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700102F RID: 4143
			// (get) Token: 0x06009748 RID: 38728 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700102F")]
			private BundleRouter router
			{
				[Token(Token = "0x6009748")]
				[Address(RVA = "0x3122BB0", Offset = "0x31217B0", VA = "0x183122BB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001030 RID: 4144
			// (get) Token: 0x06009749 RID: 38729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001030")]
			private ResourceOptions options
			{
				[Token(Token = "0x6009749")]
				[Address(RVA = "0x3122AD0", Offset = "0x31216D0", VA = "0x183122AD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001031 RID: 4145
			// (get) Token: 0x0600974A RID: 38730 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001031")]
			private RuntimeAssetMeta.Manager assetMetas
			{
				[Token(Token = "0x600974A")]
				[Address(RVA = "0xCE05E0", Offset = "0xCDF1E0", VA = "0x180CE05E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600974B RID: 38731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600974B")]
			[Address(RVA = "0x3122480", Offset = "0x3121080", VA = "0x183122480")]
			public BundleManager(ABResourceManager resManager)
			{
			}

			// Token: 0x0600974C RID: 38732 RVA: 0x0003AD10 File Offset: 0x00038F10
			[Token(Token = "0x600974C")]
			[Address(RVA = "0x3121110", Offset = "0x311FD10", VA = "0x183121110")]
			public bool TryGetInfo(string bundleName, out ABResourceManager.BundleInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600974D RID: 38733 RVA: 0x0003AD28 File Offset: 0x00038F28
			[Token(Token = "0x600974D")]
			[Address(RVA = "0x3121180", Offset = "0x311FD80", VA = "0x183121180")]
			public bool TryGetOrLoadBundle(ABResourceManager.BundleInfo info, out BundleHolder bundle)
			{
				return default(bool);
			}

			// Token: 0x0600974E RID: 38734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600974E")]
			[Address(RVA = "0x3120DA0", Offset = "0x311F9A0", VA = "0x183120DA0")]
			public BundleHolder GetOrLoadBundle(ABResourceManager.BundleInfo info)
			{
				return null;
			}

			// Token: 0x0600974F RID: 38735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600974F")]
			[Address(RVA = "0x3121760", Offset = "0x3120360", VA = "0x183121760")]
			public void UnloadAssetAndDecBundleRef(string name, UnityEngine.Object obj)
			{
			}

			// Token: 0x06009750 RID: 38736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009750")]
			[Address(RVA = "0x3120A50", Offset = "0x311F650", VA = "0x183120A50")]
			public void DecBundleRef(string bundleName, ABResourceManager.BundleInfo source)
			{
			}

			// Token: 0x06009751 RID: 38737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009751")]
			[Address(RVA = "0x3121DB0", Offset = "0x31209B0", VA = "0x183121DB0")]
			private void _DecRef(BundleHolder bundle, bool isAssetRef, bool sameSCC)
			{
			}

			// Token: 0x06009752 RID: 38738 RVA: 0x0003AD40 File Offset: 0x00038F40
			[Token(Token = "0x6009752")]
			[Address(RVA = "0x31208D0", Offset = "0x311F4D0", VA = "0x1831208D0")]
			public bool CheckBundleInvalid(BundleHolder bundle)
			{
				return default(bool);
			}

			// Token: 0x06009753 RID: 38739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009753")]
			[Address(RVA = "0x3121C70", Offset = "0x3120870", VA = "0x183121C70")]
			public void Unload(string bundleName, bool forceUnloadEvenUsed)
			{
			}

			// Token: 0x06009754 RID: 38740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009754")]
			[Address(RVA = "0x31214D0", Offset = "0x31200D0", VA = "0x1831214D0")]
			public void UnloadAll(bool forceUnloadEvenUsed, out bool hasBundleRetained)
			{
			}

			// Token: 0x06009755 RID: 38741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009755")]
			[Address(RVA = "0x31211B0", Offset = "0x311FDB0", VA = "0x1831211B0")]
			public void UnloadAllExcept(ICollection<string> excludedBundles, bool forceUnloadEvenUsed)
			{
			}

			// Token: 0x06009756 RID: 38742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009756")]
			[Address(RVA = "0x3122040", Offset = "0x3120C40", VA = "0x183122040")]
			private void _UnloadAllImpl(bool forceUnloadEvenUsed)
			{
			}

			// Token: 0x06009757 RID: 38743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009757")]
			[Address(RVA = "0x3122240", Offset = "0x3120E40", VA = "0x183122240")]
			private void _UnloadBatchImpl(bool forceUnloadEvenUsed, List<BundleHolder> bundles)
			{
			}

			// Token: 0x06009758 RID: 38744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009758")]
			[Address(RVA = "0x3121AB0", Offset = "0x31206B0", VA = "0x183121AB0")]
			public void UnloadUnusedBundles()
			{
			}

			// Token: 0x06009759 RID: 38745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009759")]
			[Address(RVA = "0x3120D10", Offset = "0x311F910", VA = "0x183120D10", Slot = "4")]
			public IEnumerator<KeyValuePair<string, BundleHolder>> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600975A RID: 38746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600975A")]
			[Address(RVA = "0x3120D10", Offset = "0x311F910", VA = "0x183120D10", Slot = "5")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04008D92 RID: 36242
			[Token(Token = "0x4008D92")]
			[FieldOffset(Offset = "0x0")]
			private static List<BundleHolder> s_tempBundleList;

			// Token: 0x04008D93 RID: 36243
			[Token(Token = "0x4008D93")]
			[FieldOffset(Offset = "0x10")]
			private ABResourceManager m_resManager;

			// Token: 0x04008D94 RID: 36244
			[Token(Token = "0x4008D94")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, ABResourceManager.BundleInfo> m_bundleNameToBundleInfoMap;

			// Token: 0x04008D95 RID: 36245
			[Token(Token = "0x4008D95")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, BundleHolder> m_activeBundlesMap;

			// Token: 0x04008D96 RID: 36246
			[Token(Token = "0x4008D96")]
			[FieldOffset(Offset = "0x28")]
			[Inspect]
			private List<BundleHolder>[] m_activeBundleSCCGroups;
		}
	}
}
