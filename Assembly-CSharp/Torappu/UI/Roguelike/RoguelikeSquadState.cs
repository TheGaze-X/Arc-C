using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.BattleFinish;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005529 RID: 21801
	[Token(Token = "0x2005529")]
	public class RoguelikeSquadState : PopupFadeState
	{
		// Token: 0x060200F3 RID: 131315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200F3")]
		[Address(RVA = "0x1A2B440", Offset = "0x1A2A040", VA = "0x181A2B440", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060200F4 RID: 131316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200F4")]
		[Address(RVA = "0x1A2BDA0", Offset = "0x1A2A9A0", VA = "0x181A2BDA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060200F5 RID: 131317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200F5")]
		[Address(RVA = "0x1A2CFE0", Offset = "0x1A2BBE0", VA = "0x181A2CFE0", Slot = "31")]
		protected virtual void TryRenderStartBattleButton()
		{
		}

		// Token: 0x060200F6 RID: 131318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200F6")]
		[Address(RVA = "0x1A2DCF0", Offset = "0x1A2C8F0", VA = "0x181A2DCF0")]
		private RoguelikeSquadStartBattleButtonPluginBase _LoadStartBattleButton()
		{
			return null;
		}

		// Token: 0x060200F7 RID: 131319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200F7")]
		[Address(RVA = "0x1A2B4A0", Offset = "0x1A2A0A0", VA = "0x181A2B4A0")]
		public List<RoguelikeCharCardViewModel> LoadAllCharList()
		{
			return null;
		}

		// Token: 0x060200F8 RID: 131320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200F8")]
		[Address(RVA = "0x1A2C320", Offset = "0x1A2AF20", VA = "0x181A2C320")]
		public void OnSelectEmptyPos(int index)
		{
		}

		// Token: 0x060200F9 RID: 131321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200F9")]
		[Address(RVA = "0x1A2CAE0", Offset = "0x1A2B6E0", VA = "0x181A2CAE0")]
		public void OnSelectSkill(int instId, string skillId)
		{
		}

		// Token: 0x060200FA RID: 131322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200FA")]
		[Address(RVA = "0x1A2C6F0", Offset = "0x1A2B2F0", VA = "0x181A2C6F0")]
		public void OnSelectExistChar(int instId)
		{
		}

		// Token: 0x060200FB RID: 131323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200FB")]
		[Address(RVA = "0x1A2B8A0", Offset = "0x1A2A4A0", VA = "0x181A2B8A0")]
		public void OnChangeAllChar()
		{
		}

		// Token: 0x060200FC RID: 131324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200FC")]
		[Address(RVA = "0x1A2BC40", Offset = "0x1A2A840", VA = "0x181A2BC40")]
		public void OnClearOnSelect()
		{
		}

		// Token: 0x060200FD RID: 131325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200FD")]
		[Address(RVA = "0x1A2AE00", Offset = "0x1A29A00", VA = "0x181A2AE00")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x060200FE RID: 131326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200FE")]
		[Address(RVA = "0x1A2D740", Offset = "0x1A2C340", VA = "0x181A2D740")]
		private void _EventOnStartBattle()
		{
		}

		// Token: 0x060200FF RID: 131327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200FF")]
		[Address(RVA = "0x1A2B180", Offset = "0x1A29D80", VA = "0x181A2B180")]
		public void EventOnStartBattleClicked()
		{
		}

		// Token: 0x06020100 RID: 131328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020100")]
		[Address(RVA = "0x1A2ED70", Offset = "0x1A2D970", VA = "0x181A2ED70")]
		private void _TryUnlockNodeByCost()
		{
		}

		// Token: 0x06020101 RID: 131329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020101")]
		[Address(RVA = "0x1A2AE60", Offset = "0x1A29A60", VA = "0x181A2AE60")]
		public void EventOnClearBtnClick()
		{
		}

		// Token: 0x06020102 RID: 131330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020102")]
		[Address(RVA = "0x1A2B0C0", Offset = "0x1A29CC0", VA = "0x181A2B0C0")]
		public void EventOnMultiFormatClick()
		{
		}

		// Token: 0x06020103 RID: 131331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020103")]
		[Address(RVA = "0x1A2D9B0", Offset = "0x1A2C5B0", VA = "0x181A2D9B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020104 RID: 131332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020104")]
		[Address(RVA = "0x1A2E250", Offset = "0x1A2CE50", VA = "0x181A2E250")]
		private void _StartBattle(List<RequestSquadSlot> slots)
		{
		}

		// Token: 0x06020105 RID: 131333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020105")]
		[Address(RVA = "0x1A2CE70", Offset = "0x1A2BA70", VA = "0x181A2CE70", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06020106 RID: 131334 RVA: 0x000B4708 File Offset: 0x000B2908
		[Token(Token = "0x6020106")]
		[Address(RVA = "0x1A2D580", Offset = "0x1A2C180", VA = "0x181A2D580")]
		private bool _EnsureSpChar(RoguelikeCharCardViewModel insertChar, List<RoguelikeCharCardViewModel> squadList)
		{
			return default(bool);
		}

		// Token: 0x06020107 RID: 131335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020107")]
		[Address(RVA = "0x1A2A510", Offset = "0x1A29110", VA = "0x181A2A510")]
		public void DealWithFromStateBean(IStateBean stateBean)
		{
		}

		// Token: 0x06020108 RID: 131336 RVA: 0x000B4720 File Offset: 0x000B2920
		[Token(Token = "0x6020108")]
		[Address(RVA = "0x1A2D3D0", Offset = "0x1A2BFD0", VA = "0x181A2D3D0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06020109 RID: 131337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020109")]
		[Address(RVA = "0x1A2CD00", Offset = "0x1A2B900", VA = "0x181A2CD00", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602010A RID: 131338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602010A")]
		[Address(RVA = "0x1A2DF60", Offset = "0x1A2CB60", VA = "0x181A2DF60")]
		private static void _PlaySquadVoice(List<RoguelikeCharCardViewModel> prevSquad, List<RoguelikeCharCardViewModel> newSquad)
		{
		}

		// Token: 0x0602010B RID: 131339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602010B")]
		[Address(RVA = "0x1A2D8B0", Offset = "0x1A2C4B0", VA = "0x181A2D8B0")]
		private List<RoguelikeTopicExtraBuffData> _GetTopicExtraBuffs(string topicId)
		{
			return null;
		}

		// Token: 0x0602010C RID: 131340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602010C")]
		[Address(RVA = "0x1A2D440", Offset = "0x1A2C040", VA = "0x181A2D440")]
		private void _BindNodeUnlockStrategies()
		{
		}

		// Token: 0x0602010D RID: 131341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602010D")]
		[Address(RVA = "0x1A2EDD0", Offset = "0x1A2D9D0", VA = "0x181A2EDD0")]
		private void _TryUnlockNodeByCost(string topicId)
		{
		}

		// Token: 0x0602010E RID: 131342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602010E")]
		[Address(RVA = "0x1A2F070", Offset = "0x1A2DC70", VA = "0x181A2F070")]
		public RoguelikeSquadState()
		{
		}

		// Token: 0x06020112 RID: 131346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020112")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06020113 RID: 131347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020113")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06020114 RID: 131348 RVA: 0x000B4738 File Offset: 0x000B2938
		[Token(Token = "0x6020114")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06020115 RID: 131349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020115")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0402B4C3 RID: 177347
		[Token(Token = "0x402B4C3")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0402B4C4 RID: 177348
		[Token(Token = "0x402B4C4")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeCharSelectStateBean.Input m_cacheInput;

		// Token: 0x0402B4C5 RID: 177349
		[Token(Token = "0x402B4C5")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeSquadStateBean m_squadStateBean;

		// Token: 0x0402B4C6 RID: 177350
		[Token(Token = "0x402B4C6")]
		private const int CACHE_CONST_MAX = 10;

		// Token: 0x0402B4C7 RID: 177351
		[Token(Token = "0x402B4C7")]
		private const string ANIMATORPARAM = "delete";

		// Token: 0x0402B4C8 RID: 177352
		[Token(Token = "0x402B4C8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RoguelikeSquadView _squadView;

		// Token: 0x0402B4C9 RID: 177353
		[Token(Token = "0x402B4C9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Animator _deleteState;

		// Token: 0x0402B4CA RID: 177354
		[Token(Token = "0x402B4CA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x0402B4CB RID: 177355
		[Token(Token = "0x402B4CB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIGuidebookTrigger _guideBookTrigger;

		// Token: 0x0402B4CC RID: 177356
		[Token(Token = "0x402B4CC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Start Battle")]
		private RectTransform _startBattleButtonRoot;

		// Token: 0x0402B4CD RID: 177357
		[Token(Token = "0x402B4CD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RoguelikeNodeCheckUnlockStrategyFactory _nodeCheckUnlockStrategyFactory;

		// Token: 0x0402B4CE RID: 177358
		[Token(Token = "0x402B4CE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _pluginContainer;

		// Token: 0x0402B4CF RID: 177359
		[Token(Token = "0x402B4CF")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeCommonTopMenu m_topMenu;

		// Token: 0x0402B4D0 RID: 177360
		[Token(Token = "0x402B4D0")]
		[FieldOffset(Offset = "0xC8")]
		private RoguelikeMenuAdapter m_menuAdapter;

		// Token: 0x0402B4D1 RID: 177361
		[Token(Token = "0x402B4D1")]
		[FieldOffset(Offset = "0xD0")]
		private List<IRoguelikeCharCardViewPluginContext> m_pluginContexts;

		// Token: 0x0402B4D2 RID: 177362
		[Token(Token = "0x402B4D2")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeSquadStartBattleButtonPluginBase m_curStartBattleButtonPlugin;

		// Token: 0x0402B4D3 RID: 177363
		[Token(Token = "0x402B4D3")]
		[FieldOffset(Offset = "0xE0")]
		private RoguelikeSquadStatePlugin m_statePlugin;

		// Token: 0x0402B4D4 RID: 177364
		[Token(Token = "0x402B4D4")]
		[FieldOffset(Offset = "0xE8")]
		private IRoguelikeSquadBattleStartHandler m_startBattleHandler;

		// Token: 0x0402B4D5 RID: 177365
		[Token(Token = "0x402B4D5")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_deleteFlag;

		// Token: 0x0402B4D6 RID: 177366
		[Token(Token = "0x402B4D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402B4D7 RID: 177367
		[Token(Token = "0x402B4D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402B4D8 RID: 177368
		[Token(Token = "0x402B4D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryRenderStartBattleButton;

		// Token: 0x0402B4D9 RID: 177369
		[Token(Token = "0x402B4D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadStartBattleButton;

		// Token: 0x0402B4DA RID: 177370
		[Token(Token = "0x402B4DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadAllCharList;

		// Token: 0x0402B4DB RID: 177371
		[Token(Token = "0x402B4DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSelectEmptyPos;

		// Token: 0x0402B4DC RID: 177372
		[Token(Token = "0x402B4DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnSelectSkill;

		// Token: 0x0402B4DD RID: 177373
		[Token(Token = "0x402B4DD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSelectExistChar;

		// Token: 0x0402B4DE RID: 177374
		[Token(Token = "0x402B4DE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnChangeAllChar;

		// Token: 0x0402B4DF RID: 177375
		[Token(Token = "0x402B4DF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClearOnSelect;

		// Token: 0x0402B4E0 RID: 177376
		[Token(Token = "0x402B4E0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0402B4E1 RID: 177377
		[Token(Token = "0x402B4E1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnStartBattle;

		// Token: 0x0402B4E2 RID: 177378
		[Token(Token = "0x402B4E2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnStartBattleClicked;

		// Token: 0x0402B4E3 RID: 177379
		[Token(Token = "0x402B4E3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryUnlockNodeByCost;

		// Token: 0x0402B4E4 RID: 177380
		[Token(Token = "0x402B4E4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnClearBtnClick;

		// Token: 0x0402B4E5 RID: 177381
		[Token(Token = "0x402B4E5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormatClick;

		// Token: 0x0402B4E6 RID: 177382
		[Token(Token = "0x402B4E6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B4E7 RID: 177383
		[Token(Token = "0x402B4E7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__StartBattle;

		// Token: 0x0402B4E8 RID: 177384
		[Token(Token = "0x402B4E8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402B4E9 RID: 177385
		[Token(Token = "0x402B4E9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EnsureSpChar;

		// Token: 0x0402B4EA RID: 177386
		[Token(Token = "0x402B4EA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_DealWithFromStateBean;

		// Token: 0x0402B4EB RID: 177387
		[Token(Token = "0x402B4EB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0402B4EC RID: 177388
		[Token(Token = "0x402B4EC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0402B4ED RID: 177389
		[Token(Token = "0x402B4ED")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__PlaySquadVoice;

		// Token: 0x0402B4EE RID: 177390
		[Token(Token = "0x402B4EE")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetTopicExtraBuffs;

		// Token: 0x0402B4EF RID: 177391
		[Token(Token = "0x402B4EF")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__BindNodeUnlockStrategies;

		// Token: 0x0402B4F0 RID: 177392
		[Token(Token = "0x402B4F0")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix1__TryUnlockNodeByCost;

		// Token: 0x0402B4F1 RID: 177393
		[Token(Token = "0x402B4F1")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200552A RID: 21802
		[Token(Token = "0x200552A")]
		private class RoguelikeStartBattleServiceConfig : StartBattleServiceConfig<RoguelikeStartBattleRequest, DefaultStartBattleResponse>
		{
			// Token: 0x17004B35 RID: 19253
			// (get) Token: 0x06020116 RID: 131350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004B35")]
			protected override string serviceCode
			{
				[Token(Token = "0x6020116")]
				[Address(RVA = "0x1A3D7F0", Offset = "0x1A3C3F0", VA = "0x181A3D7F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06020117 RID: 131351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020117")]
			[Address(RVA = "0x1A3D720", Offset = "0x1A3C320", VA = "0x181A3D720")]
			public RoguelikeStartBattleServiceConfig(RoguelikeNodePosition toPos, string stageId, CommonStartBattleRequest.SquadModel squad)
			{
			}

			// Token: 0x06020118 RID: 131352 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020118")]
			[Address(RVA = "0x1A3D660", Offset = "0x1A3C260", VA = "0x181A3D660", Slot = "5")]
			protected override RoguelikeStartBattleRequest ParseRequest()
			{
				return null;
			}

			// Token: 0x0402B4F2 RID: 177394
			[Token(Token = "0x402B4F2")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeNodePosition m_toPos;

			// Token: 0x0402B4F3 RID: 177395
			[Token(Token = "0x402B4F3")]
			[FieldOffset(Offset = "0x18")]
			private string m_stageId;

			// Token: 0x0402B4F4 RID: 177396
			[Token(Token = "0x402B4F4")]
			[FieldOffset(Offset = "0x20")]
			private CommonStartBattleRequest.SquadModel m_squad;

			// Token: 0x0402B4F5 RID: 177397
			[Token(Token = "0x402B4F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x0402B4F6 RID: 177398
			[Token(Token = "0x402B4F6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B4F7 RID: 177399
			[Token(Token = "0x402B4F7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ParseRequest;
		}

		// Token: 0x0200552B RID: 21803
		[Token(Token = "0x200552B")]
		private class RoguelikeFinishBattleServiceConfig : FinishBattleServiceConfig<RoguelikeFinishBattleRequest, RoguelikeFinishBattleResponse>
		{
			// Token: 0x17004B36 RID: 19254
			// (get) Token: 0x06020119 RID: 131353 RVA: 0x000B4750 File Offset: 0x000B2950
			[Token(Token = "0x17004B36")]
			public override int overrideMaxRetryCount
			{
				[Token(Token = "0x6020119")]
				[Address(RVA = "0x13A8070", Offset = "0x13A6C70", VA = "0x1813A8070", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602011A RID: 131354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602011A")]
			[Address(RVA = "0x1A3A980", Offset = "0x1A39580", VA = "0x181A3A980")]
			public RoguelikeFinishBattleServiceConfig(string serviceCode)
			{
			}

			// Token: 0x0602011B RID: 131355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602011B")]
			[Address(RVA = "0x1A3A850", Offset = "0x1A39450", VA = "0x181A3A850", Slot = "9")]
			public override void OnParseRequest(RoguelikeFinishBattleRequest request)
			{
			}

			// Token: 0x0402B4F8 RID: 177400
			[Token(Token = "0x402B4F8")]
			private const int FINISH_BATTLE_SERVICE_MAX_RETRY_COUNT = 100;
		}

		// Token: 0x0200552C RID: 21804
		[Token(Token = "0x200552C")]
		private class RoguelikeBattleStartControllerPlugin : BattleStartController.IPlugin
		{
			// Token: 0x0602011C RID: 131356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602011C")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public RoguelikeBattleStartControllerPlugin(RoguelikeSquadState state, RoguelikeSquadStateBean bean)
			{
			}

			// Token: 0x0602011D RID: 131357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602011D")]
			[Address(RVA = "0x1A399D0", Offset = "0x1A385D0", VA = "0x181A399D0", Slot = "4")]
			public void OverrideInParams(ref BattleInOut.InParams inParams, CommonStartBattleResponse response)
			{
			}

			// Token: 0x0602011E RID: 131358 RVA: 0x000B4768 File Offset: 0x000B2968
			[Token(Token = "0x602011E")]
			[Address(RVA = "0x1A3A800", Offset = "0x1A39400", VA = "0x181A3A800")]
			private GameModeMeta.GameModeType _CheckRoguelikeGameModeType(string topicId, RoguelikeDungeonNode focusNode)
			{
				return GameModeMeta.GameModeType.DEFAULT;
			}

			// Token: 0x0402B4F9 RID: 177401
			[Token(Token = "0x402B4F9")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeSquadState m_state;

			// Token: 0x0402B4FA RID: 177402
			[Token(Token = "0x402B4FA")]
			[FieldOffset(Offset = "0x18")]
			private RoguelikeSquadStateBean m_bean;
		}

		// Token: 0x0200552D RID: 21805
		[Token(Token = "0x200552D")]
		private class RoguelikeBattleFinishIndexPlugin : BattleFinishIndexState.Plugin
		{
			// Token: 0x0602011F RID: 131359 RVA: 0x000B4780 File Offset: 0x000B2980
			[Token(Token = "0x602011F")]
			[Address(RVA = "0x1A398E0", Offset = "0x1A384E0", VA = "0x181A398E0", Slot = "5")]
			public override bool HandleRedirection()
			{
				return default(bool);
			}

			// Token: 0x06020120 RID: 131360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020120")]
			[Address(RVA = "0x1A39970", Offset = "0x1A38570", VA = "0x181A39970")]
			public RoguelikeBattleFinishIndexPlugin()
			{
			}

			// Token: 0x06020121 RID: 131361 RVA: 0x000B4798 File Offset: 0x000B2998
			[Token(Token = "0x6020121")]
			[Address(RVA = "0x1A39960", Offset = "0x1A38560", VA = "0x181A39960")]
			private bool <>xLuaBaseProxy_HandleRedirection()
			{
				return default(bool);
			}

			// Token: 0x0402B4FB RID: 177403
			[Token(Token = "0x402B4FB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_HandleRedirection;

			// Token: 0x0402B4FC RID: 177404
			[Token(Token = "0x402B4FC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
