using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class TabAttribute : Attribute, IRuntimeAttribute<Enum>, IRuntimeAttribute
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		public Enum Tab
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000060")]
		public string MethodName
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000061")]
		public Type Template
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x4F54E0", Offset = "0x4F40E0", VA = "0x1804F54E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000062")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x4F5480", Offset = "0x4F4080", VA = "0x1804F5480", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4F4E90", Offset = "0x4F3A90", VA = "0x1804F4E90", Slot = "7")]
		public Enum Invoke(int index, object instance, object value)
		{
			return null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4F52D0", Offset = "0x4F3ED0", VA = "0x1804F52D0")]
		public TabAttribute(object tab)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4F5200", Offset = "0x4F3E00", VA = "0x1804F5200")]
		public TabAttribute(string methodName)
		{
		}

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x10")]
		private Enum tab;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x18")]
		private string methodName;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x20")]
		private List<Delegate> delegates;

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000190 RID: 400
		[Token(Token = "0x2000036")]
		public delegate Enum DescriptorDelegate();

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000194 RID: 404
		[Token(Token = "0x2000037")]
		public delegate Enum DescriptorStaticDelegate(TabAttribute descriptor, object instance, object value);
	}
}
