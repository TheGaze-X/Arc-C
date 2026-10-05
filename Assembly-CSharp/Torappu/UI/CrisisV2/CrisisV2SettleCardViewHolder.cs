using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005929 RID: 22825
	[Token(Token = "0x2005929")]
	public class CrisisV2SettleCardViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021406 RID: 136198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021406")]
		[Address(RVA = "0x1B92B10", Offset = "0x1B91710", VA = "0x181B92B10")]
		public void Render(SquadItemStruct viewModel, CrisisV2SettleCardView prefab, bool isAssist)
		{
		}

		// Token: 0x06021407 RID: 136199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021407")]
		[Address(RVA = "0x1B92780", Offset = "0x1B91380", VA = "0x181B92780")]
		public void RenderNoDetailAssist(CrisisV2SettleViewModel.SquadSkinInfo skinInfo, CrisisV2SettleCardView prefab, bool isAssist)
		{
		}

		// Token: 0x06021408 RID: 136200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021408")]
		[Address(RVA = "0x1B92CE0", Offset = "0x1B918E0", VA = "0x181B92CE0")]
		private void _InitIfNot(CrisisV2SettleCardView prefab)
		{
		}

		// Token: 0x06021409 RID: 136201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021409")]
		[Address(RVA = "0x1B92DC0", Offset = "0x1B919C0", VA = "0x181B92DC0")]
		public CrisisV2SettleCardViewHolder()
		{
		}

		// Token: 0x0402D4E2 RID: 185570
		[Token(Token = "0x402D4E2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objEmptyBg;

		// Token: 0x0402D4E3 RID: 185571
		[Token(Token = "0x402D4E3")]
		[FieldOffset(Offset = "0x20")]
		private CrisisV2SettleCardView m_cardView;

		// Token: 0x0402D4E4 RID: 185572
		[Token(Token = "0x402D4E4")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0402D4E5 RID: 185573
		[Token(Token = "0x402D4E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D4E6 RID: 185574
		[Token(Token = "0x402D4E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderNoDetailAssist;

		// Token: 0x0402D4E7 RID: 185575
		[Token(Token = "0x402D4E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D4E8 RID: 185576
		[Token(Token = "0x402D4E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
