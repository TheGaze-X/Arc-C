using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006893 RID: 26771
	[Token(Token = "0x2006893")]
	public abstract class StageTabBaseState : StageBaseState
	{
		// Token: 0x060265CC RID: 157132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265CC")]
		[Address(RVA = "0x216EB60", Offset = "0x216D760", VA = "0x18216EB60", Slot = "23")]
		public virtual void OnMapLoadFinish(string zoneId)
		{
		}

		// Token: 0x060265CD RID: 157133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265CD")]
		[Address(RVA = "0x216EB00", Offset = "0x216D700", VA = "0x18216EB00", Slot = "24")]
		public virtual void OnMapLoadError(string zoneId)
		{
		}

		// Token: 0x060265CE RID: 157134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60265CE")]
		[Address(RVA = "0x216EBC0", Offset = "0x216D7C0", VA = "0x18216EBC0")]
		protected StageTabBaseState()
		{
		}

		// Token: 0x04036068 RID: 221288
		[Token(Token = "0x4036068")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMapLoadFinish;

		// Token: 0x04036069 RID: 221289
		[Token(Token = "0x4036069")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMapLoadError;

		// Token: 0x0403606A RID: 221290
		[Token(Token = "0x403606A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
