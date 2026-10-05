using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Shop;
using Torappu.UI.VoucherSkin;
using UnityEngine;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EC8 RID: 16072
	[Token(Token = "0x2003EC8")]
	public class SkinPage : StateEnginePage
	{
		// Token: 0x06018F00 RID: 102144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018F00")]
		[Address(RVA = "0x119A440", Offset = "0x1199040", VA = "0x18119A440", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06018F01 RID: 102145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F01")]
		[Address(RVA = "0x119AEE0", Offset = "0x1199AE0", VA = "0x18119AEE0")]
		public static void OpenPageForTargetSkin(string skinId, SkinPage.PageReferrer referrer)
		{
		}

		// Token: 0x06018F02 RID: 102146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F02")]
		[Address(RVA = "0x119AD20", Offset = "0x1199920", VA = "0x18119AD20")]
		public static void OpenPageForTargetSkinList(string focusId, List<string> skinIdList)
		{
		}

		// Token: 0x06018F03 RID: 102147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F03")]
		[Address(RVA = "0x119A790", Offset = "0x1199390", VA = "0x18119A790")]
		public static void OpenPageForCharList(string charId, SkinPage.PageReferrer referrer)
		{
		}

		// Token: 0x06018F04 RID: 102148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F04")]
		[Address(RVA = "0x119B300", Offset = "0x1199F00", VA = "0x18119B300")]
		private static void _OpenPageForTargetSkinWithData(string charId, List<ShopSkinItemViewModel> goodList, SkinPage.PageReferrer referrer)
		{
		}

		// Token: 0x06018F05 RID: 102149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F05")]
		[Address(RVA = "0x119AA80", Offset = "0x1199680", VA = "0x18119AA80")]
		public static void OpenPageForSkinList(string focusSkinId, List<SkinShopViewModel> skinList, SkinPage.PageReferrer referrer)
		{
		}

		// Token: 0x06018F06 RID: 102150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F06")]
		[Address(RVA = "0x119B0F0", Offset = "0x1199CF0", VA = "0x18119B0F0")]
		public static void OpenPageForVoucherSkinList(string focusSkinId, List<VoucherSkinItemViewModel> skinList, string voucherId, int voucherInstId, SkinPage.PageReferrer referrer)
		{
		}

		// Token: 0x06018F07 RID: 102151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F07")]
		[Address(RVA = "0x119A890", Offset = "0x1199490", VA = "0x18119A890")]
		public static void OpenPageForMultiSkinList(string focusSkinId, List<ShopSkinItemViewModel> shopSkinList, List<string> skinIdList, SkinPage.PageReferrer referrer)
		{
		}

		// Token: 0x06018F08 RID: 102152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F08")]
		[Address(RVA = "0x119A500", Offset = "0x1199100", VA = "0x18119A500", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06018F09 RID: 102153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F09")]
		[Address(RVA = "0x119B5F0", Offset = "0x119A1F0", VA = "0x18119B5F0")]
		public SkinPage()
		{
		}

		// Token: 0x06018F0B RID: 102155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018F0B")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x06018F0C RID: 102156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F0C")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401EC6C RID: 126060
		[Token(Token = "0x401EC6C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0401EC6D RID: 126061
		[Token(Token = "0x401EC6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0401EC6E RID: 126062
		[Token(Token = "0x401EC6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenPageForTargetSkin;

		// Token: 0x0401EC6F RID: 126063
		[Token(Token = "0x401EC6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenPageForTargetSkinList;

		// Token: 0x0401EC70 RID: 126064
		[Token(Token = "0x401EC70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenPageForCharList;

		// Token: 0x0401EC71 RID: 126065
		[Token(Token = "0x401EC71")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OpenPageForTargetSkinWithData;

		// Token: 0x0401EC72 RID: 126066
		[Token(Token = "0x401EC72")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OpenPageForSkinList;

		// Token: 0x0401EC73 RID: 126067
		[Token(Token = "0x401EC73")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OpenPageForVoucherSkinList;

		// Token: 0x0401EC74 RID: 126068
		[Token(Token = "0x401EC74")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OpenPageForMultiSkinList;

		// Token: 0x0401EC75 RID: 126069
		[Token(Token = "0x401EC75")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401EC76 RID: 126070
		[Token(Token = "0x401EC76")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EC9 RID: 16073
		[Token(Token = "0x2003EC9")]
		public class Params : IHotfixable
		{
			// Token: 0x17003B7F RID: 15231
			// (get) Token: 0x06018F0D RID: 102157 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06018F0E RID: 102158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003B7F")]
			public List<SkinSelectViewModel> viewModelList
			{
				[Token(Token = "0x6018F0D")]
				[Address(RVA = "0x11972E0", Offset = "0x1195EE0", VA = "0x1811972E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6018F0E")]
				[Address(RVA = "0x1197340", Offset = "0x1195F40", VA = "0x181197340")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06018F0F RID: 102159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F0F")]
			[Address(RVA = "0x1196650", Offset = "0x1195250", VA = "0x181196650")]
			public void InitData(SkinPage.Params.InitOptions options)
			{
			}

			// Token: 0x06018F10 RID: 102160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F10")]
			[Address(RVA = "0x1197280", Offset = "0x1195E80", VA = "0x181197280")]
			public Params()
			{
			}

			// Token: 0x0401EC77 RID: 126071
			[Token(Token = "0x401EC77")]
			[FieldOffset(Offset = "0x10")]
			public SkinPage.PageReferrer pageReferrer;

			// Token: 0x0401EC78 RID: 126072
			[Token(Token = "0x401EC78")]
			[FieldOffset(Offset = "0x14")]
			public bool showTitleBarFlag;

			// Token: 0x0401EC7A RID: 126074
			[Token(Token = "0x401EC7A")]
			[FieldOffset(Offset = "0x20")]
			public string focusSkinId;

			// Token: 0x0401EC7B RID: 126075
			[Token(Token = "0x401EC7B")]
			[FieldOffset(Offset = "0x28")]
			public string voucherId;

			// Token: 0x0401EC7C RID: 126076
			[Token(Token = "0x401EC7C")]
			[FieldOffset(Offset = "0x30")]
			public int voucherInstId;

			// Token: 0x0401EC7D RID: 126077
			[Token(Token = "0x401EC7D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_viewModelList;

			// Token: 0x0401EC7E RID: 126078
			[Token(Token = "0x401EC7E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_viewModelList;

			// Token: 0x0401EC7F RID: 126079
			[Token(Token = "0x401EC7F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_InitData;

			// Token: 0x0401EC80 RID: 126080
			[Token(Token = "0x401EC80")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02003ECA RID: 16074
			[Token(Token = "0x2003ECA")]
			public struct InitOptions
			{
				// Token: 0x0401EC81 RID: 126081
				[Token(Token = "0x401EC81")]
				[FieldOffset(Offset = "0x0")]
				public string charId;

				// Token: 0x0401EC82 RID: 126082
				[Token(Token = "0x401EC82")]
				[FieldOffset(Offset = "0x8")]
				public List<ShopSkinItemViewModel> skinList;

				// Token: 0x0401EC83 RID: 126083
				[Token(Token = "0x401EC83")]
				[FieldOffset(Offset = "0x10")]
				public List<string> onShowSkin;

				// Token: 0x0401EC84 RID: 126084
				[Token(Token = "0x401EC84")]
				[FieldOffset(Offset = "0x18")]
				public bool titleBarFlag;

				// Token: 0x0401EC85 RID: 126085
				[Token(Token = "0x401EC85")]
				[FieldOffset(Offset = "0x20")]
				public Comparison<SkinSelectViewModel> sortFunc;

				// Token: 0x0401EC86 RID: 126086
				[Token(Token = "0x401EC86")]
				[FieldOffset(Offset = "0x28")]
				public List<VoucherSkinItemViewModel> voucherSkinList;

				// Token: 0x0401EC87 RID: 126087
				[Token(Token = "0x401EC87")]
				[FieldOffset(Offset = "0x30")]
				public bool useVoucher;

				// Token: 0x0401EC88 RID: 126088
				[Token(Token = "0x401EC88")]
				[FieldOffset(Offset = "0x34")]
				public SkinPage.PageReferrer pageReferrer;
			}
		}

		// Token: 0x02003ECB RID: 16075
		[Token(Token = "0x2003ECB")]
		public enum PageReferrer
		{
			// Token: 0x0401EC8A RID: 126090
			[Token(Token = "0x401EC8A")]
			NONE,
			// Token: 0x0401EC8B RID: 126091
			[Token(Token = "0x401EC8B")]
			SHOP_SKIN,
			// Token: 0x0401EC8C RID: 126092
			[Token(Token = "0x401EC8C")]
			SHOP_GP,
			// Token: 0x0401EC8D RID: 126093
			[Token(Token = "0x401EC8D")]
			ACTIVITY_MILESTONE,
			// Token: 0x0401EC8E RID: 126094
			[Token(Token = "0x401EC8E")]
			VOUCHER,
			// Token: 0x0401EC8F RID: 126095
			[Token(Token = "0x401EC8F")]
			CHARACTER_INFO,
			// Token: 0x0401EC90 RID: 126096
			[Token(Token = "0x401EC90")]
			ROGUELIKE_BATTLE_PASS,
			// Token: 0x0401EC91 RID: 126097
			[Token(Token = "0x401EC91")]
			TEMPLATE_SHOP,
			// Token: 0x0401EC92 RID: 126098
			[Token(Token = "0x401EC92")]
			CRISIS_MAP,
			// Token: 0x0401EC93 RID: 126099
			[Token(Token = "0x401EC93")]
			WARDROBE,
			// Token: 0x0401EC94 RID: 126100
			[Token(Token = "0x401EC94")]
			ART_GALLERY
		}
	}
}
