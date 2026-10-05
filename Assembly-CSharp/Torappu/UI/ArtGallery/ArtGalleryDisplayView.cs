using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065FE RID: 26110
	[Token(Token = "0x20065FE")]
	public class ArtGalleryDisplayView : DataBinder<ArtGalleryDisplayProperty>
	{
		// Token: 0x06025848 RID: 153672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025848")]
		[Address(RVA = "0x2081970", Offset = "0x2080570", VA = "0x182081970", Slot = "7")]
		public override void OnValueChanged(ArtGalleryDisplayProperty property)
		{
		}

		// Token: 0x06025849 RID: 153673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025849")]
		[Address(RVA = "0x2081A40", Offset = "0x2080640", VA = "0x182081A40")]
		public ArtGalleryDisplayView()
		{
		}

		// Token: 0x04034B05 RID: 215813
		[Token(Token = "0x4034B05")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtGalleryFilterItemView[] _filterItemList;

		// Token: 0x04034B06 RID: 215814
		[Token(Token = "0x4034B06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034B07 RID: 215815
		[Token(Token = "0x4034B07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
