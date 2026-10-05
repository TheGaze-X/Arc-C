using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200568D RID: 22157
	[Token(Token = "0x200568D")]
	public class RL04TopicChallengeToggleGroup : RoguelikeTopicChallengeToggleGroup
	{
		// Token: 0x0602081B RID: 133147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602081B")]
		[Address(RVA = "0x1AB6280", Offset = "0x1AB4E80", VA = "0x181AB6280", Slot = "4")]
		public override void Init(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x0602081C RID: 133148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602081C")]
		[Address(RVA = "0x1AB67A0", Offset = "0x1AB53A0", VA = "0x181AB67A0", Slot = "5")]
		public override void RefreshToggles(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x0602081D RID: 133149 RVA: 0x000B63B8 File Offset: 0x000B45B8
		[Token(Token = "0x602081D")]
		[Address(RVA = "0x1AB6A00", Offset = "0x1AB5600", VA = "0x181AB6A00")]
		private ROGUELIKE_TOPIC_TOGGLE_DOT_STATE _TryGetToggleDotState(PlayerRoguelikeChallengeStatus challengeStatus)
		{
			return ROGUELIKE_TOPIC_TOGGLE_DOT_STATE.LOCK;
		}

		// Token: 0x0602081E RID: 133150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602081E")]
		[Address(RVA = "0x1AB6AA0", Offset = "0x1AB56A0", VA = "0x181AB6AA0")]
		public RL04TopicChallengeToggleGroup()
		{
		}

		// Token: 0x0402C0CF RID: 180431
		[Token(Token = "0x402C0CF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeTopicToggleDotWithLock _toggleDotPrefab;

		// Token: 0x0402C0D0 RID: 180432
		[Token(Token = "0x402C0D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _toggleLinePrefab;

		// Token: 0x0402C0D1 RID: 180433
		[Token(Token = "0x402C0D1")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeTopicToggleDotWithLock> m_dots;

		// Token: 0x0402C0D2 RID: 180434
		[Token(Token = "0x402C0D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C0D3 RID: 180435
		[Token(Token = "0x402C0D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshToggles;

		// Token: 0x0402C0D4 RID: 180436
		[Token(Token = "0x402C0D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryGetToggleDotState;

		// Token: 0x0402C0D5 RID: 180437
		[Token(Token = "0x402C0D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
