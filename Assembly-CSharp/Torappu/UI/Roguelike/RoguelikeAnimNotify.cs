using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051E8 RID: 20968
	[Token(Token = "0x20051E8")]
	public abstract class RoguelikeAnimNotify : RoguelikeCustomNotify
	{
		// Token: 0x0601EF6B RID: 126827
		[Token(Token = "0x601EF6B")]
		protected abstract void Render(ValueBundle options);

		// Token: 0x0601EF6C RID: 126828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF6C")]
		[Address(RVA = "0x18AF270", Offset = "0x18ADE70", VA = "0x1818AF270", Slot = "5")]
		public override void DoNotify(Action<RoguelikeCustomNotifyType> onComplete, ValueBundle options)
		{
		}

		// Token: 0x0601EF6D RID: 126829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF6D")]
		[Address(RVA = "0x18AF4A0", Offset = "0x18AE0A0", VA = "0x1818AF4A0", Slot = "6")]
		public override void Kill()
		{
		}

		// Token: 0x0601EF6E RID: 126830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF6E")]
		[Address(RVA = "0x18AF500", Offset = "0x18AE100", VA = "0x1818AF500")]
		private void _KillTween()
		{
		}

		// Token: 0x0601EF6F RID: 126831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF6F")]
		[Address(RVA = "0x18AF590", Offset = "0x18AE190", VA = "0x1818AF590")]
		protected RoguelikeAnimNotify()
		{
		}

		// Token: 0x040298E0 RID: 170208
		[Token(Token = "0x40298E0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x040298E1 RID: 170209
		[Token(Token = "0x40298E1")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_tween;

		// Token: 0x040298E2 RID: 170210
		[Token(Token = "0x40298E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoNotify;

		// Token: 0x040298E3 RID: 170211
		[Token(Token = "0x40298E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Kill;

		// Token: 0x040298E4 RID: 170212
		[Token(Token = "0x40298E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__KillTween;

		// Token: 0x040298E5 RID: 170213
		[Token(Token = "0x40298E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
