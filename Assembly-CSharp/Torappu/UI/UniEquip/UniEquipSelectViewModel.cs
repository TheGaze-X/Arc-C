using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C3F RID: 15423
	[Token(Token = "0x2003C3F")]
	public class UniEquipSelectViewModel : IHotfixable, IComparable<UniEquipSelectViewModel>
	{
		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x060181D8 RID: 98776 RVA: 0x00099660 File Offset: 0x00097860
		// (set) Token: 0x060181D9 RID: 98777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700399B")]
		public UniEquipSelectViewModel.EquipAvgSortType avgSortType
		{
			[Token(Token = "0x60181D8")]
			[Address(RVA = "0x109BF80", Offset = "0x109AB80", VA = "0x18109BF80")]
			[CompilerGenerated]
			get
			{
				return UniEquipSelectViewModel.EquipAvgSortType.NONE;
			}
			[Token(Token = "0x60181D9")]
			[Address(RVA = "0x109BFE0", Offset = "0x109ABE0", VA = "0x18109BFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060181DA RID: 98778 RVA: 0x00099678 File Offset: 0x00097878
		[Token(Token = "0x60181DA")]
		[Address(RVA = "0x109B150", Offset = "0x1099D50", VA = "0x18109B150", Slot = "4")]
		public int CompareTo(UniEquipSelectViewModel other)
		{
			return 0;
		}

		// Token: 0x060181DB RID: 98779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181DB")]
		[Address(RVA = "0x109B200", Offset = "0x1099E00", VA = "0x18109B200")]
		public void InitPlayerData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x060181DC RID: 98780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181DC")]
		[Address(RVA = "0x109B8D0", Offset = "0x109A4D0", VA = "0x18109B8D0")]
		public void TryRefreshSelectStateIfHasInitSelectId(PlayerCharacter playerChar, string initSelectId)
		{
		}

		// Token: 0x060181DD RID: 98781 RVA: 0x00099690 File Offset: 0x00097890
		[Token(Token = "0x60181DD")]
		[Address(RVA = "0x109BE40", Offset = "0x109AA40", VA = "0x18109BE40")]
		private UniEquipSelectViewModel.EquipAvgSortType _GetEquipAvgSortType()
		{
			return UniEquipSelectViewModel.EquipAvgSortType.NONE;
		}

		// Token: 0x060181DE RID: 98782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181DE")]
		[Address(RVA = "0x109B980", Offset = "0x109A580", VA = "0x18109B980")]
		private void _CheckEquipAddOrOverrideTalent()
		{
		}

		// Token: 0x060181DF RID: 98783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181DF")]
		[Address(RVA = "0x109BCB0", Offset = "0x109A8B0", VA = "0x18109BCB0")]
		private void _CheckSubProfession(PlayerCharacter playerChar, CharacterData charData, UniEquipData uniEquipData)
		{
		}

		// Token: 0x060181E0 RID: 98784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181E0")]
		[Address(RVA = "0x109BED0", Offset = "0x109AAD0", VA = "0x18109BED0")]
		public UniEquipSelectViewModel()
		{
		}

		// Token: 0x0401D4A5 RID: 119973
		[Token(Token = "0x401D4A5")]
		[FieldOffset(Offset = "0x10")]
		public string uniEquipId;

		// Token: 0x0401D4A6 RID: 119974
		[Token(Token = "0x401D4A6")]
		[FieldOffset(Offset = "0x18")]
		public UniEquipData data;

		// Token: 0x0401D4A7 RID: 119975
		[Token(Token = "0x401D4A7")]
		[FieldOffset(Offset = "0x20")]
		public CharacterData cachedCharData;

		// Token: 0x0401D4A8 RID: 119976
		[Token(Token = "0x401D4A8")]
		[FieldOffset(Offset = "0x28")]
		public string subProfessionId;

		// Token: 0x0401D4A9 RID: 119977
		[Token(Token = "0x401D4A9")]
		[FieldOffset(Offset = "0x30")]
		public bool isSelect;

		// Token: 0x0401D4AA RID: 119978
		[Token(Token = "0x401D4AA")]
		[FieldOffset(Offset = "0x31")]
		public bool isFocus;

		// Token: 0x0401D4AB RID: 119979
		[Token(Token = "0x401D4AB")]
		[FieldOffset(Offset = "0x32")]
		public bool isUnlock;

		// Token: 0x0401D4AC RID: 119980
		[Token(Token = "0x401D4AC")]
		[FieldOffset(Offset = "0x38")]
		public List<bool> uniEquipMissionList;

		// Token: 0x0401D4AD RID: 119981
		[Token(Token = "0x401D4AD")]
		[FieldOffset(Offset = "0x40")]
		public PlayerCharacter cachePlayerChar;

		// Token: 0x0401D4AE RID: 119982
		[Token(Token = "0x401D4AE")]
		[FieldOffset(Offset = "0x48")]
		public int equipLevel;

		// Token: 0x0401D4AF RID: 119983
		[Token(Token = "0x401D4AF")]
		[FieldOffset(Offset = "0x4C")]
		public bool isUnlockAvailable;

		// Token: 0x0401D4B0 RID: 119984
		[Token(Token = "0x401D4B0")]
		[FieldOffset(Offset = "0x4D")]
		public bool isLevelUpValid;

		// Token: 0x0401D4B1 RID: 119985
		[Token(Token = "0x401D4B1")]
		[FieldOffset(Offset = "0x4E")]
		public bool isAddOrOverrideTalent;

		// Token: 0x0401D4B2 RID: 119986
		[Token(Token = "0x401D4B2")]
		[FieldOffset(Offset = "0x4F")]
		public bool isSubProfessionChanged;

		// Token: 0x0401D4B3 RID: 119987
		[Token(Token = "0x401D4B3")]
		[FieldOffset(Offset = "0x50")]
		public bool isAttrbuteChanged;

		// Token: 0x0401D4B4 RID: 119988
		[Token(Token = "0x401D4B4")]
		[FieldOffset(Offset = "0x51")]
		public bool isLevelUpEnough;

		// Token: 0x0401D4B6 RID: 119990
		[Token(Token = "0x401D4B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgSortType;

		// Token: 0x0401D4B7 RID: 119991
		[Token(Token = "0x401D4B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_avgSortType;

		// Token: 0x0401D4B8 RID: 119992
		[Token(Token = "0x401D4B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0401D4B9 RID: 119993
		[Token(Token = "0x401D4B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitPlayerData;

		// Token: 0x0401D4BA RID: 119994
		[Token(Token = "0x401D4BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryRefreshSelectStateIfHasInitSelectId;

		// Token: 0x0401D4BB RID: 119995
		[Token(Token = "0x401D4BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetEquipAvgSortType;

		// Token: 0x0401D4BC RID: 119996
		[Token(Token = "0x401D4BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckEquipAddOrOverrideTalent;

		// Token: 0x0401D4BD RID: 119997
		[Token(Token = "0x401D4BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckSubProfession;

		// Token: 0x0401D4BE RID: 119998
		[Token(Token = "0x401D4BE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C40 RID: 15424
		[Token(Token = "0x2003C40")]
		public enum EquipAvgSortType
		{
			// Token: 0x0401D4C0 RID: 120000
			[Token(Token = "0x401D4C0")]
			NONE,
			// Token: 0x0401D4C1 RID: 120001
			[Token(Token = "0x401D4C1")]
			INITIAL,
			// Token: 0x0401D4C2 RID: 120002
			[Token(Token = "0x401D4C2")]
			LEVEL_MAX,
			// Token: 0x0401D4C3 RID: 120003
			[Token(Token = "0x401D4C3")]
			LEVELUP_VALID,
			// Token: 0x0401D4C4 RID: 120004
			[Token(Token = "0x401D4C4")]
			LOCKED
		}
	}
}
