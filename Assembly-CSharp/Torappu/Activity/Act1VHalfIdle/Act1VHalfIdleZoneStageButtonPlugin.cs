using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200781E RID: 30750
	[Token(Token = "0x200781E")]
	public class Act1VHalfIdleZoneStageButtonPlugin : ActivityCustomZoneBaseStageButtonPlugin
	{
		// Token: 0x0602B224 RID: 176676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B224")]
		[Address(RVA = "0x2702C30", Offset = "0x2701830", VA = "0x182702C30")]
		private void _InitViewIfNot(string actId)
		{
		}

		// Token: 0x0602B225 RID: 176677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B225")]
		[Address(RVA = "0x2702B60", Offset = "0x2701760", VA = "0x182702B60")]
		private void _EventOnClick()
		{
		}

		// Token: 0x0602B226 RID: 176678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B226")]
		[Address(RVA = "0x2702950", Offset = "0x2701550", VA = "0x182702950", Slot = "5")]
		public override void Render(ActivityCustomZoneMapViewModel zoneModel, StageViewModel stageViewModel, bool isSelected, bool isFastMode)
		{
		}

		// Token: 0x0602B227 RID: 176679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B227")]
		[Address(RVA = "0x27027D0", Offset = "0x27013D0", VA = "0x1827027D0")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602B228 RID: 176680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B228")]
		[Address(RVA = "0x2702F70", Offset = "0x2701B70", VA = "0x182702F70")]
		public Act1VHalfIdleZoneStageButtonPlugin()
		{
		}

		// Token: 0x0602B229 RID: 176681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B229")]
		[Address(RVA = "0x24B7970", Offset = "0x24B6570", VA = "0x1824B7970")]
		private void <>xLuaBaseProxy_Render(ActivityCustomZoneMapViewModel P0, StageViewModel P1, bool P2, bool P3)
		{
		}

		// Token: 0x0403E57F RID: 255359
		[Token(Token = "0x403E57F")]
		private const float LOCK_LINE_ALPHA = 0.3f;

		// Token: 0x0403E580 RID: 255360
		[Token(Token = "0x403E580")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _isHard;

		// Token: 0x0403E581 RID: 255361
		[Token(Token = "0x403E581")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _lockLineImg;

		// Token: 0x0403E582 RID: 255362
		[Token(Token = "0x403E582")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E583 RID: 255363
		[Token(Token = "0x403E583")]
		[FieldOffset(Offset = "0x38")]
		private Act1VHalfIdleZoneStageButtonView m_view;

		// Token: 0x0403E584 RID: 255364
		[Token(Token = "0x403E584")]
		[FieldOffset(Offset = "0x40")]
		private ActivityCustomZoneStageButton m_stageBtn;

		// Token: 0x0403E585 RID: 255365
		[Token(Token = "0x403E585")]
		[FieldOffset(Offset = "0x48")]
		private string m_actId;

		// Token: 0x0403E586 RID: 255366
		[Token(Token = "0x403E586")]
		[FieldOffset(Offset = "0x50")]
		private string m_stageId;

		// Token: 0x0403E587 RID: 255367
		[Token(Token = "0x403E587")]
		[FieldOffset(Offset = "0x58")]
		private bool m_showTrackpoint;

		// Token: 0x0403E588 RID: 255368
		[Token(Token = "0x403E588")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitViewIfNot;

		// Token: 0x0403E589 RID: 255369
		[Token(Token = "0x403E589")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EventOnClick;

		// Token: 0x0403E58A RID: 255370
		[Token(Token = "0x403E58A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E58B RID: 255371
		[Token(Token = "0x403E58B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403E58C RID: 255372
		[Token(Token = "0x403E58C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
