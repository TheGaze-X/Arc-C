using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F94 RID: 16276
	[Token(Token = "0x2003F94")]
	public class SiracusaSmallMapAreaFogView : SiracusaMapAreaFogViewBase
	{
		// Token: 0x060193F7 RID: 103415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193F7")]
		[Address(RVA = "0x11F5600", Offset = "0x11F4200", VA = "0x1811F5600", Slot = "4")]
		public override void Render(SiracusaData.AreaData areaData, bool isShow)
		{
		}

		// Token: 0x060193F8 RID: 103416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193F8")]
		[Address(RVA = "0x11F57C0", Offset = "0x11F43C0", VA = "0x1811F57C0")]
		public SiracusaSmallMapAreaFogView()
		{
		}

		// Token: 0x0401F563 RID: 128355
		[Token(Token = "0x401F563")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIDynImage _imgAreaIcon;

		// Token: 0x0401F564 RID: 128356
		[Token(Token = "0x401F564")]
		[FieldOffset(Offset = "0x40")]
		private string m_areaId;

		// Token: 0x0401F565 RID: 128357
		[Token(Token = "0x401F565")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F566 RID: 128358
		[Token(Token = "0x401F566")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
