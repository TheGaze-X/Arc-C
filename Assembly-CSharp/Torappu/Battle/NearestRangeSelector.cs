using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002519 RID: 9497
	[Token(Token = "0x2002519")]
	public class NearestRangeSelector : RangeSelector
	{
		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x0600F508 RID: 62728 RVA: 0x0005AE88 File Offset: 0x00059088
		[Token(Token = "0x17001FF0")]
		private bool IsLimitTargetNum
		{
			[Token(Token = "0x600F508")]
			[Address(RVA = "0x6CB5A0", Offset = "0x6CA1A0", VA = "0x1806CB5A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x0600F509 RID: 62729 RVA: 0x0005AEA0 File Offset: 0x000590A0
		[Token(Token = "0x17001FF1")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F509")]
			[Address(RVA = "0x6CB720", Offset = "0x6CA320", VA = "0x1806CB720", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x0600F50A RID: 62730 RVA: 0x0005AEB8 File Offset: 0x000590B8
		[Token(Token = "0x17001FF2")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F50A")]
			[Address(RVA = "0x6CB6C0", Offset = "0x6CA2C0", VA = "0x1806CB6C0", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x0600F50B RID: 62731 RVA: 0x0005AED0 File Offset: 0x000590D0
		[Token(Token = "0x17001FF3")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F50B")]
			[Address(RVA = "0x6CB660", Offset = "0x6CA260", VA = "0x1806CB660", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x0600F50C RID: 62732 RVA: 0x0005AEE8 File Offset: 0x000590E8
		[Token(Token = "0x17001FF4")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F50C")]
			[Address(RVA = "0x6CB600", Offset = "0x6CA200", VA = "0x1806CB600", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F50D RID: 62733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F50D")]
		[Address(RVA = "0x6CB460", Offset = "0x6CA060", VA = "0x1806CB460", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F50E RID: 62734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F50E")]
		[Address(RVA = "0x6CB0C0", Offset = "0x6C9CC0", VA = "0x1806CB0C0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F50F RID: 62735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F50F")]
		[Address(RVA = "0x6CB400", Offset = "0x6CA000", VA = "0x1806CB400", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F510 RID: 62736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F510")]
		[Address(RVA = "0x6CB3A0", Offset = "0x6C9FA0", VA = "0x1806CB3A0", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F511 RID: 62737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F511")]
		[Address(RVA = "0x6CB530", Offset = "0x6CA130", VA = "0x1806CB530")]
		public NearestRangeSelector()
		{
		}

		// Token: 0x0600F512 RID: 62738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F512")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F513 RID: 62739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F513")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010F98 RID: 69528
		[Token(Token = "0x4010F98")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SideType _targetSide;

		// Token: 0x04010F99 RID: 69529
		[Token(Token = "0x4010F99")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private MotionMask _targetMotion;

		// Token: 0x04010F9A RID: 69530
		[Token(Token = "0x4010F9A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private EntityCategory _targetCategory;

		// Token: 0x04010F9B RID: 69531
		[Token(Token = "0x4010F9B")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private bool _ignoreTargetFree;

		// Token: 0x04010F9C RID: 69532
		[Token(Token = "0x4010F9C")]
		[FieldOffset(Offset = "0xAD")]
		[SerializeField]
		private bool _limitTargetNum;

		// Token: 0x04010F9D RID: 69533
		[Token(Token = "0x4010F9D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Inspect("IsLimitTargetNum")]
		private int _maxTargetNum;

		// Token: 0x04010F9E RID: 69534
		[Token(Token = "0x4010F9E")]
		[FieldOffset(Offset = "0xB4")]
		private int m_maxTargetNum;

		// Token: 0x04010F9F RID: 69535
		[Token(Token = "0x4010F9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_IsLimitTargetNum;

		// Token: 0x04010FA0 RID: 69536
		[Token(Token = "0x4010FA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010FA1 RID: 69537
		[Token(Token = "0x4010FA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010FA2 RID: 69538
		[Token(Token = "0x4010FA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010FA3 RID: 69539
		[Token(Token = "0x4010FA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010FA4 RID: 69540
		[Token(Token = "0x4010FA4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010FA5 RID: 69541
		[Token(Token = "0x4010FA5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010FA6 RID: 69542
		[Token(Token = "0x4010FA6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010FA7 RID: 69543
		[Token(Token = "0x4010FA7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010FA8 RID: 69544
		[Token(Token = "0x4010FA8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
