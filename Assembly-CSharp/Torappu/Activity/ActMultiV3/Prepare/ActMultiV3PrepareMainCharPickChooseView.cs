using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007056 RID: 28758
	[Token(Token = "0x2007056")]
	public class ActMultiV3PrepareMainCharPickChooseView : DataBinder<ActMultiV3PrepareMainCharPickPanelViewModelProperty>
	{
		// Token: 0x17006089 RID: 24713
		// (get) Token: 0x06028D66 RID: 167270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028D67 RID: 167271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006089")]
		public Action<int> onSelectChar
		{
			[Token(Token = "0x6028D66")]
			[Address(RVA = "0x2433D80", Offset = "0x2432980", VA = "0x182433D80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028D67")]
			[Address(RVA = "0x2433EC0", Offset = "0x2432AC0", VA = "0x182433EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700608A RID: 24714
		// (get) Token: 0x06028D68 RID: 167272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028D69 RID: 167273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700608A")]
		public Action onSkip
		{
			[Token(Token = "0x6028D68")]
			[Address(RVA = "0x2433DE0", Offset = "0x24329E0", VA = "0x182433DE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028D69")]
			[Address(RVA = "0x2433F40", Offset = "0x2432B40", VA = "0x182433F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700608B RID: 24715
		// (get) Token: 0x06028D6A RID: 167274 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028D6B RID: 167275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700608B")]
		public Action onMyTurn
		{
			[Token(Token = "0x6028D6A")]
			[Address(RVA = "0x2433D20", Offset = "0x2432920", VA = "0x182433D20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028D6B")]
			[Address(RVA = "0x2433E40", Offset = "0x2432A40", VA = "0x182433E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028D6C RID: 167276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D6C")]
		[Address(RVA = "0x2432DB0", Offset = "0x24319B0", VA = "0x182432DB0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainCharPickPanelViewModelProperty property)
		{
		}

		// Token: 0x06028D6D RID: 167277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D6D")]
		[Address(RVA = "0x2433B80", Offset = "0x2432780", VA = "0x182433B80")]
		private void _SetInvert(bool invert)
		{
		}

		// Token: 0x06028D6E RID: 167278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D6E")]
		[Address(RVA = "0x24338B0", Offset = "0x24324B0", VA = "0x1824338B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028D6F RID: 167279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D6F")]
		[Address(RVA = "0x2433740", Offset = "0x2432340", VA = "0x182433740")]
		private void _DelayPlayNotiPlayerAnim(float delay)
		{
		}

		// Token: 0x06028D70 RID: 167280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D70")]
		[Address(RVA = "0x2433680", Offset = "0x2432280", VA = "0x182433680")]
		public void PlayNotiPlayerAnim()
		{
		}

		// Token: 0x06028D71 RID: 167281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D71")]
		[Address(RVA = "0x2433CB0", Offset = "0x24328B0", VA = "0x182433CB0")]
		public ActMultiV3PrepareMainCharPickChooseView()
		{
		}

		// Token: 0x0403A3E7 RID: 238567
		[Token(Token = "0x403A3E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _pickCnt;

		// Token: 0x0403A3E8 RID: 238568
		[Token(Token = "0x403A3E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateFadeSwitcher _myTurnToggle;

		// Token: 0x0403A3E9 RID: 238569
		[Token(Token = "0x403A3E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x0403A3EA RID: 238570
		[Token(Token = "0x403A3EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PrefabMark[] _invertTips;

		// Token: 0x0403A3EB RID: 238571
		[Token(Token = "0x403A3EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _skipTextToggle;

		// Token: 0x0403A3EC RID: 238572
		[Token(Token = "0x403A3EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _myTurnAnim;

		// Token: 0x0403A3ED RID: 238573
		[Token(Token = "0x403A3ED")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _pTurnAnim;

		// Token: 0x0403A3EE RID: 238574
		[Token(Token = "0x403A3EE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _notiPlayerAnim;

		// Token: 0x0403A3EF RID: 238575
		[Token(Token = "0x403A3EF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _delayOnNotiPlayerAnim;

		// Token: 0x0403A3F0 RID: 238576
		[Token(Token = "0x403A3F0")]
		[FieldOffset(Offset = "0x80")]
		private ActMultiV3PrepareMainCharPickChooseView.Adapter m_charListAdapter;

		// Token: 0x0403A3F1 RID: 238577
		[Token(Token = "0x403A3F1")]
		[FieldOffset(Offset = "0x88")]
		private bool m_curMyTurn;

		// Token: 0x0403A3F2 RID: 238578
		[Token(Token = "0x403A3F2")]
		[FieldOffset(Offset = "0x90")]
		private AnimationSwitchTween m_notiPlayerAnimSwitchTween;

		// Token: 0x0403A3F3 RID: 238579
		[Token(Token = "0x403A3F3")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_delayNotiTween;

		// Token: 0x0403A3F7 RID: 238583
		[Token(Token = "0x403A3F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSelectChar;

		// Token: 0x0403A3F8 RID: 238584
		[Token(Token = "0x403A3F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSelectChar;

		// Token: 0x0403A3F9 RID: 238585
		[Token(Token = "0x403A3F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onSkip;

		// Token: 0x0403A3FA RID: 238586
		[Token(Token = "0x403A3FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onSkip;

		// Token: 0x0403A3FB RID: 238587
		[Token(Token = "0x403A3FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onMyTurn;

		// Token: 0x0403A3FC RID: 238588
		[Token(Token = "0x403A3FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onMyTurn;

		// Token: 0x0403A3FD RID: 238589
		[Token(Token = "0x403A3FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A3FE RID: 238590
		[Token(Token = "0x403A3FE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetInvert;

		// Token: 0x0403A3FF RID: 238591
		[Token(Token = "0x403A3FF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A400 RID: 238592
		[Token(Token = "0x403A400")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DelayPlayNotiPlayerAnim;

		// Token: 0x0403A401 RID: 238593
		[Token(Token = "0x403A401")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PlayNotiPlayerAnim;

		// Token: 0x0403A402 RID: 238594
		[Token(Token = "0x403A402")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007057 RID: 28759
		[Token(Token = "0x2007057")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700608C RID: 24716
			// (get) Token: 0x06028D73 RID: 167283 RVA: 0x000D3368 File Offset: 0x000D1568
			// (set) Token: 0x06028D72 RID: 167282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700608C")]
			public int skipNum
			{
				[Token(Token = "0x6028D73")]
				[Address(RVA = "0x24479B0", Offset = "0x24465B0", VA = "0x1824479B0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6028D72")]
				[Address(RVA = "0x2447A20", Offset = "0x2446620", VA = "0x182447A20")]
				set
				{
				}
			}

			// Token: 0x1700608D RID: 24717
			// (get) Token: 0x06028D74 RID: 167284 RVA: 0x000D3380 File Offset: 0x000D1580
			[Token(Token = "0x1700608D")]
			private bool enableSkip
			{
				[Token(Token = "0x6028D74")]
				[Address(RVA = "0x24478F0", Offset = "0x24464F0", VA = "0x1824478F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700608E RID: 24718
			// (get) Token: 0x06028D75 RID: 167285 RVA: 0x000D3398 File Offset: 0x000D1598
			[Token(Token = "0x1700608E")]
			public override int count
			{
				[Token(Token = "0x6028D75")]
				[Address(RVA = "0x2447860", Offset = "0x2446460", VA = "0x182447860", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028D76 RID: 167286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028D76")]
			[Address(RVA = "0x2447230", Offset = "0x2445E30", VA = "0x182447230", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06028D77 RID: 167287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028D77")]
			[Address(RVA = "0x24475E0", Offset = "0x24461E0", VA = "0x1824475E0")]
			private void _EventCardClick(int instId)
			{
			}

			// Token: 0x06028D78 RID: 167288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028D78")]
			[Address(RVA = "0x2447670", Offset = "0x2446270", VA = "0x182447670")]
			private void _EventSkipConfirm()
			{
			}

			// Token: 0x06028D79 RID: 167289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028D79")]
			[Address(RVA = "0x24476F0", Offset = "0x24462F0", VA = "0x1824476F0")]
			public Adapter()
			{
			}

			// Token: 0x0403A403 RID: 238595
			[Token(Token = "0x403A403")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3PrepareMainCharCardModel> charList;

			// Token: 0x0403A404 RID: 238596
			[Token(Token = "0x403A404")]
			[FieldOffset(Offset = "0x28")]
			public bool enableClick;

			// Token: 0x0403A405 RID: 238597
			[Token(Token = "0x403A405")]
			[FieldOffset(Offset = "0x30")]
			public Action<int> onCardClick;

			// Token: 0x0403A406 RID: 238598
			[Token(Token = "0x403A406")]
			[FieldOffset(Offset = "0x38")]
			public Action onSkipConfirm;

			// Token: 0x0403A407 RID: 238599
			[Token(Token = "0x403A407")]
			[FieldOffset(Offset = "0x40")]
			private ActMultiV3PrepareMainCharCardModel m_skipModel;

			// Token: 0x0403A408 RID: 238600
			[Token(Token = "0x403A408")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_skipNum;

			// Token: 0x0403A409 RID: 238601
			[Token(Token = "0x403A409")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_skipNum;

			// Token: 0x0403A40A RID: 238602
			[Token(Token = "0x403A40A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_enableSkip;

			// Token: 0x0403A40B RID: 238603
			[Token(Token = "0x403A40B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A40C RID: 238604
			[Token(Token = "0x403A40C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403A40D RID: 238605
			[Token(Token = "0x403A40D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__EventCardClick;

			// Token: 0x0403A40E RID: 238606
			[Token(Token = "0x403A40E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__EventSkipConfirm;

			// Token: 0x0403A40F RID: 238607
			[Token(Token = "0x403A40F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
