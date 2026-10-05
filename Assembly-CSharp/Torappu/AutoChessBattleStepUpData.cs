using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.ObjectPool;
using XLua;

namespace Torappu
{
	// Token: 0x020005F5 RID: 1525
	[Token(Token = "0x20005F5")]
	public class AutoChessBattleStepUpData : IStreamSerialize, IReusable, IHotfixable
	{
		// Token: 0x060061F9 RID: 25081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F9")]
		[Address(RVA = "0x1DE7E20", Offset = "0x1DE6A20", VA = "0x181DE7E20")]
		public AutoChessBattleStepUpData()
		{
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FA")]
		[Address(RVA = "0x1DE7DC0", Offset = "0x1DE69C0", VA = "0x181DE7DC0", Slot = "4")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FB")]
		[Address(RVA = "0x1DE7D00", Offset = "0x1DE6900", VA = "0x181DE7D00", Slot = "5")]
		public void OnAllocate()
		{
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FC")]
		[Address(RVA = "0x1DE7D60", Offset = "0x1DE6960", VA = "0x181DE7D60", Slot = "6")]
		public void OnRecycle()
		{
		}

		// Token: 0x04002C10 RID: 11280
		[Token(Token = "0x4002C10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04002C11 RID: 11281
		[Token(Token = "0x4002C11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04002C13 RID: 11283
		[Token(Token = "0x4002C13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRecycle;
	}
}
