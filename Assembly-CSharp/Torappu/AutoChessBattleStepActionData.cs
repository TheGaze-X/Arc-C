using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.ObjectPool;
using XLua;

namespace Torappu
{
	// Token: 0x020005F4 RID: 1524
	[Token(Token = "0x20005F4")]
	public class AutoChessBattleStepActionData : IStreamDeserialize, IStreamSerialize, IReusable, IHotfixable
	{
		// Token: 0x060061F4 RID: 25076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F4")]
		[Address(RVA = "0x1DE7860", Offset = "0x1DE6460", VA = "0x181DE7860")]
		public AutoChessBattleStepActionData()
		{
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F5")]
		[Address(RVA = "0x1DE7620", Offset = "0x1DE6220", VA = "0x181DE7620", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F6")]
		[Address(RVA = "0x1DE7700", Offset = "0x1DE6300", VA = "0x181DE7700", Slot = "5")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x060061F7 RID: 25079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F7")]
		[Address(RVA = "0x1DE7540", Offset = "0x1DE6140", VA = "0x181DE7540", Slot = "6")]
		public void OnAllocate()
		{
		}

		// Token: 0x060061F8 RID: 25080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F8")]
		[Address(RVA = "0x1DE75A0", Offset = "0x1DE61A0", VA = "0x181DE75A0", Slot = "7")]
		public void OnRecycle()
		{
		}

		// Token: 0x04002C08 RID: 11272
		[Token(Token = "0x4002C08")]
		[FieldOffset(Offset = "0x10")]
		public int playerUidIndex;

		// Token: 0x04002C09 RID: 11273
		[Token(Token = "0x4002C09")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessBattleStepActionOperate operate;

		// Token: 0x04002C0A RID: 11274
		[Token(Token = "0x4002C0A")]
		[FieldOffset(Offset = "0x18")]
		public List<int> paramList;

		// Token: 0x04002C0B RID: 11275
		[Token(Token = "0x4002C0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04002C0C RID: 11276
		[Token(Token = "0x4002C0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRecycle;
	}
}
