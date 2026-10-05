using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044C2 RID: 17602
	[Token(Token = "0x20044C2")]
	public class RoguelikeTopicDifficultyDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601AE1A RID: 110106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE1A")]
		[Address(RVA = "0x1408ED0", Offset = "0x1407AD0", VA = "0x181408ED0")]
		public void LoadData(string topicId, RoguelikeTopicNormalModelStyle normalModeStyle)
		{
		}

		// Token: 0x0601AE1B RID: 110107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE1B")]
		[Address(RVA = "0x1409200", Offset = "0x1407E00", VA = "0x181409200")]
		public RoguelikeTopicDifficultyDetailStateBean()
		{
		}

		// Token: 0x0402272A RID: 141098
		[Token(Token = "0x402272A")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeTopicDifficultyItemModel> difficultyItemModelList;

		// Token: 0x0402272B RID: 141099
		[Token(Token = "0x402272B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402272C RID: 141100
		[Token(Token = "0x402272C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
