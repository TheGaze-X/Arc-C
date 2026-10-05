using System;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act15D0
{
	// Token: 0x020079C1 RID: 31169
	[Token(Token = "0x20079C1")]
	public class Act15D0SoundEffectTrigger : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BB7A RID: 179066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB7A")]
		[Address(RVA = "0x279D150", Offset = "0x279BD50", VA = "0x18279D150")]
		public void _animatorPlaySoundEffect()
		{
		}

		// Token: 0x0602BB7B RID: 179067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB7B")]
		[Address(RVA = "0x279D240", Offset = "0x279BE40", VA = "0x18279D240")]
		public Act15D0SoundEffectTrigger()
		{
		}

		// Token: 0x0403F403 RID: 259075
		[Token(Token = "0x403F403")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UiEffectSoundType effectSoundType;

		// Token: 0x0403F404 RID: 259076
		[Token(Token = "0x403F404")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__animatorPlaySoundEffect;

		// Token: 0x0403F405 RID: 259077
		[Token(Token = "0x403F405")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
