using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029EC RID: 10732
	[Token(Token = "0x20029EC")]
	public class PyczogCurveMovement : AdvancedMovement
	{
		// Token: 0x06011CCF RID: 72911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CCF")]
		[Address(RVA = "0x9A7A80", Offset = "0x9A6680", VA = "0x1809A7A80", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CD0 RID: 72912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD0")]
		[Address(RVA = "0x9A7C80", Offset = "0x9A6880", VA = "0x1809A7C80", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011CD1 RID: 72913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD1")]
		[Address(RVA = "0x9A7FD0", Offset = "0x9A6BD0", VA = "0x1809A7FD0")]
		public void RotateToCertainDirection(SharedConsts.Direction forwardDir, float angle)
		{
		}

		// Token: 0x06011CD2 RID: 72914 RVA: 0x0006D080 File Offset: 0x0006B280
		[Token(Token = "0x6011CD2")]
		[Address(RVA = "0x9A8330", Offset = "0x9A6F30", VA = "0x1809A8330")]
		private Vector2 _GetBezierPoint(FP t)
		{
			return default(Vector2);
		}

		// Token: 0x06011CD3 RID: 72915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD3")]
		[Address(RVA = "0x9A84E0", Offset = "0x9A70E0", VA = "0x1809A84E0")]
		public PyczogCurveMovement()
		{
		}

		// Token: 0x06011CD4 RID: 72916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD4")]
		[Address(RVA = "0x9936D0", Offset = "0x9922D0", VA = "0x1809936D0")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011CD5 RID: 72917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CD5")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013FDF RID: 81887
		[Token(Token = "0x4013FDF")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Vector2 _ctrlPoint0;

		// Token: 0x04013FE0 RID: 81888
		[Token(Token = "0x4013FE0")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Vector2 _ctrlPoint1;

		// Token: 0x04013FE1 RID: 81889
		[Token(Token = "0x4013FE1")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Vector2 _ctrlPoint2;

		// Token: 0x04013FE2 RID: 81890
		[Token(Token = "0x4013FE2")]
		[FieldOffset(Offset = "0x158")]
		private Vector2 m_ctrlPoint0;

		// Token: 0x04013FE3 RID: 81891
		[Token(Token = "0x4013FE3")]
		[FieldOffset(Offset = "0x160")]
		private Vector2 m_ctrlPoint1;

		// Token: 0x04013FE4 RID: 81892
		[Token(Token = "0x4013FE4")]
		[FieldOffset(Offset = "0x168")]
		private Vector2 m_ctrlPoint2;

		// Token: 0x04013FE5 RID: 81893
		[Token(Token = "0x4013FE5")]
		[FieldOffset(Offset = "0x170")]
		private Vector2 m_startPosition;

		// Token: 0x04013FE6 RID: 81894
		[Token(Token = "0x4013FE6")]
		[FieldOffset(Offset = "0x178")]
		private FP m_ratio;

		// Token: 0x04013FE7 RID: 81895
		[Token(Token = "0x4013FE7")]
		[FieldOffset(Offset = "0x180")]
		private FP m_ratioSpeed;

		// Token: 0x04013FE8 RID: 81896
		[Token(Token = "0x4013FE8")]
		[FieldOffset(Offset = "0x188")]
		private bool m_hasInitRotation;

		// Token: 0x04013FE9 RID: 81897
		[Token(Token = "0x4013FE9")]
		[FieldOffset(Offset = "0x189")]
		private bool m_needFlipX;

		// Token: 0x04013FEA RID: 81898
		[Token(Token = "0x4013FEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013FEB RID: 81899
		[Token(Token = "0x4013FEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013FEC RID: 81900
		[Token(Token = "0x4013FEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RotateToCertainDirection;

		// Token: 0x04013FED RID: 81901
		[Token(Token = "0x4013FED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetBezierPoint;

		// Token: 0x04013FEE RID: 81902
		[Token(Token = "0x4013FEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
