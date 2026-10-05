using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003234 RID: 12852
	[Token(Token = "0x2003234")]
	public class FunnelHitEffect : Effect.Behaviour
	{
		// Token: 0x06014614 RID: 83476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014614")]
		[Address(RVA = "0xC9F760", Offset = "0xC9E360", VA = "0x180C9F760", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014615 RID: 83477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014615")]
		[Address(RVA = "0xC9F8E0", Offset = "0xC9E4E0", VA = "0x180C9F8E0")]
		public FunnelHitEffect()
		{
		}

		// Token: 0x06014616 RID: 83478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014616")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040180CD RID: 98509
		[Token(Token = "0x40180CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _randomRange;

		// Token: 0x040180CE RID: 98510
		[Token(Token = "0x40180CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040180CF RID: 98511
		[Token(Token = "0x40180CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
