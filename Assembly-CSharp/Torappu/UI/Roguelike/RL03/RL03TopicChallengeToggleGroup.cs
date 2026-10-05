using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200580E RID: 22542
	[Token(Token = "0x200580E")]
	public class RL03TopicChallengeToggleGroup : RoguelikeTopicChallengeToggleGroup
	{
		// Token: 0x06020F27 RID: 134951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F27")]
		[Address(RVA = "0x1B53CE0", Offset = "0x1B528E0", VA = "0x181B53CE0", Slot = "4")]
		public override void Init(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x06020F28 RID: 134952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F28")]
		[Address(RVA = "0x1B54200", Offset = "0x1B52E00", VA = "0x181B54200", Slot = "5")]
		public override void RefreshToggles(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x06020F29 RID: 134953 RVA: 0x000B7F18 File Offset: 0x000B6118
		[Token(Token = "0x6020F29")]
		[Address(RVA = "0x1B54460", Offset = "0x1B53060", VA = "0x181B54460")]
		private ROGUELIKE_TOPIC_TOGGLE_DOT_STATE _TryGetToggleDotState(PlayerRoguelikeChallengeStatus challengeStatus)
		{
			return ROGUELIKE_TOPIC_TOGGLE_DOT_STATE.LOCK;
		}

		// Token: 0x06020F2A RID: 134954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F2A")]
		[Address(RVA = "0x1B54500", Offset = "0x1B53100", VA = "0x181B54500")]
		public RL03TopicChallengeToggleGroup()
		{
		}

		// Token: 0x0402CCC3 RID: 183491
		[Token(Token = "0x402CCC3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeTopicToggleDotWithLock _toggleDotPrefab;

		// Token: 0x0402CCC4 RID: 183492
		[Token(Token = "0x402CCC4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _toggleLinePrefab;

		// Token: 0x0402CCC5 RID: 183493
		[Token(Token = "0x402CCC5")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeTopicToggleDotWithLock> m_dots;

		// Token: 0x0402CCC6 RID: 183494
		[Token(Token = "0x402CCC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402CCC7 RID: 183495
		[Token(Token = "0x402CCC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshToggles;

		// Token: 0x0402CCC8 RID: 183496
		[Token(Token = "0x402CCC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryGetToggleDotState;

		// Token: 0x0402CCC9 RID: 183497
		[Token(Token = "0x402CCC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
