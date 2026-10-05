using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003248 RID: 12872
	[Token(Token = "0x2003248")]
	public class PauseEffectIfRenderInvisible : Effect.Behaviour
	{
		// Token: 0x060146A2 RID: 83618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A2")]
		[Address(RVA = "0xCA8770", Offset = "0xCA7370", VA = "0x180CA8770")]
		private void Update()
		{
		}

		// Token: 0x060146A3 RID: 83619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A3")]
		[Address(RVA = "0xCA8980", Offset = "0xCA7580", VA = "0x180CA8980")]
		public PauseEffectIfRenderInvisible()
		{
		}

		// Token: 0x040181C0 RID: 98752
		[Token(Token = "0x40181C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _finishIfInvisible;

		// Token: 0x040181C1 RID: 98753
		[Token(Token = "0x40181C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040181C2 RID: 98754
		[Token(Token = "0x40181C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
