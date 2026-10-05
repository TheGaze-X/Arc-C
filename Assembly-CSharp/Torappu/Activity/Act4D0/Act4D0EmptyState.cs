using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200727B RID: 29307
	[Token(Token = "0x200727B")]
	public class Act4D0EmptyState : State
	{
		// Token: 0x0602981F RID: 170015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602981F")]
		[Address(RVA = "0x24DB7D0", Offset = "0x24DA3D0", VA = "0x1824DB7D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029820 RID: 170016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029820")]
		[Address(RVA = "0x24DB830", Offset = "0x24DA430", VA = "0x1824DB830", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06029821 RID: 170017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029821")]
		[Address(RVA = "0x24DB990", Offset = "0x24DA590", VA = "0x1824DB990")]
		public void ToStoryState()
		{
		}

		// Token: 0x06029822 RID: 170018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029822")]
		[Address(RVA = "0x24DB900", Offset = "0x24DA500", VA = "0x1824DB900")]
		public void ToMileStoneState()
		{
		}

		// Token: 0x06029823 RID: 170019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029823")]
		[Address(RVA = "0x24DBA20", Offset = "0x24DA620", VA = "0x1824DBA20")]
		public Act4D0EmptyState()
		{
		}

		// Token: 0x06029824 RID: 170020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029824")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403B4F0 RID: 242928
		[Token(Token = "0x403B4F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B4F1 RID: 242929
		[Token(Token = "0x403B4F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B4F2 RID: 242930
		[Token(Token = "0x403B4F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToStoryState;

		// Token: 0x0403B4F3 RID: 242931
		[Token(Token = "0x403B4F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToMileStoneState;

		// Token: 0x0403B4F4 RID: 242932
		[Token(Token = "0x403B4F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
