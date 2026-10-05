using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E85 RID: 7813
	[Token(Token = "0x2001E85")]
	public class AVGButton : MonoBehaviour, IHotfixable, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x0600C18A RID: 49546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C18A")]
		[Address(RVA = "0x33D4F30", Offset = "0x33D3B30", VA = "0x1833D4F30")]
		private void _OnPointerExit()
		{
		}

		// Token: 0x0600C18B RID: 49547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C18B")]
		[Address(RVA = "0x33D49F0", Offset = "0x33D35F0", VA = "0x1833D49F0")]
		private void Update()
		{
		}

		// Token: 0x0600C18C RID: 49548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C18C")]
		[Address(RVA = "0x33D48A0", Offset = "0x33D34A0", VA = "0x1833D48A0", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600C18D RID: 49549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C18D")]
		[Address(RVA = "0x33D4FE0", Offset = "0x33D3BE0", VA = "0x1833D4FE0")]
		public AVGButton()
		{
		}

		// Token: 0x0400C304 RID: 49924
		[Token(Token = "0x400C304")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Millsecs")]
		private int _longPressThreshold;

		// Token: 0x0400C305 RID: 49925
		[Token(Token = "0x400C305")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _dragDiatance;

		// Token: 0x0400C306 RID: 49926
		[Token(Token = "0x400C306")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action onClickAction;

		// Token: 0x0400C307 RID: 49927
		[Token(Token = "0x400C307")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<Vector2> onLongPressAction;

		// Token: 0x0400C308 RID: 49928
		[Token(Token = "0x400C308")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<Vector2> onDragAction;

		// Token: 0x0400C309 RID: 49929
		[Token(Token = "0x400C309")]
		[FieldOffset(Offset = "0x38")]
		private AVGButton.DragContext m_context;

		// Token: 0x0400C30A RID: 49930
		[Token(Token = "0x400C30A")]
		[FieldOffset(Offset = "0x48")]
		private AVGButton.State m_state;

		// Token: 0x0400C30B RID: 49931
		[Token(Token = "0x400C30B")]
		[FieldOffset(Offset = "0x50")]
		private DateTime m_pressStartTime;

		// Token: 0x0400C30C RID: 49932
		[Token(Token = "0x400C30C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnPointerExit;

		// Token: 0x0400C30D RID: 49933
		[Token(Token = "0x400C30D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400C30E RID: 49934
		[Token(Token = "0x400C30E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0400C30F RID: 49935
		[Token(Token = "0x400C30F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E86 RID: 7814
		[Token(Token = "0x2001E86")]
		private enum State
		{
			// Token: 0x0400C311 RID: 49937
			[Token(Token = "0x400C311")]
			NONE,
			// Token: 0x0400C312 RID: 49938
			[Token(Token = "0x400C312")]
			CLICK,
			// Token: 0x0400C313 RID: 49939
			[Token(Token = "0x400C313")]
			LONG_PRESS
		}

		// Token: 0x02001E87 RID: 7815
		[Token(Token = "0x2001E87")]
		private struct DragContext
		{
			// Token: 0x1700173C RID: 5948
			// (get) Token: 0x0600C18E RID: 49550 RVA: 0x00047118 File Offset: 0x00045318
			// (set) Token: 0x0600C18F RID: 49551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700173C")]
			public int pointerId
			{
				[Token(Token = "0x600C18E")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x600C18F")]
				[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700173D RID: 5949
			// (get) Token: 0x0600C190 RID: 49552 RVA: 0x00047130 File Offset: 0x00045330
			// (set) Token: 0x0600C191 RID: 49553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700173D")]
			public bool isEmpty
			{
				[Token(Token = "0x600C190")]
				[Address(RVA = "0x33E8C90", Offset = "0x33E7890", VA = "0x1833E8C90")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x600C191")]
				[Address(RVA = "0x33E8CA0", Offset = "0x33E78A0", VA = "0x1833E8CA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700173E RID: 5950
			// (get) Token: 0x0600C192 RID: 49554 RVA: 0x00047148 File Offset: 0x00045348
			// (set) Token: 0x0600C193 RID: 49555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700173E")]
			public Vector2 startPos
			{
				[Token(Token = "0x600C192")]
				[Address(RVA = "0x15795A0", Offset = "0x15781A0", VA = "0x1815795A0")]
				[CompilerGenerated]
				readonly get
				{
					return default(Vector2);
				}
				[Token(Token = "0x600C193")]
				[Address(RVA = "0x33E8CB0", Offset = "0x33E78B0", VA = "0x1833E8CB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600C194 RID: 49556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C194")]
			[Address(RVA = "0x33E8C20", Offset = "0x33E7820", VA = "0x1833E8C20")]
			public DragContext(int pointerID, Vector2 startPos)
			{
			}

			// Token: 0x0400C314 RID: 49940
			[Token(Token = "0x400C314")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AVGButton.DragContext EMPTY;
		}
	}
}
