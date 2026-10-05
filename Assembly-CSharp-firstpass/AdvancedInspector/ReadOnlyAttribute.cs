using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class ReadOnlyAttribute : Attribute, IReadOnly, IListAttribute, IRuntimeAttribute<bool>, IRuntimeAttribute
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002430 File Offset: 0x00000630
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public bool Condition
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004D")]
		public string MethodName
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004E")]
		public Type Template
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x4F2960", Offset = "0x4F1560", VA = "0x1804F2960", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004F")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x4F2900", Offset = "0x4F1500", VA = "0x1804F2900", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4F1ED0", Offset = "0x4F0AD0", VA = "0x1804F1ED0", Slot = "8")]
		public bool Invoke(int index, object instance, object value)
		{
			return default(bool);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4F2290", Offset = "0x4F0E90", VA = "0x1804F2290", Slot = "7")]
		public bool IsReadOnly(object[] instances, object[] values)
		{
			return default(bool);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4F25C0", Offset = "0x4F11C0", VA = "0x1804F25C0")]
		public ReadOnlyAttribute()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x4F2750", Offset = "0x4F1350", VA = "0x1804F2750")]
		public ReadOnlyAttribute(bool condition)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4F2810", Offset = "0x4F1410", VA = "0x1804F2810")]
		public ReadOnlyAttribute(Delegate method)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4F23D0", Offset = "0x4F0FD0", VA = "0x1804F23D0")]
		public ReadOnlyAttribute(Delegate method, bool condition)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4F2670", Offset = "0x4F1270", VA = "0x1804F2670")]
		public ReadOnlyAttribute(string methodName)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4F24D0", Offset = "0x4F10D0", VA = "0x1804F24D0")]
		public ReadOnlyAttribute(string methodName, bool condition)
		{
		}

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		private bool condition;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x18")]
		private string methodName;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x20")]
		private List<Delegate> delegates;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000145 RID: 325
		[Token(Token = "0x200002B")]
		public delegate bool ReadOnlyDelegate();

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000149 RID: 329
		[Token(Token = "0x200002C")]
		public delegate bool ReadOnlyStaticDelegate(ReadOnlyAttribute readOnly, object instance, object value);
	}
}
