using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection.Emit
{
	// Token: 0x02000544 RID: 1348
	[Token(Token = "0x2000544")]
	public class ConstructorBuilder : ConstructorInfo
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x00015A08 File Offset: 0x00013C08
		[Token(Token = "0x17000595")]
		public override MethodAttributes Attributes
		{
			[Token(Token = "0x6002773")]
			[Address(RVA = "0x4C10B40", Offset = "0x4C0F740", VA = "0x184C10B40", Slot = "17")]
			get
			{
				return MethodAttributes.PrivateScope;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000596")]
		public override System.Type DeclaringType
		{
			[Token(Token = "0x6002774")]
			[Address(RVA = "0x4C10B90", Offset = "0x4C0F790", VA = "0x184C10B90", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000597")]
		public override string Name
		{
			[Token(Token = "0x6002775")]
			[Address(RVA = "0x4C10C30", Offset = "0x4C0F830", VA = "0x184C10C30", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002776")]
		[Address(RVA = "0x4C10A00", Offset = "0x4C0F600", VA = "0x184C10A00", Slot = "16")]
		public override ParameterInfo[] GetParameters()
		{
			return null;
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00015A20 File Offset: 0x00013C20
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x4C109B0", Offset = "0x4C0F5B0", VA = "0x184C109B0", Slot = "18")]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.IL;
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x00015A38 File Offset: 0x00013C38
		[Token(Token = "0x17000598")]
		public override System.RuntimeMethodHandle MethodHandle
		{
			[Token(Token = "0x6002778")]
			[Address(RVA = "0x4C10BE0", Offset = "0x4C0F7E0", VA = "0x184C10BE0", Slot = "34")]
			get
			{
				return default(System.RuntimeMethodHandle);
			}
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x4C10AA0", Offset = "0x4C0F6A0", VA = "0x184C10AA0", Slot = "41")]
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00015A50 File Offset: 0x00013C50
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x4C10AF0", Offset = "0x4C0F6F0", VA = "0x184C10AF0", Slot = "12")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600277B")]
		[Address(RVA = "0x4C10910", Offset = "0x4C0F510", VA = "0x184C10910", Slot = "13")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600277C")]
		[Address(RVA = "0x4C10960", Offset = "0x4C0F560", VA = "0x184C10960", Slot = "14")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000599")]
		public override System.Type ReflectedType
		{
			[Token(Token = "0x600277D")]
			[Address(RVA = "0x4C10C80", Offset = "0x4C0F880", VA = "0x184C10C80", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x4C10A50", Offset = "0x4C0F650", VA = "0x184C10A50", Slot = "33")]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, System.Globalization.CultureInfo culture)
		{
			return null;
		}
	}
}
