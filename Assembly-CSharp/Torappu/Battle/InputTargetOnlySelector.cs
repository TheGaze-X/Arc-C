using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002518 RID: 9496
	[Token(Token = "0x2002518")]
	public class InputTargetOnlySelector : RangeSelector
	{
		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x0600F501 RID: 62721 RVA: 0x0005AE28 File Offset: 0x00059028
		[Token(Token = "0x17001FEC")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F501")]
			[Address(RVA = "0x6CB060", Offset = "0x6C9C60", VA = "0x1806CB060", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x0600F502 RID: 62722 RVA: 0x0005AE40 File Offset: 0x00059040
		[Token(Token = "0x17001FED")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F502")]
			[Address(RVA = "0x6CB000", Offset = "0x6C9C00", VA = "0x1806CB000", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x0600F503 RID: 62723 RVA: 0x0005AE58 File Offset: 0x00059058
		[Token(Token = "0x17001FEE")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F503")]
			[Address(RVA = "0x6CAFA0", Offset = "0x6C9BA0", VA = "0x1806CAFA0", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x0600F504 RID: 62724 RVA: 0x0005AE70 File Offset: 0x00059070
		[Token(Token = "0x17001FEF")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F504")]
			[Address(RVA = "0x6CAF40", Offset = "0x6C9B40", VA = "0x1806CAF40", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F505 RID: 62725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F505")]
		[Address(RVA = "0x6CAC00", Offset = "0x6C9800", VA = "0x1806CAC00", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F506 RID: 62726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F506")]
		[Address(RVA = "0x6CABA0", Offset = "0x6C97A0", VA = "0x1806CABA0", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F507 RID: 62727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F507")]
		[Address(RVA = "0x6CAEC0", Offset = "0x6C9AC0", VA = "0x1806CAEC0")]
		public InputTargetOnlySelector()
		{
		}

		// Token: 0x04010F8D RID: 69517
		[Token(Token = "0x4010F8D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SideType _targetSide;

		// Token: 0x04010F8E RID: 69518
		[Token(Token = "0x4010F8E")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private MotionMask _targetMotion;

		// Token: 0x04010F8F RID: 69519
		[Token(Token = "0x4010F8F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private EntityCategory _targetCategory;

		// Token: 0x04010F90 RID: 69520
		[Token(Token = "0x4010F90")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private bool _ignoreTargetFree;

		// Token: 0x04010F91 RID: 69521
		[Token(Token = "0x4010F91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010F92 RID: 69522
		[Token(Token = "0x4010F92")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010F93 RID: 69523
		[Token(Token = "0x4010F93")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010F94 RID: 69524
		[Token(Token = "0x4010F94")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010F95 RID: 69525
		[Token(Token = "0x4010F95")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010F96 RID: 69526
		[Token(Token = "0x4010F96")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010F97 RID: 69527
		[Token(Token = "0x4010F97")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
