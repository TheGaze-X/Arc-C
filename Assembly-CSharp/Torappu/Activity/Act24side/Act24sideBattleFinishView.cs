using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007566 RID: 30054
	[Token(Token = "0x2007566")]
	public class Act24sideBattleFinishView : ActivityBattleFinishView
	{
		// Token: 0x0602A50E RID: 173326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A50E")]
		[Address(RVA = "0x25F55A0", Offset = "0x25F41A0", VA = "0x1825F55A0", Slot = "11")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602A50F RID: 173327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A50F")]
		[Address(RVA = "0x25F5CD0", Offset = "0x25F48D0", VA = "0x1825F5CD0")]
		private void _Render()
		{
		}

		// Token: 0x0602A510 RID: 173328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A510")]
		[Address(RVA = "0x25F59D0", Offset = "0x25F45D0", VA = "0x1825F59D0")]
		private IEnumerator _FinishBattleActCoroutine()
		{
			return null;
		}

		// Token: 0x0602A511 RID: 173329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A511")]
		[Address(RVA = "0x25F5B30", Offset = "0x25F4730", VA = "0x1825F5B30")]
		private void _RenderDrop()
		{
		}

		// Token: 0x0602A512 RID: 173330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A512")]
		[Address(RVA = "0x25F5A80", Offset = "0x25F4680", VA = "0x1825F5A80")]
		private IEnumerator _RenderDropCoroutine()
		{
			return null;
		}

		// Token: 0x0602A513 RID: 173331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A513")]
		[Address(RVA = "0x25F5510", Offset = "0x25F4110", VA = "0x1825F5510")]
		public void EventOnPageClicked()
		{
		}

		// Token: 0x0602A514 RID: 173332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A514")]
		[Address(RVA = "0x25F5ED0", Offset = "0x25F4AD0", VA = "0x1825F5ED0")]
		public Act24sideBattleFinishView()
		{
		}

		// Token: 0x0403CD95 RID: 249237
		[Token(Token = "0x403CD95")]
		private const float PASTTIME = 0.2f;

		// Token: 0x0403CD96 RID: 249238
		[Token(Token = "0x403CD96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFullScreenImage _blurBackground;

		// Token: 0x0403CD97 RID: 249239
		[Token(Token = "0x403CD97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIExpBar _playerExpBar;

		// Token: 0x0403CD98 RID: 249240
		[Token(Token = "0x403CD98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act24sideBattleFinishInfoView _battleInfoView;

		// Token: 0x0403CD99 RID: 249241
		[Token(Token = "0x403CD99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BattleFinishDropInfoView _dropInfoView;

		// Token: 0x0403CD9A RID: 249242
		[Token(Token = "0x403CD9A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act24sideBattleFinishMeldingDropInfoView _meldingDropInfoView;

		// Token: 0x0403CD9B RID: 249243
		[Token(Token = "0x403CD9B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _meldingDropRoot;

		// Token: 0x0403CD9C RID: 249244
		[Token(Token = "0x403CD9C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BattleFinishIllustView _illustView;

		// Token: 0x0403CD9D RID: 249245
		[Token(Token = "0x403CD9D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Animator _favoutAnimator;

		// Token: 0x0403CD9E RID: 249246
		[Token(Token = "0x403CD9E")]
		[FieldOffset(Offset = "0x70")]
		private Act24sideBattleFinishViewModel m_viewModel;

		// Token: 0x0403CD9F RID: 249247
		[Token(Token = "0x403CD9F")]
		[FieldOffset(Offset = "0x78")]
		private UIExpBarController m_expBarController;

		// Token: 0x0403CDA0 RID: 249248
		[Token(Token = "0x403CDA0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isLoadingAnimEnd;

		// Token: 0x0403CDA1 RID: 249249
		[Token(Token = "0x403CDA1")]
		[FieldOffset(Offset = "0x84")]
		private float m_animEndTime;

		// Token: 0x0403CDA2 RID: 249250
		[Token(Token = "0x403CDA2")]
		[FieldOffset(Offset = "0x88")]
		private Act24sideBattleFinishMeldingDropInfoView m_meldingDropInfoView;

		// Token: 0x0403CDA3 RID: 249251
		[Token(Token = "0x403CDA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403CDA4 RID: 249252
		[Token(Token = "0x403CDA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403CDA5 RID: 249253
		[Token(Token = "0x403CDA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FinishBattleActCoroutine;

		// Token: 0x0403CDA6 RID: 249254
		[Token(Token = "0x403CDA6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDrop;

		// Token: 0x0403CDA7 RID: 249255
		[Token(Token = "0x403CDA7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderDropCoroutine;

		// Token: 0x0403CDA8 RID: 249256
		[Token(Token = "0x403CDA8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnPageClicked;

		// Token: 0x0403CDA9 RID: 249257
		[Token(Token = "0x403CDA9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
