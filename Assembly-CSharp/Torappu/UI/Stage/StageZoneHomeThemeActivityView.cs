using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067DF RID: 26591
	[Token(Token = "0x20067DF")]
	public class StageZoneHomeThemeActivityView : StageZoneHomeThemeView.Plugin
	{
		// Token: 0x060261E9 RID: 156137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261E9")]
		[Address(RVA = "0x213FE60", Offset = "0x213EA60", VA = "0x18213FE60", Slot = "5")]
		public override Sprite GetThemeLogo()
		{
			return null;
		}

		// Token: 0x060261EA RID: 156138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261EA")]
		[Address(RVA = "0x213FEC0", Offset = "0x213EAC0", VA = "0x18213FEC0", Slot = "6")]
		protected override void OnDataUpdated(StageZoneHomeThemeView.Plugin.Param param)
		{
		}

		// Token: 0x060261EB RID: 156139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261EB")]
		[Address(RVA = "0x2140410", Offset = "0x213F010", VA = "0x182140410")]
		private void _UpdateActivityItemInfo()
		{
		}

		// Token: 0x060261EC RID: 156140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261EC")]
		[Address(RVA = "0x213FE00", Offset = "0x213EA00", VA = "0x18213FE00")]
		public void EventOnThemeClicked()
		{
		}

		// Token: 0x060261ED RID: 156141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261ED")]
		[Address(RVA = "0x21406B0", Offset = "0x213F2B0", VA = "0x1821406B0")]
		public StageZoneHomeThemeActivityView()
		{
		}

		// Token: 0x04035AC5 RID: 219845
		[Token(Token = "0x4035AC5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelItem;

		// Token: 0x04035AC6 RID: 219846
		[Token(Token = "0x4035AC6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textItemCount;

		// Token: 0x04035AC7 RID: 219847
		[Token(Token = "0x4035AC7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x04035AC8 RID: 219848
		[Token(Token = "0x4035AC8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgMain;

		// Token: 0x04035AC9 RID: 219849
		[Token(Token = "0x4035AC9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgMainMagnify;

		// Token: 0x04035ACA RID: 219850
		[Token(Token = "0x4035ACA")]
		[FieldOffset(Offset = "0x48")]
		private ZoneHomeEntryActivityModel m_viewModel;

		// Token: 0x04035ACB RID: 219851
		[Token(Token = "0x4035ACB")]
		[FieldOffset(Offset = "0x50")]
		private ActivityThemeData m_themeData;

		// Token: 0x04035ACC RID: 219852
		[Token(Token = "0x4035ACC")]
		[FieldOffset(Offset = "0x58")]
		private UIItemViewModel m_itemModel;

		// Token: 0x04035ACD RID: 219853
		[Token(Token = "0x4035ACD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetThemeLogo;

		// Token: 0x04035ACE RID: 219854
		[Token(Token = "0x4035ACE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035ACF RID: 219855
		[Token(Token = "0x4035ACF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateActivityItemInfo;

		// Token: 0x04035AD0 RID: 219856
		[Token(Token = "0x4035AD0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnThemeClicked;

		// Token: 0x04035AD1 RID: 219857
		[Token(Token = "0x4035AD1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
