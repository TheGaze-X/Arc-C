using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act33Sign
{
	// Token: 0x02007481 RID: 29825
	[Token(Token = "0x2007481")]
	public class Act33SignRedpackItemViewModel : IHotfixable
	{
		// Token: 0x0602A110 RID: 172304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A110")]
		[Address(RVA = "0x25C05D0", Offset = "0x25BF1D0", VA = "0x1825C05D0")]
		public void LoadData(int signCount)
		{
		}

		// Token: 0x0602A111 RID: 172305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A111")]
		[Address(RVA = "0x25C0830", Offset = "0x25BF430", VA = "0x1825C0830")]
		public Act33SignRedpackItemViewModel()
		{
		}

		// Token: 0x0403C5E2 RID: 247266
		[Token(Token = "0x403C5E2")]
		private const string TITLE_ID = "title_{0}";

		// Token: 0x0403C5E3 RID: 247267
		[Token(Token = "0x403C5E3")]
		private const string DESC_ID = "desc_{0}";

		// Token: 0x0403C5E4 RID: 247268
		[Token(Token = "0x403C5E4")]
		private const string NUMBER_ID = "num_{0}";

		// Token: 0x0403C5E5 RID: 247269
		[Token(Token = "0x403C5E5")]
		[FieldOffset(Offset = "0x10")]
		public int order;

		// Token: 0x0403C5E6 RID: 247270
		[Token(Token = "0x403C5E6")]
		[FieldOffset(Offset = "0x18")]
		public string blessing;

		// Token: 0x0403C5E7 RID: 247271
		[Token(Token = "0x403C5E7")]
		[FieldOffset(Offset = "0x20")]
		public long absolutData;

		// Token: 0x0403C5E8 RID: 247272
		[Token(Token = "0x403C5E8")]
		[FieldOffset(Offset = "0x28")]
		public string adTip;

		// Token: 0x0403C5E9 RID: 247273
		[Token(Token = "0x403C5E9")]
		[FieldOffset(Offset = "0x30")]
		public int relativeData;

		// Token: 0x0403C5EA RID: 247274
		[Token(Token = "0x403C5EA")]
		[FieldOffset(Offset = "0x38")]
		public List<ItemBundle> itemList;

		// Token: 0x0403C5EB RID: 247275
		[Token(Token = "0x403C5EB")]
		[FieldOffset(Offset = "0x40")]
		public Act33SignRedpackStatus status;

		// Token: 0x0403C5EC RID: 247276
		[Token(Token = "0x403C5EC")]
		[FieldOffset(Offset = "0x48")]
		public Func<string, Sprite> loadSpriteFunc;

		// Token: 0x0403C5ED RID: 247277
		[Token(Token = "0x403C5ED")]
		[FieldOffset(Offset = "0x50")]
		public string titleId;

		// Token: 0x0403C5EE RID: 247278
		[Token(Token = "0x403C5EE")]
		[FieldOffset(Offset = "0x58")]
		public string descId;

		// Token: 0x0403C5EF RID: 247279
		[Token(Token = "0x403C5EF")]
		[FieldOffset(Offset = "0x60")]
		public string numId;

		// Token: 0x0403C5F0 RID: 247280
		[Token(Token = "0x403C5F0")]
		[FieldOffset(Offset = "0x68")]
		public string extraTips;

		// Token: 0x0403C5F1 RID: 247281
		[Token(Token = "0x403C5F1")]
		[FieldOffset(Offset = "0x70")]
		public int daysLeftToCalm;

		// Token: 0x0403C5F2 RID: 247282
		[Token(Token = "0x403C5F2")]
		[FieldOffset(Offset = "0x74")]
		public bool absolutDatePass;

		// Token: 0x0403C5F3 RID: 247283
		[Token(Token = "0x403C5F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403C5F4 RID: 247284
		[Token(Token = "0x403C5F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
