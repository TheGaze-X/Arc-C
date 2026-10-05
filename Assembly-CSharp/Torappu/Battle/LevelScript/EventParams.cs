using System;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200282B RID: 10283
	[Token(Token = "0x200282B")]
	public class EventParams : ParamBlackboard
	{
		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x060111E2 RID: 70114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025BB")]
		private static ScopeStack<EventParams> scopeReusableStack
		{
			[Token(Token = "0x60111E2")]
			[Address(RVA = "0x90CDC0", Offset = "0x90B9C0", VA = "0x18090CDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060111E3 RID: 70115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111E3")]
		[Address(RVA = "0x90CCA0", Offset = "0x90B8A0", VA = "0x18090CCA0")]
		public static EventParams NewEventParams()
		{
			return null;
		}

		// Token: 0x060111E4 RID: 70116 RVA: 0x00069750 File Offset: 0x00067950
		[Token(Token = "0x60111E4")]
		[Address(RVA = "0x90C9B0", Offset = "0x90B5B0", VA = "0x18090C9B0")]
		public static ScopeStack<EventParams>.Scope<EventParams> Allocate(out EventParams context)
		{
			return default(ScopeStack<EventParams>.Scope<EventParams>);
		}

		// Token: 0x060111E5 RID: 70117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111E5")]
		[Address(RVA = "0x90CC30", Offset = "0x90B830", VA = "0x18090CC30")]
		public static EventParams NewEmpty()
		{
			return null;
		}

		// Token: 0x060111E6 RID: 70118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111E6")]
		[Address(RVA = "0x90CD50", Offset = "0x90B950", VA = "0x18090CD50")]
		public void SetSender(string unitId)
		{
		}

		// Token: 0x060111E7 RID: 70119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111E7")]
		[Address(RVA = "0x90CCF0", Offset = "0x90B8F0", VA = "0x18090CCF0")]
		public void SetReceiver(string unitId)
		{
		}

		// Token: 0x060111E8 RID: 70120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111E8")]
		[Address(RVA = "0x90CDB0", Offset = "0x90B9B0", VA = "0x18090CDB0")]
		public EventParams()
		{
		}

		// Token: 0x040132F3 RID: 78579
		[Token(Token = "0x40132F3")]
		[FieldOffset(Offset = "0x0")]
		private static ScopeStack<EventParams> s_scopeReusableStack;
	}
}
