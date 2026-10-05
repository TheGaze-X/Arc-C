using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032B6 RID: 12982
	[Token(Token = "0x20032B6")]
	public class AutoChessUnderFrameSkillButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x060149F3 RID: 84467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149F3")]
		[Address(RVA = "0xCDDCB0", Offset = "0xCDC8B0", VA = "0x180CDDCB0")]
		public void OnSkillButtonClicked()
		{
		}

		// Token: 0x060149F4 RID: 84468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149F4")]
		[Address(RVA = "0xCDDD10", Offset = "0xCDC910", VA = "0x180CDDD10")]
		public void OnSkillRangeToggled()
		{
		}

		// Token: 0x060149F5 RID: 84469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149F5")]
		[Address(RVA = "0xCDDDC0", Offset = "0xCDC9C0", VA = "0x180CDDDC0")]
		public void Show(Character character)
		{
		}

		// Token: 0x060149F6 RID: 84470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149F6")]
		[Address(RVA = "0xCDDC40", Offset = "0xCDC840", VA = "0x180CDDC40")]
		public void Hide()
		{
		}

		// Token: 0x060149F7 RID: 84471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149F7")]
		[Address(RVA = "0xCDE0C0", Offset = "0xCDCCC0", VA = "0x180CDE0C0")]
		private void _SetData(Character character)
		{
		}

		// Token: 0x060149F8 RID: 84472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149F8")]
		[Address(RVA = "0xCDE240", Offset = "0xCDCE40", VA = "0x180CDE240")]
		private void _UpdateData()
		{
		}

		// Token: 0x060149F9 RID: 84473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149F9")]
		[Address(RVA = "0xCDE830", Offset = "0xCDD430", VA = "0x180CDE830")]
		private void _UpdateSkillToggle()
		{
		}

		// Token: 0x060149FA RID: 84474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149FA")]
		[Address(RVA = "0xCDE610", Offset = "0xCDD210", VA = "0x180CDE610")]
		private void _UpdateSkillCount(bool force)
		{
		}

		// Token: 0x060149FB RID: 84475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149FB")]
		[Address(RVA = "0xCDDFB0", Offset = "0xCDCBB0", VA = "0x180CDDFB0")]
		private void _DoUpdateRangeToShow(Character character)
		{
		}

		// Token: 0x060149FC RID: 84476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60149FC")]
		[Address(RVA = "0xCDE930", Offset = "0xCDD530", VA = "0x180CDE930")]
		public AutoChessUnderFrameSkillButton()
		{
		}

		// Token: 0x040186DC RID: 100060
		[Token(Token = "0x40186DC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _skillButton;

		// Token: 0x040186DD RID: 100061
		[Token(Token = "0x40186DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x040186DE RID: 100062
		[Token(Token = "0x40186DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _skillNotReadyMark;

		// Token: 0x040186DF RID: 100063
		[Token(Token = "0x40186DF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _skillStopMark;

		// Token: 0x040186E0 RID: 100064
		[Token(Token = "0x40186E0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MaskableGraphic _skillAutoMark;

		// Token: 0x040186E1 RID: 100065
		[Token(Token = "0x40186E1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _skillAmountPanel;

		// Token: 0x040186E2 RID: 100066
		[Token(Token = "0x40186E2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _skillAmountNum;

		// Token: 0x040186E3 RID: 100067
		[Token(Token = "0x40186E3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _skillProgressLabel;

		// Token: 0x040186E4 RID: 100068
		[Token(Token = "0x40186E4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _skillProgressLabelNormalColor;

		// Token: 0x040186E5 RID: 100069
		[Token(Token = "0x40186E5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _skillProgressLabelStackColor;

		// Token: 0x040186E6 RID: 100070
		[Token(Token = "0x40186E6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Toggle _skillRangeToggle;

		// Token: 0x040186E7 RID: 100071
		[Token(Token = "0x40186E7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _skillPanel;

		// Token: 0x040186E8 RID: 100072
		[Token(Token = "0x40186E8")]
		[FieldOffset(Offset = "0x88")]
		private Character m_character;

		// Token: 0x040186E9 RID: 100073
		[Token(Token = "0x40186E9")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isSkillAmountShown;

		// Token: 0x040186EA RID: 100074
		[Token(Token = "0x40186EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSkillButtonClicked;

		// Token: 0x040186EB RID: 100075
		[Token(Token = "0x40186EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSkillRangeToggled;

		// Token: 0x040186EC RID: 100076
		[Token(Token = "0x40186EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040186ED RID: 100077
		[Token(Token = "0x40186ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040186EE RID: 100078
		[Token(Token = "0x40186EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x040186EF RID: 100079
		[Token(Token = "0x40186EF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x040186F0 RID: 100080
		[Token(Token = "0x40186F0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateSkillToggle;

		// Token: 0x040186F1 RID: 100081
		[Token(Token = "0x40186F1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateSkillCount;

		// Token: 0x040186F2 RID: 100082
		[Token(Token = "0x40186F2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoUpdateRangeToShow;

		// Token: 0x040186F3 RID: 100083
		[Token(Token = "0x40186F3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
