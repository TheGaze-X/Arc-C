using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D69 RID: 7529
	[Token(Token = "0x2001D69")]
	public class MeetingClueProductView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B9F4 RID: 47604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F4")]
		[Address(RVA = "0x3379E80", Offset = "0x3378A80", VA = "0x183379E80")]
		public void Setup(IMeetingSession session)
		{
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F5")]
		[Address(RVA = "0x337A930", Offset = "0x3379530", VA = "0x18337A930")]
		private void _SetupView()
		{
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F6")]
		[Address(RVA = "0x337A710", Offset = "0x3379310", VA = "0x18337A710")]
		private void _RefreshRoomClue()
		{
		}

		// Token: 0x0600B9F7 RID: 47607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F7")]
		[Address(RVA = "0x3379F10", Offset = "0x3378B10", VA = "0x183379F10")]
		public void Show([Optional] Action onClose)
		{
		}

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F8")]
		[Address(RVA = "0x3379930", Offset = "0x3378530", VA = "0x183379930")]
		public void Hide()
		{
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x0600B9F9 RID: 47609 RVA: 0x00045A50 File Offset: 0x00043C50
		[Token(Token = "0x17001696")]
		public bool shown
		{
			[Token(Token = "0x600B9F9")]
			[Address(RVA = "0x337B060", Offset = "0x3379C60", VA = "0x18337B060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x00045A68 File Offset: 0x00043C68
		[Token(Token = "0x600B9FA")]
		[Address(RVA = "0x337A3F0", Offset = "0x3378FF0", VA = "0x18337A3F0")]
		private bool _RefreshProgressBar()
		{
			return default(bool);
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FB")]
		[Address(RVA = "0x337A2B0", Offset = "0x3378EB0", VA = "0x18337A2B0")]
		public void UpdateFetchCharacterProduct()
		{
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FC")]
		[Address(RVA = "0x337A310", Offset = "0x3378F10", VA = "0x18337A310")]
		private void Update()
		{
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FD")]
		[Address(RVA = "0x3379CD0", Offset = "0x33788D0", VA = "0x183379CD0")]
		public void OnFetchRoomProductClueButtonPressed()
		{
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FE")]
		[Address(RVA = "0x3379C60", Offset = "0x3378860", VA = "0x183379C60")]
		public void OnCloseButtonPressed()
		{
		}

		// Token: 0x0600B9FF RID: 47615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FF")]
		[Address(RVA = "0x337AFF0", Offset = "0x3379BF0", VA = "0x18337AFF0")]
		public MeetingClueProductView()
		{
		}

		// Token: 0x0400B8BF RID: 47295
		[Token(Token = "0x400B8BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _stopCharacterPanel;

		// Token: 0x0400B8C0 RID: 47296
		[Token(Token = "0x400B8C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _stopRoomPanel;

		// Token: 0x0400B8C1 RID: 47297
		[Token(Token = "0x400B8C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _runningCharacterPanel;

		// Token: 0x0400B8C2 RID: 47298
		[Token(Token = "0x400B8C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _runningRoomPanel;

		// Token: 0x0400B8C3 RID: 47299
		[Token(Token = "0x400B8C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _emptyCharacterPanel;

		// Token: 0x0400B8C4 RID: 47300
		[Token(Token = "0x400B8C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _emptyRoomPanel;

		// Token: 0x0400B8C5 RID: 47301
		[Token(Token = "0x400B8C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MeetingClueRestTimeLabel _restTimeLabel;

		// Token: 0x0400B8C6 RID: 47302
		[Token(Token = "0x400B8C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StretchProgressBar _productProgressBar;

		// Token: 0x0400B8C7 RID: 47303
		[Token(Token = "0x400B8C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _creditCharacterProduct;

		// Token: 0x0400B8C8 RID: 47304
		[Token(Token = "0x400B8C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _creditRoomProduct;

		// Token: 0x0400B8C9 RID: 47305
		[Token(Token = "0x400B8C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _roomProductIcon;

		// Token: 0x0400B8CA RID: 47306
		[Token(Token = "0x400B8CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x0400B8CB RID: 47307
		[Token(Token = "0x400B8CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _blurBG;

		// Token: 0x0400B8CC RID: 47308
		[Token(Token = "0x400B8CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _fetchButton;

		// Token: 0x0400B8CD RID: 47309
		[Token(Token = "0x400B8CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _newLabel;

		// Token: 0x0400B8CE RID: 47310
		[Token(Token = "0x400B8CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _storageFullHint;

		// Token: 0x0400B8CF RID: 47311
		[Token(Token = "0x400B8CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400B8D0 RID: 47312
		[Token(Token = "0x400B8D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0400B8D1 RID: 47313
		[Token(Token = "0x400B8D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _fetchButtonText;

		// Token: 0x0400B8D2 RID: 47314
		[Token(Token = "0x400B8D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private IMeetingSession m_session;

		// Token: 0x0400B8D3 RID: 47315
		[Token(Token = "0x400B8D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float m_timer;

		// Token: 0x0400B8D4 RID: 47316
		[Token(Token = "0x400B8D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_shown;

		// Token: 0x0400B8D5 RID: 47317
		[Token(Token = "0x400B8D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		private bool m_needUpdateProgress;

		// Token: 0x0400B8D6 RID: 47318
		[Token(Token = "0x400B8D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		private bool m_storageFull;

		// Token: 0x0400B8D7 RID: 47319
		[Token(Token = "0x400B8D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBF")]
		private bool m_tweening;

		// Token: 0x0400B8D8 RID: 47320
		[Token(Token = "0x400B8D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action m_onCloseCallback;

		// Token: 0x0400B8D9 RID: 47321
		[Token(Token = "0x400B8D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400B8DA RID: 47322
		[Token(Token = "0x400B8DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetupView;

		// Token: 0x0400B8DB RID: 47323
		[Token(Token = "0x400B8DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshRoomClue;

		// Token: 0x0400B8DC RID: 47324
		[Token(Token = "0x400B8DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0400B8DD RID: 47325
		[Token(Token = "0x400B8DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0400B8DE RID: 47326
		[Token(Token = "0x400B8DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_shown;

		// Token: 0x0400B8DF RID: 47327
		[Token(Token = "0x400B8DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshProgressBar;

		// Token: 0x0400B8E0 RID: 47328
		[Token(Token = "0x400B8E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateFetchCharacterProduct;

		// Token: 0x0400B8E1 RID: 47329
		[Token(Token = "0x400B8E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400B8E2 RID: 47330
		[Token(Token = "0x400B8E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFetchRoomProductClueButtonPressed;

		// Token: 0x0400B8E3 RID: 47331
		[Token(Token = "0x400B8E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCloseButtonPressed;

		// Token: 0x0400B8E4 RID: 47332
		[Token(Token = "0x400B8E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
