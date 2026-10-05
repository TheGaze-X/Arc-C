using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029EE RID: 10734
	[Token(Token = "0x20029EE")]
	public class RotateAroundMovement : BasicMovement
	{
		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x06011CDC RID: 72924 RVA: 0x0006D098 File Offset: 0x0006B298
		[Token(Token = "0x17002741")]
		private bool rotateAndMoving
		{
			[Token(Token = "0x6011CDC")]
			[Address(RVA = "0x9B57C0", Offset = "0x9B43C0", VA = "0x1809B57C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x06011CDD RID: 72925 RVA: 0x0006D0B0 File Offset: 0x0006B2B0
		[Token(Token = "0x17002742")]
		private bool dynamicChangeProjectileAroundRadius
		{
			[Token(Token = "0x6011CDD")]
			[Address(RVA = "0x9B5690", Offset = "0x9B4290", VA = "0x1809B5690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x06011CDE RID: 72926 RVA: 0x0006D0C8 File Offset: 0x0006B2C8
		[Token(Token = "0x17002743")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011CDE")]
			[Address(RVA = "0x9B5760", Offset = "0x9B4360", VA = "0x1809B5760", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011CDF RID: 72927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CDF")]
		[Address(RVA = "0x9B46E0", Offset = "0x9B32E0", VA = "0x1809B46E0", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x06011CE0 RID: 72928 RVA: 0x0006D0E0 File Offset: 0x0006B2E0
		// (set) Token: 0x06011CE1 RID: 72929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002744")]
		public float aroundSpeed
		{
			[Token(Token = "0x6011CE0")]
			[Address(RVA = "0x9B5630", Offset = "0x9B4230", VA = "0x1809B5630")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6011CE1")]
			[Address(RVA = "0x9B5890", Offset = "0x9B4490", VA = "0x1809B5890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x06011CE2 RID: 72930 RVA: 0x0006D0F8 File Offset: 0x0006B2F8
		// (set) Token: 0x06011CE3 RID: 72931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002745")]
		public float accumulatedDegree
		{
			[Token(Token = "0x6011CE2")]
			[Address(RVA = "0x9B55D0", Offset = "0x9B41D0", VA = "0x1809B55D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6011CE3")]
			[Address(RVA = "0x9B5820", Offset = "0x9B4420", VA = "0x1809B5820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06011CE4 RID: 72932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CE4")]
		[Address(RVA = "0x9B4270", Offset = "0x9B2E70", VA = "0x1809B4270", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011CE5 RID: 72933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CE5")]
		[Address(RVA = "0x9B4600", Offset = "0x9B3200", VA = "0x1809B4600", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CE6 RID: 72934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CE6")]
		[Address(RVA = "0x9B45A0", Offset = "0x9B31A0", VA = "0x1809B45A0", Slot = "20")]
		protected override void OnInitPose()
		{
		}

		// Token: 0x06011CE7 RID: 72935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CE7")]
		[Address(RVA = "0x9B4210", Offset = "0x9B2E10", VA = "0x1809B4210", Slot = "21")]
		protected override void DealReached()
		{
		}

		// Token: 0x06011CE8 RID: 72936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CE8")]
		[Address(RVA = "0x9B4870", Offset = "0x9B3470", VA = "0x1809B4870", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011CE9 RID: 72937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CE9")]
		[Address(RVA = "0x9B5220", Offset = "0x9B3E20", VA = "0x1809B5220")]
		private void _CalculateProjectileRadiusAndRotate(FP deltaTime)
		{
		}

		// Token: 0x06011CEA RID: 72938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CEA")]
		[Address(RVA = "0x9B5560", Offset = "0x9B4160", VA = "0x1809B5560")]
		public RotateAroundMovement()
		{
		}

		// Token: 0x06011CEB RID: 72939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CEB")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011CEC RID: 72940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CEC")]
		[Address(RVA = "0x97EC30", Offset = "0x97D830", VA = "0x18097EC30")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011CED RID: 72941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CED")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011CEE RID: 72942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CEE")]
		[Address(RVA = "0x998A00", Offset = "0x997600", VA = "0x180998A00")]
		private void <>xLuaBaseProxy_OnInitPose()
		{
		}

		// Token: 0x06011CEF RID: 72943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CEF")]
		[Address(RVA = "0x998210", Offset = "0x996E10", VA = "0x180998210")]
		private void <>xLuaBaseProxy_DealReached()
		{
		}

		// Token: 0x06011CF0 RID: 72944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CF0")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013FF6 RID: 81910
		[Token(Token = "0x4013FF6")]
		private const int MAX_DEGREES = 360;

		// Token: 0x04013FF7 RID: 81911
		[Token(Token = "0x4013FF7")]
		private const float RADIUS_CHANGE_RATE = 0.01f;

		// Token: 0x04013FF8 RID: 81912
		[Token(Token = "0x4013FF8")]
		private const string FINAL_RADIUS = "final_radius";

		// Token: 0x04013FF9 RID: 81913
		[Token(Token = "0x4013FF9")]
		private const string DEFAULT_RADIUS = "default_radius";

		// Token: 0x04013FFA RID: 81914
		[Token(Token = "0x4013FFA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("RotateAroundMovement")]
		private float _aroundSpeed;

		// Token: 0x04013FFB RID: 81915
		[Token(Token = "0x4013FFB")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Group("RotateAroundMovement")]
		private bool _stopIfTargetDead;

		// Token: 0x04013FFC RID: 81916
		[Token(Token = "0x4013FFC")]
		[FieldOffset(Offset = "0xAD")]
		[SerializeField]
		[Group("RotateAroundMovement")]
		private bool _rotateAndMoving;

		// Token: 0x04013FFD RID: 81917
		[Token(Token = "0x4013FFD")]
		[FieldOffset(Offset = "0xAE")]
		[SerializeField]
		[Inspect("rotateAndMoving")]
		[Group("RotateAroundMovement")]
		private bool _rotateWithWorldPosition;

		// Token: 0x04013FFE RID: 81918
		[Token(Token = "0x4013FFE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Inspect("rotateAndMoving")]
		[Group("RotateAroundMovement")]
		private float _projectileAroundRadius;

		// Token: 0x04013FFF RID: 81919
		[Token(Token = "0x4013FFF")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Group("RotateAroundMovement")]
		private bool _clockwise;

		// Token: 0x04014000 RID: 81920
		[Token(Token = "0x4014000")]
		[FieldOffset(Offset = "0xB5")]
		[SerializeField]
		private bool _pointYAxisToTraceTarget;

		// Token: 0x04014001 RID: 81921
		[Token(Token = "0x4014001")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 m_direction;

		// Token: 0x04014002 RID: 81922
		[Token(Token = "0x4014002")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_pointYAxisToTraceTarget;

		// Token: 0x04014003 RID: 81923
		[Token(Token = "0x4014003")]
		[FieldOffset(Offset = "0xC8")]
		private float m_finalRadius;

		// Token: 0x04014004 RID: 81924
		[Token(Token = "0x4014004")]
		[FieldOffset(Offset = "0xCC")]
		private float m_defaultRadius;

		// Token: 0x04014005 RID: 81925
		[Token(Token = "0x4014005")]
		[FieldOffset(Offset = "0xD0")]
		private float m_curRadius;

		// Token: 0x04014006 RID: 81926
		[Token(Token = "0x4014006")]
		[FieldOffset(Offset = "0xD4")]
		private float m_progress;

		// Token: 0x04014009 RID: 81929
		[Token(Token = "0x4014009")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rotateAndMoving;

		// Token: 0x0401400A RID: 81930
		[Token(Token = "0x401400A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dynamicChangeProjectileAroundRadius;

		// Token: 0x0401400B RID: 81931
		[Token(Token = "0x401400B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x0401400C RID: 81932
		[Token(Token = "0x401400C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x0401400D RID: 81933
		[Token(Token = "0x401400D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_aroundSpeed;

		// Token: 0x0401400E RID: 81934
		[Token(Token = "0x401400E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_aroundSpeed;

		// Token: 0x0401400F RID: 81935
		[Token(Token = "0x401400F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_accumulatedDegree;

		// Token: 0x04014010 RID: 81936
		[Token(Token = "0x4014010")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_accumulatedDegree;

		// Token: 0x04014011 RID: 81937
		[Token(Token = "0x4014011")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014012 RID: 81938
		[Token(Token = "0x4014012")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04014013 RID: 81939
		[Token(Token = "0x4014013")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnInitPose;

		// Token: 0x04014014 RID: 81940
		[Token(Token = "0x4014014")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DealReached;

		// Token: 0x04014015 RID: 81941
		[Token(Token = "0x4014015")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014016 RID: 81942
		[Token(Token = "0x4014016")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CalculateProjectileRadiusAndRotate;

		// Token: 0x04014017 RID: 81943
		[Token(Token = "0x4014017")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
