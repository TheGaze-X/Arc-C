using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055E1 RID: 21985
	[Token(Token = "0x20055E1")]
	public class RL05MenuCopperView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020452 RID: 132178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020452")]
		[Address(RVA = "0x1A645F0", Offset = "0x1A631F0", VA = "0x181A645F0")]
		public void Render(RoguelikePlayerCopperItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x06020453 RID: 132179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020453")]
		[Address(RVA = "0x1A64810", Offset = "0x1A63410", VA = "0x181A64810")]
		public RL05MenuCopperView()
		{
		}

		// Token: 0x0402BA82 RID: 178818
		[Token(Token = "0x402BA82")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _copperItemCardScale;

		// Token: 0x0402BA83 RID: 178819
		[Token(Token = "0x402BA83")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _copperCardContainer;

		// Token: 0x0402BA84 RID: 178820
		[Token(Token = "0x402BA84")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptySlotBg;

		// Token: 0x0402BA85 RID: 178821
		[Token(Token = "0x402BA85")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402BA86 RID: 178822
		[Token(Token = "0x402BA86")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BA87 RID: 178823
		[Token(Token = "0x402BA87")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeAbstractCopperItemCard m_copperCard;

		// Token: 0x0402BA88 RID: 178824
		[Token(Token = "0x402BA88")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikePlayerCopperItemViewModel m_viewModel;

		// Token: 0x0402BA89 RID: 178825
		[Token(Token = "0x402BA89")]
		[FieldOffset(Offset = "0x58")]
		private string m_topicId;

		// Token: 0x0402BA8A RID: 178826
		[Token(Token = "0x402BA8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BA8B RID: 178827
		[Token(Token = "0x402BA8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
