using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public abstract class BaseNumberConverter : TypeConverter
	{
		// Token: 0x0600096E RID: 2414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		internal BaseNumberConverter()
		{
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x170001D8")]
		internal virtual bool AllowHex
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000970 RID: 2416
		[Token(Token = "0x170001D9")]
		internal abstract Type TargetType { [Token(Token = "0x6000970")] get; }

		// Token: 0x06000971 RID: 2417
		[Token(Token = "0x6000971")]
		internal abstract object FromString(string value, int radix);

		// Token: 0x06000972 RID: 2418
		[Token(Token = "0x6000972")]
		internal abstract object FromString(string value, NumberFormatInfo formatInfo);

		// Token: 0x06000973 RID: 2419
		[Token(Token = "0x6000973")]
		internal abstract string ToString(object value, NumberFormatInfo formatInfo);

		// Token: 0x06000974 RID: 2420 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x5139920", Offset = "0x5138520", VA = "0x185139920", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x5139A10", Offset = "0x5138610", VA = "0x185139A10", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x5139DA0", Offset = "0x51389A0", VA = "0x185139DA0", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x51399D0", Offset = "0x51385D0", VA = "0x1851399D0", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}
	}
}
