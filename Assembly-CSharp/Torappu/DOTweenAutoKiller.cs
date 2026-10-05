using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	public class DOTweenAutoKiller : SingletonInScene<DOTweenAutoKiller>, IDisposable, IHotfixable
	{
		// Token: 0x06004DC2 RID: 19906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC2")]
		[Address(RVA = "0x187F860", Offset = "0x187E460", VA = "0x18187F860")]
		private DOTweenAutoKiller()
		{
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC3")]
		[Address(RVA = "0x187F6F0", Offset = "0x187E2F0", VA = "0x18187F6F0")]
		public void RegisterDontAutoKillTween(Tween t)
		{
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC4")]
		[Address(RVA = "0x187F540", Offset = "0x187E140", VA = "0x18187F540", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x18")]
		private List<DOTweenAutoKiller.TweenPtr> m_dontAutoKillTweens;

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterDontAutoKillTween;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x020004D1 RID: 1233
		[Token(Token = "0x20004D1")]
		public struct TweenPtr
		{
			// Token: 0x1700020C RID: 524
			// (get) Token: 0x06004DC5 RID: 19909 RVA: 0x0002DBD0 File Offset: 0x0002BDD0
			[Token(Token = "0x1700020C")]
			public bool isValid
			{
				[Token(Token = "0x6004DC5")]
				[Address(RVA = "0x1893340", Offset = "0x1891F40", VA = "0x181893340")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040011DA RID: 4570
			[Token(Token = "0x40011DA")]
			[FieldOffset(Offset = "0x0")]
			public object id;

			// Token: 0x040011DB RID: 4571
			[Token(Token = "0x40011DB")]
			[FieldOffset(Offset = "0x8")]
			public Tween tween;
		}
	}
}
