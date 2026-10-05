using System;
using System.Globalization;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public sealed class MemberAliasFieldInfo : FieldInfo
	{
		// Token: 0x06000369 RID: 873 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x4E384B0", Offset = "0x4E370B0", VA = "0x184E384B0")]
		public MemberAliasFieldInfo(FieldInfo field, string namePrefix)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x4E38400", Offset = "0x4E37000", VA = "0x184E38400")]
		public MemberAliasFieldInfo(FieldInfo field, string namePrefix, string separatorString)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000069")]
		public FieldInfo AliasedField
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700006A")]
		public override Module Module
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x4BAB760", Offset = "0x4BAA360", VA = "0x184BAB760", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x1700006B")]
		public override int MetadataToken
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x4BAB710", Offset = "0x4BAA310", VA = "0x184BAB710", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700006C")]
		public override string Name
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700006D")]
		public override Type DeclaringType
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x4BAB620", Offset = "0x4BAA220", VA = "0x184BAB620", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700006E")]
		public override Type ReflectedType
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x4BAB7B0", Offset = "0x4BAA3B0", VA = "0x184BAB7B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700006F")]
		public override Type FieldType
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x4BAB6C0", Offset = "0x4BAA2C0", VA = "0x184BAB6C0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x17000070")]
		public override RuntimeFieldHandle FieldHandle
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x4BAB670", Offset = "0x4BAA270", VA = "0x184BAB670", Slot = "24")]
			get
			{
				return default(RuntimeFieldHandle);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x17000071")]
		public override FieldAttributes Attributes
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x4BAB5D0", Offset = "0x4BAA1D0", VA = "0x184BAB5D0", Slot = "16")]
			get
			{
				return FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x4BAB1B0", Offset = "0x4BA9DB0", VA = "0x184BAB1B0", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x4BAB210", Offset = "0x4BA9E10", VA = "0x184BAB210", Slot = "14")]
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x4BAB440", Offset = "0x4BAA040", VA = "0x184BAB440", Slot = "12")]
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x3DD3E40", Offset = "0x3DD2A40", VA = "0x183DD3E40", Slot = "25")]
		public override object GetValue(object obj)
		{
			return null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x4E38380", Offset = "0x4E36F80", VA = "0x184E38380", Slot = "27")]
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
		}

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		private const string FAKE_NAME_SEPARATOR_STRING = "+";

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x10")]
		private FieldInfo aliasedField;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x18")]
		private string mangledName;
	}
}
