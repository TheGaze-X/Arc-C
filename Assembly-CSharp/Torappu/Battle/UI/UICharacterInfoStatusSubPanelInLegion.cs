using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032CA RID: 13002
	[Token(Token = "0x20032CA")]
	public class UICharacterInfoStatusSubPanelInLegion : UICharacterInfoStatusSubPanel
	{
		// Token: 0x06014ABD RID: 84669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ABD")]
		[Address(RVA = "0xCF0140", Offset = "0xCEED40", VA = "0x180CF0140", Slot = "5")]
		public override void SetData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014ABE RID: 84670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ABE")]
		[Address(RVA = "0xCF0760", Offset = "0xCEF360", VA = "0x180CF0760")]
		private void _RefreshProfessionPanelState(UICharacterInfoStatusSubPanelInLegion.ProfessionPanelState state)
		{
		}

		// Token: 0x06014ABF RID: 84671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ABF")]
		[Address(RVA = "0xCF0610", Offset = "0xCEF210", VA = "0x180CF0610", Slot = "6")]
		public override void UpdateData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AC0 RID: 84672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AC0")]
		[Address(RVA = "0xCF0880", Offset = "0xCEF480", VA = "0x180CF0880")]
		public UICharacterInfoStatusSubPanelInLegion()
		{
		}

		// Token: 0x06014AC1 RID: 84673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AC1")]
		[Address(RVA = "0xCEF9C0", Offset = "0xCEE5C0", VA = "0x180CEF9C0")]
		private void <>xLuaBaseProxy_SetData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x06014AC2 RID: 84674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AC2")]
		[Address(RVA = "0xCEF9F0", Offset = "0xCEE5F0", VA = "0x180CEF9F0")]
		private void <>xLuaBaseProxy_UpdateData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x04018836 RID: 100406
		[Token(Token = "0x4018836")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Legion")]
		private Image _professionBacklight;

		// Token: 0x04018837 RID: 100407
		[Token(Token = "0x4018837")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Legion")]
		private Image _professionNoInfo;

		// Token: 0x04018838 RID: 100408
		[Token(Token = "0x4018838")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Legion")]
		private Text _professionDescription;

		// Token: 0x04018839 RID: 100409
		[Token(Token = "0x4018839")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Legion")]
		private Text _professionDescriptionHead;

		// Token: 0x0401883A RID: 100410
		[Token(Token = "0x401883A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Legion")]
		private CanvasGroup _professionCanvasGroup;

		// Token: 0x0401883B RID: 100411
		[Token(Token = "0x401883B")]
		[FieldOffset(Offset = "0xD8")]
		private UICharacterInfoStatusSubPanelInLegion.ProfessionPanelState m_panelState;

		// Token: 0x0401883C RID: 100412
		[Token(Token = "0x401883C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401883D RID: 100413
		[Token(Token = "0x401883D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshProfessionPanelState;

		// Token: 0x0401883E RID: 100414
		[Token(Token = "0x401883E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401883F RID: 100415
		[Token(Token = "0x401883F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032CB RID: 13003
		[Token(Token = "0x20032CB")]
		private enum ProfessionPanelState
		{
			// Token: 0x04018841 RID: 100417
			[Token(Token = "0x4018841")]
			INACTIVE,
			// Token: 0x04018842 RID: 100418
			[Token(Token = "0x4018842")]
			ACTIVE,
			// Token: 0x04018843 RID: 100419
			[Token(Token = "0x4018843")]
			HIGHLIGHT
		}
	}
}
