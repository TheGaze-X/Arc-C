using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029A1 RID: 10657
	[Token(Token = "0x20029A1")]
	public class PolygonSelectorHitBehaviour : SelectorHitBehaviourWithAllyBlockedEnemy
	{
		// Token: 0x06011A55 RID: 72277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A55")]
		[Address(RVA = "0x97AD50", Offset = "0x979950", VA = "0x18097AD50", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011A56 RID: 72278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A56")]
		[Address(RVA = "0x97B180", Offset = "0x979D80", VA = "0x18097B180")]
		public PolygonSelectorHitBehaviour()
		{
		}

		// Token: 0x06011A57 RID: 72279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A57")]
		[Address(RVA = "0x96B840", Offset = "0x96A440", VA = "0x18096B840")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x04013C22 RID: 80930
		[Token(Token = "0x4013C22")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _audioSignal;

		// Token: 0x04013C23 RID: 80931
		[Token(Token = "0x4013C23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013C24 RID: 80932
		[Token(Token = "0x4013C24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
