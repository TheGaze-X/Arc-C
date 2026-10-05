using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E93 RID: 24211
	[Token(Token = "0x2005E93")]
	public class ItemRepoCharBackView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023141 RID: 143681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023141")]
		[Address(RVA = "0x1D8FD40", Offset = "0x1D8E940", VA = "0x181D8FD40")]
		public void OnClick()
		{
		}

		// Token: 0x06023142 RID: 143682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023142")]
		[Address(RVA = "0x1D8FDC0", Offset = "0x1D8E9C0", VA = "0x181D8FDC0")]
		public void Render(ItemBundle charInfo, bool clickable)
		{
		}

		// Token: 0x06023143 RID: 143683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023143")]
		[Address(RVA = "0x1D8FF60", Offset = "0x1D8EB60", VA = "0x181D8FF60")]
		public ItemRepoCharBackView()
		{
		}

		// Token: 0x04030506 RID: 197894
		[Token(Token = "0x4030506")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _charProtrait;

		// Token: 0x04030507 RID: 197895
		[Token(Token = "0x4030507")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x04030508 RID: 197896
		[Token(Token = "0x4030508")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public UIStringEvent onClickEvent;

		// Token: 0x04030509 RID: 197897
		[Token(Token = "0x4030509")]
		[FieldOffset(Offset = "0x30")]
		private string m_cacheCharId;

		// Token: 0x0403050A RID: 197898
		[Token(Token = "0x403050A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403050B RID: 197899
		[Token(Token = "0x403050B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403050C RID: 197900
		[Token(Token = "0x403050C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
