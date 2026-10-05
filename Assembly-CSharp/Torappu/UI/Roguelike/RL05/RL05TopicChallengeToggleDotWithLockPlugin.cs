using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200556C RID: 21868
	[Token(Token = "0x200556C")]
	public class RL05TopicChallengeToggleDotWithLockPlugin : RoguelikeTopicToggleDotWithLockPlugin
	{
		// Token: 0x0602024F RID: 131663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602024F")]
		[Address(RVA = "0x1A38FB0", Offset = "0x1A37BB0", VA = "0x181A38FB0", Slot = "4")]
		public override void Init(int dotIndex, int dotsCountPerGroup)
		{
		}

		// Token: 0x06020250 RID: 131664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020250")]
		[Address(RVA = "0x1A39050", Offset = "0x1A37C50", VA = "0x181A39050")]
		public RL05TopicChallengeToggleDotWithLockPlugin()
		{
		}

		// Token: 0x0402B6B9 RID: 177849
		[Token(Token = "0x402B6B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objRightLine;

		// Token: 0x0402B6BA RID: 177850
		[Token(Token = "0x402B6BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402B6BB RID: 177851
		[Token(Token = "0x402B6BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
