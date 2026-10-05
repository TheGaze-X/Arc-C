using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CD8 RID: 7384
	[Token(Token = "0x2001CD8")]
	public class BuildingSMPowerView : BuildingSMSingleRoomTypeView
	{
		// Token: 0x0600B6BC RID: 46780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6BC")]
		[Address(RVA = "0x333E8A0", Offset = "0x333D4A0", VA = "0x18333E8A0", Slot = "4")]
		public override void Render(SelectedRoomDetailViewModel roomModel)
		{
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6BD")]
		[Address(RVA = "0x333EA80", Offset = "0x333D680", VA = "0x18333EA80")]
		public BuildingSMPowerView()
		{
		}

		// Token: 0x0400B44D RID: 46157
		[Token(Token = "0x400B44D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _powerText;

		// Token: 0x0400B44E RID: 46158
		[Token(Token = "0x400B44E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _accelLaborText;

		// Token: 0x0400B44F RID: 46159
		[Token(Token = "0x400B44F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _laborAccelLayout;

		// Token: 0x0400B450 RID: 46160
		[Token(Token = "0x400B450")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Style Buff")]
		private Color _bkgColorLaborAccel;

		// Token: 0x0400B451 RID: 46161
		[Token(Token = "0x400B451")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Style Buff")]
		private Color _textColorLaborAccel;

		// Token: 0x0400B452 RID: 46162
		[Token(Token = "0x400B452")]
		[FieldOffset(Offset = "0x70")]
		private BuildingBuffedValueView.ListAdapter m_laborAccelAdapter;

		// Token: 0x0400B453 RID: 46163
		[Token(Token = "0x400B453")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B454 RID: 46164
		[Token(Token = "0x400B454")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
