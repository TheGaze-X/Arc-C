using System;
using System.Globalization;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public sealed class MemberAliasMethodInfo : MethodInfo
	{
		// Token: 0x06000379 RID: 889 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x4E38670", Offset = "0x4E37270", VA = "0x184E38670")]
		public MemberAliasMethodInfo(MethodInfo method, string namePrefix)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x4E38400", Offset = "0x4E37000", VA = "0x184E38400")]
		public MemberAliasMethodInfo(MethodInfo method, string namePrefix, string separatorString)
		{
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000072")]
		public MethodInfo AliasedMethod
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000073")]
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0xFEAA60", Offset = "0xFE9660", VA = "0x180FEAA60", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x17000074")]
		public override RuntimeMethodHandle MethodHandle
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x4E38740", Offset = "0x4E37340", VA = "0x184E38740", Slot = "34")]
			get
			{
				return default(RuntimeMethodHandle);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x17000075")]
		public override MethodAttributes Attributes
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x4BAB6C0", Offset = "0x4BAA2C0", VA = "0x184BAB6C0", Slot = "17")]
			get
			{
				return MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000076")]
		public override Type ReturnType
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x4E38790", Offset = "0x4E37390", VA = "0x184E38790", Slot = "42")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000077")]
		public override Type DeclaringType
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x4BAB620", Offset = "0x4BAA220", VA = "0x184BAB620", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000078")]
		public override string Name
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000079")]
		public override Type ReflectedType
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x4BAB7B0", Offset = "0x4BAA3B0", VA = "0x184BAB7B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x4E38580", Offset = "0x4E37180", VA = "0x184E38580", Slot = "45")]
		public override MethodInfo GetBaseDefinition()
		{
			return null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x4BAB1B0", Offset = "0x4BA9DB0", VA = "0x184BAB1B0", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x4BAB210", Offset = "0x4BA9E10", VA = "0x184BAB210", Slot = "14")]
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x4E385D0", Offset = "0x4E371D0", VA = "0x184E385D0", Slot = "18")]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.IL;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x4BAB5D0", Offset = "0x4BAA1D0", VA = "0x184BAB5D0", Slot = "16")]
		public override ParameterInfo[] GetParameters()
		{
			return null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x4E38620", Offset = "0x4E37220", VA = "0x184E38620", Slot = "33")]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			return null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000038CC File Offset: 0x00001ACC
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x4BAB440", Offset = "0x4BAA040", VA = "0x184BAB440", Slot = "12")]
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		private const string FAKE_NAME_SEPARATOR_STRING = "+";

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x10")]
		private MethodInfo aliasedMethod;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x18")]
		private string mangledName;
	}
}
