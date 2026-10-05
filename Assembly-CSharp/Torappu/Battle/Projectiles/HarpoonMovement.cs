using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029DB RID: 10715
	[Token(Token = "0x20029DB")]
	public class HarpoonMovement : BasicMovement
	{
		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x06011C40 RID: 72768 RVA: 0x0006CC90 File Offset: 0x0006AE90
		[Token(Token = "0x17002731")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011C40")]
			[Address(RVA = "0x99CE20", Offset = "0x99BA20", VA = "0x18099CE20", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011C41 RID: 72769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C41")]
		[Address(RVA = "0x99C4A0", Offset = "0x99B0A0", VA = "0x18099C4A0", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011C42 RID: 72770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C42")]
		[Address(RVA = "0x99C620", Offset = "0x99B220", VA = "0x18099C620", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011C43 RID: 72771 RVA: 0x0006CCA8 File Offset: 0x0006AEA8
		[Token(Token = "0x6011C43")]
		[Address(RVA = "0x99C0A0", Offset = "0x99ACA0", VA = "0x18099C0A0", Slot = "22")]
		protected override bool DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011C44 RID: 72772 RVA: 0x0006CCC0 File Offset: 0x0006AEC0
		[Token(Token = "0x6011C44")]
		[Address(RVA = "0x99C2A0", Offset = "0x99AEA0", VA = "0x18099C2A0", Slot = "23")]
		protected override Vector3 GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06011C45 RID: 72773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C45")]
		[Address(RVA = "0x99CC70", Offset = "0x99B870", VA = "0x18099CC70")]
		private void Update()
		{
		}

		// Token: 0x06011C46 RID: 72774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C46")]
		[Address(RVA = "0x99CD30", Offset = "0x99B930", VA = "0x18099CD30")]
		private void _UpdateSpeed(float deltaTime)
		{
		}

		// Token: 0x06011C47 RID: 72775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C47")]
		[Address(RVA = "0x99CDB0", Offset = "0x99B9B0", VA = "0x18099CDB0")]
		public HarpoonMovement()
		{
		}

		// Token: 0x06011C48 RID: 72776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C48")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011C49 RID: 72777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C49")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011C4A RID: 72778 RVA: 0x0006CCD8 File Offset: 0x0006AED8
		[Token(Token = "0x6011C4A")]
		[Address(RVA = "0x97EC10", Offset = "0x97D810", VA = "0x18097EC10")]
		private bool <>xLuaBaseProxy_DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011C4B RID: 72779 RVA: 0x0006CCF0 File Offset: 0x0006AEF0
		[Token(Token = "0x6011C4B")]
		[Address(RVA = "0x993690", Offset = "0x992290", VA = "0x180993690")]
		private Vector3 <>xLuaBaseProxy_GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x04013EE7 RID: 81639
		[Token(Token = "0x4013EE7")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _speed;

		// Token: 0x04013EE8 RID: 81640
		[Token(Token = "0x4013EE8")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _acceleration;

		// Token: 0x04013EE9 RID: 81641
		[Token(Token = "0x4013EE9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _stayWhenReached;

		// Token: 0x04013EEA RID: 81642
		[Token(Token = "0x4013EEA")]
		[FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _keepUpdateDirection;

		// Token: 0x04013EEB RID: 81643
		[Token(Token = "0x4013EEB")]
		[FieldOffset(Offset = "0xB2")]
		[SerializeField]
		private bool _keepUpdateTargetpos;

		// Token: 0x04013EEC RID: 81644
		[Token(Token = "0x4013EEC")]
		[FieldOffset(Offset = "0xB3")]
		[SerializeField]
		private bool _independentUpdateAfterReached;

		// Token: 0x04013EED RID: 81645
		[Token(Token = "0x4013EED")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private bool _extendToLenth;

		// Token: 0x04013EEE RID: 81646
		[Token(Token = "0x4013EEE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _extendLenth;

		// Token: 0x04013EEF RID: 81647
		[Token(Token = "0x4013EEF")]
		[FieldOffset(Offset = "0xBC")]
		private float m_speed;

		// Token: 0x04013EF0 RID: 81648
		[Token(Token = "0x4013EF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013EF1 RID: 81649
		[Token(Token = "0x4013EF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013EF2 RID: 81650
		[Token(Token = "0x4013EF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013EF3 RID: 81651
		[Token(Token = "0x4013EF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoCheckReachedInternal;

		// Token: 0x04013EF4 RID: 81652
		[Token(Token = "0x4013EF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetTraceTargetMapPosition;

		// Token: 0x04013EF5 RID: 81653
		[Token(Token = "0x4013EF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04013EF6 RID: 81654
		[Token(Token = "0x4013EF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateSpeed;

		// Token: 0x04013EF7 RID: 81655
		[Token(Token = "0x4013EF7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
