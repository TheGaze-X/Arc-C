using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	public class DecimalConverter : BaseNumberConverter
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x17000200")]
		internal override bool AllowHex
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000201")]
		internal override Type TargetType
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x5142CE0", Offset = "0x51418E0", VA = "0x185142CE0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00005E98 File Offset: 0x00004098
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x51426C0", Offset = "0x51412C0", VA = "0x1851426C0", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x5142780", Offset = "0x5141380", VA = "0x185142780", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x5142B80", Offset = "0x5141780", VA = "0x185142B80", Slot = "18")]
		internal override object FromString(string value, int radix)
		{
			return null;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x5142AF0", Offset = "0x51416F0", VA = "0x185142AF0", Slot = "19")]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return null;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x5142C30", Offset = "0x5141830", VA = "0x185142C30", Slot = "20")]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return null;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public DecimalConverter()
		{
		}
	}
}
