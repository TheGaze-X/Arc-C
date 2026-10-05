using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D49 RID: 15689
	[Token(Token = "0x2003D49")]
	public class TemplateShopPage : StateEnginePage
	{
		// Token: 0x06018707 RID: 100103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018707")]
		[Address(RVA = "0x10F7080", Offset = "0x10F5C80", VA = "0x1810F7080", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06018708 RID: 100104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018708")]
		[Address(RVA = "0x10F6400", Offset = "0x10F5000", VA = "0x1810F6400")]
		public string GetShopId()
		{
			return null;
		}

		// Token: 0x06018709 RID: 100105 RVA: 0x0009A638 File Offset: 0x00098838
		[Token(Token = "0x6018709")]
		[Address(RVA = "0x10F64F0", Offset = "0x10F50F0", VA = "0x1810F64F0")]
		public TemplateShopSource GetShopSourceType()
		{
			return TemplateShopSource.ACT;
		}

		// Token: 0x0601870A RID: 100106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601870A")]
		[Address(RVA = "0x10F61E0", Offset = "0x10F4DE0", VA = "0x1810F61E0")]
		public string GetReplicateActId()
		{
			return null;
		}

		// Token: 0x0601870B RID: 100107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601870B")]
		[Address(RVA = "0x10F62D0", Offset = "0x10F4ED0", VA = "0x1810F62D0")]
		public static string GetShopIdStatic()
		{
			return null;
		}

		// Token: 0x0601870C RID: 100108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601870C")]
		[Address(RVA = "0x10F5FC0", Offset = "0x10F4BC0", VA = "0x1810F5FC0")]
		public static string GetReplicateActIdStatic()
		{
			return null;
		}

		// Token: 0x0601870D RID: 100109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601870D")]
		[Address(RVA = "0x10F7330", Offset = "0x10F5F30", VA = "0x1810F7330")]
		private static IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onFinish)
		{
			return null;
		}

		// Token: 0x0601870E RID: 100110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601870E")]
		[Address(RVA = "0x10F65C0", Offset = "0x10F51C0", VA = "0x1810F65C0")]
		public static void HandlerBuyRequest(int count, TemplateCommonShopGoodViewModel viewModel, Action onFinish)
		{
		}

		// Token: 0x0601870F RID: 100111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601870F")]
		[Address(RVA = "0x10F6A40", Offset = "0x10F5640", VA = "0x1810F6A40")]
		public static void JumpToDetailState(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x06018710 RID: 100112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018710")]
		[Address(RVA = "0x10F6C40", Offset = "0x10F5840", VA = "0x1810F6C40")]
		public static TemplateShopResHolder LoadTemplateShopResHolder()
		{
			return null;
		}

		// Token: 0x06018711 RID: 100113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018711")]
		[Address(RVA = "0x10F6DD0", Offset = "0x10F59D0", VA = "0x1810F6DD0")]
		public static GameObject LoadTemplateShopTitle()
		{
			return null;
		}

		// Token: 0x06018712 RID: 100114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018712")]
		[Address(RVA = "0x10F7400", Offset = "0x10F6000", VA = "0x1810F7400")]
		public TemplateShopPage()
		{
		}

		// Token: 0x06018713 RID: 100115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018713")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0401DE61 RID: 122465
		[Token(Token = "0x401DE61")]
		[FieldOffset(Offset = "0x0")]
		public static TemplateCommonShopGoodViewModel detailViewModelCache;

		// Token: 0x0401DE62 RID: 122466
		[Token(Token = "0x401DE62")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private List<TemplateShopResourceBar> _resBarList;

		// Token: 0x0401DE63 RID: 122467
		[Token(Token = "0x401DE63")]
		[FieldOffset(Offset = "0xF8")]
		private TemplateShopResHolder m_cacheResHolder;

		// Token: 0x0401DE64 RID: 122468
		[Token(Token = "0x401DE64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0401DE65 RID: 122469
		[Token(Token = "0x401DE65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShopId;

		// Token: 0x0401DE66 RID: 122470
		[Token(Token = "0x401DE66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetShopSourceType;

		// Token: 0x0401DE67 RID: 122471
		[Token(Token = "0x401DE67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetReplicateActId;

		// Token: 0x0401DE68 RID: 122472
		[Token(Token = "0x401DE68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetShopIdStatic;

		// Token: 0x0401DE69 RID: 122473
		[Token(Token = "0x401DE69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetReplicateActIdStatic;

		// Token: 0x0401DE6A RID: 122474
		[Token(Token = "0x401DE6A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0401DE6B RID: 122475
		[Token(Token = "0x401DE6B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HandlerBuyRequest;

		// Token: 0x0401DE6C RID: 122476
		[Token(Token = "0x401DE6C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_JumpToDetailState;

		// Token: 0x0401DE6D RID: 122477
		[Token(Token = "0x401DE6D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadTemplateShopResHolder;

		// Token: 0x0401DE6E RID: 122478
		[Token(Token = "0x401DE6E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadTemplateShopTitle;

		// Token: 0x0401DE6F RID: 122479
		[Token(Token = "0x401DE6F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D4A RID: 15690
		[Token(Token = "0x2003D4A")]
		public class Params
		{
			// Token: 0x06018714 RID: 100116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018714")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0401DE70 RID: 122480
			[Token(Token = "0x401DE70")]
			[FieldOffset(Offset = "0x10")]
			public string templateShopId;

			// Token: 0x0401DE71 RID: 122481
			[Token(Token = "0x401DE71")]
			[FieldOffset(Offset = "0x18")]
			public TemplateShopSource source;

			// Token: 0x0401DE72 RID: 122482
			[Token(Token = "0x401DE72")]
			[FieldOffset(Offset = "0x20")]
			public string replicateActId;
		}
	}
}
