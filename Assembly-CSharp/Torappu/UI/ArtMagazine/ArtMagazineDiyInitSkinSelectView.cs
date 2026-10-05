using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200656C RID: 25964
	[Token(Token = "0x200656C")]
	public class ArtMagazineDiyInitSkinSelectView : DataBinder<ArtMagazineDiyHomeProperty>
	{
		// Token: 0x06025558 RID: 152920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025558")]
		[Address(RVA = "0x204A950", Offset = "0x2049550", VA = "0x18204A950", Slot = "7")]
		public override void OnValueChanged(ArtMagazineDiyHomeProperty property)
		{
		}

		// Token: 0x06025559 RID: 152921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025559")]
		[Address(RVA = "0x204A770", Offset = "0x2049370", VA = "0x18204A770")]
		public void EventOpenHomeState()
		{
		}

		// Token: 0x0602555A RID: 152922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602555A")]
		[Address(RVA = "0x204A860", Offset = "0x2049460", VA = "0x18204A860")]
		public void EventOpenSkinEditState()
		{
		}

		// Token: 0x0602555B RID: 152923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602555B")]
		[Address(RVA = "0x204AC40", Offset = "0x2049840", VA = "0x18204AC40")]
		public ArtMagazineDiyInitSkinSelectView()
		{
		}

		// Token: 0x04034622 RID: 214562
		[Token(Token = "0x4034622")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04034623 RID: 214563
		[Token(Token = "0x4034623")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtMagazineDiySkinSelectCommonView _commonView;

		// Token: 0x04034624 RID: 214564
		[Token(Token = "0x4034624")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034625 RID: 214565
		[Token(Token = "0x4034625")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034626 RID: 214566
		[Token(Token = "0x4034626")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOpenHomeState;

		// Token: 0x04034627 RID: 214567
		[Token(Token = "0x4034627")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOpenSkinEditState;

		// Token: 0x04034628 RID: 214568
		[Token(Token = "0x4034628")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
