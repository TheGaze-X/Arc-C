using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057AD RID: 22445
	[Token(Token = "0x20057AD")]
	public class RL01TopicChallengePluginContext : RoguelikeTopicChallengePluginContext
	{
		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x06020D43 RID: 134467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CF6")]
		public override RoguelikeTopicChallengeToggleGroup topicChallengeToggleGroupPrefab
		{
			[Token(Token = "0x6020D43")]
			[Address(RVA = "0x1B1D870", Offset = "0x1B1C470", VA = "0x181B1D870", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020D44 RID: 134468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D44")]
		[Address(RVA = "0x1B1D810", Offset = "0x1B1C410", VA = "0x181B1D810")]
		public RL01TopicChallengePluginContext()
		{
		}

		// Token: 0x0402C9B1 RID: 182705
		[Token(Token = "0x402C9B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL01TopicChallengeToggleGroup _topicChallengeTogglePrefab;

		// Token: 0x0402C9B2 RID: 182706
		[Token(Token = "0x402C9B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicChallengeToggleGroupPrefab;

		// Token: 0x0402C9B3 RID: 182707
		[Token(Token = "0x402C9B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
