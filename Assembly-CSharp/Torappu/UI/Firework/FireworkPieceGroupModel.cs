using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E2A RID: 20010
	[Token(Token = "0x2004E2A")]
	public class FireworkPieceGroupModel : IHotfixable
	{
		// Token: 0x0601DE47 RID: 122439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE47")]
		[Address(RVA = "0x1769BD0", Offset = "0x17687D0", VA = "0x181769BD0")]
		public void LoadData()
		{
		}

		// Token: 0x0601DE48 RID: 122440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE48")]
		[Address(RVA = "0x1769CC0", Offset = "0x17688C0", VA = "0x181769CC0")]
		public FireworkPieceGroupModel()
		{
		}

		// Token: 0x04027A57 RID: 162391
		[Token(Token = "0x4027A57")]
		[FieldOffset(Offset = "0x10")]
		public string platePieceId;

		// Token: 0x04027A58 RID: 162392
		[Token(Token = "0x4027A58")]
		[FieldOffset(Offset = "0x18")]
		public int platePieceSortId;

		// Token: 0x04027A59 RID: 162393
		[Token(Token = "0x4027A59")]
		[FieldOffset(Offset = "0x1C")]
		public int platePieceCount;

		// Token: 0x04027A5A RID: 162394
		[Token(Token = "0x4027A5A")]
		[FieldOffset(Offset = "0x20")]
		public List<FireworkData.PlateSlotData> plateSlotDataList;

		// Token: 0x04027A5B RID: 162395
		[Token(Token = "0x4027A5B")]
		[FieldOffset(Offset = "0x28")]
		public FireworkData.FireworkDirectionType directionType;

		// Token: 0x04027A5C RID: 162396
		[Token(Token = "0x4027A5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027A5D RID: 162397
		[Token(Token = "0x4027A5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
