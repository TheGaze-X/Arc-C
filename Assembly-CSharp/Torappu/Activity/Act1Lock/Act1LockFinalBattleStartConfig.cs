using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x0200786C RID: 30828
	[Token(Token = "0x200786C")]
	public class Act1LockFinalBattleStartConfig : StartBattleServiceConfig<Act1LockFinalBattleStartRequest, Act1LockFinalBattleStartResponse>
	{
		// Token: 0x17006516 RID: 25878
		// (get) Token: 0x0602B33E RID: 176958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006516")]
		protected override string serviceCode
		{
			[Token(Token = "0x602B33E")]
			[Address(RVA = "0x2708AC0", Offset = "0x27076C0", VA = "0x182708AC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B33F RID: 176959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B33F")]
		[Address(RVA = "0x27089E0", Offset = "0x27075E0", VA = "0x1827089E0")]
		public Act1LockFinalBattleStartConfig(string activityId, string stageId, bool useSpecial, bool usePt, bool isReplay)
		{
		}

		// Token: 0x0602B340 RID: 176960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B340")]
		[Address(RVA = "0x2708910", Offset = "0x2707510", VA = "0x182708910", Slot = "5")]
		protected override Act1LockFinalBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403E762 RID: 255842
		[Token(Token = "0x403E762")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x0403E763 RID: 255843
		[Token(Token = "0x403E763")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x0403E764 RID: 255844
		[Token(Token = "0x403E764")]
		[FieldOffset(Offset = "0x20")]
		private bool m_useSpecial;

		// Token: 0x0403E765 RID: 255845
		[Token(Token = "0x403E765")]
		[FieldOffset(Offset = "0x21")]
		private bool m_usePracticeTicket;

		// Token: 0x0403E766 RID: 255846
		[Token(Token = "0x403E766")]
		[FieldOffset(Offset = "0x22")]
		private bool m_isReplay;

		// Token: 0x0403E767 RID: 255847
		[Token(Token = "0x403E767")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403E768 RID: 255848
		[Token(Token = "0x403E768")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403E769 RID: 255849
		[Token(Token = "0x403E769")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
