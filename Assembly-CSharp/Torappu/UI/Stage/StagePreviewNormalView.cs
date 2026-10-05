using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200692A RID: 26922
	[Token(Token = "0x200692A")]
	public class StagePreviewNormalView : StagePreviewInfoBasicPanel
	{
		// Token: 0x060268F2 RID: 157938 RVA: 0x000CBAF0 File Offset: 0x000C9CF0
		[Token(Token = "0x60268F2")]
		[Address(RVA = "0x21B4400", Offset = "0x21B3000", VA = "0x1821B4400", Slot = "6")]
		protected override bool OnZoneViewChanged(IStageSelectHandler zoneModel, StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x060268F3 RID: 157939 RVA: 0x000CBB08 File Offset: 0x000C9D08
		[Token(Token = "0x60268F3")]
		[Address(RVA = "0x21B4770", Offset = "0x21B3370", VA = "0x1821B4770", Slot = "7")]
		protected override bool SelectStageViewModel(IStageSelectHandler zoneModel, out StageViewModel stageModel)
		{
			return default(bool);
		}

		// Token: 0x060268F4 RID: 157940 RVA: 0x000CBB20 File Offset: 0x000C9D20
		[Token(Token = "0x60268F4")]
		[Address(RVA = "0x21B4360", Offset = "0x21B2F60", VA = "0x1821B4360", Slot = "8")]
		protected override bool CheckToShow(IStageSelectHandler zoneModel)
		{
			return default(bool);
		}

		// Token: 0x060268F5 RID: 157941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268F5")]
		[Address(RVA = "0x21B4850", Offset = "0x21B3450", VA = "0x1821B4850")]
		private void _RaiseTutorialSignal()
		{
		}

		// Token: 0x060268F6 RID: 157942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268F6")]
		[Address(RVA = "0x21B48B0", Offset = "0x21B34B0", VA = "0x1821B48B0")]
		public StagePreviewNormalView()
		{
		}

		// Token: 0x060268F7 RID: 157943 RVA: 0x000CBB38 File Offset: 0x000C9D38
		[Token(Token = "0x60268F7")]
		[Address(RVA = "0x214F1A0", Offset = "0x214DDA0", VA = "0x18214F1A0")]
		private bool <>xLuaBaseProxy_OnZoneViewChanged(IStageSelectHandler P0, StageViewModel P1)
		{
			return default(bool);
		}

		// Token: 0x04036620 RID: 222752
		[Token(Token = "0x4036620")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("NORMAL")]
		protected StagePreviewRankView _rankView;

		// Token: 0x04036621 RID: 222753
		[Token(Token = "0x4036621")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("NORMAL")]
		private Image _diffLogo;

		// Token: 0x04036622 RID: 222754
		[Token(Token = "0x4036622")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("NORMAL")]
		private Image _diffBackImg;

		// Token: 0x04036623 RID: 222755
		[Token(Token = "0x4036623")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("NORMAL")]
		private GameObject _diffGroupButton;

		// Token: 0x04036624 RID: 222756
		[Token(Token = "0x4036624")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("NORMAL")]
		private GameObject _diffGroupPartBtn;

		// Token: 0x04036625 RID: 222757
		[Token(Token = "0x4036625")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("NORMAL")]
		private Color _commonApCostColor;

		// Token: 0x04036626 RID: 222758
		[Token(Token = "0x4036626")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("NORMAL Group Ap")]
		private Color _groupApCostColor;

		// Token: 0x04036627 RID: 222759
		[Token(Token = "0x4036627")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("NORMAL Group Ap")]
		private Color _commonColor;

		// Token: 0x04036628 RID: 222760
		[Token(Token = "0x4036628")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Group("NORMAL Group Ap")]
		private Color _toughColor;

		// Token: 0x04036629 RID: 222761
		[Token(Token = "0x4036629")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		[Group("NORMAL")]
		private GameObject _hasDiffPart;

		// Token: 0x0403662A RID: 222762
		[Token(Token = "0x403662A")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("NORMAL")]
		private Text _diffShortText;

		// Token: 0x0403662B RID: 222763
		[Token(Token = "0x403662B")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("NORMAL")]
		private Image _coloredBack;

		// Token: 0x0403662C RID: 222764
		[Token(Token = "0x403662C")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("NORMAL")]
		private Sprite _normalPart;

		// Token: 0x0403662D RID: 222765
		[Token(Token = "0x403662D")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("NORMAL")]
		private Sprite _toughPart;

		// Token: 0x0403662E RID: 222766
		[Token(Token = "0x403662E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneViewChanged;

		// Token: 0x0403662F RID: 222767
		[Token(Token = "0x403662F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectStageViewModel;

		// Token: 0x04036630 RID: 222768
		[Token(Token = "0x4036630")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckToShow;

		// Token: 0x04036631 RID: 222769
		[Token(Token = "0x4036631")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RaiseTutorialSignal;

		// Token: 0x04036632 RID: 222770
		[Token(Token = "0x4036632")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
