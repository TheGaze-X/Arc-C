using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077F2 RID: 30706
	[Token(Token = "0x20077F2")]
	public class GachaViewModel : UITabPager.TabPageViewModel
	{
		// Token: 0x0602B144 RID: 176452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B144")]
		[Address(RVA = "0x26EB030", Offset = "0x26E9C30", VA = "0x1826EB030", Slot = "4")]
		public override object GetDialogInput()
		{
			return null;
		}

		// Token: 0x0602B145 RID: 176453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B145")]
		[Address(RVA = "0x26EB0E0", Offset = "0x26E9CE0", VA = "0x1826EB0E0")]
		public GachaViewModel()
		{
		}

		// Token: 0x0602B146 RID: 176454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B146")]
		[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
		private object <>xLuaBaseProxy_GetDialogInput()
		{
			return null;
		}

		// Token: 0x0403E3E9 RID: 254953
		[Token(Token = "0x403E3E9")]
		[FieldOffset(Offset = "0x30")]
		public string actId;

		// Token: 0x0403E3EA RID: 254954
		[Token(Token = "0x403E3EA")]
		[FieldOffset(Offset = "0x38")]
		public string poolId;

		// Token: 0x0403E3EB RID: 254955
		[Token(Token = "0x403E3EB")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x0403E3EC RID: 254956
		[Token(Token = "0x403E3EC")]
		[FieldOffset(Offset = "0x44")]
		public Act1VHalfIdleGachaPoolType poolType;

		// Token: 0x0403E3ED RID: 254957
		[Token(Token = "0x403E3ED")]
		[FieldOffset(Offset = "0x48")]
		public int availableGachaTimes;

		// Token: 0x0403E3EE RID: 254958
		[Token(Token = "0x403E3EE")]
		[FieldOffset(Offset = "0x50")]
		public string poolName;

		// Token: 0x0403E3EF RID: 254959
		[Token(Token = "0x403E3EF")]
		[FieldOffset(Offset = "0x58")]
		public string gachaItemId;

		// Token: 0x0403E3F0 RID: 254960
		[Token(Token = "0x403E3F0")]
		[FieldOffset(Offset = "0x60")]
		public int gachaItemCount;

		// Token: 0x0403E3F1 RID: 254961
		[Token(Token = "0x403E3F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDialogInput;

		// Token: 0x0403E3F2 RID: 254962
		[Token(Token = "0x403E3F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
