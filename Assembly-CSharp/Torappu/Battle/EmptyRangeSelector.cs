using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200250A RID: 9482
	[Token(Token = "0x200250A")]
	public class EmptyRangeSelector : RangeSelector
	{
		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x0600F451 RID: 62545 RVA: 0x0005A360 File Offset: 0x00058560
		[Token(Token = "0x17001FDB")]
		public bool limitTargetNum
		{
			[Token(Token = "0x600F451")]
			[Address(RVA = "0x6BBF60", Offset = "0x6BAB60", VA = "0x1806BBF60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x0600F452 RID: 62546 RVA: 0x0005A378 File Offset: 0x00058578
		[Token(Token = "0x17001FDC")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F452")]
			[Address(RVA = "0x6BC0E0", Offset = "0x6BACE0", VA = "0x1806BC0E0", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x0600F453 RID: 62547 RVA: 0x0005A390 File Offset: 0x00058590
		[Token(Token = "0x17001FDD")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F453")]
			[Address(RVA = "0x6BC080", Offset = "0x6BAC80", VA = "0x1806BC080", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x0600F454 RID: 62548 RVA: 0x0005A3A8 File Offset: 0x000585A8
		[Token(Token = "0x17001FDE")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F454")]
			[Address(RVA = "0x6BC020", Offset = "0x6BAC20", VA = "0x1806BC020", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x0600F455 RID: 62549 RVA: 0x0005A3C0 File Offset: 0x000585C0
		[Token(Token = "0x17001FDF")]
		protected int maxTargetNum
		{
			[Token(Token = "0x600F455")]
			[Address(RVA = "0x6BBFC0", Offset = "0x6BABC0", VA = "0x1806BBFC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x0600F456 RID: 62550 RVA: 0x0005A3D8 File Offset: 0x000585D8
		[Token(Token = "0x17001FE0")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F456")]
			[Address(RVA = "0x6BBF00", Offset = "0x6BAB00", VA = "0x1806BBF00", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F457 RID: 62551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F457")]
		[Address(RVA = "0x6BBE40", Offset = "0x6BAA40", VA = "0x1806BBE40", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F458 RID: 62552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F458")]
		[Address(RVA = "0x6BBDE0", Offset = "0x6BA9E0", VA = "0x1806BBDE0", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F459 RID: 62553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F459")]
		[Address(RVA = "0x6BBEA0", Offset = "0x6BAAA0", VA = "0x1806BBEA0")]
		public EmptyRangeSelector()
		{
		}

		// Token: 0x04010E92 RID: 69266
		[Token(Token = "0x4010E92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_limitTargetNum;

		// Token: 0x04010E93 RID: 69267
		[Token(Token = "0x4010E93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010E94 RID: 69268
		[Token(Token = "0x4010E94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010E95 RID: 69269
		[Token(Token = "0x4010E95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010E96 RID: 69270
		[Token(Token = "0x4010E96")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxTargetNum;

		// Token: 0x04010E97 RID: 69271
		[Token(Token = "0x4010E97")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010E98 RID: 69272
		[Token(Token = "0x4010E98")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010E99 RID: 69273
		[Token(Token = "0x4010E99")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010E9A RID: 69274
		[Token(Token = "0x4010E9A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
