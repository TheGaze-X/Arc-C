using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	public sealed class HttpListenerTimeoutsElement : ConfigurationElement
	{
		// Token: 0x06001B53 RID: 6995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x50BC420", Offset = "0x50BB020", VA = "0x1850BC420")]
		public HttpListenerTimeoutsElement()
		{
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x1700061B")]
		public TimeSpan DrainEntityBody
		{
			[Token(Token = "0x6001B54")]
			[Address(RVA = "0x50BC450", Offset = "0x50BB050", VA = "0x1850BC450")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x1700061C")]
		public TimeSpan EntityBody
		{
			[Token(Token = "0x6001B55")]
			[Address(RVA = "0x50BC480", Offset = "0x50BB080", VA = "0x1850BC480")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x1700061D")]
		public TimeSpan HeaderWait
		{
			[Token(Token = "0x6001B56")]
			[Address(RVA = "0x50BC4B0", Offset = "0x50BB0B0", VA = "0x1850BC4B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x1700061E")]
		public TimeSpan IdleConnection
		{
			[Token(Token = "0x6001B57")]
			[Address(RVA = "0x50BC4E0", Offset = "0x50BB0E0", VA = "0x1850BC4E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x1700061F")]
		public long MinSendBytesPerSecond
		{
			[Token(Token = "0x6001B58")]
			[Address(RVA = "0x50BC510", Offset = "0x50BB110", VA = "0x1850BC510")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000620")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B59")]
			[Address(RVA = "0x50BC540", Offset = "0x50BB140", VA = "0x1850BC540", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x17000621")]
		public TimeSpan RequestQueue
		{
			[Token(Token = "0x6001B5A")]
			[Address(RVA = "0x50BC570", Offset = "0x50BB170", VA = "0x1850BC570")]
			get
			{
				return default(TimeSpan);
			}
		}
	}
}
