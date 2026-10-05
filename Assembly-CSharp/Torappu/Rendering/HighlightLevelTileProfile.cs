using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002061 RID: 8289
	[Token(Token = "0x2002061")]
	[CreateAssetMenu(menuName = "Torappu/Highlight Level Tile Profile")]
	public class HighlightLevelTileProfile : HighlightTileProfile
	{
		// Token: 0x0600CC32 RID: 52274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC32")]
		[Address(RVA = "0x34D55F0", Offset = "0x34D41F0", VA = "0x1834D55F0")]
		public HighlightLevelTileProfile()
		{
		}

		// Token: 0x0400D6A9 RID: 54953
		[Token(Token = "0x400D6A9")]
		[FieldOffset(Offset = "0x30")]
		public HighlightLevelTileProfile.HighlightLevelPack[] levelPacks;

		// Token: 0x02002062 RID: 8290
		[Token(Token = "0x2002062")]
		[Serializable]
		public struct HighlightLevelPack
		{
			// Token: 0x0400D6AA RID: 54954
			[Token(Token = "0x400D6AA")]
			[FieldOffset(Offset = "0x0")]
			public Color color;

			// Token: 0x0400D6AB RID: 54955
			[Token(Token = "0x400D6AB")]
			[FieldOffset(Offset = "0x10")]
			public float strength;
		}
	}
}
