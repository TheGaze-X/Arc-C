using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RuntimeResolveAttribute : Attribute, IListAttribute, IRuntimeAttribute<Type>, IRuntimeAttribute, IRuntimeType
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x4F3200", Offset = "0x4F1E00", VA = "0x1804F3200", Slot = "13")]
		public Type GetType(object[] instances, object[] values)
		{
			return null;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000057")]
		public string MethodName
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000058")]
		public Type Template
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4F39D0", Offset = "0x4F25D0", VA = "0x1804F39D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000059")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x4F3970", Offset = "0x4F2570", VA = "0x1804F3970", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x4F3390", Offset = "0x4F1F90", VA = "0x1804F3390", Slot = "7")]
		public Type Invoke(int index, object instance, object value)
		{
			return null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x4F3700", Offset = "0x4F2300", VA = "0x1804F3700")]
		public RuntimeResolveAttribute()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x4F37B0", Offset = "0x4F23B0", VA = "0x1804F37B0")]
		public RuntimeResolveAttribute(string methodName)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x4F3880", Offset = "0x4F2480", VA = "0x1804F3880")]
		public RuntimeResolveAttribute(Delegate method)
		{
		}

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x10")]
		private string methodName;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		private List<Delegate> delegates;

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600016F RID: 367
		[Token(Token = "0x2000031")]
		public delegate Type RuntimeResolveDelegate();

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000173 RID: 371
		[Token(Token = "0x2000032")]
		public delegate Type RuntimeResolveStaticDelegate(RuntimeResolveAttribute runtimeResolve, object instance, object value);
	}
}
