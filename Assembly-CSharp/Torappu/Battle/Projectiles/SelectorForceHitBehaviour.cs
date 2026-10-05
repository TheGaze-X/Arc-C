using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029AD RID: 10669
	[Token(Token = "0x20029AD")]
	public class SelectorForceHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x06011AAC RID: 72364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AAC")]
		[Address(RVA = "0x984650", Offset = "0x983250", VA = "0x180984650", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011AAD RID: 72365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AAD")]
		[Address(RVA = "0x9848D0", Offset = "0x9834D0", VA = "0x1809848D0")]
		public SelectorForceHitBehaviour()
		{
		}

		// Token: 0x06011AAE RID: 72366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AAE")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x04013CAE RID: 81070
		[Token(Token = "0x4013CAE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _forceHit;

		// Token: 0x04013CAF RID: 81071
		[Token(Token = "0x4013CAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013CB0 RID: 81072
		[Token(Token = "0x4013CB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
