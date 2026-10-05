using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005737 RID: 22327
	[Token(Token = "0x2005737")]
	public class RL02ClassicEndingStatsMutationAndVirtueItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020B8C RID: 134028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B8C")]
		[Address(RVA = "0x1B05F10", Offset = "0x1B04B10", VA = "0x181B05F10")]
		public void Render(RoguelikeSquadBuffModel virtueModel, string topicId)
		{
		}

		// Token: 0x06020B8D RID: 134029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B8D")]
		[Address(RVA = "0x1B05D90", Offset = "0x1B04990", VA = "0x181B05D90")]
		public void Render(RoguelikeCharBuffModel mutationModel, string topicId)
		{
		}

		// Token: 0x06020B8E RID: 134030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B8E")]
		[Address(RVA = "0x1B06070", Offset = "0x1B04C70", VA = "0x181B06070")]
		public RL02ClassicEndingStatsMutationAndVirtueItemView()
		{
		}

		// Token: 0x0402C6AF RID: 181935
		[Token(Token = "0x402C6AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402C6B0 RID: 181936
		[Token(Token = "0x402C6B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlBkgMutation;

		// Token: 0x0402C6B1 RID: 181937
		[Token(Token = "0x402C6B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlBkgVirtue;

		// Token: 0x0402C6B2 RID: 181938
		[Token(Token = "0x402C6B2")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C6B3 RID: 181939
		[Token(Token = "0x402C6B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C6B4 RID: 181940
		[Token(Token = "0x402C6B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0402C6B5 RID: 181941
		[Token(Token = "0x402C6B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
