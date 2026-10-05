using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004348 RID: 17224
	[Token(Token = "0x2004348")]
	public class SandboxV2LogisticsHomeViewModel : IHotfixable
	{
		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x0601A722 RID: 108322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EBF")]
		public string topicId
		{
			[Token(Token = "0x601A722")]
			[Address(RVA = "0x138BD90", Offset = "0x138A990", VA = "0x18138BD90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x0601A723 RID: 108323 RVA: 0x000A1CB8 File Offset: 0x0009FEB8
		[Token(Token = "0x17003EC0")]
		public bool isBuffValid
		{
			[Token(Token = "0x601A723")]
			[Address(RVA = "0x138BBD0", Offset = "0x138A7D0", VA = "0x18138BBD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x0601A724 RID: 108324 RVA: 0x000A1CD0 File Offset: 0x0009FED0
		[Token(Token = "0x17003EC1")]
		public bool isUpdateSquadValid
		{
			[Token(Token = "0x601A724")]
			[Address(RVA = "0x138BCD0", Offset = "0x138A8D0", VA = "0x18138BCD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x0601A725 RID: 108325 RVA: 0x000A1CE8 File Offset: 0x0009FEE8
		[Token(Token = "0x17003EC2")]
		public int selectCharIndex
		{
			[Token(Token = "0x601A725")]
			[Address(RVA = "0x138BD30", Offset = "0x138A930", VA = "0x18138BD30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x0601A726 RID: 108326 RVA: 0x000A1D00 File Offset: 0x0009FF00
		[Token(Token = "0x17003EC3")]
		public bool isNoSelectChar
		{
			[Token(Token = "0x601A726")]
			[Address(RVA = "0x138BC30", Offset = "0x138A830", VA = "0x18138BC30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A727 RID: 108327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A727")]
		[Address(RVA = "0x138A530", Offset = "0x1389130", VA = "0x18138A530")]
		public void InitData(string topicId, SandboxV2LogisticsVisitMode visitMode)
		{
		}

		// Token: 0x0601A728 RID: 108328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A728")]
		[Address(RVA = "0x138A5E0", Offset = "0x13891E0", VA = "0x18138A5E0")]
		public void LoadData()
		{
		}

		// Token: 0x0601A729 RID: 108329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A729")]
		[Address(RVA = "0x138A4A0", Offset = "0x13890A0", VA = "0x18138A4A0")]
		public SandboxV2LogisticsCharViewModel GetSelectCharViewModel()
		{
			return null;
		}

		// Token: 0x0601A72A RID: 108330 RVA: 0x000A1D18 File Offset: 0x0009FF18
		[Token(Token = "0x601A72A")]
		[Address(RVA = "0x138AAA0", Offset = "0x13896A0", VA = "0x18138AAA0")]
		public bool TryToSwitchBuffInfo(int squadIndex)
		{
			return default(bool);
		}

		// Token: 0x0601A72B RID: 108331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A72B")]
		[Address(RVA = "0x138AA40", Offset = "0x1389640", VA = "0x18138AA40")]
		public void SwitchBuffInfoToTotal()
		{
		}

		// Token: 0x0601A72C RID: 108332 RVA: 0x000A1D30 File Offset: 0x0009FF30
		[Token(Token = "0x601A72C")]
		[Address(RVA = "0x1389F70", Offset = "0x1388B70", VA = "0x181389F70")]
		public bool CheckIfDecreaseBuffWhenRemoveChar()
		{
			return default(bool);
		}

		// Token: 0x0601A72D RID: 108333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A72D")]
		[Address(RVA = "0x138A100", Offset = "0x1388D00", VA = "0x18138A100")]
		public ListDict<int, SandboxV2CharSquad> GeneSelectCharDictForCharSelect()
		{
			return null;
		}

		// Token: 0x0601A72E RID: 108334 RVA: 0x000A1D48 File Offset: 0x0009FF48
		[Token(Token = "0x601A72E")]
		[Address(RVA = "0x138A2A0", Offset = "0x1388EA0", VA = "0x18138A2A0")]
		public int GetCharSelectIndexByIndex(int selectIndex)
		{
			return 0;
		}

		// Token: 0x0601A72F RID: 108335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A72F")]
		[Address(RVA = "0x138B320", Offset = "0x1389F20", VA = "0x18138B320")]
		private void _GeneCharViewModelList(SandboxV2Data gameData, PlayerSandboxV2 playerSandboxV2)
		{
		}

		// Token: 0x0601A730 RID: 108336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A730")]
		[Address(RVA = "0x138AEB0", Offset = "0x1389AB0", VA = "0x18138AEB0")]
		private void _GeneBuffViewModelList(SandboxV2Data gameData, PlayerSandboxV2 playerSandboxV2)
		{
		}

		// Token: 0x0601A731 RID: 108337 RVA: 0x000A1D60 File Offset: 0x0009FF60
		[Token(Token = "0x601A731")]
		[Address(RVA = "0x138B9C0", Offset = "0x138A5C0", VA = "0x18138B9C0")]
		private SandboxV2LogisticsBuffInvalidStatus _GetBuffInvalidStatus(PlayerSandboxV2 playerSandboxV2)
		{
			return SandboxV2LogisticsBuffInvalidStatus.NONE;
		}

		// Token: 0x0601A732 RID: 108338 RVA: 0x000A1D78 File Offset: 0x0009FF78
		[Token(Token = "0x601A732")]
		[Address(RVA = "0x138AB60", Offset = "0x1389760", VA = "0x18138AB60")]
		private int _CompareCharsWithCharSelectRule(SandboxV2LogisticsCharViewModel obj1, SandboxV2LogisticsCharViewModel obj2)
		{
			return 0;
		}

		// Token: 0x0601A733 RID: 108339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A733")]
		[Address(RVA = "0x138BAC0", Offset = "0x138A6C0", VA = "0x18138BAC0")]
		public SandboxV2LogisticsHomeViewModel()
		{
		}

		// Token: 0x040219F8 RID: 137720
		[Token(Token = "0x40219F8")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, SandboxV2LogisticsBuffViewModel> buffListDict;

		// Token: 0x040219F9 RID: 137721
		[Token(Token = "0x40219F9")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2LogisticsCharViewModel> charList;

		// Token: 0x040219FA RID: 137722
		[Token(Token = "0x40219FA")]
		[FieldOffset(Offset = "0x20")]
		public int drinkCntPerPeriod;

		// Token: 0x040219FB RID: 137723
		[Token(Token = "0x40219FB")]
		[FieldOffset(Offset = "0x24")]
		public int basementLevel;

		// Token: 0x040219FC RID: 137724
		[Token(Token = "0x40219FC")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2LogisticsBuffInvalidStatus buffInvalidStatus;

		// Token: 0x040219FD RID: 137725
		[Token(Token = "0x40219FD")]
		[FieldOffset(Offset = "0x2C")]
		public int drinkTotalCapacity;

		// Token: 0x040219FE RID: 137726
		[Token(Token = "0x40219FE")]
		[FieldOffset(Offset = "0x30")]
		public int squadMaxCount;

		// Token: 0x040219FF RID: 137727
		[Token(Token = "0x40219FF")]
		[FieldOffset(Offset = "0x34")]
		public int squadMaxValidCount;

		// Token: 0x04021A00 RID: 137728
		[Token(Token = "0x4021A00")]
		[FieldOffset(Offset = "0x38")]
		public string removeCharDialogDesc;

		// Token: 0x04021A01 RID: 137729
		[Token(Token = "0x4021A01")]
		[FieldOffset(Offset = "0x40")]
		public string removeCharDialogWarning;

		// Token: 0x04021A02 RID: 137730
		[Token(Token = "0x4021A02")]
		[FieldOffset(Offset = "0x48")]
		public bool isInRift;

		// Token: 0x04021A03 RID: 137731
		[Token(Token = "0x4021A03")]
		[FieldOffset(Offset = "0x50")]
		private string m_topicId;

		// Token: 0x04021A04 RID: 137732
		[Token(Token = "0x4021A04")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2LogisticsVisitMode m_visitMode;

		// Token: 0x04021A05 RID: 137733
		[Token(Token = "0x4021A05")]
		[FieldOffset(Offset = "0x5C")]
		private int m_selectedCharIndex;

		// Token: 0x04021A06 RID: 137734
		[Token(Token = "0x4021A06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04021A07 RID: 137735
		[Token(Token = "0x4021A07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isBuffValid;

		// Token: 0x04021A08 RID: 137736
		[Token(Token = "0x4021A08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isUpdateSquadValid;

		// Token: 0x04021A09 RID: 137737
		[Token(Token = "0x4021A09")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectCharIndex;

		// Token: 0x04021A0A RID: 137738
		[Token(Token = "0x4021A0A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isNoSelectChar;

		// Token: 0x04021A0B RID: 137739
		[Token(Token = "0x4021A0B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04021A0C RID: 137740
		[Token(Token = "0x4021A0C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021A0D RID: 137741
		[Token(Token = "0x4021A0D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSelectCharViewModel;

		// Token: 0x04021A0E RID: 137742
		[Token(Token = "0x4021A0E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryToSwitchBuffInfo;

		// Token: 0x04021A0F RID: 137743
		[Token(Token = "0x4021A0F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SwitchBuffInfoToTotal;

		// Token: 0x04021A10 RID: 137744
		[Token(Token = "0x4021A10")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfDecreaseBuffWhenRemoveChar;

		// Token: 0x04021A11 RID: 137745
		[Token(Token = "0x4021A11")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GeneSelectCharDictForCharSelect;

		// Token: 0x04021A12 RID: 137746
		[Token(Token = "0x4021A12")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCharSelectIndexByIndex;

		// Token: 0x04021A13 RID: 137747
		[Token(Token = "0x4021A13")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GeneCharViewModelList;

		// Token: 0x04021A14 RID: 137748
		[Token(Token = "0x4021A14")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GeneBuffViewModelList;

		// Token: 0x04021A15 RID: 137749
		[Token(Token = "0x4021A15")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetBuffInvalidStatus;

		// Token: 0x04021A16 RID: 137750
		[Token(Token = "0x4021A16")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CompareCharsWithCharSelectRule;

		// Token: 0x04021A17 RID: 137751
		[Token(Token = "0x4021A17")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
