using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C41 RID: 15425
	[Token(Token = "0x2003C41")]
	public class UniEquipSelectList : IHotfixable
	{
		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x060181E1 RID: 98785 RVA: 0x000996A8 File Offset: 0x000978A8
		[Token(Token = "0x1700399C")]
		public bool isUnlocked
		{
			[Token(Token = "0x60181E1")]
			[Address(RVA = "0x1099BB0", Offset = "0x10987B0", VA = "0x181099BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x060181E2 RID: 98786 RVA: 0x000996C0 File Offset: 0x000978C0
		[Token(Token = "0x1700399D")]
		public int focusIndex
		{
			[Token(Token = "0x60181E2")]
			[Address(RVA = "0x1099B40", Offset = "0x1098740", VA = "0x181099B40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x060181E3 RID: 98787 RVA: 0x000996D8 File Offset: 0x000978D8
		[Token(Token = "0x1700399E")]
		public bool needFocus
		{
			[Token(Token = "0x60181E3")]
			[Address(RVA = "0x1099C80", Offset = "0x1098880", VA = "0x181099C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060181E4 RID: 98788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181E4")]
		[Address(RVA = "0x10991A0", Offset = "0x1097DA0", VA = "0x1810991A0")]
		public void LoadData(UniEquipSelectList.LoadParam param)
		{
		}

		// Token: 0x060181E5 RID: 98789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181E5")]
		[Address(RVA = "0x10999F0", Offset = "0x10985F0", VA = "0x1810999F0")]
		public void SwitchEquip(string uniEquipId, bool needFocus = false)
		{
		}

		// Token: 0x060181E6 RID: 98790 RVA: 0x000996F0 File Offset: 0x000978F0
		[Token(Token = "0x60181E6")]
		[Address(RVA = "0x1099110", Offset = "0x1097D10", VA = "0x181099110")]
		public bool CheckNeedUnlockAvg(int index)
		{
			return default(bool);
		}

		// Token: 0x060181E7 RID: 98791 RVA: 0x00099708 File Offset: 0x00097908
		[Token(Token = "0x60181E7")]
		[Address(RVA = "0x1099080", Offset = "0x1097C80", VA = "0x181099080")]
		public bool CheckNeedLevelupAvg(int index)
		{
			return default(bool);
		}

		// Token: 0x060181E8 RID: 98792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181E8")]
		[Address(RVA = "0x1099AA0", Offset = "0x10986A0", VA = "0x181099AA0")]
		public UniEquipSelectList()
		{
		}

		// Token: 0x0401D4C5 RID: 120005
		[Token(Token = "0x401D4C5")]
		[FieldOffset(Offset = "0x10")]
		public CharQuery charQuery;

		// Token: 0x0401D4C6 RID: 120006
		[Token(Token = "0x401D4C6")]
		[FieldOffset(Offset = "0x28")]
		public CharacterData charData;

		// Token: 0x0401D4C7 RID: 120007
		[Token(Token = "0x401D4C7")]
		[FieldOffset(Offset = "0x30")]
		public PlayerCharacter playerCharacter;

		// Token: 0x0401D4C8 RID: 120008
		[Token(Token = "0x401D4C8")]
		[FieldOffset(Offset = "0x38")]
		public int instCharId;

		// Token: 0x0401D4C9 RID: 120009
		[Token(Token = "0x401D4C9")]
		[FieldOffset(Offset = "0x40")]
		public List<CharacterTalentViewModel> talentDescsDictionary;

		// Token: 0x0401D4CA RID: 120010
		[Token(Token = "0x401D4CA")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, UniEquipSelectViewModel> viewModelDict;

		// Token: 0x0401D4CB RID: 120011
		[Token(Token = "0x401D4CB")]
		[FieldOffset(Offset = "0x50")]
		public List<UniEquipSelectViewModel> selectViewModels;

		// Token: 0x0401D4CC RID: 120012
		[Token(Token = "0x401D4CC")]
		[FieldOffset(Offset = "0x58")]
		public string selectEquipId;

		// Token: 0x0401D4CD RID: 120013
		[Token(Token = "0x401D4CD")]
		[FieldOffset(Offset = "0x60")]
		public string uniEquipId;

		// Token: 0x0401D4CE RID: 120014
		[Token(Token = "0x401D4CE")]
		[FieldOffset(Offset = "0x68")]
		public AttributesCalculator.Input attributeInput;

		// Token: 0x0401D4CF RID: 120015
		[Token(Token = "0x401D4CF")]
		[FieldOffset(Offset = "0x80")]
		public AttributesData attributeData;

		// Token: 0x0401D4D0 RID: 120016
		[Token(Token = "0x401D4D0")]
		[FieldOffset(Offset = "0x88")]
		public AttributesCalculator.AttributeRawDelta attributeDelta;

		// Token: 0x0401D4D1 RID: 120017
		[Token(Token = "0x401D4D1")]
		[FieldOffset(Offset = "0x90")]
		public string traitDesc1;

		// Token: 0x0401D4D2 RID: 120018
		[Token(Token = "0x401D4D2")]
		[FieldOffset(Offset = "0x98")]
		public string traitDesc2;

		// Token: 0x0401D4D3 RID: 120019
		[Token(Token = "0x401D4D3")]
		[FieldOffset(Offset = "0xA0")]
		public string cacheFocus;

		// Token: 0x0401D4D4 RID: 120020
		[Token(Token = "0x401D4D4")]
		[FieldOffset(Offset = "0xA8")]
		private UniEquipSelectList.AVGConfig m_avgConfig;

		// Token: 0x0401D4D5 RID: 120021
		[Token(Token = "0x401D4D5")]
		[FieldOffset(Offset = "0xBC")]
		private int m_focusIndex;

		// Token: 0x0401D4D6 RID: 120022
		[Token(Token = "0x401D4D6")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_needFocus;

		// Token: 0x0401D4D7 RID: 120023
		[Token(Token = "0x401D4D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlocked;

		// Token: 0x0401D4D8 RID: 120024
		[Token(Token = "0x401D4D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_focusIndex;

		// Token: 0x0401D4D9 RID: 120025
		[Token(Token = "0x401D4D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_needFocus;

		// Token: 0x0401D4DA RID: 120026
		[Token(Token = "0x401D4DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D4DB RID: 120027
		[Token(Token = "0x401D4DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchEquip;

		// Token: 0x0401D4DC RID: 120028
		[Token(Token = "0x401D4DC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckNeedUnlockAvg;

		// Token: 0x0401D4DD RID: 120029
		[Token(Token = "0x401D4DD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckNeedLevelupAvg;

		// Token: 0x0401D4DE RID: 120030
		[Token(Token = "0x401D4DE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C42 RID: 15426
		[Token(Token = "0x2003C42")]
		public struct LoadParam
		{
			// Token: 0x0401D4DF RID: 120031
			[Token(Token = "0x401D4DF")]
			[FieldOffset(Offset = "0x0")]
			public int charInstId;

			// Token: 0x0401D4E0 RID: 120032
			[Token(Token = "0x401D4E0")]
			[FieldOffset(Offset = "0x8")]
			public CharacterData charData;

			// Token: 0x0401D4E1 RID: 120033
			[Token(Token = "0x401D4E1")]
			[FieldOffset(Offset = "0x10")]
			public PlayerCharacter playerChar;

			// Token: 0x0401D4E2 RID: 120034
			[Token(Token = "0x401D4E2")]
			[FieldOffset(Offset = "0x18")]
			public bool needFocus;

			// Token: 0x0401D4E3 RID: 120035
			[Token(Token = "0x401D4E3")]
			[FieldOffset(Offset = "0x19")]
			public bool isAvgRunning;

			// Token: 0x0401D4E4 RID: 120036
			[Token(Token = "0x401D4E4")]
			[FieldOffset(Offset = "0x20")]
			public string initSelectEquipId;
		}

		// Token: 0x02003C43 RID: 15427
		[Token(Token = "0x2003C43")]
		private struct AVGConfig : IHotfixable
		{
			// Token: 0x060181E9 RID: 98793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60181E9")]
			[Address(RVA = "0x108D500", Offset = "0x108C100", VA = "0x18108D500")]
			public void TryOverrideFocusStatusWhenAvg(List<UniEquipSelectViewModel> selectViewModels)
			{
			}

			// Token: 0x060181EA RID: 98794 RVA: 0x00099720 File Offset: 0x00097920
			[Token(Token = "0x60181EA")]
			[Address(RVA = "0x108D330", Offset = "0x108BF30", VA = "0x18108D330")]
			public static int CompareWhenAvg(UniEquipSelectViewModel a, UniEquipSelectViewModel b)
			{
				return 0;
			}

			// Token: 0x0401D4E5 RID: 120037
			[Token(Token = "0x401D4E5")]
			[FieldOffset(Offset = "0x0")]
			public bool isAvgRunning;

			// Token: 0x0401D4E6 RID: 120038
			[Token(Token = "0x401D4E6")]
			[FieldOffset(Offset = "0x4")]
			public int lastUnlockIndex;

			// Token: 0x0401D4E7 RID: 120039
			[Token(Token = "0x401D4E7")]
			[FieldOffset(Offset = "0x8")]
			public int firstLockIndex;

			// Token: 0x0401D4E8 RID: 120040
			[Token(Token = "0x401D4E8")]
			[FieldOffset(Offset = "0xC")]
			public int focusIndex;

			// Token: 0x0401D4E9 RID: 120041
			[Token(Token = "0x401D4E9")]
			[FieldOffset(Offset = "0x10")]
			public bool needFocus;

			// Token: 0x0401D4EA RID: 120042
			[Token(Token = "0x401D4EA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_TryOverrideFocusStatusWhenAvg;

			// Token: 0x0401D4EB RID: 120043
			[Token(Token = "0x401D4EB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CompareWhenAvg;
		}
	}
}
