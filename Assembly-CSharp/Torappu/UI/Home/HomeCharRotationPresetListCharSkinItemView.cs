using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AE8 RID: 19176
	[Token(Token = "0x2004AE8")]
	public class HomeCharRotationPresetListCharSkinItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170043FF RID: 17407
		// (get) Token: 0x0601CCE4 RID: 117988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170043FF")]
		public UIColorGraphic itemGraphic
		{
			[Token(Token = "0x601CCE4")]
			[Address(RVA = "0x16412D0", Offset = "0x163FED0", VA = "0x1816412D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601CCE5 RID: 117989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCE5")]
		[Address(RVA = "0x1641110", Offset = "0x163FD10", VA = "0x181641110")]
		public void Render(HomeCharRotationPresetSkinItemViewModel skin, string profileSkinTag)
		{
		}

		// Token: 0x0601CCE6 RID: 117990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCE6")]
		[Address(RVA = "0x1641270", Offset = "0x163FE70", VA = "0x181641270")]
		public HomeCharRotationPresetListCharSkinItemView()
		{
		}

		// Token: 0x04025C9F RID: 154783
		[Token(Token = "0x4025C9F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlEmptyChar;

		// Token: 0x04025CA0 RID: 154784
		[Token(Token = "0x4025CA0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlChar;

		// Token: 0x04025CA1 RID: 154785
		[Token(Token = "0x4025CA1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _charAvatar;

		// Token: 0x04025CA2 RID: 154786
		[Token(Token = "0x4025CA2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlProfileChar;

		// Token: 0x04025CA3 RID: 154787
		[Token(Token = "0x4025CA3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlSpDynIllust;

		// Token: 0x04025CA4 RID: 154788
		[Token(Token = "0x4025CA4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _itemGraphic;

		// Token: 0x04025CA5 RID: 154789
		[Token(Token = "0x4025CA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemGraphic;

		// Token: 0x04025CA6 RID: 154790
		[Token(Token = "0x4025CA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025CA7 RID: 154791
		[Token(Token = "0x4025CA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
