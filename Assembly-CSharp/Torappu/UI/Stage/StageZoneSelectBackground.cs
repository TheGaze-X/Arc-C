using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069B7 RID: 27063
	[Token(Token = "0x20069B7")]
	public class StageZoneSelectBackground : DataBinder<ZoneViewProperty>
	{
		// Token: 0x06026BB2 RID: 158642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BB2")]
		[Address(RVA = "0x21CDE70", Offset = "0x21CCA70", VA = "0x1821CDE70", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026BB3 RID: 158643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BB3")]
		[Address(RVA = "0x21CDF60", Offset = "0x21CCB60", VA = "0x1821CDF60")]
		private void _UpdateBkgStatus(ZoneViewProperty property)
		{
		}

		// Token: 0x06026BB4 RID: 158644 RVA: 0x000CC1E0 File Offset: 0x000CA3E0
		[Token(Token = "0x6026BB4")]
		[Address(RVA = "0x21CDDC0", Offset = "0x21CC9C0", VA = "0x1821CDDC0")]
		public static bool CheckIfUseCommonBackground(ZoneViewProperty property)
		{
			return default(bool);
		}

		// Token: 0x06026BB5 RID: 158645 RVA: 0x000CC1F8 File Offset: 0x000CA3F8
		[Token(Token = "0x6026BB5")]
		[Address(RVA = "0x21CDEF0", Offset = "0x21CCAF0", VA = "0x1821CDEF0")]
		private static bool _CheckIfInstantShow(ZoneViewType prevType, ZoneViewType curType)
		{
			return default(bool);
		}

		// Token: 0x06026BB6 RID: 158646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BB6")]
		[Address(RVA = "0x21CE1C0", Offset = "0x21CCDC0", VA = "0x1821CE1C0")]
		public StageZoneSelectBackground()
		{
		}

		// Token: 0x04036AFA RID: 223994
		[Token(Token = "0x4036AFA")]
		public const float TWEEN_DURATION = 0.23f;

		// Token: 0x04036AFB RID: 223995
		[Token(Token = "0x4036AFB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04036AFC RID: 223996
		[Token(Token = "0x4036AFC")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_zoneGroupSwitch;

		// Token: 0x04036AFD RID: 223997
		[Token(Token = "0x4036AFD")]
		[FieldOffset(Offset = "0x30")]
		private ZoneViewType m_curViewType;

		// Token: 0x04036AFE RID: 223998
		[Token(Token = "0x4036AFE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036AFF RID: 223999
		[Token(Token = "0x4036AFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateBkgStatus;

		// Token: 0x04036B00 RID: 224000
		[Token(Token = "0x4036B00")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfUseCommonBackground;

		// Token: 0x04036B01 RID: 224001
		[Token(Token = "0x4036B01")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckIfInstantShow;

		// Token: 0x04036B02 RID: 224002
		[Token(Token = "0x4036B02")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
