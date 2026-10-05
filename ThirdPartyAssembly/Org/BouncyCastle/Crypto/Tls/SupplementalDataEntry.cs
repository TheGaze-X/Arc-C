using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	public class SupplementalDataEntry
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x3437250", Offset = "0x3435E50", VA = "0x183437250")]
		public SupplementalDataEntry(int dataType, byte[] data)
		{
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x17000303")]
		public virtual int DataType
		{
			[Token(Token = "0x6001567")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000304")]
		public virtual byte[] Data
		{
			[Token(Token = "0x6001568")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BFA RID: 3066
		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x10")]
		protected readonly int mDataType;

		// Token: 0x04000BFB RID: 3067
		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x18")]
		protected readonly byte[] mData;
	}
}
