using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055B8 RID: 21944
	[Token(Token = "0x20055B8")]
	public class RL05SwapCopperListAdapter : LoopScrollAdapter<RL05SwapCopperItemViewHolder, RoguelikePlayerCopperItemViewModel>
	{
		// Token: 0x06020379 RID: 131961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020379")]
		[Address(RVA = "0x1A5C250", Offset = "0x1A5AE50", VA = "0x181A5C250", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602037A RID: 131962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602037A")]
		[Address(RVA = "0x1A5C300", Offset = "0x1A5AF00", VA = "0x181A5C300", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RL05SwapCopperItemViewHolder holder, RoguelikePlayerCopperItemViewModel data)
		{
		}

		// Token: 0x0602037B RID: 131963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602037B")]
		[Address(RVA = "0x1A5C450", Offset = "0x1A5B050", VA = "0x181A5C450")]
		public RL05SwapCopperListAdapter()
		{
		}

		// Token: 0x0402B93B RID: 178491
		[Token(Token = "0x402B93B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _swapCopperItemObjPrefab;

		// Token: 0x0402B93C RID: 178492
		[Token(Token = "0x402B93C")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402B93D RID: 178493
		[Token(Token = "0x402B93D")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public string selectCopperIndex;

		// Token: 0x0402B93E RID: 178494
		[Token(Token = "0x402B93E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402B93F RID: 178495
		[Token(Token = "0x402B93F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402B940 RID: 178496
		[Token(Token = "0x402B940")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
