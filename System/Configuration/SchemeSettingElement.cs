using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	public sealed class SchemeSettingElement : ConfigurationElement
	{
		// Token: 0x06001C81 RID: 7297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x50BE490", Offset = "0x50BD090", VA = "0x1850BE490")]
		public SchemeSettingElement()
		{
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x17000693")]
		public GenericUriParserOptions GenericUriParserOptions
		{
			[Token(Token = "0x6001C82")]
			[Address(RVA = "0x50BE4C0", Offset = "0x50BD0C0", VA = "0x1850BE4C0")]
			get
			{
				return GenericUriParserOptions.Default;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000694")]
		public string Name
		{
			[Token(Token = "0x6001C83")]
			[Address(RVA = "0x50BE4F0", Offset = "0x50BD0F0", VA = "0x1850BE4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000695")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001C84")]
			[Address(RVA = "0x50BE520", Offset = "0x50BD120", VA = "0x1850BE520", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
