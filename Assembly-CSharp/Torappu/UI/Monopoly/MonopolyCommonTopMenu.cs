using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047E4 RID: 18404
	[Token(Token = "0x20047E4")]
	public class MonopolyCommonTopMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x0601BD75 RID: 114037 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BD76 RID: 114038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004236")]
		public Action onExit
		{
			[Token(Token = "0x601BD75")]
			[Address(RVA = "0x1523CF0", Offset = "0x15228F0", VA = "0x181523CF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BD76")]
			[Address(RVA = "0x1523D50", Offset = "0x1522950", VA = "0x181523D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BD77 RID: 114039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD77")]
		[Address(RVA = "0x1523BE0", Offset = "0x15227E0", VA = "0x181523BE0")]
		public void EventOnExitBtnClicked()
		{
		}

		// Token: 0x0601BD78 RID: 114040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD78")]
		[Address(RVA = "0x1523C90", Offset = "0x1522890", VA = "0x181523C90")]
		public MonopolyCommonTopMenu()
		{
		}

		// Token: 0x040243AE RID: 148398
		[Token(Token = "0x40243AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onExit;

		// Token: 0x040243AF RID: 148399
		[Token(Token = "0x40243AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onExit;

		// Token: 0x040243B0 RID: 148400
		[Token(Token = "0x40243B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnExitBtnClicked;

		// Token: 0x040243B1 RID: 148401
		[Token(Token = "0x40243B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
