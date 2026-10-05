using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020012CB RID: 4811
	[Token(Token = "0x20012CB")]
	public class SandboxV2MonthRushData : ITimeValidInfo, IHotfixable
	{
		// Token: 0x06007244 RID: 29252 RVA: 0x00032D48 File Offset: 0x00030F48
		[Token(Token = "0x6007244")]
		[Address(RVA = "0x2210390", Offset = "0x220EF90", VA = "0x182210390", Slot = "4")]
		public long GetStartTs()
		{
			return 0L;
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x00032D60 File Offset: 0x00030F60
		[Token(Token = "0x6007245")]
		[Address(RVA = "0x2210330", Offset = "0x220EF30", VA = "0x182210330", Slot = "5")]
		public long GetEndTs()
		{
			return 0L;
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007246")]
		[Address(RVA = "0x22103F0", Offset = "0x220EFF0", VA = "0x1822103F0")]
		public SandboxV2MonthRushData()
		{
		}

		// Token: 0x04006A44 RID: 27204
		[Token(Token = "0x4006A44")]
		[FieldOffset(Offset = "0x10")]
		public string monthlyRushId;

		// Token: 0x04006A45 RID: 27205
		[Token(Token = "0x4006A45")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x04006A46 RID: 27206
		[Token(Token = "0x4006A46")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x04006A47 RID: 27207
		[Token(Token = "0x4006A47")]
		[FieldOffset(Offset = "0x28")]
		public bool isLast;

		// Token: 0x04006A48 RID: 27208
		[Token(Token = "0x4006A48")]
		[FieldOffset(Offset = "0x2C")]
		public int sortId;

		// Token: 0x04006A49 RID: 27209
		[Token(Token = "0x4006A49")]
		[FieldOffset(Offset = "0x30")]
		public string rushGroupKey;

		// Token: 0x04006A4A RID: 27210
		[Token(Token = "0x4006A4A")]
		[FieldOffset(Offset = "0x38")]
		public string monthlyRushName;

		// Token: 0x04006A4B RID: 27211
		[Token(Token = "0x4006A4B")]
		[FieldOffset(Offset = "0x40")]
		public string monthlyRushDes;

		// Token: 0x04006A4C RID: 27212
		[Token(Token = "0x4006A4C")]
		[FieldOffset(Offset = "0x48")]
		public string weatherId;

		// Token: 0x04006A4D RID: 27213
		[Token(Token = "0x4006A4D")]
		[FieldOffset(Offset = "0x50")]
		public string nodeId;

		// Token: 0x04006A4E RID: 27214
		[Token(Token = "0x4006A4E")]
		[FieldOffset(Offset = "0x58")]
		public string conditionGroup;

		// Token: 0x04006A4F RID: 27215
		[Token(Token = "0x4006A4F")]
		[FieldOffset(Offset = "0x60")]
		public string conditionDesc;

		// Token: 0x04006A50 RID: 27216
		[Token(Token = "0x4006A50")]
		[FieldOffset(Offset = "0x68")]
		public List<ItemBundle> rewardItemList;

		// Token: 0x04006A51 RID: 27217
		[Token(Token = "0x4006A51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetStartTs;

		// Token: 0x04006A52 RID: 27218
		[Token(Token = "0x4006A52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEndTs;

		// Token: 0x04006A53 RID: 27219
		[Token(Token = "0x4006A53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
