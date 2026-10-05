using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D9 RID: 10713
	[Token(Token = "0x20029D9")]
	public abstract class FuncTimeBasedMovementCalculator : AdvancedMovement.MovementCalculator
	{
		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x06011C23 RID: 72739 RVA: 0x0006CC48 File Offset: 0x0006AE48
		[Token(Token = "0x1700272C")]
		public override Vector3 direction
		{
			[Token(Token = "0x6011C23")]
			[Address(RVA = "0x99AB50", Offset = "0x999750", VA = "0x18099AB50", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x06011C24 RID: 72740 RVA: 0x0006CC60 File Offset: 0x0006AE60
		[Token(Token = "0x1700272D")]
		public override Vector3 curPos
		{
			[Token(Token = "0x6011C24")]
			[Address(RVA = "0x99AAD0", Offset = "0x9996D0", VA = "0x18099AAD0", Slot = "5")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06011C25 RID: 72741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C25")]
		[Address(RVA = "0x99A600", Offset = "0x999200", VA = "0x18099A600", Slot = "6")]
		protected override void InitInline(Vector3 pos, Vector3 dir)
		{
		}

		// Token: 0x06011C26 RID: 72742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C26")]
		[Address(RVA = "0x99A720", Offset = "0x999320", VA = "0x18099A720", Slot = "7")]
		protected override void OnTickInline(FP deltaTime)
		{
		}

		// Token: 0x06011C27 RID: 72743
		[Token(Token = "0x6011C27")]
		protected abstract FP GetYFromXValue(FP x);

		// Token: 0x06011C28 RID: 72744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C28")]
		[Address(RVA = "0x99AA30", Offset = "0x999630", VA = "0x18099AA30")]
		protected FuncTimeBasedMovementCalculator()
		{
		}

		// Token: 0x04013ECC RID: 81612
		[Token(Token = "0x4013ECC")]
		[FieldOffset(Offset = "0x18")]
		private FP m_time;

		// Token: 0x04013ECD RID: 81613
		[Token(Token = "0x4013ECD")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 m_direction;

		// Token: 0x04013ECE RID: 81614
		[Token(Token = "0x4013ECE")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_startPos;

		// Token: 0x04013ECF RID: 81615
		[Token(Token = "0x4013ECF")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_curPos;

		// Token: 0x04013ED0 RID: 81616
		[Token(Token = "0x4013ED0")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_showedDirection;

		// Token: 0x04013ED1 RID: 81617
		[Token(Token = "0x4013ED1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_direction;

		// Token: 0x04013ED2 RID: 81618
		[Token(Token = "0x4013ED2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curPos;

		// Token: 0x04013ED3 RID: 81619
		[Token(Token = "0x4013ED3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitInline;

		// Token: 0x04013ED4 RID: 81620
		[Token(Token = "0x4013ED4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTickInline;

		// Token: 0x04013ED5 RID: 81621
		[Token(Token = "0x4013ED5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
