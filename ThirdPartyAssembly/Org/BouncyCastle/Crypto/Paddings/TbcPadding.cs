using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x020002F5 RID: 757
	[Token(Token = "0x20002F5")]
	public class TbcPadding : IBlockCipherPadding
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000396")]
		public string PaddingName
		{
			[Token(Token = "0x600195B")]
			[Address(RVA = "0x52972E0", Offset = "0x5295EE0", VA = "0x1852972E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void Init(SecureRandom random)
		{
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0000C588 File Offset: 0x0000A788
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x5297220", Offset = "0x5295E20", VA = "0x185297220", Slot = "9")]
		public virtual int AddPadding(byte[] input, int inOff)
		{
			return 0;
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x5297290", Offset = "0x5295E90", VA = "0x185297290", Slot = "10")]
		public virtual int PadCount(byte[] input)
		{
			return 0;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TbcPadding()
		{
		}
	}
}
