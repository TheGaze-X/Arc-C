using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Date
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	public sealed class DateTimeObject
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x545B120", Offset = "0x5459D20", VA = "0x18545B120")]
		public DateTimeObject(DateTime dt)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x170000D0")]
		public DateTime Value
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x545B0C0", Offset = "0x5459CC0", VA = "0x18545B0C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x10")]
		private readonly DateTime dt;
	}
}
