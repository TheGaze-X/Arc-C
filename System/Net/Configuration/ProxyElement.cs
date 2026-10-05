using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003F9 RID: 1017
	[Token(Token = "0x20003F9")]
	public sealed class ProxyElement : ConfigurationElement
	{
		// Token: 0x06001B31 RID: 6961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x50BD360", Offset = "0x50BBF60", VA = "0x1850BD360")]
		public ProxyElement()
		{
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0000BE80 File Offset: 0x0000A080
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060B")]
		public ProxyElement.AutoDetectValues AutoDetect
		{
			[Token(Token = "0x6001B32")]
			[Address(RVA = "0x50BD390", Offset = "0x50BBF90", VA = "0x1850BD390")]
			get
			{
				return ProxyElement.AutoDetectValues.False;
			}
			[Token(Token = "0x6001B33")]
			[Address(RVA = "0x50BD4B0", Offset = "0x50BC0B0", VA = "0x1850BD4B0")]
			set
			{
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0000BE98 File Offset: 0x0000A098
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060C")]
		public ProxyElement.BypassOnLocalValues BypassOnLocal
		{
			[Token(Token = "0x6001B34")]
			[Address(RVA = "0x50BD3C0", Offset = "0x50BBFC0", VA = "0x1850BD3C0")]
			get
			{
				return ProxyElement.BypassOnLocalValues.False;
			}
			[Token(Token = "0x6001B35")]
			[Address(RVA = "0x50BD4E0", Offset = "0x50BC0E0", VA = "0x1850BD4E0")]
			set
			{
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060D")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B36")]
			[Address(RVA = "0x50BD3F0", Offset = "0x50BBFF0", VA = "0x1850BD3F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060E")]
		public Uri ProxyAddress
		{
			[Token(Token = "0x6001B37")]
			[Address(RVA = "0x50BD420", Offset = "0x50BC020", VA = "0x1850BD420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B38")]
			[Address(RVA = "0x50BD510", Offset = "0x50BC110", VA = "0x1850BD510")]
			set
			{
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060F")]
		public Uri ScriptLocation
		{
			[Token(Token = "0x6001B39")]
			[Address(RVA = "0x50BD450", Offset = "0x50BC050", VA = "0x1850BD450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x50BD540", Offset = "0x50BC140", VA = "0x1850BD540")]
			set
			{
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000610")]
		public ProxyElement.UseSystemDefaultValues UseSystemDefault
		{
			[Token(Token = "0x6001B3B")]
			[Address(RVA = "0x50BD480", Offset = "0x50BC080", VA = "0x1850BD480")]
			get
			{
				return ProxyElement.UseSystemDefaultValues.False;
			}
			[Token(Token = "0x6001B3C")]
			[Address(RVA = "0x50BD570", Offset = "0x50BC170", VA = "0x1850BD570")]
			set
			{
			}
		}

		// Token: 0x020003FA RID: 1018
		[Token(Token = "0x20003FA")]
		public enum AutoDetectValues
		{
			// Token: 0x0400114A RID: 4426
			[Token(Token = "0x400114A")]
			False,
			// Token: 0x0400114B RID: 4427
			[Token(Token = "0x400114B")]
			True,
			// Token: 0x0400114C RID: 4428
			[Token(Token = "0x400114C")]
			Unspecified = -1
		}

		// Token: 0x020003FB RID: 1019
		[Token(Token = "0x20003FB")]
		public enum BypassOnLocalValues
		{
			// Token: 0x0400114E RID: 4430
			[Token(Token = "0x400114E")]
			False,
			// Token: 0x0400114F RID: 4431
			[Token(Token = "0x400114F")]
			True,
			// Token: 0x04001150 RID: 4432
			[Token(Token = "0x4001150")]
			Unspecified = -1
		}

		// Token: 0x020003FC RID: 1020
		[Token(Token = "0x20003FC")]
		public enum UseSystemDefaultValues
		{
			// Token: 0x04001152 RID: 4434
			[Token(Token = "0x4001152")]
			False,
			// Token: 0x04001153 RID: 4435
			[Token(Token = "0x4001153")]
			True,
			// Token: 0x04001154 RID: 4436
			[Token(Token = "0x4001154")]
			Unspecified = -1
		}
	}
}
