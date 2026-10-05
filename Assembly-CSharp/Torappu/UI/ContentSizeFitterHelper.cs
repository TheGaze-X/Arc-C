using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x02003779 RID: 14201
	[Token(Token = "0x2003779")]
	internal class ContentSizeFitterHelper : UIBehaviour
	{
		// Token: 0x060168A8 RID: 92328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A8")]
		[Address(RVA = "0xEF2D80", Offset = "0xEF1980", VA = "0x180EF2D80", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060168A9 RID: 92329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60168A9")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public ContentSizeFitterHelper()
		{
		}

		// Token: 0x0401B297 RID: 111255
		[Token(Token = "0x401B297")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action eSizeChanged;
	}
}
