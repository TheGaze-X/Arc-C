using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public abstract class TypeListConverter : TypeConverter
	{
		// Token: 0x06000D0C RID: 3340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		protected TypeListConverter(Type[] types)
		{
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x5175DA0", Offset = "0x51749A0", VA = "0x185175DA0", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x5175E50", Offset = "0x5174A50", VA = "0x185175E50", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x5175F00", Offset = "0x5174B00", VA = "0x185175F00", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x5176050", Offset = "0x5174C50", VA = "0x185176050", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x51761E0", Offset = "0x5174DE0", VA = "0x1851761E0", Slot = "12")]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type[] _types;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x18")]
		private TypeConverter.StandardValuesCollection _values;
	}
}
