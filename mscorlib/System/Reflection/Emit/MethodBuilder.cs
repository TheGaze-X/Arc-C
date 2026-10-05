using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection.Emit
{
	// Token: 0x0200054C RID: 1356
	[Token(Token = "0x200054C")]
	public sealed class MethodBuilder : MethodInfo
	{
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x00015C90 File Offset: 0x00013E90
		[Token(Token = "0x170005B6")]
		public override MethodAttributes Attributes
		{
			[Token(Token = "0x60027DD")]
			[Address(RVA = "0x4C1DF10", Offset = "0x4C1CB10", VA = "0x184C1DF10", Slot = "17")]
			get
			{
				return MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005B7")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x60027DE")]
			[Address(RVA = "0x4C1DF60", Offset = "0x4C1CB60", VA = "0x184C1DF60", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x00015CA8 File Offset: 0x00013EA8
		[Token(Token = "0x170005B8")]
		public override System.RuntimeMethodHandle MethodHandle
		{
			[Token(Token = "0x60027DF")]
			[Address(RVA = "0x4C1DFB0", Offset = "0x4C1CBB0", VA = "0x184C1DFB0", Slot = "34")]
			get
			{
				return default(System.RuntimeMethodHandle);
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005B9")]
		public override string Name
		{
			[Token(Token = "0x60027E0")]
			[Address(RVA = "0x4C1E000", Offset = "0x4C1CC00", VA = "0x184C1E000", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005BA")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x60027E1")]
			[Address(RVA = "0x4C1E050", Offset = "0x4C1CC50", VA = "0x184C1E050", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005BB")]
		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			[Token(Token = "0x60027E2")]
			[Address(RVA = "0x4C1E0A0", Offset = "0x4C1CCA0", VA = "0x184C1E0A0", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x4C1DCE0", Offset = "0x4C1C8E0", VA = "0x184C1DCE0", Slot = "45")]
		public override MethodInfo GetBaseDefinition()
		{
			return null;
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x4C1DD30", Offset = "0x4C1C930", VA = "0x184C1DD30", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x4C1DD80", Offset = "0x4C1C980", VA = "0x184C1DD80", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00015CC0 File Offset: 0x00013EC0
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x4C1DDD0", Offset = "0x4C1C9D0", VA = "0x184C1DDD0", Slot = "18")]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.IL;
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x4C1DE20", Offset = "0x4C1CA20", VA = "0x184C1DE20", Slot = "16")]
		public override ParameterInfo[] GetParameters()
		{
			return null;
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x4C1DE70", Offset = "0x4C1CA70", VA = "0x184C1DE70", Slot = "33")]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x4C1DEC0", Offset = "0x4C1CAC0", VA = "0x184C1DEC0", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}
	}
}
