using System;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI;
using Torappu.UI.RoguelikeTopic;
using Torappu.UI.RoguelikeTopic.Mode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Scripts.UI.RoguelikeTopic.Mode
{
	// Token: 0x020017A0 RID: 6048
	[Token(Token = "0x20017A0")]
	public class RoguelikeTopicBattlePassEntryView : RoguelikeTopicSubView
	{
		// Token: 0x060098E3 RID: 39139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E3")]
		[Address(RVA = "0x3148190", Offset = "0x3146D90", VA = "0x183148190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E4")]
		[Address(RVA = "0x3147E60", Offset = "0x3146A60", VA = "0x183147E60", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E5")]
		[Address(RVA = "0x3147DD0", Offset = "0x31469D0", VA = "0x183147DD0")]
		public void EventOnBattlePass()
		{
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E6")]
		[Address(RVA = "0x3148270", Offset = "0x3146E70", VA = "0x183148270")]
		public RoguelikeTopicBattlePassEntryView()
		{
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E7")]
		[Address(RVA = "0x1406270", Offset = "0x1404E70", VA = "0x181406270")]
		private void <>xLuaBaseProxy_OnValueChanged(RoguelikeTopicModeViewProperty P0)
		{
		}

		// Token: 0x04008EE6 RID: 36582
		[Token(Token = "0x4008EE6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textBpLevel;

		// Token: 0x04008EE7 RID: 36583
		[Token(Token = "0x4008EE7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBpNotice;

		// Token: 0x04008EE8 RID: 36584
		[Token(Token = "0x4008EE8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objBpNotice;

		// Token: 0x04008EE9 RID: 36585
		[Token(Token = "0x4008EE9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIActTrackPoint _bpTrackPoint;

		// Token: 0x04008EEA RID: 36586
		[Token(Token = "0x4008EEA")]
		[FieldOffset(Offset = "0x48")]
		private TrackPointViewProperty m_bpRewardProperty;

		// Token: 0x04008EEB RID: 36587
		[Token(Token = "0x4008EEB")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04008EEC RID: 36588
		[Token(Token = "0x4008EEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04008EED RID: 36589
		[Token(Token = "0x4008EED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04008EEE RID: 36590
		[Token(Token = "0x4008EEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBattlePass;

		// Token: 0x04008EEF RID: 36591
		[Token(Token = "0x4008EEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
