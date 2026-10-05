using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2000275")]
	public class ServerNameList
	{
		// Token: 0x06001536 RID: 5430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x524F850", Offset = "0x524E450", VA = "0x18524F850")]
		public ServerNameList(IList serverNameList)
		{
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F9")]
		public virtual IList ServerNames
		{
			[Token(Token = "0x6001537")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x524EFD0", Offset = "0x524DBD0", VA = "0x18524EFD0", Slot = "5")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x524F3E0", Offset = "0x524DFE0", VA = "0x18524F3E0")]
		public static ServerNameList Parse(Stream input)
		{
			return null;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x524EF90", Offset = "0x524DB90", VA = "0x18524EF90")]
		private static byte[] CheckNameType(byte[] nameTypesSeen, byte nameType)
		{
			return null;
		}

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IList mServerNameList;
	}
}
