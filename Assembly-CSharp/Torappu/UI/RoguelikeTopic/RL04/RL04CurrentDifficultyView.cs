using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046C3 RID: 18115
	[Token(Token = "0x20046C3")]
	public class RL04CurrentDifficultyView : RoguelikeTopicCurrentDifficultyBaseView
	{
		// Token: 0x0601B788 RID: 112520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B788")]
		[Address(RVA = "0x14C31F0", Offset = "0x14C1DF0", VA = "0x1814C31F0", Slot = "5")]
		protected override void OnRender(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B789 RID: 112521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B789")]
		[Address(RVA = "0x14C3030", Offset = "0x14C1C30", VA = "0x1814C3030", Slot = "6")]
		protected override void OnRenderDifficulty(RoguelikeTopicDifficultyViewModel diffModel)
		{
		}

		// Token: 0x0601B78A RID: 112522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B78A")]
		[Address(RVA = "0x14C3340", Offset = "0x14C1F40", VA = "0x1814C3340")]
		public RL04CurrentDifficultyView()
		{
		}

		// Token: 0x0601B78B RID: 112523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B78B")]
		[Address(RVA = "0x142FAD0", Offset = "0x142E6D0", VA = "0x18142FAD0")]
		private void <>xLuaBaseProxy_OnRenderDifficulty(RoguelikeTopicDifficultyViewModel P0)
		{
		}

		// Token: 0x04023914 RID: 145684
		[Token(Token = "0x4023914")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _gradeToggle;

		// Token: 0x04023915 RID: 145685
		[Token(Token = "0x4023915")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _gradeText;

		// Token: 0x04023916 RID: 145686
		[Token(Token = "0x4023916")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x04023917 RID: 145687
		[Token(Token = "0x4023917")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _buffActiveTips;

		// Token: 0x04023918 RID: 145688
		[Token(Token = "0x4023918")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _difficultyIconBack;

		// Token: 0x04023919 RID: 145689
		[Token(Token = "0x4023919")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasObject _difficultyAtlasObject;

		// Token: 0x0402391A RID: 145690
		[Token(Token = "0x402391A")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402391B RID: 145691
		[Token(Token = "0x402391B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402391C RID: 145692
		[Token(Token = "0x402391C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderDifficulty;

		// Token: 0x0402391D RID: 145693
		[Token(Token = "0x402391D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
