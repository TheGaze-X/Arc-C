using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054AE RID: 21678
	[Token(Token = "0x20054AE")]
	public class RoguelikeCharSelectBranchItemViewModel : IComparable<RoguelikeCharSelectBranchItemViewModel>
	{
		// Token: 0x0601FE42 RID: 130626 RVA: 0x000B3AF0 File Offset: 0x000B1CF0
		[Token(Token = "0x601FE42")]
		[Address(RVA = "0x1A00EF0", Offset = "0x19FFAF0", VA = "0x181A00EF0", Slot = "4")]
		public int CompareTo(RoguelikeCharSelectBranchItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0601FE43 RID: 130627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE43")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeCharSelectBranchItemViewModel()
		{
		}

		// Token: 0x0402B02A RID: 176170
		[Token(Token = "0x402B02A")]
		[FieldOffset(Offset = "0x10")]
		public string equipId;

		// Token: 0x0402B02B RID: 176171
		[Token(Token = "0x402B02B")]
		[FieldOffset(Offset = "0x18")]
		public int equipLevel;

		// Token: 0x0402B02C RID: 176172
		[Token(Token = "0x402B02C")]
		[FieldOffset(Offset = "0x20")]
		public Sprite branchIcon;

		// Token: 0x0402B02D RID: 176173
		[Token(Token = "0x402B02D")]
		[FieldOffset(Offset = "0x28")]
		public string branchName;

		// Token: 0x0402B02E RID: 176174
		[Token(Token = "0x402B02E")]
		[FieldOffset(Offset = "0x30")]
		public string branchExtraName;

		// Token: 0x0402B02F RID: 176175
		[Token(Token = "0x402B02F")]
		[FieldOffset(Offset = "0x38")]
		public bool isAvailable;

		// Token: 0x0402B030 RID: 176176
		[Token(Token = "0x402B030")]
		[FieldOffset(Offset = "0x3C")]
		public UniEquipType equipType;

		// Token: 0x0402B031 RID: 176177
		[Token(Token = "0x402B031")]
		[FieldOffset(Offset = "0x40")]
		public int sortOrder;
	}
}
