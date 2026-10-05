using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029EB RID: 10731
	[Token(Token = "0x20029EB")]
	public class ParacurveMovementWithRandomLocation : ParacurveMovement
	{
		// Token: 0x06011CCA RID: 72906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CCA")]
		[Address(RVA = "0x9A5EC0", Offset = "0x9A4AC0", VA = "0x1809A5EC0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011CCB RID: 72907 RVA: 0x0006D050 File Offset: 0x0006B250
		[Token(Token = "0x6011CCB")]
		[Address(RVA = "0x9A5E40", Offset = "0x9A4A40", VA = "0x1809A5E40", Slot = "23")]
		protected override Vector3 GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06011CCC RID: 72908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CCC")]
		[Address(RVA = "0x9A6150", Offset = "0x9A4D50", VA = "0x1809A6150")]
		public ParacurveMovementWithRandomLocation()
		{
		}

		// Token: 0x06011CCD RID: 72909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CCD")]
		[Address(RVA = "0x999480", Offset = "0x998080", VA = "0x180999480")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011CCE RID: 72910 RVA: 0x0006D068 File Offset: 0x0006B268
		[Token(Token = "0x6011CCE")]
		[Address(RVA = "0x993690", Offset = "0x992290", VA = "0x180993690")]
		private Vector3 <>xLuaBaseProxy_GetTraceTargetMapPosition()
		{
			return default(Vector3);
		}

		// Token: 0x04013FDA RID: 81882
		[Token(Token = "0x4013FDA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("RandomOffset")]
		private float _offset;

		// Token: 0x04013FDB RID: 81883
		[Token(Token = "0x4013FDB")]
		[FieldOffset(Offset = "0xF4")]
		private Vector3 m_targetRandomPos;

		// Token: 0x04013FDC RID: 81884
		[Token(Token = "0x4013FDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013FDD RID: 81885
		[Token(Token = "0x4013FDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTraceTargetMapPosition;

		// Token: 0x04013FDE RID: 81886
		[Token(Token = "0x4013FDE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
