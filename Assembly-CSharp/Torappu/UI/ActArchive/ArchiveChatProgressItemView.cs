using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B4A RID: 27466
	[Token(Token = "0x2006B4A")]
	public class ArchiveChatProgressItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027415 RID: 160789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027415")]
		[Address(RVA = "0x226DCB0", Offset = "0x226C8B0", VA = "0x18226DCB0")]
		public void Render(bool isSelected, Color selectedColor)
		{
		}

		// Token: 0x06027416 RID: 160790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027416")]
		[Address(RVA = "0x226DDD0", Offset = "0x226C9D0", VA = "0x18226DDD0")]
		public ArchiveChatProgressItemView()
		{
		}

		// Token: 0x040378E5 RID: 227557
		[Token(Token = "0x40378E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgSelected;

		// Token: 0x040378E6 RID: 227558
		[Token(Token = "0x40378E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x040378E7 RID: 227559
		[Token(Token = "0x40378E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040378E8 RID: 227560
		[Token(Token = "0x40378E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
