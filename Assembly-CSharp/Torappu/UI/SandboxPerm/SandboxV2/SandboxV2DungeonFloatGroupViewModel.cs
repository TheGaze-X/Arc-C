using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042DD RID: 17117
	[Token(Token = "0x20042DD")]
	public class SandboxV2DungeonFloatGroupViewModel : IHotfixable
	{
		// Token: 0x0601A53D RID: 107837 RVA: 0x000A1430 File Offset: 0x0009F630
		[Token(Token = "0x601A53D")]
		[Address(RVA = "0x132D640", Offset = "0x132C240", VA = "0x18132D640")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601A53E RID: 107838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A53E")]
		[Address(RVA = "0x132D4C0", Offset = "0x132C0C0", VA = "0x18132D4C0")]
		public void Clear()
		{
		}

		// Token: 0x0601A53F RID: 107839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A53F")]
		[Address(RVA = "0x132D3F0", Offset = "0x132BFF0", VA = "0x18132D3F0")]
		public void AddFloat(SandboxV2DungeonFloatViewModel floatViewModel)
		{
		}

		// Token: 0x0601A540 RID: 107840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A540")]
		[Address(RVA = "0x132D6C0", Offset = "0x132C2C0", VA = "0x18132D6C0")]
		public SandboxV2DungeonFloatGroupViewModel()
		{
		}

		// Token: 0x0402160C RID: 136716
		[Token(Token = "0x402160C")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2DungeonFloatViewModel> floatList;

		// Token: 0x0402160D RID: 136717
		[Token(Token = "0x402160D")]
		[FieldOffset(Offset = "0x18")]
		public List<string> floatKeys;

		// Token: 0x0402160E RID: 136718
		[Token(Token = "0x402160E")]
		[FieldOffset(Offset = "0x20")]
		public bool isEnemyRush;

		// Token: 0x0402160F RID: 136719
		[Token(Token = "0x402160F")]
		[FieldOffset(Offset = "0x24")]
		public int stackCount;

		// Token: 0x04021610 RID: 136720
		[Token(Token = "0x4021610")]
		[FieldOffset(Offset = "0x28")]
		public float hpRatio;

		// Token: 0x04021611 RID: 136721
		[Token(Token = "0x4021611")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04021612 RID: 136722
		[Token(Token = "0x4021612")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04021613 RID: 136723
		[Token(Token = "0x4021613")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddFloat;

		// Token: 0x04021614 RID: 136724
		[Token(Token = "0x4021614")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
