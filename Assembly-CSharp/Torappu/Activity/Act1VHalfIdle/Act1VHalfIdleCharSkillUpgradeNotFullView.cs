using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007714 RID: 30484
	[Token(Token = "0x2007714")]
	public class Act1VHalfIdleCharSkillUpgradeNotFullView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AD34 RID: 175412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD34")]
		[Address(RVA = "0x269BB50", Offset = "0x269A750", VA = "0x18269BB50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AD35 RID: 175413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD35")]
		[Address(RVA = "0x269B490", Offset = "0x269A090", VA = "0x18269B490")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel)
		{
		}

		// Token: 0x0602AD36 RID: 175414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD36")]
		[Address(RVA = "0x269BF30", Offset = "0x269AB30", VA = "0x18269BF30")]
		private void _OnIncreaseBtnClicked()
		{
		}

		// Token: 0x0602AD37 RID: 175415 RVA: 0x000DA2B0 File Offset: 0x000D84B0
		[Token(Token = "0x602AD37")]
		[Address(RVA = "0x269C030", Offset = "0x269AC30", VA = "0x18269C030")]
		private bool _OnIncreaseBtnLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0602AD38 RID: 175416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD38")]
		[Address(RVA = "0x269BD30", Offset = "0x269A930", VA = "0x18269BD30")]
		private void _OnDecreaseBtnClicked()
		{
		}

		// Token: 0x0602AD39 RID: 175417 RVA: 0x000DA2C8 File Offset: 0x000D84C8
		[Token(Token = "0x602AD39")]
		[Address(RVA = "0x269BE30", Offset = "0x269AA30", VA = "0x18269BE30")]
		private bool _OnDecreaseBtnLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0602AD3A RID: 175418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD3A")]
		[Address(RVA = "0x269B280", Offset = "0x2699E80", VA = "0x18269B280")]
		public void OnBtnMinClicked()
		{
		}

		// Token: 0x0602AD3B RID: 175419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD3B")]
		[Address(RVA = "0x269B1E0", Offset = "0x2699DE0", VA = "0x18269B1E0")]
		public void OnBtnMaxClicked()
		{
		}

		// Token: 0x0602AD3C RID: 175420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD3C")]
		[Address(RVA = "0x269B320", Offset = "0x2699F20", VA = "0x18269B320")]
		public void OnBtnUpgradeClicked()
		{
		}

		// Token: 0x0602AD3D RID: 175421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD3D")]
		[Address(RVA = "0x269B3C0", Offset = "0x2699FC0", VA = "0x18269B3C0")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AD3E RID: 175422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD3E")]
		[Address(RVA = "0x269C130", Offset = "0x269AD30", VA = "0x18269C130")]
		public Act1VHalfIdleCharSkillUpgradeNotFullView()
		{
		}

		// Token: 0x0403DB86 RID: 252806
		[Token(Token = "0x403DB86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlNoSkill;

		// Token: 0x0403DB87 RID: 252807
		[Token(Token = "0x403DB87")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlHasSkill;

		// Token: 0x0403DB88 RID: 252808
		[Token(Token = "0x403DB88")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCurrCount;

		// Token: 0x0403DB89 RID: 252809
		[Token(Token = "0x403DB89")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlItemEnough;

		// Token: 0x0403DB8A RID: 252810
		[Token(Token = "0x403DB8A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlItemNotEnough;

		// Token: 0x0403DB8B RID: 252811
		[Token(Token = "0x403DB8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x0403DB8C RID: 252812
		[Token(Token = "0x403DB8C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textLocked;

		// Token: 0x0403DB8D RID: 252813
		[Token(Token = "0x403DB8D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act1VHalfIdleCharSkillUpgradeNotFullView.ItemCostView _itemViewEnough;

		// Token: 0x0403DB8E RID: 252814
		[Token(Token = "0x403DB8E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act1VHalfIdleCharSkillUpgradeNotFullView.ItemCostView _itemViewNotEnough;

		// Token: 0x0403DB8F RID: 252815
		[Token(Token = "0x403DB8F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UILongPressButtonEx _btnIncrease;

		// Token: 0x0403DB90 RID: 252816
		[Token(Token = "0x403DB90")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UILongPressButtonEx _btnDecrease;

		// Token: 0x0403DB91 RID: 252817
		[Token(Token = "0x403DB91")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfIdleCharSkillUpgradeSkillRankView _rankBefore;

		// Token: 0x0403DB92 RID: 252818
		[Token(Token = "0x403DB92")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfIdleCharSkillUpgradeSkillRankView _rankAfter;

		// Token: 0x0403DB93 RID: 252819
		[Token(Token = "0x403DB93")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlUpgradeLight;

		// Token: 0x0403DB94 RID: 252820
		[Token(Token = "0x403DB94")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _upgradeLightDuration;

		// Token: 0x0403DB95 RID: 252821
		[Token(Token = "0x403DB95")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _pnlTextDiscount;

		// Token: 0x0403DB96 RID: 252822
		[Token(Token = "0x403DB96")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textDiscount;

		// Token: 0x0403DB97 RID: 252823
		[Token(Token = "0x403DB97")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _pnlDiscountGO;

		// Token: 0x0403DB98 RID: 252824
		[Token(Token = "0x403DB98")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _btnUpgradeGO;

		// Token: 0x0403DB99 RID: 252825
		[Token(Token = "0x403DB99")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x0403DB9A RID: 252826
		[Token(Token = "0x403DB9A")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DB9B RID: 252827
		[Token(Token = "0x403DB9B")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_cachedHasSkill;

		// Token: 0x0403DB9C RID: 252828
		[Token(Token = "0x403DB9C")]
		[FieldOffset(Offset = "0xCC")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403DB9D RID: 252829
		[Token(Token = "0x403DB9D")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cachedSwitchCharSeqNum;

		// Token: 0x0403DB9E RID: 252830
		[Token(Token = "0x403DB9E")]
		[FieldOffset(Offset = "0xD4")]
		private int m_cachedUpgradeSkillSeqNum;

		// Token: 0x0403DB9F RID: 252831
		[Token(Token = "0x403DB9F")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_skillUpgradeTween;

		// Token: 0x0403DBA0 RID: 252832
		[Token(Token = "0x403DBA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DBA1 RID: 252833
		[Token(Token = "0x403DBA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DBA2 RID: 252834
		[Token(Token = "0x403DBA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnClicked;

		// Token: 0x0403DBA3 RID: 252835
		[Token(Token = "0x403DBA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnLongPressed;

		// Token: 0x0403DBA4 RID: 252836
		[Token(Token = "0x403DBA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnClicked;

		// Token: 0x0403DBA5 RID: 252837
		[Token(Token = "0x403DBA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnLongPressed;

		// Token: 0x0403DBA6 RID: 252838
		[Token(Token = "0x403DBA6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnMinClicked;

		// Token: 0x0403DBA7 RID: 252839
		[Token(Token = "0x403DBA7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnMaxClicked;

		// Token: 0x0403DBA8 RID: 252840
		[Token(Token = "0x403DBA8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBtnUpgradeClicked;

		// Token: 0x0403DBA9 RID: 252841
		[Token(Token = "0x403DBA9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DBAA RID: 252842
		[Token(Token = "0x403DBAA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007715 RID: 30485
		[Token(Token = "0x2007715")]
		[Serializable]
		private class ItemCostView : IHotfixable
		{
			// Token: 0x0602AD41 RID: 175425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD41")]
			[Address(RVA = "0x26A79C0", Offset = "0x26A65C0", VA = "0x1826A79C0")]
			public void Render(Act1VHalfIdleCharUpgradeViewModel.CharUpgradeItemShowParam itemShowParam, ILoadAsset assetLoader)
			{
			}

			// Token: 0x0602AD42 RID: 175426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD42")]
			[Address(RVA = "0x26A7B60", Offset = "0x26A6760", VA = "0x1826A7B60")]
			public ItemCostView()
			{
			}

			// Token: 0x0403DBAB RID: 252843
			[Token(Token = "0x403DBAB")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlCountDiscount;

			// Token: 0x0403DBAC RID: 252844
			[Token(Token = "0x403DBAC")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textCountOriginal;

			// Token: 0x0403DBAD RID: 252845
			[Token(Token = "0x403DBAD")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textCountRequired;

			// Token: 0x0403DBAE RID: 252846
			[Token(Token = "0x403DBAE")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image _imgItemIcon;

			// Token: 0x0403DBAF RID: 252847
			[Token(Token = "0x403DBAF")]
			[FieldOffset(Offset = "0x30")]
			private string m_cachedItemId;

			// Token: 0x0403DBB0 RID: 252848
			[Token(Token = "0x403DBB0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403DBB1 RID: 252849
			[Token(Token = "0x403DBB1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
