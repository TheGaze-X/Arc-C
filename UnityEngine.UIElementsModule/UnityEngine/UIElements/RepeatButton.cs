using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	public class RepeatButton : TextElement
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x5AC1530", Offset = "0x5AC0130", VA = "0x185AC1530")]
		public RepeatButton()
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x5AC1460", Offset = "0x5AC0060", VA = "0x185AC1460")]
		public RepeatButton(Action clickEvent, long delay, long interval)
		{
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x5AC1320", Offset = "0x5ABFF20", VA = "0x185AC1320")]
		public void SetAction(Action clickEvent, long delay, long interval)
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x5AC12F0", Offset = "0x5ABFEF0", VA = "0x185AC12F0")]
		internal void AddAction(Action clickEvent)
		{
		}

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x478")]
		private Clickable m_Clickable;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x02000137 RID: 311
		[Token(Token = "0x2000137")]
		public new class UxmlFactory : UxmlFactory<RepeatButton, RepeatButton.UxmlTraits>
		{
			// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x5AD2EB0", Offset = "0x5AD1AB0", VA = "0x185AD2EB0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000138 RID: 312
		[Token(Token = "0x2000138")]
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x060008B0 RID: 2224 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x5AD37D0", Offset = "0x5AD23D0", VA = "0x185AD37D0", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x5AD6D50", Offset = "0x5AD5950", VA = "0x185AD6D50")]
			public UxmlTraits()
			{
			}

			// Token: 0x040004AE RID: 1198
			[Token(Token = "0x40004AE")]
			[FieldOffset(Offset = "0x90")]
			private UxmlLongAttributeDescription m_Delay;

			// Token: 0x040004AF RID: 1199
			[Token(Token = "0x40004AF")]
			[FieldOffset(Offset = "0x98")]
			private UxmlLongAttributeDescription m_Interval;
		}
	}
}
