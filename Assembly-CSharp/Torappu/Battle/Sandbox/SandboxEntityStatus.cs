using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A6F RID: 10863
	[Token(Token = "0x2002A6F")]
	[Serializable]
	public class SandboxEntityStatus : IHotfixable
	{
		// Token: 0x06012106 RID: 73990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012106")]
		[Address(RVA = "0xA2C5B0", Offset = "0xA2B1B0", VA = "0x180A2C5B0")]
		public SandboxEntityStatus(SandboxEntityStatusKey key, SandboxEntityStatusValue value)
		{
		}

		// Token: 0x06012107 RID: 73991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012107")]
		[Address(RVA = "0xA2C660", Offset = "0xA2B260", VA = "0x180A2C660")]
		public static implicit operator SandboxEntityStatus(PlayerSandboxV2.Dungeon.EntityStatus v)
		{
			return null;
		}

		// Token: 0x06012108 RID: 73992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012108")]
		[Address(RVA = "0xA2C4D0", Offset = "0xA2B0D0", VA = "0x180A2C4D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06012109 RID: 73993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012109")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x04014687 RID: 83591
		[Token(Token = "0x4014687")]
		[FieldOffset(Offset = "0x10")]
		public SandboxEntityStatusKey key;

		// Token: 0x04014688 RID: 83592
		[Token(Token = "0x4014688")]
		[FieldOffset(Offset = "0x20")]
		public SandboxEntityStatusValue value;

		// Token: 0x04014689 RID: 83593
		[Token(Token = "0x4014689")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401468A RID: 83594
		[Token(Token = "0x401468A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_op_Implicit;

		// Token: 0x0401468B RID: 83595
		[Token(Token = "0x401468B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToString;
	}
}
