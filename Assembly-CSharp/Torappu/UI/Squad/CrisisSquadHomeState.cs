using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DBD RID: 15805
	[Token(Token = "0x2003DBD")]
	public class CrisisSquadHomeState : State, IRuneSquadController, ISquadCharSelectContext
	{
		// Token: 0x0601892B RID: 100651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601892B")]
		[Address(RVA = "0x1102820", Offset = "0x1101420", VA = "0x181102820", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601892C RID: 100652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601892C")]
		[Address(RVA = "0x1102B30", Offset = "0x1101730", VA = "0x181102B30", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601892D RID: 100653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601892D")]
		[Address(RVA = "0x11026E0", Offset = "0x11012E0", VA = "0x1811026E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601892E RID: 100654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601892E")]
		[Address(RVA = "0x1102D90", Offset = "0x1101990", VA = "0x181102D90", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601892F RID: 100655 RVA: 0x0009ACF8 File Offset: 0x00098EF8
		[Token(Token = "0x601892F")]
		[Address(RVA = "0x1103620", Offset = "0x1102220", VA = "0x181103620", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06018930 RID: 100656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018930")]
		[Address(RVA = "0x1102BC0", Offset = "0x11017C0", VA = "0x181102BC0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06018931 RID: 100657 RVA: 0x0009AD10 File Offset: 0x00098F10
		[Token(Token = "0x6018931")]
		[Address(RVA = "0x1102580", Offset = "0x1101180", VA = "0x181102580")]
		public static SquadFriendListItem.LockedStyle GenLockedStyle4CharInvalid()
		{
			return default(SquadFriendListItem.LockedStyle);
		}

		// Token: 0x06018932 RID: 100658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018932")]
		[Address(RVA = "0x11039D0", Offset = "0x11025D0", VA = "0x1811039D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018933 RID: 100659 RVA: 0x0009AD28 File Offset: 0x00098F28
		[Token(Token = "0x6018933")]
		[Address(RVA = "0x1101E50", Offset = "0x1100A50", VA = "0x181101E50")]
		public bool CheckIfCharInstSelectable(int instId)
		{
			return default(bool);
		}

		// Token: 0x06018934 RID: 100660 RVA: 0x0009AD40 File Offset: 0x00098F40
		[Token(Token = "0x6018934")]
		[Address(RVA = "0x1101FC0", Offset = "0x1100BC0", VA = "0x181101FC0", Slot = "23")]
		public bool CheckIfCharSelectable(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x06018935 RID: 100661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018935")]
		[Address(RVA = "0x11027C0", Offset = "0x11013C0", VA = "0x1811027C0", Slot = "24")]
		public List<int> GetTempListForExclusiveInstIds()
		{
			return null;
		}

		// Token: 0x06018936 RID: 100662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018936")]
		[Address(RVA = "0x1102740", Offset = "0x1101340", VA = "0x181102740", Slot = "25")]
		public SquadGroupViewModel GetSquadGroupViewModel()
		{
			return null;
		}

		// Token: 0x06018937 RID: 100663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018937")]
		[Address(RVA = "0x1104550", Offset = "0x1103150", VA = "0x181104550")]
		private void _OnSingleFormationClicked(int index)
		{
		}

		// Token: 0x06018938 RID: 100664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018938")]
		[Address(RVA = "0x11045F0", Offset = "0x11031F0", VA = "0x1811045F0")]
		private void _OnTopMenuRoutedToOtherPage(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x06018939 RID: 100665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018939")]
		[Address(RVA = "0x1102300", Offset = "0x1100F00", VA = "0x181102300")]
		public void EventOnMultiFormationClicked()
		{
		}

		// Token: 0x0601893A RID: 100666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601893A")]
		[Address(RVA = "0x1102240", Offset = "0x1100E40", VA = "0x181102240")]
		public void EventOnClearAssistClicked()
		{
		}

		// Token: 0x0601893B RID: 100667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601893B")]
		[Address(RVA = "0x1102070", Offset = "0x1100C70", VA = "0x181102070")]
		public void EventOnAssistClicked()
		{
		}

		// Token: 0x0601893C RID: 100668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601893C")]
		[Address(RVA = "0x11023A0", Offset = "0x1100FA0", VA = "0x1811023A0")]
		public void EventOnStartBattleClicked()
		{
		}

		// Token: 0x0601893D RID: 100669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601893D")]
		[Address(RVA = "0x11038B0", Offset = "0x11024B0", VA = "0x1811038B0")]
		private void _GoToCharSelectState()
		{
		}

		// Token: 0x0601893E RID: 100670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601893E")]
		[Address(RVA = "0x1103940", Offset = "0x1102540", VA = "0x181103940")]
		private void _GoToFriendAssistState()
		{
		}

		// Token: 0x0601893F RID: 100671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601893F")]
		[Address(RVA = "0x11042F0", Offset = "0x1102EF0", VA = "0x1811042F0")]
		private void _OnCharSelectFinished(IStateBean stateBean)
		{
		}

		// Token: 0x06018940 RID: 100672 RVA: 0x0009AD58 File Offset: 0x00098F58
		[Token(Token = "0x6018940")]
		[Address(RVA = "0x1104790", Offset = "0x1103390", VA = "0x181104790")]
		private CharSelectStateBean.Input _ParseSquadSelectParam()
		{
			return default(CharSelectStateBean.Input);
		}

		// Token: 0x06018941 RID: 100673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018941")]
		[Address(RVA = "0x1104DB0", Offset = "0x11039B0", VA = "0x181104DB0")]
		private void _SaveSquadFormationIfNeeded(Action nextStep)
		{
		}

		// Token: 0x06018942 RID: 100674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018942")]
		[Address(RVA = "0x11037E0", Offset = "0x11023E0", VA = "0x1811037E0")]
		private SquadItemStruct[] _GetCurSquadMembers()
		{
			return null;
		}

		// Token: 0x06018943 RID: 100675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018943")]
		[Address(RVA = "0x1103690", Offset = "0x1102290", VA = "0x181103690")]
		private void _DoStartBattle()
		{
		}

		// Token: 0x06018944 RID: 100676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018944")]
		[Address(RVA = "0x1103AB0", Offset = "0x11026B0", VA = "0x181103AB0")]
		private void _InvokedStartBattle()
		{
		}

		// Token: 0x06018945 RID: 100677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018945")]
		[Address(RVA = "0x1104E50", Offset = "0x1103A50", VA = "0x181104E50")]
		public CrisisSquadHomeState()
		{
		}

		// Token: 0x0601894D RID: 100685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601894D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601894E RID: 100686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601894E")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601894F RID: 100687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601894F")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018950 RID: 100688 RVA: 0x0009AD70 File Offset: 0x00098F70
		[Token(Token = "0x6018950")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06018951 RID: 100689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018951")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0401E217 RID: 123415
		[Token(Token = "0x401E217")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PrefabInstHolder _topMenuContainer;

		// Token: 0x0401E218 RID: 123416
		[Token(Token = "0x401E218")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SquadAssistCardView _assistCard;

		// Token: 0x0401E219 RID: 123417
		[Token(Token = "0x401E219")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RuneSquadGroupController _squadGroupController;

		// Token: 0x0401E21A RID: 123418
		[Token(Token = "0x401E21A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SquadCharSelectMaskPlugin _charSelectMask;

		// Token: 0x0401E21B RID: 123419
		[Token(Token = "0x401E21B")]
		[FieldOffset(Offset = "0x70")]
		private CrisisSquadStateBean m_stateBean;

		// Token: 0x0401E21C RID: 123420
		[Token(Token = "0x401E21C")]
		[FieldOffset(Offset = "0x78")]
		private CrisisSquadHomeState.CharSelectContext m_charSelectContext;

		// Token: 0x0401E21D RID: 123421
		[Token(Token = "0x401E21D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401E21E RID: 123422
		[Token(Token = "0x401E21E")]
		[FieldOffset(Offset = "0x88")]
		private SquadHomeState.DefaultCharSelectInput m_charSelectInputParam;

		// Token: 0x0401E21F RID: 123423
		[Token(Token = "0x401E21F")]
		[FieldOffset(Offset = "0xD0")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0401E220 RID: 123424
		[Token(Token = "0x401E220")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E221 RID: 123425
		[Token(Token = "0x401E221")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401E222 RID: 123426
		[Token(Token = "0x401E222")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E223 RID: 123427
		[Token(Token = "0x401E223")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401E224 RID: 123428
		[Token(Token = "0x401E224")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0401E225 RID: 123429
		[Token(Token = "0x401E225")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0401E226 RID: 123430
		[Token(Token = "0x401E226")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenLockedStyle4CharInvalid;

		// Token: 0x0401E227 RID: 123431
		[Token(Token = "0x401E227")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E228 RID: 123432
		[Token(Token = "0x401E228")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfCharInstSelectable;

		// Token: 0x0401E229 RID: 123433
		[Token(Token = "0x401E229")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfCharSelectable;

		// Token: 0x0401E22A RID: 123434
		[Token(Token = "0x401E22A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTempListForExclusiveInstIds;

		// Token: 0x0401E22B RID: 123435
		[Token(Token = "0x401E22B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSquadGroupViewModel;

		// Token: 0x0401E22C RID: 123436
		[Token(Token = "0x401E22C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSingleFormationClicked;

		// Token: 0x0401E22D RID: 123437
		[Token(Token = "0x401E22D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnTopMenuRoutedToOtherPage;

		// Token: 0x0401E22E RID: 123438
		[Token(Token = "0x401E22E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormationClicked;

		// Token: 0x0401E22F RID: 123439
		[Token(Token = "0x401E22F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnClearAssistClicked;

		// Token: 0x0401E230 RID: 123440
		[Token(Token = "0x401E230")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnAssistClicked;

		// Token: 0x0401E231 RID: 123441
		[Token(Token = "0x401E231")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnStartBattleClicked;

		// Token: 0x0401E232 RID: 123442
		[Token(Token = "0x401E232")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GoToCharSelectState;

		// Token: 0x0401E233 RID: 123443
		[Token(Token = "0x401E233")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GoToFriendAssistState;

		// Token: 0x0401E234 RID: 123444
		[Token(Token = "0x401E234")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnCharSelectFinished;

		// Token: 0x0401E235 RID: 123445
		[Token(Token = "0x401E235")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ParseSquadSelectParam;

		// Token: 0x0401E236 RID: 123446
		[Token(Token = "0x401E236")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SaveSquadFormationIfNeeded;

		// Token: 0x0401E237 RID: 123447
		[Token(Token = "0x401E237")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetCurSquadMembers;

		// Token: 0x0401E238 RID: 123448
		[Token(Token = "0x401E238")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__DoStartBattle;

		// Token: 0x0401E239 RID: 123449
		[Token(Token = "0x401E239")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__InvokedStartBattle;

		// Token: 0x0401E23A RID: 123450
		[Token(Token = "0x401E23A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DBE RID: 15806
		[Token(Token = "0x2003DBE")]
		private struct CharSelectContext
		{
			// Token: 0x0401E23B RID: 123451
			[Token(Token = "0x401E23B")]
			[FieldOffset(Offset = "0x0")]
			public int editIndex;

			// Token: 0x0401E23C RID: 123452
			[Token(Token = "0x401E23C")]
			[FieldOffset(Offset = "0x4")]
			public bool isSingleMode;
		}

		// Token: 0x02003DBF RID: 15807
		[Token(Token = "0x2003DBF")]
		private class CharSelectPlugin : UICharacterSelectState.Plugin<CrisisSquadHomeState>
		{
			// Token: 0x17003AA4 RID: 15012
			// (get) Token: 0x06018952 RID: 100690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AA4")]
			public override string overrideNoCharText
			{
				[Token(Token = "0x6018952")]
				[Address(RVA = "0x1101D80", Offset = "0x1100980", VA = "0x181101D80", Slot = "28")]
				get
				{
					return null;
				}
			}

			// Token: 0x17003AA5 RID: 15013
			// (get) Token: 0x06018953 RID: 100691 RVA: 0x0009AD88 File Offset: 0x00098F88
			[Token(Token = "0x17003AA5")]
			public override bool showCharInfoEntry
			{
				[Token(Token = "0x6018953")]
				[Address(RVA = "0x1101DF0", Offset = "0x11009F0", VA = "0x181101DF0", Slot = "29")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003AA6 RID: 15014
			// (get) Token: 0x06018954 RID: 100692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AA6")]
			public override CharSelectCardMaskPlugin cardMaskPrefab
			{
				[Token(Token = "0x6018954")]
				[Address(RVA = "0x1101D00", Offset = "0x1100900", VA = "0x181101D00", Slot = "32")]
				get
				{
					return null;
				}
			}

			// Token: 0x06018955 RID: 100693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018955")]
			[Address(RVA = "0x11016C0", Offset = "0x11002C0", VA = "0x1811016C0", Slot = "25")]
			public override void OverrideCharSelect(int instId, Action<int> selfCharSelect)
			{
			}

			// Token: 0x06018956 RID: 100694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018956")]
			[Address(RVA = "0x11018D0", Offset = "0x11004D0", VA = "0x1811018D0", Slot = "33")]
			public override void OverrideDismiss(Action selfDismiss)
			{
			}

			// Token: 0x06018957 RID: 100695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018957")]
			[Address(RVA = "0x1101950", Offset = "0x1100550", VA = "0x181101950", Slot = "27")]
			public override void OverrideSelectCanceled(Action selfCancel)
			{
			}

			// Token: 0x06018958 RID: 100696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018958")]
			[Address(RVA = "0x11019D0", Offset = "0x11005D0", VA = "0x1811019D0", Slot = "26")]
			public override void OverrideSelectConfirmed(Action selfConfirm)
			{
			}

			// Token: 0x06018959 RID: 100697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018959")]
			[Address(RVA = "0x1101A50", Offset = "0x1100650", VA = "0x181101A50", Slot = "30")]
			public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
			{
			}

			// Token: 0x0601895A RID: 100698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601895A")]
			[Address(RVA = "0x1101620", Offset = "0x1100220", VA = "0x181101620", Slot = "31")]
			public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
			{
			}

			// Token: 0x0601895B RID: 100699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601895B")]
			[Address(RVA = "0x1101BC0", Offset = "0x11007C0", VA = "0x181101BC0", Slot = "34")]
			public override string OverrideUpdateSelectedSkill(int instId, string prevSkill, Func<int, string, string> selfUpdateSelectSkill)
			{
				return null;
			}

			// Token: 0x0601895C RID: 100700 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601895C")]
			[Address(RVA = "0x1101AF0", Offset = "0x11006F0", VA = "0x181101AF0", Slot = "35")]
			public override string OverrideUpdateSelectedBranch(int instId, string prevBranch, Func<int, string, string> selfUpdateSelectBranch)
			{
				return null;
			}

			// Token: 0x0601895D RID: 100701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601895D")]
			[Address(RVA = "0x1101470", Offset = "0x1100070", VA = "0x181101470", Slot = "37")]
			public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
			{
			}

			// Token: 0x0601895E RID: 100702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601895E")]
			[Address(RVA = "0x1101C90", Offset = "0x1100890", VA = "0x181101C90")]
			public CharSelectPlugin()
			{
			}

			// Token: 0x0401E23D RID: 123453
			[Token(Token = "0x401E23D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_overrideNoCharText;

			// Token: 0x0401E23E RID: 123454
			[Token(Token = "0x401E23E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

			// Token: 0x0401E23F RID: 123455
			[Token(Token = "0x401E23F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_cardMaskPrefab;

			// Token: 0x0401E240 RID: 123456
			[Token(Token = "0x401E240")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideCharSelect;

			// Token: 0x0401E241 RID: 123457
			[Token(Token = "0x401E241")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OverrideDismiss;

			// Token: 0x0401E242 RID: 123458
			[Token(Token = "0x401E242")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

			// Token: 0x0401E243 RID: 123459
			[Token(Token = "0x401E243")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OverrideSelectConfirmed;

			// Token: 0x0401E244 RID: 123460
			[Token(Token = "0x401E244")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OverrideSkillSelect;

			// Token: 0x0401E245 RID: 123461
			[Token(Token = "0x401E245")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OverrideBranchSelect;

			// Token: 0x0401E246 RID: 123462
			[Token(Token = "0x401E246")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedSkill;

			// Token: 0x0401E247 RID: 123463
			[Token(Token = "0x401E247")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OverrideUpdateSelectedBranch;

			// Token: 0x0401E248 RID: 123464
			[Token(Token = "0x401E248")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

			// Token: 0x0401E249 RID: 123465
			[Token(Token = "0x401E249")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003DC0 RID: 15808
		[Token(Token = "0x2003DC0")]
		private class SquadAssistPlugin : SquadFriendAssistState.Plugin<CrisisSquadHomeState>
		{
			// Token: 0x0601895F RID: 100703 RVA: 0x0009ADA0 File Offset: 0x00098FA0
			[Token(Token = "0x601895F")]
			[Address(RVA = "0x1108700", Offset = "0x1107300", VA = "0x181108700", Slot = "9")]
			public override bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig)
			{
				return default(bool);
			}

			// Token: 0x06018960 RID: 100704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018960")]
			[Address(RVA = "0x1108990", Offset = "0x1107590", VA = "0x181108990")]
			public SquadAssistPlugin()
			{
			}
		}
	}
}
