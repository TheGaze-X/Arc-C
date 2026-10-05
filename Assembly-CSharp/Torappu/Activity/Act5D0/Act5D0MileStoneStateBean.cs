using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071FA RID: 29178
	[Token(Token = "0x20071FA")]
	public class Act5D0MileStoneStateBean : MileStoneStateBean
	{
		// Token: 0x0602961F RID: 169503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602961F")]
		[Address(RVA = "0x24C1F30", Offset = "0x24C0B30", VA = "0x1824C1F30", Slot = "4")]
		protected override List<MileStoneInfo> GetMileStoneList()
		{
			return null;
		}

		// Token: 0x06029620 RID: 169504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029620")]
		[Address(RVA = "0x24C1FC0", Offset = "0x24C0BC0", VA = "0x1824C1FC0", Slot = "5")]
		protected override MileStonePlayerInfo GetMileStonePlayerInfo()
		{
			return null;
		}

		// Token: 0x06029621 RID: 169505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029621")]
		[Address(RVA = "0x24C2060", Offset = "0x24C0C60", VA = "0x1824C2060", Slot = "6")]
		protected override string GetMileStoneToken()
		{
			return null;
		}

		// Token: 0x06029622 RID: 169506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029622")]
		[Address(RVA = "0x24C20F0", Offset = "0x24C0CF0", VA = "0x1824C20F0", Slot = "7")]
		protected override string GetSpReward()
		{
			return null;
		}

		// Token: 0x06029623 RID: 169507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029623")]
		[Address(RVA = "0x24C2180", Offset = "0x24C0D80", VA = "0x1824C2180", Slot = "8")]
		protected override void OnInitInfo()
		{
		}

		// Token: 0x06029624 RID: 169508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029624")]
		[Address(RVA = "0x24C22C0", Offset = "0x24C0EC0", VA = "0x1824C22C0")]
		public Act5D0MileStoneStateBean()
		{
		}

		// Token: 0x0403B1BE RID: 242110
		[Token(Token = "0x403B1BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMileStoneList;

		// Token: 0x0403B1BF RID: 242111
		[Token(Token = "0x403B1BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMileStonePlayerInfo;

		// Token: 0x0403B1C0 RID: 242112
		[Token(Token = "0x403B1C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMileStoneToken;

		// Token: 0x0403B1C1 RID: 242113
		[Token(Token = "0x403B1C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSpReward;

		// Token: 0x0403B1C2 RID: 242114
		[Token(Token = "0x403B1C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInitInfo;

		// Token: 0x0403B1C3 RID: 242115
		[Token(Token = "0x403B1C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
