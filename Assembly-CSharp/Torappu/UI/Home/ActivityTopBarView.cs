using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BC3 RID: 19395
	[Token(Token = "0x2004BC3")]
	public class ActivityTopBarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004494 RID: 17556
		// (get) Token: 0x0601D260 RID: 119392 RVA: 0x000AAB80 File Offset: 0x000A8D80
		[Token(Token = "0x17004494")]
		public float preferredHeight
		{
			[Token(Token = "0x601D260")]
			[Address(RVA = "0x16B4610", Offset = "0x16B3210", VA = "0x1816B4610")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004495 RID: 17557
		// (get) Token: 0x0601D261 RID: 119393 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D262 RID: 119394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004495")]
		public Action onSwitchAnimEnd
		{
			[Token(Token = "0x601D261")]
			[Address(RVA = "0x16B4550", Offset = "0x16B3150", VA = "0x1816B4550")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D262")]
			[Address(RVA = "0x16B4770", Offset = "0x16B3370", VA = "0x1816B4770")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004496 RID: 17558
		// (get) Token: 0x0601D263 RID: 119395 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D264 RID: 119396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004496")]
		public Action onSwitchAnimStart
		{
			[Token(Token = "0x601D263")]
			[Address(RVA = "0x16B45B0", Offset = "0x16B31B0", VA = "0x1816B45B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D264")]
			[Address(RVA = "0x16B47F0", Offset = "0x16B33F0", VA = "0x1816B47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004497 RID: 17559
		// (get) Token: 0x0601D265 RID: 119397 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D266 RID: 119398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004497")]
		public Action<string> onClick
		{
			[Token(Token = "0x601D265")]
			[Address(RVA = "0x16B44F0", Offset = "0x16B30F0", VA = "0x1816B44F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D266")]
			[Address(RVA = "0x16B46F0", Offset = "0x16B32F0", VA = "0x1816B46F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601D267 RID: 119399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D267")]
		[Address(RVA = "0x16B38B0", Offset = "0x16B24B0", VA = "0x1816B38B0")]
		public void Render(string actId, ActShowType showType, ActivityTable.HomeActivityConfig config, bool fastMode)
		{
		}

		// Token: 0x0601D268 RID: 119400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D268")]
		[Address(RVA = "0x16B4040", Offset = "0x16B2C40", VA = "0x1816B4040")]
		private void _SetShow(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601D269 RID: 119401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D269")]
		[Address(RVA = "0x16B3BE0", Offset = "0x16B27E0", VA = "0x1816B3BE0")]
		private void _RenderBasicInfo()
		{
		}

		// Token: 0x0601D26A RID: 119402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D26A")]
		[Address(RVA = "0x16B4220", Offset = "0x16B2E20", VA = "0x1816B4220")]
		private void _UpdateStatus(ActShowType showType)
		{
		}

		// Token: 0x0601D26B RID: 119403 RVA: 0x000AAB98 File Offset: 0x000A8D98
		[Token(Token = "0x601D26B")]
		[Address(RVA = "0x16B41C0", Offset = "0x16B2DC0", VA = "0x1816B41C0")]
		private bool _ShowSwitchAnim()
		{
			return default(bool);
		}

		// Token: 0x0601D26C RID: 119404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D26C")]
		[Address(RVA = "0x16B39F0", Offset = "0x16B25F0", VA = "0x1816B39F0")]
		private void _EnsureSwitchTweenIfHave()
		{
		}

		// Token: 0x0601D26D RID: 119405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D26D")]
		[Address(RVA = "0x16B3700", Offset = "0x16B2300", VA = "0x1816B3700")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601D26E RID: 119406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D26E")]
		[Address(RVA = "0x16B3810", Offset = "0x16B2410", VA = "0x1816B3810")]
		public void EventOnLockedClicked()
		{
		}

		// Token: 0x0601D26F RID: 119407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D26F")]
		[Address(RVA = "0x16B4400", Offset = "0x16B3000", VA = "0x1816B4400")]
		public ActivityTopBarView()
		{
		}

		// Token: 0x04026426 RID: 156710
		[Token(Token = "0x4026426")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Image _activityIcon;

		// Token: 0x04026427 RID: 156711
		[Token(Token = "0x4026427")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Image _backImage;

		// Token: 0x04026428 RID: 156712
		[Token(Token = "0x4026428")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Text _infoText;

		// Token: 0x04026429 RID: 156713
		[Token(Token = "0x4026429")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Text _infoText2;

		// Token: 0x0402642A RID: 156714
		[Token(Token = "0x402642A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _button;

		// Token: 0x0402642B RID: 156715
		[Token(Token = "0x402642B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0402642C RID: 156716
		[Token(Token = "0x402642C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Nullable")]
		private GameObject _panelLocked;

		// Token: 0x0402642D RID: 156717
		[Token(Token = "0x402642D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Nullable")]
		private GameObject _panelFinished;

		// Token: 0x0402642E RID: 156718
		[Token(Token = "0x402642E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _needSwitchAnim;

		// Token: 0x0402642F RID: 156719
		[Token(Token = "0x402642F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Inspect("_ShowSwitchAnim")]
		private UIAnimationLocation _verticalShowAnim;

		// Token: 0x04026430 RID: 156720
		[Token(Token = "0x4026430")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Inspect("_ShowSwitchAnim")]
		private UIAnimationLocation _verticalHideAnim;

		// Token: 0x04026431 RID: 156721
		[Token(Token = "0x4026431")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Inspect("_ShowSwitchAnim")]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04026432 RID: 156722
		[Token(Token = "0x4026432")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LayoutElement _preferredLayout;

		// Token: 0x04026435 RID: 156725
		[Token(Token = "0x4026435")]
		[FieldOffset(Offset = "0xA0")]
		private TrackPointViewProperty m_activityRedPoint;

		// Token: 0x04026436 RID: 156726
		[Token(Token = "0x4026436")]
		[FieldOffset(Offset = "0xA8")]
		private ActivityTable.HomeActivityConfig m_homeActConfig;

		// Token: 0x04026437 RID: 156727
		[Token(Token = "0x4026437")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isUnlocked;

		// Token: 0x04026438 RID: 156728
		[Token(Token = "0x4026438")]
		[FieldOffset(Offset = "0xB8")]
		private UISwitchTween m_switchTween;

		// Token: 0x0402643A RID: 156730
		[Token(Token = "0x402643A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0402643B RID: 156731
		[Token(Token = "0x402643B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onSwitchAnimEnd;

		// Token: 0x0402643C RID: 156732
		[Token(Token = "0x402643C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onSwitchAnimEnd;

		// Token: 0x0402643D RID: 156733
		[Token(Token = "0x402643D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onSwitchAnimStart;

		// Token: 0x0402643E RID: 156734
		[Token(Token = "0x402643E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onSwitchAnimStart;

		// Token: 0x0402643F RID: 156735
		[Token(Token = "0x402643F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04026440 RID: 156736
		[Token(Token = "0x4026440")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04026441 RID: 156737
		[Token(Token = "0x4026441")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026442 RID: 156738
		[Token(Token = "0x4026442")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetShow;

		// Token: 0x04026443 RID: 156739
		[Token(Token = "0x4026443")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderBasicInfo;

		// Token: 0x04026444 RID: 156740
		[Token(Token = "0x4026444")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateStatus;

		// Token: 0x04026445 RID: 156741
		[Token(Token = "0x4026445")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowSwitchAnim;

		// Token: 0x04026446 RID: 156742
		[Token(Token = "0x4026446")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTweenIfHave;

		// Token: 0x04026447 RID: 156743
		[Token(Token = "0x4026447")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04026448 RID: 156744
		[Token(Token = "0x4026448")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnLockedClicked;

		// Token: 0x04026449 RID: 156745
		[Token(Token = "0x4026449")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
