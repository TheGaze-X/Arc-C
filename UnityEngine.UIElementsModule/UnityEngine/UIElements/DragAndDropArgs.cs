using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	internal struct DragAndDropArgs : IListDragAndDropArgs
	{
		// Token: 0x1700024E RID: 590
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024E")]
		public object target
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00005B38 File Offset: 0x00003D38
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024F")]
		public int insertAtIndex
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00005B50 File Offset: 0x00003D50
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000250")]
		public int parentId
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x375DB10", Offset = "0x375C710", VA = "0x18375DB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00005B68 File Offset: 0x00003D68
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000251")]
		public int childIndex
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00005B80 File Offset: 0x00003D80
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000252")]
		public DragAndDropPosition dragAndDropPosition
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "8")]
			[CompilerGenerated]
			readonly get
			{
				return DragAndDropPosition.OverItem;
			}
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000253")]
		public IDragAndDropData dragAndDropData
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "7")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
