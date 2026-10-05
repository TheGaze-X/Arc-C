using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200324B RID: 12875
	[Token(Token = "0x200324B")]
	public class PlayAnimationBehaviour : Effect.Behaviour
	{
		// Token: 0x060146B8 RID: 83640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B8")]
		[Address(RVA = "0xCAB4B0", Offset = "0xCAA0B0", VA = "0x180CAB4B0")]
		private void Update()
		{
		}

		// Token: 0x060146B9 RID: 83641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146B9")]
		[Address(RVA = "0xCAB160", Offset = "0xCA9D60", VA = "0x180CAB160")]
		private void Awake()
		{
		}

		// Token: 0x060146BA RID: 83642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146BA")]
		[Address(RVA = "0xCAB1F0", Offset = "0xCA9DF0", VA = "0x180CAB1F0", Slot = "4")]
		public override void Init(Effect effect)
		{
		}

		// Token: 0x060146BB RID: 83643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146BB")]
		[Address(RVA = "0xCAB3E0", Offset = "0xCA9FE0", VA = "0x180CAB3E0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060146BC RID: 83644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146BC")]
		[Address(RVA = "0xCAB2D0", Offset = "0xCA9ED0", VA = "0x180CAB2D0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060146BD RID: 83645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146BD")]
		[Address(RVA = "0xCAB640", Offset = "0xCAA240", VA = "0x180CAB640")]
		public PlayAnimationBehaviour()
		{
		}

		// Token: 0x060146BE RID: 83646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146BE")]
		[Address(RVA = "0xC9CCD0", Offset = "0xC9B8D0", VA = "0x180C9CCD0")]
		private void <>xLuaBaseProxy_Init(Effect P0)
		{
		}

		// Token: 0x060146BF RID: 83647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146BF")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060146C0 RID: 83648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C0")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040181DE RID: 98782
		[Token(Token = "0x40181DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _onPlayAnim;

		// Token: 0x040181DF RID: 98783
		[Token(Token = "0x40181DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _onFinishAnim;

		// Token: 0x040181E0 RID: 98784
		[Token(Token = "0x40181E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _disableFinishAnimWhenOwnerAlive;

		// Token: 0x040181E1 RID: 98785
		[Token(Token = "0x40181E1")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _finishWhenOwnerFinish;

		// Token: 0x040181E2 RID: 98786
		[Token(Token = "0x40181E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _finishWhenNotContaionsBuff;

		// Token: 0x040181E3 RID: 98787
		[Token(Token = "0x40181E3")]
		[FieldOffset(Offset = "0x40")]
		private Animation m_animation;

		// Token: 0x040181E4 RID: 98788
		[Token(Token = "0x40181E4")]
		[FieldOffset(Offset = "0x48")]
		private bool m_started;

		// Token: 0x040181E5 RID: 98789
		[Token(Token = "0x40181E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040181E6 RID: 98790
		[Token(Token = "0x40181E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040181E7 RID: 98791
		[Token(Token = "0x40181E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040181E8 RID: 98792
		[Token(Token = "0x40181E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040181E9 RID: 98793
		[Token(Token = "0x40181E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040181EA RID: 98794
		[Token(Token = "0x40181EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
