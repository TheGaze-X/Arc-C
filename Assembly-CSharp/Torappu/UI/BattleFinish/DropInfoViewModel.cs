using System;
using Il2CppDummyDll;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061FB RID: 25083
	[Token(Token = "0x20061FB")]
	public struct DropInfoViewModel
	{
		// Token: 0x04032511 RID: 206097
		[Token(Token = "0x4032511")]
		[FieldOffset(Offset = "0x0")]
		public UIItemViewModel itemModel;

		// Token: 0x04032512 RID: 206098
		[Token(Token = "0x4032512")]
		[FieldOffset(Offset = "0x8")]
		public bool isFirstDrop;

		// Token: 0x04032513 RID: 206099
		[Token(Token = "0x4032513")]
		[FieldOffset(Offset = "0x9")]
		public bool isUnusual;

		// Token: 0x04032514 RID: 206100
		[Token(Token = "0x4032514")]
		[FieldOffset(Offset = "0xC")]
		public StageDropType dropType;

		// Token: 0x04032515 RID: 206101
		[Token(Token = "0x4032515")]
		[FieldOffset(Offset = "0x10")]
		public PlayerCharacter charInst;

		// Token: 0x04032516 RID: 206102
		[Token(Token = "0x4032516")]
		[FieldOffset(Offset = "0x18")]
		public GachaResult gachaResult;
	}
}
