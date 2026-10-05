using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076F6 RID: 30454
	[Token(Token = "0x20076F6")]
	public struct Act1VHalfIdleDetailInfoPatchBuilder : ICharInfoPatchBuilder<Act1VHalfIdleBasicCharInfo>, IHotfixable
	{
		// Token: 0x17006475 RID: 25717
		// (get) Token: 0x0602ACAF RID: 175279 RVA: 0x000DA0B8 File Offset: 0x000D82B8
		[Token(Token = "0x17006475")]
		public bool isEmpty
		{
			[Token(Token = "0x602ACAF")]
			[Address(RVA = "0x2686190", Offset = "0x2684D90", VA = "0x182686190", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602ACB0 RID: 175280 RVA: 0x000DA0D0 File Offset: 0x000D82D0
		[Token(Token = "0x602ACB0")]
		[Address(RVA = "0x2685E30", Offset = "0x2684A30", VA = "0x182685E30")]
		public static Act1VHalfIdleDetailInfoPatchBuilder ParseFromActData(ICharIdentityInfo identityInfo, CharQuery charQuery, CharacterData charData, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType)
		{
			return default(Act1VHalfIdleDetailInfoPatchBuilder);
		}

		// Token: 0x0602ACB1 RID: 175281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACB1")]
		[Address(RVA = "0x2685D40", Offset = "0x2684940", VA = "0x182685D40", Slot = "5")]
		public Act1VHalfIdleBasicCharInfo BuildTo(Act1VHalfIdleBasicCharInfo characterInfo)
		{
			return null;
		}

		// Token: 0x0403DAB1 RID: 252593
		[Token(Token = "0x403DAB1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Act1VHalfIdleDetailInfoPatchBuilder EMPTY;

		// Token: 0x0403DAB2 RID: 252594
		[Token(Token = "0x403DAB2")]
		[FieldOffset(Offset = "0x0")]
		public BasicCharInfoModel.DefaultDetailInfoPatchBuilder defaultBuilder;

		// Token: 0x0403DAB3 RID: 252595
		[Token(Token = "0x403DAB3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403DAB4 RID: 252596
		[Token(Token = "0x403DAB4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ParseFromActData;

		// Token: 0x0403DAB5 RID: 252597
		[Token(Token = "0x403DAB5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_BuildTo;
	}
}
