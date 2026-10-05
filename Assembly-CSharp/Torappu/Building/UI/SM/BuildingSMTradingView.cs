using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CD9 RID: 7385
	[Token(Token = "0x2001CD9")]
	public class BuildingSMTradingView : BuildingSMSingleRoomTypeView
	{
		// Token: 0x0600B6BE RID: 46782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6BE")]
		[Address(RVA = "0x333EAE0", Offset = "0x333D6E0", VA = "0x18333EAE0", Slot = "4")]
		public override void Render(SelectedRoomDetailViewModel roomModel)
		{
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6BF")]
		[Address(RVA = "0x333ED80", Offset = "0x333D980", VA = "0x18333ED80")]
		private static void _UpdateToggleByBuff(ThreeStateToggle toggle, float buffVal, int sign = 1)
		{
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6C0")]
		[Address(RVA = "0x333EE90", Offset = "0x333DA90", VA = "0x18333EE90")]
		public BuildingSMTradingView()
		{
		}

		// Token: 0x0400B455 RID: 46165
		[Token(Token = "0x400B455")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textManpowerCost;

		// Token: 0x0400B456 RID: 46166
		[Token(Token = "0x400B456")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _mpBuffLayout;

		// Token: 0x0400B457 RID: 46167
		[Token(Token = "0x400B457")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ThreeStateToggle _toggleManpowerCost;

		// Token: 0x0400B458 RID: 46168
		[Token(Token = "0x400B458")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textSpeedEmpty;

		// Token: 0x0400B459 RID: 46169
		[Token(Token = "0x400B459")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _speedBuffLayout;

		// Token: 0x0400B45A RID: 46170
		[Token(Token = "0x400B45A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ThreeStateToggle _toggleOrderSpeed;

		// Token: 0x0400B45B RID: 46171
		[Token(Token = "0x400B45B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Buff Style")]
		private Color _bkgBuffColor;

		// Token: 0x0400B45C RID: 46172
		[Token(Token = "0x400B45C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Buff Style")]
		private Color _textBuffColor;

		// Token: 0x0400B45D RID: 46173
		[Token(Token = "0x400B45D")]
		[FieldOffset(Offset = "0x88")]
		private BuildingBuffedValueView.ListAdapter m_mpBuffAdapter;

		// Token: 0x0400B45E RID: 46174
		[Token(Token = "0x400B45E")]
		[FieldOffset(Offset = "0x90")]
		private BuildingBuffedValueView.ListAdapter m_speedBuffAdapter;

		// Token: 0x0400B45F RID: 46175
		[Token(Token = "0x400B45F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B460 RID: 46176
		[Token(Token = "0x400B460")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateToggleByBuff;

		// Token: 0x0400B461 RID: 46177
		[Token(Token = "0x400B461")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
