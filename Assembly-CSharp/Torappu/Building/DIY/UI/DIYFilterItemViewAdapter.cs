using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200193C RID: 6460
	[Token(Token = "0x200193C")]
	public class DIYFilterItemViewAdapter : LoopScrollAdapter<DIYFilterItemViewAdapter.ViewHolder, DIYShopFilterViewData>
	{
		// Token: 0x14000043 RID: 67
		// (add) Token: 0x0600A27C RID: 41596 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A27D RID: 41597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000043")]
		public event Action<DIYShopFilterViewData> furnitureSelected
		{
			[Token(Token = "0x600A27C")]
			[Address(RVA = "0x31BDA80", Offset = "0x31BC680", VA = "0x1831BDA80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A27D")]
			[Address(RVA = "0x31BDD80", Offset = "0x31BC980", VA = "0x1831BDD80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x0600A27E RID: 41598 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A27F RID: 41599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000044")]
		public event Action<DIYShopFilterViewData> infoSelected
		{
			[Token(Token = "0x600A27E")]
			[Address(RVA = "0x31BDB80", Offset = "0x31BC780", VA = "0x1831BDB80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A27F")]
			[Address(RVA = "0x31BDE80", Offset = "0x31BCA80", VA = "0x1831BDE80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x0600A280 RID: 41600 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A281 RID: 41601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000045")]
		public event Action<DIYShopFilterViewData> descSelected
		{
			[Token(Token = "0x600A280")]
			[Address(RVA = "0x31BD980", Offset = "0x31BC580", VA = "0x1831BD980")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A281")]
			[Address(RVA = "0x31BDC80", Offset = "0x31BC880", VA = "0x1831BDC80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A282")]
		[Address(RVA = "0x31BD890", Offset = "0x31BC490", VA = "0x1831BD890")]
		private void _OnButtonPressed(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A283")]
		[Address(RVA = "0x31BD810", Offset = "0x31BC410", VA = "0x1831BD810")]
		private void _OnButtonInfoPressed(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A284")]
		[Address(RVA = "0x31BD790", Offset = "0x31BC390", VA = "0x1831BD790")]
		private void _OnButtonDescPressed(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A285 RID: 41605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A285")]
		[Address(RVA = "0x31BD440", Offset = "0x31BC040", VA = "0x1831BD440", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A286")]
		[Address(RVA = "0x31BD4F0", Offset = "0x31BC0F0", VA = "0x1831BD4F0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, DIYFilterItemViewAdapter.ViewHolder holder, DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A287")]
		[Address(RVA = "0x31BD910", Offset = "0x31BC510", VA = "0x1831BD910")]
		public DIYFilterItemViewAdapter()
		{
		}

		// Token: 0x040098C5 RID: 39109
		[Token(Token = "0x40098C5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _furnitureViewPrefab;

		// Token: 0x040098C9 RID: 39113
		[Token(Token = "0x40098C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_furnitureSelected;

		// Token: 0x040098CA RID: 39114
		[Token(Token = "0x40098CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_furnitureSelected;

		// Token: 0x040098CB RID: 39115
		[Token(Token = "0x40098CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_add_infoSelected;

		// Token: 0x040098CC RID: 39116
		[Token(Token = "0x40098CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_remove_infoSelected;

		// Token: 0x040098CD RID: 39117
		[Token(Token = "0x40098CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_add_descSelected;

		// Token: 0x040098CE RID: 39118
		[Token(Token = "0x40098CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_remove_descSelected;

		// Token: 0x040098CF RID: 39119
		[Token(Token = "0x40098CF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnButtonPressed;

		// Token: 0x040098D0 RID: 39120
		[Token(Token = "0x40098D0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnButtonInfoPressed;

		// Token: 0x040098D1 RID: 39121
		[Token(Token = "0x40098D1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnButtonDescPressed;

		// Token: 0x040098D2 RID: 39122
		[Token(Token = "0x40098D2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040098D3 RID: 39123
		[Token(Token = "0x40098D3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040098D4 RID: 39124
		[Token(Token = "0x40098D4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200193D RID: 6461
		[Token(Token = "0x200193D")]
		public struct ViewHolder
		{
			// Token: 0x040098D5 RID: 39125
			[Token(Token = "0x40098D5")]
			[FieldOffset(Offset = "0x0")]
			public GameObject panel;
		}
	}
}
