using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection.Emit
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	public sealed class FieldBuilder : FieldInfo
	{
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x00015B88 File Offset: 0x00013D88
		[Token(Token = "0x170005A8")]
		public override FieldAttributes Attributes
		{
			[Token(Token = "0x60027AF")]
			[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "16")]
			get
			{
				return FieldAttributes.PrivateScope;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005A9")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x60027B0")]
			[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00015BA0 File Offset: 0x00013DA0
		[Token(Token = "0x170005AA")]
		public override System.RuntimeFieldHandle FieldHandle
		{
			[Token(Token = "0x60027B1")]
			[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "24")]
			get
			{
				return default(System.RuntimeFieldHandle);
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005AB")]
		public override System.Type FieldType
		{
			[Token(Token = "0x60027B2")]
			[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005AC")]
		public override string Name
		{
			[Token(Token = "0x60027B3")]
			[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005AD")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x60027B4")]
			[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60027B5")]
		[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60027B6")]
		[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "25")]
		public override object GetValue(object obj)
		{
			return null;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00015BB8 File Offset: 0x00013DB8
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x4C1D030", Offset = "0x4C1BC30", VA = "0x184C1D030", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x4C1D040", Offset = "0x4C1BC40", VA = "0x184C1D040", Slot = "27")]
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, System.Globalization.CultureInfo culture)
		{
		}
	}
}
