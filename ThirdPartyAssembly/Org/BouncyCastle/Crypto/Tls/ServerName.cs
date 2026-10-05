using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	public class ServerName
	{
		// Token: 0x0600152F RID: 5423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x524FD60", Offset = "0x524E960", VA = "0x18524FD60")]
		public ServerName(byte nameType, object name)
		{
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x170002F7")]
		public virtual byte NameType
		{
			[Token(Token = "0x6001530")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F8")]
		public virtual object Name
		{
			[Token(Token = "0x6001531")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x524FA50", Offset = "0x524E650", VA = "0x18524FA50", Slot = "6")]
		public virtual string GetHostName()
		{
			return null;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x524F8E0", Offset = "0x524E4E0", VA = "0x18524F8E0", Slot = "7")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x524FC00", Offset = "0x524E800", VA = "0x18524FC00")]
		public static ServerName Parse(Stream input)
		{
			return null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x524FB40", Offset = "0x524E740", VA = "0x18524FB40")]
		protected static bool IsCorrectType(byte nameType, object name)
		{
			return default(bool);
		}

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte mNameType;

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x18")]
		protected readonly object mName;
	}
}
