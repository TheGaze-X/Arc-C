using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005685 RID: 22149
	[Token(Token = "0x2005685")]
	public class RL04TopicChallengeCardPlugin : RoguelikeTopicChallengeCardPlugin
	{
		// Token: 0x060207EB RID: 133099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207EB")]
		[Address(RVA = "0x1AA0A50", Offset = "0x1A9F650", VA = "0x181AA0A50", Slot = "4")]
		public override void Render(string topicId, RoguelikeTopicChallengeModel model)
		{
		}

		// Token: 0x060207EC RID: 133100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207EC")]
		[Address(RVA = "0x1AA0B60", Offset = "0x1A9F760", VA = "0x181AA0B60")]
		public RL04TopicChallengeCardPlugin()
		{
		}

		// Token: 0x0402C08F RID: 180367
		[Token(Token = "0x402C08F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objUnlockPart;

		// Token: 0x0402C090 RID: 180368
		[Token(Token = "0x402C090")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objLockPart;

		// Token: 0x0402C091 RID: 180369
		[Token(Token = "0x402C091")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Lock Part")]
		private Text _txtLockTips;

		// Token: 0x0402C092 RID: 180370
		[Token(Token = "0x402C092")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isLock;

		// Token: 0x0402C093 RID: 180371
		[Token(Token = "0x402C093")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C094 RID: 180372
		[Token(Token = "0x402C094")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
