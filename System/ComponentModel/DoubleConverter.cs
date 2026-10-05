using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	public class DoubleConverter : BaseNumberConverter
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x1700020D")]
		internal override bool AllowHex
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020E")]
		internal override Type TargetType
		{
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x5143AC0", Offset = "0x51426C0", VA = "0x185143AC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x5143900", Offset = "0x5142500", VA = "0x185143900", Slot = "18")]
		internal override object FromString(string value, int radix)
		{
			return null;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x51439B0", Offset = "0x51425B0", VA = "0x1851439B0", Slot = "19")]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return null;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x5143A20", Offset = "0x5142620", VA = "0x185143A20", Slot = "20")]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public DoubleConverter()
		{
		}
	}
}
