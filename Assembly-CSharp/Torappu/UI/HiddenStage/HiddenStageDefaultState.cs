using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CA1 RID: 19617
	[Token(Token = "0x2004CA1")]
	public class HiddenStageDefaultState : State
	{
		// Token: 0x0601D675 RID: 120437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D675")]
		[Address(RVA = "0x1707BF0", Offset = "0x17067F0", VA = "0x181707BF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x0601D676 RID: 120438 RVA: 0x000AB630 File Offset: 0x000A9830
		[Token(Token = "0x170044FE")]
		public bool isRetro
		{
			[Token(Token = "0x601D676")]
			[Address(RVA = "0x1709CE0", Offset = "0x17088E0", VA = "0x181709CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x0601D677 RID: 120439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044FF")]
		public string activityId
		{
			[Token(Token = "0x601D677")]
			[Address(RVA = "0x1709C50", Offset = "0x1708850", VA = "0x181709C50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D678 RID: 120440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D678")]
		[Address(RVA = "0x1709340", Offset = "0x1707F40", VA = "0x181709340")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D679 RID: 120441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D679")]
		[Address(RVA = "0x1708D30", Offset = "0x1707930", VA = "0x181708D30")]
		private void _InitDecodeView()
		{
		}

		// Token: 0x0601D67A RID: 120442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D67A")]
		[Address(RVA = "0x1708020", Offset = "0x1706C20", VA = "0x181708020")]
		private void SendUnlockHiddenStage(string stageId, Action<HiddenStageUnlockResponse> handler)
		{
		}

		// Token: 0x0601D67B RID: 120443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D67B")]
		[Address(RVA = "0x1709A80", Offset = "0x1708680", VA = "0x181709A80")]
		private void _UnlockResp(HiddenStageUnlockResponse resp)
		{
		}

		// Token: 0x0601D67C RID: 120444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D67C")]
		[Address(RVA = "0x1709510", Offset = "0x1708110", VA = "0x181709510")]
		private void _OnGoToSquad(bool isPractice)
		{
		}

		// Token: 0x0601D67D RID: 120445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D67D")]
		[Address(RVA = "0x1708360", Offset = "0x1706F60", VA = "0x181708360")]
		private void _EventOnAvgClick()
		{
		}

		// Token: 0x0601D67E RID: 120446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D67E")]
		[Address(RVA = "0x1708850", Offset = "0x1707450", VA = "0x181708850")]
		private void _EventOnEnemyHandbookClick()
		{
		}

		// Token: 0x0601D67F RID: 120447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D67F")]
		[Address(RVA = "0x17085B0", Offset = "0x17071B0", VA = "0x1817085B0")]
		private void _EventOnBattleStart()
		{
		}

		// Token: 0x0601D680 RID: 120448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D680")]
		[Address(RVA = "0x17099F0", Offset = "0x17085F0", VA = "0x1817099F0")]
		private void _OnOpenRewardClick()
		{
		}

		// Token: 0x0601D681 RID: 120449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D681")]
		[Address(RVA = "0x1708A10", Offset = "0x1707610", VA = "0x181708A10")]
		private void _EventOnJumpToStageDetail()
		{
		}

		// Token: 0x0601D682 RID: 120450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D682")]
		[Address(RVA = "0x1708AC0", Offset = "0x17076C0", VA = "0x181708AC0")]
		private void _EventOnJumpToStage(string stageId)
		{
		}

		// Token: 0x0601D683 RID: 120451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D683")]
		[Address(RVA = "0x1708960", Offset = "0x1707560", VA = "0x181708960")]
		private void _EventOnJumpToDecodePanel()
		{
		}

		// Token: 0x0601D684 RID: 120452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D684")]
		[Address(RVA = "0x1708C00", Offset = "0x1707800", VA = "0x181708C00")]
		private void _EventOnUnlockHiddenStage()
		{
		}

		// Token: 0x0601D685 RID: 120453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D685")]
		[Address(RVA = "0x17088E0", Offset = "0x17074E0", VA = "0x1817088E0")]
		private void _EventOnExit()
		{
		}

		// Token: 0x0601D686 RID: 120454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D686")]
		[Address(RVA = "0x1707C50", Offset = "0x1706850", VA = "0x181707C50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D687 RID: 120455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D687")]
		[Address(RVA = "0x1707DF0", Offset = "0x17069F0", VA = "0x181707DF0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601D688 RID: 120456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D688")]
		[Address(RVA = "0x1707D90", Offset = "0x1706990", VA = "0x181707D90", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601D689 RID: 120457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D689")]
		[Address(RVA = "0x1707E50", Offset = "0x1706A50", VA = "0x181707E50", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601D68A RID: 120458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D68A")]
		[Address(RVA = "0x1709750", Offset = "0x1708350", VA = "0x181709750")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x0601D68B RID: 120459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D68B")]
		[Address(RVA = "0x17098B0", Offset = "0x17084B0", VA = "0x1817098B0")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x0601D68C RID: 120460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D68C")]
		[Address(RVA = "0x1708260", Offset = "0x1706E60", VA = "0x181708260")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x0601D68D RID: 120461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D68D")]
		[Address(RVA = "0x1707A70", Offset = "0x1706670", VA = "0x181707A70")]
		public void CloseTips()
		{
		}

		// Token: 0x0601D68E RID: 120462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D68E")]
		[Address(RVA = "0x1709B80", Offset = "0x1708780", VA = "0x181709B80")]
		public HiddenStageDefaultState()
		{
		}

		// Token: 0x0601D68F RID: 120463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D68F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601D690 RID: 120464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D690")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601D691 RID: 120465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D691")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601D692 RID: 120466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D692")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04026B80 RID: 158592
		[Token(Token = "0x4026B80")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _mapTips;

		// Token: 0x04026B81 RID: 158593
		[Token(Token = "0x4026B81")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _mapPreview;

		// Token: 0x04026B82 RID: 158594
		[Token(Token = "0x4026B82")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x04026B83 RID: 158595
		[Token(Token = "0x4026B83")]
		[FieldOffset(Offset = "0x68")]
		private RectTransform m_viewContainer;

		// Token: 0x04026B84 RID: 158596
		[Token(Token = "0x4026B84")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedStageId;

		// Token: 0x04026B85 RID: 158597
		[Token(Token = "0x4026B85")]
		[FieldOffset(Offset = "0x78")]
		private HiddenStageDecodeProperty m_property;

		// Token: 0x04026B86 RID: 158598
		[Token(Token = "0x4026B86")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04026B87 RID: 158599
		[Token(Token = "0x4026B87")]
		[FieldOffset(Offset = "0x88")]
		private HiddenStageDecodeView m_view;

		// Token: 0x04026B88 RID: 158600
		[Token(Token = "0x4026B88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04026B89 RID: 158601
		[Token(Token = "0x4026B89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRetro;

		// Token: 0x04026B8A RID: 158602
		[Token(Token = "0x4026B8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04026B8B RID: 158603
		[Token(Token = "0x4026B8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026B8C RID: 158604
		[Token(Token = "0x4026B8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitDecodeView;

		// Token: 0x04026B8D RID: 158605
		[Token(Token = "0x4026B8D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SendUnlockHiddenStage;

		// Token: 0x04026B8E RID: 158606
		[Token(Token = "0x4026B8E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UnlockResp;

		// Token: 0x04026B8F RID: 158607
		[Token(Token = "0x4026B8F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnGoToSquad;

		// Token: 0x04026B90 RID: 158608
		[Token(Token = "0x4026B90")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnAvgClick;

		// Token: 0x04026B91 RID: 158609
		[Token(Token = "0x4026B91")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnEnemyHandbookClick;

		// Token: 0x04026B92 RID: 158610
		[Token(Token = "0x4026B92")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnBattleStart;

		// Token: 0x04026B93 RID: 158611
		[Token(Token = "0x4026B93")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnOpenRewardClick;

		// Token: 0x04026B94 RID: 158612
		[Token(Token = "0x4026B94")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnJumpToStageDetail;

		// Token: 0x04026B95 RID: 158613
		[Token(Token = "0x4026B95")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnJumpToStage;

		// Token: 0x04026B96 RID: 158614
		[Token(Token = "0x4026B96")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnJumpToDecodePanel;

		// Token: 0x04026B97 RID: 158615
		[Token(Token = "0x4026B97")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnUnlockHiddenStage;

		// Token: 0x04026B98 RID: 158616
		[Token(Token = "0x4026B98")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnExit;

		// Token: 0x04026B99 RID: 158617
		[Token(Token = "0x4026B99")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04026B9A RID: 158618
		[Token(Token = "0x4026B9A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04026B9B RID: 158619
		[Token(Token = "0x4026B9B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04026B9C RID: 158620
		[Token(Token = "0x4026B9C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04026B9D RID: 158621
		[Token(Token = "0x4026B9D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x04026B9E RID: 158622
		[Token(Token = "0x4026B9E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x04026B9F RID: 158623
		[Token(Token = "0x4026B9F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x04026BA0 RID: 158624
		[Token(Token = "0x4026BA0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CloseTips;

		// Token: 0x04026BA1 RID: 158625
		[Token(Token = "0x4026BA1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
