using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200580D RID: 22541
	[Token(Token = "0x200580D")]
	public class RL03TopicChallengeToggleDotWithLockPlugin : RoguelikeTopicToggleDotWithLockPlugin
	{
		// Token: 0x06020F25 RID: 134949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F25")]
		[Address(RVA = "0x1B53BE0", Offset = "0x1B527E0", VA = "0x181B53BE0", Slot = "4")]
		public override void Init(int dotIndex, int dotsCountPerGroup)
		{
		}

		// Token: 0x06020F26 RID: 134950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F26")]
		[Address(RVA = "0x1B53C80", Offset = "0x1B52880", VA = "0x181B53C80")]
		public RL03TopicChallengeToggleDotWithLockPlugin()
		{
		}

		// Token: 0x0402CCC0 RID: 183488
		[Token(Token = "0x402CCC0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objRightLine;

		// Token: 0x0402CCC1 RID: 183489
		[Token(Token = "0x402CCC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402CCC2 RID: 183490
		[Token(Token = "0x402CCC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
