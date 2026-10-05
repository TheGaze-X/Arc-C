using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C00 RID: 3072
	[Token(Token = "0x2000C00")]
	[Serializable]
	public class PlayerNameCardSkin
	{
		// Token: 0x06006894 RID: 26772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006894")]
		[Address(RVA = "0x1EFBC30", Offset = "0x1EFA830", VA = "0x181EFBC30")]
		public PlayerNameCardSkin()
		{
		}

		// Token: 0x04003EBB RID: 16059
		[Token(Token = "0x4003EBB")]
		[FieldOffset(Offset = "0x10")]
		public string selected;

		// Token: 0x04003EBC RID: 16060
		[Token(Token = "0x4003EBC")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerNameCardSkin.SkinState> state;

		// Token: 0x04003EBD RID: 16061
		[Token(Token = "0x4003EBD")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, int> tmpl;

		// Token: 0x02000C01 RID: 3073
		[Token(Token = "0x2000C01")]
		public class SkinState
		{
			// Token: 0x06006895 RID: 26773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006895")]
			[Address(RVA = "0x1F01980", Offset = "0x1F00580", VA = "0x181F01980")]
			public SkinState()
			{
			}

			// Token: 0x04003EBE RID: 16062
			[Token(Token = "0x4003EBE")]
			[FieldOffset(Offset = "0x10")]
			public bool unlock;

			// Token: 0x04003EBF RID: 16063
			[Token(Token = "0x4003EBF")]
			[FieldOffset(Offset = "0x18")]
			public List<List<int>> progress;

			// Token: 0x04003EC0 RID: 16064
			[Token(Token = "0x4003EC0")]
			[FieldOffset(Offset = "0x20")]
			public long unlockTs;
		}
	}
}
