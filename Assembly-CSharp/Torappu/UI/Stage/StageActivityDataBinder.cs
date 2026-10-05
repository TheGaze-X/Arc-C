using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068DF RID: 26847
	[Token(Token = "0x20068DF")]
	public class StageActivityDataBinder : DataBinder<ZoneViewProperty>
	{
		// Token: 0x06026766 RID: 157542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026766")]
		[Address(RVA = "0x217E5B0", Offset = "0x217D1B0", VA = "0x18217E5B0", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026767 RID: 157543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026767")]
		[Address(RVA = "0x217F0E0", Offset = "0x217DCE0", VA = "0x18217F0E0")]
		private void _UpdateMapDecor(ZoneViewProperty property)
		{
		}

		// Token: 0x06026768 RID: 157544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026768")]
		[Address(RVA = "0x217EC80", Offset = "0x217D880", VA = "0x18217EC80")]
		private void _UpdateActivityZoneMapPlugin(ZoneViewProperty zoneProp)
		{
		}

		// Token: 0x06026769 RID: 157545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026769")]
		[Address(RVA = "0x217E940", Offset = "0x217D540", VA = "0x18217E940")]
		private StageZoneMapStatePlugin _CreateActPlugin(string actId, StagePage page)
		{
			return null;
		}

		// Token: 0x0602676A RID: 157546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602676A")]
		[Address(RVA = "0x217F240", Offset = "0x217DE40", VA = "0x18217F240")]
		public StageActivityDataBinder()
		{
		}

		// Token: 0x04036303 RID: 221955
		[Token(Token = "0x4036303")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _mapDecorCanvasGroup;

		// Token: 0x04036304 RID: 221956
		[Token(Token = "0x4036304")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StageActivityLoader _activityLoader;

		// Token: 0x04036305 RID: 221957
		[Token(Token = "0x4036305")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SafeParentComponent _zoneMapPluginContainer;

		// Token: 0x04036306 RID: 221958
		[Token(Token = "0x4036306")]
		[FieldOffset(Offset = "0x38")]
		private UIPageListener m_pageListener;

		// Token: 0x04036307 RID: 221959
		[Token(Token = "0x4036307")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_mapDecorSwitch;

		// Token: 0x04036308 RID: 221960
		[Token(Token = "0x4036308")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, StageZoneMapStatePlugin> m_actZoneMapPlugins;

		// Token: 0x04036309 RID: 221961
		[Token(Token = "0x4036309")]
		[FieldOffset(Offset = "0x50")]
		private ZoneViewType m_prevType;

		// Token: 0x0403630A RID: 221962
		[Token(Token = "0x403630A")]
		[FieldOffset(Offset = "0x58")]
		private string m_prevSelectedZone;

		// Token: 0x0403630B RID: 221963
		[Token(Token = "0x403630B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0403630C RID: 221964
		[Token(Token = "0x403630C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403630D RID: 221965
		[Token(Token = "0x403630D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateMapDecor;

		// Token: 0x0403630E RID: 221966
		[Token(Token = "0x403630E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateActivityZoneMapPlugin;

		// Token: 0x0403630F RID: 221967
		[Token(Token = "0x403630F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateActPlugin;

		// Token: 0x04036310 RID: 221968
		[Token(Token = "0x4036310")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
