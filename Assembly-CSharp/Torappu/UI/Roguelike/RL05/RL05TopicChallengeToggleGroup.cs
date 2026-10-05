using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200556D RID: 21869
	[Token(Token = "0x200556D")]
	public class RL05TopicChallengeToggleGroup : RoguelikeTopicChallengeToggleGroup
	{
		// Token: 0x06020251 RID: 131665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020251")]
		[Address(RVA = "0x1A390B0", Offset = "0x1A37CB0", VA = "0x181A390B0", Slot = "4")]
		public override void Init(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x06020252 RID: 131666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020252")]
		[Address(RVA = "0x1A395D0", Offset = "0x1A381D0", VA = "0x181A395D0", Slot = "5")]
		public override void RefreshToggles(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x06020253 RID: 131667 RVA: 0x000B4D20 File Offset: 0x000B2F20
		[Token(Token = "0x6020253")]
		[Address(RVA = "0x1A397E0", Offset = "0x1A383E0", VA = "0x181A397E0")]
		private ROGUELIKE_TOPIC_TOGGLE_DOT_STATE _TryGetToggleDotState(PlayerRoguelikeChallengeStatus challengeStatus)
		{
			return ROGUELIKE_TOPIC_TOGGLE_DOT_STATE.LOCK;
		}

		// Token: 0x06020254 RID: 131668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020254")]
		[Address(RVA = "0x1A39880", Offset = "0x1A38480", VA = "0x181A39880")]
		public RL05TopicChallengeToggleGroup()
		{
		}

		// Token: 0x0402B6BC RID: 177852
		[Token(Token = "0x402B6BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeTopicToggleDotWithLock _toggleDotPrefab;

		// Token: 0x0402B6BD RID: 177853
		[Token(Token = "0x402B6BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _toggleLinePrefab;

		// Token: 0x0402B6BE RID: 177854
		[Token(Token = "0x402B6BE")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeTopicToggleDotWithLock> m_dots;

		// Token: 0x0402B6BF RID: 177855
		[Token(Token = "0x402B6BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402B6C0 RID: 177856
		[Token(Token = "0x402B6C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshToggles;

		// Token: 0x0402B6C1 RID: 177857
		[Token(Token = "0x402B6C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryGetToggleDotState;

		// Token: 0x0402B6C2 RID: 177858
		[Token(Token = "0x402B6C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
