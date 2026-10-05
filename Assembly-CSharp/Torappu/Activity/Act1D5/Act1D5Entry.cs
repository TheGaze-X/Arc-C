using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1D5
{
	// Token: 0x020078F6 RID: 30966
	[Token(Token = "0x20078F6")]
	public class Act1D5Entry : ActivityCommonCheckinEntry, IHotfixable
	{
		// Token: 0x0602B6BB RID: 177851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6BB")]
		[Address(RVA = "0x2752B50", Offset = "0x2751750", VA = "0x182752B50", Slot = "4")]
		public override void OnEnter(string activityId)
		{
		}

		// Token: 0x0602B6BC RID: 177852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B6BC")]
		[Address(RVA = "0x2753E80", Offset = "0x2752A80", VA = "0x182753E80")]
		private IEnumerator _refreshVertial(DefaultCheckInData data)
		{
			return null;
		}

		// Token: 0x0602B6BD RID: 177853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6BD")]
		[Address(RVA = "0x2753A00", Offset = "0x2752600", VA = "0x182753A00")]
		private void _ApplyTimeInfo(long startTime, long endTime)
		{
		}

		// Token: 0x0602B6BE RID: 177854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6BE")]
		[Address(RVA = "0x27535B0", Offset = "0x27521B0", VA = "0x1827535B0", Slot = "9")]
		protected override void RefreshInfo()
		{
		}

		// Token: 0x0602B6BF RID: 177855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6BF")]
		[Address(RVA = "0x2753DC0", Offset = "0x27529C0", VA = "0x182753DC0")]
		public Act1D5Entry()
		{
		}

		// Token: 0x0602B6C0 RID: 177856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6C0")]
		[Address(RVA = "0x25BA740", Offset = "0x25B9340", VA = "0x1825BA740")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x0403ECAE RID: 257198
		[Token(Token = "0x403ECAE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<ActivityCommonCheckinItem> _checkinItemList;

		// Token: 0x0403ECAF RID: 257199
		[Token(Token = "0x403ECAF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403ECB0 RID: 257200
		[Token(Token = "0x403ECB0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _openTime;

		// Token: 0x0403ECB1 RID: 257201
		[Token(Token = "0x403ECB1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0403ECB2 RID: 257202
		[Token(Token = "0x403ECB2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _apItemTime;

		// Token: 0x0403ECB3 RID: 257203
		[Token(Token = "0x403ECB3")]
		[FieldOffset(Offset = "0x98")]
		private List<ActivityCommonCheckinItem> m_itemList;

		// Token: 0x0403ECB4 RID: 257204
		[Token(Token = "0x403ECB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403ECB5 RID: 257205
		[Token(Token = "0x403ECB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__refreshVertial;

		// Token: 0x0403ECB6 RID: 257206
		[Token(Token = "0x403ECB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyTimeInfo;

		// Token: 0x0403ECB7 RID: 257207
		[Token(Token = "0x403ECB7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x0403ECB8 RID: 257208
		[Token(Token = "0x403ECB8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
