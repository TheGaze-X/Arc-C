using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[RequireComponent(typeof(InputField))]
	public class InputFieldFocusDetector : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600078C RID: 1932 RVA: 0x0000206A File Offset: 0x0000026A
		// (remove) Token: 0x0600078D RID: 1933 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x14000014")]
		public event Action<bool> OnFocusChanged
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x5C4D290", Offset = "0x5C4BE90", VA = "0x185C4D290")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x5C4D340", Offset = "0x5C4BF40", VA = "0x185C4D340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0000344C File Offset: 0x0000164C
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700008C")]
		public bool IsFocused
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x5C4D3F0", Offset = "0x5C4BFF0", VA = "0x185C4D3F0")]
			private set
			{
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x5C4D1A0", Offset = "0x5C4BDA0", VA = "0x185C4D1A0")]
		private void Awake()
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x5C4D250", Offset = "0x5C4BE50", VA = "0x185C4D250")]
		private void Start()
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x5C4D220", Offset = "0x5C4BE20", VA = "0x185C4D220", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x5C4D1F0", Offset = "0x5C4BDF0", VA = "0x185C4D1F0", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x5C4D250", Offset = "0x5C4BE50", VA = "0x185C4D250")]
		public void UpdateFocusState()
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public InputFieldFocusDetector()
		{
		}

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x18")]
		private InputField inputField;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x28")]
		private bool _isFocused;
	}
}
