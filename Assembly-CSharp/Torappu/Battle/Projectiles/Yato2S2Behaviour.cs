using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029C7 RID: 10695
	[Token(Token = "0x20029C7")]
	public class Yato2S2Behaviour : SelectorHitBehaviour
	{
		// Token: 0x06011B6F RID: 72559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B6F")]
		[Address(RVA = "0x9925C0", Offset = "0x9911C0", VA = "0x1809925C0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011B70 RID: 72560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B70")]
		[Address(RVA = "0x992850", Offset = "0x991450", VA = "0x180992850", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011B71 RID: 72561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B71")]
		[Address(RVA = "0x992220", Offset = "0x990E20", VA = "0x180992220", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011B72 RID: 72562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B72")]
		[Address(RVA = "0x992B00", Offset = "0x991700", VA = "0x180992B00")]
		public Yato2S2Behaviour()
		{
		}

		// Token: 0x06011B73 RID: 72563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B73")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011B74 RID: 72564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B74")]
		[Address(RVA = "0x96EFB0", Offset = "0x96DBB0", VA = "0x18096EFB0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011B75 RID: 72565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B75")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x04013DC8 RID: 81352
		[Token(Token = "0x4013DC8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private FP _minDistance;

		// Token: 0x04013DC9 RID: 81353
		[Token(Token = "0x4013DC9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private FP _maxDistance;

		// Token: 0x04013DCA RID: 81354
		[Token(Token = "0x4013DCA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private FP _intervalDistance;

		// Token: 0x04013DCB RID: 81355
		[Token(Token = "0x4013DCB")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private FP _extandUnit;

		// Token: 0x04013DCC RID: 81356
		[Token(Token = "0x4013DCC")]
		[FieldOffset(Offset = "0xC8")]
		private FP m_distance;

		// Token: 0x04013DCD RID: 81357
		[Token(Token = "0x4013DCD")]
		[FieldOffset(Offset = "0xD0")]
		private int m_intervalIndex;

		// Token: 0x04013DCE RID: 81358
		[Token(Token = "0x4013DCE")]
		[FieldOffset(Offset = "0xD8")]
		private FP m_distanceTolerance;

		// Token: 0x04013DCF RID: 81359
		[Token(Token = "0x4013DCF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013DD0 RID: 81360
		[Token(Token = "0x4013DD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013DD1 RID: 81361
		[Token(Token = "0x4013DD1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013DD2 RID: 81362
		[Token(Token = "0x4013DD2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
