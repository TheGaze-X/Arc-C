using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[Serializable]
	public struct TMP_GlyphAdjustmentRecord
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00002D30 File Offset: 0x00000F30
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		public uint glyphIndex
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00002D48 File Offset: 0x00000F48
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public TMP_GlyphValueRecord glyphValueRecord
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x4007490", Offset = "0x4006090", VA = "0x184007490")]
			get
			{
				return default(TMP_GlyphValueRecord);
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x5892F90", Offset = "0x5891B90", VA = "0x185892F90")]
			set
			{
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xDD17F0", Offset = "0xDD03F0", VA = "0x180DD17F0")]
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x5892EC0", Offset = "0x5891AC0", VA = "0x185892EC0")]
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord)
		{
		}

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal uint m_GlyphIndex;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		internal TMP_GlyphValueRecord m_GlyphValueRecord;
	}
}
