using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F0D RID: 20237
	[Token(Token = "0x2004F0D")]
	public class FifthAnnivExploreSideInfoSimpleSubView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E29F RID: 123551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E29F")]
		[Address(RVA = "0x17D7870", Offset = "0x17D6470", VA = "0x1817D7870")]
		public void Render(FifthAnnivExploreViewModel viewModel)
		{
		}

		// Token: 0x0601E2A0 RID: 123552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2A0")]
		[Address(RVA = "0x17D7BE0", Offset = "0x17D67E0", VA = "0x1817D7BE0")]
		public FifthAnnivExploreSideInfoSimpleSubView()
		{
		}

		// Token: 0x0402827D RID: 164477
		[Token(Token = "0x402827D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _teamNameText;

		// Token: 0x0402827E RID: 164478
		[Token(Token = "0x402827E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _teamCodeText;

		// Token: 0x0402827F RID: 164479
		[Token(Token = "0x402827F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage[] _teamValueIcons;

		// Token: 0x04028280 RID: 164480
		[Token(Token = "0x4028280")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _teamValueTexts;

		// Token: 0x04028281 RID: 164481
		[Token(Token = "0x4028281")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _backBtn;

		// Token: 0x04028282 RID: 164482
		[Token(Token = "0x4028282")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _tweenDelay;

		// Token: 0x04028283 RID: 164483
		[Token(Token = "0x4028283")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _abilityIconAtlas;

		// Token: 0x04028284 RID: 164484
		[Token(Token = "0x4028284")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_valueTween;

		// Token: 0x04028285 RID: 164485
		[Token(Token = "0x4028285")]
		[FieldOffset(Offset = "0x58")]
		private Action m_onBackBtnClick;

		// Token: 0x04028286 RID: 164486
		[Token(Token = "0x4028286")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028287 RID: 164487
		[Token(Token = "0x4028287")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, int> m_prevAbilityValues;

		// Token: 0x04028288 RID: 164488
		[Token(Token = "0x4028288")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028289 RID: 164489
		[Token(Token = "0x4028289")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
