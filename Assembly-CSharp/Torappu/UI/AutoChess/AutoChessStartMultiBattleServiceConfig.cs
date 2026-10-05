using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006264 RID: 25188
	[Token(Token = "0x2006264")]
	public class AutoChessStartMultiBattleServiceConfig : StartBattleServiceConfig<AutoChessMultiBattleStartRequest, AutoChessMultiBattleStartResponse>
	{
		// Token: 0x0602456F RID: 148847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602456F")]
		[Address(RVA = "0x1F2EC30", Offset = "0x1F2D830", VA = "0x181F2EC30")]
		public AutoChessStartMultiBattleServiceConfig(string activityId, string sceneId)
		{
		}

		// Token: 0x06024570 RID: 148848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024570")]
		[Address(RVA = "0x1F2EB80", Offset = "0x1F2D780", VA = "0x181F2EB80", Slot = "5")]
		protected override AutoChessMultiBattleStartRequest ParseRequest()
		{
			return null;
		}

		// Token: 0x170055B1 RID: 21937
		// (get) Token: 0x06024571 RID: 148849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170055B1")]
		protected override string serviceCode
		{
			[Token(Token = "0x6024571")]
			[Address(RVA = "0x1F2ECE0", Offset = "0x1F2D8E0", VA = "0x181F2ECE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0403289A RID: 207002
		[Token(Token = "0x403289A")]
		[FieldOffset(Offset = "0x10")]
		private string m_activityId;

		// Token: 0x0403289B RID: 207003
		[Token(Token = "0x403289B")]
		[FieldOffset(Offset = "0x18")]
		private string m_sceneId;

		// Token: 0x0403289C RID: 207004
		[Token(Token = "0x403289C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403289D RID: 207005
		[Token(Token = "0x403289D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ParseRequest;

		// Token: 0x0403289E RID: 207006
		[Token(Token = "0x403289E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_serviceCode;
	}
}
