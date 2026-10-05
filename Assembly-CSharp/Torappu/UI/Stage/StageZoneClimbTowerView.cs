using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006798 RID: 26520
	[Token(Token = "0x2006798")]
	public class StageZoneClimbTowerView : DataBinder<StageZoneWeeklyRewardProperty>
	{
		// Token: 0x170059FC RID: 23036
		// (get) Token: 0x06026099 RID: 155801 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602609A RID: 155802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059FC")]
		public Action onClicked
		{
			[Token(Token = "0x6026099")]
			[Address(RVA = "0x211DEA0", Offset = "0x211CAA0", VA = "0x18211DEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602609A")]
			[Address(RVA = "0x211DFC0", Offset = "0x211CBC0", VA = "0x18211DFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170059FD RID: 23037
		// (get) Token: 0x0602609B RID: 155803 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602609C RID: 155804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059FD")]
		public Action onRotateStageClicked
		{
			[Token(Token = "0x602609B")]
			[Address(RVA = "0x211DF00", Offset = "0x211CB00", VA = "0x18211DF00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602609C")]
			[Address(RVA = "0x211E040", Offset = "0x211CC40", VA = "0x18211E040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170059FE RID: 23038
		// (get) Token: 0x0602609D RID: 155805 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602609E RID: 155806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059FE")]
		public UIPage page
		{
			[Token(Token = "0x602609D")]
			[Address(RVA = "0x211DF60", Offset = "0x211CB60", VA = "0x18211DF60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602609E")]
			[Address(RVA = "0x211E0C0", Offset = "0x211CCC0", VA = "0x18211E0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602609F RID: 155807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602609F")]
		[Address(RVA = "0x211D950", Offset = "0x211C550", VA = "0x18211D950", Slot = "7")]
		public override void OnValueChanged(StageZoneWeeklyRewardProperty property)
		{
		}

		// Token: 0x060260A0 RID: 155808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260A0")]
		[Address(RVA = "0x211D730", Offset = "0x211C330", VA = "0x18211D730")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060260A1 RID: 155809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260A1")]
		[Address(RVA = "0x211D840", Offset = "0x211C440", VA = "0x18211D840")]
		public void EventOnRotateStageClicked()
		{
		}

		// Token: 0x060260A2 RID: 155810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260A2")]
		[Address(RVA = "0x211DE30", Offset = "0x211CA30", VA = "0x18211DE30")]
		public StageZoneClimbTowerView()
		{
		}

		// Token: 0x0403583C RID: 219196
		[Token(Token = "0x403583C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggleBtn;

		// Token: 0x0403583D RID: 219197
		[Token(Token = "0x403583D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _climbTowerBtnCanvas;

		// Token: 0x0403583E RID: 219198
		[Token(Token = "0x403583E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _toggleInBattle;

		// Token: 0x0403583F RID: 219199
		[Token(Token = "0x403583F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _toggleBattleHard;

		// Token: 0x04035840 RID: 219200
		[Token(Token = "0x4035840")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _towerName;

		// Token: 0x04035841 RID: 219201
		[Token(Token = "0x4035841")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _towerSubName;

		// Token: 0x04035842 RID: 219202
		[Token(Token = "0x4035842")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _towerIcon;

		// Token: 0x04035843 RID: 219203
		[Token(Token = "0x4035843")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _towerIconBlack;

		// Token: 0x04035844 RID: 219204
		[Token(Token = "0x4035844")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _seasonNum;

		// Token: 0x04035845 RID: 219205
		[Token(Token = "0x4035845")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _seasonName;

		// Token: 0x04035846 RID: 219206
		[Token(Token = "0x4035846")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textSeasonRemainTime;

		// Token: 0x04035847 RID: 219207
		[Token(Token = "0x4035847")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _imgRemainTimeBkg;

		// Token: 0x04035848 RID: 219208
		[Token(Token = "0x4035848")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private StageZoneClimbTowerView.EndTimeCountDownBgStyle[] _endTimeStyles;

		// Token: 0x0403584C RID: 219212
		[Token(Token = "0x403584C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0403584D RID: 219213
		[Token(Token = "0x403584D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0403584E RID: 219214
		[Token(Token = "0x403584E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onRotateStageClicked;

		// Token: 0x0403584F RID: 219215
		[Token(Token = "0x403584F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onRotateStageClicked;

		// Token: 0x04035850 RID: 219216
		[Token(Token = "0x4035850")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04035851 RID: 219217
		[Token(Token = "0x4035851")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04035852 RID: 219218
		[Token(Token = "0x4035852")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035853 RID: 219219
		[Token(Token = "0x4035853")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04035854 RID: 219220
		[Token(Token = "0x4035854")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnRotateStageClicked;

		// Token: 0x04035855 RID: 219221
		[Token(Token = "0x4035855")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006799 RID: 26521
		[Token(Token = "0x2006799")]
		[Serializable]
		public struct EndTimeCountDownBgStyle
		{
			// Token: 0x04035856 RID: 219222
			[Token(Token = "0x4035856")]
			[FieldOffset(Offset = "0x0")]
			public UIAtlasObject atlasObject;

			// Token: 0x04035857 RID: 219223
			[Token(Token = "0x4035857")]
			[FieldOffset(Offset = "0x8")]
			public string imgName;

			// Token: 0x04035858 RID: 219224
			[Token(Token = "0x4035858")]
			[FieldOffset(Offset = "0x10")]
			public int secondRemain;

			// Token: 0x04035859 RID: 219225
			[Token(Token = "0x4035859")]
			[FieldOffset(Offset = "0x14")]
			public Color textColor;
		}
	}
}
