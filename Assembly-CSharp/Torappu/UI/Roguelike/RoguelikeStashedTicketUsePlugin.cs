using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200553E RID: 21822
	[Token(Token = "0x200553E")]
	public abstract class RoguelikeStashedTicketUsePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020165 RID: 131429
		[Token(Token = "0x6020165")]
		public abstract RoguelikeStashedTicketUseParamBuilder GetModelParamBuilder();

		// Token: 0x06020166 RID: 131430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020166")]
		[Address(RVA = "0x1A40150", Offset = "0x1A3ED50", VA = "0x181A40150")]
		protected RoguelikeStashedTicketUsePlugin()
		{
		}

		// Token: 0x0402B57C RID: 177532
		[Token(Token = "0x402B57C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
