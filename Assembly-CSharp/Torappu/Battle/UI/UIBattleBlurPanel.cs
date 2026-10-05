using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003372 RID: 13170
	[Token(Token = "0x2003372")]
	[RequireComponent(typeof(RectTransform))]
	public class UIBattleBlurPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0601502C RID: 86060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031ED")]
		protected FadeSwitchTween fadeTween
		{
			[Token(Token = "0x601502C")]
			[Address(RVA = "0xD6E0F0", Offset = "0xD6CCF0", VA = "0x180D6E0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601502D RID: 86061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601502D")]
		[Address(RVA = "0xD6D970", Offset = "0xD6C570", VA = "0x180D6D970")]
		public void ShowBattleBlur()
		{
		}

		// Token: 0x0601502E RID: 86062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601502E")]
		[Address(RVA = "0xD6D8F0", Offset = "0xD6C4F0", VA = "0x180D6D8F0")]
		public void HideBattleBlur()
		{
		}

		// Token: 0x0601502F RID: 86063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601502F")]
		[Address(RVA = "0xD6DF00", Offset = "0xD6CB00", VA = "0x180D6DF00")]
		private void _ShotBlurBackground()
		{
		}

		// Token: 0x06015030 RID: 86064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015030")]
		[Address(RVA = "0xD6DC40", Offset = "0xD6C840", VA = "0x180D6DC40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015031 RID: 86065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015031")]
		[Address(RVA = "0xD6E090", Offset = "0xD6CC90", VA = "0x180D6E090")]
		public UIBattleBlurPanel()
		{
		}

		// Token: 0x04018FFE RID: 102398
		[Token(Token = "0x4018FFE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _raycastTarget;

		// Token: 0x04018FFF RID: 102399
		[Token(Token = "0x4018FFF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Blur bkg's anchors would be reset. To avoid reseting panel self's anchor, use a specified bkg")]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04019000 RID: 102400
		[Token(Token = "0x4019000")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Shader _blurShader;

		// Token: 0x04019001 RID: 102401
		[Token(Token = "0x4019001")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04019002 RID: 102402
		[Token(Token = "0x4019002")]
		[FieldOffset(Offset = "0x38")]
		private UIRenderTextureImage m_bkgImage;

		// Token: 0x04019003 RID: 102403
		[Token(Token = "0x4019003")]
		[FieldOffset(Offset = "0x40")]
		private CanvasGroup m_alphaHandler;

		// Token: 0x04019004 RID: 102404
		[Token(Token = "0x4019004")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x04019005 RID: 102405
		[Token(Token = "0x4019005")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fadeTween;

		// Token: 0x04019006 RID: 102406
		[Token(Token = "0x4019006")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowBattleBlur;

		// Token: 0x04019007 RID: 102407
		[Token(Token = "0x4019007")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideBattleBlur;

		// Token: 0x04019008 RID: 102408
		[Token(Token = "0x4019008")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShotBlurBackground;

		// Token: 0x04019009 RID: 102409
		[Token(Token = "0x4019009")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401900A RID: 102410
		[Token(Token = "0x401900A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
