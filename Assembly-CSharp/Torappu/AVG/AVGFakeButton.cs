using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.AVG
{
	// Token: 0x02001F5C RID: 8028
	[Token(Token = "0x2001F5C")]
	public class AVGFakeButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
	{
		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x0600C790 RID: 51088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A5")]
		public Button target
		{
			[Token(Token = "0x600C790")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x0600C791 RID: 51089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A6")]
		public UILongPressButtonEx longPressButtonExTarget
		{
			[Token(Token = "0x600C791")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C792 RID: 51090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C792")]
		[Address(RVA = "0x347E230", Offset = "0x347CE30", VA = "0x18347E230")]
		public void SetTarget(Button target, [Optional] UILongPressButtonEx longPressButtonExTarget)
		{
		}

		// Token: 0x0600C793 RID: 51091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C793")]
		[Address(RVA = "0x347DF70", Offset = "0x347CB70", VA = "0x18347DF70", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600C794 RID: 51092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C794")]
		[Address(RVA = "0x347E180", Offset = "0x347CD80", VA = "0x18347E180", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x0600C795 RID: 51093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C795")]
		[Address(RVA = "0x347E020", Offset = "0x347CC20", VA = "0x18347E020", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600C796 RID: 51094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C796")]
		[Address(RVA = "0x347E0D0", Offset = "0x347CCD0", VA = "0x18347E0D0", Slot = "7")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x0600C797 RID: 51095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C797")]
		[Address(RVA = "0x347DE40", Offset = "0x347CA40", VA = "0x18347DE40")]
		public void OnClick()
		{
		}

		// Token: 0x0600C798 RID: 51096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C798")]
		[Address(RVA = "0x347E670", Offset = "0x347D270", VA = "0x18347E670")]
		private void _RemoveUIButtonKeyBoardConfigIfExist()
		{
		}

		// Token: 0x0600C799 RID: 51097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C799")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AVGFakeButton()
		{
		}

		// Token: 0x0400CD96 RID: 52630
		[Token(Token = "0x400CD96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIButton _buttonInst;

		// Token: 0x0400CD97 RID: 52631
		[Token(Token = "0x400CD97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onClickCB;

		// Token: 0x0400CD98 RID: 52632
		[Token(Token = "0x400CD98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UILongPressButton m_longPressBtnOnTarget;

		// Token: 0x0400CD99 RID: 52633
		[Token(Token = "0x400CD99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Button m_target;

		// Token: 0x0400CD9A RID: 52634
		[Token(Token = "0x400CD9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UILongPressButtonEx m_longPressButtonExTarget;
	}
}
