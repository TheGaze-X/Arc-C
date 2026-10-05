using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200659C RID: 26012
	[Token(Token = "0x200659C")]
	public class ArtMagazineDiyGridAvatarItem : ArtMagazineDiyGridItemBase
	{
		// Token: 0x06025669 RID: 153193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025669")]
		[Address(RVA = "0x20627C0", Offset = "0x20613C0", VA = "0x1820627C0", Slot = "4")]
		protected override void OnRender(IArtMagazineDiyItemViewModel itemModel, bool isSelected)
		{
		}

		// Token: 0x0602566A RID: 153194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602566A")]
		[Address(RVA = "0x2062920", Offset = "0x2061520", VA = "0x182062920")]
		public ArtMagazineDiyGridAvatarItem()
		{
		}

		// Token: 0x040347A6 RID: 214950
		[Token(Token = "0x40347A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _avatarPic;

		// Token: 0x040347A7 RID: 214951
		[Token(Token = "0x40347A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x040347A8 RID: 214952
		[Token(Token = "0x40347A8")]
		[FieldOffset(Offset = "0x48")]
		private string m_cacheAvatarId;

		// Token: 0x040347A9 RID: 214953
		[Token(Token = "0x40347A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040347AA RID: 214954
		[Token(Token = "0x40347AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
