using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200555F RID: 21855
	[Token(Token = "0x200555F")]
	public class RL03RewardExtraInfoFactory : RoguelikeRewardExtraInfoFactory
	{
		// Token: 0x060201FF RID: 131583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60201FF")]
		[Address(RVA = "0x1A31680", Offset = "0x1A30280", VA = "0x181A31680", Slot = "4")]
		public override string CreateExtraInfo(RoguelikeSortItemViewStruct viewStruct)
		{
			return null;
		}

		// Token: 0x06020200 RID: 131584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020200")]
		[Address(RVA = "0x1A31AC0", Offset = "0x1A306C0", VA = "0x181A31AC0")]
		public RL03RewardExtraInfoFactory()
		{
		}

		// Token: 0x06020201 RID: 131585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020201")]
		[Address(RVA = "0x1A31A30", Offset = "0x1A30630", VA = "0x181A31A30")]
		private string <>xLuaBaseProxy_CreateExtraInfo(RoguelikeSortItemViewStruct P0)
		{
			return null;
		}

		// Token: 0x0402B65D RID: 177757
		[Token(Token = "0x402B65D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateExtraInfo;

		// Token: 0x0402B65E RID: 177758
		[Token(Token = "0x402B65E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
