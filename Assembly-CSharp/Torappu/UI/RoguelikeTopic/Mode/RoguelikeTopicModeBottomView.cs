using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x02004670 RID: 18032
	[Token(Token = "0x2004670")]
	public class RoguelikeTopicModeBottomView : RoguelikeTopicSubView
	{
		// Token: 0x0601B609 RID: 112137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B609")]
		[Address(RVA = "0x14BBB00", Offset = "0x14BA700", VA = "0x1814BBB00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B60A RID: 112138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B60A")]
		[Address(RVA = "0x14BB650", Offset = "0x14BA250", VA = "0x1814BB650", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B60B RID: 112139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B60B")]
		[Address(RVA = "0x14BBC80", Offset = "0x14BA880", VA = "0x1814BBC80")]
		private void _OnModeTabClicked(ModeTabIDs.SerializeTabID clickedTab)
		{
		}

		// Token: 0x0601B60C RID: 112140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B60C")]
		[Address(RVA = "0x14BBE30", Offset = "0x14BAA30", VA = "0x1814BBE30")]
		private void _RefreshMonthModeInfo(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B60D RID: 112141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B60D")]
		[Address(RVA = "0x14BBD50", Offset = "0x14BA950", VA = "0x1814BBD50")]
		private void _RefreshChallengeModeInfo(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B60E RID: 112142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B60E")]
		[Address(RVA = "0x14BC120", Offset = "0x14BAD20", VA = "0x1814BC120")]
		public RoguelikeTopicModeBottomView()
		{
		}

		// Token: 0x0601B60F RID: 112143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B60F")]
		[Address(RVA = "0x14BB4E0", Offset = "0x14BA0E0", VA = "0x1814BB4E0")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x04023615 RID: 144917
		[Token(Token = "0x4023615")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeTopicModeToggle[] _toggles;

		// Token: 0x04023616 RID: 144918
		[Token(Token = "0x4023616")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlMonthModeRefresh;

		// Token: 0x04023617 RID: 144919
		[Token(Token = "0x4023617")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMonthModeRefresh;

		// Token: 0x04023618 RID: 144920
		[Token(Token = "0x4023618")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _trackpointMonthModeRefresh;

		// Token: 0x04023619 RID: 144921
		[Token(Token = "0x4023619")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _trackpointChallengeModeRefresh;

		// Token: 0x0402361A RID: 144922
		[Token(Token = "0x402361A")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0402361B RID: 144923
		[Token(Token = "0x402361B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402361C RID: 144924
		[Token(Token = "0x402361C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402361D RID: 144925
		[Token(Token = "0x402361D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnModeTabClicked;

		// Token: 0x0402361E RID: 144926
		[Token(Token = "0x402361E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshMonthModeInfo;

		// Token: 0x0402361F RID: 144927
		[Token(Token = "0x402361F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshChallengeModeInfo;

		// Token: 0x04023620 RID: 144928
		[Token(Token = "0x4023620")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
