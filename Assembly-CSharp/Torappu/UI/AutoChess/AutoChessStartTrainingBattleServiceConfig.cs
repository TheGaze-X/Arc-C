using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006267 RID: 25191
	[Token(Token = "0x2006267")]
	public class AutoChessStartTrainingBattleServiceConfig : StartBattleServiceConfig<AutoChessTrainingBattleStartRequest, AutoChessTrainingBattleStartResponse>
	{
		// Token: 0x06024578 RID: 148856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024578")]
		[Address(RVA = "0x1F2EE00", Offset = "0x1F2DA00", VA = "0x181F2EE00")]
		public AutoChessStartTrainingBattleServiceConfig(string activityId, string stageId)
		{
		}

		// Token: 0x06024579 RID: 148857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024579")]
		[Address(RVA = "0x1F2ED50", Offset = "0x1F2D950", VA = "0x181F2ED50", Slot = "5")]
		protected override AutoChessTrainingBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x170055B2 RID: 21938
		// (get) Token: 0x0602457A RID: 148858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170055B2")]
		protected override string serviceCode
		{
			[Token(Token = "0x602457A")]
			[Address(RVA = "0x1F2EEB0", Offset = "0x1F2DAB0", VA = "0x181F2EEB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x040328A1 RID: 207009
		[Token(Token = "0x40328A1")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x040328A2 RID: 207010
		[Token(Token = "0x40328A2")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x040328A3 RID: 207011
		[Token(Token = "0x40328A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040328A4 RID: 207012
		[Token(Token = "0x40328A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ParseRequest;

		// Token: 0x040328A5 RID: 207013
		[Token(Token = "0x40328A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_serviceCode;
	}
}
