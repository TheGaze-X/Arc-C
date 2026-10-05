using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200680A RID: 26634
	[Token(Token = "0x200680A")]
	public class SideStoryMapDecroDataBinder : DataBinder<ZoneViewProperty>
	{
		// Token: 0x06026297 RID: 156311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026297")]
		[Address(RVA = "0x21344B0", Offset = "0x21330B0", VA = "0x1821344B0", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026298 RID: 156312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026298")]
		[Address(RVA = "0x2134730", Offset = "0x2133330", VA = "0x182134730")]
		private void _UpdateMapDecor(ZoneViewProperty property)
		{
		}

		// Token: 0x06026299 RID: 156313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026299")]
		[Address(RVA = "0x2134890", Offset = "0x2133490", VA = "0x182134890")]
		public SideStoryMapDecroDataBinder()
		{
		}

		// Token: 0x04035C18 RID: 220184
		[Token(Token = "0x4035C18")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SideStoryMapDecroLoader _loader;

		// Token: 0x04035C19 RID: 220185
		[Token(Token = "0x4035C19")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _mapDecorCanvasGroup;

		// Token: 0x04035C1A RID: 220186
		[Token(Token = "0x4035C1A")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_zoneGroupSwitch;

		// Token: 0x04035C1B RID: 220187
		[Token(Token = "0x4035C1B")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_mapDecorSwitch;

		// Token: 0x04035C1C RID: 220188
		[Token(Token = "0x4035C1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035C1D RID: 220189
		[Token(Token = "0x4035C1D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateMapDecor;

		// Token: 0x04035C1E RID: 220190
		[Token(Token = "0x4035C1E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
