using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RestrictAttribute : Attribute, IRestrict, IListAttribute, IRuntimeAttribute
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002478 File Offset: 0x00000678
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public RestrictDisplay Display
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return RestrictDisplay.DropDown;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4F29C0", Offset = "0x4F15C0", VA = "0x1804F29C0", Slot = "7")]
		public IList GetRestricted(object[] instances, object[] values)
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "8")]
		public RestrictDisplay GetDisplay(object[] instances, object[] values)
		{
			return RestrictDisplay.DropDown;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "9")]
		public int GetItemsPerRow(object[] instances, object[] values)
		{
			return 0;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000053")]
		public string MethodName
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000054")]
		public Type Template
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x4F31A0", Offset = "0x4F1DA0", VA = "0x1804F31A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000055")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x4F3140", Offset = "0x4F1D40", VA = "0x1804F3140", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4F2D70", Offset = "0x4F1970", VA = "0x1804F2D70")]
		public RestrictAttribute(string methodName)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4F2E50", Offset = "0x4F1A50", VA = "0x1804F2E50")]
		public RestrictAttribute(string methodName, RestrictDisplay display)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x4F2F40", Offset = "0x4F1B40", VA = "0x1804F2F40")]
		public RestrictAttribute(Delegate method)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x4F3040", Offset = "0x4F1C40", VA = "0x1804F3040")]
		public RestrictAttribute(Delegate method, RestrictDisplay display)
		{
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x10")]
		private RestrictDisplay display;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x14")]
		private int maxItemsPerRow;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x18")]
		private string methodName;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		private List<Delegate> delegates;

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600015D RID: 349
		[Token(Token = "0x200002E")]
		public delegate IList RestrictDelegate();

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000161 RID: 353
		[Token(Token = "0x200002F")]
		public delegate IList RestrictStaticDelegate(RestrictAttribute restrict, object instance, object value);
	}
}
