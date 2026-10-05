using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200324A RID: 12874
	[Token(Token = "0x200324A")]
	public class PauseEffectWithAnimation : Effect.Behaviour
	{
		// Token: 0x060146AD RID: 83629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146AD")]
		[Address(RVA = "0xCAA900", Offset = "0xCA9500", VA = "0x180CAA900", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060146AE RID: 83630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146AE")]
		[Address(RVA = "0xCAA810", Offset = "0xCA9410", VA = "0x180CAA810", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060146AF RID: 83631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146AF")]
		[Address(RVA = "0xCAA980", Offset = "0xCA9580", VA = "0x180CAA980")]
		private void Update()
		{
		}

		// Token: 0x060146B0 RID: 83632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B0")]
		[Address(RVA = "0xCAA9E0", Offset = "0xCA95E0", VA = "0x180CAA9E0")]
		private void _CheckPause()
		{
		}

		// Token: 0x060146B1 RID: 83633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B1")]
		[Address(RVA = "0xCAAC50", Offset = "0xCA9850", VA = "0x180CAAC50")]
		private void _DoPause()
		{
		}

		// Token: 0x060146B2 RID: 83634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B2")]
		[Address(RVA = "0xCAB060", Offset = "0xCA9C60", VA = "0x180CAB060")]
		private void _SetPause()
		{
		}

		// Token: 0x060146B3 RID: 83635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B3")]
		[Address(RVA = "0xCAAE90", Offset = "0xCA9A90", VA = "0x180CAAE90")]
		private void _DoRestore()
		{
		}

		// Token: 0x060146B4 RID: 83636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B4")]
		[Address(RVA = "0xCAB0F0", Offset = "0xCA9CF0", VA = "0x180CAB0F0")]
		public PauseEffectWithAnimation()
		{
		}

		// Token: 0x060146B6 RID: 83638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B6")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060146B7 RID: 83639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B7")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040181CE RID: 98766
		[Token(Token = "0x40181CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _validAnimation;

		// Token: 0x040181CF RID: 98767
		[Token(Token = "0x40181CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _finishIfPause;

		// Token: 0x040181D0 RID: 98768
		[Token(Token = "0x40181D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _invalidAnimation;

		// Token: 0x040181D1 RID: 98769
		[Token(Token = "0x40181D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _noPauseWhenValid;

		// Token: 0x040181D2 RID: 98770
		[Token(Token = "0x40181D2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _delayToPause;

		// Token: 0x040181D3 RID: 98771
		[Token(Token = "0x40181D3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _delayToRestore;

		// Token: 0x040181D4 RID: 98772
		[Token(Token = "0x40181D4")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine m_pauseCoroutine;

		// Token: 0x040181D5 RID: 98773
		[Token(Token = "0x40181D5")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine m_restoreCoroutine;

		// Token: 0x040181D6 RID: 98774
		[Token(Token = "0x40181D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040181D7 RID: 98775
		[Token(Token = "0x40181D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040181D8 RID: 98776
		[Token(Token = "0x40181D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040181D9 RID: 98777
		[Token(Token = "0x40181D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckPause;

		// Token: 0x040181DA RID: 98778
		[Token(Token = "0x40181DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoPause;

		// Token: 0x040181DB RID: 98779
		[Token(Token = "0x40181DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetPause;

		// Token: 0x040181DC RID: 98780
		[Token(Token = "0x40181DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoRestore;

		// Token: 0x040181DD RID: 98781
		[Token(Token = "0x40181DD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
