using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Act6Fun
{
	// Token: 0x0200342C RID: 13356
	[Token(Token = "0x200342C")]
	public class Act6FunUIPlugin : UIController.Plugin
	{
		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0601561B RID: 87579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003295")]
		private GameModeFactory.Act6FunGameMode gameMode
		{
			[Token(Token = "0x601561B")]
			[Address(RVA = "0xDC7020", Offset = "0xDC5C20", VA = "0x180DC7020")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601561C RID: 87580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601561C")]
		[Address(RVA = "0xDC64C0", Offset = "0xDC50C0", VA = "0x180DC64C0")]
		private void Update()
		{
		}

		// Token: 0x0601561D RID: 87581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601561D")]
		[Address(RVA = "0xDC6860", Offset = "0xDC5460", VA = "0x180DC6860")]
		private void _ShowOrHideArrow(bool isShow)
		{
		}

		// Token: 0x0601561E RID: 87582 RVA: 0x0008B9F8 File Offset: 0x00089BF8
		[Token(Token = "0x601561E")]
		[Address(RVA = "0xDC5540", Offset = "0xDC4140", VA = "0x180DC5540")]
		public Vector2 GetDirectionInput()
		{
			return default(Vector2);
		}

		// Token: 0x0601561F RID: 87583 RVA: 0x0008BA10 File Offset: 0x00089C10
		[Token(Token = "0x601561F")]
		[Address(RVA = "0xDC66B0", Offset = "0xDC52B0", VA = "0x180DC66B0")]
		private bool _CheckInputDisabled()
		{
			return default(bool);
		}

		// Token: 0x06015620 RID: 87584 RVA: 0x0008BA28 File Offset: 0x00089C28
		[Token(Token = "0x6015620")]
		[Address(RVA = "0xDC6730", Offset = "0xDC5330", VA = "0x180DC6730")]
		private Vector2 _GetJoystickAxis()
		{
			return default(Vector2);
		}

		// Token: 0x06015621 RID: 87585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015621")]
		[Address(RVA = "0xDC6B80", Offset = "0xDC5780", VA = "0x180DC6B80")]
		private void _UpdateCoinPanel(bool isInit = false)
		{
		}

		// Token: 0x06015622 RID: 87586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015622")]
		[Address(RVA = "0xDC6DA0", Offset = "0xDC59A0", VA = "0x180DC6DA0")]
		private void _UpdateTimerPanel(bool isInit = false)
		{
		}

		// Token: 0x06015623 RID: 87587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015623")]
		[Address(RVA = "0xDC6990", Offset = "0xDC5590", VA = "0x180DC6990")]
		private void _ToggleInCombatPanel(bool isShow)
		{
		}

		// Token: 0x06015624 RID: 87588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015624")]
		[Address(RVA = "0xDC5F80", Offset = "0xDC4B80", VA = "0x180DC5F80", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x06015625 RID: 87589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015625")]
		[Address(RVA = "0xDC6260", Offset = "0xDC4E60", VA = "0x180DC6260", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06015626 RID: 87590 RVA: 0x0008BA40 File Offset: 0x00089C40
		[Token(Token = "0x6015626")]
		[Address(RVA = "0xDC5810", Offset = "0xDC4410", VA = "0x180DC5810", Slot = "47")]
		public override bool HookBattleAccomplishPerform(out UIAnimationPerform perform)
		{
			return default(bool);
		}

		// Token: 0x06015627 RID: 87591 RVA: 0x0008BA58 File Offset: 0x00089C58
		[Token(Token = "0x6015627")]
		[Address(RVA = "0xDC5C00", Offset = "0xDC4800", VA = "0x180DC5C00", Slot = "23")]
		public override bool HookGameStartStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015628 RID: 87592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015628")]
		[Address(RVA = "0xDC6190", Offset = "0xDC4D90", VA = "0x180DC6190", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06015629 RID: 87593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015629")]
		[Address(RVA = "0xDC60E0", Offset = "0xDC4CE0", VA = "0x180DC60E0", Slot = "18")]
		public override void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x0601562A RID: 87594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601562A")]
		[Address(RVA = "0xDC5E30", Offset = "0xDC4A30", VA = "0x180DC5E30", Slot = "39")]
		public override void OnCharacterMenuShow(Character character)
		{
		}

		// Token: 0x0601562B RID: 87595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601562B")]
		[Address(RVA = "0xDC5D90", Offset = "0xDC4990", VA = "0x180DC5D90", Slot = "41")]
		public override void OnCharacterMenuHide()
		{
		}

		// Token: 0x0601562C RID: 87596 RVA: 0x0008BA70 File Offset: 0x00089C70
		[Token(Token = "0x601562C")]
		[Address(RVA = "0xDC5CD0", Offset = "0xDC48D0", VA = "0x180DC5CD0", Slot = "45")]
		public override bool HookPauseMask(bool isPause)
		{
			return default(bool);
		}

		// Token: 0x0601562D RID: 87597 RVA: 0x0008BA88 File Offset: 0x00089C88
		[Token(Token = "0x601562D")]
		[Address(RVA = "0xDC59A0", Offset = "0xDC45A0", VA = "0x180DC59A0", Slot = "33")]
		public override bool HookBattleFailedTips(int tipCnt, out TipData[] tipData)
		{
			return default(bool);
		}

		// Token: 0x0601562E RID: 87598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601562E")]
		[Address(RVA = "0xDC58B0", Offset = "0xDC44B0", VA = "0x180DC58B0", Slot = "36")]
		public override void HookBattleData(CommonFinishBattleRequest.BattleData battleData)
		{
		}

		// Token: 0x0601562F RID: 87599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601562F")]
		[Address(RVA = "0xDC63F0", Offset = "0xDC4FF0", VA = "0x180DC63F0")]
		public void SetEnemyBlocked(bool isDisable)
		{
		}

		// Token: 0x06015630 RID: 87600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015630")]
		[Address(RVA = "0xDC6FA0", Offset = "0xDC5BA0", VA = "0x180DC6FA0")]
		public Act6FunUIPlugin()
		{
		}

		// Token: 0x06015632 RID: 87602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015632")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06015633 RID: 87603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015633")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06015634 RID: 87604 RVA: 0x0008BAA0 File Offset: 0x00089CA0
		[Token(Token = "0x6015634")]
		[Address(RVA = "0xDC6480", Offset = "0xDC5080", VA = "0x180DC6480")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishPerform(out UIAnimationPerform P0)
		{
			return default(bool);
		}

		// Token: 0x06015635 RID: 87605 RVA: 0x0008BAB8 File Offset: 0x00089CB8
		[Token(Token = "0x6015635")]
		[Address(RVA = "0xD69530", Offset = "0xD68130", VA = "0x180D69530")]
		private bool <>xLuaBaseProxy_HookGameStartStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015636 RID: 87606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015636")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06015637 RID: 87607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015637")]
		[Address(RVA = "0xDC64B0", Offset = "0xDC50B0", VA = "0x180DC64B0")]
		private void <>xLuaBaseProxy_OnFixedUpdate(FP P0)
		{
		}

		// Token: 0x06015638 RID: 87608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015638")]
		[Address(RVA = "0x9CCDD0", Offset = "0x9CB9D0", VA = "0x1809CCDD0")]
		private void <>xLuaBaseProxy_OnCharacterMenuShow(Character P0)
		{
		}

		// Token: 0x06015639 RID: 87609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015639")]
		[Address(RVA = "0x9CCDC0", Offset = "0x9CB9C0", VA = "0x1809CCDC0")]
		private void <>xLuaBaseProxy_OnCharacterMenuHide()
		{
		}

		// Token: 0x0601563A RID: 87610 RVA: 0x0008BAD0 File Offset: 0x00089CD0
		[Token(Token = "0x601563A")]
		[Address(RVA = "0xA032B0", Offset = "0xA01EB0", VA = "0x180A032B0")]
		private bool <>xLuaBaseProxy_HookPauseMask(bool P0)
		{
			return default(bool);
		}

		// Token: 0x0601563B RID: 87611 RVA: 0x0008BAE8 File Offset: 0x00089CE8
		[Token(Token = "0x601563B")]
		[Address(RVA = "0xDC64A0", Offset = "0xDC50A0", VA = "0x180DC64A0")]
		private bool <>xLuaBaseProxy_HookBattleFailedTips(int P0, out TipData[] P1)
		{
			return default(bool);
		}

		// Token: 0x0601563C RID: 87612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601563C")]
		[Address(RVA = "0xDC6490", Offset = "0xDC5090", VA = "0x180DC6490")]
		private void <>xLuaBaseProxy_HookBattleData(CommonFinishBattleRequest.BattleData P0)
		{
		}

		// Token: 0x04019946 RID: 104774
		[Token(Token = "0x4019946")]
		private const string DISABLE_JOYSTICK_KEY_PAUSE = "DISABLE_JOYSTICK_KEY_PAUSE";

		// Token: 0x04019947 RID: 104775
		[Token(Token = "0x4019947")]
		private const string DISABLE_JOYSTICK_KEY_CHAR_MENU = "DISABLE_JOYSTICK_KEY_CHAR_MENU";

		// Token: 0x04019948 RID: 104776
		[Token(Token = "0x4019948")]
		private const string TIMER_FORMAT = "{0}:{1}";

		// Token: 0x04019949 RID: 104777
		[Token(Token = "0x4019949")]
		public const float SHOW_IN_COMBAT_BANNER_DURATION = 0f;

		// Token: 0x0401994A RID: 104778
		[Token(Token = "0x401994A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_BATTLE_START;

		// Token: 0x0401994B RID: 104779
		[Token(Token = "0x401994B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act6FunUIDynPosJoystickHost _joystickHost;

		// Token: 0x0401994C RID: 104780
		[Token(Token = "0x401994C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ETCJoystick _joystick;

		// Token: 0x0401994D RID: 104781
		[Token(Token = "0x401994D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rectTransformArrow;

		// Token: 0x0401994E RID: 104782
		[Token(Token = "0x401994E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroupArrow;

		// Token: 0x0401994F RID: 104783
		[Token(Token = "0x401994F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _arrowRotationOffset;

		// Token: 0x04019950 RID: 104784
		[Token(Token = "0x4019950")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _coinPanelText;

		// Token: 0x04019951 RID: 104785
		[Token(Token = "0x4019951")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationWrapper _gainCoinAnimWrapper;

		// Token: 0x04019952 RID: 104786
		[Token(Token = "0x4019952")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _gainCoinClipName;

		// Token: 0x04019953 RID: 104787
		[Token(Token = "0x4019953")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _gainCoinHolder;

		// Token: 0x04019954 RID: 104788
		[Token(Token = "0x4019954")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _feverEffectHolder;

		// Token: 0x04019955 RID: 104789
		[Token(Token = "0x4019955")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _timerText;

		// Token: 0x04019956 RID: 104790
		[Token(Token = "0x4019956")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<UIStateNode> _states;

		// Token: 0x04019957 RID: 104791
		[Token(Token = "0x4019957")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationPerform _accomplishedPerform;

		// Token: 0x04019958 RID: 104792
		[Token(Token = "0x4019958")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string[] _failedPanelTipDescKeys;

		// Token: 0x04019959 RID: 104793
		[Token(Token = "0x4019959")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasGroupInCombatBanner;

		// Token: 0x0401995A RID: 104794
		[Token(Token = "0x401995A")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_arrowFadeTween;

		// Token: 0x0401995B RID: 104795
		[Token(Token = "0x401995B")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_panelInCombatFadeTween;

		// Token: 0x0401995C RID: 104796
		[Token(Token = "0x401995C")]
		[FieldOffset(Offset = "0xB0")]
		private int m_oldCoinCnt;

		// Token: 0x0401995D RID: 104797
		[Token(Token = "0x401995D")]
		[FieldOffset(Offset = "0xB4")]
		private int m_oldPlayTime;

		// Token: 0x0401995E RID: 104798
		[Token(Token = "0x401995E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x0401995F RID: 104799
		[Token(Token = "0x401995F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04019960 RID: 104800
		[Token(Token = "0x4019960")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowOrHideArrow;

		// Token: 0x04019961 RID: 104801
		[Token(Token = "0x4019961")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDirectionInput;

		// Token: 0x04019962 RID: 104802
		[Token(Token = "0x4019962")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckInputDisabled;

		// Token: 0x04019963 RID: 104803
		[Token(Token = "0x4019963")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetJoystickAxis;

		// Token: 0x04019964 RID: 104804
		[Token(Token = "0x4019964")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateCoinPanel;

		// Token: 0x04019965 RID: 104805
		[Token(Token = "0x4019965")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateTimerPanel;

		// Token: 0x04019966 RID: 104806
		[Token(Token = "0x4019966")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ToggleInCombatPanel;

		// Token: 0x04019967 RID: 104807
		[Token(Token = "0x4019967")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04019968 RID: 104808
		[Token(Token = "0x4019968")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04019969 RID: 104809
		[Token(Token = "0x4019969")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishPerform;

		// Token: 0x0401996A RID: 104810
		[Token(Token = "0x401996A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HookGameStartStateSwitch;

		// Token: 0x0401996B RID: 104811
		[Token(Token = "0x401996B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0401996C RID: 104812
		[Token(Token = "0x401996C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0401996D RID: 104813
		[Token(Token = "0x401996D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

		// Token: 0x0401996E RID: 104814
		[Token(Token = "0x401996E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuHide;

		// Token: 0x0401996F RID: 104815
		[Token(Token = "0x401996F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_HookPauseMask;

		// Token: 0x04019970 RID: 104816
		[Token(Token = "0x4019970")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_HookBattleFailedTips;

		// Token: 0x04019971 RID: 104817
		[Token(Token = "0x4019971")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_HookBattleData;

		// Token: 0x04019972 RID: 104818
		[Token(Token = "0x4019972")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetEnemyBlocked;

		// Token: 0x04019973 RID: 104819
		[Token(Token = "0x4019973")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
