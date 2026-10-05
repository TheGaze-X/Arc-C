using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078B3 RID: 30899
	[Token(Token = "0x20078B3")]
	public class Act1LockMapAdapter : DataBinder<Act1LockZoneMapViewProperty>
	{
		// Token: 0x0602B54D RID: 177485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B54D")]
		[Address(RVA = "0x2728680", Offset = "0x2727280", VA = "0x182728680", Slot = "7")]
		public override void OnValueChanged(Act1LockZoneMapViewProperty property)
		{
		}

		// Token: 0x0602B54E RID: 177486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B54E")]
		[Address(RVA = "0x2728730", Offset = "0x2727330", VA = "0x182728730")]
		public Act1LockMapAdapter()
		{
		}

		// Token: 0x0403EA3A RID: 256570
		[Token(Token = "0x403EA3A")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Act1LockMapView mapView;

		// Token: 0x0403EA3B RID: 256571
		[Token(Token = "0x403EA3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403EA3C RID: 256572
		[Token(Token = "0x403EA3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
