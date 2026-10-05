using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200405D RID: 16477
	[Token(Token = "0x200405D")]
	public struct TabPanelConfig
	{
		// Token: 0x0401FC46 RID: 130118
		[Token(Token = "0x401FC46")]
		[FieldOffset(Offset = "0x0")]
		public string topTitle;

		// Token: 0x0401FC47 RID: 130119
		[Token(Token = "0x401FC47")]
		[FieldOffset(Offset = "0x8")]
		public Sprite topIcon;

		// Token: 0x0401FC48 RID: 130120
		[Token(Token = "0x401FC48")]
		[FieldOffset(Offset = "0x10")]
		public bool hideBottomGradient;

		// Token: 0x0401FC49 RID: 130121
		[Token(Token = "0x401FC49")]
		[FieldOffset(Offset = "0x18")]
		public Func<string, bool> activeCheckFunc;
	}
}
