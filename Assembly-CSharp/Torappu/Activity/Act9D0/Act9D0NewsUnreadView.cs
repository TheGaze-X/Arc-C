using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007178 RID: 29048
	[Token(Token = "0x2007178")]
	public class Act9D0NewsUnreadView : ActivityStageComponent, IHotfixable
	{
		// Token: 0x060293C0 RID: 168896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C0")]
		[Address(RVA = "0x24A01E0", Offset = "0x249EDE0", VA = "0x1824A01E0")]
		private void OnEnable()
		{
		}

		// Token: 0x060293C1 RID: 168897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C1")]
		[Address(RVA = "0x24A0180", Offset = "0x249ED80", VA = "0x1824A0180")]
		private void OnDisable()
		{
		}

		// Token: 0x060293C2 RID: 168898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C2")]
		[Address(RVA = "0x24A0240", Offset = "0x249EE40", VA = "0x1824A0240", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x060293C3 RID: 168899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C3")]
		[Address(RVA = "0x249FF10", Offset = "0x249EB10", VA = "0x18249FF10", Slot = "5")]
		protected override void BeforeUnload()
		{
		}

		// Token: 0x060293C4 RID: 168900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C4")]
		[Address(RVA = "0x24A05F0", Offset = "0x249F1F0", VA = "0x1824A05F0")]
		private void _OnNewsUpdated(object _)
		{
		}

		// Token: 0x060293C5 RID: 168901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C5")]
		[Address(RVA = "0x24A0490", Offset = "0x249F090", VA = "0x1824A0490")]
		private void _OnAnimationPlay()
		{
		}

		// Token: 0x060293C6 RID: 168902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60293C6")]
		[Address(RVA = "0x24A03E0", Offset = "0x249EFE0", VA = "0x1824A03E0")]
		private IEnumerator _DisplayCoroutine()
		{
			return null;
		}

		// Token: 0x060293C7 RID: 168903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C7")]
		[Address(RVA = "0x24A0B00", Offset = "0x249F700", VA = "0x1824A0B00")]
		private void _StatusBegin()
		{
		}

		// Token: 0x060293C8 RID: 168904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C8")]
		[Address(RVA = "0x24A0BC0", Offset = "0x249F7C0", VA = "0x1824A0BC0")]
		private void _StatusEnd()
		{
		}

		// Token: 0x060293C9 RID: 168905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293C9")]
		[Address(RVA = "0x24A00B0", Offset = "0x249ECB0", VA = "0x1824A00B0")]
		public void EventOnNewsClicked()
		{
		}

		// Token: 0x060293CA RID: 168906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293CA")]
		[Address(RVA = "0x24A0C80", Offset = "0x249F880", VA = "0x1824A0C80")]
		public Act9D0NewsUnreadView()
		{
		}

		// Token: 0x060293CB RID: 168907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293CB")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x060293CC RID: 168908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293CC")]
		[Address(RVA = "0x22E9250", Offset = "0x22E7E50", VA = "0x1822E9250")]
		private void <>xLuaBaseProxy_BeforeUnload()
		{
		}

		// Token: 0x0403AE39 RID: 241209
		[Token(Token = "0x403AE39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unreadObj;

		// Token: 0x0403AE3A RID: 241210
		[Token(Token = "0x403AE3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _noUnreadObj;

		// Token: 0x0403AE3B RID: 241211
		[Token(Token = "0x403AE3B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _unreadTitle;

		// Token: 0x0403AE3C RID: 241212
		[Token(Token = "0x403AE3C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _unreadCount;

		// Token: 0x0403AE3D RID: 241213
		[Token(Token = "0x403AE3D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0403AE3E RID: 241214
		[Token(Token = "0x403AE3E")]
		[FieldOffset(Offset = "0x50")]
		private CoroutineOnEnable m_displayCoroutine;

		// Token: 0x0403AE3F RID: 241215
		[Token(Token = "0x403AE3F")]
		private const string UNREAD_ANIM = "act13d5_news_unread";

		// Token: 0x0403AE40 RID: 241216
		[Token(Token = "0x403AE40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403AE41 RID: 241217
		[Token(Token = "0x403AE41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403AE42 RID: 241218
		[Token(Token = "0x403AE42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403AE43 RID: 241219
		[Token(Token = "0x403AE43")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x0403AE44 RID: 241220
		[Token(Token = "0x403AE44")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnNewsUpdated;

		// Token: 0x0403AE45 RID: 241221
		[Token(Token = "0x403AE45")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnAnimationPlay;

		// Token: 0x0403AE46 RID: 241222
		[Token(Token = "0x403AE46")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DisplayCoroutine;

		// Token: 0x0403AE47 RID: 241223
		[Token(Token = "0x403AE47")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StatusBegin;

		// Token: 0x0403AE48 RID: 241224
		[Token(Token = "0x403AE48")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StatusEnd;

		// Token: 0x0403AE49 RID: 241225
		[Token(Token = "0x403AE49")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnNewsClicked;

		// Token: 0x0403AE4A RID: 241226
		[Token(Token = "0x403AE4A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
