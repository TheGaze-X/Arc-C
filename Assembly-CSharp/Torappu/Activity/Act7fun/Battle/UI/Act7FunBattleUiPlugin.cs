using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act7Fun.Battle.UI
{
	// Token: 0x020071A3 RID: 29091
	[Token(Token = "0x20071A3")]
	public class Act7FunBattleUiPlugin : UIController.Plugin
	{
		// Token: 0x0602946C RID: 169068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602946C")]
		[Address(RVA = "0x24BBD70", Offset = "0x24BA970", VA = "0x1824BBD70", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0602946D RID: 169069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602946D")]
		[Address(RVA = "0x24BC2B0", Offset = "0x24BAEB0", VA = "0x1824BC2B0", Slot = "13")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x0602946E RID: 169070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602946E")]
		[Address(RVA = "0x24BB930", Offset = "0x24BA530", VA = "0x1824BB930", Slot = "38")]
		public override void OnDummyTouchedToTile(Character character, Tile tile)
		{
		}

		// Token: 0x0602946F RID: 169071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602946F")]
		[Address(RVA = "0x24BC690", Offset = "0x24BB290", VA = "0x1824BC690", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06029470 RID: 169072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029470")]
		[Address(RVA = "0x24BC130", Offset = "0x24BAD30", VA = "0x1824BC130", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06029471 RID: 169073 RVA: 0x000D4FB8 File Offset: 0x000D31B8
		[Token(Token = "0x6029471")]
		[Address(RVA = "0x24BB450", Offset = "0x24BA050", VA = "0x1824BB450", Slot = "23")]
		public override bool HookGameStartStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06029472 RID: 169074 RVA: 0x000D4FD0 File Offset: 0x000D31D0
		[Token(Token = "0x6029472")]
		[Address(RVA = "0x24BAEC0", Offset = "0x24B9AC0", VA = "0x1824BAEC0", Slot = "44")]
		public override bool CanPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x06029473 RID: 169075 RVA: 0x000D4FE8 File Offset: 0x000D31E8
		[Token(Token = "0x6029473")]
		[Address(RVA = "0x24BAFB0", Offset = "0x24B9BB0", VA = "0x1824BAFB0", Slot = "25")]
		public override bool HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06029474 RID: 169076 RVA: 0x000D5000 File Offset: 0x000D3200
		[Token(Token = "0x6029474")]
		[Address(RVA = "0x24BB090", Offset = "0x24B9C90", VA = "0x1824BB090", Slot = "32")]
		public override bool HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x06029475 RID: 169077 RVA: 0x000D5018 File Offset: 0x000D3218
		[Token(Token = "0x6029475")]
		[Address(RVA = "0x24BB180", Offset = "0x24B9D80", VA = "0x1824BB180", Slot = "35")]
		public override bool HookConfirmFinish(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x06029476 RID: 169078 RVA: 0x000D5030 File Offset: 0x000D3230
		[Token(Token = "0x6029476")]
		[Address(RVA = "0x24BB520", Offset = "0x24BA120", VA = "0x1824BB520", Slot = "53")]
		public override bool HookGetProfessionImage(Image image, Deck.Card card, ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode)
		{
			return default(bool);
		}

		// Token: 0x06029477 RID: 169079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029477")]
		[Address(RVA = "0x24BC860", Offset = "0x24BB460", VA = "0x1824BC860")]
		private void _OnGameStart(object args)
		{
		}

		// Token: 0x06029478 RID: 169080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029478")]
		[Address(RVA = "0x24BC9A0", Offset = "0x24BB5A0", VA = "0x1824BC9A0")]
		public Act7FunBattleUiPlugin()
		{
		}

		// Token: 0x0602947A RID: 169082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602947A")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x0602947B RID: 169083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602947B")]
		[Address(RVA = "0x7D24D0", Offset = "0x7D10D0", VA = "0x1807D24D0")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x0602947C RID: 169084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602947C")]
		[Address(RVA = "0x9CCDE0", Offset = "0x9CB9E0", VA = "0x1809CCDE0")]
		private void <>xLuaBaseProxy_OnDummyTouchedToTile(Character P0, Tile P1)
		{
		}

		// Token: 0x0602947D RID: 169085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602947D")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0602947E RID: 169086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602947E")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x0602947F RID: 169087 RVA: 0x000D5048 File Offset: 0x000D3248
		[Token(Token = "0x602947F")]
		[Address(RVA = "0xD69530", Offset = "0xD68130", VA = "0x180D69530")]
		private bool <>xLuaBaseProxy_HookGameStartStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06029480 RID: 169088 RVA: 0x000D5060 File Offset: 0x000D3260
		[Token(Token = "0x6029480")]
		[Address(RVA = "0xDD4300", Offset = "0xDD2F00", VA = "0x180DD4300")]
		private bool <>xLuaBaseProxy_CanPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x06029481 RID: 169089 RVA: 0x000D5078 File Offset: 0x000D3278
		[Token(Token = "0x6029481")]
		[Address(RVA = "0x960A00", Offset = "0x95F600", VA = "0x180960A00")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06029482 RID: 169090 RVA: 0x000D5090 File Offset: 0x000D3290
		[Token(Token = "0x6029482")]
		[Address(RVA = "0x7D2470", Offset = "0x7D1070", VA = "0x1807D2470")]
		private bool <>xLuaBaseProxy_HookBattleSystemMenuSwitch()
		{
			return default(bool);
		}

		// Token: 0x06029483 RID: 169091 RVA: 0x000D50A8 File Offset: 0x000D32A8
		[Token(Token = "0x6029483")]
		[Address(RVA = "0x960A20", Offset = "0x95F620", VA = "0x180960A20")]
		private bool <>xLuaBaseProxy_HookConfirmFinish(Action P0)
		{
			return default(bool);
		}

		// Token: 0x06029484 RID: 169092 RVA: 0x000D50C0 File Offset: 0x000D32C0
		[Token(Token = "0x6029484")]
		[Address(RVA = "0x24BC660", Offset = "0x24BB260", VA = "0x1824BC660")]
		private bool <>xLuaBaseProxy_HookGetProfessionImage(Image P0, Deck.Card P1, ObjectPtr<Character> P2, UICharacterInfoPanel.ModeType P3)
		{
			return default(bool);
		}

		// Token: 0x0403AF40 RID: 241472
		[Token(Token = "0x403AF40")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum ON_GAME_START_STATE;

		// Token: 0x0403AF41 RID: 241473
		[Token(Token = "0x403AF41")]
		[FieldOffset(Offset = "0x4")]
		public static readonly UIStateEnum ON_BATTLE_FINISH_STATE;

		// Token: 0x0403AF42 RID: 241474
		[Token(Token = "0x403AF42")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UIStateEnum BATTLE_MENU_STATE;

		// Token: 0x0403AF43 RID: 241475
		[Token(Token = "0x403AF43")]
		public const float BATTLE_DIRECTOR_TWEEN_DURATION = 0.12f;

		// Token: 0x0403AF44 RID: 241476
		[Token(Token = "0x403AF44")]
		public const string DIRECTOR_TAG_FILTER = "act7fun_direct";

		// Token: 0x0403AF45 RID: 241477
		[Token(Token = "0x403AF45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _directorPrefab;

		// Token: 0x0403AF46 RID: 241478
		[Token(Token = "0x403AF46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TargetSelector _getTrapSelector;

		// Token: 0x0403AF47 RID: 241479
		[Token(Token = "0x403AF47")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Ability _selectorEmptyAbility;

		// Token: 0x0403AF48 RID: 241480
		[Token(Token = "0x403AF48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act7FunBattleHUDPanel _hudPanel;

		// Token: 0x0403AF49 RID: 241481
		[Token(Token = "0x403AF49")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x0403AF4A RID: 241482
		[Token(Token = "0x403AF4A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ProfessionCardUiPlugin _professionPlugin;

		// Token: 0x0403AF4B RID: 241483
		[Token(Token = "0x403AF4B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _showInfoImageBack;

		// Token: 0x0403AF4C RID: 241484
		[Token(Token = "0x403AF4C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInDragState;

		// Token: 0x0403AF4D RID: 241485
		[Token(Token = "0x403AF4D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_director;

		// Token: 0x0403AF4E RID: 241486
		[Token(Token = "0x403AF4E")]
		[FieldOffset(Offset = "0x70")]
		private Act7FunBattleHUDPanel m_hudPanel;

		// Token: 0x0403AF4F RID: 241487
		[Token(Token = "0x403AF4F")]
		[FieldOffset(Offset = "0x78")]
		private GameModeFactory.Act7FunGameMode m_gameMode;

		// Token: 0x0403AF50 RID: 241488
		[Token(Token = "0x403AF50")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_directorTween;

		// Token: 0x0403AF51 RID: 241489
		[Token(Token = "0x403AF51")]
		[FieldOffset(Offset = "0x88")]
		private Image m_showInfoImageBack;

		// Token: 0x0403AF52 RID: 241490
		[Token(Token = "0x403AF52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0403AF53 RID: 241491
		[Token(Token = "0x403AF53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x0403AF54 RID: 241492
		[Token(Token = "0x403AF54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDummyTouchedToTile;

		// Token: 0x0403AF55 RID: 241493
		[Token(Token = "0x403AF55")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403AF56 RID: 241494
		[Token(Token = "0x403AF56")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0403AF57 RID: 241495
		[Token(Token = "0x403AF57")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookGameStartStateSwitch;

		// Token: 0x0403AF58 RID: 241496
		[Token(Token = "0x403AF58")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CanPressBackButton;

		// Token: 0x0403AF59 RID: 241497
		[Token(Token = "0x403AF59")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

		// Token: 0x0403AF5A RID: 241498
		[Token(Token = "0x403AF5A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

		// Token: 0x0403AF5B RID: 241499
		[Token(Token = "0x403AF5B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HookConfirmFinish;

		// Token: 0x0403AF5C RID: 241500
		[Token(Token = "0x403AF5C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HookGetProfessionImage;

		// Token: 0x0403AF5D RID: 241501
		[Token(Token = "0x403AF5D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0403AF5E RID: 241502
		[Token(Token = "0x403AF5E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
