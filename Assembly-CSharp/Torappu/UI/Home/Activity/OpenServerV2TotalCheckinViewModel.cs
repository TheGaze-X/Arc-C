using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C9B RID: 19611
	[Token(Token = "0x2004C9B")]
	public class OpenServerV2TotalCheckinViewModel : IHotfixable
	{
		// Token: 0x0601D639 RID: 120377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D639")]
		[Address(RVA = "0x16F1C50", Offset = "0x16F0850", VA = "0x1816F1C50")]
		public void LoadData(OpenServerData openServerData, OpenServerScheduleItem groupData)
		{
		}

		// Token: 0x0601D63A RID: 120378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D63A")]
		[Address(RVA = "0x16F1EC0", Offset = "0x16F0AC0", VA = "0x1816F1EC0")]
		public void UpdateStatusByPlayerData()
		{
		}

		// Token: 0x0601D63B RID: 120379 RVA: 0x000AB5D0 File Offset: 0x000A97D0
		[Token(Token = "0x601D63B")]
		[Address(RVA = "0x16F1B10", Offset = "0x16F0710", VA = "0x1816F1B10")]
		public bool CheckAvailable()
		{
			return default(bool);
		}

		// Token: 0x0601D63C RID: 120380 RVA: 0x000AB5E8 File Offset: 0x000A97E8
		[Token(Token = "0x601D63C")]
		[Address(RVA = "0x16F1B70", Offset = "0x16F0770", VA = "0x1816F1B70")]
		public int GetFirstNotGotItemIndex()
		{
			return 0;
		}

		// Token: 0x0601D63D RID: 120381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D63D")]
		[Address(RVA = "0x16F20C0", Offset = "0x16F0CC0", VA = "0x1816F20C0")]
		public OpenServerV2TotalCheckinViewModel()
		{
		}

		// Token: 0x04026B13 RID: 158483
		[Token(Token = "0x4026B13")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x04026B14 RID: 158484
		[Token(Token = "0x4026B14")]
		[FieldOffset(Offset = "0x18")]
		public List<OpenServerV2TotalCheckinItemData> items;

		// Token: 0x04026B15 RID: 158485
		[Token(Token = "0x4026B15")]
		[FieldOffset(Offset = "0x20")]
		public List<string> displayChars;

		// Token: 0x04026B16 RID: 158486
		[Token(Token = "0x4026B16")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isAvailable;

		// Token: 0x04026B17 RID: 158487
		[Token(Token = "0x4026B17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026B18 RID: 158488
		[Token(Token = "0x4026B18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateStatusByPlayerData;

		// Token: 0x04026B19 RID: 158489
		[Token(Token = "0x4026B19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckAvailable;

		// Token: 0x04026B1A RID: 158490
		[Token(Token = "0x4026B1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetFirstNotGotItemIndex;

		// Token: 0x04026B1B RID: 158491
		[Token(Token = "0x4026B1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
