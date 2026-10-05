using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DC2 RID: 15810
	[Token(Token = "0x2003DC2")]
	public class RuneSquadHomeState : State, IRuneSquadController, ISquadCharSelectContext
	{
		// Token: 0x06018963 RID: 100707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018963")]
		[Address(RVA = "0x11060B0", Offset = "0x1104CB0", VA = "0x1811060B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018964 RID: 100708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018964")]
		[Address(RVA = "0x11063B0", Offset = "0x1104FB0", VA = "0x1811063B0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06018965 RID: 100709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018965")]
		[Address(RVA = "0x1105F70", Offset = "0x1104B70", VA = "0x181105F70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018966 RID: 100710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018966")]
		[Address(RVA = "0x1106610", Offset = "0x1105210", VA = "0x181106610", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018967 RID: 100711 RVA: 0x0009ADB8 File Offset: 0x00098FB8
		[Token(Token = "0x6018967")]
		[Address(RVA = "0x1106E90", Offset = "0x1105A90", VA = "0x181106E90", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06018968 RID: 100712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018968")]
		[Address(RVA = "0x1106440", Offset = "0x1105040", VA = "0x181106440", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06018969 RID: 100713 RVA: 0x0009ADD0 File Offset: 0x00098FD0
		[Token(Token = "0x6018969")]
		[Address(RVA = "0x1105E10", Offset = "0x1104A10", VA = "0x181105E10")]
		public static SquadFriendListItem.LockedStyle GenLockedStyle4CharInvalid()
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x0601896A RID: 100714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601896A")]
		[Address(RVA = "0x1107240", Offset = "0x1105E40", VA = "0x181107240")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601896B RID: 100715 RVA: 0x0009ADE8 File Offset: 0x00098FE8
		[Token(Token = "0x601896B")]
		[Address(RVA = "0x11056E0", Offset = "0x11042E0", VA = "0x1811056E0")]
		public bool CheckIfCharInstSelectable(int instId)
		{
			return default(bool);
		}

		// Token: 0x0601896C RID: 100716 RVA: 0x0009AE00 File Offset: 0x00099000
		[Token(Token = "0x601896C")]
		[Address(RVA = "0x1105850", Offset = "0x1104450", VA = "0x181105850", Slot = "23")]
		public bool CheckIfCharSelectable(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x0601896D RID: 100717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601896D")]
		[Address(RVA = "0x1106050", Offset = "0x1104C50", VA = "0x181106050", Slot = "24")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x0601896E RID: 100718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601896E")]
		[Address(RVA = "0x1105FD0", Offset = "0x1104BD0", VA = "0x181105FD0", Slot = "25")]
		public SquadGroupViewModel GetSquadGroupViewModel()
		{
			return null;
		}

		// Token: 0x0601896F RID: 100719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601896F")]
		[Address(RVA = "0x1107D90", Offset = "0x1106990", VA = "0x181107D90")]
		private void _OnSingleFormationClicked(int index)
		{
		}

		// Token: 0x06018970 RID: 100720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018970")]
		[Address(RVA = "0x1107E30", Offset = "0x1106A30", VA = "0x181107E30")]
		private void _OnTopMenuRoutedToOtherPage(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x06018971 RID: 100721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018971")]
		[Address(RVA = "0x1105B90", Offset = "0x1104790", VA = "0x181105B90")]
		public void EventOnMultiFormationClicked()
		{
		}

		// Token: 0x06018972 RID: 100722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018972")]
		[Address(RVA = "0x1105AD0", Offset = "0x11046D0", VA = "0x181105AD0")]
		public void EventOnClearAssistClicked()
		{
		}

		// Token: 0x06018973 RID: 100723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018973")]
		[Address(RVA = "0x1105900", Offset = "0x1104500", VA = "0x181105900")]
		public void EventOnAssistClicked()
		{
		}

		// Token: 0x06018974 RID: 100724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018974")]
		[Address(RVA = "0x1105C30", Offset = "0x1104830", VA = "0x181105C30")]
		public void EventOnStartBattleClicked()
		{
		}

		// Token: 0x06018975 RID: 100725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018975")]
		[Address(RVA = "0x1107120", Offset = "0x1105D20", VA = "0x181107120")]
		private void _GoToCharSelectState()
		{
		}

		// Token: 0x06018976 RID: 100726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018976")]
		[Address(RVA = "0x11071B0", Offset = "0x1105DB0", VA = "0x1811071B0")]
		private void _GoToFriendAssistState()
		{
		}

		// Token: 0x06018977 RID: 100727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018977")]
		[Address(RVA = "0x1107B30", Offset = "0x1106730", VA = "0x181107B30")]
		private void _OnCharSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x06018978 RID: 100728 RVA: 0x0009AE18 File Offset: 0x00099018
		[Token(Token = "0x6018978")]
		[Address(RVA = "0x1107FD0", Offset = "0x1106BD0", VA = "0x181107FD0")]
		private CharSelectStateBean.Input _ParseSquadSelectParam()
		{
			return default(CharSelectStateBean.Input);
		}

		// Token: 0x06018979 RID: 100729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018979")]
		[Address(RVA = "0x1108560", Offset = "0x1107160", VA = "0x181108560")]
		private void _SaveSquadFormationIfNeeded(Action nextStep)
		{
		}

		// Token: 0x0601897A RID: 100730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601897A")]
		[Address(RVA = "0x1107050", Offset = "0x1105C50", VA = "0x181107050")]
		private SquadItemStruct[] _GetCurSquadMembers()
		{
			return null;
		}

		// Token: 0x0601897B RID: 100731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601897B")]
		[Address(RVA = "0x1106F00", Offset = "0x1105B00", VA = "0x181106F00")]
		private void _DoStartBattle()
		{
		}

		// Token: 0x0601897C RID: 100732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601897C")]
		[Address(RVA = "0x1107320", Offset = "0x1105F20", VA = "0x181107320")]
		private void _InvokedStartBattle()
		{
		}

		// Token: 0x0601897D RID: 100733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601897D")]
		[Address(RVA = "0x1108600", Offset = "0x1107200", VA = "0x181108600")]
		public RuneSquadHomeState()
		{
		}

		// Token: 0x06018985 RID: 100741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018985")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018986 RID: 100742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018986")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06018987 RID: 100743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018987")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018988 RID: 100744 RVA: 0x0009AE30 File Offset: 0x00099030
		[Token(Token = "0x6018988")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06018989 RID: 100745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018989")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0401E24D RID: 123469
		[Token(Token = "0x401E24D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PrefabInstHolder _topMenuContainer;

		// Token: 0x0401E24E RID: 123470
		[Token(Token = "0x401E24E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SquadAssistCardView _assistCard;

		// Token: 0x0401E24F RID: 123471
		[Token(Token = "0x401E24F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RuneSquadGroupController _squadGroupController;

		// Token: 0x0401E250 RID: 123472
		[Token(Token = "0x401E250")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SquadCharSelectMaskPlugin _charSelectMask;

		// Token: 0x0401E251 RID: 123473
		[Token(Token = "0x401E251")]
		[FieldOffset(Offset = "0x70")]
		private RuneSquadHomeStateBeanV1 m_stateBean;

		// Token: 0x0401E252 RID: 123474
		[Token(Token = "0x401E252")]
		[FieldOffset(Offset = "0x78")]
		private RuneSquadHomeState.CharSelectContext m_charSelectContext;

		// Token: 0x0401E253 RID: 123475
		[Token(Token = "0x401E253")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401E254 RID: 123476
		[Token(Token = "0x401E254")]
		[FieldOffset(Offset = "0x88")]
		private SquadHomeState.DefaultCharSelectInput m_charSelectInputParam;

		// Token: 0x0401E255 RID: 123477
		[Token(Token = "0x401E255")]
		[FieldOffset(Offset = "0xD0")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0401E256 RID: 123478
		[Token(Token = "0x401E256")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E257 RID: 123479
		[Token(Token = "0x401E257")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401E258 RID: 123480
		[Token(Token = "0x401E258")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E259 RID: 123481
		[Token(Token = "0x401E259")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401E25A RID: 123482
		[Token(Token = "0x401E25A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0401E25B RID: 123483
		[Token(Token = "0x401E25B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0401E25C RID: 123484
		[Token(Token = "0x401E25C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenLockedStyle4CharInvalid;

		// Token: 0x0401E25D RID: 123485
		[Token(Token = "0x401E25D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E25E RID: 123486
		[Token(Token = "0x401E25E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfCharInstSelectable;

		// Token: 0x0401E25F RID: 123487
		[Token(Token = "0x401E25F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfCharSelectable;

		// Token: 0x0401E260 RID: 123488
		[Token(Token = "0x401E260")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0401E261 RID: 123489
		[Token(Token = "0x401E261")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSquadGroupViewModel;

		// Token: 0x0401E262 RID: 123490
		[Token(Token = "0x401E262")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSingleFormationClicked;

		// Token: 0x0401E263 RID: 123491
		[Token(Token = "0x401E263")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnTopMenuRoutedToOtherPage;

		// Token: 0x0401E264 RID: 123492
		[Token(Token = "0x401E264")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormationClicked;

		// Token: 0x0401E265 RID: 123493
		[Token(Token = "0x401E265")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnClearAssistClicked;

		// Token: 0x0401E266 RID: 123494
		[Token(Token = "0x401E266")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnAssistClicked;

		// Token: 0x0401E267 RID: 123495
		[Token(Token = "0x401E267")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnStartBattleClicked;

		// Token: 0x0401E268 RID: 123496
		[Token(Token = "0x401E268")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GoToCharSelectState;

		// Token: 0x0401E269 RID: 123497
		[Token(Token = "0x401E269")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GoToFriendAssistState;

		// Token: 0x0401E26A RID: 123498
		[Token(Token = "0x401E26A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnCharSelectFinished;

		// Token: 0x0401E26B RID: 123499
		[Token(Token = "0x401E26B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ParseSquadSelectParam;

		// Token: 0x0401E26C RID: 123500
		[Token(Token = "0x401E26C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SaveSquadFormationIfNeeded;

		// Token: 0x0401E26D RID: 123501
		[Token(Token = "0x401E26D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetCurSquadMembers;

		// Token: 0x0401E26E RID: 123502
		[Token(Token = "0x401E26E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__DoStartBattle;

		// Token: 0x0401E26F RID: 123503
		[Token(Token = "0x401E26F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__InvokedStartBattle;

		// Token: 0x0401E270 RID: 123504
		[Token(Token = "0x401E270")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DC3 RID: 15811
		[Token(Token = "0x2003DC3")]
		private struct CharSelectContext
		{
			// Token: 0x0401E271 RID: 123505
			[Token(Token = "0x401E271")]
			[FieldOffset(Offset = "0x0")]
			public int editIndex;

			// Token: 0x0401E272 RID: 123506
			[Token(Token = "0x401E272")]
			[FieldOffset(Offset = "0x4")]
			public bool isSingleMode;
		}

		// Token: 0x02003DC4 RID: 15812
		[Token(Token = "0x2003DC4")]
		private class CharSelectPlugin : UICharacterSelectState.Plugin<RuneSquadHomeState>
		{
			// Token: 0x17003AA7 RID: 15015
			// (get) Token: 0x0601898A RID: 100746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AA7")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x601898A")]
				[Address(RVA = "0x111C3A0", Offset = "0x111AFA0", VA = "0x18111C3A0", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x17003AA8 RID: 15016
			// (get) Token: 0x0601898B RID: 100747 RVA: 0x0009AE48 File Offset: 0x00099048
			[Token(Token = "0x17003AA8")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x601898B")]
				[Address(RVA = "0x111C470", Offset = "0x111B070", VA = "0x18111C470", Slot = "29")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003AA9 RID: 15017
			// (get) Token: 0x0601898C RID: 100748 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AA9")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x601898C")]
				[Address(RVA = "0x111C230", Offset = "0x111AE30", VA = "0x18111C230", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601898D RID: 100749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601898D")]
			[Address(RVA = "0x111B900", Offset = "0x111A500", VA = "0x18111B900", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x0601898E RID: 100750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601898E")]
			[Address(RVA = "0x111BA50", Offset = "0x111A650", VA = "0x18111BA50", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x0601898F RID: 100751 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601898F")]
			[Address(RVA = "0x111BB50", Offset = "0x111A750", VA = "0x18111BB50", Slot = "27")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x06018990 RID: 100752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018990")]
			[Address(RVA = "0x111BBD0", Offset = "0x111A7D0", VA = "0x18111BBD0", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x06018991 RID: 100753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018991")]
			[Address(RVA = "0x111BD70", Offset = "0x111A970", VA = "0x18111BD70", Slot = "30")]
			public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
			{
			}

			// Token: 0x06018992 RID: 100754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018992")]
			[Address(RVA = "0x111B7C0", Offset = "0x111A3C0", VA = "0x18111B7C0", Slot = "31")]
			public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
			{
			}

			// Token: 0x06018993 RID: 100755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018993")]
			[Address(RVA = "0x111BFB0", Offset = "0x111ABB0", VA = "0x18111BFB0", Slot = "34")]
			public override string OverrideUpdateSelectedSkill(int instId, string prevSkill, Func<int, string, string> selfUpdateSelectSkill)
			{
				return null;
			}

			// Token: 0x06018994 RID: 100756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018994")]
			[Address(RVA = "0x111BE10", Offset = "0x111AA10", VA = "0x18111BE10", Slot = "35")]
			public override string OverrideUpdateSelectedBranch(int instId, string prevBranch, Func<int, string, string> selfUpdateSelectBranch)
			{
				return null;
			}

			// Token: 0x06018995 RID: 100757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018995")]
			[Address(RVA = "0x111B4E0", Offset = "0x111A0E0", VA = "0x18111B4E0", Slot = "37")]
			public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
			{
			}

			// Token: 0x06018996 RID: 100758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018996")]
			[Address(RVA = "0x111C150", Offset = "0x111AD50", VA = "0x18111C150")]
			public CharSelectPlugin()
			{
			}

			// Token: 0x0401E273 RID: 123507
			[Token(Token = "0x401E273")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_overrideNoCharText;

			// Token: 0x0401E274 RID: 123508
			[Token(Token = "0x401E274")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

			// Token: 0x0401E275 RID: 123509
			[Token(Token = "0x401E275")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x0401E276 RID: 123510
			[Token(Token = "0x401E276")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x0401E277 RID: 123511
			[Token(Token = "0x401E277")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x0401E278 RID: 123512
			[Token(Token = "0x401E278")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

			// Token: 0x0401E279 RID: 123513
			[Token(Token = "0x401E279")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x0401E27A RID: 123514
			[Token(Token = "0x401E27A")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OverrideSkillSelect;

			// Token: 0x0401E27B RID: 123515
			[Token(Token = "0x401E27B")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OverrideBranchSelect;

			// Token: 0x0401E27C RID: 123516
			[Token(Token = "0x401E27C")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedSkill;

			// Token: 0x0401E27D RID: 123517
			[Token(Token = "0x401E27D")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedBranch;

			// Token: 0x0401E27E RID: 123518
			[Token(Token = "0x401E27E")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

			// Token: 0x0401E27F RID: 123519
			[Token(Token = "0x401E27F")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003DC5 RID: 15813
		[Token(Token = "0x2003DC5")]
		private class SquadAssistPlugin : SquadFriendAssistState.Plugin<RuneSquadHomeState>
		{
			// Token: 0x06018997 RID: 100759 RVA: 0x0009AE60 File Offset: 0x00099060
			[Token(Token = "0x6018997")]
			[Address(RVA = "0x1122100", Offset = "0x1120D00", VA = "0x181122100", Slot = "9")]
			public override bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig)
			{
				return default(bool);
			}

			// Token: 0x06018998 RID: 100760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018998")]
			[Address(RVA = "0x11225B0", Offset = "0x11211B0", VA = "0x1811225B0")]
			public SquadAssistPlugin()
			{
			}
		}

		// Token: 0x02003DC6 RID: 15814
		[Token(Token = "0x2003DC6")]
		private class StartServiceConfig : StartBattleServiceConfig<RuneStartBattleRequest, RuneStartBattleResponse>
		{
			// Token: 0x06018999 RID: 100761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018999")]
			[Address(RVA = "0x1133BB0", Offset = "0x11327B0", VA = "0x181133BB0")]
			public StartServiceConfig(BattleStartController.Param param)
			{
			}

			// Token: 0x17003AAA RID: 15018
			// (get) Token: 0x0601899A RID: 100762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AAA")]
			protected override string serviceCode
			{
				[Token(Token = "0x601899A")]
				[Address(RVA = "0x1133D10", Offset = "0x1132910", VA = "0x181133D10", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601899B RID: 100763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601899B")]
			[Address(RVA = "0x1133940", Offset = "0x1132540", VA = "0x181133940", Slot = "5")]
			protected override RuneStartBattleRequest ParseRequest()
			{
				return null;
			}

			// Token: 0x0401E280 RID: 123520
			[Token(Token = "0x401E280")]
			[FieldOffset(Offset = "0x10")]
			private BattleStartController.Param m_param;

			// Token: 0x0401E281 RID: 123521
			[Token(Token = "0x401E281")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E282 RID: 123522
			[Token(Token = "0x401E282")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x0401E283 RID: 123523
			[Token(Token = "0x401E283")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ParseRequest;
		}
	}
}
