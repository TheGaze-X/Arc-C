using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[UsedByNativeCode]
	[Serializable]
	public struct GlyphValueRecord : IEquatable<GlyphValueRecord>
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x17000024")]
		public float xPlacement
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x592C440", Offset = "0x592B040", VA = "0x18592C440")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x17000025")]
		public float yPlacement
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x5916B50", Offset = "0x5915750", VA = "0x185916B50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x17000026")]
		public float xAdvance
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x592C420", Offset = "0x592B020", VA = "0x18592C420")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x17000027")]
		public float yAdvance
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x5917F50", Offset = "0x5916B50", VA = "0x185917F50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x5949920", Offset = "0x5948520", VA = "0x185949920")]
		public static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b)
		{
			return default(GlyphValueRecord);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x59D1DB0", Offset = "0x59D09B0", VA = "0x1859D1DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x59D1CD0", Offset = "0x59D08D0", VA = "0x1859D1CD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x59D1D30", Offset = "0x59D0930", VA = "0x1859D1D30", Slot = "4")]
		public bool Equals(GlyphValueRecord other)
		{
			return default(bool);
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("xPlacement")]
		[SerializeField]
		private float m_XPlacement;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[NativeName("yPlacement")]
		private float m_YPlacement;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[NativeName("xAdvance")]
		private float m_XAdvance;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0xC")]
		[NativeName("yAdvance")]
		[SerializeField]
		private float m_YAdvance;
	}
}
