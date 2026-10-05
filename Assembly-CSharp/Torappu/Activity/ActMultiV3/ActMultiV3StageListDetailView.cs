using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FE9 RID: 28649
	[Token(Token = "0x2006FE9")]
	public class ActMultiV3StageListDetailView : DataBinder<ActMultiV3StageDetailStateProperty>
	{
		// Token: 0x06028B04 RID: 166660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B04")]
		[Address(RVA = "0x2400F80", Offset = "0x23FFB80", VA = "0x182400F80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028B05 RID: 166661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B05")]
		[Address(RVA = "0x2400B20", Offset = "0x23FF720", VA = "0x182400B20", Slot = "7")]
		public override void OnValueChanged(ActMultiV3StageDetailStateProperty property)
		{
		}

		// Token: 0x06028B06 RID: 166662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B06")]
		[Address(RVA = "0x24009F0", Offset = "0x23FF5F0", VA = "0x1824009F0")]
		public void OnBtnLeftClicked()
		{
		}

		// Token: 0x06028B07 RID: 166663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B07")]
		[Address(RVA = "0x2400A80", Offset = "0x23FF680", VA = "0x182400A80")]
		public void OnBtnRightClicked()
		{
		}

		// Token: 0x06028B08 RID: 166664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B08")]
		[Address(RVA = "0x2400960", Offset = "0x23FF560", VA = "0x182400960")]
		public void OnBtnEnemyHandbookClicked()
		{
		}

		// Token: 0x06028B09 RID: 166665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B09")]
		[Address(RVA = "0x2401100", Offset = "0x23FFD00", VA = "0x182401100")]
		public ActMultiV3StageListDetailView()
		{
		}

		// Token: 0x04039FB7 RID: 237495
		[Token(Token = "0x4039FB7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActMultiV3StageListDetailView.AnimConfig[] _animConfigs;

		// Token: 0x04039FB8 RID: 237496
		[Token(Token = "0x4039FB8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _layoutDots;

		// Token: 0x04039FB9 RID: 237497
		[Token(Token = "0x4039FB9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _viewHolder;

		// Token: 0x04039FBA RID: 237498
		[Token(Token = "0x4039FBA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActMultiV3StageDetailView _viewPrefab;

		// Token: 0x04039FBB RID: 237499
		[Token(Token = "0x4039FBB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlEnemyHandbook;

		// Token: 0x04039FBC RID: 237500
		[Token(Token = "0x4039FBC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ActMultiV3StageListDetailView.EnemyItemView[] _enemyItems;

		// Token: 0x04039FBD RID: 237501
		[Token(Token = "0x4039FBD")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x04039FBE RID: 237502
		[Token(Token = "0x4039FBE")]
		[FieldOffset(Offset = "0x54")]
		private ActMultiV3MapDiffType m_cachedDiffType;

		// Token: 0x04039FBF RID: 237503
		[Token(Token = "0x4039FBF")]
		[FieldOffset(Offset = "0x58")]
		private ActMultiV3StageListDetailView.Adapter m_adapter;

		// Token: 0x04039FC0 RID: 237504
		[Token(Token = "0x4039FC0")]
		[FieldOffset(Offset = "0x60")]
		private ActMultiV3StageDetailView m_view;

		// Token: 0x04039FC1 RID: 237505
		[Token(Token = "0x4039FC1")]
		[FieldOffset(Offset = "0x68")]
		private ActMultiV3StageListDetailStateViewModel m_cachedViewModel;

		// Token: 0x04039FC2 RID: 237506
		[Token(Token = "0x4039FC2")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039FC3 RID: 237507
		[Token(Token = "0x4039FC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039FC4 RID: 237508
		[Token(Token = "0x4039FC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039FC5 RID: 237509
		[Token(Token = "0x4039FC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnLeftClicked;

		// Token: 0x04039FC6 RID: 237510
		[Token(Token = "0x4039FC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnRightClicked;

		// Token: 0x04039FC7 RID: 237511
		[Token(Token = "0x4039FC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnEnemyHandbookClicked;

		// Token: 0x04039FC8 RID: 237512
		[Token(Token = "0x4039FC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FEA RID: 28650
		[Token(Token = "0x2006FEA")]
		[Serializable]
		private class AnimConfig : IHotfixable
		{
			// Token: 0x17006016 RID: 24598
			// (get) Token: 0x06028B0A RID: 166666 RVA: 0x000D2AB0 File Offset: 0x000D0CB0
			[Token(Token = "0x17006016")]
			public ActMultiV3MapDiffType diffType
			{
				[Token(Token = "0x6028B0A")]
				[Address(RVA = "0x2401F20", Offset = "0x2400B20", VA = "0x182401F20")]
				get
				{
					return ActMultiV3MapDiffType.NONE;
				}
			}

			// Token: 0x17006017 RID: 24599
			// (get) Token: 0x06028B0B RID: 166667 RVA: 0x000D2AC8 File Offset: 0x000D0CC8
			[Token(Token = "0x17006017")]
			public UIAnimationLocation diffAnim
			{
				[Token(Token = "0x6028B0B")]
				[Address(RVA = "0x2401EA0", Offset = "0x2400AA0", VA = "0x182401EA0")]
				get
				{
					return default(UIAnimationLocation);
				}
			}

			// Token: 0x06028B0C RID: 166668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B0C")]
			[Address(RVA = "0x2401E40", Offset = "0x2400A40", VA = "0x182401E40")]
			public AnimConfig()
			{
			}

			// Token: 0x04039FC9 RID: 237513
			[Token(Token = "0x4039FC9")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private ActMultiV3MapDiffType _diffType;

			// Token: 0x04039FCA RID: 237514
			[Token(Token = "0x4039FCA")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIAnimationLocation _diffAnim;

			// Token: 0x04039FCB RID: 237515
			[Token(Token = "0x4039FCB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_diffType;

			// Token: 0x04039FCC RID: 237516
			[Token(Token = "0x4039FCC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_diffAnim;

			// Token: 0x04039FCD RID: 237517
			[Token(Token = "0x4039FCD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006FEB RID: 28651
		[Token(Token = "0x2006FEB")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06028B0D RID: 166669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B0D")]
			[Address(RVA = "0x2401CF0", Offset = "0x24008F0", VA = "0x182401CF0")]
			public Adapter(ActMultiV3StageListDetailView closure)
			{
			}

			// Token: 0x17006018 RID: 24600
			// (get) Token: 0x06028B0E RID: 166670 RVA: 0x000D2AE0 File Offset: 0x000D0CE0
			[Token(Token = "0x17006018")]
			public override int count
			{
				[Token(Token = "0x6028B0E")]
				[Address(RVA = "0x2401D70", Offset = "0x2400970", VA = "0x182401D70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028B0F RID: 166671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028B0F")]
			[Address(RVA = "0x2401A30", Offset = "0x2400630", VA = "0x182401A30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039FCE RID: 237518
			[Token(Token = "0x4039FCE")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3StageListDetailView m_closure;

			// Token: 0x04039FCF RID: 237519
			[Token(Token = "0x4039FCF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039FD0 RID: 237520
			[Token(Token = "0x4039FD0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039FD1 RID: 237521
			[Token(Token = "0x4039FD1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006FEC RID: 28652
		[Token(Token = "0x2006FEC")]
		[Serializable]
		private class EnemyItemView : IHotfixable
		{
			// Token: 0x06028B10 RID: 166672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B10")]
			[Address(RVA = "0x2402F30", Offset = "0x2401B30", VA = "0x182402F30")]
			public void Render(ActMultiV3StageDetailViewModel.EnemyItemModel enemyItemModel)
			{
			}

			// Token: 0x06028B11 RID: 166673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B11")]
			[Address(RVA = "0x2403060", Offset = "0x2401C60", VA = "0x182403060")]
			public EnemyItemView()
			{
			}

			// Token: 0x04039FD2 RID: 237522
			[Token(Token = "0x4039FD2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x04039FD3 RID: 237523
			[Token(Token = "0x4039FD3")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Image _enemyIcon;

			// Token: 0x04039FD4 RID: 237524
			[Token(Token = "0x4039FD4")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _enemyIndex;

			// Token: 0x04039FD5 RID: 237525
			[Token(Token = "0x4039FD5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04039FD6 RID: 237526
			[Token(Token = "0x4039FD6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
