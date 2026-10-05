using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002367 RID: 9063
	[Token(Token = "0x2002367")]
	[SelectionBase]
	public class MapWidget : VisualObject
	{
		// Token: 0x0600E5AC RID: 58796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5AC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		public virtual void Init()
		{
		}

		// Token: 0x0600E5AD RID: 58797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E5AD")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public MapWidget()
		{
		}

		// Token: 0x0400FD7A RID: 64890
		[Token(Token = "0x400FD7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Expandable(AlwaysExpanded = true)]
		private GridPosition _anchorPos;
	}
}
