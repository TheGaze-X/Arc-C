using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200626A RID: 25194
	[Token(Token = "0x200626A")]
	public class AutoChessMultiBattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x06024581 RID: 148865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024581")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public AutoChessMultiBattleFinishRequest()
		{
		}

		// Token: 0x040328A8 RID: 207016
		[Token(Token = "0x40328A8")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;

		// Token: 0x040328A9 RID: 207017
		[Token(Token = "0x40328A9")]
		[FieldOffset(Offset = "0x28")]
		public string sceneId;
	}
}
