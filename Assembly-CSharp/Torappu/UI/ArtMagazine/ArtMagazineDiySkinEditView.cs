using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200656D RID: 25965
	[Token(Token = "0x200656D")]
	public class ArtMagazineDiySkinEditView : DataBinder<ArtMagazineDiyHomeProperty>
	{
		// Token: 0x1700581E RID: 22558
		// (get) Token: 0x0602555C RID: 152924 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602555D RID: 152925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700581E")]
		public ArtMagazineDiyLeafCharIllustHolder.LeafCharSkinWrapper charSkinWrapper
		{
			[Token(Token = "0x602555C")]
			[Address(RVA = "0x2050D00", Offset = "0x204F900", VA = "0x182050D00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602555D")]
			[Address(RVA = "0x2050D60", Offset = "0x204F960", VA = "0x182050D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602555E RID: 152926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602555E")]
		[Address(RVA = "0x2050550", Offset = "0x204F150", VA = "0x182050550", Slot = "7")]
		public override void OnValueChanged(ArtMagazineDiyHomeProperty property)
		{
		}

		// Token: 0x0602555F RID: 152927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602555F")]
		[Address(RVA = "0x20509D0", Offset = "0x204F5D0", VA = "0x1820509D0")]
		private void _UpdateSize()
		{
		}

		// Token: 0x06025560 RID: 152928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025560")]
		[Address(RVA = "0x2050850", Offset = "0x204F450", VA = "0x182050850")]
		private void _UpdatePos()
		{
		}

		// Token: 0x06025561 RID: 152929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025561")]
		[Address(RVA = "0x20507E0", Offset = "0x204F3E0", VA = "0x1820507E0")]
		protected void Update()
		{
		}

		// Token: 0x06025562 RID: 152930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025562")]
		[Address(RVA = "0x2050370", Offset = "0x204EF70", VA = "0x182050370")]
		public void EventOpenHomeState()
		{
		}

		// Token: 0x06025563 RID: 152931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025563")]
		[Address(RVA = "0x2050460", Offset = "0x204F060", VA = "0x182050460")]
		public void EventOpenSkinSelectState()
		{
		}

		// Token: 0x06025564 RID: 152932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025564")]
		[Address(RVA = "0x2050280", Offset = "0x204EE80", VA = "0x182050280")]
		public void EventOnResetClick()
		{
		}

		// Token: 0x06025565 RID: 152933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025565")]
		[Address(RVA = "0x2050C90", Offset = "0x204F890", VA = "0x182050C90")]
		public ArtMagazineDiySkinEditView()
		{
		}

		// Token: 0x04034629 RID: 214569
		[Token(Token = "0x4034629")]
		private const float SIZE_MIN_VAL = 100f;

		// Token: 0x0403462A RID: 214570
		[Token(Token = "0x403462A")]
		private const float SIZE_MAX_VAL = 300f;

		// Token: 0x0403462B RID: 214571
		[Token(Token = "0x403462B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _posText;

		// Token: 0x0403462C RID: 214572
		[Token(Token = "0x403462C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _sizeText;

		// Token: 0x0403462D RID: 214573
		[Token(Token = "0x403462D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _sizeMax;

		// Token: 0x0403462E RID: 214574
		[Token(Token = "0x403462E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _sizeMin;

		// Token: 0x0403462F RID: 214575
		[Token(Token = "0x403462F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x04034630 RID: 214576
		[Token(Token = "0x4034630")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034631 RID: 214577
		[Token(Token = "0x4034631")]
		[FieldOffset(Offset = "0x58")]
		private ArtMagazineLeafCharViewModel m_charModel;

		// Token: 0x04034632 RID: 214578
		[Token(Token = "0x4034632")]
		[FieldOffset(Offset = "0x60")]
		private float m_normalizedSizeMin;

		// Token: 0x04034633 RID: 214579
		[Token(Token = "0x4034633")]
		[FieldOffset(Offset = "0x64")]
		private float m_normalizedSizeMax;

		// Token: 0x04034635 RID: 214581
		[Token(Token = "0x4034635")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charSkinWrapper;

		// Token: 0x04034636 RID: 214582
		[Token(Token = "0x4034636")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charSkinWrapper;

		// Token: 0x04034637 RID: 214583
		[Token(Token = "0x4034637")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034638 RID: 214584
		[Token(Token = "0x4034638")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateSize;

		// Token: 0x04034639 RID: 214585
		[Token(Token = "0x4034639")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdatePos;

		// Token: 0x0403463A RID: 214586
		[Token(Token = "0x403463A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403463B RID: 214587
		[Token(Token = "0x403463B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOpenHomeState;

		// Token: 0x0403463C RID: 214588
		[Token(Token = "0x403463C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOpenSkinSelectState;

		// Token: 0x0403463D RID: 214589
		[Token(Token = "0x403463D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnResetClick;

		// Token: 0x0403463E RID: 214590
		[Token(Token = "0x403463E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
