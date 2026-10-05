using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006100 RID: 24832
	[Token(Token = "0x2006100")]
	public class CampaignWorldZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170054C6 RID: 21702
		// (get) Token: 0x06023E3C RID: 147004 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023E3D RID: 147005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054C6")]
		public Action<CampaignWorldZoneViewModel> onClicked
		{
			[Token(Token = "0x6023E3C")]
			[Address(RVA = "0x1E932A0", Offset = "0x1E91EA0", VA = "0x181E932A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023E3D")]
			[Address(RVA = "0x1E933B0", Offset = "0x1E91FB0", VA = "0x181E933B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170054C7 RID: 21703
		// (get) Token: 0x06023E3E RID: 147006 RVA: 0x000C2508 File Offset: 0x000C0708
		[Token(Token = "0x170054C7")]
		public Bounds worldBounds
		{
			[Token(Token = "0x6023E3E")]
			[Address(RVA = "0x1E93300", Offset = "0x1E91F00", VA = "0x181E93300")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x170054C8 RID: 21704
		// (get) Token: 0x06023E3F RID: 147007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054C8")]
		public Button hotspotCircle
		{
			[Token(Token = "0x6023E3F")]
			[Address(RVA = "0x1E93240", Offset = "0x1E91E40", VA = "0x181E93240")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023E40 RID: 147008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E40")]
		[Address(RVA = "0x1E92660", Offset = "0x1E91260", VA = "0x181E92660")]
		public void Render(CampaignWorldZoneViewModel viewModel)
		{
		}

		// Token: 0x06023E41 RID: 147009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E41")]
		[Address(RVA = "0x1E92A00", Offset = "0x1E91600", VA = "0x181E92A00")]
		public void StopEffect()
		{
		}

		// Token: 0x06023E42 RID: 147010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E42")]
		[Address(RVA = "0x1E92550", Offset = "0x1E91150", VA = "0x181E92550")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06023E43 RID: 147011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E43")]
		[Address(RVA = "0x1E92A60", Offset = "0x1E91660", VA = "0x181E92A60")]
		private void _ApplyHolderConfig()
		{
		}

		// Token: 0x06023E44 RID: 147012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E44")]
		[Address(RVA = "0x1E92FD0", Offset = "0x1E91BD0", VA = "0x181E92FD0")]
		private void _ApplyPanelInfoAlignment(RectTransform rectTrans)
		{
		}

		// Token: 0x06023E45 RID: 147013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E45")]
		[Address(RVA = "0x1E924F0", Offset = "0x1E910F0", VA = "0x181E924F0")]
		public void Awake()
		{
		}

		// Token: 0x06023E46 RID: 147014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E46")]
		[Address(RVA = "0x1E931E0", Offset = "0x1E91DE0", VA = "0x181E931E0")]
		public CampaignWorldZoneView()
		{
		}

		// Token: 0x04031C99 RID: 203929
		[Token(Token = "0x4031C99")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Settings")]
		private Color _colorNormalCircle1;

		// Token: 0x04031C9A RID: 203930
		[Token(Token = "0x4031C9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Settings")]
		private Color _colorRotateCircle1;

		// Token: 0x04031C9B RID: 203931
		[Token(Token = "0x4031C9B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageCircle1;

		// Token: 0x04031C9C RID: 203932
		[Token(Token = "0x4031C9C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageCircle2;

		// Token: 0x04031C9D RID: 203933
		[Token(Token = "0x4031C9D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _effectCircle;

		// Token: 0x04031C9E RID: 203934
		[Token(Token = "0x4031C9E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imageLocked;

		// Token: 0x04031C9F RID: 203935
		[Token(Token = "0x4031C9F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _panelInfo;

		// Token: 0x04031CA0 RID: 203936
		[Token(Token = "0x4031CA0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<RectTransform> _panelInfoAlignRectTrans;

		// Token: 0x04031CA1 RID: 203937
		[Token(Token = "0x4031CA1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x04031CA2 RID: 203938
		[Token(Token = "0x4031CA2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imageIconShadow;

		// Token: 0x04031CA3 RID: 203939
		[Token(Token = "0x4031CA3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04031CA4 RID: 203940
		[Token(Token = "0x4031CA4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textNameShadow;

		// Token: 0x04031CA5 RID: 203941
		[Token(Token = "0x4031CA5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _panelCountDown;

		// Token: 0x04031CA6 RID: 203942
		[Token(Token = "0x4031CA6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textCountDown;

		// Token: 0x04031CA7 RID: 203943
		[Token(Token = "0x4031CA7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imageCountDownShadow;

		// Token: 0x04031CA8 RID: 203944
		[Token(Token = "0x4031CA8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform _trackPointContainerLeft;

		// Token: 0x04031CA9 RID: 203945
		[Token(Token = "0x4031CA9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform _trackPointContainerRight;

		// Token: 0x04031CAA RID: 203946
		[Token(Token = "0x4031CAA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button _hotspotRect;

		// Token: 0x04031CAB RID: 203947
		[Token(Token = "0x4031CAB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button _hotspotCircle;

		// Token: 0x04031CAC RID: 203948
		[Token(Token = "0x4031CAC")]
		[FieldOffset(Offset = "0xC0")]
		private CampaignWorldZoneViewModel m_cacheModel;

		// Token: 0x04031CAD RID: 203949
		[Token(Token = "0x4031CAD")]
		[FieldOffset(Offset = "0xC8")]
		private GameObject m_trackPoint;

		// Token: 0x04031CAE RID: 203950
		[Token(Token = "0x4031CAE")]
		[FieldOffset(Offset = "0xD0")]
		private CampaignWorldZoneHolder.PanelInfoAlignment m_panelInfoAlignment;

		// Token: 0x04031CB0 RID: 203952
		[Token(Token = "0x4031CB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x04031CB1 RID: 203953
		[Token(Token = "0x4031CB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x04031CB2 RID: 203954
		[Token(Token = "0x4031CB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_worldBounds;

		// Token: 0x04031CB3 RID: 203955
		[Token(Token = "0x4031CB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hotspotCircle;

		// Token: 0x04031CB4 RID: 203956
		[Token(Token = "0x4031CB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031CB5 RID: 203957
		[Token(Token = "0x4031CB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StopEffect;

		// Token: 0x04031CB6 RID: 203958
		[Token(Token = "0x4031CB6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04031CB7 RID: 203959
		[Token(Token = "0x4031CB7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ApplyHolderConfig;

		// Token: 0x04031CB8 RID: 203960
		[Token(Token = "0x4031CB8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ApplyPanelInfoAlignment;

		// Token: 0x04031CB9 RID: 203961
		[Token(Token = "0x4031CB9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04031CBA RID: 203962
		[Token(Token = "0x4031CBA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
