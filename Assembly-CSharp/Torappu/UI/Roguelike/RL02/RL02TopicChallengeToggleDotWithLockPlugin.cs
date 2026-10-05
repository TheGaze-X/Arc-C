using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200572F RID: 22319
	[Token(Token = "0x200572F")]
	public class RL02TopicChallengeToggleDotWithLockPlugin : RoguelikeTopicToggleDotWithLockPlugin
	{
		// Token: 0x06020B6F RID: 133999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B6F")]
		[Address(RVA = "0x1B0E1D0", Offset = "0x1B0CDD0", VA = "0x181B0E1D0", Slot = "4")]
		public override void Init(int dotIndex, int dotsCountPerGroup)
		{
		}

		// Token: 0x06020B70 RID: 134000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B70")]
		[Address(RVA = "0x1B0E270", Offset = "0x1B0CE70", VA = "0x181B0E270")]
		public RL02TopicChallengeToggleDotWithLockPlugin()
		{
		}

		// Token: 0x0402C677 RID: 181879
		[Token(Token = "0x402C677")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objRightLine;

		// Token: 0x0402C678 RID: 181880
		[Token(Token = "0x402C678")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C679 RID: 181881
		[Token(Token = "0x402C679")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
