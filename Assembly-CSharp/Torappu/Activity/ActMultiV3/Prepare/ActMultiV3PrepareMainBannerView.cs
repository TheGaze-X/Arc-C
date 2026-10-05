using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007048 RID: 28744
	[Token(Token = "0x2007048")]
	public class ActMultiV3PrepareMainBannerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006078 RID: 24696
		// (get) Token: 0x06028CE9 RID: 167145 RVA: 0x000D3188 File Offset: 0x000D1388
		[Token(Token = "0x17006078")]
		public bool playing
		{
			[Token(Token = "0x6028CE9")]
			[Address(RVA = "0x2432410", Offset = "0x2431010", VA = "0x182432410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028CEA RID: 167146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CEA")]
		[Address(RVA = "0x2431F80", Offset = "0x2430B80", VA = "0x182431F80")]
		public void Play(ActMultiV3PrepareMainBannerType bannerType)
		{
		}

		// Token: 0x06028CEB RID: 167147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CEB")]
		[Address(RVA = "0x2432340", Offset = "0x2430F40", VA = "0x182432340")]
		private void _OnAnimEnd()
		{
		}

		// Token: 0x06028CEC RID: 167148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CEC")]
		[Address(RVA = "0x2431F20", Offset = "0x2430B20", VA = "0x182431F20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06028CED RID: 167149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CED")]
		[Address(RVA = "0x24322C0", Offset = "0x2430EC0", VA = "0x1824322C0")]
		private void _ClearAnim()
		{
		}

		// Token: 0x06028CEE RID: 167150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CEE")]
		[Address(RVA = "0x24323B0", Offset = "0x2430FB0", VA = "0x1824323B0")]
		public ActMultiV3PrepareMainBannerView()
		{
		}

		// Token: 0x0403A31B RID: 238363
		[Token(Token = "0x403A31B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animIn;

		// Token: 0x0403A31C RID: 238364
		[Token(Token = "0x403A31C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animOut;

		// Token: 0x0403A31D RID: 238365
		[Token(Token = "0x403A31D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x0403A31E RID: 238366
		[Token(Token = "0x403A31E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _blackToggle;

		// Token: 0x0403A31F RID: 238367
		[Token(Token = "0x403A31F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _firstNode;

		// Token: 0x0403A320 RID: 238368
		[Token(Token = "0x403A320")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _noCharPickNode;

		// Token: 0x0403A321 RID: 238369
		[Token(Token = "0x403A321")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _squadNode;

		// Token: 0x0403A322 RID: 238370
		[Token(Token = "0x403A322")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_animTween;

		// Token: 0x0403A323 RID: 238371
		[Token(Token = "0x403A323")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_playing;

		// Token: 0x0403A324 RID: 238372
		[Token(Token = "0x403A324")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0403A325 RID: 238373
		[Token(Token = "0x403A325")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnAnimEnd;

		// Token: 0x0403A326 RID: 238374
		[Token(Token = "0x403A326")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403A327 RID: 238375
		[Token(Token = "0x403A327")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearAnim;

		// Token: 0x0403A328 RID: 238376
		[Token(Token = "0x403A328")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
