using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F41 RID: 8001
	[Token(Token = "0x2001F41")]
	public class AVGUIStateEngineController : MonoBehaviour, IAVGDataSubscriber<AVGStoryCache>, IHotfixable
	{
		// Token: 0x0600C6E9 RID: 50921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E9")]
		[Address(RVA = "0x3486060", Offset = "0x3484C60", VA = "0x183486060")]
		private void OnEnable()
		{
		}

		// Token: 0x0600C6EA RID: 50922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C6EA")]
		[Address(RVA = "0x34868A0", Offset = "0x34854A0", VA = "0x1834868A0")]
		private IEnumerator _WaitForStateEngineInited()
		{
			return null;
		}

		// Token: 0x0600C6EB RID: 50923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6EB")]
		[Address(RVA = "0x3486540", Offset = "0x3485140", VA = "0x183486540")]
		private void _UpdateReaderModeState()
		{
		}

		// Token: 0x0600C6EC RID: 50924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6EC")]
		[Address(RVA = "0x3486340", Offset = "0x3484F40", VA = "0x183486340")]
		private void _EnableReaderModeState()
		{
		}

		// Token: 0x0600C6ED RID: 50925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6ED")]
		[Address(RVA = "0x34863C0", Offset = "0x3484FC0", VA = "0x1834863C0")]
		private void _ResetToDefaultState()
		{
		}

		// Token: 0x0600C6EE RID: 50926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6EE")]
		[Address(RVA = "0x3486220", Offset = "0x3484E20", VA = "0x183486220", Slot = "4")]
		public void OnValueChanged(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C6EF RID: 50927 RVA: 0x00048948 File Offset: 0x00046B48
		[Token(Token = "0x600C6EF")]
		[Address(RVA = "0x3486440", Offset = "0x3485040", VA = "0x183486440")]
		private bool _ShouldShowReaderMode(AVGStoryCache viewModel)
		{
			return default(bool);
		}

		// Token: 0x0600C6F0 RID: 50928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6F0")]
		[Address(RVA = "0x3485EF0", Offset = "0x3484AF0", VA = "0x183485EF0")]
		public void NotifyAVGReset()
		{
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x0600C6F1 RID: 50929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001792")]
		public AVGReaderModeAdapter readerModeAdapter
		{
			[Token(Token = "0x600C6F1")]
			[Address(RVA = "0x3486B10", Offset = "0x3485710", VA = "0x183486B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x0600C6F2 RID: 50930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001793")]
		public AVGReaderModeAutoPlayController autoPlayController
		{
			[Token(Token = "0x600C6F2")]
			[Address(RVA = "0x3486A50", Offset = "0x3485650", VA = "0x183486A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x0600C6F3 RID: 50931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001794")]
		public AVGReaderModePerformanceAdapter performanceAdapter
		{
			[Token(Token = "0x600C6F3")]
			[Address(RVA = "0x3486AB0", Offset = "0x34856B0", VA = "0x183486AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C6F4 RID: 50932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6F4")]
		[Address(RVA = "0x3486950", Offset = "0x3485550", VA = "0x183486950")]
		public AVGUIStateEngineController()
		{
		}

		// Token: 0x0400CC88 RID: 52360
		[Token(Token = "0x400CC88")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0400CC89 RID: 52361
		[Token(Token = "0x400CC89")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x0400CC8A RID: 52362
		[Token(Token = "0x400CC8A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AVGReaderModeAdapter _commandAdapter;

		// Token: 0x0400CC8B RID: 52363
		[Token(Token = "0x400CC8B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AVGReaderModePerformanceAdapter _performanceAdapter;

		// Token: 0x0400CC8C RID: 52364
		[Token(Token = "0x400CC8C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AVGReaderModeAutoPlayController _autoPlayController;

		// Token: 0x0400CC8D RID: 52365
		[Token(Token = "0x400CC8D")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0400CC8E RID: 52366
		[Token(Token = "0x400CC8E")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine m_waitSeInited;

		// Token: 0x0400CC8F RID: 52367
		[Token(Token = "0x400CC8F")]
		[FieldOffset(Offset = "0x50")]
		private LatchUtils.InvokeWhenUnlock m_seInitLatch;

		// Token: 0x0400CC90 RID: 52368
		[Token(Token = "0x400CC90")]
		[FieldOffset(Offset = "0x58")]
		private AVGStoryCache m_storyCache;

		// Token: 0x0400CC91 RID: 52369
		[Token(Token = "0x400CC91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400CC92 RID: 52370
		[Token(Token = "0x400CC92")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__WaitForStateEngineInited;

		// Token: 0x0400CC93 RID: 52371
		[Token(Token = "0x400CC93")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateReaderModeState;

		// Token: 0x0400CC94 RID: 52372
		[Token(Token = "0x400CC94")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnableReaderModeState;

		// Token: 0x0400CC95 RID: 52373
		[Token(Token = "0x400CC95")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetToDefaultState;

		// Token: 0x0400CC96 RID: 52374
		[Token(Token = "0x400CC96")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CC97 RID: 52375
		[Token(Token = "0x400CC97")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShouldShowReaderMode;

		// Token: 0x0400CC98 RID: 52376
		[Token(Token = "0x400CC98")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyAVGReset;

		// Token: 0x0400CC99 RID: 52377
		[Token(Token = "0x400CC99")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_readerModeAdapter;

		// Token: 0x0400CC9A RID: 52378
		[Token(Token = "0x400CC9A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_autoPlayController;

		// Token: 0x0400CC9B RID: 52379
		[Token(Token = "0x400CC9B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_performanceAdapter;

		// Token: 0x0400CC9C RID: 52380
		[Token(Token = "0x400CC9C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
