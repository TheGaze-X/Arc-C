using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067E0 RID: 26592
	[Token(Token = "0x20067E0")]
	public class StageZoneHomeThemeCrisisV2View : StageZoneHomeThemeView.Plugin, IHotfixable
	{
		// Token: 0x060261EE RID: 156142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261EE")]
		[Address(RVA = "0x21407D0", Offset = "0x213F3D0", VA = "0x1821407D0", Slot = "5")]
		public override Sprite GetThemeLogo()
		{
			return null;
		}

		// Token: 0x060261EF RID: 156143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261EF")]
		[Address(RVA = "0x2140770", Offset = "0x213F370", VA = "0x182140770")]
		public void EventOnThemeClicked()
		{
		}

		// Token: 0x060261F0 RID: 156144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261F0")]
		[Address(RVA = "0x2140830", Offset = "0x213F430", VA = "0x182140830", Slot = "6")]
		protected override void OnDataUpdated(StageZoneHomeThemeView.Plugin.Param param)
		{
		}

		// Token: 0x060261F1 RID: 156145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261F1")]
		[Address(RVA = "0x2140BB0", Offset = "0x213F7B0", VA = "0x182140BB0")]
		public StageZoneHomeThemeCrisisV2View()
		{
		}

		// Token: 0x04035AD2 RID: 219858
		[Token(Token = "0x4035AD2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x04035AD3 RID: 219859
		[Token(Token = "0x4035AD3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNoRank;

		// Token: 0x04035AD4 RID: 219860
		[Token(Token = "0x4035AD4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgMain;

		// Token: 0x04035AD5 RID: 219861
		[Token(Token = "0x4035AD5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgMainMagnify;

		// Token: 0x04035AD6 RID: 219862
		[Token(Token = "0x4035AD6")]
		[FieldOffset(Offset = "0x40")]
		private ZoneHomeEntryCrisisV2Model m_viewModel;

		// Token: 0x04035AD7 RID: 219863
		[Token(Token = "0x4035AD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetThemeLogo;

		// Token: 0x04035AD8 RID: 219864
		[Token(Token = "0x4035AD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnThemeClicked;

		// Token: 0x04035AD9 RID: 219865
		[Token(Token = "0x4035AD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035ADA RID: 219866
		[Token(Token = "0x4035ADA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
