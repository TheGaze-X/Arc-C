using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004245 RID: 16965
	[Token(Token = "0x2004245")]
	public class SandboxV2EventChoiceView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x0601A260 RID: 107104 RVA: 0x000A0638 File Offset: 0x0009E838
		[Token(Token = "0x17003E28")]
		public bool isPlayingEnterAnim
		{
			[Token(Token = "0x601A260")]
			[Address(RVA = "0x1305C20", Offset = "0x1304820", VA = "0x181305C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A261 RID: 107105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A261")]
		[Address(RVA = "0x1305320", Offset = "0x1303F20", VA = "0x181305320")]
		public void Render(int index, SandboxV2EventChoiceViewModel viewModel, bool isSelected, bool playAnim, bool isEnter)
		{
		}

		// Token: 0x0601A262 RID: 107106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A262")]
		[Address(RVA = "0x1305960", Offset = "0x1304560", VA = "0x181305960")]
		private void _PlayAnimIfNeeded(int index, bool playAnim)
		{
		}

		// Token: 0x0601A263 RID: 107107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A263")]
		[Address(RVA = "0x13056B0", Offset = "0x13042B0", VA = "0x1813056B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A264 RID: 107108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A264")]
		[Address(RVA = "0x1305230", Offset = "0x1303E30", VA = "0x181305230")]
		public void OnSelectAndConfirm()
		{
		}

		// Token: 0x0601A265 RID: 107109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A265")]
		[Address(RVA = "0x1305130", Offset = "0x1303D30", VA = "0x181305130")]
		public void OnInactive()
		{
		}

		// Token: 0x0601A266 RID: 107110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A266")]
		[Address(RVA = "0x1305AE0", Offset = "0x13046E0", VA = "0x181305AE0")]
		private void _TutorialOnly_TryRaiseAVGSignal()
		{
		}

		// Token: 0x0601A267 RID: 107111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A267")]
		[Address(RVA = "0x13055F0", Offset = "0x13041F0", VA = "0x1813055F0")]
		public void TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x0601A268 RID: 107112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A268")]
		[Address(RVA = "0x1305BC0", Offset = "0x13047C0", VA = "0x181305BC0")]
		public SandboxV2EventChoiceView()
		{
		}

		// Token: 0x04021083 RID: 135299
		[Token(Token = "0x4021083")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2EventChoiceView.Group _activeGroup;

		// Token: 0x04021084 RID: 135300
		[Token(Token = "0x4021084")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x04021085 RID: 135301
		[Token(Token = "0x4021085")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2EventChoiceView.Group _inactiveGroup;

		// Token: 0x04021086 RID: 135302
		[Token(Token = "0x4021086")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelInactive;

		// Token: 0x04021087 RID: 135303
		[Token(Token = "0x4021087")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSelectHotspot;

		// Token: 0x04021088 RID: 135304
		[Token(Token = "0x4021088")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelConfirmHotspot;

		// Token: 0x04021089 RID: 135305
		[Token(Token = "0x4021089")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _enterAnimIntervalDelay;

		// Token: 0x0402108A RID: 135306
		[Token(Token = "0x402108A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0402108B RID: 135307
		[Token(Token = "0x402108B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _selectedAnim;

		// Token: 0x0402108C RID: 135308
		[Token(Token = "0x402108C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x0402108D RID: 135309
		[Token(Token = "0x402108D")]
		[FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("_inactiveHotspot")]
		[SerializeField]
		private Button _selectHotspot;

		// Token: 0x0402108E RID: 135310
		[Token(Token = "0x402108E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _confirmHotspot;

		// Token: 0x0402108F RID: 135311
		[Token(Token = "0x402108F")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04021090 RID: 135312
		[Token(Token = "0x4021090")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedChoiceId;

		// Token: 0x04021091 RID: 135313
		[Token(Token = "0x4021091")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_animTween;

		// Token: 0x04021092 RID: 135314
		[Token(Token = "0x4021092")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_loopTween;

		// Token: 0x04021093 RID: 135315
		[Token(Token = "0x4021093")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_selectedTween;

		// Token: 0x04021094 RID: 135316
		[Token(Token = "0x4021094")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021095 RID: 135317
		[Token(Token = "0x4021095")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isPlayingEnterAnim;

		// Token: 0x04021096 RID: 135318
		[Token(Token = "0x4021096")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021097 RID: 135319
		[Token(Token = "0x4021097")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayAnimIfNeeded;

		// Token: 0x04021098 RID: 135320
		[Token(Token = "0x4021098")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021099 RID: 135321
		[Token(Token = "0x4021099")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSelectAndConfirm;

		// Token: 0x0402109A RID: 135322
		[Token(Token = "0x402109A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInactive;

		// Token: 0x0402109B RID: 135323
		[Token(Token = "0x402109B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseAVGSignal;

		// Token: 0x0402109C RID: 135324
		[Token(Token = "0x402109C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x0402109D RID: 135325
		[Token(Token = "0x402109D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004246 RID: 16966
		[Token(Token = "0x2004246")]
		[Serializable]
		private class Group
		{
			// Token: 0x0601A269 RID: 107113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A269")]
			[Address(RVA = "0x12FDB80", Offset = "0x12FC780", VA = "0x1812FDB80")]
			public void Render(SandboxV2EventChoiceViewModel viewModel)
			{
			}

			// Token: 0x0601A26A RID: 107114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A26A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Group()
			{
			}

			// Token: 0x0402109E RID: 135326
			[Token(Token = "0x402109E")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _title;

			// Token: 0x0402109F RID: 135327
			[Token(Token = "0x402109F")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _costAction;

			// Token: 0x040210A0 RID: 135328
			[Token(Token = "0x40210A0")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _panelCost;
		}
	}
}
