using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029A9 RID: 10665
	[Token(Token = "0x20029A9")]
	public class RayS2Behaviour : Projectile.Behaviour
	{
		// Token: 0x06011A8E RID: 72334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A8E")]
		[Address(RVA = "0x9814B0", Offset = "0x9800B0", VA = "0x1809814B0", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011A8F RID: 72335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A8F")]
		[Address(RVA = "0x981C30", Offset = "0x980830", VA = "0x180981C30")]
		public RayS2Behaviour()
		{
		}

		// Token: 0x06011A90 RID: 72336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A90")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x04013C75 RID: 81013
		[Token(Token = "0x4013C75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuffData[] _buffsToToken;

		// Token: 0x04013C76 RID: 81014
		[Token(Token = "0x4013C76")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _buffkey;

		// Token: 0x04013C77 RID: 81015
		[Token(Token = "0x4013C77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013C78 RID: 81016
		[Token(Token = "0x4013C78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
