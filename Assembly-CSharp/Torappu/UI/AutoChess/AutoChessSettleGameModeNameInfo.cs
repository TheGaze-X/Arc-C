using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062ED RID: 25325
	[Token(Token = "0x20062ED")]
	[Serializable]
	public class AutoChessSettleGameModeNameInfo
	{
		// Token: 0x06024802 RID: 149506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024802")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessSettleGameModeNameInfo()
		{
		}

		// Token: 0x04032DD3 RID: 208339
		[Token(Token = "0x4032DD3")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessModeDifficultyType difficultyType;

		// Token: 0x04032DD4 RID: 208340
		[Token(Token = "0x4032DD4")]
		[FieldOffset(Offset = "0x18")]
		public GameObject objMode;

		// Token: 0x04032DD5 RID: 208341
		[Token(Token = "0x4032DD5")]
		[FieldOffset(Offset = "0x20")]
		public Text txtModeName;
	}
}
