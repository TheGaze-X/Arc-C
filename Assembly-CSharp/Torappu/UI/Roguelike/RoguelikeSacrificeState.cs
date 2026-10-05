using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200545D RID: 21597
	[Token(Token = "0x200545D")]
	public class RoguelikeSacrificeState : PopupFadeState
	{
		// Token: 0x0601FC9C RID: 130204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC9C")]
		[Address(RVA = "0x19F92C0", Offset = "0x19F7EC0", VA = "0x1819F92C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FC9D RID: 130205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC9D")]
		[Address(RVA = "0x19F98B0", Offset = "0x19F84B0", VA = "0x1819F98B0")]
		private void _InitView()
		{
		}

		// Token: 0x0601FC9E RID: 130206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC9E")]
		[Address(RVA = "0x19F8CC0", Offset = "0x19F78C0", VA = "0x1819F8CC0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601FC9F RID: 130207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC9F")]
		[Address(RVA = "0x19F8D20", Offset = "0x19F7920", VA = "0x1819F8D20", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601FCA0 RID: 130208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCA0")]
		[Address(RVA = "0x19FA0E0", Offset = "0x19F8CE0", VA = "0x1819FA0E0")]
		private void _OnItemClicked(string indexId)
		{
		}

		// Token: 0x0601FCA1 RID: 130209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCA1")]
		[Address(RVA = "0x19F9C20", Offset = "0x19F8820", VA = "0x1819F9C20")]
		private void _OnConfirmBtnClicked()
		{
		}

		// Token: 0x0601FCA2 RID: 130210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCA2")]
		[Address(RVA = "0x19F99C0", Offset = "0x19F85C0", VA = "0x1819F99C0")]
		private void _OnBackBtnClicked()
		{
		}

		// Token: 0x0601FCA3 RID: 130211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCA3")]
		[Address(RVA = "0x19F9E60", Offset = "0x19F8A60", VA = "0x1819F9E60")]
		private void _OnConfirmSacrifice(string selectedIndexId)
		{
		}

		// Token: 0x0601FCA4 RID: 130212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FCA4")]
		[Address(RVA = "0x19F9180", Offset = "0x19F7D80", VA = "0x1819F9180")]
		private string _GetSacrificeChoiceId()
		{
			return null;
		}

		// Token: 0x0601FCA5 RID: 130213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCA5")]
		[Address(RVA = "0x19FA330", Offset = "0x19F8F30", VA = "0x1819FA330")]
		public RoguelikeSacrificeState()
		{
		}

		// Token: 0x0601FCA7 RID: 130215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCA7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402AD50 RID: 175440
		[Token(Token = "0x402AD50")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _defaultBkg;

		// Token: 0x0402AD51 RID: 175441
		[Token(Token = "0x402AD51")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewHolder;

		// Token: 0x0402AD52 RID: 175442
		[Token(Token = "0x402AD52")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeSacrificeState.RoguelikeSacrificeStateBean m_stateBean;

		// Token: 0x0402AD53 RID: 175443
		[Token(Token = "0x402AD53")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeSacrificeView m_view;

		// Token: 0x0402AD54 RID: 175444
		[Token(Token = "0x402AD54")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeSacrificePlugin m_plugin;

		// Token: 0x0402AD55 RID: 175445
		[Token(Token = "0x402AD55")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeSacrificeState.MenuAdapter m_menuAdapter;

		// Token: 0x0402AD56 RID: 175446
		[Token(Token = "0x402AD56")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x0402AD57 RID: 175447
		[Token(Token = "0x402AD57")]
		[FieldOffset(Offset = "0xA8")]
		private string m_topicId;

		// Token: 0x0402AD58 RID: 175448
		[Token(Token = "0x402AD58")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeDungeonController m_controller;

		// Token: 0x0402AD59 RID: 175449
		[Token(Token = "0x402AD59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AD5A RID: 175450
		[Token(Token = "0x402AD5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x0402AD5B RID: 175451
		[Token(Token = "0x402AD5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402AD5C RID: 175452
		[Token(Token = "0x402AD5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402AD5D RID: 175453
		[Token(Token = "0x402AD5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0402AD5E RID: 175454
		[Token(Token = "0x402AD5E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnConfirmBtnClicked;

		// Token: 0x0402AD5F RID: 175455
		[Token(Token = "0x402AD5F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBackBtnClicked;

		// Token: 0x0402AD60 RID: 175456
		[Token(Token = "0x402AD60")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnConfirmSacrifice;

		// Token: 0x0402AD61 RID: 175457
		[Token(Token = "0x402AD61")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetSacrificeChoiceId;

		// Token: 0x0402AD62 RID: 175458
		[Token(Token = "0x402AD62")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200545E RID: 21598
		[Token(Token = "0x200545E")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004A7D RID: 19069
			// (get) Token: 0x0601FCA8 RID: 130216 RVA: 0x000B32E0 File Offset: 0x000B14E0
			[Token(Token = "0x17004A7D")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601FCA8")]
				[Address(RVA = "0x19E7390", Offset = "0x19E5F90", VA = "0x1819E7390", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004A7E RID: 19070
			// (get) Token: 0x0601FCA9 RID: 130217 RVA: 0x000B32F8 File Offset: 0x000B14F8
			[Token(Token = "0x17004A7E")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601FCA9")]
				[Address(RVA = "0x19E72D0", Offset = "0x19E5ED0", VA = "0x1819E72D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601FCAA RID: 130218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FCAA")]
			[Address(RVA = "0x19E7060", Offset = "0x19E5C60", VA = "0x1819E7060")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601FCAB RID: 130219 RVA: 0x000B3310 File Offset: 0x000B1510
			[Token(Token = "0x601FCAB")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601FCAC RID: 130220 RVA: 0x000B3328 File Offset: 0x000B1528
			[Token(Token = "0x601FCAC")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402AD63 RID: 175459
			[Token(Token = "0x402AD63")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402AD64 RID: 175460
			[Token(Token = "0x402AD64")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402AD65 RID: 175461
			[Token(Token = "0x402AD65")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200545F RID: 21599
		[Token(Token = "0x200545F")]
		private class RoguelikeSacrificeStateBean : IStateBean, IHotfixable
		{
			// Token: 0x0601FCAD RID: 130221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FCAD")]
			[Address(RVA = "0x19F8950", Offset = "0x19F7550", VA = "0x1819F8950")]
			public void LoadData(string topicId, RoguelikeSacrificeModelParamBuilder builder)
			{
			}

			// Token: 0x0601FCAE RID: 130222 RVA: 0x000B3340 File Offset: 0x000B1540
			[Token(Token = "0x601FCAE")]
			[Address(RVA = "0x19F8A10", Offset = "0x19F7610", VA = "0x1819F8A10")]
			public bool OnItemClicked(string indexId)
			{
				return default(bool);
			}

			// Token: 0x0601FCAF RID: 130223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FCAF")]
			[Address(RVA = "0x19F8BD0", Offset = "0x19F77D0", VA = "0x1819F8BD0")]
			public RoguelikeSacrificeStateBean()
			{
			}

			// Token: 0x0402AD66 RID: 175462
			[Token(Token = "0x402AD66")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeSacrificeProperty property;

			// Token: 0x0402AD67 RID: 175463
			[Token(Token = "0x402AD67")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402AD68 RID: 175464
			[Token(Token = "0x402AD68")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnItemClicked;

			// Token: 0x0402AD69 RID: 175465
			[Token(Token = "0x402AD69")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
