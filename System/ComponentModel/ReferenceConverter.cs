using System;
using System.Collections;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public class ReferenceConverter : TypeConverter
	{
		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public ReferenceConverter(Type type)
		{
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x5162890", Offset = "0x5161490", VA = "0x185162890", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x5162940", Offset = "0x5161540", VA = "0x185162940", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x5162C00", Offset = "0x5161800", VA = "0x185162C00", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x5162FB0", Offset = "0x5161BB0", VA = "0x185162FB0", Slot = "12")]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "16")]
		protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value)
		{
			return default(bool);
		}

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_none;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x10")]
		private Type _type;

		// Token: 0x020001D9 RID: 473
		[Token(Token = "0x20001D9")]
		private class ReferenceComparer : IComparer
		{
			// Token: 0x06000CB2 RID: 3250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public ReferenceComparer(ReferenceConverter converter)
			{
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x00007128 File Offset: 0x00005328
			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x51627E0", Offset = "0x51613E0", VA = "0x1851627E0", Slot = "4")]
			public int Compare(object item1, object item2)
			{
				return 0;
			}

			// Token: 0x04000746 RID: 1862
			[Token(Token = "0x4000746")]
			[FieldOffset(Offset = "0x10")]
			private ReferenceConverter _converter;
		}
	}
}
