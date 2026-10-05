using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056A9 RID: 22185
	[Token(Token = "0x20056A9")]
	public class RL04DungeonDisasterEffect : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020893 RID: 133267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020893")]
		[Address(RVA = "0x1AA6B60", Offset = "0x1AA5760", VA = "0x181AA6B60")]
		public void OnCreate()
		{
		}

		// Token: 0x06020894 RID: 133268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020894")]
		[Address(RVA = "0x1AA6D40", Offset = "0x1AA5940", VA = "0x181AA6D40")]
		public void SetEffectShow(bool hasDisaster)
		{
		}

		// Token: 0x06020895 RID: 133269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020895")]
		[Address(RVA = "0x1AA6BC0", Offset = "0x1AA57C0", VA = "0x181AA6BC0")]
		public void PlayStartEffect()
		{
		}

		// Token: 0x06020896 RID: 133270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020896")]
		[Address(RVA = "0x1AA6DC0", Offset = "0x1AA59C0", VA = "0x181AA6DC0")]
		public RL04DungeonDisasterEffect()
		{
		}

		// Token: 0x0402C159 RID: 180569
		[Token(Token = "0x402C159")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateFadeSwitcher _fadeSwitcher;

		// Token: 0x0402C15A RID: 180570
		[Token(Token = "0x402C15A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _startEffect;

		// Token: 0x0402C15B RID: 180571
		[Token(Token = "0x402C15B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0402C15C RID: 180572
		[Token(Token = "0x402C15C")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_cachedAnim;

		// Token: 0x0402C15D RID: 180573
		[Token(Token = "0x402C15D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402C15E RID: 180574
		[Token(Token = "0x402C15E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetEffectShow;

		// Token: 0x0402C15F RID: 180575
		[Token(Token = "0x402C15F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayStartEffect;

		// Token: 0x0402C160 RID: 180576
		[Token(Token = "0x402C160")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
