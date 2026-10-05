using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C8C RID: 27788
	[Token(Token = "0x2006C8C")]
	public class TemplateActivityMapDecorZoneItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005DB0 RID: 23984
		// (get) Token: 0x06027A55 RID: 162389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DB0")]
		public string zoneId
		{
			[Token(Token = "0x6027A55")]
			[Address(RVA = "0x22DFC10", Offset = "0x22DE810", VA = "0x1822DFC10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027A56 RID: 162390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A56")]
		[Address(RVA = "0x22DF890", Offset = "0x22DE490", VA = "0x1822DF890")]
		public void Render(TemplateActivityZoneGroupViewModel.ZoneViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x06027A57 RID: 162391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A57")]
		[Address(RVA = "0x22DFA80", Offset = "0x22DE680", VA = "0x1822DFA80", Slot = "4")]
		protected virtual void _InitIfNot()
		{
		}

		// Token: 0x06027A58 RID: 162392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A58")]
		[Address(RVA = "0x22DF760", Offset = "0x22DE360", VA = "0x1822DF760")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06027A59 RID: 162393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A59")]
		[Address(RVA = "0x22DFBB0", Offset = "0x22DE7B0", VA = "0x1822DFBB0")]
		public TemplateActivityMapDecorZoneItem()
		{
		}

		// Token: 0x040383C5 RID: 230341
		[Token(Token = "0x40383C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x040383C6 RID: 230342
		[Token(Token = "0x40383C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x040383C7 RID: 230343
		[Token(Token = "0x40383C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x040383C8 RID: 230344
		[Token(Token = "0x40383C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelIcon;

		// Token: 0x040383C9 RID: 230345
		[Token(Token = "0x40383C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroupIcon;

		// Token: 0x040383CA RID: 230346
		[Token(Token = "0x40383CA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x040383CB RID: 230347
		[Token(Token = "0x40383CB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x040383CC RID: 230348
		[Token(Token = "0x40383CC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x040383CD RID: 230349
		[Token(Token = "0x40383CD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _trackPointContainer;

		// Token: 0x040383CE RID: 230350
		[Token(Token = "0x40383CE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _trackPointPrefab;

		// Token: 0x040383CF RID: 230351
		[Token(Token = "0x40383CF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _playStagePushAudio;

		// Token: 0x040383D0 RID: 230352
		[Token(Token = "0x40383D0")]
		[FieldOffset(Offset = "0x69")]
		private bool m_hasInited;

		// Token: 0x040383D1 RID: 230353
		[Token(Token = "0x40383D1")]
		[FieldOffset(Offset = "0x70")]
		private GameObject m_trackPoint;

		// Token: 0x040383D2 RID: 230354
		[Token(Token = "0x40383D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x040383D3 RID: 230355
		[Token(Token = "0x40383D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040383D4 RID: 230356
		[Token(Token = "0x40383D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040383D5 RID: 230357
		[Token(Token = "0x40383D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x040383D6 RID: 230358
		[Token(Token = "0x40383D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
