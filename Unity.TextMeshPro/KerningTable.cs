using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[Serializable]
	public class KerningTable
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x58818A0", Offset = "0x58804A0", VA = "0x1858818A0")]
		public KerningTable()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x5881380", Offset = "0x587FF80", VA = "0x185881380")]
		public void AddKerningPair()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x5881210", Offset = "0x587FE10", VA = "0x185881210")]
		public int AddKerningPair(uint first, uint second, float offset)
		{
			return 0;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x5881090", Offset = "0x587FC90", VA = "0x185881090")]
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments)
		{
			return 0;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x58814E0", Offset = "0x58800E0", VA = "0x1858814E0")]
		public void RemoveKerningPair(int left, int right)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x58815F0", Offset = "0x58801F0", VA = "0x1858815F0")]
		public void RemoveKerningPair(int index)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x5881650", Offset = "0x5880250", VA = "0x185881650")]
		public void SortKerningPairs()
		{
		}

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x10")]
		public List<KerningPair> kerningPairs;
	}
}
