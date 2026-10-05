using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078CF RID: 30927
	[Token(Token = "0x20078CF")]
	public class Act1LockMainProperty : DynamicBindProperty<Act1LockMainProperty, Act1LockMainModel>, IHotfixable
	{
		// Token: 0x0602B5EA RID: 177642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5EA")]
		[Address(RVA = "0x27279D0", Offset = "0x27265D0", VA = "0x1827279D0")]
		public void RefreshMainInfo(string activityId)
		{
		}

		// Token: 0x0602B5EB RID: 177643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5EB")]
		[Address(RVA = "0x2727EE0", Offset = "0x2726AE0", VA = "0x182727EE0")]
		public Act1LockMainProperty()
		{
		}

		// Token: 0x0403EB7A RID: 256890
		[Token(Token = "0x403EB7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshMainInfo;

		// Token: 0x0403EB7B RID: 256891
		[Token(Token = "0x403EB7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
