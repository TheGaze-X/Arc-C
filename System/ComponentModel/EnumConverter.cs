using System;
using System.Collections;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	public class EnumConverter : TypeConverter
	{
		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x24BE8D0", Offset = "0x24BD4D0", VA = "0x1824BE8D0")]
		public EnumConverter(Type type)
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DF")]
		protected Type EnumType
		{
			[Token(Token = "0x6000DB4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E0")]
		protected TypeConverter.StandardValuesCollection Values
		{
			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DB6")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x515B700", Offset = "0x515A300", VA = "0x18515B700", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x515B7F0", Offset = "0x515A3F0", VA = "0x18515B7F0", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		protected virtual IComparer Comparer
		{
			[Token(Token = "0x6000DB9")]
			[Address(RVA = "0x515CF80", Offset = "0x515BB80", VA = "0x18515CF80", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x515B8E0", Offset = "0x515A4E0", VA = "0x18515B8E0", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x515BD80", Offset = "0x515A980", VA = "0x18515BD80", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x515CB50", Offset = "0x515B750", VA = "0x18515CB50", Slot = "12")]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x515CAA0", Offset = "0x515B6A0", VA = "0x18515CAA0", Slot = "13")]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x515CF20", Offset = "0x515BB20", VA = "0x18515CF20", Slot = "15")]
		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			return default(bool);
		}

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x10")]
		private TypeConverter.StandardValuesCollection values;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x18")]
		private Type type;
	}
}
