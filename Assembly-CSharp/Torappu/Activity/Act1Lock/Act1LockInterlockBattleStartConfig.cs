using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007866 RID: 30822
	[Token(Token = "0x2007866")]
	public class Act1LockInterlockBattleStartConfig : StartBattleServiceConfig<Act1LockInterlockBattleStartRequest, Act1LockInterlockBattleStartResponse>
	{
		// Token: 0x17006515 RID: 25877
		// (get) Token: 0x0602B333 RID: 176947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006515")]
		protected override string serviceCode
		{
			[Token(Token = "0x602B333")]
			[Address(RVA = "0x2708DA0", Offset = "0x27079A0", VA = "0x182708DA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B334 RID: 176948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B334")]
		[Address(RVA = "0x2708CD0", Offset = "0x27078D0", VA = "0x182708CD0")]
		public Act1LockInterlockBattleStartConfig(string activityId, string stageId, bool useSpecial)
		{
		}

		// Token: 0x0602B335 RID: 176949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B335")]
		[Address(RVA = "0x2708C10", Offset = "0x2707810", VA = "0x182708C10", Slot = "5")]
		protected override Act1LockInterlockBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x0403E755 RID: 255829
		[Token(Token = "0x403E755")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x0403E756 RID: 255830
		[Token(Token = "0x403E756")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x0403E757 RID: 255831
		[Token(Token = "0x403E757")]
		[FieldOffset(Offset = "0x20")]
		private bool m_useSpecial;

		// Token: 0x0403E758 RID: 255832
		[Token(Token = "0x403E758")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403E759 RID: 255833
		[Token(Token = "0x403E759")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403E75A RID: 255834
		[Token(Token = "0x403E75A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseRequest;
	}
}
