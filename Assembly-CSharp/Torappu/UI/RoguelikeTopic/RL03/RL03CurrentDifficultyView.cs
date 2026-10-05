using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045AF RID: 17839
	[Token(Token = "0x20045AF")]
	public class RL03CurrentDifficultyView : RoguelikeTopicCurrentDifficultyBaseView
	{
		// Token: 0x0601B253 RID: 111187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B253")]
		[Address(RVA = "0x1445AD0", Offset = "0x14446D0", VA = "0x181445AD0", Slot = "5")]
		protected override void OnRender(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B254 RID: 111188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B254")]
		[Address(RVA = "0x14459D0", Offset = "0x14445D0", VA = "0x1814459D0", Slot = "6")]
		protected override void OnRenderDifficulty(RoguelikeTopicDifficultyViewModel diffModel)
		{
		}

		// Token: 0x0601B255 RID: 111189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B255")]
		[Address(RVA = "0x1445C30", Offset = "0x1444830", VA = "0x181445C30")]
		public RL03CurrentDifficultyView()
		{
		}

		// Token: 0x0601B256 RID: 111190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B256")]
		[Address(RVA = "0x142FAD0", Offset = "0x142E6D0", VA = "0x18142FAD0")]
		private void <>xLuaBaseProxy_OnRenderDifficulty(RoguelikeTopicDifficultyViewModel P0)
		{
		}

		// Token: 0x04022F28 RID: 143144
		[Token(Token = "0x4022F28")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _gradeToggle;

		// Token: 0x04022F29 RID: 143145
		[Token(Token = "0x4022F29")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _gradeText;

		// Token: 0x04022F2A RID: 143146
		[Token(Token = "0x4022F2A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x04022F2B RID: 143147
		[Token(Token = "0x4022F2B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _buffActiveTips;

		// Token: 0x04022F2C RID: 143148
		[Token(Token = "0x4022F2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04022F2D RID: 143149
		[Token(Token = "0x4022F2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderDifficulty;

		// Token: 0x04022F2E RID: 143150
		[Token(Token = "0x4022F2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
