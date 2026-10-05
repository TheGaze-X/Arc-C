using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004244 RID: 16964
	[Token(Token = "0x2004244")]
	public class SandboxV2DungeonSideBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A25C RID: 107100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A25C")]
		[Address(RVA = "0x1300B20", Offset = "0x12FF720", VA = "0x181300B20")]
		public void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A25D RID: 107101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A25D")]
		[Address(RVA = "0x1300FF0", Offset = "0x12FFBF0", VA = "0x181300FF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A25E RID: 107102 RVA: 0x000A0620 File Offset: 0x0009E820
		[Token(Token = "0x601A25E")]
		[Address(RVA = "0x1300ED0", Offset = "0x12FFAD0", VA = "0x181300ED0")]
		private AnimationSwitchTween.Builder _GetAnimationSwitchTweenBuilder(UIAnimationLocation animLocation)
		{
			return default(AnimationSwitchTween.Builder);
		}

		// Token: 0x0601A25F RID: 107103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A25F")]
		[Address(RVA = "0x13011E0", Offset = "0x12FFDE0", VA = "0x1813011E0")]
		public SandboxV2DungeonSideBar()
		{
		}

		// Token: 0x04021075 RID: 135285
		[Token(Token = "0x4021075")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _questAnim;

		// Token: 0x04021076 RID: 135286
		[Token(Token = "0x4021076")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _enemyRushAnim;

		// Token: 0x04021077 RID: 135287
		[Token(Token = "0x4021077")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _otherAnim;

		// Token: 0x04021078 RID: 135288
		[Token(Token = "0x4021078")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelEmergencyTrackPoint;

		// Token: 0x04021079 RID: 135289
		[Token(Token = "0x4021079")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _enemyRushCount;

		// Token: 0x0402107A RID: 135290
		[Token(Token = "0x402107A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _otherCount;

		// Token: 0x0402107B RID: 135291
		[Token(Token = "0x402107B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0402107C RID: 135292
		[Token(Token = "0x402107C")]
		[FieldOffset(Offset = "0x68")]
		private AnimationSwitchTween m_questTween;

		// Token: 0x0402107D RID: 135293
		[Token(Token = "0x402107D")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_enemyRushTween;

		// Token: 0x0402107E RID: 135294
		[Token(Token = "0x402107E")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_otherTween;

		// Token: 0x0402107F RID: 135295
		[Token(Token = "0x402107F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021080 RID: 135296
		[Token(Token = "0x4021080")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021081 RID: 135297
		[Token(Token = "0x4021081")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetAnimationSwitchTweenBuilder;

		// Token: 0x04021082 RID: 135298
		[Token(Token = "0x4021082")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
