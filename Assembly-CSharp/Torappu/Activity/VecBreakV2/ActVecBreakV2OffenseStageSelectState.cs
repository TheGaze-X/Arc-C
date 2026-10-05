using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E4B RID: 28235
	[Token(Token = "0x2006E4B")]
	public class ActVecBreakV2OffenseStageSelectState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060282E3 RID: 164579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282E3")]
		[Address(RVA = "0x237C600", Offset = "0x237B200", VA = "0x18237C600", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060282E4 RID: 164580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E4")]
		[Address(RVA = "0x237C660", Offset = "0x237B260", VA = "0x18237C660", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060282E5 RID: 164581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E5")]
		[Address(RVA = "0x237D5A0", Offset = "0x237C1A0", VA = "0x18237D5A0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x060282E6 RID: 164582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E6")]
		[Address(RVA = "0x237D050", Offset = "0x237BC50", VA = "0x18237D050", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060282E7 RID: 164583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E7")]
		[Address(RVA = "0x237D150", Offset = "0x237BD50", VA = "0x18237D150", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060282E8 RID: 164584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E8")]
		[Address(RVA = "0x237E2F0", Offset = "0x237CEF0", VA = "0x18237E2F0")]
		private void _OnNavPrev()
		{
		}

		// Token: 0x060282E9 RID: 164585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E9")]
		[Address(RVA = "0x237E1E0", Offset = "0x237CDE0", VA = "0x18237E1E0")]
		private void _OnNavNext()
		{
		}

		// Token: 0x060282EA RID: 164586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282EA")]
		[Address(RVA = "0x237E3C0", Offset = "0x237CFC0", VA = "0x18237E3C0")]
		private void _OnOpenEnemyDetail()
		{
		}

		// Token: 0x060282EB RID: 164587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282EB")]
		[Address(RVA = "0x237E4D0", Offset = "0x237D0D0", VA = "0x18237E4D0")]
		private void _OnOpenMapPreview()
		{
		}

		// Token: 0x060282EC RID: 164588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282EC")]
		[Address(RVA = "0x237E5E0", Offset = "0x237D1E0", VA = "0x18237E5E0")]
		private void _OnOpenSquadPage()
		{
		}

		// Token: 0x060282ED RID: 164589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282ED")]
		[Address(RVA = "0x237DFB0", Offset = "0x237CBB0", VA = "0x18237DFB0")]
		private void _OnEnterRaidMode()
		{
		}

		// Token: 0x060282EE RID: 164590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282EE")]
		[Address(RVA = "0x237DBB0", Offset = "0x237C7B0", VA = "0x18237DBB0")]
		private void _EnterFromBattle()
		{
		}

		// Token: 0x060282EF RID: 164591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282EF")]
		[Address(RVA = "0x237DB00", Offset = "0x237C700", VA = "0x18237DB00")]
		private IEnumerator _EnterFromBattleCoroutine()
		{
			return null;
		}

		// Token: 0x060282F0 RID: 164592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282F0")]
		[Address(RVA = "0x237D860", Offset = "0x237C460", VA = "0x18237D860")]
		private void _ClearFromBattleCoroutine(UIPage page)
		{
		}

		// Token: 0x060282F1 RID: 164593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282F1")]
		[Address(RVA = "0x237D770", Offset = "0x237C370", VA = "0x18237D770")]
		private void _AnimateTower()
		{
		}

		// Token: 0x060282F2 RID: 164594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282F2")]
		[Address(RVA = "0x237D6C0", Offset = "0x237C2C0", VA = "0x18237D6C0")]
		private IEnumerator _AnimateTowerCoroutine()
		{
			return null;
		}

		// Token: 0x060282F3 RID: 164595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282F3")]
		[Address(RVA = "0x237DA20", Offset = "0x237C620", VA = "0x18237DA20")]
		private void _ClearTowerCoroutine(UIPage page)
		{
		}

		// Token: 0x060282F4 RID: 164596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282F4")]
		[Address(RVA = "0x237E990", Offset = "0x237D590", VA = "0x18237E990")]
		private void _TriggerGuideAutoShow(UIPage page)
		{
		}

		// Token: 0x060282F5 RID: 164597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282F5")]
		[Address(RVA = "0x237E8E0", Offset = "0x237D4E0", VA = "0x18237E8E0")]
		private IEnumerator _TriggerGuideAutoShowCoroutine()
		{
			return null;
		}

		// Token: 0x060282F6 RID: 164598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282F6")]
		[Address(RVA = "0x237D940", Offset = "0x237C540", VA = "0x18237D940")]
		private void _ClearGuideCoroutine(UIPage page)
		{
		}

		// Token: 0x060282F7 RID: 164599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282F7")]
		[Address(RVA = "0x237DDD0", Offset = "0x237C9D0", VA = "0x18237DDD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060282F8 RID: 164600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282F8")]
		[Address(RVA = "0x237DD20", Offset = "0x237C920", VA = "0x18237DD20")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x060282F9 RID: 164601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282F9")]
		[Address(RVA = "0x237EAD0", Offset = "0x237D6D0", VA = "0x18237EAD0")]
		private void _UpdateBackground(ActVecBreakV2OffensePage page)
		{
		}

		// Token: 0x060282FA RID: 164602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282FA")]
		[Address(RVA = "0x237EC30", Offset = "0x237D830", VA = "0x18237EC30")]
		public ActVecBreakV2OffenseStageSelectState()
		{
		}

		// Token: 0x060282FB RID: 164603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282FB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060282FC RID: 164604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282FC")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x060282FD RID: 164605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282FD")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04039104 RID: 233732
		[Token(Token = "0x4039104")]
		[NonSerialized]
		public const int ON_NAV_PREV = 1;

		// Token: 0x04039105 RID: 233733
		[Token(Token = "0x4039105")]
		[NonSerialized]
		public const int ON_NAV_NEXT = 2;

		// Token: 0x04039106 RID: 233734
		[Token(Token = "0x4039106")]
		[NonSerialized]
		public const int ON_OPEN_ENEMY_DETAIL = 3;

		// Token: 0x04039107 RID: 233735
		[Token(Token = "0x4039107")]
		[NonSerialized]
		public const int ON_OPEN_MAP_PREVIEW = 4;

		// Token: 0x04039108 RID: 233736
		[Token(Token = "0x4039108")]
		[NonSerialized]
		public const int ON_OPEN_SQUAD = 5;

		// Token: 0x04039109 RID: 233737
		[Token(Token = "0x4039109")]
		[NonSerialized]
		public const int ON_ENTER_RAID_MODE = 6;

		// Token: 0x0403910A RID: 233738
		[Token(Token = "0x403910A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403910B RID: 233739
		[Token(Token = "0x403910B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActVecBreakV2OffenseBackground _background;

		// Token: 0x0403910C RID: 233740
		[Token(Token = "0x403910C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ActVecBreakV2OffenseStageSelectView _stageSelectView;

		// Token: 0x0403910D RID: 233741
		[Token(Token = "0x403910D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _towerAnimDelay;

		// Token: 0x0403910E RID: 233742
		[Token(Token = "0x403910E")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _enterTowerAnimDelay;

		// Token: 0x0403910F RID: 233743
		[Token(Token = "0x403910F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _btnDelay;

		// Token: 0x04039110 RID: 233744
		[Token(Token = "0x4039110")]
		[FieldOffset(Offset = "0x94")]
		private bool m_inited;

		// Token: 0x04039111 RID: 233745
		[Token(Token = "0x4039111")]
		[FieldOffset(Offset = "0x98")]
		private string m_actId;

		// Token: 0x04039112 RID: 233746
		[Token(Token = "0x4039112")]
		[FieldOffset(Offset = "0xA0")]
		private ActVecBreakV2OffenseProp m_prop;

		// Token: 0x04039113 RID: 233747
		[Token(Token = "0x4039113")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine m_guidebookCoroutine;

		// Token: 0x04039114 RID: 233748
		[Token(Token = "0x4039114")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine m_towerCoroutine;

		// Token: 0x04039115 RID: 233749
		[Token(Token = "0x4039115")]
		[FieldOffset(Offset = "0xB8")]
		private Coroutine m_enterFromBattleCoroutine;

		// Token: 0x04039116 RID: 233750
		[Token(Token = "0x4039116")]
		[FieldOffset(Offset = "0xC0")]
		private WaitForSeconds m_wait;

		// Token: 0x04039117 RID: 233751
		[Token(Token = "0x4039117")]
		[FieldOffset(Offset = "0xC8")]
		private WaitForSeconds m_enterWait;

		// Token: 0x04039118 RID: 233752
		[Token(Token = "0x4039118")]
		[FieldOffset(Offset = "0xD0")]
		private WaitForSeconds m_btnWait;

		// Token: 0x04039119 RID: 233753
		[Token(Token = "0x4039119")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403911A RID: 233754
		[Token(Token = "0x403911A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403911B RID: 233755
		[Token(Token = "0x403911B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0403911C RID: 233756
		[Token(Token = "0x403911C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403911D RID: 233757
		[Token(Token = "0x403911D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403911E RID: 233758
		[Token(Token = "0x403911E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnNavPrev;

		// Token: 0x0403911F RID: 233759
		[Token(Token = "0x403911F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnNavNext;

		// Token: 0x04039120 RID: 233760
		[Token(Token = "0x4039120")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnOpenEnemyDetail;

		// Token: 0x04039121 RID: 233761
		[Token(Token = "0x4039121")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnOpenMapPreview;

		// Token: 0x04039122 RID: 233762
		[Token(Token = "0x4039122")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnOpenSquadPage;

		// Token: 0x04039123 RID: 233763
		[Token(Token = "0x4039123")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnEnterRaidMode;

		// Token: 0x04039124 RID: 233764
		[Token(Token = "0x4039124")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EnterFromBattle;

		// Token: 0x04039125 RID: 233765
		[Token(Token = "0x4039125")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EnterFromBattleCoroutine;

		// Token: 0x04039126 RID: 233766
		[Token(Token = "0x4039126")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ClearFromBattleCoroutine;

		// Token: 0x04039127 RID: 233767
		[Token(Token = "0x4039127")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__AnimateTower;

		// Token: 0x04039128 RID: 233768
		[Token(Token = "0x4039128")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__AnimateTowerCoroutine;

		// Token: 0x04039129 RID: 233769
		[Token(Token = "0x4039129")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearTowerCoroutine;

		// Token: 0x0403912A RID: 233770
		[Token(Token = "0x403912A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TriggerGuideAutoShow;

		// Token: 0x0403912B RID: 233771
		[Token(Token = "0x403912B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TriggerGuideAutoShowCoroutine;

		// Token: 0x0403912C RID: 233772
		[Token(Token = "0x403912C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ClearGuideCoroutine;

		// Token: 0x0403912D RID: 233773
		[Token(Token = "0x403912D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403912E RID: 233774
		[Token(Token = "0x403912E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x0403912F RID: 233775
		[Token(Token = "0x403912F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateBackground;

		// Token: 0x04039130 RID: 233776
		[Token(Token = "0x4039130")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
