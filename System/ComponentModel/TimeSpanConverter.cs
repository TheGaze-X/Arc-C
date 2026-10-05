using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	public class TimeSpanConverter : TypeConverter
	{
		// Token: 0x06000CE4 RID: 3300 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x5174540", Offset = "0x5173140", VA = "0x185174540", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x51745F0", Offset = "0x51731F0", VA = "0x1851745F0", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x51746A0", Offset = "0x51732A0", VA = "0x1851746A0", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x5174830", Offset = "0x5173430", VA = "0x185174830", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public TimeSpanConverter()
		{
		}
	}
}
