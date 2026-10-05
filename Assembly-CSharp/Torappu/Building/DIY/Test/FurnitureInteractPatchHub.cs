using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x020018FF RID: 6399
	[Token(Token = "0x20018FF")]
	public class FurnitureInteractPatchHub : ScriptableObject
	{
		// Token: 0x0600A144 RID: 41284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A144")]
		[Address(RVA = "0x31CB370", Offset = "0x31C9F70", VA = "0x1831CB370")]
		public FurnitureInteractPatchHub()
		{
		}

		// Token: 0x04009784 RID: 38788
		[Token(Token = "0x4009784")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private List<FurnitureInteractPatch> _patchDB;
	}
}
