using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005500 RID: 21760
	[Token(Token = "0x2005500")]
	public class RoguelikeShopDetailControllerBindings : IHotfixable
	{
		// Token: 0x17004B11 RID: 19217
		// (get) Token: 0x0602001E RID: 131102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B11")]
		public RoguelikeShopDetailExtraInfoPlugin extraInfoPlugin
		{
			[Token(Token = "0x602001E")]
			[Address(RVA = "0x1A1FA50", Offset = "0x1A1E650", VA = "0x181A1FA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B12 RID: 19218
		// (get) Token: 0x0602001F RID: 131103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B12")]
		public RoguelikeShopDetailConfirmPlugin confirmPlugin
		{
			[Token(Token = "0x602001F")]
			[Address(RVA = "0x1A1F9F0", Offset = "0x1A1E5F0", VA = "0x181A1F9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B13 RID: 19219
		// (get) Token: 0x06020020 RID: 131104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B13")]
		public RoguelikeGoodsObjPlugin goodIconPlugin
		{
			[Token(Token = "0x6020020")]
			[Address(RVA = "0x1A1FAB0", Offset = "0x1A1E6B0", VA = "0x181A1FAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020021 RID: 131105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020021")]
		[Address(RVA = "0x1A1F990", Offset = "0x1A1E590", VA = "0x181A1F990")]
		private RoguelikeShopDetailControllerBindings()
		{
		}

		// Token: 0x06020022 RID: 131106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020022")]
		[Address(RVA = "0x1A1F920", Offset = "0x1A1E520", VA = "0x181A1F920")]
		public void OnConfirm()
		{
		}

		// Token: 0x06020023 RID: 131107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020023")]
		[Address(RVA = "0x1A1F8B0", Offset = "0x1A1E4B0", VA = "0x181A1F8B0")]
		public void OnCancel()
		{
		}

		// Token: 0x0402B349 RID: 176969
		[Token(Token = "0x402B349")]
		[FieldOffset(Offset = "0x10")]
		private Action m_onCancel;

		// Token: 0x0402B34A RID: 176970
		[Token(Token = "0x402B34A")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onConfirm;

		// Token: 0x0402B34B RID: 176971
		[Token(Token = "0x402B34B")]
		[FieldOffset(Offset = "0x20")]
		private RoguelikeShopDetailExtraInfoPlugin m_extraInfoPlugin;

		// Token: 0x0402B34C RID: 176972
		[Token(Token = "0x402B34C")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeShopDetailConfirmPlugin m_confirmPlugin;

		// Token: 0x0402B34D RID: 176973
		[Token(Token = "0x402B34D")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeGoodsObjPlugin m_goodIconPlugin;

		// Token: 0x0402B34E RID: 176974
		[Token(Token = "0x402B34E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extraInfoPlugin;

		// Token: 0x0402B34F RID: 176975
		[Token(Token = "0x402B34F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_confirmPlugin;

		// Token: 0x0402B350 RID: 176976
		[Token(Token = "0x402B350")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_goodIconPlugin;

		// Token: 0x0402B351 RID: 176977
		[Token(Token = "0x402B351")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B352 RID: 176978
		[Token(Token = "0x402B352")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x0402B353 RID: 176979
		[Token(Token = "0x402B353")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x02005501 RID: 21761
		[Token(Token = "0x2005501")]
		public struct Builder
		{
			// Token: 0x06020024 RID: 131108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020024")]
			[Address(RVA = "0x1A164D0", Offset = "0x1A150D0", VA = "0x181A164D0")]
			public RoguelikeShopDetailControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B354 RID: 176980
			[Token(Token = "0x402B354")]
			[FieldOffset(Offset = "0x0")]
			public Action onCancel;

			// Token: 0x0402B355 RID: 176981
			[Token(Token = "0x402B355")]
			[FieldOffset(Offset = "0x8")]
			public Action onConfirm;

			// Token: 0x0402B356 RID: 176982
			[Token(Token = "0x402B356")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeShopDetailExtraInfoPlugin extraInfoPlugin;

			// Token: 0x0402B357 RID: 176983
			[Token(Token = "0x402B357")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeShopDetailConfirmPlugin confirmPlugin;

			// Token: 0x0402B358 RID: 176984
			[Token(Token = "0x402B358")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeGoodsObjPlugin goodIconPlugin;
		}
	}
}
