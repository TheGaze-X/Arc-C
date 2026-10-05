using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029BF RID: 10687
	[Token(Token = "0x20029BF")]
	public class Thorn2S3Renderer : Projectile.Behaviour, IEffectSource
	{
		// Token: 0x06011B29 RID: 72489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B29")]
		[Address(RVA = "0x98D660", Offset = "0x98C260", VA = "0x18098D660", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011B2A RID: 72490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B2A")]
		[Address(RVA = "0x98DAF0", Offset = "0x98C6F0", VA = "0x18098DAF0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011B2B RID: 72491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B2B")]
		[Address(RVA = "0x98DA70", Offset = "0x98C670", VA = "0x18098DA70", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011B2C RID: 72492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B2C")]
		[Address(RVA = "0x98DBE0", Offset = "0x98C7E0", VA = "0x18098DBE0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011B2D RID: 72493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B2D")]
		[Address(RVA = "0x98DC70", Offset = "0x98C870", VA = "0x18098DC70")]
		private void _SetLineRenderer()
		{
		}

		// Token: 0x06011B2E RID: 72494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B2E")]
		[Address(RVA = "0x98D5C0", Offset = "0x98C1C0", VA = "0x18098D5C0", Slot = "15")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011B2F RID: 72495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B2F")]
		[Address(RVA = "0x98E0F0", Offset = "0x98CCF0", VA = "0x18098E0F0")]
		public Thorn2S3Renderer()
		{
		}

		// Token: 0x06011B30 RID: 72496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B30")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011B31 RID: 72497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B31")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011B32 RID: 72498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B32")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x06011B33 RID: 72499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B33")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013D74 RID: 81268
		[Token(Token = "0x4013D74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _mainEffect;

		// Token: 0x04013D75 RID: 81269
		[Token(Token = "0x4013D75")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useEndPointAsStartPos;

		// Token: 0x04013D76 RID: 81270
		[Token(Token = "0x4013D76")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Effect> m_mainEffect;

		// Token: 0x04013D77 RID: 81271
		[Token(Token = "0x4013D77")]
		[FieldOffset(Offset = "0x48")]
		private LineRenderer[] m_lineRenderers;

		// Token: 0x04013D78 RID: 81272
		[Token(Token = "0x4013D78")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isProjectileReached;

		// Token: 0x04013D79 RID: 81273
		[Token(Token = "0x4013D79")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isRenderering;

		// Token: 0x04013D7A RID: 81274
		[Token(Token = "0x4013D7A")]
		[FieldOffset(Offset = "0x58")]
		private Vector3[] m_positions;

		// Token: 0x04013D7B RID: 81275
		[Token(Token = "0x4013D7B")]
		[FieldOffset(Offset = "0x60")]
		private Thorn2PolygonRange m_range;

		// Token: 0x04013D7C RID: 81276
		[Token(Token = "0x4013D7C")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isLoop;

		// Token: 0x04013D7D RID: 81277
		[Token(Token = "0x4013D7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D7E RID: 81278
		[Token(Token = "0x4013D7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013D7F RID: 81279
		[Token(Token = "0x4013D7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013D80 RID: 81280
		[Token(Token = "0x4013D80")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013D81 RID: 81281
		[Token(Token = "0x4013D81")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetLineRenderer;

		// Token: 0x04013D82 RID: 81282
		[Token(Token = "0x4013D82")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013D83 RID: 81283
		[Token(Token = "0x4013D83")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
