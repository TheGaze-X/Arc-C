using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class ToolbarAttribute : Attribute
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		public string Name
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		public string Style
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public bool Label
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000071")]
		public bool Flexible
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x4F6210", Offset = "0x4F4E10", VA = "0x1804F6210")]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public int Priority
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x4F5EB0", Offset = "0x4F4AB0", VA = "0x1804F5EB0")]
		public ToolbarAttribute(string name)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x4F6030", Offset = "0x4F4C30", VA = "0x1804F6030")]
		public ToolbarAttribute(string name, int priority)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x4F6010", Offset = "0x4F4C10", VA = "0x1804F6010")]
		public ToolbarAttribute(string name, string style)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4F5F10", Offset = "0x4F4B10", VA = "0x1804F5F10")]
		public ToolbarAttribute(string name, string style, int priority)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x4F60D0", Offset = "0x4F4CD0", VA = "0x1804F60D0")]
		public ToolbarAttribute(string name, bool label)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4F6140", Offset = "0x4F4D40", VA = "0x1804F6140")]
		public ToolbarAttribute(string name, bool label, int priority)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4F5E90", Offset = "0x4F4A90", VA = "0x1804F5E90")]
		public ToolbarAttribute(string name, string style, bool label)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4F60A0", Offset = "0x4F4CA0", VA = "0x1804F60A0")]
		public ToolbarAttribute(string name, string style, bool label, int priority)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x4F61C0", Offset = "0x4F4DC0", VA = "0x1804F61C0")]
		public ToolbarAttribute(string name, string style, bool label, bool flexible)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4F5F40", Offset = "0x4F4B40", VA = "0x1804F5F40")]
		public ToolbarAttribute(string name, string style, bool label, bool flexible, int priority)
		{
		}

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		public const string ToolbarStyle = "Toolbar";

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x18")]
		private string style;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x20")]
		private bool label;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x21")]
		private bool flexible;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x24")]
		private int priority;
	}
}
