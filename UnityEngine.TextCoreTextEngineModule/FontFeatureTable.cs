using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Serializable]
	public class FontFeatureTable
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001F")]
		internal List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x59F28E0", Offset = "0x59F14E0", VA = "0x1859F28E0")]
		public FontFeatureTable()
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x59F2690", Offset = "0x59F1290", VA = "0x1859F2690")]
		public void SortGlyphPairAdjustmentRecords()
		{
		}

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x18")]
		internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup;
	}
}
