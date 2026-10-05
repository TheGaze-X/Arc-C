using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B41 RID: 31553
	[Token(Token = "0x2007B41")]
	public class ActivityFirstStageZoneController : DataBinder<ActivityFirstMapProperty>, IHotfixable
	{
		// Token: 0x0602C2B7 RID: 180919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2B7")]
		[Address(RVA = "0x2817FD0", Offset = "0x2816BD0", VA = "0x182817FD0", Slot = "7")]
		public override void OnValueChanged(ActivityFirstMapProperty property)
		{
		}

		// Token: 0x0602C2B8 RID: 180920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2B8")]
		[Address(RVA = "0x2817F40", Offset = "0x2816B40", VA = "0x182817F40")]
		public void EventOnToZoneMapClicked()
		{
		}

		// Token: 0x0602C2B9 RID: 180921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2B9")]
		[Address(RVA = "0x2818090", Offset = "0x2816C90", VA = "0x182818090")]
		public ActivityFirstStageZoneController()
		{
		}

		// Token: 0x04040075 RID: 262261
		[Token(Token = "0x4040075")]
		[FieldOffset(Offset = "0x20")]
		private string m_currentZone;

		// Token: 0x04040076 RID: 262262
		[Token(Token = "0x4040076")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04040077 RID: 262263
		[Token(Token = "0x4040077")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnToZoneMapClicked;

		// Token: 0x04040078 RID: 262264
		[Token(Token = "0x4040078")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
