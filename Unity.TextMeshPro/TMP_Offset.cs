using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public struct TMP_Offset
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public float left
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x877290", Offset = "0x875E90", VA = "0x180877290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x8772C0", Offset = "0x875EC0", VA = "0x1808772C0")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public float right
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x877280", Offset = "0x875E80", VA = "0x180877280")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public float top
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public float bottom
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x877270", Offset = "0x875E70", VA = "0x180877270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public float horizontal
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x877290", Offset = "0x875E90", VA = "0x180877290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x57A9A30", Offset = "0x57A8630", VA = "0x1857A9A30")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public float vertical
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x58A37C0", Offset = "0x58A23C0", VA = "0x1858A37C0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x1700002B")]
		public static TMP_Offset zero
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x58A36B0", Offset = "0x58A22B0", VA = "0x1858A36B0")]
			get
			{
				return default(TMP_Offset);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		public TMP_Offset(float left, float right, float top, float bottom)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x58A3690", Offset = "0x58A2290", VA = "0x1858A3690")]
		public TMP_Offset(float horizontal, float vertical)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4E32FB0", Offset = "0x4E31BB0", VA = "0x184E32FB0")]
		public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs)
		{
			return default(bool);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x58A3710", Offset = "0x58A2310", VA = "0x1858A3710")]
		public static bool operator !=(TMP_Offset lhs, TMP_Offset rhs)
		{
			return default(bool);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x56FE1D0", Offset = "0x56FCDD0", VA = "0x1856FE1D0")]
		public static TMP_Offset operator *(TMP_Offset a, float b)
		{
			return default(TMP_Offset);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x58A3600", Offset = "0x58A2200", VA = "0x1858A3600", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x58A35A0", Offset = "0x58A21A0", VA = "0x1858A35A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x58A3520", Offset = "0x58A2120", VA = "0x1858A3520")]
		public bool Equals(TMP_Offset other)
		{
			return default(bool);
		}

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x0")]
		private float m_Left;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x4")]
		private float m_Right;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x8")]
		private float m_Top;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0xC")]
		private float m_Bottom;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_Offset k_ZeroOffset;
	}
}
