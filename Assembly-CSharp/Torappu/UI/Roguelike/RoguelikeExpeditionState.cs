using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052D2 RID: 21202
	[Token(Token = "0x20052D2")]
	public class RoguelikeExpeditionState : PopupFadeState
	{
		// Token: 0x0601F458 RID: 128088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F458")]
		[Address(RVA = "0x18FEE90", Offset = "0x18FDA90", VA = "0x1818FEE90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F459 RID: 128089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F459")]
		[Address(RVA = "0x18FEE30", Offset = "0x18FDA30", VA = "0x1818FEE30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F45A RID: 128090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F45A")]
		[Address(RVA = "0x18FF640", Offset = "0x18FE240", VA = "0x1818FF640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F45B RID: 128091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F45B")]
		[Address(RVA = "0x18FFCF0", Offset = "0x18FE8F0", VA = "0x1818FFCF0")]
		private void _InitView()
		{
		}

		// Token: 0x0601F45C RID: 128092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F45C")]
		[Address(RVA = "0x19000C0", Offset = "0x18FECC0", VA = "0x1819000C0")]
		private void _OnCharSelectChange(string charInstId)
		{
		}

		// Token: 0x0601F45D RID: 128093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F45D")]
		[Address(RVA = "0x19002A0", Offset = "0x18FEEA0", VA = "0x1819002A0")]
		private void _OnConfirmBtnClicked()
		{
		}

		// Token: 0x0601F45E RID: 128094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F45E")]
		[Address(RVA = "0x18FFE60", Offset = "0x18FEA60", VA = "0x1818FFE60")]
		private void _OnBackBtnClicked()
		{
		}

		// Token: 0x0601F45F RID: 128095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F45F")]
		[Address(RVA = "0x1900440", Offset = "0x18FF040", VA = "0x181900440")]
		private void _OnConfirmExpedition(string selectedCharInstId)
		{
		}

		// Token: 0x0601F460 RID: 128096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F460")]
		[Address(RVA = "0x18FF500", Offset = "0x18FE100", VA = "0x1818FF500")]
		private string _GetExpeditionChoiceId()
		{
			return null;
		}

		// Token: 0x0601F461 RID: 128097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F461")]
		[Address(RVA = "0x19006C0", Offset = "0x18FF2C0", VA = "0x1819006C0")]
		public RoguelikeExpeditionState()
		{
		}

		// Token: 0x0601F463 RID: 128099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F463")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04029FEE RID: 172014
		[Token(Token = "0x4029FEE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _defaultBkg;

		// Token: 0x04029FEF RID: 172015
		[Token(Token = "0x4029FEF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewHolder;

		// Token: 0x04029FF0 RID: 172016
		[Token(Token = "0x4029FF0")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeExpeditionState.RoguelikeExpeditionStateBean m_stateBean;

		// Token: 0x04029FF1 RID: 172017
		[Token(Token = "0x4029FF1")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeExpeditionView m_view;

		// Token: 0x04029FF2 RID: 172018
		[Token(Token = "0x4029FF2")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeExpeditionPluginContext m_pluginContext;

		// Token: 0x04029FF3 RID: 172019
		[Token(Token = "0x4029FF3")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeExpeditionConfirmBehaviour m_confirmBehaviour;

		// Token: 0x04029FF4 RID: 172020
		[Token(Token = "0x4029FF4")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04029FF5 RID: 172021
		[Token(Token = "0x4029FF5")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeExpeditionState.MenuAdapter m_menuAdapter;

		// Token: 0x04029FF6 RID: 172022
		[Token(Token = "0x4029FF6")]
		[FieldOffset(Offset = "0xB0")]
		private string m_topicId;

		// Token: 0x04029FF7 RID: 172023
		[Token(Token = "0x4029FF7")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeDungeonController m_controller;

		// Token: 0x04029FF8 RID: 172024
		[Token(Token = "0x4029FF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029FF9 RID: 172025
		[Token(Token = "0x4029FF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029FFA RID: 172026
		[Token(Token = "0x4029FFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029FFB RID: 172027
		[Token(Token = "0x4029FFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x04029FFC RID: 172028
		[Token(Token = "0x4029FFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCharSelectChange;

		// Token: 0x04029FFD RID: 172029
		[Token(Token = "0x4029FFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnConfirmBtnClicked;

		// Token: 0x04029FFE RID: 172030
		[Token(Token = "0x4029FFE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBackBtnClicked;

		// Token: 0x04029FFF RID: 172031
		[Token(Token = "0x4029FFF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnConfirmExpedition;

		// Token: 0x0402A000 RID: 172032
		[Token(Token = "0x402A000")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetExpeditionChoiceId;

		// Token: 0x0402A001 RID: 172033
		[Token(Token = "0x402A001")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052D3 RID: 21203
		[Token(Token = "0x20052D3")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004960 RID: 18784
			// (get) Token: 0x0601F464 RID: 128100 RVA: 0x000B1600 File Offset: 0x000AF800
			[Token(Token = "0x17004960")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601F464")]
				[Address(RVA = "0x18F35F0", Offset = "0x18F21F0", VA = "0x1818F35F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004961 RID: 18785
			// (get) Token: 0x0601F465 RID: 128101 RVA: 0x000B1618 File Offset: 0x000AF818
			[Token(Token = "0x17004961")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601F465")]
				[Address(RVA = "0x18F34C0", Offset = "0x18F20C0", VA = "0x1818F34C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601F466 RID: 128102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F466")]
			[Address(RVA = "0x18F3310", Offset = "0x18F1F10", VA = "0x1818F3310")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601F467 RID: 128103 RVA: 0x000B1630 File Offset: 0x000AF830
			[Token(Token = "0x601F467")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601F468 RID: 128104 RVA: 0x000B1648 File Offset: 0x000AF848
			[Token(Token = "0x601F468")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402A002 RID: 172034
			[Token(Token = "0x402A002")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402A003 RID: 172035
			[Token(Token = "0x402A003")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402A004 RID: 172036
			[Token(Token = "0x402A004")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020052D4 RID: 21204
		[Token(Token = "0x20052D4")]
		private class RoguelikeExpeditionStateBean : IStateBean, IHotfixable
		{
			// Token: 0x17004962 RID: 18786
			// (get) Token: 0x0601F469 RID: 128105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004962")]
			public string selectingCharInstId
			{
				[Token(Token = "0x601F469")]
				[Address(RVA = "0x18FED70", Offset = "0x18FD970", VA = "0x1818FED70")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601F46A RID: 128106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F46A")]
			[Address(RVA = "0x18FE860", Offset = "0x18FD460", VA = "0x1818FE860")]
			public void LoadData(string topicId)
			{
			}

			// Token: 0x0601F46B RID: 128107 RVA: 0x000B1660 File Offset: 0x000AF860
			[Token(Token = "0x601F46B")]
			[Address(RVA = "0x18FEB40", Offset = "0x18FD740", VA = "0x1818FEB40")]
			public bool UpdateSelectingChar(string charId)
			{
				return default(bool);
			}

			// Token: 0x0601F46C RID: 128108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F46C")]
			[Address(RVA = "0x18FEAB0", Offset = "0x18FD6B0", VA = "0x1818FEAB0")]
			public void UpdateInitFlag(bool isInit)
			{
			}

			// Token: 0x0601F46D RID: 128109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F46D")]
			[Address(RVA = "0x18FE900", Offset = "0x18FD500", VA = "0x1818FE900")]
			public void SortCharList(RoguelikeExpeditionPluginContext.RoguelikeExpeditionCharListSort sort)
			{
			}

			// Token: 0x0601F46E RID: 128110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F46E")]
			[Address(RVA = "0x18FEC80", Offset = "0x18FD880", VA = "0x1818FEC80")]
			public RoguelikeExpeditionStateBean()
			{
			}

			// Token: 0x0402A005 RID: 172037
			[Token(Token = "0x402A005")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeExpeditionModelProperty property;

			// Token: 0x0402A006 RID: 172038
			[Token(Token = "0x402A006")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_selectingCharInstId;

			// Token: 0x0402A007 RID: 172039
			[Token(Token = "0x402A007")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402A008 RID: 172040
			[Token(Token = "0x402A008")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateSelectingChar;

			// Token: 0x0402A009 RID: 172041
			[Token(Token = "0x402A009")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateInitFlag;

			// Token: 0x0402A00A RID: 172042
			[Token(Token = "0x402A00A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SortCharList;

			// Token: 0x0402A00B RID: 172043
			[Token(Token = "0x402A00B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
