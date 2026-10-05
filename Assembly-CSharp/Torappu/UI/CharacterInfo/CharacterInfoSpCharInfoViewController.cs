using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F35 RID: 24373
	[Token(Token = "0x2005F35")]
	public class CharacterInfoSpCharInfoViewController : DataBinder<CharInfoGroupProperty>
	{
		// Token: 0x060234BE RID: 144574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234BE")]
		[Address(RVA = "0x1DDB870", Offset = "0x1DDA470", VA = "0x181DDB870", Slot = "7")]
		public override void OnValueChanged(CharInfoGroupProperty property)
		{
		}

		// Token: 0x060234BF RID: 144575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234BF")]
		[Address(RVA = "0x1DDB7C0", Offset = "0x1DDA3C0", VA = "0x181DDB7C0")]
		public void OnFavorShow()
		{
		}

		// Token: 0x060234C0 RID: 144576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C0")]
		[Address(RVA = "0x1DDB720", Offset = "0x1DDA320", VA = "0x181DDB720")]
		public void OnFavorDisable()
		{
		}

		// Token: 0x060234C1 RID: 144577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C1")]
		[Address(RVA = "0x1DDBCA0", Offset = "0x1DDA8A0", VA = "0x181DDBCA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060234C2 RID: 144578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234C2")]
		[Address(RVA = "0x1DDBD40", Offset = "0x1DDA940", VA = "0x181DDBD40")]
		public CharacterInfoSpCharInfoViewController()
		{
		}

		// Token: 0x04030ADC RID: 199388
		[Token(Token = "0x4030ADC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageFavor;

		// Token: 0x04030ADD RID: 199389
		[Token(Token = "0x4030ADD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSpCharInfo;

		// Token: 0x04030ADE RID: 199390
		[Token(Token = "0x4030ADE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPopup;

		// Token: 0x04030ADF RID: 199391
		[Token(Token = "0x4030ADF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSpCharInfoMission;

		// Token: 0x04030AE0 RID: 199392
		[Token(Token = "0x4030AE0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelSpCharInfoMissionComplete;

		// Token: 0x04030AE1 RID: 199393
		[Token(Token = "0x4030AE1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textSpCharNames;

		// Token: 0x04030AE2 RID: 199394
		[Token(Token = "0x4030AE2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textMissionDesc;

		// Token: 0x04030AE3 RID: 199395
		[Token(Token = "0x4030AE3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textMissionInProgress;

		// Token: 0x04030AE4 RID: 199396
		[Token(Token = "0x4030AE4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelMission;

		// Token: 0x04030AE5 RID: 199397
		[Token(Token = "0x4030AE5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelMissionInProgress;

		// Token: 0x04030AE6 RID: 199398
		[Token(Token = "0x4030AE6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelMissionHasReward;

		// Token: 0x04030AE7 RID: 199399
		[Token(Token = "0x4030AE7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICommonTrackPoint _missionTrackPoint;

		// Token: 0x04030AE8 RID: 199400
		[Token(Token = "0x4030AE8")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04030AE9 RID: 199401
		[Token(Token = "0x4030AE9")]
		[FieldOffset(Offset = "0x88")]
		private SpCharInfoViewModel m_cacheModel;

		// Token: 0x04030AEA RID: 199402
		[Token(Token = "0x4030AEA")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_missionTrackPointProp;

		// Token: 0x04030AEB RID: 199403
		[Token(Token = "0x4030AEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030AEC RID: 199404
		[Token(Token = "0x4030AEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFavorShow;

		// Token: 0x04030AED RID: 199405
		[Token(Token = "0x4030AED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFavorDisable;

		// Token: 0x04030AEE RID: 199406
		[Token(Token = "0x4030AEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030AEF RID: 199407
		[Token(Token = "0x4030AEF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
