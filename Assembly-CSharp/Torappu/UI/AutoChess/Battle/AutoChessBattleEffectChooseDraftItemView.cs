using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064AF RID: 25775
	[Token(Token = "0x20064AF")]
	public class AutoChessBattleEffectChooseDraftItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060250DD RID: 151773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250DD")]
		[Address(RVA = "0x1FDEC00", Offset = "0x1FDD800", VA = "0x181FDEC00")]
		public void Render(AutoChessBattleEffectChooseDraftItemModel model, AutoChessBattleEffectChooseDraftModel draftModel, AutoChessBattleEffectChooseDraftItemView.Params param)
		{
		}

		// Token: 0x060250DE RID: 151774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250DE")]
		[Address(RVA = "0x1FDF1C0", Offset = "0x1FDDDC0", VA = "0x181FDF1C0")]
		private void _RegisterTutorialGOIfNeed(AutoChessBattleEffectChooseDraftModel draftModel, AutoChessBattleEffectChooseDraftItemModel model)
		{
		}

		// Token: 0x060250DF RID: 151775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250DF")]
		[Address(RVA = "0x1FDEA80", Offset = "0x1FDD680", VA = "0x181FDEA80")]
		public void OnSelectItem()
		{
		}

		// Token: 0x060250E0 RID: 151776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E0")]
		[Address(RVA = "0x1FDE990", Offset = "0x1FDD590", VA = "0x181FDE990")]
		public void OnConfirmItemSelection()
		{
		}

		// Token: 0x060250E1 RID: 151777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E1")]
		[Address(RVA = "0x1FDEF80", Offset = "0x1FDDB80", VA = "0x181FDEF80")]
		public void SetGroup(ExclusiveSelectionGroup group)
		{
		}

		// Token: 0x060250E2 RID: 151778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E2")]
		[Address(RVA = "0x1FDF020", Offset = "0x1FDDC20", VA = "0x181FDF020")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060250E3 RID: 151779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E3")]
		[Address(RVA = "0x1FDF580", Offset = "0x1FDE180", VA = "0x181FDF580")]
		private void _RenderContent(AutoChessBattleEffectChooseDraftItemModel model)
		{
		}

		// Token: 0x060250E4 RID: 151780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E4")]
		[Address(RVA = "0x1FDFBB0", Offset = "0x1FDE7B0", VA = "0x181FDFBB0")]
		private void _RenderEquipItem(AutoChessBattleEffectChooseDraftEquipItemModel model)
		{
		}

		// Token: 0x060250E5 RID: 151781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E5")]
		[Address(RVA = "0x1FDFA00", Offset = "0x1FDE600", VA = "0x181FDFA00")]
		private void _RenderEnemyItem(AutoChessBattleEffectChooseDraftEnemyItemModel model)
		{
		}

		// Token: 0x060250E6 RID: 151782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E6")]
		[Address(RVA = "0x1FDF3F0", Offset = "0x1FDDFF0", VA = "0x181FDF3F0")]
		private void _RenderBuffItem(AutoChessBattleEffectChooseDraftBuffItemModel model)
		{
		}

		// Token: 0x060250E7 RID: 151783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E7")]
		[Address(RVA = "0x1FDFEB0", Offset = "0x1FDEAB0", VA = "0x181FDFEB0")]
		private void _RenderSelection(AutoChessBattleEffectChooseDraftItemModel model, bool isFirstShow, AutoChessBattleSpPrepareStepModel.Step curStep)
		{
		}

		// Token: 0x060250E8 RID: 151784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250E8")]
		[Address(RVA = "0x1FDFFA0", Offset = "0x1FDEBA0", VA = "0x181FDFFA0")]
		public AutoChessBattleEffectChooseDraftItemView()
		{
		}

		// Token: 0x04033DFD RID: 212477
		[Token(Token = "0x4033DFD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04033DFE RID: 212478
		[Token(Token = "0x4033DFE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04033DFF RID: 212479
		[Token(Token = "0x4033DFF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04033E00 RID: 212480
		[Token(Token = "0x4033E00")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessComLevel _comLevel;

		// Token: 0x04033E01 RID: 212481
		[Token(Token = "0x4033E01")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _priceObj;

		// Token: 0x04033E02 RID: 212482
		[Token(Token = "0x4033E02")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _availPriceText;

		// Token: 0x04033E03 RID: 212483
		[Token(Token = "0x4033E03")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _unavailPriceText;

		// Token: 0x04033E04 RID: 212484
		[Token(Token = "0x4033E04")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _priceToggle;

		// Token: 0x04033E05 RID: 212485
		[Token(Token = "0x4033E05")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _avatarContent;

		// Token: 0x04033E06 RID: 212486
		[Token(Token = "0x4033E06")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _availSwitchAnim;

		// Token: 0x04033E07 RID: 212487
		[Token(Token = "0x4033E07")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TwoPhaseButtonWidget _cardBtn;

		// Token: 0x04033E08 RID: 212488
		[Token(Token = "0x4033E08")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _btnExpand;

		// Token: 0x04033E09 RID: 212489
		[Token(Token = "0x4033E09")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x04033E0A RID: 212490
		[Token(Token = "0x4033E0A")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x04033E0B RID: 212491
		[Token(Token = "0x4033E0B")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033E0C RID: 212492
		[Token(Token = "0x4033E0C")]
		[FieldOffset(Offset = "0xA0")]
		private AutoChessBattleEffectChooseDraftItemView.AvatarListAdapter m_avatarAdapter;

		// Token: 0x04033E0D RID: 212493
		[Token(Token = "0x4033E0D")]
		[FieldOffset(Offset = "0xA8")]
		private AutoChessBattleEffectChooseDraftItemModel m_cachedModel;

		// Token: 0x04033E0E RID: 212494
		[Token(Token = "0x4033E0E")]
		[FieldOffset(Offset = "0xB0")]
		private AutoChessBattleSpPrepareStepModel.Step m_cachedStep;

		// Token: 0x04033E0F RID: 212495
		[Token(Token = "0x4033E0F")]
		[FieldOffset(Offset = "0xB4")]
		private AutoChessEffectChooseDataModel.AutoChessBattleEffectChooseMode m_cachedMode;

		// Token: 0x04033E10 RID: 212496
		[Token(Token = "0x4033E10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033E11 RID: 212497
		[Token(Token = "0x4033E11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGOIfNeed;

		// Token: 0x04033E12 RID: 212498
		[Token(Token = "0x4033E12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSelectItem;

		// Token: 0x04033E13 RID: 212499
		[Token(Token = "0x4033E13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnConfirmItemSelection;

		// Token: 0x04033E14 RID: 212500
		[Token(Token = "0x4033E14")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetGroup;

		// Token: 0x04033E15 RID: 212501
		[Token(Token = "0x4033E15")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033E16 RID: 212502
		[Token(Token = "0x4033E16")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderContent;

		// Token: 0x04033E17 RID: 212503
		[Token(Token = "0x4033E17")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderEquipItem;

		// Token: 0x04033E18 RID: 212504
		[Token(Token = "0x4033E18")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderEnemyItem;

		// Token: 0x04033E19 RID: 212505
		[Token(Token = "0x4033E19")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderBuffItem;

		// Token: 0x04033E1A RID: 212506
		[Token(Token = "0x4033E1A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderSelection;

		// Token: 0x04033E1B RID: 212507
		[Token(Token = "0x4033E1B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064B0 RID: 25776
		[Token(Token = "0x20064B0")]
		public struct Params
		{
			// Token: 0x04033E1C RID: 212508
			[Token(Token = "0x4033E1C")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessBattleSpPrepareStepModel.Step curStep;

			// Token: 0x04033E1D RID: 212509
			[Token(Token = "0x4033E1D")]
			[FieldOffset(Offset = "0x4")]
			public AutoChessEffectChooseDataModel.AutoChessBattleEffectChooseMode mode;

			// Token: 0x04033E1E RID: 212510
			[Token(Token = "0x4033E1E")]
			[FieldOffset(Offset = "0x8")]
			public bool isFirstShow;
		}

		// Token: 0x020064B1 RID: 25777
		[Token(Token = "0x20064B1")]
		private class AvatarListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060250EA RID: 151786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250EA")]
			[Address(RVA = "0x1FF0370", Offset = "0x1FEEF70", VA = "0x181FF0370")]
			public AvatarListAdapter(AutoChessBattleEffectChooseDraftItemView closure)
			{
			}

			// Token: 0x17005773 RID: 22387
			// (get) Token: 0x060250EB RID: 151787 RVA: 0x000C6528 File Offset: 0x000C4728
			[Token(Token = "0x17005773")]
			public override int count
			{
				[Token(Token = "0x60250EB")]
				[Address(RVA = "0x1FF03F0", Offset = "0x1FEEFF0", VA = "0x181FF03F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060250EC RID: 151788 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60250EC")]
			[Address(RVA = "0x1FF0110", Offset = "0x1FEED10", VA = "0x181FF0110", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04033E1F RID: 212511
			[Token(Token = "0x4033E1F")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessBattleEffectChooseDraftItemView m_closure;

			// Token: 0x04033E20 RID: 212512
			[Token(Token = "0x4033E20")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033E21 RID: 212513
			[Token(Token = "0x4033E21")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033E22 RID: 212514
			[Token(Token = "0x4033E22")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
