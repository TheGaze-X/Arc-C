using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A71 RID: 23153
	[Token(Token = "0x2005A71")]
	public class SkinShopBlindboxSkinListViewModel : IHotfixable
	{
		// Token: 0x17004F07 RID: 20231
		// (get) Token: 0x06021AFD RID: 137981 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021AFE RID: 137982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F07")]
		public SkinShopBlindboxSkinListDiffGroupViewModel diffSkinGroup
		{
			[Token(Token = "0x6021AFD")]
			[Address(RVA = "0x1C2B0C0", Offset = "0x1C29CC0", VA = "0x181C2B0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021AFE")]
			[Address(RVA = "0x1C2B120", Offset = "0x1C29D20", VA = "0x181C2B120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06021AFF RID: 137983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AFF")]
		[Address(RVA = "0x1C2A2E0", Offset = "0x1C28EE0", VA = "0x181C2A2E0")]
		public void AddSkinListViewModel(SkinShopBlindboxSkinListItemViewModel itemViewModel)
		{
		}

		// Token: 0x06021B00 RID: 137984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B00")]
		[Address(RVA = "0x1C2A470", Offset = "0x1C29070", VA = "0x181C2A470")]
		public void LoadData(List<SkinGachaItemSkinViewModel> gachaSkins)
		{
		}

		// Token: 0x06021B01 RID: 137985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B01")]
		[Address(RVA = "0x1C2AAE0", Offset = "0x1C296E0", VA = "0x181C2AAE0")]
		private SkinShopBlindboxSkinListItemViewModel _GenerateSkinViewModel(SkinGachaItemSkinViewModel skin)
		{
			return null;
		}

		// Token: 0x06021B02 RID: 137986 RVA: 0x000BB188 File Offset: 0x000B9388
		[Token(Token = "0x6021B02")]
		[Address(RVA = "0x1C2A980", Offset = "0x1C29580", VA = "0x181C2A980")]
		private bool _CheckIfHaveSkin(string skinId)
		{
			return default(bool);
		}

		// Token: 0x06021B03 RID: 137987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B03")]
		[Address(RVA = "0x1C2AF60", Offset = "0x1C29B60", VA = "0x181C2AF60")]
		public SkinShopBlindboxSkinListViewModel()
		{
		}

		// Token: 0x0402E102 RID: 188674
		[Token(Token = "0x402E102")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diffSkinGroup;

		// Token: 0x0402E103 RID: 188675
		[Token(Token = "0x402E103")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_diffSkinGroup;

		// Token: 0x0402E104 RID: 188676
		[Token(Token = "0x402E104")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddSkinListViewModel;

		// Token: 0x0402E105 RID: 188677
		[Token(Token = "0x402E105")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402E106 RID: 188678
		[Token(Token = "0x402E106")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateSkinViewModel;

		// Token: 0x0402E107 RID: 188679
		[Token(Token = "0x402E107")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIfHaveSkin;

		// Token: 0x0402E108 RID: 188680
		[Token(Token = "0x402E108")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
