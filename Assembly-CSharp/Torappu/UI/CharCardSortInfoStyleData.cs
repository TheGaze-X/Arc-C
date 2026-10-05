using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200354A RID: 13642
	[Token(Token = "0x200354A")]
	[Serializable]
	public struct CharCardSortInfoStyleData
	{
		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x06015BD8 RID: 89048 RVA: 0x0008DA50 File Offset: 0x0008BC50
		[Token(Token = "0x170033A3")]
		public bool isEmpty
		{
			[Token(Token = "0x6015BD8")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0401A20C RID: 107020
		[Token(Token = "0x401A20C")]
		[FieldOffset(Offset = "0x0")]
		public string sortTypeIconId;

		// Token: 0x0401A20D RID: 107021
		[Token(Token = "0x401A20D")]
		[FieldOffset(Offset = "0x8")]
		public Color maskColor;

		// Token: 0x0401A20E RID: 107022
		[Token(Token = "0x401A20E")]
		[FieldOffset(Offset = "0x18")]
		public Color maskCustomColor;

		// Token: 0x0401A20F RID: 107023
		[Token(Token = "0x401A20F")]
		[FieldOffset(Offset = "0x28")]
		public Color textCustomColor;
	}
}
