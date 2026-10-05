using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001346 RID: 4934
	[Token(Token = "0x2001346")]
	[Serializable]
	public class SpecialOperatorDetailData
	{
		// Token: 0x06007303 RID: 29443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007303")]
		[Address(RVA = "0x2213260", Offset = "0x2211E60", VA = "0x182213260")]
		public SpecialOperatorDetailData()
		{
		}

		// Token: 0x04006D50 RID: 27984
		[Token(Token = "0x4006D50")]
		[FieldOffset(Offset = "0x10")]
		public int[][] specialOperatorExpMap;

		// Token: 0x04006D51 RID: 27985
		[Token(Token = "0x4006D51")]
		[FieldOffset(Offset = "0x18")]
		public SpecialOperatorDetailConstData detailConstData;

		// Token: 0x04006D52 RID: 27986
		[Token(Token = "0x4006D52")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SpecialOperatorDetailTabData> tabData;

		// Token: 0x04006D53 RID: 27987
		[Token(Token = "0x4006D53")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SpecialOperatorDetailNodeUnlockData> nodeUnlockData;

		// Token: 0x04006D54 RID: 27988
		[Token(Token = "0x4006D54")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, SpecialOperatorDetailEvolveNodeData> evolveNodeData;

		// Token: 0x04006D55 RID: 27989
		[Token(Token = "0x4006D55")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, SpecialOperatorDetailSkillNodeData> skillNodeData;

		// Token: 0x04006D56 RID: 27990
		[Token(Token = "0x4006D56")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, SpecialOperatorDetailTalentNodeData> talentNodeData;

		// Token: 0x04006D57 RID: 27991
		[Token(Token = "0x4006D57")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, SpecialOperatorDetailMasterNodeData> masterNodeData;

		// Token: 0x04006D58 RID: 27992
		[Token(Token = "0x4006D58")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, SpecialOperatorDetailUniEquipNodeData> uniEquipNodeData;

		// Token: 0x04006D59 RID: 27993
		[Token(Token = "0x4006D59")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, SpecialOperatorDiagramData> nodeDiagramMap;
	}
}
