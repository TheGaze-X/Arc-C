using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterCommon
{
	// Token: 0x02005FD0 RID: 24528
	[Token(Token = "0x2005FD0")]
	public class CharacterUniEquipViewModel : IComparable<CharacterUniEquipViewModel>
	{
		// Token: 0x0602376A RID: 145258 RVA: 0x000C0F30 File Offset: 0x000BF130
		[Token(Token = "0x602376A")]
		[Address(RVA = "0x173B1B0", Offset = "0x1739DB0", VA = "0x18173B1B0", Slot = "4")]
		public int CompareTo(CharacterUniEquipViewModel other)
		{
			return 0;
		}

		// Token: 0x0602376B RID: 145259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602376B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharacterUniEquipViewModel()
		{
		}

		// Token: 0x040310E6 RID: 200934
		[Token(Token = "0x40310E6")]
		[FieldOffset(Offset = "0x10")]
		public UniEquipData data;

		// Token: 0x040310E7 RID: 200935
		[Token(Token = "0x40310E7")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x040310E8 RID: 200936
		[Token(Token = "0x40310E8")]
		[FieldOffset(Offset = "0x1C")]
		public bool isShow;

		// Token: 0x040310E9 RID: 200937
		[Token(Token = "0x40310E9")]
		[FieldOffset(Offset = "0x1D")]
		public bool isUnlock;

		// Token: 0x040310EA RID: 200938
		[Token(Token = "0x40310EA")]
		[FieldOffset(Offset = "0x1E")]
		public bool isEquip;

		// Token: 0x040310EB RID: 200939
		[Token(Token = "0x40310EB")]
		[FieldOffset(Offset = "0x20")]
		public int sortOrder;
	}
}
