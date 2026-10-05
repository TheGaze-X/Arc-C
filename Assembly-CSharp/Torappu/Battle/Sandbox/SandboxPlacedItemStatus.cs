using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A6B RID: 10859
	[Token(Token = "0x2002A6B")]
	[Serializable]
	public class SandboxPlacedItemStatus : IHotfixable
	{
		// Token: 0x060120FF RID: 73983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120FF")]
		[Address(RVA = "0xA33FA0", Offset = "0xA32BA0", VA = "0x180A33FA0")]
		public SandboxPlacedItemStatus(SandboxPlacedItemStatusKey key, SandboxPlacedItemStatusValue value)
		{
		}

		// Token: 0x06012100 RID: 73984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012100")]
		[Address(RVA = "0xA34050", Offset = "0xA32C50", VA = "0x180A34050")]
		public static implicit operator SandboxPlacedItemStatus(PlayerSandboxV2.Dungeon.Building v)
		{
			return null;
		}

		// Token: 0x0401467E RID: 83582
		[Token(Token = "0x401467E")]
		[FieldOffset(Offset = "0x10")]
		public SandboxPlacedItemStatusKey key;

		// Token: 0x0401467F RID: 83583
		[Token(Token = "0x401467F")]
		[FieldOffset(Offset = "0x20")]
		public SandboxPlacedItemStatusValue value;

		// Token: 0x04014680 RID: 83584
		[Token(Token = "0x4014680")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04014681 RID: 83585
		[Token(Token = "0x4014681")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_op_Implicit;
	}
}
