using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007538 RID: 30008
	[Token(Token = "0x2007538")]
	public class RhineBattlePerformanceItemListModel : IHotfixable
	{
		// Token: 0x0602A463 RID: 173155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A463")]
		[Address(RVA = "0x25EDCD0", Offset = "0x25EC8D0", VA = "0x1825EDCD0")]
		public void InputItem(RhineBattlePerformanceItemModel item)
		{
		}

		// Token: 0x0602A464 RID: 173156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A464")]
		[Address(RVA = "0x25EDEB0", Offset = "0x25ECAB0", VA = "0x1825EDEB0")]
		public void UpdateDisplayInfo()
		{
		}

		// Token: 0x0602A465 RID: 173157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A465")]
		[Address(RVA = "0x25EDC70", Offset = "0x25EC870", VA = "0x1825EDC70")]
		public string GetLowLevelItemIconId()
		{
			return null;
		}

		// Token: 0x0602A466 RID: 173158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A466")]
		[Address(RVA = "0x25EDC10", Offset = "0x25EC810", VA = "0x1825EDC10")]
		public string GetHighLevelItemIconId()
		{
			return null;
		}

		// Token: 0x0602A467 RID: 173159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A467")]
		[Address(RVA = "0x25EE040", Offset = "0x25ECC40", VA = "0x1825EE040")]
		private string _GetLevelItemIconByIndex(int index)
		{
			return null;
		}

		// Token: 0x0602A468 RID: 173160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A468")]
		[Address(RVA = "0x25EE0F0", Offset = "0x25ECCF0", VA = "0x1825EE0F0")]
		private void _SortBySortId()
		{
		}

		// Token: 0x0602A469 RID: 173161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A469")]
		[Address(RVA = "0x25EE250", Offset = "0x25ECE50", VA = "0x1825EE250")]
		public RhineBattlePerformanceItemListModel()
		{
		}

		// Token: 0x0403CC8A RID: 248970
		[Token(Token = "0x403CC8A")]
		public const string LOCK_ITEM_ICON_ID = "act25side_battle_performance_lock";

		// Token: 0x0403CC8B RID: 248971
		[Token(Token = "0x403CC8B")]
		[FieldOffset(Offset = "0x10")]
		public string displayName;

		// Token: 0x0403CC8C RID: 248972
		[Token(Token = "0x403CC8C")]
		[FieldOffset(Offset = "0x18")]
		public string displayDesc;

		// Token: 0x0403CC8D RID: 248973
		[Token(Token = "0x403CC8D")]
		[FieldOffset(Offset = "0x20")]
		public bool lowLevelUnlock;

		// Token: 0x0403CC8E RID: 248974
		[Token(Token = "0x403CC8E")]
		[FieldOffset(Offset = "0x21")]
		public bool lowLevelNew;

		// Token: 0x0403CC8F RID: 248975
		[Token(Token = "0x403CC8F")]
		[FieldOffset(Offset = "0x22")]
		public bool highLevelUnlock;

		// Token: 0x0403CC90 RID: 248976
		[Token(Token = "0x403CC90")]
		[FieldOffset(Offset = "0x23")]
		public bool highLevelNew;

		// Token: 0x0403CC91 RID: 248977
		[Token(Token = "0x403CC91")]
		[FieldOffset(Offset = "0x28")]
		private List<RhineBattlePerformanceItemModel> m_itemList;

		// Token: 0x0403CC92 RID: 248978
		[Token(Token = "0x403CC92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InputItem;

		// Token: 0x0403CC93 RID: 248979
		[Token(Token = "0x403CC93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateDisplayInfo;

		// Token: 0x0403CC94 RID: 248980
		[Token(Token = "0x403CC94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetLowLevelItemIconId;

		// Token: 0x0403CC95 RID: 248981
		[Token(Token = "0x403CC95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetHighLevelItemIconId;

		// Token: 0x0403CC96 RID: 248982
		[Token(Token = "0x403CC96")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetLevelItemIconByIndex;

		// Token: 0x0403CC97 RID: 248983
		[Token(Token = "0x403CC97")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SortBySortId;

		// Token: 0x0403CC98 RID: 248984
		[Token(Token = "0x403CC98")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
