using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D0 RID: 10704
	[Token(Token = "0x20029D0")]
	public class AttachToTarget : BasicMovement
	{
		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x06011BDB RID: 72667 RVA: 0x0006CA98 File Offset: 0x0006AC98
		[Token(Token = "0x17002721")]
		protected bool delayAfterReached
		{
			[Token(Token = "0x6011BDB")]
			[Address(RVA = "0x9975C0", Offset = "0x9961C0", VA = "0x1809975C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x06011BDC RID: 72668 RVA: 0x0006CAB0 File Offset: 0x0006ACB0
		[Token(Token = "0x17002722")]
		private bool attachToMountPoint
		{
			[Token(Token = "0x6011BDC")]
			[Address(RVA = "0x997560", Offset = "0x996160", VA = "0x180997560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x06011BDD RID: 72669 RVA: 0x0006CAC8 File Offset: 0x0006ACC8
		[Token(Token = "0x17002723")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011BDD")]
			[Address(RVA = "0x997620", Offset = "0x996220", VA = "0x180997620", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011BDE RID: 72670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BDE")]
		[Address(RVA = "0x996D20", Offset = "0x995920", VA = "0x180996D20", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011BDF RID: 72671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BDF")]
		[Address(RVA = "0x9967B0", Offset = "0x9953B0", VA = "0x1809967B0", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011BE0 RID: 72672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BE0")]
		[Address(RVA = "0x9973D0", Offset = "0x995FD0", VA = "0x1809973D0")]
		private void _OnBeforeAppearOrDisappear(object arg)
		{
		}

		// Token: 0x06011BE1 RID: 72673 RVA: 0x0006CAE0 File Offset: 0x0006ACE0
		[Token(Token = "0x6011BE1")]
		[Address(RVA = "0x996720", Offset = "0x995320", VA = "0x180996720", Slot = "22")]
		protected override bool DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011BE2 RID: 72674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BE2")]
		[Address(RVA = "0x996BD0", Offset = "0x9957D0", VA = "0x180996BD0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011BE3 RID: 72675 RVA: 0x0006CAF8 File Offset: 0x0006ACF8
		[Token(Token = "0x6011BE3")]
		[Address(RVA = "0x996640", Offset = "0x995240", VA = "0x180996640")]
		protected bool CheckStartTick(float deltaTime)
		{
			return default(bool);
		}

		// Token: 0x06011BE4 RID: 72676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BE4")]
		[Address(RVA = "0x9974C0", Offset = "0x9960C0", VA = "0x1809974C0")]
		public AttachToTarget()
		{
		}

		// Token: 0x06011BE5 RID: 72677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BE5")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011BE6 RID: 72678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BE6")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011BE7 RID: 72679 RVA: 0x0006CB10 File Offset: 0x0006AD10
		[Token(Token = "0x6011BE7")]
		[Address(RVA = "0x97EC10", Offset = "0x97D810", VA = "0x18097EC10")]
		private bool <>xLuaBaseProxy_DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011BE8 RID: 72680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011BE8")]
		[Address(RVA = "0x9973C0", Offset = "0x995FC0", VA = "0x1809973C0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013E62 RID: 81506
		[Token(Token = "0x4013E62")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _keepUpdate;

		// Token: 0x04013E63 RID: 81507
		[Token(Token = "0x4013E63")]
		[FieldOffset(Offset = "0xA9")]
		[SerializeField]
		private bool _attachToMountPoint;

		// Token: 0x04013E64 RID: 81508
		[Token(Token = "0x4013E64")]
		[FieldOffset(Offset = "0xAA")]
		[SerializeField]
		[Inspect("attachToMountPoint")]
		private bool _ignoreMountPointHeight;

		// Token: 0x04013E65 RID: 81509
		[Token(Token = "0x4013E65")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Entity.MountPointType _mountPointType;

		// Token: 0x04013E66 RID: 81510
		[Token(Token = "0x4013E66")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _checkReached;

		// Token: 0x04013E67 RID: 81511
		[Token(Token = "0x4013E67")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _delayAfterReached;

		// Token: 0x04013E68 RID: 81512
		[Token(Token = "0x4013E68")]
		[FieldOffset(Offset = "0xB2")]
		[SerializeField]
		[Inspect("delayAfterReached")]
		private bool _updateDelayTimeOnlyOnce;

		// Token: 0x04013E69 RID: 81513
		[Token(Token = "0x4013E69")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _delayTime;

		// Token: 0x04013E6A RID: 81514
		[Token(Token = "0x4013E6A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Inspect("delayAfterReached")]
		private float _extraDelayTime;

		// Token: 0x04013E6B RID: 81515
		[Token(Token = "0x4013E6B")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _delayToStart;

		// Token: 0x04013E6C RID: 81516
		[Token(Token = "0x4013E6C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _immediatelyReach;

		// Token: 0x04013E6D RID: 81517
		[Token(Token = "0x4013E6D")]
		[FieldOffset(Offset = "0xC1")]
		[SerializeField]
		private bool _stopIfTargetDead;

		// Token: 0x04013E6E RID: 81518
		[Token(Token = "0x4013E6E")]
		[FieldOffset(Offset = "0xC2")]
		[SerializeField]
		private bool _stopIfTargetDisappeared;

		// Token: 0x04013E6F RID: 81519
		[Token(Token = "0x4013E6F")]
		[FieldOffset(Offset = "0xC3")]
		[SerializeField]
		private bool _followTarget;

		// Token: 0x04013E70 RID: 81520
		[Token(Token = "0x4013E70")]
		[FieldOffset(Offset = "0xC8")]
		private MountPoint m_mountPoint;

		// Token: 0x04013E71 RID: 81521
		[Token(Token = "0x4013E71")]
		[FieldOffset(Offset = "0xD0")]
		private FP m_delayTime;

		// Token: 0x04013E72 RID: 81522
		[Token(Token = "0x4013E72")]
		[FieldOffset(Offset = "0xD8")]
		private float m_delayToStart;

		// Token: 0x04013E73 RID: 81523
		[Token(Token = "0x4013E73")]
		[FieldOffset(Offset = "0xDC")]
		private bool m_alreadyUpdateAfterDelay;

		// Token: 0x04013E74 RID: 81524
		[Token(Token = "0x4013E74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_delayAfterReached;

		// Token: 0x04013E75 RID: 81525
		[Token(Token = "0x4013E75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_attachToMountPoint;

		// Token: 0x04013E76 RID: 81526
		[Token(Token = "0x4013E76")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013E77 RID: 81527
		[Token(Token = "0x4013E77")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013E78 RID: 81528
		[Token(Token = "0x4013E78")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013E79 RID: 81529
		[Token(Token = "0x4013E79")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBeforeAppearOrDisappear;

		// Token: 0x04013E7A RID: 81530
		[Token(Token = "0x4013E7A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoCheckReachedInternal;

		// Token: 0x04013E7B RID: 81531
		[Token(Token = "0x4013E7B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013E7C RID: 81532
		[Token(Token = "0x4013E7C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckStartTick;

		// Token: 0x04013E7D RID: 81533
		[Token(Token = "0x4013E7D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
