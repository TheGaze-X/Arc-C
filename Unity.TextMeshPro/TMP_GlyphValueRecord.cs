using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[Serializable]
	public struct TMP_GlyphValueRecord
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public float xPlacement
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x877290", Offset = "0x875E90", VA = "0x180877290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x8772C0", Offset = "0x875EC0", VA = "0x1808772C0")]
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public float yPlacement
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x877280", Offset = "0x875E80", VA = "0x180877280")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public float xAdvance
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x5DE4E0", Offset = "0x5DD0E0", VA = "0x1805DE4E0")]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		public float yAdvance
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x877270", Offset = "0x875E70", VA = "0x180877270")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x8772A0", Offset = "0x875EA0", VA = "0x1808772A0")]
			set
			{
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x576A1B0", Offset = "0x5768DB0", VA = "0x18576A1B0")]
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x5880B50", Offset = "0x587F750", VA = "0x185880B50")]
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x58931E0", Offset = "0x5891DE0", VA = "0x1858931E0")]
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b)
		{
			return default(TMP_GlyphValueRecord);
		}

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal float m_XPlacement;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		internal float m_YPlacement;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		internal float m_XAdvance;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		internal float m_YAdvance;
	}
}
