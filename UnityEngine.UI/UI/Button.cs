using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[AddComponentMenu("UI/Button", 30)]
	public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5A068A0", Offset = "0x5A054A0", VA = "0x185A068A0")]
		protected Button()
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000006")]
		public Button.ButtonClickedEvent onClick
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x4D6D140", Offset = "0x4D6BD40", VA = "0x184D6D140")]
			set
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5A067E0", Offset = "0x5A053E0", VA = "0x185A067E0")]
		private void Press()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5A066A0", Offset = "0x5A052A0", VA = "0x185A066A0", Slot = "43")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5A066D0", Offset = "0x5A052D0", VA = "0x185A066D0", Slot = "44")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5A06620", Offset = "0x5A05220", VA = "0x185A06620")]
		private IEnumerator OnFinishSubmit()
		{
			return null;
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[FormerlySerializedAs("onClick")]
		private Button.ButtonClickedEvent m_OnClick;

		// Token: 0x02000004 RID: 4
		[Token(Token = "0x2000004")]
		[Serializable]
		public class ButtonClickedEvent : UnityEvent
		{
			// Token: 0x06000013 RID: 19 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
			public ButtonClickedEvent()
			{
			}
		}
	}
}
