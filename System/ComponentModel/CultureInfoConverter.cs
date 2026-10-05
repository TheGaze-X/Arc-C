using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	public class CultureInfoConverter : TypeConverter
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F8")]
		private string DefaultCultureString
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x513D470", Offset = "0x513C070", VA = "0x18513D470")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x513D200", Offset = "0x513BE00", VA = "0x18513D200", Slot = "16")]
		protected virtual string GetCultureName(CultureInfo culture)
		{
			return null;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x513C3D0", Offset = "0x513AFD0", VA = "0x18513C3D0", Slot = "4")]
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return default(bool);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x513C480", Offset = "0x513B080", VA = "0x18513C480", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x513C530", Offset = "0x513B130", VA = "0x18513C530", Slot = "6")]
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x513CD90", Offset = "0x513B990", VA = "0x18513CD90", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x513D250", Offset = "0x513BE50", VA = "0x18513D250", Slot = "12")]
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "13")]
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return default(bool);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public CultureInfoConverter()
		{
		}

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x10")]
		private TypeConverter.StandardValuesCollection _values;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		private const string DefaultInvariantCultureString = "(Default)";

		// Token: 0x02000185 RID: 389
		[Token(Token = "0x2000185")]
		private class CultureComparer : IComparer
		{
			// Token: 0x060009F1 RID: 2545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public CultureComparer(CultureInfoConverter cultureConverter)
			{
			}

			// Token: 0x060009F2 RID: 2546 RVA: 0x00005CD0 File Offset: 0x00003ED0
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x513C160", Offset = "0x513AD60", VA = "0x18513C160", Slot = "4")]
			public int Compare(object item1, object item2)
			{
				return 0;
			}

			// Token: 0x04000670 RID: 1648
			[Token(Token = "0x4000670")]
			[FieldOffset(Offset = "0x10")]
			private CultureInfoConverter _converter;
		}

		// Token: 0x02000186 RID: 390
		[Token(Token = "0x2000186")]
		private static class CultureInfoMapper
		{
			// Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x513D4A0", Offset = "0x513C0A0", VA = "0x18513D4A0")]
			private static Dictionary<string, string> CreateMap()
			{
				return null;
			}

			// Token: 0x060009F4 RID: 2548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x5140DE0", Offset = "0x513F9E0", VA = "0x185140DE0")]
			public static string GetCultureInfoName(string cultureInfoDisplayName)
			{
				return null;
			}

			// Token: 0x04000671 RID: 1649
			[Token(Token = "0x4000671")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Dictionary<string, string> s_cultureInfoNameMap;
		}
	}
}
