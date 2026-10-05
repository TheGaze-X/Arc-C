using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002D60 File Offset: 0x00000F60
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000071")]
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x48809B0", Offset = "0x487F5B0", VA = "0x1848809B0")]
			get
			{
				return default(TMP_GlyphAdjustmentRecord);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x58931C0", Offset = "0x5891DC0", VA = "0x1858931C0")]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002D78 File Offset: 0x00000F78
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x58931A0", Offset = "0x5891DA0", VA = "0x1858931A0")]
			get
			{
				return default(TMP_GlyphAdjustmentRecord);
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x58931D0", Offset = "0x5891DD0", VA = "0x1858931D0")]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00002D90 File Offset: 0x00000F90
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		public FontFeatureLookupFlags featureLookupFlags
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return FontFeatureLookupFlags.None;
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			set
			{
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x5892FA0", Offset = "0x5891BA0", VA = "0x185892FA0")]
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x5892FF0", Offset = "0x5891BF0", VA = "0x185892FF0")]
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
		{
		}

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal FontFeatureLookupFlags m_FeatureLookupFlags;
	}
}
