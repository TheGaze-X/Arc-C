using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E4A RID: 28234
	[Token(Token = "0x2006E4A")]
	public class ActVecBreakV2OffenseStageSelectRaidState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060282D5 RID: 164565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60282D5")]
		[Address(RVA = "0x237A2F0", Offset = "0x2378EF0", VA = "0x18237A2F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060282D6 RID: 164566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282D6")]
		[Address(RVA = "0x237A350", Offset = "0x2378F50", VA = "0x18237A350", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060282D7 RID: 164567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282D7")]
		[Address(RVA = "0x237A6C0", Offset = "0x23792C0", VA = "0x18237A6C0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060282D8 RID: 164568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282D8")]
		[Address(RVA = "0x237A7A0", Offset = "0x23793A0", VA = "0x18237A7A0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060282D9 RID: 164569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282D9")]
		[Address(RVA = "0x237AE70", Offset = "0x2379A70", VA = "0x18237AE70")]
		private void _OnClickStageInfo(string orderId)
		{
		}

		// Token: 0x060282DA RID: 164570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282DA")]
		[Address(RVA = "0x237B250", Offset = "0x2379E50", VA = "0x18237B250")]
		private void _OnOpenMapPreview()
		{
		}

		// Token: 0x060282DB RID: 164571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282DB")]
		[Address(RVA = "0x237B140", Offset = "0x2379D40", VA = "0x18237B140")]
		private void _OnOpenEnemyDetail()
		{
		}

		// Token: 0x060282DC RID: 164572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282DC")]
		[Address(RVA = "0x237B360", Offset = "0x2379F60", VA = "0x18237B360")]
		private void _OnOpenSquadPage()
		{
		}

		// Token: 0x060282DD RID: 164573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282DD")]
		[Address(RVA = "0x237B030", Offset = "0x2379C30", VA = "0x18237B030")]
		private void _OnEnterNormalMode()
		{
		}

		// Token: 0x060282DE RID: 164574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282DE")]
		[Address(RVA = "0x237AD70", Offset = "0x2379970", VA = "0x18237AD70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060282DF RID: 164575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282DF")]
		[Address(RVA = "0x237ACC0", Offset = "0x23798C0", VA = "0x18237ACC0")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x060282E0 RID: 164576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E0")]
		[Address(RVA = "0x237B660", Offset = "0x237A260", VA = "0x18237B660")]
		public ActVecBreakV2OffenseStageSelectRaidState()
		{
		}

		// Token: 0x060282E1 RID: 164577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060282E2 RID: 164578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282E2")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x040390EE RID: 233710
		[Token(Token = "0x40390EE")]
		[NonSerialized]
		public const int ON_CLICK_STAGE_INFO = 1;

		// Token: 0x040390EF RID: 233711
		[Token(Token = "0x40390EF")]
		[NonSerialized]
		public const int ON_OPEN_MAP_PREVIEW = 2;

		// Token: 0x040390F0 RID: 233712
		[Token(Token = "0x40390F0")]
		[NonSerialized]
		public const int ON_OPEN_ENEMY_DETAIL = 3;

		// Token: 0x040390F1 RID: 233713
		[Token(Token = "0x40390F1")]
		[NonSerialized]
		public const int ON_OPEN_SQUAD = 4;

		// Token: 0x040390F2 RID: 233714
		[Token(Token = "0x40390F2")]
		[NonSerialized]
		public const int ON_ENTER_NORMAL_MODE = 5;

		// Token: 0x040390F3 RID: 233715
		[Token(Token = "0x40390F3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040390F4 RID: 233716
		[Token(Token = "0x40390F4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActVecBreakV2OffenseStageSelectRaidView _stageSelectView;

		// Token: 0x040390F5 RID: 233717
		[Token(Token = "0x40390F5")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x040390F6 RID: 233718
		[Token(Token = "0x40390F6")]
		[FieldOffset(Offset = "0x88")]
		private string m_actId;

		// Token: 0x040390F7 RID: 233719
		[Token(Token = "0x40390F7")]
		[FieldOffset(Offset = "0x90")]
		private ActVecBreakV2OffenseRaidProp m_prop;

		// Token: 0x040390F8 RID: 233720
		[Token(Token = "0x40390F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040390F9 RID: 233721
		[Token(Token = "0x40390F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040390FA RID: 233722
		[Token(Token = "0x40390FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040390FB RID: 233723
		[Token(Token = "0x40390FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040390FC RID: 233724
		[Token(Token = "0x40390FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnClickStageInfo;

		// Token: 0x040390FD RID: 233725
		[Token(Token = "0x40390FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnOpenMapPreview;

		// Token: 0x040390FE RID: 233726
		[Token(Token = "0x40390FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnOpenEnemyDetail;

		// Token: 0x040390FF RID: 233727
		[Token(Token = "0x40390FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnOpenSquadPage;

		// Token: 0x04039100 RID: 233728
		[Token(Token = "0x4039100")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnEnterNormalMode;

		// Token: 0x04039101 RID: 233729
		[Token(Token = "0x4039101")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039102 RID: 233730
		[Token(Token = "0x4039102")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04039103 RID: 233731
		[Token(Token = "0x4039103")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
