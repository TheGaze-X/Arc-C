using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200506E RID: 20590
	[Token(Token = "0x200506E")]
	public abstract class EnemyDuelServiceRequest : IHotfixable, IStreamSerialize
	{
		// Token: 0x17004741 RID: 18241
		// (get) Token: 0x0601E84C RID: 125004
		[Token(Token = "0x17004741")]
		public abstract EnemyDuelServiceRequestID requestID { [Token(Token = "0x601E84C")] get; }

		// Token: 0x17004742 RID: 18242
		// (get) Token: 0x0601E84D RID: 125005
		[Token(Token = "0x17004742")]
		public abstract EnemyDuelServiceRequestTarget target { [Token(Token = "0x601E84D")] get; }

		// Token: 0x0601E84E RID: 125006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E84E")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10", Slot = "7")]
		public virtual void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E84F RID: 125007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E84F")]
		[Address(RVA = "0x1845240", Offset = "0x1843E40", VA = "0x181845240")]
		protected EnemyDuelServiceRequest()
		{
		}

		// Token: 0x04028DF5 RID: 167413
		[Token(Token = "0x4028DF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028DF6 RID: 167414
		[Token(Token = "0x4028DF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
