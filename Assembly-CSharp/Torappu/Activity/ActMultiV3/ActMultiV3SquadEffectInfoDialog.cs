using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F06 RID: 28422
	[Token(Token = "0x2006F06")]
	public class ActMultiV3SquadEffectInfoDialog : UICompDialog<ActMultiV3SquadEffectInfoDialog.Option>
	{
		// Token: 0x060285FB RID: 165371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285FB")]
		[Address(RVA = "0x23BBD50", Offset = "0x23BA950", VA = "0x1823BBD50", Slot = "18")]
		protected override void OnRender(ActMultiV3SquadEffectInfoDialog.Option input)
		{
		}

		// Token: 0x060285FC RID: 165372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285FC")]
		[Address(RVA = "0x23BBEF0", Offset = "0x23BAAF0", VA = "0x1823BBEF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060285FD RID: 165373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285FD")]
		[Address(RVA = "0x23BC270", Offset = "0x23BAE70", VA = "0x1823BC270")]
		private void _OnItemClick(ActMultiV3SquadEffectModel effectModel, ActMultiV3SquadEffectItemView.Param param)
		{
		}

		// Token: 0x060285FE RID: 165374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285FE")]
		[Address(RVA = "0x23BC3B0", Offset = "0x23BAFB0", VA = "0x1823BC3B0")]
		private void _Refresh(ActMultiV3SquadEffectInfoDialog.ViewModel viewModel)
		{
		}

		// Token: 0x060285FF RID: 165375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285FF")]
		[Address(RVA = "0x23BBC90", Offset = "0x23BA890", VA = "0x1823BBC90")]
		public void Close()
		{
		}

		// Token: 0x06028600 RID: 165376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028600")]
		[Address(RVA = "0x23BC560", Offset = "0x23BB160", VA = "0x1823BC560")]
		public ActMultiV3SquadEffectInfoDialog()
		{
		}

		// Token: 0x04039687 RID: 235143
		[Token(Token = "0x4039687")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3SquadEffectInfoView _infoViewPrefab;

		// Token: 0x04039688 RID: 235144
		[Token(Token = "0x4039688")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _infoViewContainer;

		// Token: 0x04039689 RID: 235145
		[Token(Token = "0x4039689")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ActMultiV3SquadEffectItemView _effectItemViewPrefab;

		// Token: 0x0403968A RID: 235146
		[Token(Token = "0x403968A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform[] _effecItemContainers;

		// Token: 0x0403968B RID: 235147
		[Token(Token = "0x403968B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x0403968C RID: 235148
		[Token(Token = "0x403968C")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0403968D RID: 235149
		[Token(Token = "0x403968D")]
		[FieldOffset(Offset = "0xA0")]
		private ActMultiV3SquadEffectItemView[] m_itemViews;

		// Token: 0x0403968E RID: 235150
		[Token(Token = "0x403968E")]
		[FieldOffset(Offset = "0xA8")]
		private ActMultiV3SquadEffectInfoView m_infoView;

		// Token: 0x0403968F RID: 235151
		[Token(Token = "0x403968F")]
		[FieldOffset(Offset = "0xB0")]
		private ActMultiV3SquadEffectInfoDialog.ViewModel m_viewModel;

		// Token: 0x04039690 RID: 235152
		[Token(Token = "0x4039690")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04039691 RID: 235153
		[Token(Token = "0x4039691")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039692 RID: 235154
		[Token(Token = "0x4039692")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x04039693 RID: 235155
		[Token(Token = "0x4039693")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x04039694 RID: 235156
		[Token(Token = "0x4039694")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x04039695 RID: 235157
		[Token(Token = "0x4039695")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F07 RID: 28423
		[Token(Token = "0x2006F07")]
		public class Option
		{
			// Token: 0x06028601 RID: 165377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028601")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04039696 RID: 235158
			[Token(Token = "0x4039696")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04039697 RID: 235159
			[Token(Token = "0x4039697")]
			[FieldOffset(Offset = "0x18")]
			public string selfEffectId;

			// Token: 0x04039698 RID: 235160
			[Token(Token = "0x4039698")]
			[FieldOffset(Offset = "0x20")]
			public string partnerEffectId;
		}

		// Token: 0x02006F08 RID: 28424
		[Token(Token = "0x2006F08")]
		private class ViewModel
		{
			// Token: 0x06028602 RID: 165378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028602")]
			[Address(RVA = "0x23BDE80", Offset = "0x23BCA80", VA = "0x1823BDE80")]
			public void LoadData(ActMultiV3SquadEffectInfoDialog.Option option)
			{
			}

			// Token: 0x06028603 RID: 165379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028603")]
			[Address(RVA = "0x23BE2E0", Offset = "0x23BCEE0", VA = "0x1823BE2E0")]
			public void Select(int idx)
			{
			}

			// Token: 0x06028604 RID: 165380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028604")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewModel()
			{
			}

			// Token: 0x04039699 RID: 235161
			[Token(Token = "0x4039699")]
			public const int SELF_IDX = 0;

			// Token: 0x0403969A RID: 235162
			[Token(Token = "0x403969A")]
			public const int PARTNER_IDX = 1;

			// Token: 0x0403969B RID: 235163
			[Token(Token = "0x403969B")]
			[FieldOffset(Offset = "0x10")]
			public int selectIdx;

			// Token: 0x0403969C RID: 235164
			[Token(Token = "0x403969C")]
			[FieldOffset(Offset = "0x18")]
			public ActMultiV3SquadEffectModel[] effectModels;

			// Token: 0x0403969D RID: 235165
			[Token(Token = "0x403969D")]
			[FieldOffset(Offset = "0x20")]
			public ActMultiV3SquadEffectItemView.Param[] paramArr;
		}
	}
}
