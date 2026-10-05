using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B22 RID: 6946
	[Token(Token = "0x2001B22")]
	public abstract class AbstractBuildingUIFloatStationView : DataBinder<FloatStationViewProperty>
	{
		// Token: 0x0600AEE9 RID: 44777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE9")]
		[Address(RVA = "0x32887A0", Offset = "0x32873A0", VA = "0x1832887A0")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x0600AEEA RID: 44778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEEA")]
		[Address(RVA = "0x3288810", Offset = "0x3287410", VA = "0x183288810")]
		protected AbstractBuildingUIFloatStationView()
		{
		}

		// Token: 0x0400A82A RID: 43050
		[Token(Token = "0x400A82A")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action requestToClose;

		// Token: 0x0400A82B RID: 43051
		[Token(Token = "0x400A82B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnBlankClicked;

		// Token: 0x0400A82C RID: 43052
		[Token(Token = "0x400A82C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
