using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B54 RID: 6996
	[Token(Token = "0x2001B54")]
	public class UIArchitectureRoomDetailView : MonoBehaviour
	{
		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600AFB1 RID: 44977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D4")]
		private Button levelupButton
		{
			[Token(Token = "0x600AFB1")]
			[Address(RVA = "0x32B8500", Offset = "0x32B7100", VA = "0x1832B8500")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D5")]
		private Button teardownButton
		{
			[Token(Token = "0x600AFB2")]
			[Address(RVA = "0x32B85E0", Offset = "0x32B71E0", VA = "0x1832B85E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB3")]
		[Address(RVA = "0x32B7180", Offset = "0x32B5D80", VA = "0x1832B7180")]
		private void Awake()
		{
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB4")]
		[Address(RVA = "0x32B8260", Offset = "0x32B6E60", VA = "0x1832B8260")]
		private void _TweenUpdateShow(float val)
		{
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB5")]
		[Address(RVA = "0x32B80A0", Offset = "0x32B6CA0", VA = "0x1832B80A0")]
		private void _TweenUpdateHide(float val)
		{
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB6")]
		[Address(RVA = "0x32B7680", Offset = "0x32B6280", VA = "0x1832B7680")]
		public void Setup(string name, int level, int maxLevel, Color levelPanelColor, List<LevelInfoItem> levelInfoItems, string desc, bool teardownInteractable, bool showButtonLevelup, Action onTeardown, Action onLevelup, bool levelupInteractable = true)
		{
		}

		// Token: 0x0600AFB7 RID: 44983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB7")]
		[Address(RVA = "0x32B7620", Offset = "0x32B6220", VA = "0x1832B7620")]
		public void OnTeardownButtonPressed()
		{
		}

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB8")]
		[Address(RVA = "0x32B75B0", Offset = "0x32B61B0", VA = "0x1832B75B0")]
		public void OnLevelupButtonPressed()
		{
		}

		// Token: 0x0600AFB9 RID: 44985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFB9")]
		[Address(RVA = "0x32B75A0", Offset = "0x32B61A0", VA = "0x1832B75A0")]
		public void OnBGButtonPressed()
		{
		}

		// Token: 0x0600AFBA RID: 44986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFBA")]
		[Address(RVA = "0x32B7D10", Offset = "0x32B6910", VA = "0x1832B7D10")]
		public void Show()
		{
		}

		// Token: 0x0600AFBB RID: 44987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFBB")]
		[Address(RVA = "0x32B72D0", Offset = "0x32B5ED0", VA = "0x1832B72D0")]
		public void Hide()
		{
		}

		// Token: 0x0600AFBC RID: 44988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFBC")]
		[Address(RVA = "0x32B8400", Offset = "0x32B7000", VA = "0x1832B8400")]
		public UIArchitectureRoomDetailView()
		{
		}

		// Token: 0x0400A9B4 RID: 43444
		[Token(Token = "0x400A9B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0400A9B5 RID: 43445
		[Token(Token = "0x400A9B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0400A9B6 RID: 43446
		[Token(Token = "0x400A9B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _teardownButton;

		// Token: 0x0400A9B7 RID: 43447
		[Token(Token = "0x400A9B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _levelupButton;

		// Token: 0x0400A9B8 RID: 43448
		[Token(Token = "0x400A9B8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _infoRoot;

		// Token: 0x0400A9B9 RID: 43449
		[Token(Token = "0x400A9B9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _infoProto;

		// Token: 0x0400A9BA RID: 43450
		[Token(Token = "0x400A9BA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400A9BB RID: 43451
		[Token(Token = "0x400A9BB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x0400A9BC RID: 43452
		[Token(Token = "0x400A9BC")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _tweenHorizontalTranslation;

		// Token: 0x0400A9BD RID: 43453
		[Token(Token = "0x400A9BD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _mainPanel;

		// Token: 0x0400A9BE RID: 43454
		[Token(Token = "0x400A9BE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _levelPanel;

		// Token: 0x0400A9BF RID: 43455
		[Token(Token = "0x400A9BF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _levelEmptyColor;

		// Token: 0x0400A9C0 RID: 43456
		[Token(Token = "0x400A9C0")]
		[FieldOffset(Offset = "0x78")]
		private Action m_onTearDown;

		// Token: 0x0400A9C1 RID: 43457
		[Token(Token = "0x400A9C1")]
		[FieldOffset(Offset = "0x80")]
		private Action m_onLevelup;

		// Token: 0x0400A9C2 RID: 43458
		[Token(Token = "0x400A9C2")]
		[FieldOffset(Offset = "0x88")]
		private Tweener m_transferTweener;

		// Token: 0x0400A9C3 RID: 43459
		[Token(Token = "0x400A9C3")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 m_fromPosition;

		// Token: 0x0400A9C4 RID: 43460
		[Token(Token = "0x400A9C4")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 m_toPosition;

		// Token: 0x0400A9C5 RID: 43461
		[Token(Token = "0x400A9C5")]
		[FieldOffset(Offset = "0xA8")]
		private float m_transferVal;

		// Token: 0x0400A9C6 RID: 43462
		[Token(Token = "0x400A9C6")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_shown;

		// Token: 0x0400A9C7 RID: 43463
		[Token(Token = "0x400A9C7")]
		[FieldOffset(Offset = "0xB0")]
		private Button m_levelupButton;

		// Token: 0x0400A9C8 RID: 43464
		[Token(Token = "0x400A9C8")]
		[FieldOffset(Offset = "0xB8")]
		private Button m_teardownButton;

		// Token: 0x0400A9C9 RID: 43465
		[Token(Token = "0x400A9C9")]
		[FieldOffset(Offset = "0xC0")]
		private UIBuildingLevelPanelAdapter m_buildingLevelPanelAdapter;
	}
}
