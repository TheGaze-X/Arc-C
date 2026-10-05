using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047AD RID: 18349
	[Token(Token = "0x20047AD")]
	public class RecalRuneSeasonSelectMedalItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BC89 RID: 113801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC89")]
		[Address(RVA = "0x152E7A0", Offset = "0x152D3A0", VA = "0x18152E7A0")]
		public void Render(RecalRuneSeasonStageMedalState state)
		{
		}

		// Token: 0x0601BC8A RID: 113802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC8A")]
		[Address(RVA = "0x152E910", Offset = "0x152D510", VA = "0x18152E910")]
		public RecalRuneSeasonSelectMedalItemView()
		{
		}

		// Token: 0x0402420F RID: 147983
		[Token(Token = "0x402420F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RecalRuneSeasonSelectMedalItemView.StatePanel> _statePanels;

		// Token: 0x04024210 RID: 147984
		[Token(Token = "0x4024210")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024211 RID: 147985
		[Token(Token = "0x4024211")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047AE RID: 18350
		[Token(Token = "0x20047AE")]
		[Serializable]
		private struct StatePanel
		{
			// Token: 0x04024212 RID: 147986
			[Token(Token = "0x4024212")]
			[FieldOffset(Offset = "0x0")]
			public RecalRuneSeasonStageMedalState state;

			// Token: 0x04024213 RID: 147987
			[Token(Token = "0x4024213")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}
	}
}
