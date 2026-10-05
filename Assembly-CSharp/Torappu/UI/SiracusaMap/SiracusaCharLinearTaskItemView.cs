using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F10 RID: 16144
	[Token(Token = "0x2003F10")]
	public class SiracusaCharLinearTaskItemView : SiracusaCharTaskItemView
	{
		// Token: 0x06019118 RID: 102680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019118")]
		[Address(RVA = "0x11B1850", Offset = "0x11B0450", VA = "0x1811B1850", Slot = "4")]
		public override void Render(SiracusaCharTaskRingModel taskRingModel, SiracusaCharTaskModel taskModel)
		{
		}

		// Token: 0x06019119 RID: 102681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019119")]
		[Address(RVA = "0x11B19B0", Offset = "0x11B05B0", VA = "0x1811B19B0")]
		public SiracusaCharLinearTaskItemView()
		{
		}

		// Token: 0x0601911A RID: 102682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601911A")]
		[Address(RVA = "0x11B19A0", Offset = "0x11B05A0", VA = "0x1811B19A0")]
		private void <>xLuaBaseProxy_Render(SiracusaCharTaskRingModel P0, SiracusaCharTaskModel P1)
		{
		}

		// Token: 0x0401F025 RID: 127013
		[Token(Token = "0x401F025")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _imgStatus;

		// Token: 0x0401F026 RID: 127014
		[Token(Token = "0x401F026")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasObject _statusAtlas;

		// Token: 0x0401F027 RID: 127015
		[Token(Token = "0x401F027")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _iconDoingName;

		// Token: 0x0401F028 RID: 127016
		[Token(Token = "0x401F028")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _iconDoneName;

		// Token: 0x0401F029 RID: 127017
		[Token(Token = "0x401F029")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F02A RID: 127018
		[Token(Token = "0x401F02A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
