using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004C9D RID: 19613
	[Token(Token = "0x2004C9D")]
	[Serializable]
	public class StageDecoAvatar
	{
		// Token: 0x0601D63F RID: 120383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D63F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageDecoAvatar()
		{
		}

		// Token: 0x04026B1C RID: 158492
		[Token(Token = "0x4026B1C")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04026B1D RID: 158493
		[Token(Token = "0x4026B1D")]
		[FieldOffset(Offset = "0x18")]
		public Sprite sprite;
	}
}
