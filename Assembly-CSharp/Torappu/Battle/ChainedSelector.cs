using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002508 RID: 9480
	[Token(Token = "0x2002508")]
	public class ChainedSelector : RangeSelector
	{
		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x0600F42D RID: 62509 RVA: 0x0005A1C8 File Offset: 0x000583C8
		[Token(Token = "0x17001FCE")]
		private bool isAlly
		{
			[Token(Token = "0x600F42D")]
			[Address(RVA = "0x6BBC60", Offset = "0x6BA860", VA = "0x1806BBC60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x0600F42E RID: 62510 RVA: 0x0005A1E0 File Offset: 0x000583E0
		[Token(Token = "0x17001FCF")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F42E")]
			[Address(RVA = "0x6BBD80", Offset = "0x6BA980", VA = "0x1806BBD80", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x0600F42F RID: 62511 RVA: 0x0005A1F8 File Offset: 0x000583F8
		[Token(Token = "0x17001FD0")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F42F")]
			[Address(RVA = "0x6BBD20", Offset = "0x6BA920", VA = "0x1806BBD20", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x0600F430 RID: 62512 RVA: 0x0005A210 File Offset: 0x00058410
		[Token(Token = "0x17001FD1")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F430")]
			[Address(RVA = "0x6BBCC0", Offset = "0x6BA8C0", VA = "0x1806BBCC0", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x0600F431 RID: 62513 RVA: 0x0005A228 File Offset: 0x00058428
		[Token(Token = "0x17001FD2")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F431")]
			[Address(RVA = "0x6BBC00", Offset = "0x6BA800", VA = "0x1806BBC00", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F432 RID: 62514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F432")]
		[Address(RVA = "0x6BB510", Offset = "0x6BA110", VA = "0x1806BB510", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F433 RID: 62515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F433")]
		[Address(RVA = "0x6BAD40", Offset = "0x6B9940", VA = "0x1806BAD40", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F434 RID: 62516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F434")]
		[Address(RVA = "0x6BB4B0", Offset = "0x6BA0B0", VA = "0x1806BB4B0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F435 RID: 62517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F435")]
		[Address(RVA = "0x6BB450", Offset = "0x6BA050", VA = "0x1806BB450", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F436 RID: 62518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F436")]
		[Address(RVA = "0x6BB350", Offset = "0x6B9F50", VA = "0x1806BB350")]
		private Entity FindNearestTarget(List<Entity> targets, Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F437 RID: 62519 RVA: 0x0005A240 File Offset: 0x00058440
		[Token(Token = "0x600F437")]
		[Address(RVA = "0x6BB610", Offset = "0x6BA210", VA = "0x1806BB610")]
		private int _GetNearestTargetIndex(List<Entity> targets, Vector2 center)
		{
			return 0;
		}

		// Token: 0x0600F438 RID: 62520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F438")]
		[Address(RVA = "0x6BBB10", Offset = "0x6BA710", VA = "0x1806BBB10")]
		public ChainedSelector()
		{
		}

		// Token: 0x0600F439 RID: 62521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F439")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F43A RID: 62522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F43A")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010E5A RID: 69210
		[Token(Token = "0x4010E5A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SideType _targetSide;

		// Token: 0x04010E5B RID: 69211
		[Token(Token = "0x4010E5B")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private MotionMask _targetMotion;

		// Token: 0x04010E5C RID: 69212
		[Token(Token = "0x4010E5C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private EntityCategory _targetCategory;

		// Token: 0x04010E5D RID: 69213
		[Token(Token = "0x4010E5D")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private bool _ignoreTargetFree;

		// Token: 0x04010E5E RID: 69214
		[Token(Token = "0x4010E5E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int _maxTarget;

		// Token: 0x04010E5F RID: 69215
		[Token(Token = "0x4010E5F")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Inspect("isAlly")]
		protected bool _excludeOwner;

		// Token: 0x04010E60 RID: 69216
		[Token(Token = "0x4010E60")]
		[FieldOffset(Offset = "0xB5")]
		[SerializeField]
		private bool _useChainPrefix;

		// Token: 0x04010E61 RID: 69217
		[Token(Token = "0x4010E61")]
		[FieldOffset(Offset = "0xB6")]
		[SerializeField]
		private bool _fixAllowRepetitionIfNoTarget;

		// Token: 0x04010E62 RID: 69218
		[Token(Token = "0x4010E62")]
		[FieldOffset(Offset = "0xB8")]
		private List<Entity> m_targets;

		// Token: 0x04010E63 RID: 69219
		[Token(Token = "0x4010E63")]
		[FieldOffset(Offset = "0xC0")]
		private List<Entity> m_repeatTargets;

		// Token: 0x04010E64 RID: 69220
		[Token(Token = "0x4010E64")]
		[FieldOffset(Offset = "0xC8")]
		private int m_maxTarget;

		// Token: 0x04010E65 RID: 69221
		[Token(Token = "0x4010E65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAlly;

		// Token: 0x04010E66 RID: 69222
		[Token(Token = "0x4010E66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010E67 RID: 69223
		[Token(Token = "0x4010E67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010E68 RID: 69224
		[Token(Token = "0x4010E68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010E69 RID: 69225
		[Token(Token = "0x4010E69")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010E6A RID: 69226
		[Token(Token = "0x4010E6A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010E6B RID: 69227
		[Token(Token = "0x4010E6B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010E6C RID: 69228
		[Token(Token = "0x4010E6C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010E6D RID: 69229
		[Token(Token = "0x4010E6D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010E6E RID: 69230
		[Token(Token = "0x4010E6E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FindNearestTarget;

		// Token: 0x04010E6F RID: 69231
		[Token(Token = "0x4010E6F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetNearestTargetIndex;

		// Token: 0x04010E70 RID: 69232
		[Token(Token = "0x4010E70")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
