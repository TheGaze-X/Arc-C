using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076F4 RID: 30452
	[Token(Token = "0x20076F4")]
	public struct Act1VHalfIdleAttrInfoPatchBuilder : ICharInfoPatchBuilder<Act1VHalfIdleBasicCharInfo>, IHotfixable
	{
		// Token: 0x17006473 RID: 25715
		// (get) Token: 0x0602ACA4 RID: 175268 RVA: 0x000DA058 File Offset: 0x000D8258
		[Token(Token = "0x17006473")]
		public bool isEmpty
		{
			[Token(Token = "0x602ACA4")]
			[Address(RVA = "0x26815A0", Offset = "0x26801A0", VA = "0x1826815A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602ACA5 RID: 175269 RVA: 0x000DA070 File Offset: 0x000D8270
		[Token(Token = "0x602ACA5")]
		[Address(RVA = "0x26813E0", Offset = "0x267FFE0", VA = "0x1826813E0")]
		public static Act1VHalfIdleAttrInfoPatchBuilder ParseFromActData(CharQuery charQuery, ICharIdentityInfo identityInfo, ICharEquipInfo equipInfo)
		{
			return default(Act1VHalfIdleAttrInfoPatchBuilder);
		}

		// Token: 0x0602ACA6 RID: 175270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACA6")]
		[Address(RVA = "0x2681330", Offset = "0x267FF30", VA = "0x182681330", Slot = "5")]
		public Act1VHalfIdleBasicCharInfo BuildTo(Act1VHalfIdleBasicCharInfo characterInfo)
		{
			return null;
		}

		// Token: 0x0403DAA0 RID: 252576
		[Token(Token = "0x403DAA0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Act1VHalfIdleAttrInfoPatchBuilder EMPTY;

		// Token: 0x0403DAA1 RID: 252577
		[Token(Token = "0x403DAA1")]
		[FieldOffset(Offset = "0x0")]
		public BasicCharInfoModel.DefaultAttrInfoPatchBuilder defaultBuilder;

		// Token: 0x0403DAA2 RID: 252578
		[Token(Token = "0x403DAA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403DAA3 RID: 252579
		[Token(Token = "0x403DAA3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseFromActData;

		// Token: 0x0403DAA4 RID: 252580
		[Token(Token = "0x403DAA4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BuildTo;
	}
}
