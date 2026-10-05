using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	public class WNafPreCompInfo : PreCompInfo
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012B")]
		public virtual ECPoint[] PreComp
		{
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012C")]
		public virtual ECPoint[] PreCompNeg
		{
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012D")]
		public virtual ECPoint Twice
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WNafPreCompInfo()
		{
		}

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x10")]
		protected ECPoint[] m_preComp;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x18")]
		protected ECPoint[] m_preCompNeg;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x20")]
		protected ECPoint m_twice;
	}
}
