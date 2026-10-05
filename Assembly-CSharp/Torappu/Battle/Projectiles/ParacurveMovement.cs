using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029EA RID: 10730
	[Token(Token = "0x20029EA")]
	public class ParacurveMovement : BasicMovement
	{
		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x06011CB3 RID: 72883 RVA: 0x0006CF78 File Offset: 0x0006B178
		[Token(Token = "0x1700273C")]
		public bool comeBack
		{
			[Token(Token = "0x6011CB3")]
			[Address(RVA = "0x9A77A0", Offset = "0x9A63A0", VA = "0x1809A77A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x06011CB4 RID: 72884 RVA: 0x0006CF90 File Offset: 0x0006B190
		// (set) Token: 0x06011CB5 RID: 72885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700273D")]
		protected float speed
		{
			[Token(Token = "0x6011CB4")]
			[Address(RVA = "0x9A7950", Offset = "0x9A6550", VA = "0x1809A7950")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6011CB5")]
			[Address(RVA = "0x9A7A10", Offset = "0x9A6610", VA = "0x1809A7A10")]
			set
			{
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x06011CB6 RID: 72886 RVA: 0x0006CFA8 File Offset: 0x0006B1A8
		[Token(Token = "0x1700273E")]
		protected override float realSpeed
		{
			[Token(Token = "0x6011CB6")]
			[Address(RVA = "0x9A7860", Offset = "0x9A6460", VA = "0x1809A7860", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x06011CB7 RID: 72887 RVA: 0x0006CFC0 File Offset: 0x0006B1C0
		[Token(Token = "0x1700273F")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011CB7")]
			[Address(RVA = "0x9A7800", Offset = "0x9A6400", VA = "0x1809A7800", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x06011CB8 RID: 72888 RVA: 0x0006CFD8 File Offset: 0x0006B1D8
		[Token(Token = "0x17002740")]
		private bool useRandomHeight
		{
			[Token(Token = "0x6011CB8")]
			[Address(RVA = "0x9A79B0", Offset = "0x9A65B0", VA = "0x1809A79B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011CB9 RID: 72889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CB9")]
		[Address(RVA = "0x9A6840", Offset = "0x9A5440", VA = "0x1809A6840", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011CBA RID: 72890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CBA")]
		[Address(RVA = "0x9A6970", Offset = "0x9A5570", VA = "0x1809A6970", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CBB RID: 72891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CBB")]
		[Address(RVA = "0x9A68F0", Offset = "0x9A54F0", VA = "0x1809A68F0", Slot = "20")]
		protected override void OnInitPose()
		{
		}

		// Token: 0x06011CBC RID: 72892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CBC")]
		[Address(RVA = "0x9A6E30", Offset = "0x9A5A30", VA = "0x1809A6E30", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011CBD RID: 72893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CBD")]
		[Address(RVA = "0x9992D0", Offset = "0x997ED0", VA = "0x1809992D0", Slot = "28")]
		protected new virtual void DoCheckReached()
		{
		}

		// Token: 0x06011CBE RID: 72894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CBE")]
		[Address(RVA = "0x9A7640", Offset = "0x9A6240", VA = "0x1809A7640")]
		private void _UpdateAfterReach()
		{
		}

		// Token: 0x06011CBF RID: 72895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CBF")]
		[Address(RVA = "0x9A61C0", Offset = "0x9A4DC0", VA = "0x1809A61C0")]
		protected void Comeback()
		{
		}

		// Token: 0x06011CC0 RID: 72896 RVA: 0x0006CFF0 File Offset: 0x0006B1F0
		[Token(Token = "0x6011CC0")]
		[Address(RVA = "0x9A6730", Offset = "0x9A5330", VA = "0x1809A6730", Slot = "22")]
		protected override bool DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011CC1 RID: 72897 RVA: 0x0006D008 File Offset: 0x0006B208
		[Token(Token = "0x6011CC1")]
		[Address(RVA = "0x9A6FB0", Offset = "0x9A5BB0", VA = "0x1809A6FB0")]
		private Vector3 _CalculateNextPosition(float deltaTime, bool forceToResetDir)
		{
			return default(Vector3);
		}

		// Token: 0x06011CC2 RID: 72898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CC2")]
		[Address(RVA = "0x9A7720", Offset = "0x9A6320", VA = "0x1809A7720")]
		public ParacurveMovement()
		{
		}

		// Token: 0x06011CC4 RID: 72900 RVA: 0x0006D020 File Offset: 0x0006B220
		[Token(Token = "0x6011CC4")]
		[Address(RVA = "0x97EC70", Offset = "0x97D870", VA = "0x18097EC70")]
		private float <>xLuaBaseProxy_get_realSpeed()
		{
			return 0f;
		}

		// Token: 0x06011CC5 RID: 72901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CC5")]
		[Address(RVA = "0x97EC30", Offset = "0x97D830", VA = "0x18097EC30")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011CC6 RID: 72902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CC6")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011CC7 RID: 72903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CC7")]
		[Address(RVA = "0x998A00", Offset = "0x997600", VA = "0x180998A00")]
		private void <>xLuaBaseProxy_OnInitPose()
		{
		}

		// Token: 0x06011CC8 RID: 72904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CC8")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011CC9 RID: 72905 RVA: 0x0006D038 File Offset: 0x0006B238
		[Token(Token = "0x6011CC9")]
		[Address(RVA = "0x97EC10", Offset = "0x97D810", VA = "0x18097EC10")]
		private bool <>xLuaBaseProxy_DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x04013FB2 RID: 81842
		[Token(Token = "0x4013FB2")]
		private const float MIN_FULL_HEIGHT = 0f;

		// Token: 0x04013FB3 RID: 81843
		[Token(Token = "0x4013FB3")]
		private const float DIRECTION_ZERO_TOLERANCE = 0.01f;

		// Token: 0x04013FB4 RID: 81844
		[Token(Token = "0x4013FB4")]
		private const float TOO_CLOSE_THRESHOLD = 0.05f;

		// Token: 0x04013FB5 RID: 81845
		[Token(Token = "0x4013FB5")]
		private const float LEFT_TIME_MIN_VALUE = 0.01f;

		// Token: 0x04013FB6 RID: 81846
		[Token(Token = "0x4013FB6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _speed;

		// Token: 0x04013FB7 RID: 81847
		[Token(Token = "0x4013FB7")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _raiseHeight;

		// Token: 0x04013FB8 RID: 81848
		[Token(Token = "0x4013FB8")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected bool _delayAfterReached;

		// Token: 0x04013FB9 RID: 81849
		[Token(Token = "0x4013FB9")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _delayTime;

		// Token: 0x04013FBA RID: 81850
		[Token(Token = "0x4013FBA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _updateDelayTimeOnlyOnce;

		// Token: 0x04013FBB RID: 81851
		[Token(Token = "0x4013FBB")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _noRaiseHeightThreshold;

		// Token: 0x04013FBC RID: 81852
		[Token(Token = "0x4013FBC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected bool _comeBack;

		// Token: 0x04013FBD RID: 81853
		[Token(Token = "0x4013FBD")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Inspect("comeBack")]
		private float _comeBackSpeedScale;

		// Token: 0x04013FBE RID: 81854
		[Token(Token = "0x4013FBE")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool _inverseParacurve;

		// Token: 0x04013FBF RID: 81855
		[Token(Token = "0x4013FBF")]
		[FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool _useRandomHeight;

		// Token: 0x04013FC0 RID: 81856
		[Token(Token = "0x4013FC0")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[Inspect("useRandomHeight")]
		private Vector2 _randomHeightRange;

		// Token: 0x04013FC1 RID: 81857
		[Token(Token = "0x4013FC1")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private bool _randomInverseParacurve;

		// Token: 0x04013FC2 RID: 81858
		[Token(Token = "0x4013FC2")]
		[FieldOffset(Offset = "0xD5")]
		protected bool m_isComeBack;

		// Token: 0x04013FC3 RID: 81859
		[Token(Token = "0x4013FC3")]
		[FieldOffset(Offset = "0xD8")]
		private float m_gravity;

		// Token: 0x04013FC4 RID: 81860
		[Token(Token = "0x4013FC4")]
		[FieldOffset(Offset = "0xDC")]
		private float m_velocityN;

		// Token: 0x04013FC5 RID: 81861
		[Token(Token = "0x4013FC5")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_reachedTop;

		// Token: 0x04013FC6 RID: 81862
		[Token(Token = "0x4013FC6")]
		[FieldOffset(Offset = "0xE4")]
		protected float m_delayAfterReached;

		// Token: 0x04013FC7 RID: 81863
		[Token(Token = "0x4013FC7")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_alreadyUpdateAfterDelay;

		// Token: 0x04013FC8 RID: 81864
		[Token(Token = "0x4013FC8")]
		[FieldOffset(Offset = "0xE9")]
		private bool m_inverseParacurve;

		// Token: 0x04013FC9 RID: 81865
		[Token(Token = "0x4013FC9")]
		[FieldOffset(Offset = "0xEC")]
		private float m_speed;

		// Token: 0x04013FCA RID: 81866
		[Token(Token = "0x4013FCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_comeBack;

		// Token: 0x04013FCB RID: 81867
		[Token(Token = "0x4013FCB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_speed;

		// Token: 0x04013FCC RID: 81868
		[Token(Token = "0x4013FCC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_speed;

		// Token: 0x04013FCD RID: 81869
		[Token(Token = "0x4013FCD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_realSpeed;

		// Token: 0x04013FCE RID: 81870
		[Token(Token = "0x4013FCE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013FCF RID: 81871
		[Token(Token = "0x4013FCF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_useRandomHeight;

		// Token: 0x04013FD0 RID: 81872
		[Token(Token = "0x4013FD0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013FD1 RID: 81873
		[Token(Token = "0x4013FD1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013FD2 RID: 81874
		[Token(Token = "0x4013FD2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInitPose;

		// Token: 0x04013FD3 RID: 81875
		[Token(Token = "0x4013FD3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013FD4 RID: 81876
		[Token(Token = "0x4013FD4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoCheckReached;

		// Token: 0x04013FD5 RID: 81877
		[Token(Token = "0x4013FD5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateAfterReach;

		// Token: 0x04013FD6 RID: 81878
		[Token(Token = "0x4013FD6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Comeback;

		// Token: 0x04013FD7 RID: 81879
		[Token(Token = "0x4013FD7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoCheckReachedInternal;

		// Token: 0x04013FD8 RID: 81880
		[Token(Token = "0x4013FD8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CalculateNextPosition;

		// Token: 0x04013FD9 RID: 81881
		[Token(Token = "0x4013FD9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
