using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.UI.Popup;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003349 RID: 13129
	[Token(Token = "0x2003349")]
	public class UIRoguelikePlugin : UIController.Plugin
	{
		// Token: 0x06014F14 RID: 85780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F14")]
		[Address(RVA = "0xD654E0", Offset = "0xD640E0", VA = "0x180D654E0", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x06014F15 RID: 85781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F15")]
		[Address(RVA = "0xD65610", Offset = "0xD64210", VA = "0x180D65610", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06014F16 RID: 85782 RVA: 0x00089940 File Offset: 0x00087B40
		[Token(Token = "0x6014F16")]
		[Address(RVA = "0xD65350", Offset = "0xD63F50", VA = "0x180D65350", Slot = "22")]
		public override bool HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014F17 RID: 85783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014F17")]
		[Address(RVA = "0xD64A70", Offset = "0xD63670", VA = "0x180D64A70", Slot = "29")]
		public override RectTransform HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x06014F18 RID: 85784 RVA: 0x00089958 File Offset: 0x00087B58
		[Token(Token = "0x6014F18")]
		[Address(RVA = "0xD651B0", Offset = "0xD63DB0", VA = "0x180D651B0", Slot = "35")]
		public override bool HookConfirmFinish(Action finishCallback)
		{
			return default(bool);
		}

		// Token: 0x06014F19 RID: 85785 RVA: 0x00089970 File Offset: 0x00087B70
		[Token(Token = "0x6014F19")]
		[Address(RVA = "0xD64B50", Offset = "0xD63750", VA = "0x180D64B50", Slot = "30")]
		public override bool HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014F1A RID: 85786 RVA: 0x00089988 File Offset: 0x00087B88
		[Token(Token = "0x6014F1A")]
		[Address(RVA = "0xD649F0", Offset = "0xD635F0", VA = "0x180D649F0", Slot = "31")]
		public override bool HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x06014F1B RID: 85787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F1B")]
		[Address(RVA = "0xD65770", Offset = "0xD64370", VA = "0x180D65770")]
		public void OnPanelClick()
		{
		}

		// Token: 0x06014F1C RID: 85788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F1C")]
		[Address(RVA = "0xD65960", Offset = "0xD64560", VA = "0x180D65960")]
		public UIRoguelikePlugin()
		{
		}

		// Token: 0x06014F1D RID: 85789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F1D")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06014F1E RID: 85790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F1E")]
		[Address(RVA = "0xD520E0", Offset = "0xD50CE0", VA = "0x180D520E0")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06014F1F RID: 85791 RVA: 0x000899A0 File Offset: 0x00087BA0
		[Token(Token = "0x6014F1F")]
		[Address(RVA = "0xD57EA0", Offset = "0xD56AA0", VA = "0x180D57EA0")]
		private bool <>xLuaBaseProxy_HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014F20 RID: 85792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014F20")]
		[Address(RVA = "0xD57A80", Offset = "0xD56680", VA = "0x180D57A80")]
		private RectTransform <>xLuaBaseProxy_HookBattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x06014F21 RID: 85793 RVA: 0x000899B8 File Offset: 0x00087BB8
		[Token(Token = "0x6014F21")]
		[Address(RVA = "0xD57D40", Offset = "0xD56940", VA = "0x180D57D40")]
		private bool <>xLuaBaseProxy_HookConfirmFinish(Action P0)
		{
			return default(bool);
		}

		// Token: 0x06014F22 RID: 85794 RVA: 0x000899D0 File Offset: 0x00087BD0
		[Token(Token = "0x6014F22")]
		[Address(RVA = "0xD57AE0", Offset = "0xD566E0", VA = "0x180D57AE0")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelShow()
		{
			return default(bool);
		}

		// Token: 0x06014F23 RID: 85795 RVA: 0x000899E8 File Offset: 0x00087BE8
		[Token(Token = "0x6014F23")]
		[Address(RVA = "0xD57A20", Offset = "0xD56620", VA = "0x180D57A20")]
		private bool <>xLuaBaseProxy_HookBattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x04018E80 RID: 102016
		[Token(Token = "0x4018E80")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x04018E81 RID: 102017
		[Token(Token = "0x4018E81")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _icon;

		// Token: 0x04018E82 RID: 102018
		[Token(Token = "0x4018E82")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _title;

		// Token: 0x04018E83 RID: 102019
		[Token(Token = "0x4018E83")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<Text> _textHints;

		// Token: 0x04018E84 RID: 102020
		[Token(Token = "0x4018E84")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _fadeinDuration;

		// Token: 0x04018E85 RID: 102021
		[Token(Token = "0x4018E85")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIDiceToastPanel _toastDicePanelPrefab;

		// Token: 0x04018E86 RID: 102022
		[Token(Token = "0x4018E86")]
		[FieldOffset(Offset = "0x58")]
		private readonly int HINT_COUNT;

		// Token: 0x04018E87 RID: 102023
		[Token(Token = "0x4018E87")]
		[FieldOffset(Offset = "0x60")]
		private readonly string HINT_PREFIX;

		// Token: 0x04018E88 RID: 102024
		[Token(Token = "0x4018E88")]
		[FieldOffset(Offset = "0x68")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x04018E89 RID: 102025
		[Token(Token = "0x4018E89")]
		[FieldOffset(Offset = "0x70")]
		private UIDiceToastPanel m_diceToastPanel;

		// Token: 0x04018E8A RID: 102026
		[Token(Token = "0x4018E8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04018E8B RID: 102027
		[Token(Token = "0x4018E8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04018E8C RID: 102028
		[Token(Token = "0x4018E8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HookGameReadyStateSwitch;

		// Token: 0x04018E8D RID: 102029
		[Token(Token = "0x4018E8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelInit;

		// Token: 0x04018E8E RID: 102030
		[Token(Token = "0x4018E8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HookConfirmFinish;

		// Token: 0x04018E8F RID: 102031
		[Token(Token = "0x4018E8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelShow;

		// Token: 0x04018E90 RID: 102032
		[Token(Token = "0x4018E90")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HookBattleFailedPanelHide;

		// Token: 0x04018E91 RID: 102033
		[Token(Token = "0x4018E91")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPanelClick;

		// Token: 0x04018E92 RID: 102034
		[Token(Token = "0x4018E92")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
