using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x0200289E RID: 10398
	[Token(Token = "0x200289E")]
	public class PanelTemplate : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x060114D0 RID: 70864 RVA: 0x0006A8D8 File Offset: 0x00068AD8
		[Token(Token = "0x1700263F")]
		private float oPosX
		{
			[Token(Token = "0x60114D0")]
			[Address(RVA = "0x9228D0", Offset = "0x9214D0", VA = "0x1809228D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x060114D1 RID: 70865 RVA: 0x0006A8F0 File Offset: 0x00068AF0
		[Token(Token = "0x17002640")]
		private float panelWidth
		{
			[Token(Token = "0x60114D1")]
			[Address(RVA = "0x922920", Offset = "0x921520", VA = "0x180922920")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x060114D2 RID: 70866 RVA: 0x0006A908 File Offset: 0x00068B08
		[Token(Token = "0x17002641")]
		private int maxPage
		{
			[Token(Token = "0x60114D2")]
			[Address(RVA = "0x9228B0", Offset = "0x9214B0", VA = "0x1809228B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060114D3 RID: 70867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114D3")]
		[Address(RVA = "0x922000", Offset = "0x920C00", VA = "0x180922000")]
		private void Awake()
		{
		}

		// Token: 0x060114D4 RID: 70868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114D4")]
		[Address(RVA = "0x922140", Offset = "0x920D40", VA = "0x180922140", Slot = "8")]
		public virtual void OnUpdate()
		{
		}

		// Token: 0x060114D5 RID: 70869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114D5")]
		[Address(RVA = "0x922770", Offset = "0x921370", VA = "0x180922770")]
		private void _SwitchPage(int nextPage)
		{
		}

		// Token: 0x060114D6 RID: 70870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114D6")]
		[Address(RVA = "0x9225D0", Offset = "0x9211D0", VA = "0x1809225D0")]
		private void _MovePanel()
		{
		}

		// Token: 0x060114D7 RID: 70871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114D7")]
		[Address(RVA = "0x922570", Offset = "0x921170", VA = "0x180922570")]
		public void SwitchPage(Transform page)
		{
		}

		// Token: 0x060114D8 RID: 70872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114D8")]
		[Address(RVA = "0x9224A0", Offset = "0x9210A0", VA = "0x1809224A0")]
		public void OpenOrCloseCheatManagerUI()
		{
		}

		// Token: 0x060114D9 RID: 70873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114D9")]
		[Address(RVA = "0x922060", Offset = "0x920C60", VA = "0x180922060", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060114DA RID: 70874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114DA")]
		[Address(RVA = "0x9220D0", Offset = "0x920CD0", VA = "0x1809220D0", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060114DB RID: 70875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114DB")]
		[Address(RVA = "0x9220B0", Offset = "0x920CB0", VA = "0x1809220B0", Slot = "6")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060114DC RID: 70876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114DC")]
		[Address(RVA = "0x9220C0", Offset = "0x920CC0", VA = "0x1809220C0", Slot = "7")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060114DD RID: 70877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114DD")]
		[Address(RVA = "0x91CB30", Offset = "0x91B730", VA = "0x18091CB30")]
		public PanelTemplate()
		{
		}

		// Token: 0x04013532 RID: 79154
		[Token(Token = "0x4013532")]
		[FieldOffset(Offset = "0x18")]
		protected KeyCode switchKeyCode;

		// Token: 0x04013533 RID: 79155
		[Token(Token = "0x4013533")]
		[FieldOffset(Offset = "0x1C")]
		protected KeyCode turnPageKeyCode;

		// Token: 0x04013534 RID: 79156
		[Token(Token = "0x4013534")]
		[FieldOffset(Offset = "0x20")]
		protected Color highlight;

		// Token: 0x04013535 RID: 79157
		[Token(Token = "0x4013535")]
		[FieldOffset(Offset = "0x30")]
		[Header("PanelTemplate")]
		[SerializeField]
		private RectTransform _panels;

		// Token: 0x04013536 RID: 79158
		[Token(Token = "0x4013536")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _battleInfoPanel;

		// Token: 0x04013537 RID: 79159
		[Token(Token = "0x4013537")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _panelShow;

		// Token: 0x04013538 RID: 79160
		[Token(Token = "0x4013538")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _pages;

		// Token: 0x04013539 RID: 79161
		[Token(Token = "0x4013539")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _lastPage;

		// Token: 0x0401353A RID: 79162
		[Token(Token = "0x401353A")]
		[FieldOffset(Offset = "0x58")]
		private float m_turnTime;

		// Token: 0x0401353B RID: 79163
		[Token(Token = "0x401353B")]
		[FieldOffset(Offset = "0x5C")]
		private int m_currentPage;

		// Token: 0x0401353C RID: 79164
		[Token(Token = "0x401353C")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_tween;

		// Token: 0x0401353D RID: 79165
		[Token(Token = "0x401353D")]
		[FieldOffset(Offset = "0x68")]
		private float m_scaleSpeed;

		// Token: 0x0401353E RID: 79166
		[Token(Token = "0x401353E")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 m_nextScale;

		// Token: 0x0401353F RID: 79167
		[Token(Token = "0x401353F")]
		[FieldOffset(Offset = "0x78")]
		private float m_scrollWheel;

		// Token: 0x04013540 RID: 79168
		[Token(Token = "0x4013540")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_isPointEnter;

		// Token: 0x04013541 RID: 79169
		[Token(Token = "0x4013541")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_lastPointerPos;

		// Token: 0x04013542 RID: 79170
		[Token(Token = "0x4013542")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_isPointPressed;
	}
}
