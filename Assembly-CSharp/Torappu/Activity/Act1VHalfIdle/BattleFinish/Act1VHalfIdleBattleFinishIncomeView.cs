using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007824 RID: 30756
	[Token(Token = "0x2007824")]
	public class Act1VHalfIdleBattleFinishIncomeView : Act1VHalfIdleBattleFinishSubViewBase, IAudioAnimationPlayerConditionProvider, IHotfixable
	{
		// Token: 0x170064EB RID: 25835
		// (get) Token: 0x0602B23F RID: 176703 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B23E RID: 176702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064EB")]
		public Action<bool> onBtnClick
		{
			[Token(Token = "0x602B23F")]
			[Address(RVA = "0x26F3C20", Offset = "0x26F2820", VA = "0x1826F3C20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B23E")]
			[Address(RVA = "0x26F3C80", Offset = "0x26F2880", VA = "0x1826F3C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B240 RID: 176704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B240")]
		[Address(RVA = "0x26F35A0", Offset = "0x26F21A0", VA = "0x1826F35A0")]
		public void UpdateView(bool show, Act1VHalfIdleBattleFinishIncomeViewModel model)
		{
		}

		// Token: 0x0602B241 RID: 176705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B241")]
		[Address(RVA = "0x26F34E0", Offset = "0x26F20E0", VA = "0x1826F34E0", Slot = "4")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0602B242 RID: 176706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B242")]
		[Address(RVA = "0x26F3A60", Offset = "0x26F2660", VA = "0x1826F3A60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B243 RID: 176707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B243")]
		[Address(RVA = "0x26F3430", Offset = "0x26F2030", VA = "0x1826F3430")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0602B244 RID: 176708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B244")]
		[Address(RVA = "0x26F3380", Offset = "0x26F1F80", VA = "0x1826F3380")]
		public void EventOnCancel()
		{
		}

		// Token: 0x0602B245 RID: 176709 RVA: 0x000DAF28 File Offset: 0x000D9128
		[Token(Token = "0x602B245")]
		[Address(RVA = "0x26F3320", Offset = "0x26F1F20", VA = "0x1826F3320", Slot = "5")]
		public bool CanPlayAudio()
		{
			return default(bool);
		}

		// Token: 0x0602B246 RID: 176710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B246")]
		[Address(RVA = "0x26F3B80", Offset = "0x26F2780", VA = "0x1826F3B80")]
		public Act1VHalfIdleBattleFinishIncomeView()
		{
		}

		// Token: 0x0602B247 RID: 176711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B247")]
		[Address(RVA = "0x26F3590", Offset = "0x26F2190", VA = "0x1826F3590")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0403E5BF RID: 255423
		[Token(Token = "0x403E5BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403E5C0 RID: 255424
		[Token(Token = "0x403E5C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403E5C1 RID: 255425
		[Token(Token = "0x403E5C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stageText;

		// Token: 0x0403E5C2 RID: 255426
		[Token(Token = "0x403E5C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _stagePrg;

		// Token: 0x0403E5C3 RID: 255427
		[Token(Token = "0x403E5C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x0403E5C4 RID: 255428
		[Token(Token = "0x403E5C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _bossState;

		// Token: 0x0403E5C5 RID: 255429
		[Token(Token = "0x403E5C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act1VHalfIdleIncomeGraphView _graphView;

		// Token: 0x0403E5C6 RID: 255430
		[Token(Token = "0x403E5C6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _replaceToggle;

		// Token: 0x0403E5C7 RID: 255431
		[Token(Token = "0x403E5C7")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x0403E5C8 RID: 255432
		[Token(Token = "0x403E5C8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_cachedBossComplete;

		// Token: 0x0403E5CA RID: 255434
		[Token(Token = "0x403E5CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onBtnClick;

		// Token: 0x0403E5CB RID: 255435
		[Token(Token = "0x403E5CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onBtnClick;

		// Token: 0x0403E5CC RID: 255436
		[Token(Token = "0x403E5CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403E5CD RID: 255437
		[Token(Token = "0x403E5CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403E5CE RID: 255438
		[Token(Token = "0x403E5CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E5CF RID: 255439
		[Token(Token = "0x403E5CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0403E5D0 RID: 255440
		[Token(Token = "0x403E5D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCancel;

		// Token: 0x0403E5D1 RID: 255441
		[Token(Token = "0x403E5D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CanPlayAudio;

		// Token: 0x0403E5D2 RID: 255442
		[Token(Token = "0x403E5D2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
