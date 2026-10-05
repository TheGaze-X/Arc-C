using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003687 RID: 13959
	[Token(Token = "0x2003687")]
	public class DataTransAction : ITransAction
	{
		// Token: 0x0601634B RID: 90955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601634B")]
		[Address(RVA = "0xE921F0", Offset = "0xE90DF0", VA = "0x180E921F0")]
		public DataTransAction(TransitionSide side, Action<IStateBean> callback)
		{
		}

		// Token: 0x0601634C RID: 90956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601634C")]
		[Address(RVA = "0xE92140", Offset = "0xE90D40", VA = "0x180E92140", Slot = "4")]
		public void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
		{
		}

		// Token: 0x0601634D RID: 90957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601634D")]
		[Address(RVA = "0xE92010", Offset = "0xE90C10", VA = "0x180E92010", Slot = "5")]
		public void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
		{
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0601634E RID: 90958 RVA: 0x0008FF88 File Offset: 0x0008E188
		[Token(Token = "0x17003561")]
		public TransActionType ActionType
		{
			[Token(Token = "0x601634E")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
			get
			{
				return TransActionType.SEQUENTIAL;
			}
		}

		// Token: 0x0401AAF2 RID: 109298
		[Token(Token = "0x401AAF2")]
		[FieldOffset(Offset = "0x10")]
		private Action<IStateBean> m_dataListener;

		// Token: 0x0401AAF3 RID: 109299
		[Token(Token = "0x401AAF3")]
		[FieldOffset(Offset = "0x18")]
		private TransitionSide m_transSide;
	}
}
