using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection.Emit
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	public sealed class DynamicMethod : MethodInfo
	{
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x00015A68 File Offset: 0x00013C68
		[Token(Token = "0x1700059A")]
		public override MethodAttributes Attributes
		{
			[Token(Token = "0x600277F")]
			[Address(RVA = "0x4C1C040", Offset = "0x4C1AC40", VA = "0x184C1C040", Slot = "17")]
			get
			{
				return MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700059B")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x6002780")]
			[Address(RVA = "0x4C1C090", Offset = "0x4C1AC90", VA = "0x184C1C090", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700059C")]
		public override string Name
		{
			[Token(Token = "0x6002781")]
			[Address(RVA = "0x4C1C130", Offset = "0x4C1AD30", VA = "0x184C1C130", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x4C1BF50", Offset = "0x4C1AB50", VA = "0x184C1BF50", Slot = "16")]
		public override ParameterInfo[] GetParameters()
		{
			return null;
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x00015A80 File Offset: 0x00013C80
		[Token(Token = "0x1700059D")]
		public override System.RuntimeMethodHandle MethodHandle
		{
			[Token(Token = "0x6002783")]
			[Address(RVA = "0x4C1C0E0", Offset = "0x4C1ACE0", VA = "0x184C1C0E0", Slot = "34")]
			get
			{
				return default(System.RuntimeMethodHandle);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700059E")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x6002784")]
			[Address(RVA = "0x4C1C180", Offset = "0x4C1AD80", VA = "0x184C1C180", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700059F")]
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			[Token(Token = "0x6002785")]
			[Address(RVA = "0x4C1C1D0", Offset = "0x4C1ADD0", VA = "0x184C1C1D0", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x4C1BEB0", Offset = "0x4C1AAB0", VA = "0x184C1BEB0", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x4C1BE60", Offset = "0x4C1AA60", VA = "0x184C1BE60", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00015A98 File Offset: 0x00013C98
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x4C1BF00", Offset = "0x4C1AB00", VA = "0x184C1BF00", Slot = "18")]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.IL;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x4C1BE10", Offset = "0x4C1AA10", VA = "0x184C1BE10", Slot = "45")]
		public override MethodInfo GetBaseDefinition()
		{
			return null;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x4C1BFA0", Offset = "0x4C1ABA0", VA = "0x184C1BFA0", Slot = "33")]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00015AB0 File Offset: 0x00013CB0
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x4C1BFF0", Offset = "0x4C1ABF0", VA = "0x184C1BFF0", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}
	}
}
