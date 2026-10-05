using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200327B RID: 12923
	[Token(Token = "0x200327B")]
	public class TileMapEffectOnPlayEmitter : Effect.Behaviour, IEffectSource
	{
		// Token: 0x060147E2 RID: 83938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E2")]
		[Address(RVA = "0xCC0560", Offset = "0xCBF160", VA = "0x180CC0560", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147E3 RID: 83939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E3")]
		[Address(RVA = "0xCC05D0", Offset = "0xCBF1D0", VA = "0x180CC05D0")]
		protected void _OnPlayInternal()
		{
		}

		// Token: 0x060147E4 RID: 83940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E4")]
		[Address(RVA = "0xCC0430", Offset = "0xCBF030", VA = "0x180CC0430", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060147E5 RID: 83941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E5")]
		[Address(RVA = "0xCC0500", Offset = "0xCBF100", VA = "0x180CC0500", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147E6 RID: 83942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E6")]
		[Address(RVA = "0xCC0880", Offset = "0xCBF480", VA = "0x180CC0880")]
		public TileMapEffectOnPlayEmitter()
		{
		}

		// Token: 0x060147E7 RID: 83943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E7")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147E8 RID: 83944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E8")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040183A3 RID: 99235
		[Token(Token = "0x40183A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MapEffectData[] _mapEffectData;

		// Token: 0x040183A4 RID: 99236
		[Token(Token = "0x40183A4")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasPlayed;

		// Token: 0x040183A5 RID: 99237
		[Token(Token = "0x40183A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040183A6 RID: 99238
		[Token(Token = "0x40183A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnPlayInternal;

		// Token: 0x040183A7 RID: 99239
		[Token(Token = "0x40183A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040183A8 RID: 99240
		[Token(Token = "0x40183A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040183A9 RID: 99241
		[Token(Token = "0x40183A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
