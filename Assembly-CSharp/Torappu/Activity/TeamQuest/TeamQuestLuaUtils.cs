using System;
using Il2CppDummyDll;
using Torappu.UI.CommonInviteDialog;
using XLua;

namespace Torappu.Activity.TeamQuest
{
	// Token: 0x02006EAE RID: 28334
	[Token(Token = "0x2006EAE")]
	public class TeamQuestLuaUtils : ILuaCallCSharp, IHotfixable
	{
		// Token: 0x060284DB RID: 165083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284DB")]
		[Address(RVA = "0x23976C0", Offset = "0x23962C0", VA = "0x1823976C0")]
		public static CommonInviteDialog.Input CreateBasicInviteDialogInput(bool isInvite)
		{
			return null;
		}

		// Token: 0x060284DC RID: 165084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284DC")]
		[Address(RVA = "0x23977C0", Offset = "0x23963C0", VA = "0x1823977C0")]
		public TeamQuestLuaUtils()
		{
		}

		// Token: 0x04039476 RID: 234614
		[Token(Token = "0x4039476")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateBasicInviteDialogInput;

		// Token: 0x04039477 RID: 234615
		[Token(Token = "0x4039477")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
