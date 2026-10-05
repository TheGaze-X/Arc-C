using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class MenuAttribute : Attribute, IListAttribute, IMenu, IRuntimeAttribute
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000042")]
		public string MenuItemName
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000043")]
		public string MethodName
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000044")]
		public Type Template
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x4F1AC0", Offset = "0x4F06C0", VA = "0x1804F1AC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000045")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x4F1A60", Offset = "0x4F0660", VA = "0x1804F1A60", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x4F1630", Offset = "0x4F0230", VA = "0x1804F1630", Slot = "7")]
		public void Invoke(int index, object instance, object value)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x4F1970", Offset = "0x4F0570", VA = "0x1804F1970")]
		public MenuAttribute(string menuItemName, string methodName)
		{
		}

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x10")]
		private string menuItemName;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x18")]
		private string methodName;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x20")]
		private List<Delegate> delegates;

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x0600011C RID: 284
		[Token(Token = "0x2000025")]
		public delegate void MenuDelegate();

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000120 RID: 288
		[Token(Token = "0x2000026")]
		public delegate void MenuStaticDelegate(MenuAttribute fieldMenuItem, object instance, object value);
	}
}
