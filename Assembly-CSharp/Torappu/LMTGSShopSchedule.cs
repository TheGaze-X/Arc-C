using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200130B RID: 4875
	[Token(Token = "0x200130B")]
	public class LMTGSShopSchedule
	{
		// Token: 0x06007284 RID: 29316 RVA: 0x00032E50 File Offset: 0x00031050
		[Token(Token = "0x6007284")]
		[Address(RVA = "0x1FFE4D0", Offset = "0x1FFD0D0", VA = "0x181FFE4D0")]
		public bool ShouldSerializestoreTextColor()
		{
			return default(bool);
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007285")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LMTGSShopSchedule()
		{
		}

		// Token: 0x04006C08 RID: 27656
		[Token(Token = "0x4006C08")]
		[FieldOffset(Offset = "0x10")]
		public string gachaPoolId;

		// Token: 0x04006C09 RID: 27657
		[Token(Token = "0x4006C09")]
		[FieldOffset(Offset = "0x18")]
		public string LMTGSId;

		// Token: 0x04006C0A RID: 27658
		[Token(Token = "0x4006C0A")]
		[FieldOffset(Offset = "0x20")]
		public string iconColor;

		// Token: 0x04006C0B RID: 27659
		[Token(Token = "0x4006C0B")]
		[FieldOffset(Offset = "0x28")]
		public string iconBackColor;

		// Token: 0x04006C0C RID: 27660
		[Token(Token = "0x4006C0C")]
		[FieldOffset(Offset = "0x30")]
		public string storeTextColor;

		// Token: 0x04006C0D RID: 27661
		[Token(Token = "0x4006C0D")]
		[FieldOffset(Offset = "0x38")]
		public long startTime;

		// Token: 0x04006C0E RID: 27662
		[Token(Token = "0x4006C0E")]
		[FieldOffset(Offset = "0x40")]
		public long endTime;
	}
}
