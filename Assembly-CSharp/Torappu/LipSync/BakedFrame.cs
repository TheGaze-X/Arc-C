using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.LipSync
{
	// Token: 0x0200145D RID: 5213
	[Token(Token = "0x200145D")]
	public class BakedFrame
	{
		// Token: 0x060078BC RID: 30908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078BC")]
		[Address(RVA = "0xECBDF0", Offset = "0xECA9F0", VA = "0x180ECBDF0")]
		public BakedFrame()
		{
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078BD")]
		[Address(RVA = "0x2636530", Offset = "0x2635130", VA = "0x182636530")]
		public BakedFrame(float vol, float mean)
		{
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x060078BE RID: 30910 RVA: 0x00036588 File Offset: 0x00034788
		// (set) Token: 0x060078BF RID: 30911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E6A")]
		public float volume
		{
			[Token(Token = "0x60078BE")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60078BF")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x060078C0 RID: 30912 RVA: 0x000365A0 File Offset: 0x000347A0
		// (set) Token: 0x060078C1 RID: 30913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E6B")]
		public float meanWeight
		{
			[Token(Token = "0x60078C0")]
			[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60078C1")]
			[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
