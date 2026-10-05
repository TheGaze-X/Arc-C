using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005565 RID: 21861
	[Token(Token = "0x2005565")]
	public class RL05TopicChallengeCardPlugin : RoguelikeTopicChallengeCardPlugin
	{
		// Token: 0x06020221 RID: 131617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020221")]
		[Address(RVA = "0x1A36E10", Offset = "0x1A35A10", VA = "0x181A36E10", Slot = "4")]
		public override void Render(string topicId, RoguelikeTopicChallengeModel model)
		{
		}

		// Token: 0x06020222 RID: 131618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020222")]
		[Address(RVA = "0x1A36F20", Offset = "0x1A35B20", VA = "0x181A36F20")]
		public RL05TopicChallengeCardPlugin()
		{
		}

		// Token: 0x0402B67C RID: 177788
		[Token(Token = "0x402B67C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objUnlockPart;

		// Token: 0x0402B67D RID: 177789
		[Token(Token = "0x402B67D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Lock Part")]
		private GameObject _objLockPart;

		// Token: 0x0402B67E RID: 177790
		[Token(Token = "0x402B67E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Lock Part")]
		private Text _txtLockTips;

		// Token: 0x0402B67F RID: 177791
		[Token(Token = "0x402B67F")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isLock;

		// Token: 0x0402B680 RID: 177792
		[Token(Token = "0x402B680")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B681 RID: 177793
		[Token(Token = "0x402B681")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
