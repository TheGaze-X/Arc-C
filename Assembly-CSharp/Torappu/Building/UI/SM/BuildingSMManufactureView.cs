using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CD7 RID: 7383
	[Token(Token = "0x2001CD7")]
	public class BuildingSMManufactureView : BuildingSMSingleRoomTypeView
	{
		// Token: 0x0600B6BA RID: 46778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6BA")]
		[Address(RVA = "0x333E530", Offset = "0x333D130", VA = "0x18333E530", Slot = "4")]
		public override void Render(SelectedRoomDetailViewModel roomModel)
		{
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6BB")]
		[Address(RVA = "0x333E840", Offset = "0x333D440", VA = "0x18333E840")]
		public BuildingSMManufactureView()
		{
		}

		// Token: 0x0400B441 RID: 46145
		[Token(Token = "0x400B441")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textManpowerCost;

		// Token: 0x0400B442 RID: 46146
		[Token(Token = "0x400B442")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _mpBuffLayout;

		// Token: 0x0400B443 RID: 46147
		[Token(Token = "0x400B443")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textSpeed;

		// Token: 0x0400B444 RID: 46148
		[Token(Token = "0x400B444")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _speedBuffLayout;

		// Token: 0x0400B445 RID: 46149
		[Token(Token = "0x400B445")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _iconSpeedUp;

		// Token: 0x0400B446 RID: 46150
		[Token(Token = "0x400B446")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _iconMpDown;

		// Token: 0x0400B447 RID: 46151
		[Token(Token = "0x400B447")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Buff Style")]
		private Color _bkgBuffColor;

		// Token: 0x0400B448 RID: 46152
		[Token(Token = "0x400B448")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Buff Style")]
		private Color _textBuffColor;

		// Token: 0x0400B449 RID: 46153
		[Token(Token = "0x400B449")]
		[FieldOffset(Offset = "0x88")]
		private BuildingBuffedValueView.ListAdapter m_speedBuffAdapter;

		// Token: 0x0400B44A RID: 46154
		[Token(Token = "0x400B44A")]
		[FieldOffset(Offset = "0x90")]
		private BuildingBuffedValueView.ListAdapter m_mpBuffAdapter;

		// Token: 0x0400B44B RID: 46155
		[Token(Token = "0x400B44B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B44C RID: 46156
		[Token(Token = "0x400B44C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
