using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005069 RID: 20585
	[Token(Token = "0x2005069")]
	public class EnemyDuelServiceParam
	{
		// Token: 0x0601E83B RID: 124987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E83B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelServiceParam()
		{
		}

		// Token: 0x04028DE3 RID: 167395
		[Token(Token = "0x4028DE3")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelService.Setting setting;

		// Token: 0x04028DE4 RID: 167396
		[Token(Token = "0x4028DE4")]
		[FieldOffset(Offset = "0x30")]
		public string activityId;

		// Token: 0x04028DE5 RID: 167397
		[Token(Token = "0x4028DE5")]
		[FieldOffset(Offset = "0x38")]
		public string modeId;

		// Token: 0x04028DE6 RID: 167398
		[Token(Token = "0x4028DE6")]
		[FieldOffset(Offset = "0x40")]
		public bool isRoomOwner;

		// Token: 0x04028DE7 RID: 167399
		[Token(Token = "0x4028DE7")]
		[FieldOffset(Offset = "0x48")]
		public Func<string, StageData> stageDataGetter;
	}
}
