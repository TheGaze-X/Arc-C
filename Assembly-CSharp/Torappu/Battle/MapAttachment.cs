using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200235E RID: 9054
	[Token(Token = "0x200235E")]
	[SelectionBase]
	public class MapAttachment : MapWidget, ITileListener
	{
		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x0600E591 RID: 58769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CC6")]
		public GridPosition[] attachedTiles
		{
			[Token(Token = "0x600E591")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E592 RID: 58770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E592")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public void OnLocatedCharacterUpdate(Character character)
		{
		}

		// Token: 0x0600E593 RID: 58771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E593")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public void OnEntityEnter(Entity entity)
		{
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E594")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public void OnEntityLeave(Entity entity)
		{
		}

		// Token: 0x0600E595 RID: 58773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E595")]
		[Address(RVA = "0x5C1630", Offset = "0x5C0230", VA = "0x1805C1630")]
		public MapAttachment()
		{
		}

		// Token: 0x0400FD41 RID: 64833
		[Token(Token = "0x400FD41")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridPosition[] _attachedTiles;
	}
}
