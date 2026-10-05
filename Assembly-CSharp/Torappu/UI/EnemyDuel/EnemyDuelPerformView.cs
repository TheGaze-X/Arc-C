using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FFF RID: 20479
	[Token(Token = "0x2004FFF")]
	public class EnemyDuelPerformView : DataBinder<EnemyDuelBattleProperty>
	{
		// Token: 0x0601E65E RID: 124510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E65E")]
		[Address(RVA = "0x181CD70", Offset = "0x181B970", VA = "0x18181CD70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E65F RID: 124511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E65F")]
		[Address(RVA = "0x181C8F0", Offset = "0x181B4F0", VA = "0x18181C8F0", Slot = "7")]
		public override void OnValueChanged(EnemyDuelBattleProperty property)
		{
		}

		// Token: 0x0601E660 RID: 124512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E660")]
		[Address(RVA = "0x181D080", Offset = "0x181BC80", VA = "0x18181D080")]
		public EnemyDuelPerformView()
		{
		}

		// Token: 0x04028A48 RID: 166472
		[Token(Token = "0x4028A48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLeft;

		// Token: 0x04028A49 RID: 166473
		[Token(Token = "0x4028A49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRight;

		// Token: 0x04028A4A RID: 166474
		[Token(Token = "0x4028A4A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textSupport;

		// Token: 0x04028A4B RID: 166475
		[Token(Token = "0x4028A4B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSupport;

		// Token: 0x04028A4C RID: 166476
		[Token(Token = "0x4028A4C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelSupportLeft;

		// Token: 0x04028A4D RID: 166477
		[Token(Token = "0x4028A4D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelSupportRight;

		// Token: 0x04028A4E RID: 166478
		[Token(Token = "0x4028A4E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelSupportNormal;

		// Token: 0x04028A4F RID: 166479
		[Token(Token = "0x4028A4F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelSupportAllin;

		// Token: 0x04028A50 RID: 166480
		[Token(Token = "0x4028A50")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _waitForOthers;

		// Token: 0x04028A51 RID: 166481
		[Token(Token = "0x4028A51")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _leftContent;

		// Token: 0x04028A52 RID: 166482
		[Token(Token = "0x4028A52")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _rightContent;

		// Token: 0x04028A53 RID: 166483
		[Token(Token = "0x4028A53")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PrefabInstHolder _topBarInstHolder;

		// Token: 0x04028A54 RID: 166484
		[Token(Token = "0x4028A54")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _waitLoopAnim;

		// Token: 0x04028A55 RID: 166485
		[Token(Token = "0x4028A55")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04028A56 RID: 166486
		[Token(Token = "0x4028A56")]
		[FieldOffset(Offset = "0x98")]
		private EnemyDuelPerformView.AvatarAdapter m_leftAdapter;

		// Token: 0x04028A57 RID: 166487
		[Token(Token = "0x4028A57")]
		[FieldOffset(Offset = "0xA0")]
		private EnemyDuelPerformView.AvatarAdapter m_rightAdapter;

		// Token: 0x04028A58 RID: 166488
		[Token(Token = "0x4028A58")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_waitFadeSwitch;

		// Token: 0x04028A59 RID: 166489
		[Token(Token = "0x4028A59")]
		[FieldOffset(Offset = "0xB0")]
		private EnemyDuelPerformViewModel m_cachedViewModel;

		// Token: 0x04028A5A RID: 166490
		[Token(Token = "0x4028A5A")]
		[FieldOffset(Offset = "0xB8")]
		private EnemyDuelBetTopBarView m_topBar;

		// Token: 0x04028A5B RID: 166491
		[Token(Token = "0x4028A5B")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_waitLoopTween;

		// Token: 0x04028A5C RID: 166492
		[Token(Token = "0x4028A5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028A5D RID: 166493
		[Token(Token = "0x4028A5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028A5E RID: 166494
		[Token(Token = "0x4028A5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005000 RID: 20480
		[Token(Token = "0x2005000")]
		public class AvatarAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E662 RID: 124514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E662")]
			[Address(RVA = "0x180D9F0", Offset = "0x180C5F0", VA = "0x18180D9F0")]
			public AvatarAdapter(EnemyDuelPerformView closure, EnemyDuelChoiceSide side)
			{
			}

			// Token: 0x17004706 RID: 18182
			// (get) Token: 0x0601E663 RID: 124515 RVA: 0x000AE5D0 File Offset: 0x000AC7D0
			[Token(Token = "0x17004706")]
			public override int count
			{
				[Token(Token = "0x601E663")]
				[Address(RVA = "0x180DA80", Offset = "0x180C680", VA = "0x18180DA80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E664 RID: 124516 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E664")]
			[Address(RVA = "0x180D7A0", Offset = "0x180C3A0", VA = "0x18180D7A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04028A5F RID: 166495
			[Token(Token = "0x4028A5F")]
			[FieldOffset(Offset = "0x20")]
			private EnemyDuelPerformView m_closure;

			// Token: 0x04028A60 RID: 166496
			[Token(Token = "0x4028A60")]
			[FieldOffset(Offset = "0x28")]
			private EnemyDuelChoiceSide m_side;

			// Token: 0x04028A61 RID: 166497
			[Token(Token = "0x4028A61")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028A62 RID: 166498
			[Token(Token = "0x4028A62")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04028A63 RID: 166499
			[Token(Token = "0x4028A63")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
