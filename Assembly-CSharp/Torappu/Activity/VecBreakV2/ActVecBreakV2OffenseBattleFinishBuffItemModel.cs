using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DF4 RID: 28148
	[Token(Token = "0x2006DF4")]
	public class ActVecBreakV2OffenseBattleFinishBuffItemModel : IHotfixable
	{
		// Token: 0x06028135 RID: 164149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028135")]
		[Address(RVA = "0x2351050", Offset = "0x234FC50", VA = "0x182351050")]
		public void LoadData(string buffId, ActVecBreakV2Data actData)
		{
		}

		// Token: 0x06028136 RID: 164150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028136")]
		[Address(RVA = "0x2351160", Offset = "0x234FD60", VA = "0x182351160")]
		public ActVecBreakV2OffenseBattleFinishBuffItemModel()
		{
		}

		// Token: 0x04038DA2 RID: 232866
		[Token(Token = "0x4038DA2")]
		[FieldOffset(Offset = "0x10")]
		public bool isEmpty;

		// Token: 0x04038DA3 RID: 232867
		[Token(Token = "0x4038DA3")]
		[FieldOffset(Offset = "0x18")]
		public string buffId;

		// Token: 0x04038DA4 RID: 232868
		[Token(Token = "0x4038DA4")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04038DA5 RID: 232869
		[Token(Token = "0x4038DA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038DA6 RID: 232870
		[Token(Token = "0x4038DA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
