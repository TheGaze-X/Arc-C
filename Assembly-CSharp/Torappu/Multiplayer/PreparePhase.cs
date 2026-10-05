using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Multiplayer
{
	// Token: 0x0200152E RID: 5422
	[Token(Token = "0x200152E")]
	public class PreparePhase : MultiBattlePhase
	{
		// Token: 0x06007C80 RID: 31872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C80")]
		[Address(RVA = "0x284AA00", Offset = "0x2849600", VA = "0x18284AA00", Slot = "5")]
		public override void Enter()
		{
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C81")]
		[Address(RVA = "0x284AA60", Offset = "0x2849660", VA = "0x18284AA60", Slot = "6")]
		public override void Leave()
		{
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C82")]
		[Address(RVA = "0x284AAC0", Offset = "0x28496C0", VA = "0x18284AAC0")]
		public PreparePhase()
		{
		}

		// Token: 0x04007C6D RID: 31853
		[Token(Token = "0x4007C6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Enter;

		// Token: 0x04007C6E RID: 31854
		[Token(Token = "0x4007C6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Leave;

		// Token: 0x04007C6F RID: 31855
		[Token(Token = "0x4007C6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
