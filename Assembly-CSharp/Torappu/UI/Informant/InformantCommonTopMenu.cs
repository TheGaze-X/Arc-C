using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049F6 RID: 18934
	[Token(Token = "0x20049F6")]
	public class InformantCommonTopMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x0601C818 RID: 116760 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C819 RID: 116761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700436C")]
		public Action onExit
		{
			[Token(Token = "0x601C818")]
			[Address(RVA = "0x15F4D80", Offset = "0x15F3980", VA = "0x1815F4D80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C819")]
			[Address(RVA = "0x15F4DE0", Offset = "0x15F39E0", VA = "0x1815F4DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601C81A RID: 116762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C81A")]
		[Address(RVA = "0x15F4C70", Offset = "0x15F3870", VA = "0x1815F4C70")]
		public void EventOnExitBtnClicked()
		{
		}

		// Token: 0x0601C81B RID: 116763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C81B")]
		[Address(RVA = "0x15F4D20", Offset = "0x15F3920", VA = "0x1815F4D20")]
		public InformantCommonTopMenu()
		{
		}

		// Token: 0x0402559B RID: 152987
		[Token(Token = "0x402559B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onExit;

		// Token: 0x0402559C RID: 152988
		[Token(Token = "0x402559C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onExit;

		// Token: 0x0402559D RID: 152989
		[Token(Token = "0x402559D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnExitBtnClicked;

		// Token: 0x0402559E RID: 152990
		[Token(Token = "0x402559E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
