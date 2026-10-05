using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E03 RID: 24067
	[Token(Token = "0x2005E03")]
	public class CharSelectBranchItemViewModel : IComparable<CharSelectBranchItemViewModel>
	{
		// Token: 0x06022E24 RID: 142884 RVA: 0x000BF4F0 File Offset: 0x000BD6F0
		[Token(Token = "0x6022E24")]
		[Address(RVA = "0x1D64C40", Offset = "0x1D63840", VA = "0x181D64C40", Slot = "4")]
		public int CompareTo(CharSelectBranchItemViewModel other)
		{
			return 0;
		}

		// Token: 0x06022E25 RID: 142885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E25")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharSelectBranchItemViewModel()
		{
		}

		// Token: 0x0403006F RID: 196719
		[Token(Token = "0x403006F")]
		[FieldOffset(Offset = "0x10")]
		public string equipId;

		// Token: 0x04030070 RID: 196720
		[Token(Token = "0x4030070")]
		[FieldOffset(Offset = "0x18")]
		public int equipLevel;

		// Token: 0x04030071 RID: 196721
		[Token(Token = "0x4030071")]
		[FieldOffset(Offset = "0x20")]
		public Sprite branchIcon;

		// Token: 0x04030072 RID: 196722
		[Token(Token = "0x4030072")]
		[FieldOffset(Offset = "0x28")]
		public string typeIcon;

		// Token: 0x04030073 RID: 196723
		[Token(Token = "0x4030073")]
		[FieldOffset(Offset = "0x30")]
		public string branchName;

		// Token: 0x04030074 RID: 196724
		[Token(Token = "0x4030074")]
		[FieldOffset(Offset = "0x38")]
		public string branchExtraName;

		// Token: 0x04030075 RID: 196725
		[Token(Token = "0x4030075")]
		[FieldOffset(Offset = "0x40")]
		public bool isAvailable;

		// Token: 0x04030076 RID: 196726
		[Token(Token = "0x4030076")]
		[FieldOffset(Offset = "0x44")]
		public UniEquipType equipType;

		// Token: 0x04030077 RID: 196727
		[Token(Token = "0x4030077")]
		[FieldOffset(Offset = "0x48")]
		public int sortOrder;
	}
}
