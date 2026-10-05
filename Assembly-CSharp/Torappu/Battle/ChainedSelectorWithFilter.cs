using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002509 RID: 9481
	[Token(Token = "0x2002509")]
	public class ChainedSelectorWithFilter : RangeSelector
	{
		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x0600F43B RID: 62523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001FD3")]
		private TargetValidator freeJumpValidator
		{
			[Token(Token = "0x600F43B")]
			[Address(RVA = "0x6BAA90", Offset = "0x6B9690", VA = "0x1806BAA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x0600F43C RID: 62524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001FD4")]
		private TargetValidator extraValidator
		{
			[Token(Token = "0x600F43C")]
			[Address(RVA = "0x6BAA20", Offset = "0x6B9620", VA = "0x1806BAA20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x0600F43D RID: 62525 RVA: 0x0005A258 File Offset: 0x00058458
		[Token(Token = "0x17001FD5")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F43D")]
			[Address(RVA = "0x6BACE0", Offset = "0x6B98E0", VA = "0x1806BACE0", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x0600F43E RID: 62526 RVA: 0x0005A270 File Offset: 0x00058470
		[Token(Token = "0x17001FD6")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F43E")]
			[Address(RVA = "0x6BAC80", Offset = "0x6B9880", VA = "0x1806BAC80", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x0600F43F RID: 62527 RVA: 0x0005A288 File Offset: 0x00058488
		[Token(Token = "0x17001FD7")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F43F")]
			[Address(RVA = "0x6BAC20", Offset = "0x6B9820", VA = "0x1806BAC20", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x0600F440 RID: 62528 RVA: 0x0005A2A0 File Offset: 0x000584A0
		[Token(Token = "0x17001FD8")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F440")]
			[Address(RVA = "0x6BABC0", Offset = "0x6B97C0", VA = "0x1806BABC0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x0600F441 RID: 62529 RVA: 0x0005A2B8 File Offset: 0x000584B8
		[Token(Token = "0x17001FD9")]
		protected override bool ignoreHealFree
		{
			[Token(Token = "0x600F441")]
			[Address(RVA = "0x6BAB60", Offset = "0x6B9760", VA = "0x1806BAB60", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x0600F442 RID: 62530 RVA: 0x0005A2D0 File Offset: 0x000584D0
		[Token(Token = "0x17001FDA")]
		protected override bool ignoreAllyTargetFree
		{
			[Token(Token = "0x600F442")]
			[Address(RVA = "0x6BAB00", Offset = "0x6B9700", VA = "0x1806BAB00", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F443 RID: 62531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F443")]
		[Address(RVA = "0x6BA250", Offset = "0x6B8E50", VA = "0x1806BA250", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F444 RID: 62532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F444")]
		[Address(RVA = "0x6B9B20", Offset = "0x6B8720", VA = "0x1806B9B20", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F445 RID: 62533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F445")]
		[Address(RVA = "0x6BA850", Offset = "0x6B9450", VA = "0x1806BA850")]
		private Entity _PickTarget(List<Entity> targets)
		{
			return null;
		}

		// Token: 0x0600F446 RID: 62534 RVA: 0x0005A2E8 File Offset: 0x000584E8
		[Token(Token = "0x600F446")]
		[Address(RVA = "0x6BA3D0", Offset = "0x6B8FD0", VA = "0x1806BA3D0", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F447 RID: 62535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F447")]
		[Address(RVA = "0x6BA190", Offset = "0x6B8D90", VA = "0x1806BA190", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F448 RID: 62536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F448")]
		[Address(RVA = "0x6BA1F0", Offset = "0x6B8DF0", VA = "0x1806BA1F0", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F449 RID: 62537 RVA: 0x0005A300 File Offset: 0x00058500
		[Token(Token = "0x600F449")]
		[Address(RVA = "0x6BA700", Offset = "0x6B9300", VA = "0x1806BA700")]
		private bool _IsFreeJump(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F44A RID: 62538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F44A")]
		[Address(RVA = "0x6BA570", Offset = "0x6B9170", VA = "0x1806BA570")]
		private void _InitValidatorsIfNot()
		{
		}

		// Token: 0x0600F44B RID: 62539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F44B")]
		[Address(RVA = "0x6BA960", Offset = "0x6B9560", VA = "0x1806BA960")]
		public ChainedSelectorWithFilter()
		{
		}

		// Token: 0x0600F44C RID: 62540 RVA: 0x0005A318 File Offset: 0x00058518
		[Token(Token = "0x600F44C")]
		[Address(RVA = "0x6A2E20", Offset = "0x6A1A20", VA = "0x1806A2E20")]
		private bool <>xLuaBaseProxy_get_ignoreHealFree()
		{
			return default(bool);
		}

		// Token: 0x0600F44D RID: 62541 RVA: 0x0005A330 File Offset: 0x00058530
		[Token(Token = "0x600F44D")]
		[Address(RVA = "0x6A2E10", Offset = "0x6A1A10", VA = "0x1806A2E10")]
		private bool <>xLuaBaseProxy_get_ignoreAllyTargetFree()
		{
			return default(bool);
		}

		// Token: 0x0600F44E RID: 62542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F44E")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F44F RID: 62543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F44F")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F450 RID: 62544 RVA: 0x0005A348 File Offset: 0x00058548
		[Token(Token = "0x600F450")]
		[Address(RVA = "0x6A2DC0", Offset = "0x6A19C0", VA = "0x1806A2DC0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010E71 RID: 69233
		[Token(Token = "0x4010E71")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SideType _targetSide;

		// Token: 0x04010E72 RID: 69234
		[Token(Token = "0x4010E72")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private MotionMask _targetMotion;

		// Token: 0x04010E73 RID: 69235
		[Token(Token = "0x4010E73")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private EntityCategory _targetCategory;

		// Token: 0x04010E74 RID: 69236
		[Token(Token = "0x4010E74")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private bool _ignoreTargetFree;

		// Token: 0x04010E75 RID: 69237
		[Token(Token = "0x4010E75")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int _maxTarget;

		// Token: 0x04010E76 RID: 69238
		[Token(Token = "0x4010E76")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private FilterUtil.FilterType _filterType;

		// Token: 0x04010E77 RID: 69239
		[Token(Token = "0x4010E77")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _useChainPrefix;

		// Token: 0x04010E78 RID: 69240
		[Token(Token = "0x4010E78")]
		[FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool _useAdditionalTargetCount;

		// Token: 0x04010E79 RID: 69241
		[Token(Token = "0x4010E79")]
		[FieldOffset(Offset = "0xBA")]
		[SerializeField]
		private bool _ignoreHealFree;

		// Token: 0x04010E7A RID: 69242
		[Token(Token = "0x4010E7A")]
		[FieldOffset(Offset = "0xBB")]
		[SerializeField]
		private bool _ignoreAllyTargetFree;

		// Token: 0x04010E7B RID: 69243
		[Token(Token = "0x4010E7B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TargetValidator _freeJumpValidator;

		// Token: 0x04010E7C RID: 69244
		[Token(Token = "0x4010E7C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TargetValidator _extraValidator;

		// Token: 0x04010E7D RID: 69245
		[Token(Token = "0x4010E7D")]
		[FieldOffset(Offset = "0xD0")]
		private List<Entity> m_targets;

		// Token: 0x04010E7E RID: 69246
		[Token(Token = "0x4010E7E")]
		[FieldOffset(Offset = "0xD8")]
		private Entity m_lastTarget;

		// Token: 0x04010E7F RID: 69247
		[Token(Token = "0x4010E7F")]
		[FieldOffset(Offset = "0xE0")]
		private int m_maxTarget;

		// Token: 0x04010E80 RID: 69248
		[Token(Token = "0x4010E80")]
		[FieldOffset(Offset = "0xE4")]
		private bool m_validatorInited;

		// Token: 0x04010E81 RID: 69249
		[Token(Token = "0x4010E81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_freeJumpValidator;

		// Token: 0x04010E82 RID: 69250
		[Token(Token = "0x4010E82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_extraValidator;

		// Token: 0x04010E83 RID: 69251
		[Token(Token = "0x4010E83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010E84 RID: 69252
		[Token(Token = "0x4010E84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010E85 RID: 69253
		[Token(Token = "0x4010E85")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010E86 RID: 69254
		[Token(Token = "0x4010E86")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010E87 RID: 69255
		[Token(Token = "0x4010E87")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ignoreHealFree;

		// Token: 0x04010E88 RID: 69256
		[Token(Token = "0x4010E88")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_ignoreAllyTargetFree;

		// Token: 0x04010E89 RID: 69257
		[Token(Token = "0x4010E89")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010E8A RID: 69258
		[Token(Token = "0x4010E8A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010E8B RID: 69259
		[Token(Token = "0x4010E8B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PickTarget;

		// Token: 0x04010E8C RID: 69260
		[Token(Token = "0x4010E8C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010E8D RID: 69261
		[Token(Token = "0x4010E8D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010E8E RID: 69262
		[Token(Token = "0x4010E8E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010E8F RID: 69263
		[Token(Token = "0x4010E8F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsFreeJump;

		// Token: 0x04010E90 RID: 69264
		[Token(Token = "0x4010E90")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitValidatorsIfNot;

		// Token: 0x04010E91 RID: 69265
		[Token(Token = "0x4010E91")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
