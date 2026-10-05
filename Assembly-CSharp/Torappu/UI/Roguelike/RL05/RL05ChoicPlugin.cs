using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200556E RID: 21870
	[Token(Token = "0x200556E")]
	public class RL05ChoicPlugin : RoguelikeChoicePlugin
	{
		// Token: 0x06020255 RID: 131669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020255")]
		[Address(RVA = "0x1A31D30", Offset = "0x1A30930", VA = "0x181A31D30", Slot = "4")]
		public override RoguelikeChoiceHintFactory GetChoiceHintModelFactory()
		{
			return null;
		}

		// Token: 0x06020256 RID: 131670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020256")]
		[Address(RVA = "0x1A31E10", Offset = "0x1A30A10", VA = "0x181A31E10")]
		public RL05ChoicPlugin()
		{
		}

		// Token: 0x06020257 RID: 131671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020257")]
		[Address(RVA = "0x1A31E00", Offset = "0x1A30A00", VA = "0x181A31E00")]
		private RoguelikeChoiceHintFactory <>xLuaBaseProxy_GetChoiceHintModelFactory()
		{
			return null;
		}

		// Token: 0x0402B6C3 RID: 177859
		[Token(Token = "0x402B6C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHintModelFactory;

		// Token: 0x0402B6C4 RID: 177860
		[Token(Token = "0x402B6C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
