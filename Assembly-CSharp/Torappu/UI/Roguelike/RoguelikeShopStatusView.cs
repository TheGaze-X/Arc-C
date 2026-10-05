using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005517 RID: 21783
	[Token(Token = "0x2005517")]
	public class RoguelikeShopStatusView : DataBinder<RoguelikeGameShopStatusProperty>
	{
		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x060200AA RID: 131242 RVA: 0x000B4540 File Offset: 0x000B2740
		[Token(Token = "0x17004B23")]
		public bool interactable
		{
			[Token(Token = "0x60200AA")]
			[Address(RVA = "0x1A2A160", Offset = "0x1A28D60", VA = "0x181A2A160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060200AB RID: 131243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200AB")]
		[Address(RVA = "0x1A28B80", Offset = "0x1A27780", VA = "0x181A28B80")]
		public void InitPanels(List<IRoguelikeGameShopVisibility> viewList)
		{
		}

		// Token: 0x060200AC RID: 131244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200AC")]
		[Address(RVA = "0x1A28CD0", Offset = "0x1A278D0", VA = "0x181A28CD0")]
		public void Init()
		{
		}

		// Token: 0x060200AD RID: 131245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200AD")]
		[Address(RVA = "0x1A28D30", Offset = "0x1A27930", VA = "0x181A28D30", Slot = "7")]
		public override void OnValueChanged(RoguelikeGameShopStatusProperty property)
		{
		}

		// Token: 0x060200AE RID: 131246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200AE")]
		[Address(RVA = "0x1A29DE0", Offset = "0x1A289E0", VA = "0x181A29DE0")]
		private void _UpdateView(RoguelikeGameShopStatusEnum shopStatus, bool isFastMode)
		{
		}

		// Token: 0x060200AF RID: 131247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200AF")]
		[Address(RVA = "0x1A29A80", Offset = "0x1A28680", VA = "0x181A29A80")]
		private void _StopPossibleTweens()
		{
		}

		// Token: 0x060200B0 RID: 131248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200B0")]
		[Address(RVA = "0x1A29B20", Offset = "0x1A28720", VA = "0x181A29B20")]
		private void _TestPanelsAndHideIfNeed(RoguelikeGameShopStatusEnum shopStatus, bool isFastMode)
		{
		}

		// Token: 0x060200B1 RID: 131249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200B1")]
		[Address(RVA = "0x1A297F0", Offset = "0x1A283F0", VA = "0x181A297F0")]
		private void _ShowPanelsOrDelayIfNeed(RoguelikeGameShopStatusEnum shopStatus, bool isFastMode)
		{
		}

		// Token: 0x060200B2 RID: 131250 RVA: 0x000B4558 File Offset: 0x000B2758
		[Token(Token = "0x60200B2")]
		[Address(RVA = "0x1A28E60", Offset = "0x1A27A60", VA = "0x181A28E60")]
		private float _CollectDelayTimeForPanel(IRoguelikeGameShopVisibility panel)
		{
			return 0f;
		}

		// Token: 0x060200B3 RID: 131251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200B3")]
		[Address(RVA = "0x1A291D0", Offset = "0x1A27DD0", VA = "0x181A291D0")]
		private void _GenerateDalayTweens(RoguelikeGameShopStatusEnum shopStatus, bool isFastMode)
		{
		}

		// Token: 0x060200B4 RID: 131252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200B4")]
		[Address(RVA = "0x1A29640", Offset = "0x1A28240", VA = "0x181A29640")]
		private void _GenerateInteractTween()
		{
		}

		// Token: 0x060200B5 RID: 131253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200B5")]
		[Address(RVA = "0x1A29FC0", Offset = "0x1A28BC0", VA = "0x181A29FC0")]
		public RoguelikeShopStatusView()
		{
		}

		// Token: 0x0402B431 RID: 177201
		[Token(Token = "0x402B431")]
		private const float INTERACT_CHECK_INTERVAL = 0.003f;

		// Token: 0x0402B432 RID: 177202
		[Token(Token = "0x402B432")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _interactGroup;

		// Token: 0x0402B433 RID: 177203
		[Token(Token = "0x402B433")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<IRoguelikeGameShopVisibility> m_viewList;

		// Token: 0x0402B434 RID: 177204
		[Token(Token = "0x402B434")]
		[FieldOffset(Offset = "0x30")]
		private bool m_initRender;

		// Token: 0x0402B435 RID: 177205
		[Token(Token = "0x402B435")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<IRoguelikeGameShopVisibility> m_showViewList;

		// Token: 0x0402B436 RID: 177206
		[Token(Token = "0x402B436")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<IRoguelikeGameShopVisibility, float> m_hideViewDict;

		// Token: 0x0402B437 RID: 177207
		[Token(Token = "0x402B437")]
		[FieldOffset(Offset = "0x48")]
		private float m_maxHideTime;

		// Token: 0x0402B438 RID: 177208
		[Token(Token = "0x402B438")]
		[FieldOffset(Offset = "0x4C")]
		private float m_maxShowTime;

		// Token: 0x0402B439 RID: 177209
		[Token(Token = "0x402B439")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<RoguelikeShopStatusView.ShowItem> m_delayedShowItemList;

		// Token: 0x0402B43A RID: 177210
		[Token(Token = "0x402B43A")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_delayedShow;

		// Token: 0x0402B43B RID: 177211
		[Token(Token = "0x402B43B")]
		[FieldOffset(Offset = "0x60")]
		private float m_delayTime;

		// Token: 0x0402B43C RID: 177212
		[Token(Token = "0x402B43C")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_delayedInteract;

		// Token: 0x0402B43D RID: 177213
		[Token(Token = "0x402B43D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0402B43E RID: 177214
		[Token(Token = "0x402B43E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitPanels;

		// Token: 0x0402B43F RID: 177215
		[Token(Token = "0x402B43F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402B440 RID: 177216
		[Token(Token = "0x402B440")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B441 RID: 177217
		[Token(Token = "0x402B441")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0402B442 RID: 177218
		[Token(Token = "0x402B442")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StopPossibleTweens;

		// Token: 0x0402B443 RID: 177219
		[Token(Token = "0x402B443")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TestPanelsAndHideIfNeed;

		// Token: 0x0402B444 RID: 177220
		[Token(Token = "0x402B444")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowPanelsOrDelayIfNeed;

		// Token: 0x0402B445 RID: 177221
		[Token(Token = "0x402B445")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CollectDelayTimeForPanel;

		// Token: 0x0402B446 RID: 177222
		[Token(Token = "0x402B446")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenerateDalayTweens;

		// Token: 0x0402B447 RID: 177223
		[Token(Token = "0x402B447")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenerateInteractTween;

		// Token: 0x0402B448 RID: 177224
		[Token(Token = "0x402B448")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005518 RID: 21784
		[Token(Token = "0x2005518")]
		private struct ShowItem
		{
			// Token: 0x0402B449 RID: 177225
			[Token(Token = "0x402B449")]
			[FieldOffset(Offset = "0x0")]
			public IRoguelikeGameShopVisibility view;

			// Token: 0x0402B44A RID: 177226
			[Token(Token = "0x402B44A")]
			[FieldOffset(Offset = "0x8")]
			public float time;
		}
	}
}
