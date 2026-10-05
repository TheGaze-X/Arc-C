using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.TotemBuff;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005868 RID: 22632
	[Token(Token = "0x2005868")]
	public class RL03TotemBuffView : AbstractRoguelikeTotemBuffView
	{
		// Token: 0x060210DC RID: 135388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210DC")]
		[Address(RVA = "0x1B684E0", Offset = "0x1B670E0", VA = "0x181B684E0", Slot = "4")]
		public override void OnInit()
		{
		}

		// Token: 0x060210DD RID: 135389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210DD")]
		[Address(RVA = "0x1B682E0", Offset = "0x1B66EE0", VA = "0x181B682E0", Slot = "5")]
		public override void BindState(State state)
		{
		}

		// Token: 0x060210DE RID: 135390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210DE")]
		[Address(RVA = "0x1B689D0", Offset = "0x1B675D0", VA = "0x181B689D0", Slot = "6")]
		public override void OnStateResume()
		{
		}

		// Token: 0x060210DF RID: 135391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60210DF")]
		[Address(RVA = "0x1B68430", Offset = "0x1B67030", VA = "0x181B68430", Slot = "7")]
		public override IRoguelikeTotemBuffViewModel GeneViewData(string topicId, bool isOpenDirectFromDungeon)
		{
			return null;
		}

		// Token: 0x060210E0 RID: 135392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E0")]
		[Address(RVA = "0x1B68360", Offset = "0x1B66F60", VA = "0x181B68360")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x060210E1 RID: 135393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E1")]
		[Address(RVA = "0x1B68A50", Offset = "0x1B67650", VA = "0x181B68A50")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x060210E2 RID: 135394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E2")]
		[Address(RVA = "0x1B69560", Offset = "0x1B68160", VA = "0x181B69560")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x060210E3 RID: 135395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E3")]
		[Address(RVA = "0x1B68EC0", Offset = "0x1B67AC0", VA = "0x181B68EC0")]
		private void _OnTotemListItemClick(string totemId, string instId)
		{
		}

		// Token: 0x060210E4 RID: 135396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E4")]
		[Address(RVA = "0x1B68E20", Offset = "0x1B67A20", VA = "0x181B68E20")]
		private void _OnMapNodeClick(int depth, int index)
		{
		}

		// Token: 0x060210E5 RID: 135397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E5")]
		[Address(RVA = "0x1B68B20", Offset = "0x1B67720", VA = "0x181B68B20")]
		private void _OnConfirmBtnClick()
		{
		}

		// Token: 0x060210E6 RID: 135398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E6")]
		[Address(RVA = "0x1B696C0", Offset = "0x1B682C0", VA = "0x181B696C0")]
		private void _SendUseTotemRequest(List<string> totemIndex, List<string> nodeIndex, Action requestCallback)
		{
		}

		// Token: 0x060210E7 RID: 135399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E7")]
		[Address(RVA = "0x1B692D0", Offset = "0x1B67ED0", VA = "0x181B692D0")]
		private void _OnUseTotemRequestCompleted()
		{
		}

		// Token: 0x060210E8 RID: 135400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E8")]
		[Address(RVA = "0x1B691B0", Offset = "0x1B67DB0", VA = "0x181B691B0")]
		private void _OnUseTotemDialogCompleted()
		{
		}

		// Token: 0x060210E9 RID: 135401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210E9")]
		[Address(RVA = "0x1B69950", Offset = "0x1B68550", VA = "0x181B69950")]
		public RL03TotemBuffView()
		{
		}

		// Token: 0x0402CFAF RID: 184239
		[Token(Token = "0x402CFAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL03TotemBuffMapView _mapView;

		// Token: 0x0402CFB0 RID: 184240
		[Token(Token = "0x402CFB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL03TotemBuffListView _listView;

		// Token: 0x0402CFB1 RID: 184241
		[Token(Token = "0x402CFB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL03TotemBuffBottomView _bottomView;

		// Token: 0x0402CFB2 RID: 184242
		[Token(Token = "0x402CFB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rectTransformBack;

		// Token: 0x0402CFB3 RID: 184243
		[Token(Token = "0x402CFB3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _entryAnimLocation;

		// Token: 0x0402CFB4 RID: 184244
		[Token(Token = "0x402CFB4")]
		[FieldOffset(Offset = "0x48")]
		private RL03TotemBuffViewModel m_viewModel;

		// Token: 0x0402CFB5 RID: 184245
		[Token(Token = "0x402CFB5")]
		[FieldOffset(Offset = "0x50")]
		private State m_bindState;

		// Token: 0x0402CFB6 RID: 184246
		[Token(Token = "0x402CFB6")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_entryTween;

		// Token: 0x0402CFB7 RID: 184247
		[Token(Token = "0x402CFB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402CFB8 RID: 184248
		[Token(Token = "0x402CFB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindState;

		// Token: 0x0402CFB9 RID: 184249
		[Token(Token = "0x402CFB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateResume;

		// Token: 0x0402CFBA RID: 184250
		[Token(Token = "0x402CFBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GeneViewData;

		// Token: 0x0402CFBB RID: 184251
		[Token(Token = "0x402CFBB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x0402CFBC RID: 184252
		[Token(Token = "0x402CFBC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x0402CFBD RID: 184253
		[Token(Token = "0x402CFBD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0402CFBE RID: 184254
		[Token(Token = "0x402CFBE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnTotemListItemClick;

		// Token: 0x0402CFBF RID: 184255
		[Token(Token = "0x402CFBF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnMapNodeClick;

		// Token: 0x0402CFC0 RID: 184256
		[Token(Token = "0x402CFC0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnConfirmBtnClick;

		// Token: 0x0402CFC1 RID: 184257
		[Token(Token = "0x402CFC1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SendUseTotemRequest;

		// Token: 0x0402CFC2 RID: 184258
		[Token(Token = "0x402CFC2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnUseTotemRequestCompleted;

		// Token: 0x0402CFC3 RID: 184259
		[Token(Token = "0x402CFC3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnUseTotemDialogCompleted;

		// Token: 0x0402CFC4 RID: 184260
		[Token(Token = "0x402CFC4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
