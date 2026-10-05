using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006289 RID: 25225
	[Token(Token = "0x2006289")]
	public class AutoChessBandChooseAVGAdapter : ExecutorComponent, IHotfixable
	{
		// Token: 0x06024602 RID: 148994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024602")]
		[Address(RVA = "0x1F22810", Offset = "0x1F21410", VA = "0x181F22810", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06024603 RID: 148995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024603")]
		[Address(RVA = "0x1F227B0", Offset = "0x1F213B0", VA = "0x181F227B0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06024604 RID: 148996 RVA: 0x000C40E0 File Offset: 0x000C22E0
		[Token(Token = "0x6024604")]
		[Address(RVA = "0x1F229A0", Offset = "0x1F215A0", VA = "0x181F229A0")]
		private bool _OnFocusBandItem(Command command)
		{
			return default(bool);
		}

		// Token: 0x06024605 RID: 148997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024605")]
		[Address(RVA = "0x1F22750", Offset = "0x1F21350", VA = "0x181F22750")]
		public void EventOnFocusComplete()
		{
		}

		// Token: 0x06024606 RID: 148998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024606")]
		[Address(RVA = "0x1F22A40", Offset = "0x1F21640", VA = "0x181F22A40")]
		public AutoChessBandChooseAVGAdapter()
		{
		}

		// Token: 0x0403297B RID: 207227
		[Token(Token = "0x403297B")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403297C RID: 207228
		[Token(Token = "0x403297C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0403297D RID: 207229
		[Token(Token = "0x403297D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0403297E RID: 207230
		[Token(Token = "0x403297E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnFocusBandItem;

		// Token: 0x0403297F RID: 207231
		[Token(Token = "0x403297F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFocusComplete;

		// Token: 0x04032980 RID: 207232
		[Token(Token = "0x4032980")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
