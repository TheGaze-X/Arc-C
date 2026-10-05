using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C36 RID: 23606
	[Token(Token = "0x2005C36")]
	public class ClimbTowerBackgroundController : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022364 RID: 140132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022364")]
		[Address(RVA = "0x1CA19B0", Offset = "0x1CA05B0", VA = "0x181CA19B0")]
		public void Render(int layer)
		{
		}

		// Token: 0x06022365 RID: 140133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022365")]
		[Address(RVA = "0x1CA1B80", Offset = "0x1CA0780", VA = "0x181CA1B80")]
		public ClimbTowerBackgroundController()
		{
		}

		// Token: 0x0402EF00 RID: 192256
		[Token(Token = "0x402EF00")]
		private const int TOWER_MAX_LAYER = 6;

		// Token: 0x0402EF01 RID: 192257
		[Token(Token = "0x402EF01")]
		private const int TOWER_LAYER_INIT_POS = -60;

		// Token: 0x0402EF02 RID: 192258
		[Token(Token = "0x402EF02")]
		private const float TOWER_LAYER_OFFSET = 24f;

		// Token: 0x0402EF03 RID: 192259
		[Token(Token = "0x402EF03")]
		private const float TOWER_LAYER_MOVE_DURATION = 0.23f;

		// Token: 0x0402EF04 RID: 192260
		[Token(Token = "0x402EF04")]
		[FieldOffset(Offset = "0x18")]
		private int m_cachedLayer;

		// Token: 0x0402EF05 RID: 192261
		[Token(Token = "0x402EF05")]
		[FieldOffset(Offset = "0x20")]
		private Tween m_tween;

		// Token: 0x0402EF06 RID: 192262
		[Token(Token = "0x402EF06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EF07 RID: 192263
		[Token(Token = "0x402EF07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
