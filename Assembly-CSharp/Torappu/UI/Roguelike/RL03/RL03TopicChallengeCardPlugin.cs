using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005806 RID: 22534
	[Token(Token = "0x2005806")]
	public class RL03TopicChallengeCardPlugin : RoguelikeTopicChallengeCardPlugin
	{
		// Token: 0x06020EF7 RID: 134903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EF7")]
		[Address(RVA = "0x1B32EC0", Offset = "0x1B31AC0", VA = "0x181B32EC0", Slot = "4")]
		public override void Render(string topicId, RoguelikeTopicChallengeModel model)
		{
		}

		// Token: 0x06020EF8 RID: 134904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EF8")]
		[Address(RVA = "0x1B32FD0", Offset = "0x1B31BD0", VA = "0x181B32FD0")]
		public RL03TopicChallengeCardPlugin()
		{
		}

		// Token: 0x0402CC83 RID: 183427
		[Token(Token = "0x402CC83")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objUnlockPart;

		// Token: 0x0402CC84 RID: 183428
		[Token(Token = "0x402CC84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objLockPart;

		// Token: 0x0402CC85 RID: 183429
		[Token(Token = "0x402CC85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Lock Part")]
		private Text _txtLockTips;

		// Token: 0x0402CC86 RID: 183430
		[Token(Token = "0x402CC86")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isLock;

		// Token: 0x0402CC87 RID: 183431
		[Token(Token = "0x402CC87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CC88 RID: 183432
		[Token(Token = "0x402CC88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
