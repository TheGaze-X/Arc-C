using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Legion;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032D9 RID: 13017
	[Token(Token = "0x20032D9")]
	public class UIBattleLegionRedrawPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014B28 RID: 84776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B28")]
		[Address(RVA = "0xD20490", Offset = "0xD1F090", VA = "0x180D20490")]
		public void Show(LegionUICardRedrawState legionState, GameModeFactory.LegionGameMode manager)
		{
		}

		// Token: 0x06014B29 RID: 84777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B29")]
		[Address(RVA = "0xD202D0", Offset = "0xD1EED0", VA = "0x180D202D0")]
		public void ShowRedrawCards(int curCnt)
		{
		}

		// Token: 0x06014B2A RID: 84778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B2A")]
		[Address(RVA = "0xD20110", Offset = "0xD1ED10", VA = "0x180D20110")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x06014B2B RID: 84779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B2B")]
		[Address(RVA = "0xD20260", Offset = "0xD1EE60", VA = "0x180D20260")]
		public void OnUnselectClick()
		{
		}

		// Token: 0x06014B2C RID: 84780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B2C")]
		[Address(RVA = "0xD20180", Offset = "0xD1ED80", VA = "0x180D20180")]
		public void OnShowPendingCard()
		{
		}

		// Token: 0x06014B2D RID: 84781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B2D")]
		[Address(RVA = "0xD201F0", Offset = "0xD1EDF0", VA = "0x180D201F0")]
		public void OnShowUsedCard()
		{
		}

		// Token: 0x06014B2E RID: 84782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B2E")]
		[Address(RVA = "0xD206F0", Offset = "0xD1F2F0", VA = "0x180D206F0")]
		public UIBattleLegionRedrawPanel()
		{
		}

		// Token: 0x0401891D RID: 100637
		[Token(Token = "0x401891D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _curCntText;

		// Token: 0x0401891E RID: 100638
		[Token(Token = "0x401891E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _totalCntText;

		// Token: 0x0401891F RID: 100639
		[Token(Token = "0x401891F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgTipBg;

		// Token: 0x04018920 RID: 100640
		[Token(Token = "0x4018920")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _remainingCardCountText;

		// Token: 0x04018921 RID: 100641
		[Token(Token = "0x4018921")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _usedCardCountText;

		// Token: 0x04018922 RID: 100642
		[Token(Token = "0x4018922")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ThreeStateToggle _redrawBtnToggle;

		// Token: 0x04018923 RID: 100643
		[Token(Token = "0x4018923")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Color")]
		private Color _bgCanStart;

		// Token: 0x04018924 RID: 100644
		[Token(Token = "0x4018924")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Color")]
		private Color _bgNotStart;

		// Token: 0x04018925 RID: 100645
		[Token(Token = "0x4018925")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Color")]
		private Color _numCommon;

		// Token: 0x04018926 RID: 100646
		[Token(Token = "0x4018926")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Color")]
		private Color _numBeyond;

		// Token: 0x04018927 RID: 100647
		[Token(Token = "0x4018927")]
		[FieldOffset(Offset = "0x88")]
		private LegionUICardRedrawState m_legionState;

		// Token: 0x04018928 RID: 100648
		[Token(Token = "0x4018928")]
		[FieldOffset(Offset = "0x90")]
		private int m_totalCnt;

		// Token: 0x04018929 RID: 100649
		[Token(Token = "0x4018929")]
		private const string DEFAULT_CNT = "0";

		// Token: 0x0401892A RID: 100650
		[Token(Token = "0x401892A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401892B RID: 100651
		[Token(Token = "0x401892B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowRedrawCards;

		// Token: 0x0401892C RID: 100652
		[Token(Token = "0x401892C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x0401892D RID: 100653
		[Token(Token = "0x401892D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUnselectClick;

		// Token: 0x0401892E RID: 100654
		[Token(Token = "0x401892E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnShowPendingCard;

		// Token: 0x0401892F RID: 100655
		[Token(Token = "0x401892F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnShowUsedCard;

		// Token: 0x04018930 RID: 100656
		[Token(Token = "0x4018930")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
