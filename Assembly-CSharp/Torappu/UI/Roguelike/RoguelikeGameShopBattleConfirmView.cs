using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054E1 RID: 21729
	[Token(Token = "0x20054E1")]
	public class RoguelikeGameShopBattleConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FF52 RID: 130898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF52")]
		[Address(RVA = "0x1A0F310", Offset = "0x1A0DF10", VA = "0x181A0F310")]
		public void BindShopController(RoguelikeGameBattleShopControllerBindings bindings)
		{
		}

		// Token: 0x0601FF53 RID: 130899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF53")]
		[Address(RVA = "0x1A0F7E0", Offset = "0x1A0E3E0", VA = "0x181A0F7E0")]
		public void PlayShowAnim()
		{
		}

		// Token: 0x0601FF54 RID: 130900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF54")]
		[Address(RVA = "0x1A0F660", Offset = "0x1A0E260", VA = "0x181A0F660")]
		public void PlayConfirmAnim()
		{
		}

		// Token: 0x0601FF55 RID: 130901 RVA: 0x000B3EB0 File Offset: 0x000B20B0
		[Token(Token = "0x601FF55")]
		[Address(RVA = "0x1A0F390", Offset = "0x1A0DF90", VA = "0x181A0F390")]
		public bool IsPlayingAnim()
		{
			return default(bool);
		}

		// Token: 0x0601FF56 RID: 130902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF56")]
		[Address(RVA = "0x1A0F9F0", Offset = "0x1A0E5F0", VA = "0x181A0F9F0")]
		private void _PlayRejectAnim()
		{
		}

		// Token: 0x0601FF57 RID: 130903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF57")]
		[Address(RVA = "0x1A0F8F0", Offset = "0x1A0E4F0", VA = "0x181A0F8F0")]
		private void _OnConfirmCallback()
		{
		}

		// Token: 0x0601FF58 RID: 130904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF58")]
		[Address(RVA = "0x1A0F970", Offset = "0x1A0E570", VA = "0x181A0F970")]
		private void _OnRejectCallback()
		{
		}

		// Token: 0x0601FF59 RID: 130905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF59")]
		[Address(RVA = "0x1A0F400", Offset = "0x1A0E000", VA = "0x181A0F400")]
		public void OnBattleConfirmClick()
		{
		}

		// Token: 0x0601FF5A RID: 130906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF5A")]
		[Address(RVA = "0x1A0F4B0", Offset = "0x1A0E0B0", VA = "0x181A0F4B0")]
		public void OnBattleRejectClick()
		{
		}

		// Token: 0x0601FF5B RID: 130907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF5B")]
		[Address(RVA = "0x1A0FB70", Offset = "0x1A0E770", VA = "0x181A0FB70")]
		public RoguelikeGameShopBattleConfirmView()
		{
		}

		// Token: 0x0402B1C7 RID: 176583
		[Token(Token = "0x402B1C7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0402B1C8 RID: 176584
		[Token(Token = "0x402B1C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animConfirm;

		// Token: 0x0402B1C9 RID: 176585
		[Token(Token = "0x402B1C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animReject;

		// Token: 0x0402B1CA RID: 176586
		[Token(Token = "0x402B1CA")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_tween;

		// Token: 0x0402B1CB RID: 176587
		[Token(Token = "0x402B1CB")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInteractable;

		// Token: 0x0402B1CC RID: 176588
		[Token(Token = "0x402B1CC")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeGameBattleShopControllerBindings m_battleShopControllerBindings;

		// Token: 0x0402B1CD RID: 176589
		[Token(Token = "0x402B1CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B1CE RID: 176590
		[Token(Token = "0x402B1CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayShowAnim;

		// Token: 0x0402B1CF RID: 176591
		[Token(Token = "0x402B1CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayConfirmAnim;

		// Token: 0x0402B1D0 RID: 176592
		[Token(Token = "0x402B1D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsPlayingAnim;

		// Token: 0x0402B1D1 RID: 176593
		[Token(Token = "0x402B1D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayRejectAnim;

		// Token: 0x0402B1D2 RID: 176594
		[Token(Token = "0x402B1D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnConfirmCallback;

		// Token: 0x0402B1D3 RID: 176595
		[Token(Token = "0x402B1D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRejectCallback;

		// Token: 0x0402B1D4 RID: 176596
		[Token(Token = "0x402B1D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBattleConfirmClick;

		// Token: 0x0402B1D5 RID: 176597
		[Token(Token = "0x402B1D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBattleRejectClick;

		// Token: 0x0402B1D6 RID: 176598
		[Token(Token = "0x402B1D6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
