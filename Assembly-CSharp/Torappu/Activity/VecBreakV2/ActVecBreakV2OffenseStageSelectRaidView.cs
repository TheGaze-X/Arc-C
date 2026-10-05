using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E60 RID: 28256
	[Token(Token = "0x2006E60")]
	public class ActVecBreakV2OffenseStageSelectRaidView : DataBinder<ActVecBreakV2OffenseRaidProp>
	{
		// Token: 0x06028364 RID: 164708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028364")]
		[Address(RVA = "0x237B810", Offset = "0x237A410", VA = "0x18237B810", Slot = "7")]
		public override void OnValueChanged(ActVecBreakV2OffenseRaidProp property)
		{
		}

		// Token: 0x06028365 RID: 164709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028365")]
		[Address(RVA = "0x237B780", Offset = "0x237A380", VA = "0x18237B780")]
		public void OnEnterNormalMode()
		{
		}

		// Token: 0x06028366 RID: 164710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028366")]
		[Address(RVA = "0x237BD20", Offset = "0x237A920", VA = "0x18237BD20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028367 RID: 164711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028367")]
		[Address(RVA = "0x237C230", Offset = "0x237AE30", VA = "0x18237C230")]
		private void _RenderStageDetail(bool isFirstRender)
		{
		}

		// Token: 0x06028368 RID: 164712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028368")]
		[Address(RVA = "0x237C170", Offset = "0x237AD70", VA = "0x18237C170")]
		private void _PlaySelectAnim(bool isFirstRender, VecBreakV2OffenseStageModelBase stageModel)
		{
		}

		// Token: 0x06028369 RID: 164713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028369")]
		[Address(RVA = "0x237C460", Offset = "0x237B060", VA = "0x18237C460")]
		private void _RenderTower()
		{
		}

		// Token: 0x0602836A RID: 164714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602836A")]
		[Address(RVA = "0x237C000", Offset = "0x237AC00", VA = "0x18237C000")]
		private void _PlayEnterAnim(bool isFirstRender)
		{
		}

		// Token: 0x0602836B RID: 164715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602836B")]
		[Address(RVA = "0x237BE50", Offset = "0x237AA50", VA = "0x18237BE50")]
		private void _OnClickEnemyDetail()
		{
		}

		// Token: 0x0602836C RID: 164716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602836C")]
		[Address(RVA = "0x237BEE0", Offset = "0x237AAE0", VA = "0x18237BEE0")]
		private void _OnClickMapPreview()
		{
		}

		// Token: 0x0602836D RID: 164717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602836D")]
		[Address(RVA = "0x237BF70", Offset = "0x237AB70", VA = "0x18237BF70")]
		private void _OnOpenSquad()
		{
		}

		// Token: 0x0602836E RID: 164718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602836E")]
		[Address(RVA = "0x237C580", Offset = "0x237B180", VA = "0x18237C580")]
		public ActVecBreakV2OffenseStageSelectRaidView()
		{
		}

		// Token: 0x04039241 RID: 234049
		[Token(Token = "0x4039241")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Stage Detail")]
		private RectTransform _stageDetailRoot;

		// Token: 0x04039242 RID: 234050
		[Token(Token = "0x4039242")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Stage Detail")]
		private ActVecBreakV2OffenseStageDetailView _stageDetailViewPrefab;

		// Token: 0x04039243 RID: 234051
		[Token(Token = "0x4039243")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Tower")]
		private ActVecBreakV2OffenseStageRaidViewHolder[] _stageViewHolders;

		// Token: 0x04039244 RID: 234052
		[Token(Token = "0x4039244")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _enterAnimLocation;

		// Token: 0x04039245 RID: 234053
		[Token(Token = "0x4039245")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _selectAnimLocation;

		// Token: 0x04039246 RID: 234054
		[Token(Token = "0x4039246")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04039247 RID: 234055
		[Token(Token = "0x4039247")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039248 RID: 234056
		[Token(Token = "0x4039248")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_enterTween;

		// Token: 0x04039249 RID: 234057
		[Token(Token = "0x4039249")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x0403924A RID: 234058
		[Token(Token = "0x403924A")]
		[FieldOffset(Offset = "0x80")]
		private VecBreakV2OffenseRaidModel m_cachedModel;

		// Token: 0x0403924B RID: 234059
		[Token(Token = "0x403924B")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedEnterSeqNum;

		// Token: 0x0403924C RID: 234060
		[Token(Token = "0x403924C")]
		[FieldOffset(Offset = "0x90")]
		private ActVecBreakV2OffenseStageDetailView m_stageDetailView;

		// Token: 0x0403924D RID: 234061
		[Token(Token = "0x403924D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403924E RID: 234062
		[Token(Token = "0x403924E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnterNormalMode;

		// Token: 0x0403924F RID: 234063
		[Token(Token = "0x403924F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039250 RID: 234064
		[Token(Token = "0x4039250")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderStageDetail;

		// Token: 0x04039251 RID: 234065
		[Token(Token = "0x4039251")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlaySelectAnim;

		// Token: 0x04039252 RID: 234066
		[Token(Token = "0x4039252")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderTower;

		// Token: 0x04039253 RID: 234067
		[Token(Token = "0x4039253")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04039254 RID: 234068
		[Token(Token = "0x4039254")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnClickEnemyDetail;

		// Token: 0x04039255 RID: 234069
		[Token(Token = "0x4039255")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClickMapPreview;

		// Token: 0x04039256 RID: 234070
		[Token(Token = "0x4039256")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnOpenSquad;

		// Token: 0x04039257 RID: 234071
		[Token(Token = "0x4039257")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
