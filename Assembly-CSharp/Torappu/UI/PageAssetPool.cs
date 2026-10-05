using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037BD RID: 14269
	[Token(Token = "0x20037BD")]
	public class PageAssetPool<AssetType> : PageSingleComponent where AssetType : UnityEngine.Object
	{
		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x060169F1 RID: 92657 RVA: 0x00092028 File Offset: 0x00090228
		[Token(Token = "0x1700361F")]
		protected virtual bool enablePoolSizeLimit
		{
			[Token(Token = "0x60169F1")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x060169F2 RID: 92658 RVA: 0x00092040 File Offset: 0x00090240
		[Token(Token = "0x17003620")]
		protected int poolMaxSize
		{
			[Token(Token = "0x60169F2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x060169F3 RID: 92659 RVA: 0x00092058 File Offset: 0x00090258
		[Token(Token = "0x17003621")]
		protected int poolCapacity
		{
			[Token(Token = "0x60169F3")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060169F4 RID: 92660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169F4")]
		protected override void OnRecycle()
		{
		}

		// Token: 0x060169F5 RID: 92661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169F5")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060169F6 RID: 92662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169F6")]
		protected AssetType LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x060169F7 RID: 92663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169F7")]
		protected void RecordInstPrefab(GameObject obj, string path)
		{
		}

		// Token: 0x060169F8 RID: 92664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169F8")]
		protected void MarkAssetReused(string path)
		{
		}

		// Token: 0x060169F9 RID: 92665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169F9")]
		private void _AdjustStorage()
		{
		}

		// Token: 0x060169FA RID: 92666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169FA")]
		private void _ClearAll()
		{
		}

		// Token: 0x060169FB RID: 92667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169FB")]
		private AssetType _LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x060169FC RID: 92668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169FC")]
		private void _UnloadAsset(AssetType target)
		{
		}

		// Token: 0x060169FD RID: 92669 RVA: 0x00092070 File Offset: 0x00090270
		[Token(Token = "0x60169FD")]
		public int PageOnlyAssetGroupId()
		{
			return 0;
		}

		// Token: 0x060169FE RID: 92670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169FE")]
		public PageAssetPool()
		{
		}

		// Token: 0x0401B44F RID: 111695
		[Token(Token = "0x401B44F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int _poolMaxSize;

		// Token: 0x0401B450 RID: 111696
		[Token(Token = "0x401B450")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<PageAssetPool<AssetType>.AssetRes> m_assetCache;

		// Token: 0x0401B451 RID: 111697
		[Token(Token = "0x401B451")]
		[FieldOffset(Offset = "0x0")]
		private UIPageAssetGroup m_assetGroup;

		// Token: 0x0401B452 RID: 111698
		[Token(Token = "0x401B452")]
		[FieldOffset(Offset = "0x0")]
		private List<PageAssetPool<AssetType>.InstRes> m_instRes;

		// Token: 0x0401B453 RID: 111699
		[Token(Token = "0x401B453")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enablePoolSizeLimit;

		// Token: 0x0401B454 RID: 111700
		[Token(Token = "0x401B454")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_poolMaxSize;

		// Token: 0x0401B455 RID: 111701
		[Token(Token = "0x401B455")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_poolCapacity;

		// Token: 0x0401B456 RID: 111702
		[Token(Token = "0x401B456")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0401B457 RID: 111703
		[Token(Token = "0x401B457")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B458 RID: 111704
		[Token(Token = "0x401B458")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0401B459 RID: 111705
		[Token(Token = "0x401B459")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RecordInstPrefab;

		// Token: 0x0401B45A RID: 111706
		[Token(Token = "0x401B45A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_MarkAssetReused;

		// Token: 0x0401B45B RID: 111707
		[Token(Token = "0x401B45B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__AdjustStorage;

		// Token: 0x0401B45C RID: 111708
		[Token(Token = "0x401B45C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ClearAll;

		// Token: 0x0401B45D RID: 111709
		[Token(Token = "0x401B45D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadAsset;

		// Token: 0x0401B45E RID: 111710
		[Token(Token = "0x401B45E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UnloadAsset;

		// Token: 0x0401B45F RID: 111711
		[Token(Token = "0x401B45F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PageOnlyAssetGroupId;

		// Token: 0x0401B460 RID: 111712
		[Token(Token = "0x401B460")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020037BE RID: 14270
		[Token(Token = "0x20037BE")]
		private struct AssetRes
		{
			// Token: 0x0401B461 RID: 111713
			[Token(Token = "0x401B461")]
			[FieldOffset(Offset = "0x0")]
			public WeakReference res;

			// Token: 0x0401B462 RID: 111714
			[Token(Token = "0x401B462")]
			[FieldOffset(Offset = "0x0")]
			public string path;
		}

		// Token: 0x020037BF RID: 14271
		[Token(Token = "0x20037BF")]
		private struct InstRes
		{
			// Token: 0x0401B463 RID: 111715
			[Token(Token = "0x401B463")]
			[FieldOffset(Offset = "0x0")]
			public GameObject relatedObj;

			// Token: 0x0401B464 RID: 111716
			[Token(Token = "0x401B464")]
			[FieldOffset(Offset = "0x0")]
			public string path;
		}
	}
}
