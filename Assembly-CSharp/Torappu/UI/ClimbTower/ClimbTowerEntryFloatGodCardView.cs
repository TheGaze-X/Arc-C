using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C3F RID: 23615
	[Token(Token = "0x2005C3F")]
	public class ClimbTowerEntryFloatGodCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700504C RID: 20556
		// (get) Token: 0x0602239E RID: 140190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602239F RID: 140191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700504C")]
		public UIPage page
		{
			[Token(Token = "0x602239E")]
			[Address(RVA = "0x1CA44B0", Offset = "0x1CA30B0", VA = "0x181CA44B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602239F")]
			[Address(RVA = "0x1CA4610", Offset = "0x1CA3210", VA = "0x181CA4610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700504D RID: 20557
		// (get) Token: 0x060223A0 RID: 140192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223A1 RID: 140193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700504D")]
		public Action onClicked
		{
			[Token(Token = "0x60223A0")]
			[Address(RVA = "0x1CA43F0", Offset = "0x1CA2FF0", VA = "0x181CA43F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223A1")]
			[Address(RVA = "0x1CA4510", Offset = "0x1CA3110", VA = "0x181CA4510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700504E RID: 20558
		// (get) Token: 0x060223A2 RID: 140194 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223A3 RID: 140195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700504E")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x60223A2")]
			[Address(RVA = "0x1CA4450", Offset = "0x1CA3050", VA = "0x181CA4450")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223A3")]
			[Address(RVA = "0x1CA4590", Offset = "0x1CA3190", VA = "0x181CA4590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223A4 RID: 140196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223A4")]
		[Address(RVA = "0x1CA40C0", Offset = "0x1CA2CC0", VA = "0x181CA40C0")]
		public void Render(ClimbTowerEntryFloatPanelViewModel viewModel)
		{
		}

		// Token: 0x060223A5 RID: 140197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223A5")]
		[Address(RVA = "0x1CA3FB0", Offset = "0x1CA2BB0", VA = "0x181CA3FB0")]
		public void OnClick()
		{
		}

		// Token: 0x060223A6 RID: 140198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223A6")]
		[Address(RVA = "0x1CA41B0", Offset = "0x1CA2DB0", VA = "0x181CA41B0")]
		private void _InitIfNot(bool isGodCardTabClose)
		{
		}

		// Token: 0x060223A7 RID: 140199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223A7")]
		[Address(RVA = "0x1CA4390", Offset = "0x1CA2F90", VA = "0x181CA4390")]
		public ClimbTowerEntryFloatGodCardView()
		{
		}

		// Token: 0x0402EF5C RID: 192348
		[Token(Token = "0x402EF5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402EF5D RID: 192349
		[Token(Token = "0x402EF5D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _tabOpenAnimLocation;

		// Token: 0x0402EF5E RID: 192350
		[Token(Token = "0x402EF5E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _tabCloseAnimLocation;

		// Token: 0x0402EF5F RID: 192351
		[Token(Token = "0x402EF5F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402EF60 RID: 192352
		[Token(Token = "0x402EF60")]
		[FieldOffset(Offset = "0x48")]
		private string m_seasonId;

		// Token: 0x0402EF61 RID: 192353
		[Token(Token = "0x402EF61")]
		[FieldOffset(Offset = "0x50")]
		private ClimbTowerEntryFloatGodCardView.Adapter m_adapter;

		// Token: 0x0402EF62 RID: 192354
		[Token(Token = "0x402EF62")]
		[FieldOffset(Offset = "0x58")]
		private List<ClimbTowerEntryGodCardModel> m_godCardViewModel;

		// Token: 0x0402EF63 RID: 192355
		[Token(Token = "0x402EF63")]
		[FieldOffset(Offset = "0x60")]
		private ClimbTowerEntryFloatGodCardView.FloatGodCardSwitchTween m_tabSwitchTween;

		// Token: 0x0402EF67 RID: 192359
		[Token(Token = "0x402EF67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402EF68 RID: 192360
		[Token(Token = "0x402EF68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402EF69 RID: 192361
		[Token(Token = "0x402EF69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0402EF6A RID: 192362
		[Token(Token = "0x402EF6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0402EF6B RID: 192363
		[Token(Token = "0x402EF6B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0402EF6C RID: 192364
		[Token(Token = "0x402EF6C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0402EF6D RID: 192365
		[Token(Token = "0x402EF6D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EF6E RID: 192366
		[Token(Token = "0x402EF6E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402EF6F RID: 192367
		[Token(Token = "0x402EF6F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EF70 RID: 192368
		[Token(Token = "0x402EF70")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C40 RID: 23616
		[Token(Token = "0x2005C40")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060223A8 RID: 140200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223A8")]
			[Address(RVA = "0x1CA0EB0", Offset = "0x1C9FAB0", VA = "0x181CA0EB0")]
			public Adapter(ClimbTowerEntryFloatGodCardView closure)
			{
			}

			// Token: 0x1700504F RID: 20559
			// (get) Token: 0x060223A9 RID: 140201 RVA: 0x000BCC88 File Offset: 0x000BAE88
			[Token(Token = "0x1700504F")]
			public override int count
			{
				[Token(Token = "0x60223A9")]
				[Address(RVA = "0x1CA0F30", Offset = "0x1C9FB30", VA = "0x181CA0F30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060223AA RID: 140202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60223AA")]
			[Address(RVA = "0x1CA03F0", Offset = "0x1C9EFF0", VA = "0x181CA03F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402EF71 RID: 192369
			[Token(Token = "0x402EF71")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryFloatGodCardView m_closure;

			// Token: 0x0402EF72 RID: 192370
			[Token(Token = "0x402EF72")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EF73 RID: 192371
			[Token(Token = "0x402EF73")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EF74 RID: 192372
			[Token(Token = "0x402EF74")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005C41 RID: 23617
		[Token(Token = "0x2005C41")]
		private class FloatGodCardSwitchTween : UISwitchTween
		{
			// Token: 0x060223AB RID: 140203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223AB")]
			[Address(RVA = "0x1CB1910", Offset = "0x1CB0510", VA = "0x181CB1910")]
			public FloatGodCardSwitchTween(ClimbTowerEntryFloatGodCardView closure)
			{
			}

			// Token: 0x060223AC RID: 140204 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60223AC")]
			[Address(RVA = "0x1CB1720", Offset = "0x1CB0320", VA = "0x181CB1720", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060223AD RID: 140205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60223AD")]
			[Address(RVA = "0x1CB15F0", Offset = "0x1CB01F0", VA = "0x181CB15F0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060223AE RID: 140206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223AE")]
			[Address(RVA = "0x1CB1850", Offset = "0x1CB0450", VA = "0x181CB1850", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060223AF RID: 140207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223AF")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402EF75 RID: 192373
			[Token(Token = "0x402EF75")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerEntryFloatGodCardView m_closure;

			// Token: 0x0402EF76 RID: 192374
			[Token(Token = "0x402EF76")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EF77 RID: 192375
			[Token(Token = "0x402EF77")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402EF78 RID: 192376
			[Token(Token = "0x402EF78")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402EF79 RID: 192377
			[Token(Token = "0x402EF79")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
