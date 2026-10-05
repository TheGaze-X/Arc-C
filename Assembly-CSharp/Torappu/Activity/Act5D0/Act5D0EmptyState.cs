using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071EA RID: 29162
	[Token(Token = "0x20071EA")]
	public class Act5D0EmptyState : State
	{
		// Token: 0x060295E2 RID: 169442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60295E2")]
		[Address(RVA = "0x24A8900", Offset = "0x24A7500", VA = "0x1824A8900", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060295E3 RID: 169443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295E3")]
		[Address(RVA = "0x24A8960", Offset = "0x24A7560", VA = "0x1824A8960", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060295E4 RID: 169444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295E4")]
		[Address(RVA = "0x24A8B20", Offset = "0x24A7720", VA = "0x1824A8B20")]
		public void ToMileStoneState()
		{
		}

		// Token: 0x060295E5 RID: 169445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295E5")]
		[Address(RVA = "0x24A8A90", Offset = "0x24A7690", VA = "0x1824A8A90")]
		public void ToActivityMission()
		{
		}

		// Token: 0x060295E6 RID: 169446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295E6")]
		[Address(RVA = "0x24A8BB0", Offset = "0x24A77B0", VA = "0x1824A8BB0")]
		public void ToReplicateState()
		{
		}

		// Token: 0x060295E7 RID: 169447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295E7")]
		[Address(RVA = "0x24A8C40", Offset = "0x24A7840", VA = "0x1824A8C40")]
		public Act5D0EmptyState()
		{
		}

		// Token: 0x060295E8 RID: 169448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295E8")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403B141 RID: 241985
		[Token(Token = "0x403B141")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B142 RID: 241986
		[Token(Token = "0x403B142")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B143 RID: 241987
		[Token(Token = "0x403B143")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToMileStoneState;

		// Token: 0x0403B144 RID: 241988
		[Token(Token = "0x403B144")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToActivityMission;

		// Token: 0x0403B145 RID: 241989
		[Token(Token = "0x403B145")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ToReplicateState;

		// Token: 0x0403B146 RID: 241990
		[Token(Token = "0x403B146")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
