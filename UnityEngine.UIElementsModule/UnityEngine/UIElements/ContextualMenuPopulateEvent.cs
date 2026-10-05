using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
	{
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B7")]
		public DropdownMenu menu
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x22F8A60", Offset = "0x22F7660", VA = "0x1822F8A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		public EventBase triggerEvent
		{
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x5AD7D60", Offset = "0x5AD6960", VA = "0x185AD7D60", Slot = "12")]
		protected override void Init()
		{
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x5AD7DB0", Offset = "0x5AD69B0", VA = "0x185AD7DB0")]
		private void LocalInit()
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x5AD7F20", Offset = "0x5AD6B20", VA = "0x185AD7F20")]
		public ContextualMenuPopulateEvent()
		{
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x5AD7E40", Offset = "0x5AD6A40", VA = "0x185AD7E40", Slot = "9")]
		protected internal override void PostDispatch(IPanel panel)
		{
		}

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0xC8")]
		private ContextualMenuManager m_ContextualMenuManager;
	}
}
