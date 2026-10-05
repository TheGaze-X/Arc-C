using System;
using Il2CppDummyDll;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	public struct LinearColor
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00007B30 File Offset: 0x00005D30
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000300")]
		public float red
		{
			[Token(Token = "0x6000F6F")]
			[Address(RVA = "0x592C440", Offset = "0x592B040", VA = "0x18592C440")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000F70")]
			[Address(RVA = "0x5981370", Offset = "0x597FF70", VA = "0x185981370")]
			set
			{
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00007B48 File Offset: 0x00005D48
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000301")]
		public float green
		{
			[Token(Token = "0x6000F71")]
			[Address(RVA = "0x5916B50", Offset = "0x5915750", VA = "0x185916B50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000F72")]
			[Address(RVA = "0x59812A0", Offset = "0x597FEA0", VA = "0x1859812A0")]
			set
			{
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00007B60 File Offset: 0x00005D60
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000302")]
		public float blue
		{
			[Token(Token = "0x6000F73")]
			[Address(RVA = "0x592C420", Offset = "0x592B020", VA = "0x18592C420")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000F74")]
			[Address(RVA = "0x59811D0", Offset = "0x597FDD0", VA = "0x1859811D0")]
			set
			{
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x5980E30", Offset = "0x597FA30", VA = "0x185980E30")]
		public static LinearColor Convert(Color color, float intensity)
		{
			return default(LinearColor);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x5980E00", Offset = "0x597FA00", VA = "0x185980E00")]
		public static LinearColor Black()
		{
			return default(LinearColor);
		}

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x0")]
		private float m_red;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x4")]
		private float m_green;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x8")]
		private float m_blue;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0xC")]
		private float m_intensity;
	}
}
