using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	public class WTauNafPreCompInfo : PreCompInfo
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012E")]
		public virtual AbstractF2mPoint[] PreComp
		{
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WTauNafPreCompInfo()
		{
		}

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x10")]
		protected AbstractF2mPoint[] m_preComp;
	}
}
