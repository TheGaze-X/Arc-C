using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200778C RID: 30604
	[Token(Token = "0x200778C")]
	public class Act1VHalfIdleDepotAssistViewModel : IHotfixable
	{
		// Token: 0x0602AFAB RID: 176043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFAB")]
		[Address(RVA = "0x26C60D0", Offset = "0x26C4CD0", VA = "0x1826C60D0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602AFAC RID: 176044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFAC")]
		[Address(RVA = "0x26C6150", Offset = "0x26C4D50", VA = "0x1826C6150")]
		public void UpdateData()
		{
		}

		// Token: 0x0602AFAD RID: 176045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AFAD")]
		[Address(RVA = "0x26C5FD0", Offset = "0x26C4BD0", VA = "0x1826C5FD0")]
		public Act1VHalfIdleCharViewModel GetAssistCharBySlotId(int slotId)
		{
			return null;
		}

		// Token: 0x0602AFAE RID: 176046 RVA: 0x000DA8C8 File Offset: 0x000D8AC8
		[Token(Token = "0x602AFAE")]
		[Address(RVA = "0x26C6060", Offset = "0x26C4C60", VA = "0x1826C6060")]
		public bool GetAssistSlotAvail(int slotId)
		{
			return default(bool);
		}

		// Token: 0x0602AFAF RID: 176047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFAF")]
		[Address(RVA = "0x26C6230", Offset = "0x26C4E30", VA = "0x1826C6230")]
		private void _UpdateAssistCharStatus(Dictionary<string, PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData> chars, List<SharedCharData> assists)
		{
		}

		// Token: 0x0602AFB0 RID: 176048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFB0")]
		[Address(RVA = "0x26C6460", Offset = "0x26C5060", VA = "0x1826C6460")]
		public Act1VHalfIdleDepotAssistViewModel()
		{
		}

		// Token: 0x0403E054 RID: 254036
		[Token(Token = "0x403E054")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403E055 RID: 254037
		[Token(Token = "0x403E055")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Act1VHalfIdleCharViewModel> m_assistCharDict;

		// Token: 0x0403E056 RID: 254038
		[Token(Token = "0x403E056")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, string> m_cachedCharIdInstIdDict;

		// Token: 0x0403E057 RID: 254039
		[Token(Token = "0x403E057")]
		[FieldOffset(Offset = "0x28")]
		private int m_curAvailSlotNum;

		// Token: 0x0403E058 RID: 254040
		[Token(Token = "0x403E058")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E059 RID: 254041
		[Token(Token = "0x403E059")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403E05A RID: 254042
		[Token(Token = "0x403E05A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAssistCharBySlotId;

		// Token: 0x0403E05B RID: 254043
		[Token(Token = "0x403E05B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetAssistSlotAvail;

		// Token: 0x0403E05C RID: 254044
		[Token(Token = "0x403E05C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateAssistCharStatus;

		// Token: 0x0403E05D RID: 254045
		[Token(Token = "0x403E05D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
