using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BA1 RID: 15265
	[Token(Token = "0x2003BA1")]
	public class VoicelangCardGroupViewModel
	{
		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x06017E8D RID: 97933 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017E8C RID: 97932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003912")]
		public Dictionary<string, VoicelangCardViewModel> dataSource
		{
			[Token(Token = "0x6017E8D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017E8C")]
			[Address(RVA = "0x106C220", Offset = "0x106AE20", VA = "0x18106C220")]
			set
			{
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x06017E8E RID: 97934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003913")]
		public List<VoicelangCardViewModel> cardList
		{
			[Token(Token = "0x6017E8E")]
			[Address(RVA = "0x106C1F0", Offset = "0x106ADF0", VA = "0x18106C1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017E8F RID: 97935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E8F")]
		[Address(RVA = "0x106B600", Offset = "0x106A200", VA = "0x18106B600")]
		public void SetSingleSelect(string selectedWordkey)
		{
		}

		// Token: 0x06017E90 RID: 97936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E90")]
		[Address(RVA = "0x106B3E0", Offset = "0x1069FE0", VA = "0x18106B3E0")]
		public void SetBatchSelect()
		{
		}

		// Token: 0x06017E91 RID: 97937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E91")]
		[Address(RVA = "0x106A9A0", Offset = "0x10695A0", VA = "0x18106A9A0")]
		public void CancelSelect()
		{
		}

		// Token: 0x06017E92 RID: 97938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E92")]
		[Address(RVA = "0x106B020", Offset = "0x1069C20", VA = "0x18106B020")]
		public void RefreshCardsVoicelangType()
		{
		}

		// Token: 0x06017E93 RID: 97939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E93")]
		[Address(RVA = "0x106B2C0", Offset = "0x1069EC0", VA = "0x18106B2C0")]
		public void RefreshRedPoint()
		{
		}

		// Token: 0x06017E94 RID: 97940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E94")]
		[Address(RVA = "0x106AAA0", Offset = "0x10696A0", VA = "0x18106AAA0")]
		public List<VoicelangCardViewModel> GetNewVoiceCardListWithVoicelangGroupTypeFiltered()
		{
			return null;
		}

		// Token: 0x06017E95 RID: 97941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E95")]
		[Address(RVA = "0x106AEB0", Offset = "0x1069AB0", VA = "0x18106AEB0")]
		public List<VoicelangCardViewModel> GetSelectedList()
		{
			return null;
		}

		// Token: 0x06017E96 RID: 97942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E96")]
		[Address(RVA = "0x106B400", Offset = "0x106A000", VA = "0x18106B400")]
		public void SetCardTargetVoiceTypeToSwitch(VoiceLangType targetType)
		{
		}

		// Token: 0x06017E97 RID: 97943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E97")]
		[Address(RVA = "0x106B6D0", Offset = "0x106A2D0", VA = "0x18106B6D0")]
		public void SetVoicelangGroupType(bool isAll, VoiceLangGroupType groupType = VoiceLangGroupType.CN_MANDARIN)
		{
		}

		// Token: 0x06017E98 RID: 97944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E98")]
		[Address(RVA = "0x106B5C0", Offset = "0x106A1C0", VA = "0x18106B5C0")]
		public void SetPower(bool isAll, [Optional] string powerId)
		{
		}

		// Token: 0x06017E99 RID: 97945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E99")]
		[Address(RVA = "0x106BC60", Offset = "0x106A860", VA = "0x18106BC60")]
		private List<VoicelangCardViewModel> _AchieveSortedAndFilteredCards()
		{
			return null;
		}

		// Token: 0x06017E9A RID: 97946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E9A")]
		[Address(RVA = "0x106C0B0", Offset = "0x106ACB0", VA = "0x18106C0B0")]
		public VoicelangCardGroupViewModel()
		{
		}

		// Token: 0x0401CEB8 RID: 118456
		[Token(Token = "0x401CEB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, VoicelangCardViewModel> m_cardViewModels;

		// Token: 0x0401CEB9 RID: 118457
		[Token(Token = "0x401CEB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<VoicelangCardViewModel> m_cardListCache;

		// Token: 0x0401CEBA RID: 118458
		[Token(Token = "0x401CEBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CardGroupFilterType m_groupFilterType;

		// Token: 0x0401CEBB RID: 118459
		[Token(Token = "0x401CEBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CardPowerFilterType m_powerFilterType;

		// Token: 0x0401CEBC RID: 118460
		[Token(Token = "0x401CEBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_lastSelectedWordkey;

		// Token: 0x0401CEBD RID: 118461
		[Token(Token = "0x401CEBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VoicelangCardGroupViewModel.SelectState m_selectState;

		// Token: 0x0401CEBE RID: 118462
		[Token(Token = "0x401CEBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool skipFilterAndSort;

		// Token: 0x02003BA2 RID: 15266
		[Token(Token = "0x2003BA2")]
		private enum SelectState
		{
			// Token: 0x0401CEC0 RID: 118464
			[Token(Token = "0x401CEC0")]
			UnSelect,
			// Token: 0x0401CEC1 RID: 118465
			[Token(Token = "0x401CEC1")]
			Single,
			// Token: 0x0401CEC2 RID: 118466
			[Token(Token = "0x401CEC2")]
			Multi
		}
	}
}
