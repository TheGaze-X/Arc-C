using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051E7 RID: 20967
	[Token(Token = "0x20051E7")]
	public abstract class RoguelikeCustomNotify : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x0601EF67 RID: 126823
		[Token(Token = "0x1700484C")]
		public abstract RoguelikeCustomNotifyType notifyType { [Token(Token = "0x601EF67")] get; }

		// Token: 0x0601EF68 RID: 126824
		[Token(Token = "0x601EF68")]
		public abstract void DoNotify(Action<RoguelikeCustomNotifyType> onComplete, ValueBundle options);

		// Token: 0x0601EF69 RID: 126825
		[Token(Token = "0x601EF69")]
		public abstract void Kill();

		// Token: 0x0601EF6A RID: 126826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF6A")]
		[Address(RVA = "0x18B1340", Offset = "0x18AFF40", VA = "0x1818B1340")]
		protected RoguelikeCustomNotify()
		{
		}

		// Token: 0x040298DF RID: 170207
		[Token(Token = "0x40298DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
