using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004703 RID: 18179
	[Token(Token = "0x2004703")]
	[Serializable]
	public class BuildConfigRarityViewModel
	{
		// Token: 0x0601B915 RID: 112917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B915")]
		[Address(RVA = "0x14D9A20", Offset = "0x14D8620", VA = "0x1814D9A20")]
		public void InitData(long milliSecond, BuildConfigTagViewModel[] tagList)
		{
		}

		// Token: 0x0601B916 RID: 112918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B916")]
		[Address(RVA = "0x14D9E10", Offset = "0x14D8A10", VA = "0x1814D9E10")]
		public BuildConfigRarityViewModel()
		{
		}

		// Token: 0x04023B42 RID: 146242
		[Token(Token = "0x4023B42")]
		[FieldOffset(Offset = "0x10")]
		public GachaData.RecruitRange normalRankList;

		// Token: 0x04023B43 RID: 146243
		[Token(Token = "0x4023B43")]
		[FieldOffset(Offset = "0x18")]
		public List<int> specialRankList;
	}
}
