using System;
using System.Configuration;
using System.Net.Mail;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2000404")]
	public sealed class SmtpSection : ConfigurationSection
	{
		// Token: 0x06001B6C RID: 7020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x50C09B0", Offset = "0x50BF5B0", VA = "0x1850C09B0")]
		public SmtpSection()
		{
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0000C060 File Offset: 0x0000A260
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062A")]
		public SmtpDeliveryFormat DeliveryFormat
		{
			[Token(Token = "0x6001B6D")]
			[Address(RVA = "0x50C09E0", Offset = "0x50BF5E0", VA = "0x1850C09E0")]
			get
			{
				return SmtpDeliveryFormat.SevenBit;
			}
			[Token(Token = "0x6001B6E")]
			[Address(RVA = "0x50C0B00", Offset = "0x50BF700", VA = "0x1850C0B00")]
			set
			{
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0000C078 File Offset: 0x0000A278
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062B")]
		public SmtpDeliveryMethod DeliveryMethod
		{
			[Token(Token = "0x6001B6F")]
			[Address(RVA = "0x50C0A10", Offset = "0x50BF610", VA = "0x1850C0A10")]
			get
			{
				return SmtpDeliveryMethod.Network;
			}
			[Token(Token = "0x6001B70")]
			[Address(RVA = "0x50C0B30", Offset = "0x50BF730", VA = "0x1850C0B30")]
			set
			{
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062C")]
		public string From
		{
			[Token(Token = "0x6001B71")]
			[Address(RVA = "0x50C0A40", Offset = "0x50BF640", VA = "0x1850C0A40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B72")]
			[Address(RVA = "0x50C0B60", Offset = "0x50BF760", VA = "0x1850C0B60")]
			set
			{
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062D")]
		public SmtpNetworkElement Network
		{
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x50C0A70", Offset = "0x50BF670", VA = "0x1850C0A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062E")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B74")]
			[Address(RVA = "0x50C0AA0", Offset = "0x50BF6A0", VA = "0x1850C0AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062F")]
		public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory
		{
			[Token(Token = "0x6001B75")]
			[Address(RVA = "0x50C0AD0", Offset = "0x50BF6D0", VA = "0x1850C0AD0")]
			get
			{
				return null;
			}
		}
	}
}
