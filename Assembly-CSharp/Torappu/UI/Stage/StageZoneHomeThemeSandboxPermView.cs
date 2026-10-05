using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067E3 RID: 26595
	[Token(Token = "0x20067E3")]
	public class StageZoneHomeThemeSandboxPermView : StageZoneHomeThemeView.Plugin, IHotfixable
	{
		// Token: 0x060261FF RID: 156159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261FF")]
		[Address(RVA = "0x2141D00", Offset = "0x2140900", VA = "0x182141D00", Slot = "5")]
		public override Sprite GetThemeLogo()
		{
			return null;
		}

		// Token: 0x06026200 RID: 156160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026200")]
		[Address(RVA = "0x2141D60", Offset = "0x2140960", VA = "0x182141D60", Slot = "6")]
		protected override void OnDataUpdated(StageZoneHomeThemeView.Plugin.Param param)
		{
		}

		// Token: 0x06026201 RID: 156161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026201")]
		[Address(RVA = "0x2141CA0", Offset = "0x21408A0", VA = "0x182141CA0")]
		public void EventOnThemeClicked()
		{
		}

		// Token: 0x06026202 RID: 156162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026202")]
		[Address(RVA = "0x2141F50", Offset = "0x2140B50", VA = "0x182141F50")]
		public StageZoneHomeThemeSandboxPermView()
		{
		}

		// Token: 0x04035AF9 RID: 219897
		[Token(Token = "0x4035AF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgMain;

		// Token: 0x04035AFA RID: 219898
		[Token(Token = "0x4035AFA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _imgLogo;

		// Token: 0x04035AFB RID: 219899
		[Token(Token = "0x4035AFB")]
		[FieldOffset(Offset = "0x30")]
		private ZoneHomeSandboxPermItemModel m_viewModel;

		// Token: 0x04035AFC RID: 219900
		[Token(Token = "0x4035AFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetThemeLogo;

		// Token: 0x04035AFD RID: 219901
		[Token(Token = "0x4035AFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035AFE RID: 219902
		[Token(Token = "0x4035AFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnThemeClicked;

		// Token: 0x04035AFF RID: 219903
		[Token(Token = "0x4035AFF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
