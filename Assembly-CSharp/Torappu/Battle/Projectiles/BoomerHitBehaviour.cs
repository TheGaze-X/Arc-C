using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002988 RID: 10632
	[Token(Token = "0x2002988")]
	public class BoomerHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x0601196E RID: 72046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601196E")]
		[Address(RVA = "0x968060", Offset = "0x966C60", VA = "0x180968060", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x0601196F RID: 72047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601196F")]
		[Address(RVA = "0x9682C0", Offset = "0x966EC0", VA = "0x1809682C0")]
		public BoomerHitBehaviour()
		{
		}

		// Token: 0x06011970 RID: 72048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011970")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x04013AA2 RID: 80546
		[Token(Token = "0x4013AA2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _adsBuffKey;

		// Token: 0x04013AA3 RID: 80547
		[Token(Token = "0x4013AA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013AA4 RID: 80548
		[Token(Token = "0x4013AA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
