using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A2B RID: 23083
	[Token(Token = "0x2005A2B")]
	public class UIPortraitChooseCharCardViewModel : IHotfixable
	{
		// Token: 0x060219DA RID: 137690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219DA")]
		[Address(RVA = "0x1C146A0", Offset = "0x1C132A0", VA = "0x181C146A0")]
		public void LoadData(string charId)
		{
		}

		// Token: 0x060219DB RID: 137691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219DB")]
		[Address(RVA = "0x1C14900", Offset = "0x1C13500", VA = "0x181C14900")]
		public UIPortraitChooseCharCardViewModel()
		{
		}

		// Token: 0x0402DF5E RID: 188254
		[Token(Token = "0x402DF5E")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0402DF5F RID: 188255
		[Token(Token = "0x402DF5F")]
		[FieldOffset(Offset = "0x18")]
		public string charName;

		// Token: 0x0402DF60 RID: 188256
		[Token(Token = "0x402DF60")]
		[FieldOffset(Offset = "0x20")]
		public ProfessionCategory profession;

		// Token: 0x0402DF61 RID: 188257
		[Token(Token = "0x402DF61")]
		[FieldOffset(Offset = "0x24")]
		public RarityRank rarityRank;

		// Token: 0x0402DF62 RID: 188258
		[Token(Token = "0x402DF62")]
		[FieldOffset(Offset = "0x28")]
		public string portraitId;

		// Token: 0x0402DF63 RID: 188259
		[Token(Token = "0x402DF63")]
		[FieldOffset(Offset = "0x30")]
		public Color colorSelected;

		// Token: 0x0402DF64 RID: 188260
		[Token(Token = "0x402DF64")]
		[FieldOffset(Offset = "0x40")]
		public bool isOwned;

		// Token: 0x0402DF65 RID: 188261
		[Token(Token = "0x402DF65")]
		[FieldOffset(Offset = "0x44")]
		public int potentialRank;

		// Token: 0x0402DF66 RID: 188262
		[Token(Token = "0x402DF66")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402DF67 RID: 188263
		[Token(Token = "0x402DF67")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
