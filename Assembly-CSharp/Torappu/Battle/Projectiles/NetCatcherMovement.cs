using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029E9 RID: 10729
	[Token(Token = "0x20029E9")]
	public class NetCatcherMovement : BasicMovement
	{
		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x06011CAB RID: 72875 RVA: 0x0006CF48 File Offset: 0x0006B148
		[Token(Token = "0x1700273B")]
		public override bool movementAdjustable
		{
			[Token(Token = "0x6011CAB")]
			[Address(RVA = "0x9A5DE0", Offset = "0x9A49E0", VA = "0x1809A5DE0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011CAC RID: 72876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CAC")]
		[Address(RVA = "0x9A5530", Offset = "0x9A4130", VA = "0x1809A5530", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011CAD RID: 72877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CAD")]
		[Address(RVA = "0x9A5690", Offset = "0x9A4290", VA = "0x1809A5690", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011CAE RID: 72878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CAE")]
		[Address(RVA = "0x9A5D00", Offset = "0x9A4900", VA = "0x1809A5D00")]
		private void _UpdateSpeed(float deltaTime)
		{
		}

		// Token: 0x06011CAF RID: 72879 RVA: 0x0006CF60 File Offset: 0x0006B160
		[Token(Token = "0x6011CAF")]
		[Address(RVA = "0x9A5A90", Offset = "0x9A4690", VA = "0x1809A5A90")]
		private Vector3 _GetAdsorptionPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06011CB0 RID: 72880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CB0")]
		[Address(RVA = "0x9A5D80", Offset = "0x9A4980", VA = "0x1809A5D80")]
		public NetCatcherMovement()
		{
		}

		// Token: 0x06011CB1 RID: 72881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CB1")]
		[Address(RVA = "0x97EC40", Offset = "0x97D840", VA = "0x18097EC40")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011CB2 RID: 72882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011CB2")]
		[Address(RVA = "0x97EC60", Offset = "0x97D860", VA = "0x18097EC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013FA9 RID: 81833
		[Token(Token = "0x4013FA9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _speed;

		// Token: 0x04013FAA RID: 81834
		[Token(Token = "0x4013FAA")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _acceleration;

		// Token: 0x04013FAB RID: 81835
		[Token(Token = "0x4013FAB")]
		[FieldOffset(Offset = "0xB0")]
		private float m_speed;

		// Token: 0x04013FAC RID: 81836
		[Token(Token = "0x4013FAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_movementAdjustable;

		// Token: 0x04013FAD RID: 81837
		[Token(Token = "0x4013FAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013FAE RID: 81838
		[Token(Token = "0x4013FAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013FAF RID: 81839
		[Token(Token = "0x4013FAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateSpeed;

		// Token: 0x04013FB0 RID: 81840
		[Token(Token = "0x4013FB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetAdsorptionPosition;

		// Token: 0x04013FB1 RID: 81841
		[Token(Token = "0x4013FB1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
