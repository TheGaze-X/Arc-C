using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006963 RID: 26979
	[Token(Token = "0x2006963")]
	public class StageFogOnMap : StageFogOnMapBase
	{
		// Token: 0x060269C8 RID: 158152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269C8")]
		[Address(RVA = "0x21AC380", Offset = "0x21AAF80", VA = "0x1821AC380", Slot = "4")]
		public override void RenderView(StageFogOnMapBase.Param renderParam)
		{
		}

		// Token: 0x060269C9 RID: 158153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60269C9")]
		[Address(RVA = "0x21AC9F0", Offset = "0x21AB5F0", VA = "0x1821AC9F0")]
		private string _GetFogUnlockDesc(FogType fogType)
		{
			return null;
		}

		// Token: 0x060269CA RID: 158154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269CA")]
		[Address(RVA = "0x21AC180", Offset = "0x21AAD80", VA = "0x1821AC180")]
		public void OnEventClicked()
		{
		}

		// Token: 0x060269CB RID: 158155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269CB")]
		[Address(RVA = "0x21AC200", Offset = "0x21AAE00", VA = "0x1821AC200", Slot = "5")]
		protected override void OnFogDismiss()
		{
		}

		// Token: 0x060269CC RID: 158156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269CC")]
		[Address(RVA = "0x21ACAA0", Offset = "0x21AB6A0", VA = "0x1821ACAA0")]
		public StageFogOnMap()
		{
		}

		// Token: 0x060269CD RID: 158157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269CD")]
		[Address(RVA = "0x21ABB30", Offset = "0x21AA730", VA = "0x1821ABB30")]
		private void <>xLuaBaseProxy_OnFogDismiss()
		{
		}

		// Token: 0x040367B9 RID: 223161
		[Token(Token = "0x40367B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _zoneFogPanel;

		// Token: 0x040367BA RID: 223162
		[Token(Token = "0x40367BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _stageFogPanel;

		// Token: 0x040367BB RID: 223163
		[Token(Token = "0x40367BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _fogBtn;

		// Token: 0x040367BC RID: 223164
		[Token(Token = "0x40367BC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _fogBkg;

		// Token: 0x040367BD RID: 223165
		[Token(Token = "0x40367BD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("ZoneFog")]
		private Image _zoneFogBtnBkg;

		// Token: 0x040367BE RID: 223166
		[Token(Token = "0x40367BE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("ZoneFog")]
		private Image _zoneFogIcon;

		// Token: 0x040367BF RID: 223167
		[Token(Token = "0x40367BF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("ZoneFog")]
		private GameObject _zoneFogDecoContainer;

		// Token: 0x040367C0 RID: 223168
		[Token(Token = "0x40367C0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("ZoneFog")]
		private Text _zoneFogUnlockItemCount;

		// Token: 0x040367C1 RID: 223169
		[Token(Token = "0x40367C1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ZoneFog")]
		private Text _zoneFogDesc;

		// Token: 0x040367C2 RID: 223170
		[Token(Token = "0x40367C2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("ZoneFog")]
		private Text _zoneFogUnlockTip;

		// Token: 0x040367C3 RID: 223171
		[Token(Token = "0x40367C3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("ZoneFog")]
		private GameObject _zoneFogUnlockClickTip;

		// Token: 0x040367C4 RID: 223172
		[Token(Token = "0x40367C4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("StageFog")]
		private Image _stageFogBtnBkg;

		// Token: 0x040367C5 RID: 223173
		[Token(Token = "0x40367C5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("StageFog")]
		private Image _stageFogUnlockItemIcon;

		// Token: 0x040367C6 RID: 223174
		[Token(Token = "0x40367C6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("StageFog")]
		private Text _stageFogUnlockText;

		// Token: 0x040367C7 RID: 223175
		[Token(Token = "0x40367C7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("StageFogBtnBkg")]
		private Sprite _stageLockedBkg;

		// Token: 0x040367C8 RID: 223176
		[Token(Token = "0x40367C8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("StageFogBtnBkg")]
		private Sprite _stageUnlockableBkg;

		// Token: 0x040367C9 RID: 223177
		[Token(Token = "0x40367C9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("ZoneFogBtnBkg")]
		private Sprite _zoneLockedBkg;

		// Token: 0x040367CA RID: 223178
		[Token(Token = "0x40367CA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("ZoneFogBtnBkg")]
		private Sprite _zoneunLockableBkg;

		// Token: 0x040367CB RID: 223179
		[Token(Token = "0x40367CB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _decoImage;

		// Token: 0x040367CC RID: 223180
		[Token(Token = "0x40367CC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Animation _fogDismissAnimation;

		// Token: 0x040367CD RID: 223181
		[Token(Token = "0x40367CD")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedStageId;

		// Token: 0x040367CE RID: 223182
		[Token(Token = "0x40367CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040367CF RID: 223183
		[Token(Token = "0x40367CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetFogUnlockDesc;

		// Token: 0x040367D0 RID: 223184
		[Token(Token = "0x40367D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEventClicked;

		// Token: 0x040367D1 RID: 223185
		[Token(Token = "0x40367D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFogDismiss;

		// Token: 0x040367D2 RID: 223186
		[Token(Token = "0x40367D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
