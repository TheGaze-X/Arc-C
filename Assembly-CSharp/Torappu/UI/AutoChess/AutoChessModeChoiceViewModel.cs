using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062D4 RID: 25300
	[Token(Token = "0x20062D4")]
	public class AutoChessModeChoiceViewModel : IHotfixable
	{
		// Token: 0x170055D9 RID: 21977
		// (get) Token: 0x06024762 RID: 149346 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024763 RID: 149347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055D9")]
		public ActAutoChessData.ActAutoChessModeData trainingModeData
		{
			[Token(Token = "0x6024762")]
			[Address(RVA = "0x1F47010", Offset = "0x1F45C10", VA = "0x181F47010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024763")]
			[Address(RVA = "0x1F477D0", Offset = "0x1F463D0", VA = "0x181F477D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055DA RID: 21978
		// (get) Token: 0x06024764 RID: 149348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170055DA")]
		public List<AutoChessModeChoiceItemViewModel> itemViewModels
		{
			[Token(Token = "0x6024764")]
			[Address(RVA = "0x1F46D10", Offset = "0x1F45910", VA = "0x181F46D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170055DB RID: 21979
		// (get) Token: 0x06024765 RID: 149349 RVA: 0x000C4458 File Offset: 0x000C2658
		// (set) Token: 0x06024766 RID: 149350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055DB")]
		public AutoChessModeChoiceConfirmBtnType confirmBtnType
		{
			[Token(Token = "0x6024765")]
			[Address(RVA = "0x1F469E0", Offset = "0x1F455E0", VA = "0x181F469E0")]
			[CompilerGenerated]
			get
			{
				return AutoChessModeChoiceConfirmBtnType.NONE;
			}
			[Token(Token = "0x6024766")]
			[Address(RVA = "0x1F47170", Offset = "0x1F45D70", VA = "0x181F47170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055DC RID: 21980
		// (get) Token: 0x06024767 RID: 149351 RVA: 0x000C4470 File Offset: 0x000C2670
		// (set) Token: 0x06024768 RID: 149352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055DC")]
		public bool hasMatchRangePart
		{
			[Token(Token = "0x6024767")]
			[Address(RVA = "0x1F46B60", Offset = "0x1F45760", VA = "0x181F46B60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024768")]
			[Address(RVA = "0x1F47340", Offset = "0x1F45F40", VA = "0x181F47340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055DD RID: 21981
		// (get) Token: 0x06024769 RID: 149353 RVA: 0x000C4488 File Offset: 0x000C2688
		// (set) Token: 0x0602476A RID: 149354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055DD")]
		public bool isMatchRangePrecise
		{
			[Token(Token = "0x6024769")]
			[Address(RVA = "0x1F46C50", Offset = "0x1F45850", VA = "0x181F46C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602476A")]
			[Address(RVA = "0x1F473B0", Offset = "0x1F45FB0", VA = "0x181F473B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055DE RID: 21982
		// (get) Token: 0x0602476B RID: 149355 RVA: 0x000C44A0 File Offset: 0x000C26A0
		// (set) Token: 0x0602476C RID: 149356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055DE")]
		public bool matchFlag
		{
			[Token(Token = "0x602476B")]
			[Address(RVA = "0x1F46D70", Offset = "0x1F45970", VA = "0x181F46D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602476C")]
			[Address(RVA = "0x1F47490", Offset = "0x1F46090", VA = "0x181F47490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055DF RID: 21983
		// (get) Token: 0x0602476D RID: 149357 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602476E RID: 149358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055DF")]
		public string actId
		{
			[Token(Token = "0x602476D")]
			[Address(RVA = "0x1F46920", Offset = "0x1F45520", VA = "0x181F46920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602476E")]
			[Address(RVA = "0x1F47070", Offset = "0x1F45C70", VA = "0x181F47070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E0 RID: 21984
		// (get) Token: 0x0602476F RID: 149359 RVA: 0x000C44B8 File Offset: 0x000C26B8
		// (set) Token: 0x06024770 RID: 149360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E0")]
		public ActAutoChessModeType modeType
		{
			[Token(Token = "0x602476F")]
			[Address(RVA = "0x1F46DD0", Offset = "0x1F459D0", VA = "0x181F46DD0")]
			[CompilerGenerated]
			get
			{
				return ActAutoChessModeType.LOCAL;
			}
			[Token(Token = "0x6024770")]
			[Address(RVA = "0x1F47500", Offset = "0x1F46100", VA = "0x181F47500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E1 RID: 21985
		// (get) Token: 0x06024771 RID: 149361 RVA: 0x000C44D0 File Offset: 0x000C26D0
		// (set) Token: 0x06024772 RID: 149362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E1")]
		public ActAutoChessMultiModeSubType multiModeSubType
		{
			[Token(Token = "0x6024771")]
			[Address(RVA = "0x1F46E30", Offset = "0x1F45A30", VA = "0x181F46E30")]
			[CompilerGenerated]
			get
			{
				return ActAutoChessMultiModeSubType.NONE;
			}
			[Token(Token = "0x6024772")]
			[Address(RVA = "0x1F47570", Offset = "0x1F46170", VA = "0x181F47570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E2 RID: 21986
		// (get) Token: 0x06024773 RID: 149363 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024774 RID: 149364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E2")]
		public string selectedModeId
		{
			[Token(Token = "0x6024773")]
			[Address(RVA = "0x1F46EF0", Offset = "0x1F45AF0", VA = "0x181F46EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024774")]
			[Address(RVA = "0x1F47650", Offset = "0x1F46250", VA = "0x181F47650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E3 RID: 21987
		// (get) Token: 0x06024775 RID: 149365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024776 RID: 149366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E3")]
		public string continuousClickToastStr
		{
			[Token(Token = "0x6024775")]
			[Address(RVA = "0x1F46A40", Offset = "0x1F45640", VA = "0x181F46A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024776")]
			[Address(RVA = "0x1F471E0", Offset = "0x1F45DE0", VA = "0x181F471E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E4 RID: 21988
		// (get) Token: 0x06024777 RID: 149367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024778 RID: 149368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E4")]
		public string bannedToastStr
		{
			[Token(Token = "0x6024777")]
			[Address(RVA = "0x1F46980", Offset = "0x1F45580", VA = "0x181F46980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024778")]
			[Address(RVA = "0x1F470F0", Offset = "0x1F45CF0", VA = "0x181F470F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E5 RID: 21989
		// (get) Token: 0x06024779 RID: 149369 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602477A RID: 149370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E5")]
		public string serverOverloadToastStr
		{
			[Token(Token = "0x6024779")]
			[Address(RVA = "0x1F46F50", Offset = "0x1F45B50", VA = "0x181F46F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602477A")]
			[Address(RVA = "0x1F476D0", Offset = "0x1F462D0", VA = "0x181F476D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E6 RID: 21990
		// (get) Token: 0x0602477B RID: 149371 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602477C RID: 149372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E6")]
		public string singleModeEnterTeamFailToastStr
		{
			[Token(Token = "0x602477B")]
			[Address(RVA = "0x1F46FB0", Offset = "0x1F45BB0", VA = "0x181F46FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602477C")]
			[Address(RVA = "0x1F47750", Offset = "0x1F46350", VA = "0x181F47750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E7 RID: 21991
		// (get) Token: 0x0602477D RID: 149373 RVA: 0x000C44E8 File Offset: 0x000C26E8
		[Token(Token = "0x170055E7")]
		public bool isMatchBanned
		{
			[Token(Token = "0x602477D")]
			[Address(RVA = "0x1F46BC0", Offset = "0x1F457C0", VA = "0x181F46BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170055E8 RID: 21992
		// (get) Token: 0x0602477E RID: 149374 RVA: 0x000C4500 File Offset: 0x000C2700
		// (set) Token: 0x0602477F RID: 149375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E8")]
		public ActAutoChessModeDifficultyType selectedDifficultyType
		{
			[Token(Token = "0x602477E")]
			[Address(RVA = "0x1F46E90", Offset = "0x1F45A90", VA = "0x181F46E90")]
			[CompilerGenerated]
			get
			{
				return ActAutoChessModeDifficultyType.TRAINING;
			}
			[Token(Token = "0x602477F")]
			[Address(RVA = "0x1F475E0", Offset = "0x1F461E0", VA = "0x181F475E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055E9 RID: 21993
		// (get) Token: 0x06024780 RID: 149376 RVA: 0x000C4518 File Offset: 0x000C2718
		// (set) Token: 0x06024781 RID: 149377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055E9")]
		public bool hasLeftMaskBg
		{
			[Token(Token = "0x6024780")]
			[Address(RVA = "0x1F46B00", Offset = "0x1F45700", VA = "0x181F46B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024781")]
			[Address(RVA = "0x1F472D0", Offset = "0x1F45ED0", VA = "0x181F472D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170055EA RID: 21994
		// (get) Token: 0x06024782 RID: 149378 RVA: 0x000C4530 File Offset: 0x000C2730
		// (set) Token: 0x06024783 RID: 149379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055EA")]
		public bool isShow
		{
			[Token(Token = "0x6024782")]
			[Address(RVA = "0x1F46CB0", Offset = "0x1F458B0", VA = "0x181F46CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024783")]
			[Address(RVA = "0x1F47420", Offset = "0x1F46020", VA = "0x181F47420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170055EB RID: 21995
		// (get) Token: 0x06024784 RID: 149380 RVA: 0x000C4548 File Offset: 0x000C2748
		// (set) Token: 0x06024785 RID: 149381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170055EB")]
		public int enterSeqNum
		{
			[Token(Token = "0x6024784")]
			[Address(RVA = "0x1F46AA0", Offset = "0x1F456A0", VA = "0x181F46AA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024785")]
			[Address(RVA = "0x1F47260", Offset = "0x1F45E60", VA = "0x181F47260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024786 RID: 149382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024786")]
		[Address(RVA = "0x1F454B0", Offset = "0x1F440B0", VA = "0x181F454B0")]
		public void LoadData(string actId, ActAutoChessModeType modeType, ActAutoChessMultiModeSubType multiModeSubType, bool hasLeftMaskBg)
		{
		}

		// Token: 0x06024787 RID: 149383 RVA: 0x000C4560 File Offset: 0x000C2760
		[Token(Token = "0x6024787")]
		[Address(RVA = "0x1F46500", Offset = "0x1F45100", VA = "0x181F46500")]
		public bool TryUpdateMatchBanTime()
		{
			return default(bool);
		}

		// Token: 0x06024788 RID: 149384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024788")]
		[Address(RVA = "0x1F46270", Offset = "0x1F44E70", VA = "0x181F46270")]
		public void RefreshSelectModeId(string modeId)
		{
		}

		// Token: 0x06024789 RID: 149385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024789")]
		[Address(RVA = "0x1F46060", Offset = "0x1F44C60", VA = "0x181F46060")]
		public void RefreshModeUnlockInfo(string modeId)
		{
		}

		// Token: 0x0602478A RID: 149386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602478A")]
		[Address(RVA = "0x1F45FA0", Offset = "0x1F44BA0", VA = "0x181F45FA0")]
		public void RefreshMatchStyle(bool isPrecise)
		{
		}

		// Token: 0x0602478B RID: 149387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602478B")]
		[Address(RVA = "0x1F45EE0", Offset = "0x1F44AE0", VA = "0x181F45EE0")]
		public void RefreshMatchFlag(bool newMatchFlag)
		{
		}

		// Token: 0x0602478C RID: 149388 RVA: 0x000C4578 File Offset: 0x000C2778
		[Token(Token = "0x602478C")]
		[Address(RVA = "0x1F45E20", Offset = "0x1F44A20", VA = "0x181F45E20")]
		public bool NeedSaveSelectCacheDirectly()
		{
			return default(bool);
		}

		// Token: 0x0602478D RID: 149389 RVA: 0x000C4590 File Offset: 0x000C2790
		[Token(Token = "0x602478D")]
		[Address(RVA = "0x1F45380", Offset = "0x1F43F80", VA = "0x181F45380")]
		public bool IsValidModeIdForMatch()
		{
			return default(bool);
		}

		// Token: 0x0602478E RID: 149390 RVA: 0x000C45A8 File Offset: 0x000C27A8
		[Token(Token = "0x602478E")]
		[Address(RVA = "0x1F451E0", Offset = "0x1F43DE0", VA = "0x181F451E0")]
		public int GetSelectModeIndex()
		{
			return 0;
		}

		// Token: 0x0602478F RID: 149391 RVA: 0x000C45C0 File Offset: 0x000C27C0
		[Token(Token = "0x602478F")]
		[Address(RVA = "0x1F466A0", Offset = "0x1F452A0", VA = "0x181F466A0")]
		private AutoChessModeChoiceConfirmBtnType _GetConfirmBtnType()
		{
			return AutoChessModeChoiceConfirmBtnType.NONE;
		}

		// Token: 0x06024790 RID: 149392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024790")]
		[Address(RVA = "0x1F467A0", Offset = "0x1F453A0", VA = "0x181F467A0")]
		private void _UpdateBanTime()
		{
		}

		// Token: 0x06024791 RID: 149393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024791")]
		[Address(RVA = "0x1F46860", Offset = "0x1F45460", VA = "0x181F46860")]
		public AutoChessModeChoiceViewModel()
		{
		}

		// Token: 0x04032C84 RID: 208004
		[Token(Token = "0x4032C84")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_isTrainingModePassed;

		// Token: 0x04032C85 RID: 208005
		[Token(Token = "0x4032C85")]
		[FieldOffset(Offset = "0x70")]
		private string m_trainingModeId;

		// Token: 0x04032C86 RID: 208006
		[Token(Token = "0x4032C86")]
		[FieldOffset(Offset = "0x78")]
		private long m_banFinishTs;

		// Token: 0x04032C87 RID: 208007
		[Token(Token = "0x4032C87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trainingModeData;

		// Token: 0x04032C88 RID: 208008
		[Token(Token = "0x4032C88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_trainingModeData;

		// Token: 0x04032C89 RID: 208009
		[Token(Token = "0x4032C89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemViewModels;

		// Token: 0x04032C8A RID: 208010
		[Token(Token = "0x4032C8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_confirmBtnType;

		// Token: 0x04032C8B RID: 208011
		[Token(Token = "0x4032C8B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_confirmBtnType;

		// Token: 0x04032C8C RID: 208012
		[Token(Token = "0x4032C8C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_hasMatchRangePart;

		// Token: 0x04032C8D RID: 208013
		[Token(Token = "0x4032C8D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_hasMatchRangePart;

		// Token: 0x04032C8E RID: 208014
		[Token(Token = "0x4032C8E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isMatchRangePrecise;

		// Token: 0x04032C8F RID: 208015
		[Token(Token = "0x4032C8F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_isMatchRangePrecise;

		// Token: 0x04032C90 RID: 208016
		[Token(Token = "0x4032C90")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_matchFlag;

		// Token: 0x04032C91 RID: 208017
		[Token(Token = "0x4032C91")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_matchFlag;

		// Token: 0x04032C92 RID: 208018
		[Token(Token = "0x4032C92")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04032C93 RID: 208019
		[Token(Token = "0x4032C93")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04032C94 RID: 208020
		[Token(Token = "0x4032C94")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x04032C95 RID: 208021
		[Token(Token = "0x4032C95")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_modeType;

		// Token: 0x04032C96 RID: 208022
		[Token(Token = "0x4032C96")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_multiModeSubType;

		// Token: 0x04032C97 RID: 208023
		[Token(Token = "0x4032C97")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_multiModeSubType;

		// Token: 0x04032C98 RID: 208024
		[Token(Token = "0x4032C98")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_selectedModeId;

		// Token: 0x04032C99 RID: 208025
		[Token(Token = "0x4032C99")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_selectedModeId;

		// Token: 0x04032C9A RID: 208026
		[Token(Token = "0x4032C9A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_continuousClickToastStr;

		// Token: 0x04032C9B RID: 208027
		[Token(Token = "0x4032C9B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_continuousClickToastStr;

		// Token: 0x04032C9C RID: 208028
		[Token(Token = "0x4032C9C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_bannedToastStr;

		// Token: 0x04032C9D RID: 208029
		[Token(Token = "0x4032C9D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_bannedToastStr;

		// Token: 0x04032C9E RID: 208030
		[Token(Token = "0x4032C9E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_serverOverloadToastStr;

		// Token: 0x04032C9F RID: 208031
		[Token(Token = "0x4032C9F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_serverOverloadToastStr;

		// Token: 0x04032CA0 RID: 208032
		[Token(Token = "0x4032CA0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_singleModeEnterTeamFailToastStr;

		// Token: 0x04032CA1 RID: 208033
		[Token(Token = "0x4032CA1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_singleModeEnterTeamFailToastStr;

		// Token: 0x04032CA2 RID: 208034
		[Token(Token = "0x4032CA2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_isMatchBanned;

		// Token: 0x04032CA3 RID: 208035
		[Token(Token = "0x4032CA3")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_selectedDifficultyType;

		// Token: 0x04032CA4 RID: 208036
		[Token(Token = "0x4032CA4")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_selectedDifficultyType;

		// Token: 0x04032CA5 RID: 208037
		[Token(Token = "0x4032CA5")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_hasLeftMaskBg;

		// Token: 0x04032CA6 RID: 208038
		[Token(Token = "0x4032CA6")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_hasLeftMaskBg;

		// Token: 0x04032CA7 RID: 208039
		[Token(Token = "0x4032CA7")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04032CA8 RID: 208040
		[Token(Token = "0x4032CA8")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x04032CA9 RID: 208041
		[Token(Token = "0x4032CA9")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_enterSeqNum;

		// Token: 0x04032CAA RID: 208042
		[Token(Token = "0x4032CAA")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_enterSeqNum;

		// Token: 0x04032CAB RID: 208043
		[Token(Token = "0x4032CAB")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032CAC RID: 208044
		[Token(Token = "0x4032CAC")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_TryUpdateMatchBanTime;

		// Token: 0x04032CAD RID: 208045
		[Token(Token = "0x4032CAD")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_RefreshSelectModeId;

		// Token: 0x04032CAE RID: 208046
		[Token(Token = "0x4032CAE")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_RefreshModeUnlockInfo;

		// Token: 0x04032CAF RID: 208047
		[Token(Token = "0x4032CAF")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_RefreshMatchStyle;

		// Token: 0x04032CB0 RID: 208048
		[Token(Token = "0x4032CB0")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_RefreshMatchFlag;

		// Token: 0x04032CB1 RID: 208049
		[Token(Token = "0x4032CB1")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_NeedSaveSelectCacheDirectly;

		// Token: 0x04032CB2 RID: 208050
		[Token(Token = "0x4032CB2")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_IsValidModeIdForMatch;

		// Token: 0x04032CB3 RID: 208051
		[Token(Token = "0x4032CB3")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_GetSelectModeIndex;

		// Token: 0x04032CB4 RID: 208052
		[Token(Token = "0x4032CB4")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__GetConfirmBtnType;

		// Token: 0x04032CB5 RID: 208053
		[Token(Token = "0x4032CB5")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__UpdateBanTime;

		// Token: 0x04032CB6 RID: 208054
		[Token(Token = "0x4032CB6")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
