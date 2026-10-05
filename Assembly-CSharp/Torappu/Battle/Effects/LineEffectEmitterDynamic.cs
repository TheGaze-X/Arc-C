using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003236 RID: 12854
	[Token(Token = "0x2003236")]
	public class LineEffectEmitterDynamic : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x06014626 RID: 83494 RVA: 0x00086A48 File Offset: 0x00084C48
		[Token(Token = "0x17003040")]
		private bool finishIfBuffNotExists
		{
			[Token(Token = "0x6014626")]
			[Address(RVA = "0xCA30D0", Offset = "0xCA1CD0", VA = "0x180CA30D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x06014627 RID: 83495 RVA: 0x00086A60 File Offset: 0x00084C60
		[Token(Token = "0x17003041")]
		private bool hasStartEffect
		{
			[Token(Token = "0x6014627")]
			[Address(RVA = "0xCA3210", Offset = "0xCA1E10", VA = "0x180CA3210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x06014628 RID: 83496 RVA: 0x00086A78 File Offset: 0x00084C78
		[Token(Token = "0x17003042")]
		private bool hasMidEffect
		{
			[Token(Token = "0x6014628")]
			[Address(RVA = "0xCA31A0", Offset = "0xCA1DA0", VA = "0x180CA31A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x06014629 RID: 83497 RVA: 0x00086A90 File Offset: 0x00084C90
		[Token(Token = "0x17003043")]
		private bool hasEndEffect
		{
			[Token(Token = "0x6014629")]
			[Address(RVA = "0xCA3130", Offset = "0xCA1D30", VA = "0x180CA3130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0601462A RID: 83498 RVA: 0x00086AA8 File Offset: 0x00084CA8
		[Token(Token = "0x17003044")]
		private bool tweenEndPosition
		{
			[Token(Token = "0x601462A")]
			[Address(RVA = "0xCA3520", Offset = "0xCA2120", VA = "0x180CA3520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0601462B RID: 83499 RVA: 0x00086AC0 File Offset: 0x00084CC0
		[Token(Token = "0x17003045")]
		private bool switchMaterialParamViaLR
		{
			[Token(Token = "0x601462B")]
			[Address(RVA = "0xCA34C0", Offset = "0xCA20C0", VA = "0x180CA34C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0601462C RID: 83500 RVA: 0x00086AD8 File Offset: 0x00084CD8
		[Token(Token = "0x17003046")]
		public Vector3 startPosOffset
		{
			[Token(Token = "0x601462C")]
			[Address(RVA = "0xCA3440", Offset = "0xCA2040", VA = "0x180CA3440")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0601462D RID: 83501 RVA: 0x00086AF0 File Offset: 0x00084CF0
		[Token(Token = "0x17003047")]
		public Vector3 endPosOffset
		{
			[Token(Token = "0x601462D")]
			[Address(RVA = "0xCA3050", Offset = "0xCA1C50", VA = "0x180CA3050")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0601462E RID: 83502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003048")]
		private Effect startEffect
		{
			[Token(Token = "0x601462E")]
			[Address(RVA = "0xCA3280", Offset = "0xCA1E80", VA = "0x180CA3280")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0601462F RID: 83503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003049")]
		private Effect endEffect
		{
			[Token(Token = "0x601462F")]
			[Address(RVA = "0xCA2E90", Offset = "0xCA1A90", VA = "0x180CA2E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x06014630 RID: 83504 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014631 RID: 83505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700304A")]
		public Entity startPointOwner
		{
			[Token(Token = "0x6014630")]
			[Address(RVA = "0xCA33D0", Offset = "0xCA1FD0", VA = "0x180CA33D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6014631")]
			[Address(RVA = "0xCA3620", Offset = "0xCA2220", VA = "0x180CA3620")]
			set
			{
			}
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x06014632 RID: 83506 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014633 RID: 83507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700304B")]
		public Entity endPointOwner
		{
			[Token(Token = "0x6014632")]
			[Address(RVA = "0xCA2FE0", Offset = "0xCA1BE0", VA = "0x180CA2FE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6014633")]
			[Address(RVA = "0xCA3580", Offset = "0xCA2180", VA = "0x180CA3580")]
			set
			{
			}
		}

		// Token: 0x06014634 RID: 83508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014634")]
		[Address(RVA = "0xC9FEA0", Offset = "0xC9EAA0", VA = "0x180C9FEA0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014635 RID: 83509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014635")]
		[Address(RVA = "0xCA0600", Offset = "0xC9F200", VA = "0x180CA0600")]
		private void Update()
		{
		}

		// Token: 0x06014636 RID: 83510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014636")]
		[Address(RVA = "0xCA23B0", Offset = "0xCA0FB0", VA = "0x180CA23B0")]
		private void _TryUpdateMaterialParam()
		{
		}

		// Token: 0x06014637 RID: 83511 RVA: 0x00086B08 File Offset: 0x00084D08
		[Token(Token = "0x6014637")]
		[Address(RVA = "0xCA16C0", Offset = "0xCA02C0", VA = "0x180CA16C0")]
		private bool _TryDestroyIfOwnerNotExist()
		{
			return default(bool);
		}

		// Token: 0x06014638 RID: 83512 RVA: 0x00086B20 File Offset: 0x00084D20
		[Token(Token = "0x6014638")]
		[Address(RVA = "0xCA1550", Offset = "0xCA0150", VA = "0x180CA1550")]
		private bool _TryDestroyIfOwnerNotAliveOrReborn()
		{
			return default(bool);
		}

		// Token: 0x06014639 RID: 83513 RVA: 0x00086B38 File Offset: 0x00084D38
		[Token(Token = "0x6014639")]
		[Address(RVA = "0xCA1340", Offset = "0xC9FF40", VA = "0x180CA1340")]
		private bool _TryDestroyIfBuffNotExist()
		{
			return default(bool);
		}

		// Token: 0x0601463A RID: 83514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601463A")]
		[Address(RVA = "0xCA0BC0", Offset = "0xC9F7C0", VA = "0x180CA0BC0")]
		private void _PauseIfDisappear()
		{
		}

		// Token: 0x0601463B RID: 83515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601463B")]
		[Address(RVA = "0xCA0970", Offset = "0xC9F570", VA = "0x180CA0970")]
		private void _FetchStartEndViaBuff()
		{
		}

		// Token: 0x0601463C RID: 83516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601463C")]
		[Address(RVA = "0xCA1830", Offset = "0xCA0430", VA = "0x180CA1830")]
		private void _TryUpdateEffects()
		{
		}

		// Token: 0x0601463D RID: 83517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601463D")]
		[Address(RVA = "0xCA0F40", Offset = "0xC9FB40", VA = "0x180CA0F40")]
		private void _RefreshMidPositions()
		{
		}

		// Token: 0x0601463E RID: 83518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601463E")]
		[Address(RVA = "0xC9FB70", Offset = "0xC9E770", VA = "0x180C9FB70", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601463F RID: 83519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601463F")]
		[Address(RVA = "0xC9F9A0", Offset = "0xC9E5A0", VA = "0x180C9F9A0", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014640 RID: 83520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014640")]
		[Address(RVA = "0xC9F940", Offset = "0xC9E540", VA = "0x180C9F940", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014641 RID: 83521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014641")]
		[Address(RVA = "0xCA26C0", Offset = "0xCA12C0", VA = "0x180CA26C0")]
		private void _UpdateMountPoint()
		{
		}

		// Token: 0x06014642 RID: 83522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014642")]
		[Address(RVA = "0xCA2CA0", Offset = "0xCA18A0", VA = "0x180CA2CA0")]
		public LineEffectEmitterDynamic()
		{
		}

		// Token: 0x06014643 RID: 83523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014643")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014644 RID: 83524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014644")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040180E7 RID: 98535
		[Token(Token = "0x40180E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _startEffect;

		// Token: 0x040180E8 RID: 98536
		[Token(Token = "0x40180E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _midEffect;

		// Token: 0x040180E9 RID: 98537
		[Token(Token = "0x40180E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _endEffect;

		// Token: 0x040180EA RID: 98538
		[Token(Token = "0x40180EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Entity.MountPointType _startMountPointType;

		// Token: 0x040180EB RID: 98539
		[Token(Token = "0x40180EB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Entity.MountPointType _endMountPointType;

		// Token: 0x040180EC RID: 98540
		[Token(Token = "0x40180EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _finishIfEitherOfOwnersNotExist;

		// Token: 0x040180ED RID: 98541
		[Token(Token = "0x40180ED")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _finishIfEitherOfOwnersNotAliveOrReborn;

		// Token: 0x040180EE RID: 98542
		[Token(Token = "0x40180EE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _effectGeneratedOnTargetIfFinish;

		// Token: 0x040180EF RID: 98543
		[Token(Token = "0x40180EF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _effectGeneratedOnSourceIfFinish;

		// Token: 0x040180F0 RID: 98544
		[Token(Token = "0x40180F0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _pauseWhenDisappear;

		// Token: 0x040180F1 RID: 98545
		[Token(Token = "0x40180F1")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _tweenEndPosition;

		// Token: 0x040180F2 RID: 98546
		[Token(Token = "0x40180F2")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Inspect("tweenEndPosition")]
		private float _tweenDuration;

		// Token: 0x040180F3 RID: 98547
		[Token(Token = "0x40180F3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _forceLineUseWorldSpace;

		// Token: 0x040180F4 RID: 98548
		[Token(Token = "0x40180F4")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool _useSelfEffectOnly;

		// Token: 0x040180F5 RID: 98549
		[Token(Token = "0x40180F5")]
		[FieldOffset(Offset = "0x62")]
		[SerializeField]
		private bool _fetchStartEndViaBuff;

		// Token: 0x040180F6 RID: 98550
		[Token(Token = "0x40180F6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x040180F7 RID: 98551
		[Token(Token = "0x40180F7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _finishIfBuffNotExists;

		// Token: 0x040180F8 RID: 98552
		[Token(Token = "0x40180F8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Inspect("finishIfBuffNotExists")]
		private string _buffKeyForFinish;

		// Token: 0x040180F9 RID: 98553
		[Token(Token = "0x40180F9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Inspect("finishIfBuffNotExists")]
		private bool _checkBuffSourceForFinish;

		// Token: 0x040180FA RID: 98554
		[Token(Token = "0x40180FA")]
		[FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool _switchMaterialParamViaLR;

		// Token: 0x040180FB RID: 98555
		[Token(Token = "0x40180FB")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Inspect("switchTilingViaLR")]
		private Vector2 _tilingValueLeft;

		// Token: 0x040180FC RID: 98556
		[Token(Token = "0x40180FC")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Inspect("switchTilingViaLR")]
		private Vector2 _tilingValueRight;

		// Token: 0x040180FD RID: 98557
		[Token(Token = "0x40180FD")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Inspect("switchTilingViaLR")]
		private Vector2 _offsetValueLeft;

		// Token: 0x040180FE RID: 98558
		[Token(Token = "0x40180FE")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Inspect("switchTilingViaLR")]
		private Vector2 _offsetValueRight;

		// Token: 0x040180FF RID: 98559
		[Token(Token = "0x40180FF")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Vector3 _startPosOffset;

		// Token: 0x04018100 RID: 98560
		[Token(Token = "0x4018100")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Vector3 _endPosOffset;

		// Token: 0x04018101 RID: 98561
		[Token(Token = "0x4018101")]
		[FieldOffset(Offset = "0xC0")]
		private ObjectPtr<Entity> m_startPointOwner;

		// Token: 0x04018102 RID: 98562
		[Token(Token = "0x4018102")]
		[FieldOffset(Offset = "0xD0")]
		private ObjectPtr<Entity> m_endPointOwner;

		// Token: 0x04018103 RID: 98563
		[Token(Token = "0x4018103")]
		[FieldOffset(Offset = "0xE0")]
		private List<LineRenderer> m_lineRenderers;

		// Token: 0x04018104 RID: 98564
		[Token(Token = "0x4018104")]
		[FieldOffset(Offset = "0xE8")]
		private ListDict<string, List<Material>> m_materialMap;

		// Token: 0x04018105 RID: 98565
		[Token(Token = "0x4018105")]
		[FieldOffset(Offset = "0xF0")]
		private ObjectPtr<Effect> m_startEffect;

		// Token: 0x04018106 RID: 98566
		[Token(Token = "0x4018106")]
		[FieldOffset(Offset = "0x100")]
		private ObjectPtr<Effect> m_endEffect;

		// Token: 0x04018107 RID: 98567
		[Token(Token = "0x4018107")]
		[FieldOffset(Offset = "0x110")]
		private List<ObjectPtr<Effect>> m_midEffects;

		// Token: 0x04018108 RID: 98568
		[Token(Token = "0x4018108")]
		[FieldOffset(Offset = "0x118")]
		private bool m_fetchedStartEndViaBuff;

		// Token: 0x04018109 RID: 98569
		[Token(Token = "0x4018109")]
		[FieldOffset(Offset = "0x11C")]
		private Vector3 m_startPosition;

		// Token: 0x0401810A RID: 98570
		[Token(Token = "0x401810A")]
		[FieldOffset(Offset = "0x128")]
		private Vector3 m_endPosition;

		// Token: 0x0401810B RID: 98571
		[Token(Token = "0x401810B")]
		[FieldOffset(Offset = "0x138")]
		private List<Vector3> m_midPositions;

		// Token: 0x0401810C RID: 98572
		[Token(Token = "0x401810C")]
		[FieldOffset(Offset = "0x140")]
		private float m_lerpTime;

		// Token: 0x0401810D RID: 98573
		[Token(Token = "0x401810D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_finishIfBuffNotExists;

		// Token: 0x0401810E RID: 98574
		[Token(Token = "0x401810E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasStartEffect;

		// Token: 0x0401810F RID: 98575
		[Token(Token = "0x401810F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasMidEffect;

		// Token: 0x04018110 RID: 98576
		[Token(Token = "0x4018110")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasEndEffect;

		// Token: 0x04018111 RID: 98577
		[Token(Token = "0x4018111")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tweenEndPosition;

		// Token: 0x04018112 RID: 98578
		[Token(Token = "0x4018112")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_switchMaterialParamViaLR;

		// Token: 0x04018113 RID: 98579
		[Token(Token = "0x4018113")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_startPosOffset;

		// Token: 0x04018114 RID: 98580
		[Token(Token = "0x4018114")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_endPosOffset;

		// Token: 0x04018115 RID: 98581
		[Token(Token = "0x4018115")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_startEffect;

		// Token: 0x04018116 RID: 98582
		[Token(Token = "0x4018116")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_endEffect;

		// Token: 0x04018117 RID: 98583
		[Token(Token = "0x4018117")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_startPointOwner;

		// Token: 0x04018118 RID: 98584
		[Token(Token = "0x4018118")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_startPointOwner;

		// Token: 0x04018119 RID: 98585
		[Token(Token = "0x4018119")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_endPointOwner;

		// Token: 0x0401811A RID: 98586
		[Token(Token = "0x401811A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_endPointOwner;

		// Token: 0x0401811B RID: 98587
		[Token(Token = "0x401811B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401811C RID: 98588
		[Token(Token = "0x401811C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401811D RID: 98589
		[Token(Token = "0x401811D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryUpdateMaterialParam;

		// Token: 0x0401811E RID: 98590
		[Token(Token = "0x401811E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TryDestroyIfOwnerNotExist;

		// Token: 0x0401811F RID: 98591
		[Token(Token = "0x401811F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryDestroyIfOwnerNotAliveOrReborn;

		// Token: 0x04018120 RID: 98592
		[Token(Token = "0x4018120")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryDestroyIfBuffNotExist;

		// Token: 0x04018121 RID: 98593
		[Token(Token = "0x4018121")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PauseIfDisappear;

		// Token: 0x04018122 RID: 98594
		[Token(Token = "0x4018122")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__FetchStartEndViaBuff;

		// Token: 0x04018123 RID: 98595
		[Token(Token = "0x4018123")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryUpdateEffects;

		// Token: 0x04018124 RID: 98596
		[Token(Token = "0x4018124")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RefreshMidPositions;

		// Token: 0x04018125 RID: 98597
		[Token(Token = "0x4018125")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018126 RID: 98598
		[Token(Token = "0x4018126")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018127 RID: 98599
		[Token(Token = "0x4018127")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x04018128 RID: 98600
		[Token(Token = "0x4018128")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateMountPoint;

		// Token: 0x04018129 RID: 98601
		[Token(Token = "0x4018129")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
