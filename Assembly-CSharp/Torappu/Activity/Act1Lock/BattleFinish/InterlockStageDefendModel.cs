using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078F4 RID: 30964
	[Token(Token = "0x20078F4")]
	public class InterlockStageDefendModel : IHotfixable
	{
		// Token: 0x0602B6B8 RID: 177848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6B8")]
		[Address(RVA = "0x2762D00", Offset = "0x2761900", VA = "0x182762D00")]
		public InterlockStageDefendModel()
		{
		}

		// Token: 0x0403EC9B RID: 257179
		[Token(Token = "0x403EC9B")]
		[FieldOffset(Offset = "0x10")]
		public Sprite spriteBlurBkg;

		// Token: 0x0403EC9C RID: 257180
		[Token(Token = "0x403EC9C")]
		[FieldOffset(Offset = "0x18")]
		public bool isReplace;

		// Token: 0x0403EC9D RID: 257181
		[Token(Token = "0x403EC9D")]
		[FieldOffset(Offset = "0x1C")]
		public int battleRank;

		// Token: 0x0403EC9E RID: 257182
		[Token(Token = "0x403EC9E")]
		[FieldOffset(Offset = "0x20")]
		public string stageCode;

		// Token: 0x0403EC9F RID: 257183
		[Token(Token = "0x403EC9F")]
		[FieldOffset(Offset = "0x28")]
		public string stageName;

		// Token: 0x0403ECA0 RID: 257184
		[Token(Token = "0x403ECA0")]
		[FieldOffset(Offset = "0x30")]
		public string description;

		// Token: 0x0403ECA1 RID: 257185
		[Token(Token = "0x403ECA1")]
		[FieldOffset(Offset = "0x38")]
		public int charSlotCntBefore;

		// Token: 0x0403ECA2 RID: 257186
		[Token(Token = "0x403ECA2")]
		[FieldOffset(Offset = "0x3C")]
		public int charSlotCntAfter;

		// Token: 0x0403ECA3 RID: 257187
		[Token(Token = "0x403ECA3")]
		[FieldOffset(Offset = "0x40")]
		public int validCharCntBefore;

		// Token: 0x0403ECA4 RID: 257188
		[Token(Token = "0x403ECA4")]
		[FieldOffset(Offset = "0x44")]
		public int validCharCntAfter;

		// Token: 0x0403ECA5 RID: 257189
		[Token(Token = "0x403ECA5")]
		[FieldOffset(Offset = "0x48")]
		public List<DefendCharModel> charsBefore;

		// Token: 0x0403ECA6 RID: 257190
		[Token(Token = "0x403ECA6")]
		[FieldOffset(Offset = "0x50")]
		public List<DefendCharModel> charsAfter;

		// Token: 0x0403ECA7 RID: 257191
		[Token(Token = "0x403ECA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
