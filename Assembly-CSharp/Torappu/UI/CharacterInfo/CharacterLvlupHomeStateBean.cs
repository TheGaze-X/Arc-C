using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F11 RID: 24337
	[Token(Token = "0x2005F11")]
	public class CharacterLvlupHomeStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x1700535F RID: 21343
		// (get) Token: 0x06023414 RID: 144404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700535F")]
		public string charId
		{
			[Token(Token = "0x6023414")]
			[Address(RVA = "0x1DC68D0", Offset = "0x1DC54D0", VA = "0x181DC68D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005360 RID: 21344
		// (get) Token: 0x06023415 RID: 144405 RVA: 0x000C0408 File Offset: 0x000BE608
		[Token(Token = "0x17005360")]
		public int originLevel
		{
			[Token(Token = "0x6023415")]
			[Address(RVA = "0x1DC6930", Offset = "0x1DC5530", VA = "0x181DC6930")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06023416 RID: 144406 RVA: 0x000C0420 File Offset: 0x000BE620
		[Token(Token = "0x6023416")]
		[Address(RVA = "0x1DC4E80", Offset = "0x1DC3A80", VA = "0x181DC4E80")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x06023417 RID: 144407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023417")]
		[Address(RVA = "0x1DC4F00", Offset = "0x1DC3B00", VA = "0x181DC4F00")]
		public List<CharacterData.UniqueEquipPair> GetEquipQueries()
		{
			return null;
		}

		// Token: 0x06023418 RID: 144408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023418")]
		[Address(RVA = "0x1DC5330", Offset = "0x1DC3F30", VA = "0x181DC5330")]
		public void LoadData(CharacterLvlupPage.Param param)
		{
		}

		// Token: 0x06023419 RID: 144409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023419")]
		[Address(RVA = "0x1DC61F0", Offset = "0x1DC4DF0", VA = "0x181DC61F0")]
		public void TryModifyItemCount(int itemIndex, int deltaCount)
		{
		}

		// Token: 0x0602341A RID: 144410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602341A")]
		[Address(RVA = "0x1DC64A0", Offset = "0x1DC50A0", VA = "0x181DC64A0")]
		private void _TryAddItem(CharacterLvlupViewModel viewModel, int itemIndex, int addCount)
		{
		}

		// Token: 0x0602341B RID: 144411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602341B")]
		[Address(RVA = "0x1DC65C0", Offset = "0x1DC51C0", VA = "0x181DC65C0")]
		private void _TryReduceItem(CharacterLvlupViewModel viewModel, int itemIndex, int reduceCount)
		{
		}

		// Token: 0x0602341C RID: 144412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602341C")]
		[Address(RVA = "0x1DC5E70", Offset = "0x1DC4A70", VA = "0x181DC5E70")]
		public void SwitchToScrollMode(bool isCounting)
		{
		}

		// Token: 0x0602341D RID: 144413 RVA: 0x000C0438 File Offset: 0x000BE638
		[Token(Token = "0x602341D")]
		[Address(RVA = "0x1DC4F60", Offset = "0x1DC3B60", VA = "0x181DC4F60")]
		public int GetSelectedLevelPageIndex()
		{
			return 0;
		}

		// Token: 0x0602341E RID: 144414 RVA: 0x000C0450 File Offset: 0x000BE650
		[Token(Token = "0x602341E")]
		[Address(RVA = "0x1DC4C80", Offset = "0x1DC3880", VA = "0x181DC4C80")]
		public bool CheckIfScrollMode()
		{
			return default(bool);
		}

		// Token: 0x0602341F RID: 144415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602341F")]
		[Address(RVA = "0x1DC5FA0", Offset = "0x1DC4BA0", VA = "0x181DC5FA0")]
		public void TryConfirmIndexOnScrollEnd(int index)
		{
		}

		// Token: 0x06023420 RID: 144416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023420")]
		[Address(RVA = "0x1DC6100", Offset = "0x1DC4D00", VA = "0x181DC6100")]
		public void TryEnterScrollModeAndSelectIndex(int scrollIndex)
		{
		}

		// Token: 0x06023421 RID: 144417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023421")]
		[Address(RVA = "0x1DC5C30", Offset = "0x1DC4830", VA = "0x181DC5C30")]
		public void SwitchToCardMode(bool hasConfirmChange)
		{
		}

		// Token: 0x06023422 RID: 144418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023422")]
		[Address(RVA = "0x1DC5B00", Offset = "0x1DC4700", VA = "0x181DC5B00")]
		public void MoveToMaxValidLevel()
		{
		}

		// Token: 0x06023423 RID: 144419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023423")]
		[Address(RVA = "0x1DC4D60", Offset = "0x1DC3960", VA = "0x181DC4D60")]
		public void ClearSelectedItems()
		{
		}

		// Token: 0x06023424 RID: 144420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023424")]
		[Address(RVA = "0x1DC4AF0", Offset = "0x1DC36F0", VA = "0x181DC4AF0")]
		public List<CharacterLvlupItemCardViewModel> AchieveAllSelectedItems()
		{
			return null;
		}

		// Token: 0x06023425 RID: 144421 RVA: 0x000C0468 File Offset: 0x000BE668
		[Token(Token = "0x6023425")]
		[Address(RVA = "0x1DC5030", Offset = "0x1DC3C30", VA = "0x181DC5030")]
		public bool IsRequiredGoldValid()
		{
			return default(bool);
		}

		// Token: 0x06023426 RID: 144422 RVA: 0x000C0480 File Offset: 0x000BE680
		[Token(Token = "0x6023426")]
		[Address(RVA = "0x1DC5150", Offset = "0x1DC3D50", VA = "0x181DC5150")]
		public bool IsSelectedExpValid()
		{
			return default(bool);
		}

		// Token: 0x06023427 RID: 144423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023427")]
		[Address(RVA = "0x1DC66D0", Offset = "0x1DC52D0", VA = "0x181DC66D0")]
		public CharacterLvlupHomeStateBean()
		{
		}

		// Token: 0x0403096B RID: 199019
		[Token(Token = "0x403096B")]
		[FieldOffset(Offset = "0x18")]
		public CharacterIllustViewProperty illustProperty;

		// Token: 0x0403096C RID: 199020
		[Token(Token = "0x403096C")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public CharacterLvlupViewProperty lvlupViewProperty;

		// Token: 0x0403096D RID: 199021
		[Token(Token = "0x403096D")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public int charInstId;

		// Token: 0x0403096E RID: 199022
		[Token(Token = "0x403096E")]
		[FieldOffset(Offset = "0x30")]
		private CharQuery m_charQuery;

		// Token: 0x0403096F RID: 199023
		[Token(Token = "0x403096F")]
		[FieldOffset(Offset = "0x48")]
		private List<CharacterData.UniqueEquipPair> m_equipPairs;

		// Token: 0x04030970 RID: 199024
		[Token(Token = "0x4030970")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedOriginLevel;

		// Token: 0x04030971 RID: 199025
		[Token(Token = "0x4030971")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x04030972 RID: 199026
		[Token(Token = "0x4030972")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_originLevel;

		// Token: 0x04030973 RID: 199027
		[Token(Token = "0x4030973")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCharQuery;

		// Token: 0x04030974 RID: 199028
		[Token(Token = "0x4030974")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEquipQueries;

		// Token: 0x04030975 RID: 199029
		[Token(Token = "0x4030975")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030976 RID: 199030
		[Token(Token = "0x4030976")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryModifyItemCount;

		// Token: 0x04030977 RID: 199031
		[Token(Token = "0x4030977")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryAddItem;

		// Token: 0x04030978 RID: 199032
		[Token(Token = "0x4030978")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryReduceItem;

		// Token: 0x04030979 RID: 199033
		[Token(Token = "0x4030979")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SwitchToScrollMode;

		// Token: 0x0403097A RID: 199034
		[Token(Token = "0x403097A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSelectedLevelPageIndex;

		// Token: 0x0403097B RID: 199035
		[Token(Token = "0x403097B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfScrollMode;

		// Token: 0x0403097C RID: 199036
		[Token(Token = "0x403097C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryConfirmIndexOnScrollEnd;

		// Token: 0x0403097D RID: 199037
		[Token(Token = "0x403097D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryEnterScrollModeAndSelectIndex;

		// Token: 0x0403097E RID: 199038
		[Token(Token = "0x403097E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SwitchToCardMode;

		// Token: 0x0403097F RID: 199039
		[Token(Token = "0x403097F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_MoveToMaxValidLevel;

		// Token: 0x04030980 RID: 199040
		[Token(Token = "0x4030980")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ClearSelectedItems;

		// Token: 0x04030981 RID: 199041
		[Token(Token = "0x4030981")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_AchieveAllSelectedItems;

		// Token: 0x04030982 RID: 199042
		[Token(Token = "0x4030982")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_IsRequiredGoldValid;

		// Token: 0x04030983 RID: 199043
		[Token(Token = "0x4030983")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_IsSelectedExpValid;

		// Token: 0x04030984 RID: 199044
		[Token(Token = "0x4030984")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
