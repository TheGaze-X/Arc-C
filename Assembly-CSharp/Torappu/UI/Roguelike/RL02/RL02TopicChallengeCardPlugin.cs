using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005728 RID: 22312
	[Token(Token = "0x2005728")]
	public class RL02TopicChallengeCardPlugin : RoguelikeTopicChallengeCardPlugin
	{
		// Token: 0x06020B41 RID: 133953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B41")]
		[Address(RVA = "0x1B0C030", Offset = "0x1B0AC30", VA = "0x181B0C030", Slot = "4")]
		public override void Render(string topicId, RoguelikeTopicChallengeModel model)
		{
		}

		// Token: 0x06020B42 RID: 133954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B42")]
		[Address(RVA = "0x1B0C1D0", Offset = "0x1B0ADD0", VA = "0x181B0C1D0")]
		public RL02TopicChallengeCardPlugin()
		{
		}

		// Token: 0x0402C638 RID: 181816
		[Token(Token = "0x402C638")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("InitRes")]
		private Text _initDice;

		// Token: 0x0402C639 RID: 181817
		[Token(Token = "0x402C639")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("InitRes")]
		private Text _initKey;

		// Token: 0x0402C63A RID: 181818
		[Token(Token = "0x402C63A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objUnlockPart;

		// Token: 0x0402C63B RID: 181819
		[Token(Token = "0x402C63B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objLockPart;

		// Token: 0x0402C63C RID: 181820
		[Token(Token = "0x402C63C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Lock Part")]
		private Text _txtLockTips;

		// Token: 0x0402C63D RID: 181821
		[Token(Token = "0x402C63D")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isLock;

		// Token: 0x0402C63E RID: 181822
		[Token(Token = "0x402C63E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C63F RID: 181823
		[Token(Token = "0x402C63F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
