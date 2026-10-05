using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006796 RID: 26518
	[Token(Token = "0x2006796")]
	public class StageZoneCampaignView : DataBinder<StageZoneWeeklyRewardProperty>, IHotfixable
	{
		// Token: 0x170059F9 RID: 23033
		// (get) Token: 0x0602608F RID: 155791 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026090 RID: 155792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059F9")]
		public Action onRendered
		{
			[Token(Token = "0x602608F")]
			[Address(RVA = "0x211D000", Offset = "0x211BC00", VA = "0x18211D000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026090")]
			[Address(RVA = "0x211D140", Offset = "0x211BD40", VA = "0x18211D140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170059FA RID: 23034
		// (get) Token: 0x06026091 RID: 155793 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026092 RID: 155794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059FA")]
		public Action onClicked
		{
			[Token(Token = "0x6026091")]
			[Address(RVA = "0x211CFA0", Offset = "0x211BBA0", VA = "0x18211CFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026092")]
			[Address(RVA = "0x211D0C0", Offset = "0x211BCC0", VA = "0x18211D0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170059FB RID: 23035
		// (get) Token: 0x06026093 RID: 155795 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026094 RID: 155796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059FB")]
		public Action onRotateStageClicked
		{
			[Token(Token = "0x6026093")]
			[Address(RVA = "0x211D060", Offset = "0x211BC60", VA = "0x18211D060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026094")]
			[Address(RVA = "0x211D1C0", Offset = "0x211BDC0", VA = "0x18211D1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026095 RID: 155797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026095")]
		[Address(RVA = "0x211CA60", Offset = "0x211B660", VA = "0x18211CA60", Slot = "7")]
		public override void OnValueChanged(StageZoneWeeklyRewardProperty property)
		{
		}

		// Token: 0x06026096 RID: 155798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026096")]
		[Address(RVA = "0x211C840", Offset = "0x211B440", VA = "0x18211C840")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06026097 RID: 155799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026097")]
		[Address(RVA = "0x211C950", Offset = "0x211B550", VA = "0x18211C950")]
		public void EventOnRotateStageClicked()
		{
		}

		// Token: 0x06026098 RID: 155800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026098")]
		[Address(RVA = "0x211CF30", Offset = "0x211BB30", VA = "0x18211CF30")]
		public StageZoneCampaignView()
		{
		}

		// Token: 0x04035821 RID: 219169
		[Token(Token = "0x4035821")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textRotateRemainTime;

		// Token: 0x04035822 RID: 219170
		[Token(Token = "0x4035822")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgRemainTimeBkg;

		// Token: 0x04035823 RID: 219171
		[Token(Token = "0x4035823")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StageZoneCampaignView.EndTimeCountDownBgStyle[] _endTimeStyles;

		// Token: 0x04035824 RID: 219172
		[Token(Token = "0x4035824")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageRotateZone;

		// Token: 0x04035825 RID: 219173
		[Token(Token = "0x4035825")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageRotateZoneBlack;

		// Token: 0x04035826 RID: 219174
		[Token(Token = "0x4035826")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textRotateZoneName;

		// Token: 0x04035827 RID: 219175
		[Token(Token = "0x4035827")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textRotateStageName;

		// Token: 0x04035828 RID: 219176
		[Token(Token = "0x4035828")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasBtnRotate;

		// Token: 0x04035829 RID: 219177
		[Token(Token = "0x4035829")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelRotateUnlock;

		// Token: 0x0403582A RID: 219178
		[Token(Token = "0x403582A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textRotateUnlock;

		// Token: 0x0403582E RID: 219182
		[Token(Token = "0x403582E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRendered;

		// Token: 0x0403582F RID: 219183
		[Token(Token = "0x403582F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRendered;

		// Token: 0x04035830 RID: 219184
		[Token(Token = "0x4035830")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x04035831 RID: 219185
		[Token(Token = "0x4035831")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x04035832 RID: 219186
		[Token(Token = "0x4035832")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onRotateStageClicked;

		// Token: 0x04035833 RID: 219187
		[Token(Token = "0x4035833")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onRotateStageClicked;

		// Token: 0x04035834 RID: 219188
		[Token(Token = "0x4035834")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035835 RID: 219189
		[Token(Token = "0x4035835")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04035836 RID: 219190
		[Token(Token = "0x4035836")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnRotateStageClicked;

		// Token: 0x04035837 RID: 219191
		[Token(Token = "0x4035837")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006797 RID: 26519
		[Token(Token = "0x2006797")]
		[Serializable]
		public struct EndTimeCountDownBgStyle
		{
			// Token: 0x04035838 RID: 219192
			[Token(Token = "0x4035838")]
			[FieldOffset(Offset = "0x0")]
			public UIAtlasObject atlasObject;

			// Token: 0x04035839 RID: 219193
			[Token(Token = "0x4035839")]
			[FieldOffset(Offset = "0x8")]
			public string imgName;

			// Token: 0x0403583A RID: 219194
			[Token(Token = "0x403583A")]
			[FieldOffset(Offset = "0x10")]
			public int secondRemain;

			// Token: 0x0403583B RID: 219195
			[Token(Token = "0x403583B")]
			[FieldOffset(Offset = "0x14")]
			public Color textColor;
		}
	}
}
