using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200665F RID: 26207
	[Token(Token = "0x200665F")]
	[Serializable]
	public class HandbookTeamIconData
	{
		// Token: 0x06025A23 RID: 154147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A23")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookTeamIconData()
		{
		}

		// Token: 0x04034DDD RID: 216541
		[Token(Token = "0x4034DDD")]
		[FieldOffset(Offset = "0x10")]
		public string powerId;

		// Token: 0x04034DDE RID: 216542
		[Token(Token = "0x4034DDE")]
		[FieldOffset(Offset = "0x18")]
		public int iconType;

		// Token: 0x04034DDF RID: 216543
		[Token(Token = "0x4034DDF")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 iconPos;

		// Token: 0x04034DE0 RID: 216544
		[Token(Token = "0x4034DE0")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 iconDestination;

		// Token: 0x04034DE1 RID: 216545
		[Token(Token = "0x4034DE1")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 LargeMark;
	}
}
