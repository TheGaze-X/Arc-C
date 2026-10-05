using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F2C RID: 24364
	[Token(Token = "0x2005F2C")]
	public class SpCharMissionObjViewModel : IHotfixable
	{
		// Token: 0x0602348D RID: 144525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602348D")]
		[Address(RVA = "0x1DE4D20", Offset = "0x1DE3920", VA = "0x181DE4D20")]
		public void LoadData(SpCharMissionData missionData)
		{
		}

		// Token: 0x0602348E RID: 144526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602348E")]
		[Address(RVA = "0x1DE50B0", Offset = "0x1DE3CB0", VA = "0x181DE50B0")]
		public SpCharMissionObjViewModel()
		{
		}

		// Token: 0x04030A5B RID: 199259
		[Token(Token = "0x4030A5B")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04030A5C RID: 199260
		[Token(Token = "0x4030A5C")]
		[FieldOffset(Offset = "0x18")]
		public string missionId;

		// Token: 0x04030A5D RID: 199261
		[Token(Token = "0x4030A5D")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04030A5E RID: 199262
		[Token(Token = "0x4030A5E")]
		[FieldOffset(Offset = "0x28")]
		public string condSpriteId;

		// Token: 0x04030A5F RID: 199263
		[Token(Token = "0x4030A5F")]
		[FieldOffset(Offset = "0x30")]
		public string condDesc;

		// Token: 0x04030A60 RID: 199264
		[Token(Token = "0x4030A60")]
		[FieldOffset(Offset = "0x38")]
		public List<ItemBundle> rewards;

		// Token: 0x04030A61 RID: 199265
		[Token(Token = "0x4030A61")]
		[FieldOffset(Offset = "0x40")]
		public bool isFullfilled;

		// Token: 0x04030A62 RID: 199266
		[Token(Token = "0x4030A62")]
		[FieldOffset(Offset = "0x41")]
		public bool isComplete;

		// Token: 0x04030A63 RID: 199267
		[Token(Token = "0x4030A63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030A64 RID: 199268
		[Token(Token = "0x4030A64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
