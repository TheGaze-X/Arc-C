using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C99 RID: 19609
	[Token(Token = "0x2004C99")]
	public class OpenServerV2MissionViewModel : IHotfixable
	{
		// Token: 0x0601D630 RID: 120368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D630")]
		[Address(RVA = "0x16F10B0", Offset = "0x16EFCB0", VA = "0x1816F10B0")]
		public void LoadData(OpenServerData openServerData, OpenServerScheduleItem groupData)
		{
		}

		// Token: 0x0601D631 RID: 120369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D631")]
		[Address(RVA = "0x16F1270", Offset = "0x16EFE70", VA = "0x1816F1270")]
		public void UpdateStatusByPlayerData()
		{
		}

		// Token: 0x0601D632 RID: 120370 RVA: 0x000AB570 File Offset: 0x000A9770
		[Token(Token = "0x601D632")]
		[Address(RVA = "0x16F1050", Offset = "0x16EFC50", VA = "0x1816F1050")]
		public bool CheckAvailable()
		{
			return default(bool);
		}

		// Token: 0x0601D633 RID: 120371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D633")]
		[Address(RVA = "0x16F1450", Offset = "0x16F0050", VA = "0x1816F1450")]
		public OpenServerV2MissionViewModel()
		{
		}

		// Token: 0x04026B06 RID: 158470
		[Token(Token = "0x4026B06")]
		[FieldOffset(Offset = "0x10")]
		public List<OpenServerV2MissionItemData> items;

		// Token: 0x04026B07 RID: 158471
		[Token(Token = "0x4026B07")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isAvailable;

		// Token: 0x04026B08 RID: 158472
		[Token(Token = "0x4026B08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026B09 RID: 158473
		[Token(Token = "0x4026B09")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateStatusByPlayerData;

		// Token: 0x04026B0A RID: 158474
		[Token(Token = "0x4026B0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckAvailable;

		// Token: 0x04026B0B RID: 158475
		[Token(Token = "0x4026B0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
