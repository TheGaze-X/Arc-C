using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C78 RID: 7288
	[Token(Token = "0x2001C78")]
	public class BuildingStationSelectBuffIcon : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B519 RID: 46361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B519")]
		[Address(RVA = "0x32ED000", Offset = "0x32EBC00", VA = "0x1832ED000")]
		public void Render(StationCharViewModel.BuffStruct buffStruct)
		{
		}

		// Token: 0x0600B51A RID: 46362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51A")]
		[Address(RVA = "0x32ED360", Offset = "0x32EBF60", VA = "0x1832ED360")]
		public BuildingStationSelectBuffIcon()
		{
		}

		// Token: 0x0400B11C RID: 45340
		[Token(Token = "0x400B11C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400B11D RID: 45341
		[Token(Token = "0x400B11D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgHalo;

		// Token: 0x0400B11E RID: 45342
		[Token(Token = "0x400B11E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgHilight;

		// Token: 0x0400B11F RID: 45343
		[Token(Token = "0x400B11F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _disableAlpha;

		// Token: 0x0400B120 RID: 45344
		[Token(Token = "0x400B120")]
		[FieldOffset(Offset = "0x38")]
		private StationCharViewModel.BuffStruct m_buffCache;

		// Token: 0x0400B121 RID: 45345
		[Token(Token = "0x400B121")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0400B122 RID: 45346
		[Token(Token = "0x400B122")]
		[FieldOffset(Offset = "0x48")]
		private BuildingBuffImgConfig m_imageConfig;

		// Token: 0x0400B123 RID: 45347
		[Token(Token = "0x400B123")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B124 RID: 45348
		[Token(Token = "0x400B124")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
