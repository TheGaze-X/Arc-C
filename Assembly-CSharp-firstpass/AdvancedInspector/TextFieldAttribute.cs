using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class TextFieldAttribute : Attribute, IListAttribute
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public string Title
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public string Path
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public string Extension
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public TextFieldType Type
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return TextFieldType.Standard;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4F5540", Offset = "0x4F4140", VA = "0x1804F5540")]
		public TextFieldAttribute(TextFieldType type)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4F56C0", Offset = "0x4F42C0", VA = "0x1804F56C0")]
		public TextFieldAttribute(TextFieldType type, string title)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4F5730", Offset = "0x4F4330", VA = "0x1804F5730")]
		public TextFieldAttribute(TextFieldType type, string title, string path)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x4F55B0", Offset = "0x4F41B0", VA = "0x1804F55B0")]
		public TextFieldAttribute(TextFieldType type, string title, string path, string extension)
		{
		}

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		private const string TITLE = "Select Path...";

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		private const string PATH = "";

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		private const string EXTENSION = "";

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		private string title;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x18")]
		private string path;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x20")]
		private string extension;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x28")]
		private TextFieldType type;
	}
}
