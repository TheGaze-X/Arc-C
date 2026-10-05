using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	public class DateTimeConverter : TypeConverter
	{
		// Token: 0x06000A1C RID: 2588 RVA: 0x00005E50 File Offset: 0x00004050
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x5141EB0", Offset = "0x5140AB0", VA = "0x185141EB0", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x5141F60", Offset = "0x5140B60", VA = "0x185141F60", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x5142010", Offset = "0x5140C10", VA = "0x185142010", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x51422C0", Offset = "0x5140EC0", VA = "0x1851422C0", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public DateTimeConverter()
		{
		}
	}
}
