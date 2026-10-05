using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005730 RID: 22320
	[Token(Token = "0x2005730")]
	public class RL02TopicChallengeToggleGroup : RoguelikeTopicChallengeToggleGroup
	{
		// Token: 0x06020B71 RID: 134001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B71")]
		[Address(RVA = "0x1B0E2D0", Offset = "0x1B0CED0", VA = "0x181B0E2D0", Slot = "4")]
		public override void Init(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x06020B72 RID: 134002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B72")]
		[Address(RVA = "0x1B0E7F0", Offset = "0x1B0D3F0", VA = "0x181B0E7F0", Slot = "5")]
		public override void RefreshToggles(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x06020B73 RID: 134003 RVA: 0x000B6F28 File Offset: 0x000B5128
		[Token(Token = "0x6020B73")]
		[Address(RVA = "0x1B0EA50", Offset = "0x1B0D650", VA = "0x181B0EA50")]
		private ROGUELIKE_TOPIC_TOGGLE_DOT_STATE _TryGetToggleDotState(PlayerRoguelikeChallengeStatus challengeStatus)
		{
			return ROGUELIKE_TOPIC_TOGGLE_DOT_STATE.LOCK;
		}

		// Token: 0x06020B74 RID: 134004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B74")]
		[Address(RVA = "0x1B0EAF0", Offset = "0x1B0D6F0", VA = "0x181B0EAF0")]
		public RL02TopicChallengeToggleGroup()
		{
		}

		// Token: 0x0402C67A RID: 181882
		[Token(Token = "0x402C67A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeTopicToggleDotWithLock _toggleDotPrefab;

		// Token: 0x0402C67B RID: 181883
		[Token(Token = "0x402C67B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _toggleLinePrefab;

		// Token: 0x0402C67C RID: 181884
		[Token(Token = "0x402C67C")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeTopicToggleDotWithLock> m_dots;

		// Token: 0x0402C67D RID: 181885
		[Token(Token = "0x402C67D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C67E RID: 181886
		[Token(Token = "0x402C67E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshToggles;

		// Token: 0x0402C67F RID: 181887
		[Token(Token = "0x402C67F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryGetToggleDotState;

		// Token: 0x0402C680 RID: 181888
		[Token(Token = "0x402C680")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
