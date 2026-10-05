using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering.Behaviours
{
	// Token: 0x02002075 RID: 8309
	[Token(Token = "0x2002075")]
	public abstract class AbstractRenderBehaviour : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x0600CCCB RID: 52427
		[Token(Token = "0x17001845")]
		protected abstract bool isValid { [Token(Token = "0x600CCCB")] get; }

		// Token: 0x0600CCCC RID: 52428 RVA: 0x00049E30 File Offset: 0x00048030
		[Token(Token = "0x600CCCC")]
		[Address(RVA = "0x34CF770", Offset = "0x34CE370", VA = "0x1834CF770")]
		public bool Apply()
		{
			return default(bool);
		}

		// Token: 0x0600CCCD RID: 52429
		[Token(Token = "0x600CCCD")]
		protected abstract bool DoApply();

		// Token: 0x0600CCCE RID: 52430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCCE")]
		[Address(RVA = "0x34CF830", Offset = "0x34CE430", VA = "0x1834CF830")]
		public void Terminate()
		{
		}

		// Token: 0x0600CCCF RID: 52431
		[Token(Token = "0x600CCCF")]
		protected abstract void DoTerminate();

		// Token: 0x0600CCD0 RID: 52432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCD0")]
		[Address(RVA = "0x34CF8C0", Offset = "0x34CE4C0", VA = "0x1834CF8C0")]
		protected AbstractRenderBehaviour()
		{
		}

		// Token: 0x0400D806 RID: 55302
		[Token(Token = "0x400D806")]
		[FieldOffset(Offset = "0x18")]
		protected bool m_isApplied;

		// Token: 0x0400D807 RID: 55303
		[Token(Token = "0x400D807")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x0400D808 RID: 55304
		[Token(Token = "0x400D808")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Terminate;

		// Token: 0x0400D809 RID: 55305
		[Token(Token = "0x400D809")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
