using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.TPhysic2D;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025F8 RID: 9720
	[Token(Token = "0x20025F8")]
	[SelectionBase]
	public class GiantTrap : BossHudTrap
	{
		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x0600FD3B RID: 64827 RVA: 0x0005FC70 File Offset: 0x0005DE70
		[Token(Token = "0x1700220B")]
		public override float blockRadiusSquare
		{
			[Token(Token = "0x600FD3B")]
			[Address(RVA = "0x757DF0", Offset = "0x7569F0", VA = "0x180757DF0", Slot = "204")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x0600FD3C RID: 64828 RVA: 0x0005FC88 File Offset: 0x0005DE88
		[Token(Token = "0x1700220C")]
		public override TCircle blockCircle
		{
			[Token(Token = "0x600FD3C")]
			[Address(RVA = "0x757D40", Offset = "0x756940", VA = "0x180757D40", Slot = "205")]
			get
			{
				return default(TCircle);
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x0600FD3D RID: 64829 RVA: 0x0005FCA0 File Offset: 0x0005DEA0
		[Token(Token = "0x1700220D")]
		public override float minBlockDistToTarget
		{
			[Token(Token = "0x600FD3D")]
			[Address(RVA = "0x757F10", Offset = "0x756B10", VA = "0x180757F10", Slot = "206")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x0600FD3E RID: 64830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700220E")]
		public List<Vector2> locatePositions
		{
			[Token(Token = "0x600FD3E")]
			[Address(RVA = "0x757EB0", Offset = "0x756AB0", VA = "0x180757EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x0600FD3F RID: 64831 RVA: 0x0005FCB8 File Offset: 0x0005DEB8
		[Token(Token = "0x1700220F")]
		public override Vector2 hudOffset
		{
			[Token(Token = "0x600FD3F")]
			[Address(RVA = "0x757E50", Offset = "0x756A50", VA = "0x180757E50", Slot = "164")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600FD40 RID: 64832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD40")]
		[Address(RVA = "0x757290", Offset = "0x755E90", VA = "0x180757290", Slot = "212")]
		public override void LocateOnTile(Tile tile, bool spawnManually)
		{
		}

		// Token: 0x0600FD41 RID: 64833 RVA: 0x0005FCD0 File Offset: 0x0005DED0
		[Token(Token = "0x600FD41")]
		[Address(RVA = "0x757B90", Offset = "0x756790", VA = "0x180757B90")]
		private bool _CheckShouldAdjustColliderData()
		{
			return default(bool);
		}

		// Token: 0x0600FD42 RID: 64834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD42")]
		[Address(RVA = "0x757910", Offset = "0x756510", VA = "0x180757910", Slot = "119")]
		protected override void OnFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600FD43 RID: 64835 RVA: 0x0005FCE8 File Offset: 0x0005DEE8
		[Token(Token = "0x600FD43")]
		[Address(RVA = "0x757080", Offset = "0x755C80", VA = "0x180757080", Slot = "213")]
		public override bool CheckInBlockRange(Entity target, float shrink = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600FD44 RID: 64836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD44")]
		[Address(RVA = "0x757C40", Offset = "0x756840", VA = "0x180757C40")]
		public GiantTrap()
		{
		}

		// Token: 0x0600FD45 RID: 64837 RVA: 0x0005FD00 File Offset: 0x0005DF00
		[Token(Token = "0x600FD45")]
		[Address(RVA = "0x757A90", Offset = "0x756690", VA = "0x180757A90")]
		private float <>xLuaBaseProxy_get_blockRadiusSquare()
		{
			return 0f;
		}

		// Token: 0x0600FD46 RID: 64838 RVA: 0x0005FD18 File Offset: 0x0005DF18
		[Token(Token = "0x600FD46")]
		[Address(RVA = "0x757A60", Offset = "0x756660", VA = "0x180757A60")]
		private TCircle <>xLuaBaseProxy_get_blockCircle()
		{
			return default(TCircle);
		}

		// Token: 0x0600FD47 RID: 64839 RVA: 0x0005FD30 File Offset: 0x0005DF30
		[Token(Token = "0x600FD47")]
		[Address(RVA = "0x757B80", Offset = "0x756780", VA = "0x180757B80")]
		private float <>xLuaBaseProxy_get_minBlockDistToTarget()
		{
			return 0f;
		}

		// Token: 0x0600FD48 RID: 64840 RVA: 0x0005FD48 File Offset: 0x0005DF48
		[Token(Token = "0x600FD48")]
		[Address(RVA = "0x757AF0", Offset = "0x7566F0", VA = "0x180757AF0")]
		private Vector2 <>xLuaBaseProxy_get_hudOffset()
		{
			return default(Vector2);
		}

		// Token: 0x0600FD49 RID: 64841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD49")]
		[Address(RVA = "0x757A40", Offset = "0x756640", VA = "0x180757A40")]
		private void <>xLuaBaseProxy_LocateOnTile(Tile P0, bool P1)
		{
		}

		// Token: 0x0600FD4A RID: 64842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD4A")]
		[Address(RVA = "0x757A50", Offset = "0x756650", VA = "0x180757A50")]
		private void <>xLuaBaseProxy_OnFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600FD4B RID: 64843 RVA: 0x0005FD60 File Offset: 0x0005DF60
		[Token(Token = "0x600FD4B")]
		[Address(RVA = "0x757A30", Offset = "0x756630", VA = "0x180757A30")]
		private bool <>xLuaBaseProxy_CheckInBlockRange(Entity P0, float P1)
		{
			return default(bool);
		}

		// Token: 0x04011971 RID: 72049
		[Token(Token = "0x4011971")]
		[FieldOffset(Offset = "0x5C0")]
		[SerializeField]
		private Vector2 _locateRangeOffset;

		// Token: 0x04011972 RID: 72050
		[Token(Token = "0x4011972")]
		[FieldOffset(Offset = "0x5C8")]
		[SerializeField]
		private float _minBlockDistToTarget;

		// Token: 0x04011973 RID: 72051
		[Token(Token = "0x4011973")]
		[FieldOffset(Offset = "0x5D0")]
		[SerializeField]
		private GiantTrap.DirectionColliderData m_defaultColliderDatas;

		// Token: 0x04011974 RID: 72052
		[Token(Token = "0x4011974")]
		[FieldOffset(Offset = "0x5D8")]
		[SerializeField]
		private List<GiantTrap.DirectionColliderData> m_directionColliderDatas;

		// Token: 0x04011975 RID: 72053
		[Token(Token = "0x4011975")]
		[FieldOffset(Offset = "0x5E0")]
		private List<Vector2> m_locatePositions;

		// Token: 0x04011976 RID: 72054
		[Token(Token = "0x4011976")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_blockRadiusSquare;

		// Token: 0x04011977 RID: 72055
		[Token(Token = "0x4011977")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_blockCircle;

		// Token: 0x04011978 RID: 72056
		[Token(Token = "0x4011978")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_minBlockDistToTarget;

		// Token: 0x04011979 RID: 72057
		[Token(Token = "0x4011979")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_locatePositions;

		// Token: 0x0401197A RID: 72058
		[Token(Token = "0x401197A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hudOffset;

		// Token: 0x0401197B RID: 72059
		[Token(Token = "0x401197B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LocateOnTile;

		// Token: 0x0401197C RID: 72060
		[Token(Token = "0x401197C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckShouldAdjustColliderData;

		// Token: 0x0401197D RID: 72061
		[Token(Token = "0x401197D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0401197E RID: 72062
		[Token(Token = "0x401197E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckInBlockRange;

		// Token: 0x0401197F RID: 72063
		[Token(Token = "0x401197F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020025F9 RID: 9721
		[Token(Token = "0x20025F9")]
		[Serializable]
		public class DirectionColliderData
		{
			// Token: 0x0600FD4C RID: 64844 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FD4C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DirectionColliderData()
			{
			}

			// Token: 0x04011980 RID: 72064
			[Token(Token = "0x4011980")]
			[FieldOffset(Offset = "0x10")]
			public SharedConsts.Direction direction;

			// Token: 0x04011981 RID: 72065
			[Token(Token = "0x4011981")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 offset;

			// Token: 0x04011982 RID: 72066
			[Token(Token = "0x4011982")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 size;
		}
	}
}
