using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023D3 RID: 9171
	[Token(Token = "0x20023D3")]
	public abstract class BasicMovement : Projectile.Behaviour
	{
		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x0600E970 RID: 59760
		[Token(Token = "0x17001D96")]
		public abstract bool movementAdjustable { [Token(Token = "0x600E970")] get; }

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x0600E971 RID: 59761 RVA: 0x000556E0 File Offset: 0x000538E0
		// (set) Token: 0x0600E972 RID: 59762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D97")]
		[Inspect(Level = 2)]
		[ReadOnly]
		[Group("Debug", Priority = 100)]
		public FP moveScale
		{
			[Token(Token = "0x600E971")]
			[Address(RVA = "0x5EFBD0", Offset = "0x5EE7D0", VA = "0x1805EFBD0")]
			[CompilerGenerated]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x600E972")]
			[Address(RVA = "0x5F0030", Offset = "0x5EEC30", VA = "0x1805F0030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x0600E973 RID: 59763 RVA: 0x000556F8 File Offset: 0x000538F8
		[Token(Token = "0x17001D98")]
		[Inspect(Level = 2)]
		[Group("Debug", Priority = 100)]
		protected virtual float realSpeed
		{
			[Token(Token = "0x600E973")]
			[Address(RVA = "0x5EFDC0", Offset = "0x5EE9C0", VA = "0x1805EFDC0", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x0600E974 RID: 59764 RVA: 0x00055710 File Offset: 0x00053910
		// (set) Token: 0x0600E975 RID: 59765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D99")]
		public Vector3 direction
		{
			[Token(Token = "0x600E974")]
			[Address(RVA = "0x5EFB50", Offset = "0x5EE750", VA = "0x1805EFB50")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600E975")]
			[Address(RVA = "0x5EFFA0", Offset = "0x5EEBA0", VA = "0x1805EFFA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x0600E976 RID: 59766 RVA: 0x00055728 File Offset: 0x00053928
		// (set) Token: 0x0600E977 RID: 59767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D9A")]
		public Vector3 position
		{
			[Token(Token = "0x600E976")]
			[Address(RVA = "0x5EFC30", Offset = "0x5EE830", VA = "0x1805EFC30")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600E977")]
			[Address(RVA = "0x5F00A0", Offset = "0x5EECA0", VA = "0x1805F00A0")]
			protected set
			{
			}
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x0600E978 RID: 59768 RVA: 0x00055740 File Offset: 0x00053940
		[Token(Token = "0x17001D9B")]
		private bool useWorldPosition
		{
			[Token(Token = "0x600E978")]
			[Address(RVA = "0x5EFF40", Offset = "0x5EEB40", VA = "0x1805EFF40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x0600E979 RID: 59769 RVA: 0x00055758 File Offset: 0x00053958
		[Token(Token = "0x17001D9C")]
		public bool rotateToTarget
		{
			[Token(Token = "0x600E979")]
			[Address(RVA = "0x5EFE20", Offset = "0x5EEA20", VA = "0x1805EFE20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x0600E97A RID: 59770 RVA: 0x00055770 File Offset: 0x00053970
		[Token(Token = "0x17001D9D")]
		protected bool useTargetDirection
		{
			[Token(Token = "0x600E97A")]
			[Address(RVA = "0x5EFEE0", Offset = "0x5EEAE0", VA = "0x1805EFEE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x0600E97B RID: 59771 RVA: 0x00055788 File Offset: 0x00053988
		[Token(Token = "0x17001D9E")]
		public bool useSourceDirection
		{
			[Token(Token = "0x600E97B")]
			[Address(RVA = "0x5EFE80", Offset = "0x5EEA80", VA = "0x1805EFE80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E97C RID: 59772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E97C")]
		[Address(RVA = "0x5ECFA0", Offset = "0x5EBBA0", VA = "0x1805ECFA0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x0600E97D RID: 59773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E97D")]
		[Address(RVA = "0x5ED250", Offset = "0x5EBE50", VA = "0x1805ED250", Slot = "17")]
		protected virtual void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x0600E97E RID: 59774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E97E")]
		[Address(RVA = "0x5EEF80", Offset = "0x5EDB80", VA = "0x1805EEF80")]
		private void _InitDirectionByStart(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x0600E97F RID: 59775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E97F")]
		[Address(RVA = "0x5EDF60", Offset = "0x5ECB60", VA = "0x1805EDF60", Slot = "18")]
		protected virtual void Reset()
		{
		}

		// Token: 0x0600E980 RID: 59776 RVA: 0x000557A0 File Offset: 0x000539A0
		[Token(Token = "0x600E980")]
		[Address(RVA = "0x5EEE20", Offset = "0x5EDA20", VA = "0x1805EEE20")]
		private bool _HandleWithBuildableTargetNotValid(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600E981 RID: 59777 RVA: 0x000557B8 File Offset: 0x000539B8
		[Token(Token = "0x600E981")]
		[Address(RVA = "0x5ECE20", Offset = "0x5EBA20", VA = "0x1805ECE20", Slot = "14")]
		public override FP GetTimeScale()
		{
			return default(FP);
		}

		// Token: 0x0600E982 RID: 59778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E982")]
		[Address(RVA = "0x5EDC40", Offset = "0x5EC840", VA = "0x1805EDC40", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E983 RID: 59779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E983")]
		[Address(RVA = "0x5EDAC0", Offset = "0x5EC6C0", VA = "0x1805EDAC0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x0600E984 RID: 59780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E984")]
		[Address(RVA = "0x5ED9F0", Offset = "0x5EC5F0", VA = "0x1805ED9F0", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x0600E985 RID: 59781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E985")]
		[Address(RVA = "0x5ECCF0", Offset = "0x5EB8F0", VA = "0x1805ECCF0", Slot = "19")]
		protected virtual void DoCheckReached()
		{
		}

		// Token: 0x0600E986 RID: 59782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E986")]
		[Address(RVA = "0x5ED190", Offset = "0x5EBD90", VA = "0x1805ED190", Slot = "20")]
		protected virtual void OnInitPose()
		{
		}

		// Token: 0x0600E987 RID: 59783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E987")]
		[Address(RVA = "0x5EC5F0", Offset = "0x5EB1F0", VA = "0x1805EC5F0", Slot = "21")]
		protected virtual void DealReached()
		{
		}

		// Token: 0x0600E988 RID: 59784 RVA: 0x000557D0 File Offset: 0x000539D0
		[Token(Token = "0x600E988")]
		[Address(RVA = "0x5EC4D0", Offset = "0x5EB0D0", VA = "0x1805EC4D0")]
		protected bool CheckReached()
		{
			return default(bool);
		}

		// Token: 0x0600E989 RID: 59785 RVA: 0x000557E8 File Offset: 0x000539E8
		[Token(Token = "0x600E989")]
		[Address(RVA = "0x5EC920", Offset = "0x5EB520", VA = "0x1805EC920", Slot = "22")]
		protected virtual bool DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x0600E98A RID: 59786 RVA: 0x00055800 File Offset: 0x00053A00
		[Token(Token = "0x600E98A")]
		[Address(RVA = "0x5ECEB0", Offset = "0x5EBAB0", VA = "0x1805ECEB0", Slot = "23")]
		protected virtual Vector3 GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600E98B RID: 59787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E98B")]
		[Address(RVA = "0x5EE6E0", Offset = "0x5ED2E0", VA = "0x1805EE6E0", Slot = "24")]
		public virtual void SwitchTraceTarget(ILocatable newTarget)
		{
		}

		// Token: 0x0600E98C RID: 59788 RVA: 0x00055818 File Offset: 0x00053A18
		[Token(Token = "0x600E98C")]
		[Address(RVA = "0x5EE4B0", Offset = "0x5ED0B0", VA = "0x1805EE4B0")]
		protected static Vector3 SmoothLerpDirection(Vector3 oldDir, Vector3 newDir, FP deltaTime, bool alwaysLerp = false)
		{
			return default(Vector3);
		}

		// Token: 0x0600E98D RID: 59789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E98D")]
		[Address(RVA = "0x5ECD50", Offset = "0x5EB950", VA = "0x1805ECD50")]
		protected void DoUpdateRotation()
		{
		}

		// Token: 0x0600E98E RID: 59790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E98E")]
		[Address(RVA = "0x5EDFC0", Offset = "0x5ECBC0", VA = "0x1805EDFC0")]
		protected void RotateToCertainDirection(Vector3 direction)
		{
		}

		// Token: 0x0600E98F RID: 59791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E98F")]
		[Address(RVA = "0x5EE3E0", Offset = "0x5ECFE0", VA = "0x1805EE3E0")]
		public void SetMovementDirectionByMovementController(Vector3 inputDirection)
		{
		}

		// Token: 0x0600E990 RID: 59792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E990")]
		[Address(RVA = "0x5ED990", Offset = "0x5EC590", VA = "0x1805ED990", Slot = "25")]
		public virtual void OnMovementSwitched()
		{
		}

		// Token: 0x0600E991 RID: 59793 RVA: 0x00055830 File Offset: 0x00053A30
		[Token(Token = "0x600E991")]
		[Address(RVA = "0x5EDDB0", Offset = "0x5EC9B0", VA = "0x1805EDDB0", Slot = "26")]
		public virtual bool RegisterMoveScale(FP moveScale)
		{
			return default(bool);
		}

		// Token: 0x0600E992 RID: 59794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E992")]
		[Address(RVA = "0x5EEC00", Offset = "0x5ED800", VA = "0x1805EEC00", Slot = "27")]
		public virtual void UnregisterMoveScale(FP moveScale)
		{
		}

		// Token: 0x0600E993 RID: 59795 RVA: 0x00055848 File Offset: 0x00053A48
		[Token(Token = "0x600E993")]
		[Address(RVA = "0x5EECE0", Offset = "0x5ED8E0", VA = "0x1805EECE0")]
		private FP _CalculateFinalMoveScale()
		{
			return default(FP);
		}

		// Token: 0x0600E994 RID: 59796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E994")]
		[Address(RVA = "0x5EE310", Offset = "0x5ECF10", VA = "0x1805EE310")]
		public void SetMoveDirection(Vector3 newDirection)
		{
		}

		// Token: 0x0600E995 RID: 59797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E995")]
		[Address(RVA = "0x5EFAE0", Offset = "0x5EE6E0", VA = "0x1805EFAE0")]
		protected BasicMovement()
		{
		}

		// Token: 0x0600E996 RID: 59798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E996")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x0600E997 RID: 59799 RVA: 0x00055860 File Offset: 0x00053A60
		[Token(Token = "0x600E997")]
		[Address(RVA = "0x5EEA40", Offset = "0x5ED640", VA = "0x1805EEA40")]
		private FP <>xLuaBaseProxy_GetTimeScale()
		{
			return default(FP);
		}

		// Token: 0x0600E998 RID: 59800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E998")]
		[Address(RVA = "0x5EEBA0", Offset = "0x5ED7A0", VA = "0x1805EEBA0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E999 RID: 59801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E999")]
		[Address(RVA = "0x5EEB40", Offset = "0x5ED740", VA = "0x1805EEB40")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x0600E99A RID: 59802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E99A")]
		[Address(RVA = "0x5EEAE0", Offset = "0x5ED6E0", VA = "0x1805EEAE0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x04010178 RID: 65912
		[Token(Token = "0x4010178")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected bool _rotateToTarget;

		// Token: 0x04010179 RID: 65913
		[Token(Token = "0x4010179")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		protected bool _forceReachedWhenTimeup;

		// Token: 0x0401017A RID: 65914
		[Token(Token = "0x401017A")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		protected bool _useSourceDirection;

		// Token: 0x0401017B RID: 65915
		[Token(Token = "0x401017B")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		protected bool _useTargetDirection;

		// Token: 0x0401017C RID: 65916
		[Token(Token = "0x401017C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected bool _useStartToTarget;

		// Token: 0x0401017D RID: 65917
		[Token(Token = "0x401017D")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		protected bool _awayFromSourceAsDirection;

		// Token: 0x0401017E RID: 65918
		[Token(Token = "0x401017E")]
		[FieldOffset(Offset = "0x2E")]
		[SerializeField]
		protected bool _flyToTargetLocationOnly;

		// Token: 0x0401017F RID: 65919
		[Token(Token = "0x401017F")]
		[FieldOffset(Offset = "0x2F")]
		[SerializeField]
		[Inspect("useSourceDirection")]
		protected bool _useSourceDirectionRandomArcAngleStart;

		// Token: 0x04010180 RID: 65920
		[Token(Token = "0x4010180")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool _useSourceToTargetRandomArcAngleStart;

		// Token: 0x04010181 RID: 65921
		[Token(Token = "0x4010181")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		protected bool _useSourceDirectionArcAngleWithRatio;

		// Token: 0x04010182 RID: 65922
		[Token(Token = "0x4010182")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		protected bool _useSourceToTargetArcAngleWithRatio;

		// Token: 0x04010183 RID: 65923
		[Token(Token = "0x4010183")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _sourceDirectionArcAngleRatio;

		// Token: 0x04010184 RID: 65924
		[Token(Token = "0x4010184")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Advanced")]
		private bool _flyToPredefinedLocation;

		// Token: 0x04010185 RID: 65925
		[Token(Token = "0x4010185")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Group("Advanced")]
		private PredefinedLocation _predefinedLocation;

		// Token: 0x04010186 RID: 65926
		[Token(Token = "0x4010186")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Advanced")]
		private bool _freezeRotationZ;

		// Token: 0x04010187 RID: 65927
		[Token(Token = "0x4010187")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		[Group("Advanced")]
		private bool _freezeRotationXY;

		// Token: 0x04010188 RID: 65928
		[Token(Token = "0x4010188")]
		[FieldOffset(Offset = "0x42")]
		[SerializeField]
		[Group("Advanced")]
		[Tooltip("This only works if |freezeRotationZ| is false.")]
		protected bool _exactMatchCameraForward;

		// Token: 0x04010189 RID: 65929
		[Token(Token = "0x4010189")]
		[FieldOffset(Offset = "0x43")]
		[Tooltip("This only works if |traceTarget| is null")]
		[SerializeField]
		[Group("Advanced")]
		protected bool _resetToTargetPosWhenReached;

		// Token: 0x0401018A RID: 65930
		[Token(Token = "0x401018A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("Advanced")]
		[Tooltip("This only works if |traceTarget| is not null")]
		protected bool _resetToTracetargetMapPosV3;

		// Token: 0x0401018B RID: 65931
		[Token(Token = "0x401018B")]
		[FieldOffset(Offset = "0x45")]
		[SerializeField]
		[Group("Advanced")]
		[Tooltip("This is only works for IBuildable")]
		protected bool _handleWithIBuildableTarget;

		// Token: 0x0401018C RID: 65932
		[Token(Token = "0x401018C")]
		[FieldOffset(Offset = "0x46")]
		[SerializeField]
		[Group("Advanced")]
		protected bool _forceResetToTargetPosWhenReached;

		// Token: 0x0401018D RID: 65933
		[Token(Token = "0x401018D")]
		[FieldOffset(Offset = "0x47")]
		[SerializeField]
		[Group("Advanced")]
		protected bool _fixOnProjectileReached;

		// Token: 0x0401018E RID: 65934
		[Token(Token = "0x401018E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Advanced")]
		protected float _onlyReachedInTime;

		// Token: 0x0401018F RID: 65935
		[Token(Token = "0x401018F")]
		[FieldOffset(Offset = "0x4C")]
		protected Vector3 m_originPos;

		// Token: 0x04010190 RID: 65936
		[Token(Token = "0x4010190")]
		[FieldOffset(Offset = "0x58")]
		protected Vector3 m_targetPos;

		// Token: 0x04010191 RID: 65937
		[Token(Token = "0x4010191")]
		[FieldOffset(Offset = "0x64")]
		protected bool m_reachedTarget;

		// Token: 0x04010192 RID: 65938
		[Token(Token = "0x4010192")]
		[FieldOffset(Offset = "0x68")]
		protected MountPoint m_targetMountPoint;

		// Token: 0x04010193 RID: 65939
		[Token(Token = "0x4010193")]
		[FieldOffset(Offset = "0x70")]
		protected MountPoint m_startMountPoint;

		// Token: 0x04010194 RID: 65940
		[Token(Token = "0x4010194")]
		[FieldOffset(Offset = "0x78")]
		protected bool m_doHandleWithIBuildableTarget;

		// Token: 0x04010195 RID: 65941
		[Token(Token = "0x4010195")]
		[FieldOffset(Offset = "0x7C")]
		protected Vector3 m_cachedTargetMapPos;

		// Token: 0x04010196 RID: 65942
		[Token(Token = "0x4010196")]
		[FieldOffset(Offset = "0x88")]
		private List<FP> m_movementModifiers;

		// Token: 0x04010199 RID: 65945
		[Token(Token = "0x4010199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moveScale;

		// Token: 0x0401019A RID: 65946
		[Token(Token = "0x401019A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_moveScale;

		// Token: 0x0401019B RID: 65947
		[Token(Token = "0x401019B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_realSpeed;

		// Token: 0x0401019C RID: 65948
		[Token(Token = "0x401019C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_direction;

		// Token: 0x0401019D RID: 65949
		[Token(Token = "0x401019D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_direction;

		// Token: 0x0401019E RID: 65950
		[Token(Token = "0x401019E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x0401019F RID: 65951
		[Token(Token = "0x401019F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_position;

		// Token: 0x040101A0 RID: 65952
		[Token(Token = "0x40101A0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_useWorldPosition;

		// Token: 0x040101A1 RID: 65953
		[Token(Token = "0x40101A1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_rotateToTarget;

		// Token: 0x040101A2 RID: 65954
		[Token(Token = "0x40101A2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_useTargetDirection;

		// Token: 0x040101A3 RID: 65955
		[Token(Token = "0x40101A3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_useSourceDirection;

		// Token: 0x040101A4 RID: 65956
		[Token(Token = "0x40101A4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040101A5 RID: 65957
		[Token(Token = "0x40101A5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040101A6 RID: 65958
		[Token(Token = "0x40101A6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitDirectionByStart;

		// Token: 0x040101A7 RID: 65959
		[Token(Token = "0x40101A7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040101A8 RID: 65960
		[Token(Token = "0x40101A8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleWithBuildableTargetNotValid;

		// Token: 0x040101A9 RID: 65961
		[Token(Token = "0x40101A9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetTimeScale;

		// Token: 0x040101AA RID: 65962
		[Token(Token = "0x40101AA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040101AB RID: 65963
		[Token(Token = "0x40101AB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x040101AC RID: 65964
		[Token(Token = "0x40101AC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x040101AD RID: 65965
		[Token(Token = "0x40101AD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_DoCheckReached;

		// Token: 0x040101AE RID: 65966
		[Token(Token = "0x40101AE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnInitPose;

		// Token: 0x040101AF RID: 65967
		[Token(Token = "0x40101AF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_DealReached;

		// Token: 0x040101B0 RID: 65968
		[Token(Token = "0x40101B0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckReached;

		// Token: 0x040101B1 RID: 65969
		[Token(Token = "0x40101B1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_DoCheckReachedInternal;

		// Token: 0x040101B2 RID: 65970
		[Token(Token = "0x40101B2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetTraceTargetMapPosition;

		// Token: 0x040101B3 RID: 65971
		[Token(Token = "0x40101B3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SwitchTraceTarget;

		// Token: 0x040101B4 RID: 65972
		[Token(Token = "0x40101B4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SmoothLerpDirection;

		// Token: 0x040101B5 RID: 65973
		[Token(Token = "0x40101B5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_DoUpdateRotation;

		// Token: 0x040101B6 RID: 65974
		[Token(Token = "0x40101B6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_RotateToCertainDirection;

		// Token: 0x040101B7 RID: 65975
		[Token(Token = "0x40101B7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SetMovementDirectionByMovementController;

		// Token: 0x040101B8 RID: 65976
		[Token(Token = "0x40101B8")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnMovementSwitched;

		// Token: 0x040101B9 RID: 65977
		[Token(Token = "0x40101B9")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_RegisterMoveScale;

		// Token: 0x040101BA RID: 65978
		[Token(Token = "0x40101BA")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UnregisterMoveScale;

		// Token: 0x040101BB RID: 65979
		[Token(Token = "0x40101BB")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__CalculateFinalMoveScale;

		// Token: 0x040101BC RID: 65980
		[Token(Token = "0x40101BC")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_SetMoveDirection;

		// Token: 0x040101BD RID: 65981
		[Token(Token = "0x40101BD")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
