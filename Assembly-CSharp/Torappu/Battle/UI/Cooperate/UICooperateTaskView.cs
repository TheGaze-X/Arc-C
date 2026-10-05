using System;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033FB RID: 13307
	[Token(Token = "0x20033FB")]
	public class UICooperateTaskView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x060153E6 RID: 87014 RVA: 0x0008ACA8 File Offset: 0x00088EA8
		[Token(Token = "0x1700325C")]
		public bool sliderValueHold
		{
			[Token(Token = "0x60153E6")]
			[Address(RVA = "0xDC4E80", Offset = "0xDC3A80", VA = "0x180DC4E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x060153E7 RID: 87015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700325D")]
		public Text basicScore
		{
			[Token(Token = "0x60153E7")]
			[Address(RVA = "0xDC4E00", Offset = "0xDC3A00", VA = "0x180DC4E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x060153E8 RID: 87016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700325E")]
		public Text advanceScore
		{
			[Token(Token = "0x60153E8")]
			[Address(RVA = "0xDC4D80", Offset = "0xDC3980", VA = "0x180DC4D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060153E9 RID: 87017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153E9")]
		[Address(RVA = "0xDC3400", Offset = "0xDC2000", VA = "0x180DC3400")]
		public void OnGameReady(bool isFortessMode)
		{
		}

		// Token: 0x060153EA RID: 87018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153EA")]
		[Address(RVA = "0xDC3590", Offset = "0xDC2190", VA = "0x180DC3590")]
		public void RegistTask(string taskDesc, bool isFirstStage)
		{
		}

		// Token: 0x060153EB RID: 87019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153EB")]
		[Address(RVA = "0xDC3690", Offset = "0xDC2290", VA = "0x180DC3690")]
		public void RestoreFromRest()
		{
		}

		// Token: 0x060153EC RID: 87020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153EC")]
		[Address(RVA = "0xDC4040", Offset = "0xDC2C40", VA = "0x180DC4040")]
		public void SliderReachBasic(bool reach)
		{
		}

		// Token: 0x060153ED RID: 87021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153ED")]
		[Address(RVA = "0xDC3E70", Offset = "0xDC2A70", VA = "0x180DC3E70")]
		public void SliderReachAdvance(bool reach, bool advanceFinish = false)
		{
		}

		// Token: 0x060153EE RID: 87022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153EE")]
		[Address(RVA = "0xDC3D40", Offset = "0xDC2940", VA = "0x180DC3D40")]
		public void SliderReachAdvanceStage1()
		{
		}

		// Token: 0x060153EF RID: 87023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153EF")]
		[Address(RVA = "0xDC42D0", Offset = "0xDC2ED0", VA = "0x180DC42D0")]
		public void StageEndAnim()
		{
		}

		// Token: 0x060153F0 RID: 87024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153F0")]
		[Address(RVA = "0xDC3860", Offset = "0xDC2460", VA = "0x180DC3860")]
		public void SetOuterSlider(float value)
		{
		}

		// Token: 0x060153F1 RID: 87025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153F1")]
		[Address(RVA = "0xDC3980", Offset = "0xDC2580", VA = "0x180DC3980")]
		public void SetReachBasic(FP percentage)
		{
		}

		// Token: 0x060153F2 RID: 87026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153F2")]
		[Address(RVA = "0xDC3C30", Offset = "0xDC2830", VA = "0x180DC3C30")]
		public void SetStageTimer(FP time)
		{
		}

		// Token: 0x060153F3 RID: 87027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60153F3")]
		[Address(RVA = "0xDC4450", Offset = "0xDC3050", VA = "0x180DC4450")]
		public string TimeToShow(FP time)
		{
			return null;
		}

		// Token: 0x060153F4 RID: 87028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153F4")]
		[Address(RVA = "0xDC4380", Offset = "0xDC2F80", VA = "0x180DC4380")]
		public void StopTimerAnim()
		{
		}

		// Token: 0x060153F5 RID: 87029 RVA: 0x0008ACC0 File Offset: 0x00088EC0
		[Token(Token = "0x60153F5")]
		[Address(RVA = "0xDC3AA0", Offset = "0xDC26A0", VA = "0x180DC3AA0")]
		public float SetSliderValue(float value)
		{
			return 0f;
		}

		// Token: 0x060153F6 RID: 87030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153F6")]
		[Address(RVA = "0xDC32D0", Offset = "0xDC1ED0", VA = "0x180DC32D0")]
		public void HardSetSliderValue(float value = 0f)
		{
		}

		// Token: 0x060153F7 RID: 87031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153F7")]
		[Address(RVA = "0xDC3750", Offset = "0xDC2350", VA = "0x180DC3750")]
		public void SetFontSize(bool specialFontSize)
		{
		}

		// Token: 0x060153F8 RID: 87032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153F8")]
		[Address(RVA = "0xDC48C0", Offset = "0xDC34C0", VA = "0x180DC48C0")]
		private void _OnStageEndAnimFinish()
		{
		}

		// Token: 0x060153F9 RID: 87033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153F9")]
		[Address(RVA = "0xDC4BB0", Offset = "0xDC37B0", VA = "0x180DC4BB0")]
		private void _PlayAnimation(UIAnimationLocation animLocation)
		{
		}

		// Token: 0x060153FA RID: 87034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153FA")]
		[Address(RVA = "0xDC4AA0", Offset = "0xDC36A0", VA = "0x180DC4AA0")]
		private void _PlayAnimationWithTween(UIAnimationLocation animLocation, [Optional] TweenCallback onComplete)
		{
		}

		// Token: 0x060153FB RID: 87035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60153FB")]
		[Address(RVA = "0xDC4CC0", Offset = "0xDC38C0", VA = "0x180DC4CC0")]
		public UICooperateTaskView()
		{
		}

		// Token: 0x04019611 RID: 103953
		[Token(Token = "0x4019611")]
		private const string TIME_FORMAT = "{0}:{1}";

		// Token: 0x04019612 RID: 103954
		[Token(Token = "0x4019612")]
		private const float OUTER_MIN_SHOW_VALUE = 0.05f;

		// Token: 0x04019613 RID: 103955
		[Token(Token = "0x4019613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float BASIC_SPLIT_CNT;

		// Token: 0x04019614 RID: 103956
		[Token(Token = "0x4019614")]
		private const int BASIC_FONT_SIZE = 32;

		// Token: 0x04019615 RID: 103957
		[Token(Token = "0x4019615")]
		private const int SPECIAL_FONT_SIZE = 26;

		// Token: 0x04019616 RID: 103958
		[Token(Token = "0x4019616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animStartBasic;

		// Token: 0x04019617 RID: 103959
		[Token(Token = "0x4019617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animEndBasic;

		// Token: 0x04019618 RID: 103960
		[Token(Token = "0x4019618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animStartAdvance;

		// Token: 0x04019619 RID: 103961
		[Token(Token = "0x4019619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animStage;

		// Token: 0x0401961A RID: 103962
		[Token(Token = "0x401961A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _animComplete;

		// Token: 0x0401961B RID: 103963
		[Token(Token = "0x401961B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _animOuterLoop;

		// Token: 0x0401961C RID: 103964
		[Token(Token = "0x401961C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animTimer;

		// Token: 0x0401961D RID: 103965
		[Token(Token = "0x401961D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int _animTimerShow;

		// Token: 0x0401961E RID: 103966
		[Token(Token = "0x401961E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Task")]
		private Text _stageInfo;

		// Token: 0x0401961F RID: 103967
		[Token(Token = "0x401961F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Task")]
		private RectTransform _basicPart;

		// Token: 0x04019620 RID: 103968
		[Token(Token = "0x4019620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Task")]
		private Text _basicScore;

		// Token: 0x04019621 RID: 103969
		[Token(Token = "0x4019621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Task")]
		private Text _advanceScore;

		// Token: 0x04019622 RID: 103970
		[Token(Token = "0x4019622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Task")]
		private GameObject _advanceAccomplishDeco;

		// Token: 0x04019623 RID: 103971
		[Token(Token = "0x4019623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Task")]
		private GameObject _advanceAccomplishGroup;

		// Token: 0x04019624 RID: 103972
		[Token(Token = "0x4019624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Task")]
		private Slider _progressSlider;

		// Token: 0x04019625 RID: 103973
		[Token(Token = "0x4019625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Task")]
		private Image _progressSliderMask;

		// Token: 0x04019626 RID: 103974
		[Token(Token = "0x4019626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Task")]
		private RectTransform _sliderMask;

		// Token: 0x04019627 RID: 103975
		[Token(Token = "0x4019627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Task")]
		private float _sliderSpeed;

		// Token: 0x04019628 RID: 103976
		[Token(Token = "0x4019628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Task")]
		private Text _stageTimerNormal;

		// Token: 0x04019629 RID: 103977
		[Token(Token = "0x4019629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Task")]
		private Text _stageTimer;

		// Token: 0x0401962A RID: 103978
		[Token(Token = "0x401962A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Task")]
		private GameObject _sliderCover;

		// Token: 0x0401962B RID: 103979
		[Token(Token = "0x401962B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _fillField;

		// Token: 0x0401962C RID: 103980
		[Token(Token = "0x401962C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Slider _progressOuterSlider;

		// Token: 0x0401962D RID: 103981
		[Token(Token = "0x401962D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _timerAlarmDecoLeft;

		// Token: 0x0401962E RID: 103982
		[Token(Token = "0x401962E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _timerAlarmDecoRight;

		// Token: 0x0401962F RID: 103983
		[Token(Token = "0x401962F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _timerBg;

		// Token: 0x04019630 RID: 103984
		[Token(Token = "0x4019630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _outerStartOffset;

		// Token: 0x04019631 RID: 103985
		[Token(Token = "0x4019631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		private float _outerEndOffset;

		// Token: 0x04019632 RID: 103986
		[Token(Token = "0x4019632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private float _silderZeroValueOffset;

		// Token: 0x04019633 RID: 103987
		[Token(Token = "0x4019633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private float _silderZeroValurMargin;

		// Token: 0x04019634 RID: 103988
		[Token(Token = "0x4019634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool m_sliderBasicReach;

		// Token: 0x04019635 RID: 103989
		[Token(Token = "0x4019635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		private bool m_sliderAdvanceReach;

		// Token: 0x04019636 RID: 103990
		[Token(Token = "0x4019636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		private bool m_sliderValueHold;

		// Token: 0x04019637 RID: 103991
		[Token(Token = "0x4019637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float m_outerSliderValue;

		// Token: 0x04019638 RID: 103992
		[Token(Token = "0x4019638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float m_innerSliderValue;

		// Token: 0x04019639 RID: 103993
		[Token(Token = "0x4019639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool m_isOuterShown;

		// Token: 0x0401963A RID: 103994
		[Token(Token = "0x401963A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector2 m_sliderMaskOrigPos;

		// Token: 0x0401963B RID: 103995
		[Token(Token = "0x401963B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sliderValueHold;

		// Token: 0x0401963C RID: 103996
		[Token(Token = "0x401963C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_basicScore;

		// Token: 0x0401963D RID: 103997
		[Token(Token = "0x401963D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_advanceScore;

		// Token: 0x0401963E RID: 103998
		[Token(Token = "0x401963E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0401963F RID: 103999
		[Token(Token = "0x401963F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegistTask;

		// Token: 0x04019640 RID: 104000
		[Token(Token = "0x4019640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RestoreFromRest;

		// Token: 0x04019641 RID: 104001
		[Token(Token = "0x4019641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SliderReachBasic;

		// Token: 0x04019642 RID: 104002
		[Token(Token = "0x4019642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SliderReachAdvance;

		// Token: 0x04019643 RID: 104003
		[Token(Token = "0x4019643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SliderReachAdvanceStage1;

		// Token: 0x04019644 RID: 104004
		[Token(Token = "0x4019644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_StageEndAnim;

		// Token: 0x04019645 RID: 104005
		[Token(Token = "0x4019645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetOuterSlider;

		// Token: 0x04019646 RID: 104006
		[Token(Token = "0x4019646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetReachBasic;

		// Token: 0x04019647 RID: 104007
		[Token(Token = "0x4019647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetStageTimer;

		// Token: 0x04019648 RID: 104008
		[Token(Token = "0x4019648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TimeToShow;

		// Token: 0x04019649 RID: 104009
		[Token(Token = "0x4019649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_StopTimerAnim;

		// Token: 0x0401964A RID: 104010
		[Token(Token = "0x401964A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetSliderValue;

		// Token: 0x0401964B RID: 104011
		[Token(Token = "0x401964B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HardSetSliderValue;

		// Token: 0x0401964C RID: 104012
		[Token(Token = "0x401964C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetFontSize;

		// Token: 0x0401964D RID: 104013
		[Token(Token = "0x401964D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnStageEndAnimFinish;

		// Token: 0x0401964E RID: 104014
		[Token(Token = "0x401964E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PlayAnimation;

		// Token: 0x0401964F RID: 104015
		[Token(Token = "0x401964F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PlayAnimationWithTween;

		// Token: 0x04019650 RID: 104016
		[Token(Token = "0x4019650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
