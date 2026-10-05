using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700023B")]
		public override object source
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x5AD8A00", Offset = "0x5AD7600", VA = "0x185AD8A00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x5AD8220", Offset = "0x5AD6E20", VA = "0x185AD8220", Slot = "5")]
		public override object GetGenericData(string key)
		{
			return null;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x5AD82D0", Offset = "0x5AD6ED0", VA = "0x185AD82D0", Slot = "7")]
		public void StartDrag(StartDragArgs args, Vector3 pointerPosition)
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x5AD8890", Offset = "0x5AD7490", VA = "0x185AD8890", Slot = "8")]
		public void UpdateDrag(Vector3 pointerPosition)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public void AcceptDrag()
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20", Slot = "11")]
		public void SetVisualMode(DragVisualMode mode)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x5AD81B0", Offset = "0x5AD6DB0", VA = "0x185AD81B0", Slot = "10")]
		public void DragCleanup()
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700023C")]
		public DragAndDropData data
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x5AD8990", Offset = "0x5AD7590", VA = "0x185AD8990")]
		public DefaultDragAndDropClient()
		{
		}

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x10")]
		private readonly Hashtable m_GenericData;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x18")]
		private Label m_DraggedInfoLabel;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x20")]
		private DragVisualMode m_VisualMode;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerable<Object> m_UnityObjectReferences;
	}
}
