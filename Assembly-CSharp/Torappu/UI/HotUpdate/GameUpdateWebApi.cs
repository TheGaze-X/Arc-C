using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004AB0 RID: 19120
	[Token(Token = "0x2004AB0")]
	public class GameUpdateWebApi : IHotfixable, IGameUpdate
	{
		// Token: 0x0601CB82 RID: 117634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB82")]
		[Address(RVA = "0x1622E50", Offset = "0x1621A50", VA = "0x181622E50")]
		public GameUpdateWebApi(GameUpdateOptions options)
		{
		}

		// Token: 0x0601CB83 RID: 117635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB83")]
		[Address(RVA = "0x1622BE0", Offset = "0x16217E0", VA = "0x181622BE0", Slot = "4")]
		public IEnumerator DoUpdate(GameUpdateResult result)
		{
			return null;
		}

		// Token: 0x0601CB84 RID: 117636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB84")]
		[Address(RVA = "0x1622D80", Offset = "0x1621980", VA = "0x181622D80")]
		private IEnumerator _UpdateGame(GameUpdateContext context)
		{
			return null;
		}

		// Token: 0x0601CB85 RID: 117637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CB85")]
		[Address(RVA = "0x1622CB0", Offset = "0x16218B0", VA = "0x181622CB0")]
		private IEnumerator _GetLatestGame(GameUpdateContext context)
		{
			return null;
		}

		// Token: 0x04025B42 RID: 154434
		[Token(Token = "0x4025B42")]
		[FieldOffset(Offset = "0x10")]
		private GameUpdateOptions m_options;

		// Token: 0x04025B43 RID: 154435
		[Token(Token = "0x4025B43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04025B44 RID: 154436
		[Token(Token = "0x4025B44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoUpdate;

		// Token: 0x04025B45 RID: 154437
		[Token(Token = "0x4025B45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateGame;

		// Token: 0x04025B46 RID: 154438
		[Token(Token = "0x4025B46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetLatestGame;
	}
}
