using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;

namespace Torappu.Resource.Local
{
	// Token: 0x0200175E RID: 5982
	[Token(Token = "0x200175E")]
	public class LocalResourceManager : PersistentSingleton<LocalResourceManager>, IResourceManager
	{
		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x060096A5 RID: 38565 RVA: 0x0003AAE8 File Offset: 0x00038CE8
		[Token(Token = "0x17001018")]
		[Inspect]
		[ReadOnly]
		public bool inited
		{
			[Token(Token = "0x60096A5")]
			[Address(RVA = "0x3128DA0", Offset = "0x31279A0", VA = "0x183128DA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x060096A6 RID: 38566 RVA: 0x0003AB00 File Offset: 0x00038D00
		[Token(Token = "0x17001019")]
		[Inspect]
		[ReadOnly]
		public int loadedAssetCnt
		{
			[Token(Token = "0x60096A6")]
			[Address(RVA = "0x3128E00", Offset = "0x3127A00", VA = "0x183128E00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A7")]
		[Address(RVA = "0x3128C30", Offset = "0x3127830", VA = "0x183128C30")]
		private LocalResourceManager()
		{
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A8")]
		[Address(RVA = "0x31279B0", Offset = "0x31265B0", VA = "0x1831279B0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096A9")]
		[Address(RVA = "0x3127110", Offset = "0x3125D10", VA = "0x183127110", Slot = "9")]
		public void InitIfNot()
		{
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096AA")]
		[Address(RVA = "0x3126E80", Offset = "0x3125A80", VA = "0x183126E80", Slot = "10")]
		public void ForceReInit()
		{
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096AB")]
		[Address(RVA = "0x31283D0", Offset = "0x3126FD0", VA = "0x1831283D0")]
		private void _InitImpl(bool isInit)
		{
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096AC")]
		[Address(RVA = "0x3127010", Offset = "0x3125C10", VA = "0x183127010", Slot = "11")]
		public string GetDebugStr()
		{
			return null;
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096AD")]
		public T Load<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060096AE RID: 38574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096AE")]
		[Address(RVA = "0x3127820", Offset = "0x3126420", VA = "0x183127820", Slot = "13")]
		public UnityEngine.Object Load(string path)
		{
			return null;
		}

		// Token: 0x060096AF RID: 38575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096AF")]
		public AsyncResource LoadAsync<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060096B0 RID: 38576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096B0")]
		[Address(RVA = "0x31272F0", Offset = "0x3125EF0", VA = "0x1831272F0", Slot = "17")]
		public AsyncResource LoadAsync(string path)
		{
			return null;
		}

		// Token: 0x060096B1 RID: 38577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B1")]
		public void LoadAsync<T>(string path, Action<bool, T> cb) where T : UnityEngine.Object
		{
		}

		// Token: 0x060096B2 RID: 38578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B2")]
		[Address(RVA = "0x3127520", Offset = "0x3126120", VA = "0x183127520", Slot = "19")]
		public void LoadAsync(string path, Action<bool, UnityEngine.Object> cb)
		{
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096B3")]
		public T[] LoadAll<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060096B4 RID: 38580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096B4")]
		[Address(RVA = "0x3127170", Offset = "0x3125D70", VA = "0x183127170", Slot = "15")]
		public UnityEngine.Object[] LoadAll(string path)
		{
			return null;
		}

		// Token: 0x060096B5 RID: 38581 RVA: 0x0003AB18 File Offset: 0x00038D18
		[Token(Token = "0x60096B5")]
		public bool TryLoad<T>(string path, out T obj) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x060096B6 RID: 38582 RVA: 0x0003AB30 File Offset: 0x00038D30
		[Token(Token = "0x60096B6")]
		[Address(RVA = "0x3127AF0", Offset = "0x31266F0", VA = "0x183127AF0", Slot = "21")]
		public bool TryLoad(string path, out UnityEngine.Object obj)
		{
			return default(bool);
		}

		// Token: 0x060096B7 RID: 38583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B7")]
		[Address(RVA = "0x3128050", Offset = "0x3126C50", VA = "0x183128050", Slot = "22")]
		public void UnloadAsset(UnityEngine.Object obj)
		{
		}

		// Token: 0x060096B8 RID: 38584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B8")]
		[Address(RVA = "0x3127DC0", Offset = "0x31269C0", VA = "0x183127DC0", Slot = "23")]
		public void UnloadAssetByInstanceId(int instanceId)
		{
		}

		// Token: 0x060096B9 RID: 38585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096B9")]
		[Address(RVA = "0x3128B30", Offset = "0x3127730", VA = "0x183128B30")]
		private void _ReleaseAsset(UnityEngine.Object obj)
		{
		}

		// Token: 0x060096BA RID: 38586 RVA: 0x0003AB48 File Offset: 0x00038D48
		[Token(Token = "0x60096BA")]
		[Address(RVA = "0x3126DD0", Offset = "0x31259D0", VA = "0x183126DD0", Slot = "24")]
		public bool CheckExists(string path)
		{
			return default(bool);
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096BB")]
		[Address(RVA = "0x3127680", Offset = "0x3126280", VA = "0x183127680", Slot = "25")]
		public AsyncOperation LoadSceneAsync(string path, LoadSceneMode mode)
		{
			return null;
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x0003AB60 File Offset: 0x00038D60
		[Token(Token = "0x60096BC")]
		[Address(RVA = "0x3127750", Offset = "0x3126350", VA = "0x183127750", Slot = "26")]
		public bool LoadScene(string path, LoadSceneMode mode)
		{
			return default(bool);
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096BD")]
		[Address(RVA = "0x3128110", Offset = "0x3126D10", VA = "0x183128110", Slot = "27")]
		public void UnloadScene(string path, bool forceUnloadEvenUsed)
		{
		}

		// Token: 0x060096BE RID: 38590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096BE")]
		[Address(RVA = "0x3128190", Offset = "0x3126D90", VA = "0x183128190", Slot = "28")]
		public AsyncOperation UnloadUnusedAssets()
		{
			return null;
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096BF")]
		[Address(RVA = "0x3127CF0", Offset = "0x31268F0", VA = "0x183127CF0", Slot = "29")]
		public IEnumerator UnloadAllAssets(bool forceUnloadEvenUsed)
		{
			return null;
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096C0")]
		[Address(RVA = "0x3127C00", Offset = "0x3126800", VA = "0x183127C00", Slot = "30")]
		public IEnumerator UnloadAllAssetsExcept(string[] excludedPrefixes, bool forceUnloadEvenUsed)
		{
			return null;
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C1")]
		[Address(RVA = "0x3127A50", Offset = "0x3126650", VA = "0x183127A50", Slot = "31")]
		public void RegisterListener(IResourceListener listener)
		{
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C2")]
		[Address(RVA = "0x31281F0", Offset = "0x3126DF0", VA = "0x1831281F0", Slot = "32")]
		public void UnregisterListener(IResourceListener listener)
		{
		}

		// Token: 0x060096C3 RID: 38595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C3")]
		[Address(RVA = "0x31278F0", Offset = "0x31264F0", VA = "0x1831278F0", Slot = "33")]
		public void MarkAssetInvalid(string path)
		{
		}

		// Token: 0x060096C4 RID: 38596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096C4")]
		[Address(RVA = "0x3126EE0", Offset = "0x3125AE0", VA = "0x183126EE0", Slot = "34")]
		public string GenerateAssetFullPath(string path, out bool isStreaming)
		{
			return null;
		}

		// Token: 0x060096C5 RID: 38597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C5")]
		[Address(RVA = "0x3128660", Offset = "0x3127260", VA = "0x183128660")]
		private void _InitResLangFolder()
		{
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C6")]
		[Address(RVA = "0x3128870", Offset = "0x3127470", VA = "0x183128870")]
		private void _OnAssetLoaded(UnityEngine.Object asset, string path)
		{
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096C7")]
		[Address(RVA = "0x3128290", Offset = "0x3126E90", VA = "0x183128290")]
		private void _HandleAsyncResource(AsyncResource asyncRes, string path)
		{
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096C8")]
		[Address(RVA = "0x3128770", Offset = "0x3127370", VA = "0x183128770")]
		private IEnumerator _LoadAsync(string path, Action<bool, UnityEngine.Object> cb)
		{
			return null;
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096C9")]
		private IEnumerator _LoadAsync<T>(string path, Action<bool, T> cb) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60096CA")]
		[Address(RVA = "0x31289D0", Offset = "0x31275D0", VA = "0x1831289D0")]
		private string _PreprocessAssetPath(string path)
		{
			return null;
		}

		// Token: 0x04008CFD RID: 36093
		[Token(Token = "0x4008CFD")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, string> m_loadedAssets;

		// Token: 0x04008CFE RID: 36094
		[Token(Token = "0x4008CFE")]
		[FieldOffset(Offset = "0x20")]
		private LocalResourceManager.LoadAssetPool m_loadedAssetsRef;

		// Token: 0x04008CFF RID: 36095
		[Token(Token = "0x4008CFF")]
		[FieldOffset(Offset = "0x28")]
		private ListSet<IResourceListener> m_listeners;

		// Token: 0x04008D00 RID: 36096
		[Token(Token = "0x4008D00")]
		[FieldOffset(Offset = "0x30")]
		private string m_resLangFolder;

		// Token: 0x04008D01 RID: 36097
		[Token(Token = "0x4008D01")]
		[FieldOffset(Offset = "0x38")]
		private string m_commonLangFolder;

		// Token: 0x04008D02 RID: 36098
		[Token(Token = "0x4008D02")]
		[FieldOffset(Offset = "0x40")]
		private ILocalResourceEvents m_resEvents;

		// Token: 0x04008D03 RID: 36099
		[Token(Token = "0x4008D03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x04008D04 RID: 36100
		[Token(Token = "0x4008D04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_loadedAssetCnt;

		// Token: 0x04008D05 RID: 36101
		[Token(Token = "0x4008D05")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008D06 RID: 36102
		[Token(Token = "0x4008D06")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04008D07 RID: 36103
		[Token(Token = "0x4008D07")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x04008D08 RID: 36104
		[Token(Token = "0x4008D08")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceReInit;

		// Token: 0x04008D09 RID: 36105
		[Token(Token = "0x4008D09")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitImpl;

		// Token: 0x04008D0A RID: 36106
		[Token(Token = "0x4008D0A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDebugStr;

		// Token: 0x04008D0B RID: 36107
		[Token(Token = "0x4008D0B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04008D0C RID: 36108
		[Token(Token = "0x4008D0C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_Load;

		// Token: 0x04008D0D RID: 36109
		[Token(Token = "0x4008D0D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadAsync;

		// Token: 0x04008D0E RID: 36110
		[Token(Token = "0x4008D0E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_LoadAsync;

		// Token: 0x04008D0F RID: 36111
		[Token(Token = "0x4008D0F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix2_LoadAsync;

		// Token: 0x04008D10 RID: 36112
		[Token(Token = "0x4008D10")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix3_LoadAsync;

		// Token: 0x04008D11 RID: 36113
		[Token(Token = "0x4008D11")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadAll;

		// Token: 0x04008D12 RID: 36114
		[Token(Token = "0x4008D12")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_LoadAll;

		// Token: 0x04008D13 RID: 36115
		[Token(Token = "0x4008D13")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TryLoad;

		// Token: 0x04008D14 RID: 36116
		[Token(Token = "0x4008D14")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_TryLoad;

		// Token: 0x04008D15 RID: 36117
		[Token(Token = "0x4008D15")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x04008D16 RID: 36118
		[Token(Token = "0x4008D16")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UnloadAssetByInstanceId;

		// Token: 0x04008D17 RID: 36119
		[Token(Token = "0x4008D17")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ReleaseAsset;

		// Token: 0x04008D18 RID: 36120
		[Token(Token = "0x4008D18")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CheckExists;

		// Token: 0x04008D19 RID: 36121
		[Token(Token = "0x4008D19")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadSceneAsync;

		// Token: 0x04008D1A RID: 36122
		[Token(Token = "0x4008D1A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_LoadScene;

		// Token: 0x04008D1B RID: 36123
		[Token(Token = "0x4008D1B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_UnloadScene;

		// Token: 0x04008D1C RID: 36124
		[Token(Token = "0x4008D1C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_UnloadUnusedAssets;

		// Token: 0x04008D1D RID: 36125
		[Token(Token = "0x4008D1D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_UnloadAllAssets;

		// Token: 0x04008D1E RID: 36126
		[Token(Token = "0x4008D1E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_UnloadAllAssetsExcept;

		// Token: 0x04008D1F RID: 36127
		[Token(Token = "0x4008D1F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RegisterListener;

		// Token: 0x04008D20 RID: 36128
		[Token(Token = "0x4008D20")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_UnregisterListener;

		// Token: 0x04008D21 RID: 36129
		[Token(Token = "0x4008D21")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_MarkAssetInvalid;

		// Token: 0x04008D22 RID: 36130
		[Token(Token = "0x4008D22")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GenerateAssetFullPath;

		// Token: 0x04008D23 RID: 36131
		[Token(Token = "0x4008D23")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__InitResLangFolder;

		// Token: 0x04008D24 RID: 36132
		[Token(Token = "0x4008D24")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnAssetLoaded;

		// Token: 0x04008D25 RID: 36133
		[Token(Token = "0x4008D25")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__HandleAsyncResource;

		// Token: 0x04008D26 RID: 36134
		[Token(Token = "0x4008D26")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__LoadAsync;

		// Token: 0x04008D27 RID: 36135
		[Token(Token = "0x4008D27")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix1__LoadAsync;

		// Token: 0x04008D28 RID: 36136
		[Token(Token = "0x4008D28")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__PreprocessAssetPath;

		// Token: 0x0200175F RID: 5983
		[Token(Token = "0x200175F")]
		private class LoadedAssetEntry : RefCountedPoolItem<WeakReference<UnityEngine.Object>>
		{
			// Token: 0x060096CB RID: 38603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096CB")]
			[Address(RVA = "0x3126B60", Offset = "0x3125760", VA = "0x183126B60")]
			public LoadedAssetEntry()
			{
			}
		}

		// Token: 0x02001760 RID: 5984
		[Token(Token = "0x2001760")]
		private class LoadAssetPool : RefCountedPool<LocalResourceManager.LoadedAssetEntry, WeakReference<UnityEngine.Object>>
		{
			// Token: 0x060096CC RID: 38604 RVA: 0x0003AB78 File Offset: 0x00038D78
			[Token(Token = "0x60096CC")]
			[Address(RVA = "0x31269A0", Offset = "0x31255A0", VA = "0x1831269A0", Slot = "4")]
			protected override bool LoadObjectToItem(LocalResourceManager.LoadedAssetEntry item)
			{
				return default(bool);
			}

			// Token: 0x060096CD RID: 38605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096CD")]
			[Address(RVA = "0x3126A30", Offset = "0x3125630", VA = "0x183126A30", Slot = "5")]
			protected override void ReleaseObject(LocalResourceManager.LoadedAssetEntry item)
			{
			}

			// Token: 0x060096CE RID: 38606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096CE")]
			[Address(RVA = "0x3126A90", Offset = "0x3125690", VA = "0x183126A90")]
			public LoadAssetPool()
			{
			}
		}

		// Token: 0x02001761 RID: 5985
		[Token(Token = "0x2001761")]
		private static class ResourcesWrapper
		{
			// Token: 0x060096CF RID: 38607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096CF")]
			public static T Load<T>(string path, bool showErrorMsg, ILocalResourceEvents resEvents) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x060096D0 RID: 38608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096D0")]
			[Address(RVA = "0x312C860", Offset = "0x312B460", VA = "0x18312C860")]
			public static UnityEngine.Object Load(string path, bool showErrorMsg, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096D1 RID: 38609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096D1")]
			public static AsyncResource LoadAsync<T>(string path, ILocalResourceEvents resEvents) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x060096D2 RID: 38610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096D2")]
			[Address(RVA = "0x312C7B0", Offset = "0x312B3B0", VA = "0x18312C7B0")]
			public static AsyncResource LoadAsync(string path, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096D3 RID: 38611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096D3")]
			public static T[] LoadAll<T>(string path, ILocalResourceEvents resEvents) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x060096D4 RID: 38612 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096D4")]
			[Address(RVA = "0x312C700", Offset = "0x312B300", VA = "0x18312C700")]
			public static UnityEngine.Object[] LoadAll(string path, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096D5 RID: 38613 RVA: 0x0003AB90 File Offset: 0x00038D90
			[Token(Token = "0x60096D5")]
			[Address(RVA = "0x312C5C0", Offset = "0x312B1C0", VA = "0x18312C5C0")]
			public static bool CheckExists(string path)
			{
				return default(bool);
			}

			// Token: 0x060096D6 RID: 38614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096D6")]
			[Address(RVA = "0x312C660", Offset = "0x312B260", VA = "0x18312C660")]
			public static string GenerateFullPath(string path)
			{
				return null;
			}

			// Token: 0x04008D29 RID: 36137
			[Token(Token = "0x4008D29")]
			[FieldOffset(Offset = "0x0")]
			private static LocalResourceManager.ResourceWrapperImpl s_impl;
		}

		// Token: 0x02001762 RID: 5986
		[Token(Token = "0x2001762")]
		private abstract class ResourceWrapperImpl
		{
			// Token: 0x060096D8 RID: 38616
			[Token(Token = "0x60096D8")]
			public abstract T Load<T>(string path, bool showErrorMsg, ILocalResourceEvents resEvents) where T : UnityEngine.Object;

			// Token: 0x060096D9 RID: 38617
			[Token(Token = "0x60096D9")]
			public abstract UnityEngine.Object Load(string path, bool showErrorMsg, ILocalResourceEvents resEvents);

			// Token: 0x060096DA RID: 38618
			[Token(Token = "0x60096DA")]
			public abstract AsyncResource LoadAsync<T>(string path, ILocalResourceEvents resEvents) where T : UnityEngine.Object;

			// Token: 0x060096DB RID: 38619
			[Token(Token = "0x60096DB")]
			public abstract AsyncResource LoadAsync(string path, ILocalResourceEvents resEvents);

			// Token: 0x060096DC RID: 38620
			[Token(Token = "0x60096DC")]
			public abstract T[] LoadAll<T>(string path, ILocalResourceEvents resEvents) where T : UnityEngine.Object;

			// Token: 0x060096DD RID: 38621
			[Token(Token = "0x60096DD")]
			public abstract UnityEngine.Object[] LoadAll(string path, ILocalResourceEvents resEvents);

			// Token: 0x060096DE RID: 38622
			[Token(Token = "0x60096DE")]
			public abstract bool CheckExists(string path);

			// Token: 0x060096DF RID: 38623
			[Token(Token = "0x60096DF")]
			public abstract string GenerateFullPath(string path);

			// Token: 0x060096E0 RID: 38624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected ResourceWrapperImpl()
			{
			}
		}

		// Token: 0x02001763 RID: 5987
		[Token(Token = "0x2001763")]
		private class RuntimeResourceWrapper : LocalResourceManager.ResourceWrapperImpl
		{
			// Token: 0x060096E1 RID: 38625 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096E1")]
			public override T Load<T>(string path, bool showErrorMsg, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096E2 RID: 38626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096E2")]
			[Address(RVA = "0x312CA80", Offset = "0x312B680", VA = "0x18312CA80", Slot = "5")]
			public override UnityEngine.Object Load(string path, bool showErrorMsg, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096E3 RID: 38627 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096E3")]
			public override AsyncResource LoadAsync<T>(string path, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096E4 RID: 38628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096E4")]
			[Address(RVA = "0x312CA10", Offset = "0x312B610", VA = "0x18312CA10", Slot = "7")]
			public override AsyncResource LoadAsync(string path, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096E5 RID: 38629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096E5")]
			public override T[] LoadAll<T>(string path, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096E6 RID: 38630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096E6")]
			[Address(RVA = "0x312CA00", Offset = "0x312B600", VA = "0x18312CA00", Slot = "9")]
			public override UnityEngine.Object[] LoadAll(string path, ILocalResourceEvents resEvents)
			{
				return null;
			}

			// Token: 0x060096E7 RID: 38631 RVA: 0x0003ABA8 File Offset: 0x00038DA8
			[Token(Token = "0x60096E7")]
			[Address(RVA = "0x312C9A0", Offset = "0x312B5A0", VA = "0x18312C9A0", Slot = "10")]
			public override bool CheckExists(string path)
			{
				return default(bool);
			}

			// Token: 0x060096E8 RID: 38632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60096E8")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "11")]
			public override string GenerateFullPath(string path)
			{
				return null;
			}

			// Token: 0x060096E9 RID: 38633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096E9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuntimeResourceWrapper()
			{
			}
		}
	}
}
