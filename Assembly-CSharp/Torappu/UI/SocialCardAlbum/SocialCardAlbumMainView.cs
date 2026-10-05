using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EB1 RID: 16049
	[Token(Token = "0x2003EB1")]
	public class SocialCardAlbumMainView : DataBinder<SocialCardAlbumProperty>
	{
		// Token: 0x06018E9B RID: 102043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E9B")]
		[Address(RVA = "0x11A5570", Offset = "0x11A4170", VA = "0x1811A5570", Slot = "7")]
		public override void OnValueChanged(SocialCardAlbumProperty property)
		{
		}

		// Token: 0x06018E9C RID: 102044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E9C")]
		[Address(RVA = "0x11A5620", Offset = "0x11A4220", VA = "0x1811A5620")]
		public SocialCardAlbumMainView()
		{
		}

		// Token: 0x0401EBD8 RID: 125912
		[Token(Token = "0x401EBD8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SocialCardAlbumCardListView _listView;

		// Token: 0x0401EBD9 RID: 125913
		[Token(Token = "0x401EBD9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SocialCardAlbumSideView _sideView;

		// Token: 0x0401EBDA RID: 125914
		[Token(Token = "0x401EBDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EBDB RID: 125915
		[Token(Token = "0x401EBDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
