using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ConstructorAttribute : Attribute, IRuntimeAttribute<object>, IRuntimeAttribute
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000016")]
		public string MethodName
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000017")]
		public Type Template
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x4EC610", Offset = "0x4EB210", VA = "0x1804EC610", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000018")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x4EC5B0", Offset = "0x4EB1B0", VA = "0x1804EC5B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4EC090", Offset = "0x4EAC90", VA = "0x1804EC090", Slot = "7")]
		public object Invoke(int index, object instance, object value)
		{
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4EC4D0", Offset = "0x4EB0D0", VA = "0x1804EC4D0")]
		public ConstructorAttribute(string methodName)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4EC3E0", Offset = "0x4EAFE0", VA = "0x1804EC3E0")]
		public ConstructorAttribute(Delegate method)
		{
		}

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		private string methodName;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		private List<Delegate> delegates;

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000064 RID: 100
		[Token(Token = "0x200000E")]
		public delegate object ConstructorDelegate();

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000068 RID: 104
		[Token(Token = "0x200000F")]
		public delegate object ConstructorStaticDelegate(ConstructorAttribute constructor, object instance, object value);
	}
}
