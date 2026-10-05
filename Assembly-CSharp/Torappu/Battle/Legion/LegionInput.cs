using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A2D RID: 10797
	[Token(Token = "0x2002A2D")]
	public class LegionInput : IHotfixable
	{
		// Token: 0x06011EA9 RID: 73385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EA9")]
		[Address(RVA = "0x9C8CF0", Offset = "0x9C78F0", VA = "0x1809C8CF0")]
		public LegionInput()
		{
		}

		// Token: 0x04014311 RID: 82705
		[Token(Token = "0x4014311")]
		[FieldOffset(Offset = "0x10")]
		public List<LegionInput.ProfessionSkillPartPair> professionSkillPart;

		// Token: 0x04014312 RID: 82706
		[Token(Token = "0x4014312")]
		[FieldOffset(Offset = "0x18")]
		public List<LegionInput.PreGivenTrapInfo> trapInfos;

		// Token: 0x04014313 RID: 82707
		[Token(Token = "0x4014313")]
		[FieldOffset(Offset = "0x20")]
		public readonly int maxStackCntPerCategory;

		// Token: 0x04014314 RID: 82708
		[Token(Token = "0x4014314")]
		[FieldOffset(Offset = "0x24")]
		public readonly int professionLevelAdd;

		// Token: 0x04014315 RID: 82709
		[Token(Token = "0x4014315")]
		[FieldOffset(Offset = "0x28")]
		public readonly int maxCardCnt;

		// Token: 0x04014316 RID: 82710
		[Token(Token = "0x4014316")]
		[FieldOffset(Offset = "0x2C")]
		public int gBuffDyingDuration;

		// Token: 0x04014317 RID: 82711
		[Token(Token = "0x4014317")]
		[FieldOffset(Offset = "0x30")]
		public bool initRandomShuffle;

		// Token: 0x04014318 RID: 82712
		[Token(Token = "0x4014318")]
		[FieldOffset(Offset = "0x31")]
		public bool recycleRandomShuffle;

		// Token: 0x04014319 RID: 82713
		[Token(Token = "0x4014319")]
		[FieldOffset(Offset = "0x34")]
		public int initCardCount;

		// Token: 0x0401431A RID: 82714
		[Token(Token = "0x401431A")]
		[FieldOffset(Offset = "0x38")]
		public int initRedrawCount;

		// Token: 0x0401431B RID: 82715
		[Token(Token = "0x401431B")]
		[FieldOffset(Offset = "0x3C")]
		public int ingameRedrawCount;

		// Token: 0x0401431C RID: 82716
		[Token(Token = "0x401431C")]
		[FieldOffset(Offset = "0x40")]
		public int goldForEndprepare;

		// Token: 0x0401431D RID: 82717
		[Token(Token = "0x401431D")]
		[FieldOffset(Offset = "0x44")]
		public int goldForWaveEnd;

		// Token: 0x0401431E RID: 82718
		[Token(Token = "0x401431E")]
		[FieldOffset(Offset = "0x48")]
		public int maxGold;

		// Token: 0x0401431F RID: 82719
		[Token(Token = "0x401431F")]
		[FieldOffset(Offset = "0x4C")]
		public int initGold;

		// Token: 0x04014320 RID: 82720
		[Token(Token = "0x4014320")]
		[FieldOffset(Offset = "0x50")]
		public int initCardPrice;

		// Token: 0x04014321 RID: 82721
		[Token(Token = "0x4014321")]
		[FieldOffset(Offset = "0x54")]
		public int cardPriceGrowth;

		// Token: 0x04014322 RID: 82722
		[Token(Token = "0x4014322")]
		[FieldOffset(Offset = "0x58")]
		public int maxCardPrice;

		// Token: 0x04014323 RID: 82723
		[Token(Token = "0x4014323")]
		[FieldOffset(Offset = "0x5C")]
		public int initReShuffleTimes;

		// Token: 0x04014324 RID: 82724
		[Token(Token = "0x4014324")]
		[FieldOffset(Offset = "0x60")]
		public int initReShuffleCostTotal;

		// Token: 0x04014325 RID: 82725
		[Token(Token = "0x4014325")]
		[FieldOffset(Offset = "0x64")]
		public int initReShufflePioneerCount;

		// Token: 0x04014326 RID: 82726
		[Token(Token = "0x4014326")]
		[FieldOffset(Offset = "0x68")]
		public int addPriceWhenReshuffle;

		// Token: 0x04014327 RID: 82727
		[Token(Token = "0x4014327")]
		[FieldOffset(Offset = "0x6C")]
		public int maxAddPriceWhenReshuffle;

		// Token: 0x04014328 RID: 82728
		[Token(Token = "0x4014328")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A2E RID: 10798
		[Token(Token = "0x2002A2E")]
		[Serializable]
		public class ProfessionSkillPartPair
		{
			// Token: 0x06011EAA RID: 73386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011EAA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProfessionSkillPartPair()
			{
			}

			// Token: 0x04014329 RID: 82729
			[Token(Token = "0x4014329")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory category;

			// Token: 0x0401432A RID: 82730
			[Token(Token = "0x401432A")]
			[FieldOffset(Offset = "0x14")]
			public int part;
		}

		// Token: 0x02002A2F RID: 10799
		[Token(Token = "0x2002A2F")]
		public struct PreGivenTrapInfo
		{
			// Token: 0x0401432B RID: 82731
			[Token(Token = "0x401432B")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x0401432C RID: 82732
			[Token(Token = "0x401432C")]
			[FieldOffset(Offset = "0x8")]
			public string alias;
		}
	}
}
