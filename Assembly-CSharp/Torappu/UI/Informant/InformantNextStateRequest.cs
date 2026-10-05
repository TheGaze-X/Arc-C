using System;
using Il2CppDummyDll;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A3E RID: 19006
	[Token(Token = "0x2004A3E")]
	public class InformantNextStateRequest
	{
		// Token: 0x0601C943 RID: 117059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C943")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InformantNextStateRequest()
		{
		}

		// Token: 0x0402583A RID: 153658
		[Token(Token = "0x402583A")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0402583B RID: 153659
		[Token(Token = "0x402583B")]
		[FieldOffset(Offset = "0x18")]
		public PlayerActivity.PlayerAct44SideActivity.InformantState state;
	}
}
