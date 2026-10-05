using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	public class NewSessionTicket
	{
		// Token: 0x060014EA RID: 5354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x4BDBE90", Offset = "0x4BDAA90", VA = "0x184BDBE90")]
		public NewSessionTicket(long ticketLifetimeHint, byte[] ticket)
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x170002DF")]
		public virtual long TicketLifetimeHint
		{
			[Token(Token = "0x60014EB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E0")]
		public virtual byte[] Ticket
		{
			[Token(Token = "0x60014EC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x524AA10", Offset = "0x5249610", VA = "0x18524AA10", Slot = "6")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x524AA90", Offset = "0x5249690", VA = "0x18524AA90")]
		public static NewSessionTicket Parse(Stream input)
		{
			return null;
		}

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x10")]
		protected readonly long mTicketLifetimeHint;

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x18")]
		protected readonly byte[] mTicket;
	}
}
