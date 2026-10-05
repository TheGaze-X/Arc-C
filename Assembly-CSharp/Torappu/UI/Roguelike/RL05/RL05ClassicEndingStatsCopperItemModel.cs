using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200557E RID: 21886
	[Token(Token = "0x200557E")]
	public class RL05ClassicEndingStatsCopperItemModel
	{
		// Token: 0x0602028A RID: 131722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602028A")]
		[Address(RVA = "0x1A33A20", Offset = "0x1A32620", VA = "0x181A33A20")]
		public void InitData(string topicId, string copperItemId, bool isInBag)
		{
		}

		// Token: 0x0602028B RID: 131723 RVA: 0x000B4D98 File Offset: 0x000B2F98
		[Token(Token = "0x602028B")]
		[Address(RVA = "0x1A33A00", Offset = "0x1A32600", VA = "0x181A33A00")]
		public int GetSortId()
		{
			return 0;
		}

		// Token: 0x0602028C RID: 131724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602028C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL05ClassicEndingStatsCopperItemModel()
		{
		}

		// Token: 0x0402B710 RID: 177936
		[Token(Token = "0x402B710")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeGameCopperItemViewModel itemModel;

		// Token: 0x0402B711 RID: 177937
		[Token(Token = "0x402B711")]
		[FieldOffset(Offset = "0x18")]
		public bool isInBag;

		// Token: 0x0402B712 RID: 177938
		[Token(Token = "0x402B712")]
		[FieldOffset(Offset = "0x1C")]
		public int number;
	}
}
