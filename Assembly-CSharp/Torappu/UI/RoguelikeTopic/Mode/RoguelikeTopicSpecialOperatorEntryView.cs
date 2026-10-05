using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x02004676 RID: 18038
	[Token(Token = "0x2004676")]
	public class RoguelikeTopicSpecialOperatorEntryView : RoguelikeTopicSubView
	{
		// Token: 0x0601B62C RID: 112172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B62C")]
		[Address(RVA = "0x14BF9C0", Offset = "0x14BE5C0", VA = "0x1814BF9C0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B62D RID: 112173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B62D")]
		[Address(RVA = "0x14BF860", Offset = "0x14BE460", VA = "0x1814BF860")]
		public void EventOnSPOperator()
		{
		}

		// Token: 0x0601B62E RID: 112174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B62E")]
		[Address(RVA = "0x14BFC00", Offset = "0x14BE800", VA = "0x1814BFC00")]
		public RoguelikeTopicSpecialOperatorEntryView()
		{
		}

		// Token: 0x0601B62F RID: 112175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B62F")]
		[Address(RVA = "0x14BB4E0", Offset = "0x14BA0E0", VA = "0x1814BB4E0")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x0402365C RID: 144988
		[Token(Token = "0x402365C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedVariant;

		// Token: 0x0402365D RID: 144989
		[Token(Token = "0x402365D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _firstVariant;

		// Token: 0x0402365E RID: 144990
		[Token(Token = "0x402365E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _normalVariant;

		// Token: 0x0402365F RID: 144991
		[Token(Token = "0x402365F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _upgradeVariant;

		// Token: 0x04023660 RID: 144992
		[Token(Token = "0x4023660")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _eliteVariant;

		// Token: 0x04023661 RID: 144993
		[Token(Token = "0x4023661")]
		[FieldOffset(Offset = "0x50")]
		private string m_charId;

		// Token: 0x04023662 RID: 144994
		[Token(Token = "0x4023662")]
		[FieldOffset(Offset = "0x58")]
		private bool m_active;

		// Token: 0x04023663 RID: 144995
		[Token(Token = "0x4023663")]
		[FieldOffset(Offset = "0x60")]
		private string m_lockedMessage;

		// Token: 0x04023664 RID: 144996
		[Token(Token = "0x4023664")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023665 RID: 144997
		[Token(Token = "0x4023665")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnSPOperator;

		// Token: 0x04023666 RID: 144998
		[Token(Token = "0x4023666")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
