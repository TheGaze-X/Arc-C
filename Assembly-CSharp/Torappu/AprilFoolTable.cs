using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E9A RID: 3738
	[Token(Token = "0x2000E9A")]
	public class AprilFoolTable
	{
		// Token: 0x06006B6A RID: 27498 RVA: 0x00031368 File Offset: 0x0002F568
		[Token(Token = "0x6006B6A")]
		[Address(RVA = "0x1FFDF10", Offset = "0x1FFCB10", VA = "0x181FFDF10")]
		public bool ShouldSerializeact4FunData()
		{
			return default(bool);
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00031380 File Offset: 0x0002F580
		[Token(Token = "0x6006B6B")]
		[Address(RVA = "0x1FFDF70", Offset = "0x1FFCB70", VA = "0x181FFDF70")]
		public bool ShouldSerializeact5FunData()
		{
			return default(bool);
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x00031398 File Offset: 0x0002F598
		[Token(Token = "0x6006B6C")]
		[Address(RVA = "0x1FFDFD0", Offset = "0x1FFCBD0", VA = "0x181FFDFD0")]
		public bool ShouldSerializeact6FunData()
		{
			return default(bool);
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x000313B0 File Offset: 0x0002F5B0
		[Token(Token = "0x6006B6D")]
		[Address(RVA = "0x1FF9030", Offset = "0x1FF7C30", VA = "0x181FF9030")]
		public bool ShouldSerializeact7FunData()
		{
			return default(bool);
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6E")]
		[Address(RVA = "0x1FFE030", Offset = "0x1FFCC30", VA = "0x181FFE030")]
		public AprilFoolTable()
		{
		}

		// Token: 0x04004EEA RID: 20202
		[Token(Token = "0x4004EEA")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, AprilFoolStageData> stages;

		// Token: 0x04004EEB RID: 20203
		[Token(Token = "0x4004EEB")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, List<AprilFoolScoreData>> scoreDict;

		// Token: 0x04004EEC RID: 20204
		[Token(Token = "0x4004EEC")]
		[FieldOffset(Offset = "0x20")]
		public AprilFoolConst constant;

		// Token: 0x04004EED RID: 20205
		[Token(Token = "0x4004EED")]
		[FieldOffset(Offset = "0x28")]
		public Act4funData act4FunData;

		// Token: 0x04004EEE RID: 20206
		[Token(Token = "0x4004EEE")]
		[FieldOffset(Offset = "0x30")]
		public Act5FunData act5FunData;

		// Token: 0x04004EEF RID: 20207
		[Token(Token = "0x4004EEF")]
		[FieldOffset(Offset = "0x38")]
		public Act6FunData act6FunData;

		// Token: 0x04004EF0 RID: 20208
		[Token(Token = "0x4004EF0")]
		[FieldOffset(Offset = "0x40")]
		public Act7FunData act7FunData;
	}
}
