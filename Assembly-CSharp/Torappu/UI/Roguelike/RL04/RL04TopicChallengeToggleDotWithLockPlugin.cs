using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200568C RID: 22156
	[Token(Token = "0x200568C")]
	public class RL04TopicChallengeToggleDotWithLockPlugin : RoguelikeTopicToggleDotWithLockPlugin
	{
		// Token: 0x06020819 RID: 133145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020819")]
		[Address(RVA = "0x1AB6180", Offset = "0x1AB4D80", VA = "0x181AB6180", Slot = "4")]
		public override void Init(int dotIndex, int dotsCountPerGroup)
		{
		}

		// Token: 0x0602081A RID: 133146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602081A")]
		[Address(RVA = "0x1AB6220", Offset = "0x1AB4E20", VA = "0x181AB6220")]
		public RL04TopicChallengeToggleDotWithLockPlugin()
		{
		}

		// Token: 0x0402C0CC RID: 180428
		[Token(Token = "0x402C0CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objRightLine;

		// Token: 0x0402C0CD RID: 180429
		[Token(Token = "0x402C0CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C0CE RID: 180430
		[Token(Token = "0x402C0CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
