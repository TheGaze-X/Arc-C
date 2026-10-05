using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200681D RID: 26653
	[Token(Token = "0x200681D")]
	[RequireComponent(typeof(LayoutElement))]
	public class StageSideStoryZoneTabWidthChangePlugin : StageSideStoryZoneTabViewPlugin
	{
		// Token: 0x060262E8 RID: 156392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262E8")]
		[Address(RVA = "0x213DC00", Offset = "0x213C800", VA = "0x18213DC00", Slot = "4")]
		public override void Show(StageSideStoryZoneTabPluginShowParams showParams)
		{
		}

		// Token: 0x060262E9 RID: 156393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262E9")]
		[Address(RVA = "0x213DD70", Offset = "0x213C970", VA = "0x18213DD70")]
		public StageSideStoryZoneTabWidthChangePlugin()
		{
		}

		// Token: 0x04035CAC RID: 220332
		[Token(Token = "0x4035CAC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayoutElement _zoneLayout;

		// Token: 0x04035CAD RID: 220333
		[Token(Token = "0x4035CAD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _normalWidth;

		// Token: 0x04035CAE RID: 220334
		[Token(Token = "0x4035CAE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _selectedWidth;

		// Token: 0x04035CAF RID: 220335
		[Token(Token = "0x4035CAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lockWidth;

		// Token: 0x04035CB0 RID: 220336
		[Token(Token = "0x4035CB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04035CB1 RID: 220337
		[Token(Token = "0x4035CB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
