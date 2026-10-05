using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B9E RID: 7070
	[Token(Token = "0x2001B9E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BuildingUnlockWorkshopFormulaTrigger
	{
		// Token: 0x0600B081 RID: 45185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B081")]
		[Address(RVA = "0x32AAE00", Offset = "0x32A9A00", VA = "0x1832AAE00")]
		public static void HandleMessage(List<BuildingUnlockWorkshopFormulaPushMsg> msgList)
		{
		}

		// Token: 0x0400AAEF RID: 43759
		[Token(Token = "0x400AAEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02001B9F RID: 7071
		[Token(Token = "0x2001B9F")]
		private class BuildingUnlockWorkshopFormulaMessage : UINotificationTasks.DefaultMainUITask.ICall
		{
			// Token: 0x0600B082 RID: 45186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B082")]
			[Address(RVA = "0x32AACB0", Offset = "0x32A98B0", VA = "0x1832AACB0", Slot = "4")]
			public void Call()
			{
			}

			// Token: 0x0600B083 RID: 45187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B083")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuildingUnlockWorkshopFormulaMessage()
			{
			}

			// Token: 0x0400AAF0 RID: 43760
			[Token(Token = "0x400AAF0")]
			[FieldOffset(Offset = "0x10")]
			public List<BuildingUnlockWorkshopFormulaPushMsg> msgList;
		}
	}
}
