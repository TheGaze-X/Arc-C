using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200070F RID: 1807
	[Token(Token = "0x200070F")]
	public class DefaultFinishBattleResponse : CommonFinishBattleResponse
	{
		// Token: 0x06006377 RID: 25463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006377")]
		[Address(RVA = "0x1EE9B30", Offset = "0x1EE8730", VA = "0x181EE9B30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006378")]
		[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006379")]
		[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50", Slot = "8")]
		public override List<PryResult> GetPryResults()
		{
			return null;
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600637A")]
		[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600637B")]
		[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public DefaultFinishBattleResponse()
		{
		}

		// Token: 0x04002F47 RID: 12103
		[Token(Token = "0x4002F47")]
		[FieldOffset(Offset = "0x68")]
		public float goldScale;

		// Token: 0x04002F48 RID: 12104
		[Token(Token = "0x4002F48")]
		[FieldOffset(Offset = "0x6C")]
		public float expScale;

		// Token: 0x04002F49 RID: 12105
		[Token(Token = "0x4002F49")]
		[FieldOffset(Offset = "0x70")]
		public List<CommonFinishBattleResponse.RewardModel> firstRewards;

		// Token: 0x04002F4A RID: 12106
		[Token(Token = "0x4002F4A")]
		[FieldOffset(Offset = "0x78")]
		public string[] unlockStages;

		// Token: 0x04002F4B RID: 12107
		[Token(Token = "0x4002F4B")]
		[FieldOffset(Offset = "0x80")]
		public List<PryResult> pryResult;

		// Token: 0x04002F4C RID: 12108
		[Token(Token = "0x4002F4C")]
		[FieldOffset(Offset = "0x88")]
		public List<ServiceAlertStruct> alert;

		// Token: 0x04002F4D RID: 12109
		[Token(Token = "0x4002F4D")]
		[FieldOffset(Offset = "0x90")]
		public bool suggestFriend;

		// Token: 0x04002F4E RID: 12110
		[Token(Token = "0x4002F4E")]
		[FieldOffset(Offset = "0x98")]
		public FinishBattleResponseExtraData extra;
	}
}
