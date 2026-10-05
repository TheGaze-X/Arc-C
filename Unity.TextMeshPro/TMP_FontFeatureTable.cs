using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[Serializable]
	public class TMP_FontFeatureTable
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x58928B0", Offset = "0x58914B0", VA = "0x1858928B0")]
		public TMP_FontFeatureTable()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x5892660", Offset = "0x5891260", VA = "0x185892660")]
		public void SortGlyphPairAdjustmentRecords()
		{
		}

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x18")]
		internal Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;
	}
}
