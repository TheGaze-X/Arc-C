using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Mission
{
	// Token: 0x0200489B RID: 18587
	[Token(Token = "0x200489B")]
	[Serializable]
	public struct MainMissionTaskViewStyleConfig
	{
		// Token: 0x040249F8 RID: 150008
		[Token(Token = "0x40249F8")]
		[FieldOffset(Offset = "0x0")]
		public MainMissionTaskViewStyleBaseInfo baseInfo;

		// Token: 0x040249F9 RID: 150009
		[Token(Token = "0x40249F9")]
		[FieldOffset(Offset = "0x8")]
		public Color backgroundDownDecColor;

		// Token: 0x040249FA RID: 150010
		[Token(Token = "0x40249FA")]
		[FieldOffset(Offset = "0x18")]
		public Sprite backgroundSprite;

		// Token: 0x040249FB RID: 150011
		[Token(Token = "0x40249FB")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 descAnchorPos;

		// Token: 0x040249FC RID: 150012
		[Token(Token = "0x40249FC")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 descSizeDelta;

		// Token: 0x040249FD RID: 150013
		[Token(Token = "0x40249FD")]
		[FieldOffset(Offset = "0x30")]
		public Color descColor;

		// Token: 0x040249FE RID: 150014
		[Token(Token = "0x40249FE")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 requireLabelAnchoredPos;

		// Token: 0x040249FF RID: 150015
		[Token(Token = "0x40249FF")]
		[FieldOffset(Offset = "0x48")]
		public Color requireLabelBackgroundColor;

		// Token: 0x04024A00 RID: 150016
		[Token(Token = "0x4024A00")]
		[FieldOffset(Offset = "0x58")]
		public Color requireLabelTextColor;

		// Token: 0x04024A01 RID: 150017
		[Token(Token = "0x4024A01")]
		[FieldOffset(Offset = "0x68")]
		public Sprite acceptButtonSprite;

		// Token: 0x04024A02 RID: 150018
		[Token(Token = "0x4024A02")]
		[FieldOffset(Offset = "0x70")]
		public Sprite acceptButtonGlowSprite;

		// Token: 0x04024A03 RID: 150019
		[Token(Token = "0x4024A03")]
		[FieldOffset(Offset = "0x78")]
		public Color acceptTextColor;

		// Token: 0x04024A04 RID: 150020
		[Token(Token = "0x4024A04")]
		[FieldOffset(Offset = "0x88")]
		public Color progressBarColor;

		// Token: 0x04024A05 RID: 150021
		[Token(Token = "0x4024A05")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly MainMissionTaskViewStyleConfig EMPTY;
	}
}
