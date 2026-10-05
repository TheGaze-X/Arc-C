using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F96 RID: 16278
	[Token(Token = "0x2003F96")]
	public class SiracusaSmallMapNormalNodeView : SiracusaMapNodeViewBase
	{
		// Token: 0x060193FD RID: 103421 RVA: 0x0009D5A8 File Offset: 0x0009B7A8
		[Token(Token = "0x60193FD")]
		[Address(RVA = "0x11F5F00", Offset = "0x11F4B00", VA = "0x1811F5F00", Slot = "4")]
		public override SiracusaMapNodeViewBase.ViewType GetViewType()
		{
			return SiracusaMapNodeViewBase.ViewType.NORMAL;
		}

		// Token: 0x060193FE RID: 103422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193FE")]
		[Address(RVA = "0x11F5F60", Offset = "0x11F4B60", VA = "0x1811F5F60", Slot = "5")]
		public override void Render(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x060193FF RID: 103423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193FF")]
		[Address(RVA = "0x11F6080", Offset = "0x11F4C80", VA = "0x1811F6080")]
		public SiracusaSmallMapNormalNodeView()
		{
		}

		// Token: 0x0401F56F RID: 128367
		[Token(Token = "0x401F56F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _imgLogo;

		// Token: 0x0401F570 RID: 128368
		[Token(Token = "0x401F570")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F571 RID: 128369
		[Token(Token = "0x401F571")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F572 RID: 128370
		[Token(Token = "0x401F572")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
