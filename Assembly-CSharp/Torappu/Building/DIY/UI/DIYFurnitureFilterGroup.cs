using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001987 RID: 6535
	[Token(Token = "0x2001987")]
	public class DIYFurnitureFilterGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A3F6 RID: 41974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3F6")]
		[Address(RVA = "0x31DB3D0", Offset = "0x31D9FD0", VA = "0x1831DB3D0")]
		public void SetFilterGroupIndex(int index)
		{
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3F7")]
		[Address(RVA = "0x31DB5B0", Offset = "0x31DA1B0", VA = "0x1831DB5B0")]
		public DIYFurnitureFilterGroup()
		{
		}

		// Token: 0x04009AE0 RID: 39648
		[Token(Token = "0x4009AE0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYFurnitureFilterGroup.FilterGroupItem[] _filters;

		// Token: 0x04009AE1 RID: 39649
		[Token(Token = "0x4009AE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetFilterGroupIndex;

		// Token: 0x04009AE2 RID: 39650
		[Token(Token = "0x4009AE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001988 RID: 6536
		[Token(Token = "0x2001988")]
		[Serializable]
		public class FilterGroupItem
		{
			// Token: 0x0600A3F8 RID: 41976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3F8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FilterGroupItem()
			{
			}

			// Token: 0x04009AE3 RID: 39651
			[Token(Token = "0x4009AE3")]
			[FieldOffset(Offset = "0x10")]
			public GameObject selectGameObject;

			// Token: 0x04009AE4 RID: 39652
			[Token(Token = "0x4009AE4")]
			[FieldOffset(Offset = "0x18")]
			public GameObject unselectGameObject;
		}
	}
}
