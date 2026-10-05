using System;
using System.Globalization;
using System.Reflection;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public sealed class MemberAliasPropertyInfo : PropertyInfo
	{
		// Token: 0x0600038A RID: 906 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x4E389D0", Offset = "0x4E375D0", VA = "0x184E389D0")]
		public MemberAliasPropertyInfo(PropertyInfo prop, string namePrefix)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x4E38400", Offset = "0x4E37000", VA = "0x184E38400")]
		public MemberAliasPropertyInfo(PropertyInfo prop, string namePrefix, string separatorString)
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700007A")]
		public PropertyInfo AliasedProperty
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700007B")]
		public override Module Module
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x4BAB760", Offset = "0x4BAA360", VA = "0x184BAB760", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x1700007C")]
		public override int MetadataToken
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x4BAB710", Offset = "0x4BAA310", VA = "0x184BAB710", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700007D")]
		public override string Name
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700007E")]
		public override Type DeclaringType
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x4BAB620", Offset = "0x4BAA220", VA = "0x184BAB620", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700007F")]
		public override Type ReflectedType
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x4BAB7B0", Offset = "0x4BAA3B0", VA = "0x184BAB7B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000080")]
		public override Type PropertyType
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x4BAB5D0", Offset = "0x4BAA1D0", VA = "0x184BAB5D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000038FC File Offset: 0x00001AFC
		[Token(Token = "0x17000081")]
		public override PropertyAttributes Attributes
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x4E385D0", Offset = "0x4E371D0", VA = "0x184E385D0", Slot = "18")]
			get
			{
				return PropertyAttributes.None;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00003914 File Offset: 0x00001B14
		[Token(Token = "0x17000082")]
		public override bool CanRead
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x4E38AA0", Offset = "0x4E376A0", VA = "0x184E38AA0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000392C File Offset: 0x00001B2C
		[Token(Token = "0x17000083")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x4E38AF0", Offset = "0x4E376F0", VA = "0x184E38AF0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x4BAB1B0", Offset = "0x4BA9DB0", VA = "0x184BAB1B0", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x4BAB210", Offset = "0x4BA9E10", VA = "0x184BAB210", Slot = "14")]
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00003944 File Offset: 0x00001B44
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x4BAB440", Offset = "0x4BAA040", VA = "0x184BAB440", Slot = "12")]
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x4E387E0", Offset = "0x4E373E0", VA = "0x184E387E0", Slot = "21")]
		public override MethodInfo[] GetAccessors(bool nonPublic)
		{
			return null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x4E38840", Offset = "0x4E37440", VA = "0x184E38840", Slot = "23")]
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			return null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x4BAB6C0", Offset = "0x4BAA2C0", VA = "0x184BAB6C0", Slot = "17")]
		public override ParameterInfo[] GetIndexParameters()
		{
			return null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x4E388A0", Offset = "0x4E374A0", VA = "0x184E388A0", Slot = "25")]
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			return null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x4E38900", Offset = "0x4E37500", VA = "0x184E38900", Slot = "27")]
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			return null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x4E38950", Offset = "0x4E37550", VA = "0x184E38950", Slot = "29")]
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
		}

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		private const string FakeNameSeparatorString = "+";

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x10")]
		private PropertyInfo aliasedProperty;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x18")]
		private string mangledName;
	}
}
