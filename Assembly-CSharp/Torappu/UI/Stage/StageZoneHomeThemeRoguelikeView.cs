using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067E2 RID: 26594
	[Token(Token = "0x20067E2")]
	public class StageZoneHomeThemeRoguelikeView : StageZoneHomeThemeView.Plugin
	{
		// Token: 0x060261F9 RID: 156153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261F9")]
		[Address(RVA = "0x21418A0", Offset = "0x21404A0", VA = "0x1821418A0", Slot = "5")]
		public override Sprite GetThemeLogo()
		{
			return null;
		}

		// Token: 0x060261FA RID: 156154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261FA")]
		[Address(RVA = "0x2141900", Offset = "0x2140500", VA = "0x182141900", Slot = "6")]
		protected override void OnDataUpdated(StageZoneHomeThemeView.Plugin.Param param)
		{
		}

		// Token: 0x060261FB RID: 156155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261FB")]
		[Address(RVA = "0x2141B90", Offset = "0x2140790", VA = "0x182141B90", Slot = "4")]
		protected override void OnInit(StageZoneHomeThemeView holder)
		{
		}

		// Token: 0x060261FC RID: 156156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261FC")]
		[Address(RVA = "0x2141840", Offset = "0x2140440", VA = "0x182141840")]
		public void EventOnThemeClicked()
		{
		}

		// Token: 0x060261FD RID: 156157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261FD")]
		[Address(RVA = "0x2141C20", Offset = "0x2140820", VA = "0x182141C20")]
		public StageZoneHomeThemeRoguelikeView()
		{
		}

		// Token: 0x060261FE RID: 156158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261FE")]
		[Address(RVA = "0x2141C10", Offset = "0x2140810", VA = "0x182141C10")]
		private void <>xLuaBaseProxy_OnInit(StageZoneHomeThemeView P0)
		{
		}

		// Token: 0x04035AEF RID: 219887
		[Token(Token = "0x4035AEF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgMain;

		// Token: 0x04035AF0 RID: 219888
		[Token(Token = "0x4035AF0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgMainMagnify;

		// Token: 0x04035AF1 RID: 219889
		[Token(Token = "0x4035AF1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _imgLogo;

		// Token: 0x04035AF2 RID: 219890
		[Token(Token = "0x4035AF2")]
		[FieldOffset(Offset = "0x38")]
		private ZoneHomeRoguelikeEntryItemModel m_viewModel;

		// Token: 0x04035AF3 RID: 219891
		[Token(Token = "0x4035AF3")]
		[FieldOffset(Offset = "0x40")]
		private ActivityThemeData m_themeData;

		// Token: 0x04035AF4 RID: 219892
		[Token(Token = "0x4035AF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetThemeLogo;

		// Token: 0x04035AF5 RID: 219893
		[Token(Token = "0x4035AF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035AF6 RID: 219894
		[Token(Token = "0x4035AF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04035AF7 RID: 219895
		[Token(Token = "0x4035AF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnThemeClicked;

		// Token: 0x04035AF8 RID: 219896
		[Token(Token = "0x4035AF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
