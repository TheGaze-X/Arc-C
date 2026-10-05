using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003249 RID: 12873
	[Token(Token = "0x2003249")]
	public class PauseEffectIfSpineEvent : Effect.Behaviour
	{
		// Token: 0x060146A4 RID: 83620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A4")]
		[Address(RVA = "0xCA8C20", Offset = "0xCA7820", VA = "0x180CA8C20", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060146A5 RID: 83621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A5")]
		[Address(RVA = "0xCA9190", Offset = "0xCA7D90", VA = "0x180CA9190")]
		private void _OnPlayEffect(object arg)
		{
		}

		// Token: 0x060146A6 RID: 83622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A6")]
		[Address(RVA = "0xCA9110", Offset = "0xCA7D10", VA = "0x180CA9110")]
		private void _OnPauseEffect(object arg)
		{
		}

		// Token: 0x060146A7 RID: 83623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A7")]
		[Address(RVA = "0xCA89E0", Offset = "0xCA75E0", VA = "0x180CA89E0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060146A8 RID: 83624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A8")]
		[Address(RVA = "0xCA9210", Offset = "0xCA7E10", VA = "0x180CA9210")]
		private void _SetPause(bool pause)
		{
		}

		// Token: 0x060146A9 RID: 83625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146A9")]
		[Address(RVA = "0xCA8FA0", Offset = "0xCA7BA0", VA = "0x180CA8FA0")]
		private void Update()
		{
		}

		// Token: 0x060146AA RID: 83626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146AA")]
		[Address(RVA = "0xCA92A0", Offset = "0xCA7EA0", VA = "0x180CA92A0")]
		public PauseEffectIfSpineEvent()
		{
		}

		// Token: 0x060146AB RID: 83627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146AB")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060146AC RID: 83628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146AC")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040181C3 RID: 98755
		[Token(Token = "0x40181C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _pauseAtStart;

		// Token: 0x040181C4 RID: 98756
		[Token(Token = "0x40181C4")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _useBehaviourPause;

		// Token: 0x040181C5 RID: 98757
		[Token(Token = "0x40181C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] onlyCheckedAnimations;

		// Token: 0x040181C6 RID: 98758
		[Token(Token = "0x40181C6")]
		[FieldOffset(Offset = "0x30")]
		private UnitAnimator m_animator;

		// Token: 0x040181C7 RID: 98759
		[Token(Token = "0x40181C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040181C8 RID: 98760
		[Token(Token = "0x40181C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnPlayEffect;

		// Token: 0x040181C9 RID: 98761
		[Token(Token = "0x40181C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnPauseEffect;

		// Token: 0x040181CA RID: 98762
		[Token(Token = "0x40181CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040181CB RID: 98763
		[Token(Token = "0x40181CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetPause;

		// Token: 0x040181CC RID: 98764
		[Token(Token = "0x40181CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040181CD RID: 98765
		[Token(Token = "0x40181CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
