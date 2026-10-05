using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005690 RID: 22160
	[Token(Token = "0x2005690")]
	public class RL04ChoicePlugin : RoguelikeChoicePlugin
	{
		// Token: 0x06020825 RID: 133157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020825")]
		[Address(RVA = "0x1AA4870", Offset = "0x1AA3470", VA = "0x181AA4870", Slot = "4")]
		public override RoguelikeChoiceHintFactory GetChoiceHintModelFactory()
		{
			return null;
		}

		// Token: 0x06020826 RID: 133158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020826")]
		[Address(RVA = "0x1AA4940", Offset = "0x1AA3540", VA = "0x181AA4940")]
		public RL04ChoicePlugin()
		{
		}

		// Token: 0x06020827 RID: 133159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020827")]
		[Address(RVA = "0x1A31E00", Offset = "0x1A30A00", VA = "0x181A31E00")]
		private RoguelikeChoiceHintFactory <>xLuaBaseProxy_GetChoiceHintModelFactory()
		{
			return null;
		}

		// Token: 0x0402C0DB RID: 180443
		[Token(Token = "0x402C0DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHintModelFactory;

		// Token: 0x0402C0DC RID: 180444
		[Token(Token = "0x402C0DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
