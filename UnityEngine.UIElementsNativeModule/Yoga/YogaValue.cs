using System;
using Il2CppDummyDll;

namespace UnityEngine.Yoga
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	internal struct YogaValue
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x1700003F")]
		public YogaUnit Unit
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x566210", Offset = "0x564E10", VA = "0x180566210")]
			get
			{
				return YogaUnit.Undefined;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x17000040")]
		public float Value
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x592C440", Offset = "0x592B040", VA = "0x18592C440")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x5B513D0", Offset = "0x5B4FFD0", VA = "0x185B513D0")]
		public static YogaValue Point(float value)
		{
			return default(YogaValue);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x5B511D0", Offset = "0x5B4FDD0", VA = "0x185B511D0")]
		public bool Equals(YogaValue other)
		{
			return default(bool);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x5B51230", Offset = "0x5B4FE30", VA = "0x185B51230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x5B51320", Offset = "0x5B4FF20", VA = "0x185B51320", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x5B511B0", Offset = "0x5B4FDB0", VA = "0x185B511B0")]
		public static YogaValue Auto()
		{
			return default(YogaValue);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x5B51350", Offset = "0x5B4FF50", VA = "0x185B51350")]
		public static YogaValue Percent(float value)
		{
			return default(YogaValue);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x5B513D0", Offset = "0x5B4FFD0", VA = "0x185B513D0")]
		public static implicit operator YogaValue(float pointValue)
		{
			return default(YogaValue);
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x0")]
		private float value;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x4")]
		private YogaUnit unit;
	}
}
