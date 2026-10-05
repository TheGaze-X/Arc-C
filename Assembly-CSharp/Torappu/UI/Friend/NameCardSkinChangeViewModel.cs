using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D79 RID: 19833
	[Token(Token = "0x2004D79")]
	public class NameCardSkinChangeViewModel : IHotfixable
	{
		// Token: 0x0601DAF5 RID: 121589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAF5")]
		[Address(RVA = "0x1744410", Offset = "0x1743010", VA = "0x181744410")]
		public void LoadData()
		{
		}

		// Token: 0x0601DAF6 RID: 121590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAF6")]
		[Address(RVA = "0x1744710", Offset = "0x1743310", VA = "0x181744710")]
		public void SelectSkin(string skinId, bool isOverridden)
		{
		}

		// Token: 0x0601DAF7 RID: 121591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAF7")]
		[Address(RVA = "0x1744BE0", Offset = "0x17437E0", VA = "0x181744BE0")]
		public void UpdateSkinList()
		{
		}

		// Token: 0x0601DAF8 RID: 121592 RVA: 0x000AC410 File Offset: 0x000AA610
		[Token(Token = "0x601DAF8")]
		[Address(RVA = "0x1744A40", Offset = "0x1743640", VA = "0x181744A40")]
		public bool TryToChangeSkinTmpl(string skinId)
		{
			return default(bool);
		}

		// Token: 0x0601DAF9 RID: 121593 RVA: 0x000AC428 File Offset: 0x000AA628
		[Token(Token = "0x601DAF9")]
		[Address(RVA = "0x1744930", Offset = "0x1743530", VA = "0x181744930")]
		public bool TryHideChangeSkinTmpl()
		{
			return default(bool);
		}

		// Token: 0x0601DAFA RID: 121594 RVA: 0x000AC440 File Offset: 0x000AA640
		[Token(Token = "0x601DAFA")]
		[Address(RVA = "0x17449A0", Offset = "0x17435A0", VA = "0x1817449A0")]
		public bool TrySelectSkinTmpl(int skinTmpl)
		{
			return default(bool);
		}

		// Token: 0x0601DAFB RID: 121595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAFB")]
		[Address(RVA = "0x1744CB0", Offset = "0x17438B0", VA = "0x181744CB0")]
		public NameCardSkinChangeViewModel()
		{
		}

		// Token: 0x0402737F RID: 160639
		[Token(Token = "0x402737F")]
		[FieldOffset(Offset = "0x10")]
		public List<NameCardSkinListItemViewModel> itemViewModels;

		// Token: 0x04027380 RID: 160640
		[Token(Token = "0x4027380")]
		[FieldOffset(Offset = "0x18")]
		public NameCardV2SkinData selectedSkinData;

		// Token: 0x04027381 RID: 160641
		[Token(Token = "0x4027381")]
		[FieldOffset(Offset = "0x20")]
		public PlayerNameCardSkin.SkinState selectedSkinState;

		// Token: 0x04027382 RID: 160642
		[Token(Token = "0x4027382")]
		[FieldOffset(Offset = "0x28")]
		public NameCardV2ViewModel.ShowDetailOption showDetailOpt;

		// Token: 0x04027383 RID: 160643
		[Token(Token = "0x4027383")]
		[FieldOffset(Offset = "0x2C")]
		public int focusToIndex;

		// Token: 0x04027384 RID: 160644
		[Token(Token = "0x4027384")]
		[FieldOffset(Offset = "0x30")]
		public int focusSkinListSeqNum;

		// Token: 0x04027385 RID: 160645
		[Token(Token = "0x4027385")]
		[FieldOffset(Offset = "0x34")]
		public bool isSkinChangeUnlocked;

		// Token: 0x04027386 RID: 160646
		[Token(Token = "0x4027386")]
		[FieldOffset(Offset = "0x38")]
		public NameCardSkinTmplChangeViewModel skinTmplChangeViewModel;

		// Token: 0x04027387 RID: 160647
		[Token(Token = "0x4027387")]
		[FieldOffset(Offset = "0x40")]
		public bool beShowSkinTmplPanel;

		// Token: 0x04027388 RID: 160648
		[Token(Token = "0x4027388")]
		[FieldOffset(Offset = "0x44")]
		public int showSkinTmplSeqNum;

		// Token: 0x04027389 RID: 160649
		[Token(Token = "0x4027389")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402738A RID: 160650
		[Token(Token = "0x402738A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectSkin;

		// Token: 0x0402738B RID: 160651
		[Token(Token = "0x402738B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateSkinList;

		// Token: 0x0402738C RID: 160652
		[Token(Token = "0x402738C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryToChangeSkinTmpl;

		// Token: 0x0402738D RID: 160653
		[Token(Token = "0x402738D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryHideChangeSkinTmpl;

		// Token: 0x0402738E RID: 160654
		[Token(Token = "0x402738E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TrySelectSkinTmpl;

		// Token: 0x0402738F RID: 160655
		[Token(Token = "0x402738F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
