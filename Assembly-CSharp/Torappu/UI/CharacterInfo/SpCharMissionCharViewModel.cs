using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F2A RID: 24362
	[Token(Token = "0x2005F2A")]
	public class SpCharMissionCharViewModel : IHotfixable
	{
		// Token: 0x06023488 RID: 144520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023488")]
		[Address(RVA = "0x1DE4770", Offset = "0x1DE3370", VA = "0x181DE4770")]
		public void LoadData(PlayerCharacter playerChar, bool isCur)
		{
		}

		// Token: 0x06023489 RID: 144521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023489")]
		[Address(RVA = "0x1DE4C70", Offset = "0x1DE3870", VA = "0x181DE4C70")]
		public SpCharMissionCharViewModel()
		{
		}

		// Token: 0x04030A51 RID: 199249
		[Token(Token = "0x4030A51")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04030A52 RID: 199250
		[Token(Token = "0x4030A52")]
		[FieldOffset(Offset = "0x18")]
		public int charInstId;

		// Token: 0x04030A53 RID: 199251
		[Token(Token = "0x4030A53")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04030A54 RID: 199252
		[Token(Token = "0x4030A54")]
		[FieldOffset(Offset = "0x28")]
		public bool isCurrnet;

		// Token: 0x04030A55 RID: 199253
		[Token(Token = "0x4030A55")]
		[FieldOffset(Offset = "0x30")]
		public string skinId;

		// Token: 0x04030A56 RID: 199254
		[Token(Token = "0x4030A56")]
		[FieldOffset(Offset = "0x38")]
		public List<SpCharMissionObjViewModel> missionModels;

		// Token: 0x04030A57 RID: 199255
		[Token(Token = "0x4030A57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030A58 RID: 199256
		[Token(Token = "0x4030A58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
