using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x020045FB RID: 17915
	[Token(Token = "0x20045FB")]
	public class RL02CurrentDifficultyView : RoguelikeTopicCurrentDifficultyBaseView
	{
		// Token: 0x0601B3B8 RID: 111544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3B8")]
		[Address(RVA = "0x145D660", Offset = "0x145C260", VA = "0x18145D660", Slot = "5")]
		protected override void OnRender(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B3B9 RID: 111545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3B9")]
		[Address(RVA = "0x145D570", Offset = "0x145C170", VA = "0x18145D570", Slot = "6")]
		protected override void OnRenderDifficulty(RoguelikeTopicDifficultyViewModel diffModel)
		{
		}

		// Token: 0x0601B3BA RID: 111546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3BA")]
		[Address(RVA = "0x145D710", Offset = "0x145C310", VA = "0x18145D710")]
		public RL02CurrentDifficultyView()
		{
		}

		// Token: 0x0601B3BB RID: 111547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3BB")]
		[Address(RVA = "0x142FAD0", Offset = "0x142E6D0", VA = "0x18142FAD0")]
		private void <>xLuaBaseProxy_OnRenderDifficulty(RoguelikeTopicDifficultyViewModel P0)
		{
		}

		// Token: 0x040231DF RID: 143839
		[Token(Token = "0x40231DF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _gradeGO;

		// Token: 0x040231E0 RID: 143840
		[Token(Token = "0x40231E0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _gradeText;

		// Token: 0x040231E1 RID: 143841
		[Token(Token = "0x40231E1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x040231E2 RID: 143842
		[Token(Token = "0x40231E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040231E3 RID: 143843
		[Token(Token = "0x40231E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderDifficulty;

		// Token: 0x040231E4 RID: 143844
		[Token(Token = "0x40231E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
