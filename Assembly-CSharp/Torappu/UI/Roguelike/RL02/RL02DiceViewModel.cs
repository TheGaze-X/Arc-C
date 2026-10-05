using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200579A RID: 22426
	[Token(Token = "0x200579A")]
	public class RL02DiceViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x06020CDE RID: 134366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CDE")]
		[Address(RVA = "0x1B1DD40", Offset = "0x1B1C940", VA = "0x181B1DD40", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020CDF RID: 134367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CDF")]
		[Address(RVA = "0x1B1DF80", Offset = "0x1B1CB80", VA = "0x181B1DF80")]
		public RL02DiceViewModel()
		{
		}

		// Token: 0x06020CE0 RID: 134368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CE0")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402C931 RID: 182577
		[Token(Token = "0x402C931")]
		[FieldOffset(Offset = "0x18")]
		public string diceId;

		// Token: 0x0402C932 RID: 182578
		[Token(Token = "0x402C932")]
		[FieldOffset(Offset = "0x20")]
		public string diceDesc;

		// Token: 0x0402C933 RID: 182579
		[Token(Token = "0x402C933")]
		[FieldOffset(Offset = "0x28")]
		public int diceFaceNum;

		// Token: 0x0402C934 RID: 182580
		[Token(Token = "0x402C934")]
		[FieldOffset(Offset = "0x2C")]
		public int diceNum;

		// Token: 0x0402C935 RID: 182581
		[Token(Token = "0x402C935")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C936 RID: 182582
		[Token(Token = "0x402C936")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
