using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057AE RID: 22446
	[Token(Token = "0x20057AE")]
	public class RL01TopicChallengeToggleGroup : RoguelikeTopicChallengeToggleGroup
	{
		// Token: 0x06020D45 RID: 134469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D45")]
		[Address(RVA = "0x1B1D8D0", Offset = "0x1B1C4D0", VA = "0x181B1D8D0", Slot = "4")]
		public override void Init(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x06020D46 RID: 134470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D46")]
		[Address(RVA = "0x1B1DA80", Offset = "0x1B1C680", VA = "0x181B1DA80", Slot = "5")]
		public override void RefreshToggles(RoguelikeTopicChallengeModeViewModel challengeModeViewModel)
		{
		}

		// Token: 0x06020D47 RID: 134471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D47")]
		[Address(RVA = "0x1B1DC80", Offset = "0x1B1C880", VA = "0x181B1DC80")]
		public RL01TopicChallengeToggleGroup()
		{
		}

		// Token: 0x0402C9B4 RID: 182708
		[Token(Token = "0x402C9B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EasyInstancePool _togglePool;

		// Token: 0x0402C9B5 RID: 182709
		[Token(Token = "0x402C9B5")]
		[FieldOffset(Offset = "0x20")]
		private List<RoguelikeTopicToggleDot> m_dots;

		// Token: 0x0402C9B6 RID: 182710
		[Token(Token = "0x402C9B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C9B7 RID: 182711
		[Token(Token = "0x402C9B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshToggles;

		// Token: 0x0402C9B8 RID: 182712
		[Token(Token = "0x402C9B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
