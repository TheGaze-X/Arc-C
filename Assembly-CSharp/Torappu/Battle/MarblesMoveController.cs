using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020FA RID: 8442
	[Token(Token = "0x20020FA")]
	public class MarblesMoveController : MoveController
	{
		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x0600CF00 RID: 52992 RVA: 0x0004ABE0 File Offset: 0x00048DE0
		// (set) Token: 0x0600CF01 RID: 52993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001899")]
		public new Vector2 velocity
		{
			[Token(Token = "0x600CF00")]
			[Address(RVA = "0x3504290", Offset = "0x3502E90", VA = "0x183504290")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600CF01")]
			[Address(RVA = "0x3504300", Offset = "0x3502F00", VA = "0x183504300")]
			set
			{
			}
		}

		// Token: 0x0600CF02 RID: 52994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF02")]
		[Address(RVA = "0x3503BA0", Offset = "0x35027A0", VA = "0x183503BA0")]
		public void InitMarblesMoveController(MarblesLikeEnemy owner)
		{
		}

		// Token: 0x0600CF03 RID: 52995 RVA: 0x0004ABF8 File Offset: 0x00048DF8
		[Token(Token = "0x600CF03")]
		[Address(RVA = "0x3503FD0", Offset = "0x3502BD0", VA = "0x183503FD0", Slot = "7")]
		protected override Vector2 _CalculateSteeringForce(Vector2 moveForce, Vector2 direction)
		{
			return default(Vector2);
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x0004AC10 File Offset: 0x00048E10
		[Token(Token = "0x600CF04")]
		[Address(RVA = "0x3503C60", Offset = "0x3502860", VA = "0x183503C60")]
		private float _CalculateMarblesSteeringFactor()
		{
			return 0f;
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x0004AC28 File Offset: 0x00048E28
		[Token(Token = "0x600CF05")]
		[Address(RVA = "0x3503E60", Offset = "0x3502A60", VA = "0x183503E60")]
		private float _CalculateMarblesSteeringFactor(MarblesLikeEnemy enemy)
		{
			return 0f;
		}

		// Token: 0x0600CF06 RID: 52998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF06")]
		[Address(RVA = "0x3504180", Offset = "0x3502D80", VA = "0x183504180")]
		public MarblesMoveController()
		{
		}

		// Token: 0x0600CF07 RID: 52999 RVA: 0x0004AC40 File Offset: 0x00048E40
		[Token(Token = "0x600CF07")]
		[Address(RVA = "0x95DE10", Offset = "0x95CA10", VA = "0x18095DE10")]
		private Vector2 <>xLuaBaseProxy__CalculateSteeringForce(Vector2 P0, Vector2 P1)
		{
			return default(Vector2);
		}

		// Token: 0x0400DCB3 RID: 56499
		[Token(Token = "0x400DCB3")]
		[FieldOffset(Offset = "0x60")]
		private ObjectPtr<MarblesLikeEnemy> m_owner;

		// Token: 0x0400DCB4 RID: 56500
		[Token(Token = "0x400DCB4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Marble Movement Params")]
		private float _maxSteeringFactor;

		// Token: 0x0400DCB5 RID: 56501
		[Token(Token = "0x400DCB5")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Group("Marble Movement Params")]
		private float _steeringMassLevelFactor;

		// Token: 0x0400DCB6 RID: 56502
		[Token(Token = "0x400DCB6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Marble Movement Params")]
		private float _steeringMoveSpeedFactor;

		// Token: 0x0400DCB7 RID: 56503
		[Token(Token = "0x400DCB7")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Group("Marble Movement Params")]
		private float _minSteeringFactor;

		// Token: 0x0400DCB8 RID: 56504
		[Token(Token = "0x400DCB8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Marble Movement Params")]
		public FP _accelerationFactor;

		// Token: 0x0400DCB9 RID: 56505
		[Token(Token = "0x400DCB9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Marble Movement Params")]
		public FP _maxMoveSpeed;

		// Token: 0x0400DCBA RID: 56506
		[Token(Token = "0x400DCBA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Marble Movement Params")]
		public float _maxUnbalanceSpeed;

		// Token: 0x0400DCBB RID: 56507
		[Token(Token = "0x400DCBB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Marble Movement Params")]
		public FP _speedLossFactor;

		// Token: 0x0400DCBC RID: 56508
		[Token(Token = "0x400DCBC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Marble Movement Params")]
		public FP _velocityLossFactor;

		// Token: 0x0400DCBD RID: 56509
		[Token(Token = "0x400DCBD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Marble Movement Params")]
		public int _velocityClearForce;

		// Token: 0x0400DCBE RID: 56510
		[Token(Token = "0x400DCBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_velocity;

		// Token: 0x0400DCBF RID: 56511
		[Token(Token = "0x400DCBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_velocity;

		// Token: 0x0400DCC0 RID: 56512
		[Token(Token = "0x400DCC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitMarblesMoveController;

		// Token: 0x0400DCC1 RID: 56513
		[Token(Token = "0x400DCC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalculateSteeringForce;

		// Token: 0x0400DCC2 RID: 56514
		[Token(Token = "0x400DCC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CalculateMarblesSteeringFactor;

		// Token: 0x0400DCC3 RID: 56515
		[Token(Token = "0x400DCC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1__CalculateMarblesSteeringFactor;

		// Token: 0x0400DCC4 RID: 56516
		[Token(Token = "0x400DCC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
