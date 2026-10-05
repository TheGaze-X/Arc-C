using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029B8 RID: 10680
	[Token(Token = "0x20029B8")]
	public class SnsantChangeForceBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011AF7 RID: 72439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF7")]
		[Address(RVA = "0x988CB0", Offset = "0x9878B0", VA = "0x180988CB0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011AF8 RID: 72440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF8")]
		[Address(RVA = "0x9890E0", Offset = "0x987CE0", VA = "0x1809890E0")]
		public SnsantChangeForceBehaviour()
		{
		}

		// Token: 0x06011AF9 RID: 72441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AF9")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x04013D22 RID: 81186
		[Token(Token = "0x4013D22")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _tag;

		// Token: 0x04013D23 RID: 81187
		[Token(Token = "0x4013D23")]
		[FieldOffset(Offset = "0x30")]
		private int m_deltaForceLevel;

		// Token: 0x04013D24 RID: 81188
		[Token(Token = "0x4013D24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D25 RID: 81189
		[Token(Token = "0x4013D25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
