using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	public sealed class ModuleElement : ConfigurationElement
	{
		// Token: 0x06001B2D RID: 6957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x50BCF10", Offset = "0x50BBB10", VA = "0x1850BCF10")]
		public ModuleElement()
		{
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000609")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B2E")]
			[Address(RVA = "0x50BCF40", Offset = "0x50BBB40", VA = "0x1850BCF40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060A")]
		public string Type
		{
			[Token(Token = "0x6001B2F")]
			[Address(RVA = "0x50BCF70", Offset = "0x50BBB70", VA = "0x1850BCF70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B30")]
			[Address(RVA = "0x50BCFA0", Offset = "0x50BBBA0", VA = "0x1850BCFA0")]
			set
			{
			}
		}
	}
}
