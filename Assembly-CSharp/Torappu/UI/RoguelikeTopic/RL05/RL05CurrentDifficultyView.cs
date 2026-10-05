using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x0200458C RID: 17804
	[Token(Token = "0x200458C")]
	public class RL05CurrentDifficultyView : RoguelikeTopicCurrentDifficultyBaseView
	{
		// Token: 0x0601B1B2 RID: 111026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1B2")]
		[Address(RVA = "0x142F950", Offset = "0x142E550", VA = "0x18142F950", Slot = "5")]
		protected override void OnRender(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B1B3 RID: 111027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1B3")]
		[Address(RVA = "0x142F780", Offset = "0x142E380", VA = "0x18142F780", Slot = "6")]
		protected override void OnRenderDifficulty(RoguelikeTopicDifficultyViewModel diffModel)
		{
		}

		// Token: 0x0601B1B4 RID: 111028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1B4")]
		[Address(RVA = "0x142FAE0", Offset = "0x142E6E0", VA = "0x18142FAE0")]
		public RL05CurrentDifficultyView()
		{
		}

		// Token: 0x0601B1B5 RID: 111029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1B5")]
		[Address(RVA = "0x142FAD0", Offset = "0x142E6D0", VA = "0x18142FAD0")]
		private void <>xLuaBaseProxy_OnRenderDifficulty(RoguelikeTopicDifficultyViewModel P0)
		{
		}

		// Token: 0x04022DEC RID: 142828
		[Token(Token = "0x4022DEC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _gradeToggle;

		// Token: 0x04022DED RID: 142829
		[Token(Token = "0x4022DED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _gradeText;

		// Token: 0x04022DEE RID: 142830
		[Token(Token = "0x4022DEE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x04022DEF RID: 142831
		[Token(Token = "0x4022DEF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _buffActiveTips;

		// Token: 0x04022DF0 RID: 142832
		[Token(Token = "0x4022DF0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _difficultyIconBack;

		// Token: 0x04022DF1 RID: 142833
		[Token(Token = "0x4022DF1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasObject _difficultyAtlasObject;

		// Token: 0x04022DF2 RID: 142834
		[Token(Token = "0x4022DF2")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04022DF3 RID: 142835
		[Token(Token = "0x4022DF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04022DF4 RID: 142836
		[Token(Token = "0x4022DF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderDifficulty;

		// Token: 0x04022DF5 RID: 142837
		[Token(Token = "0x4022DF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
