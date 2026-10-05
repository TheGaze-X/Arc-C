using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B60 RID: 19296
	[Token(Token = "0x2004B60")]
	public class HomeCharRotationViewModel : IHotfixable
	{
		// Token: 0x1700444B RID: 17483
		// (get) Token: 0x0601D0CF RID: 118991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700444B")]
		public HomeCharRotationPresetItemModel displayPresetModel
		{
			[Token(Token = "0x601D0CF")]
			[Address(RVA = "0x166BB00", Offset = "0x166A700", VA = "0x18166BB00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D0D0 RID: 118992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0D0")]
		[Address(RVA = "0x166B020", Offset = "0x1669C20", VA = "0x18166B020")]
		public void LoadData()
		{
		}

		// Token: 0x0601D0D1 RID: 118993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0D1")]
		[Address(RVA = "0x166B110", Offset = "0x1669D10", VA = "0x18166B110")]
		public void RefreshData(string selectPresetInstId, HomeCharRotationViewModel.SelectSkinStrategy selectSkinStrategy)
		{
		}

		// Token: 0x0601D0D2 RID: 118994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0D2")]
		[Address(RVA = "0x166B820", Offset = "0x166A420", VA = "0x18166B820")]
		private void _SetDisplayPreset(string instId, HomeCharRotationViewModel.SelectSkinStrategy selectSkinStrategy)
		{
		}

		// Token: 0x0601D0D3 RID: 118995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0D3")]
		[Address(RVA = "0x166B750", Offset = "0x166A350", VA = "0x18166B750")]
		public void SetShowRotationList(bool show)
		{
		}

		// Token: 0x0601D0D4 RID: 118996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0D4")]
		[Address(RVA = "0x166A780", Offset = "0x1669380", VA = "0x18166A780")]
		public void ChangePresetList(long direction)
		{
		}

		// Token: 0x0601D0D5 RID: 118997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0D5")]
		[Address(RVA = "0x166A930", Offset = "0x1669530", VA = "0x18166A930")]
		public void ChangeSkinList(long direction)
		{
		}

		// Token: 0x0601D0D6 RID: 118998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0D6")]
		[Address(RVA = "0x166B660", Offset = "0x166A260", VA = "0x18166B660")]
		public void SetSelectedSkinTag(string skinTag)
		{
		}

		// Token: 0x0601D0D7 RID: 118999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0D7")]
		[Address(RVA = "0x166B560", Offset = "0x166A160", VA = "0x18166B560")]
		public void SetDisplaySkinTag(string skinTag)
		{
		}

		// Token: 0x0601D0D8 RID: 119000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D0D8")]
		[Address(RVA = "0x166AF40", Offset = "0x1669B40", VA = "0x18166AF40")]
		public HomeCharRotationPresetSkinItemViewModel GetSkinModel(string skinId)
		{
			return null;
		}

		// Token: 0x0601D0D9 RID: 119001 RVA: 0x000AA208 File Offset: 0x000A8408
		[Token(Token = "0x601D0D9")]
		[Address(RVA = "0x166AE60", Offset = "0x1669A60", VA = "0x18166AE60")]
		public int GetSkinIndex(string skinId)
		{
			return 0;
		}

		// Token: 0x0601D0DA RID: 119002 RVA: 0x000AA220 File Offset: 0x000A8420
		[Token(Token = "0x601D0DA")]
		[Address(RVA = "0x166AAF0", Offset = "0x16696F0", VA = "0x18166AAF0")]
		public HomeSecretaryChangeSkinStateBean.InputParams GenerateChangeSkinParams()
		{
			return default(HomeSecretaryChangeSkinStateBean.InputParams);
		}

		// Token: 0x0601D0DB RID: 119003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0DB")]
		[Address(RVA = "0x166B7C0", Offset = "0x166A3C0", VA = "0x18166B7C0")]
		public void SwitchEditPanelVisibility()
		{
		}

		// Token: 0x0601D0DC RID: 119004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0DC")]
		[Address(RVA = "0x166BA50", Offset = "0x166A650", VA = "0x18166BA50")]
		public HomeCharRotationViewModel()
		{
		}

		// Token: 0x040261AF RID: 156079
		[Token(Token = "0x40261AF")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, HomeCharRotationPresetItemModel> presets;

		// Token: 0x040261B0 RID: 156080
		[Token(Token = "0x40261B0")]
		[FieldOffset(Offset = "0x18")]
		public bool showRotationList;

		// Token: 0x040261B1 RID: 156081
		[Token(Token = "0x40261B1")]
		[FieldOffset(Offset = "0x20")]
		public string appliedPresetInstId;

		// Token: 0x040261B2 RID: 156082
		[Token(Token = "0x40261B2")]
		[FieldOffset(Offset = "0x28")]
		public string displayPresetInstId;

		// Token: 0x040261B3 RID: 156083
		[Token(Token = "0x40261B3")]
		[FieldOffset(Offset = "0x30")]
		public string displaySkinTag;

		// Token: 0x040261B4 RID: 156084
		[Token(Token = "0x40261B4")]
		[FieldOffset(Offset = "0x38")]
		public int skinMaxNumInPreset;

		// Token: 0x040261B5 RID: 156085
		[Token(Token = "0x40261B5")]
		[FieldOffset(Offset = "0x3C")]
		public int enterSeqNum;

		// Token: 0x040261B6 RID: 156086
		[Token(Token = "0x40261B6")]
		[FieldOffset(Offset = "0x40")]
		public bool modifiedPreviewIllust;

		// Token: 0x040261B7 RID: 156087
		[Token(Token = "0x40261B7")]
		[FieldOffset(Offset = "0x41")]
		public bool hideEditPanel;

		// Token: 0x040261B8 RID: 156088
		[Token(Token = "0x40261B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayPresetModel;

		// Token: 0x040261B9 RID: 156089
		[Token(Token = "0x40261B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040261BA RID: 156090
		[Token(Token = "0x40261BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040261BB RID: 156091
		[Token(Token = "0x40261BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetDisplayPreset;

		// Token: 0x040261BC RID: 156092
		[Token(Token = "0x40261BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetShowRotationList;

		// Token: 0x040261BD RID: 156093
		[Token(Token = "0x40261BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangePresetList;

		// Token: 0x040261BE RID: 156094
		[Token(Token = "0x40261BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ChangeSkinList;

		// Token: 0x040261BF RID: 156095
		[Token(Token = "0x40261BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetSelectedSkinTag;

		// Token: 0x040261C0 RID: 156096
		[Token(Token = "0x40261C0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetDisplaySkinTag;

		// Token: 0x040261C1 RID: 156097
		[Token(Token = "0x40261C1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSkinModel;

		// Token: 0x040261C2 RID: 156098
		[Token(Token = "0x40261C2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetSkinIndex;

		// Token: 0x040261C3 RID: 156099
		[Token(Token = "0x40261C3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GenerateChangeSkinParams;

		// Token: 0x040261C4 RID: 156100
		[Token(Token = "0x40261C4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SwitchEditPanelVisibility;

		// Token: 0x040261C5 RID: 156101
		[Token(Token = "0x40261C5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B61 RID: 19297
		[Token(Token = "0x2004B61")]
		public enum SelectSkinStrategy
		{
			// Token: 0x040261C7 RID: 156103
			[Token(Token = "0x40261C7")]
			DO_NOT_MODIFY,
			// Token: 0x040261C8 RID: 156104
			[Token(Token = "0x40261C8")]
			USE_NOW_PREVIEWING,
			// Token: 0x040261C9 RID: 156105
			[Token(Token = "0x40261C9")]
			USE_FIRST
		}
	}
}
