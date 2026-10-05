using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067E1 RID: 26593
	[Token(Token = "0x20067E1")]
	public class StageZoneHomeThemeMainlineView : StageZoneHomeThemeView.Plugin
	{
		// Token: 0x060261F2 RID: 156146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261F2")]
		[Address(RVA = "0x2140C90", Offset = "0x213F890", VA = "0x182140C90", Slot = "5")]
		public override Sprite GetThemeLogo()
		{
			return null;
		}

		// Token: 0x060261F3 RID: 156147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261F3")]
		[Address(RVA = "0x2140CF0", Offset = "0x213F8F0", VA = "0x182140CF0", Slot = "6")]
		protected override void OnDataUpdated(StageZoneHomeThemeView.Plugin.Param param)
		{
		}

		// Token: 0x060261F4 RID: 156148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261F4")]
		[Address(RVA = "0x2141450", Offset = "0x2140050", VA = "0x182141450")]
		private void _RenderMainlineProcessingPart()
		{
		}

		// Token: 0x060261F5 RID: 156149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261F5")]
		[Address(RVA = "0x2141350", Offset = "0x213FF50", VA = "0x182141350")]
		private void _RenderMainlineActDisplayPart()
		{
		}

		// Token: 0x060261F6 RID: 156150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261F6")]
		[Address(RVA = "0x2140C30", Offset = "0x213F830", VA = "0x182140C30")]
		public void EventOnThemeClicked()
		{
		}

		// Token: 0x060261F7 RID: 156151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261F7")]
		[Address(RVA = "0x21412C0", Offset = "0x213FEC0", VA = "0x1821412C0")]
		private string _GetChapterSpriteName(string chapterId)
		{
			return null;
		}

		// Token: 0x060261F8 RID: 156152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261F8")]
		[Address(RVA = "0x21417C0", Offset = "0x21403C0", VA = "0x1821417C0")]
		public StageZoneHomeThemeMainlineView()
		{
		}

		// Token: 0x04035ADB RID: 219867
		[Token(Token = "0x4035ADB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objMainlineProcessing;

		// Token: 0x04035ADC RID: 219868
		[Token(Token = "0x4035ADC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgChapter;

		// Token: 0x04035ADD RID: 219869
		[Token(Token = "0x4035ADD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgMainMagnify;

		// Token: 0x04035ADE RID: 219870
		[Token(Token = "0x4035ADE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgMainProcessing;

		// Token: 0x04035ADF RID: 219871
		[Token(Token = "0x4035ADF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textZoneIndex;

		// Token: 0x04035AE0 RID: 219872
		[Token(Token = "0x4035AE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textZoneName;

		// Token: 0x04035AE1 RID: 219873
		[Token(Token = "0x4035AE1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textProgressCode;

		// Token: 0x04035AE2 RID: 219874
		[Token(Token = "0x4035AE2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objMainlineActDisplay;

		// Token: 0x04035AE3 RID: 219875
		[Token(Token = "0x4035AE3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgMainActDisplay;

		// Token: 0x04035AE4 RID: 219876
		[Token(Token = "0x4035AE4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite _imgLogo;

		// Token: 0x04035AE5 RID: 219877
		[Token(Token = "0x4035AE5")]
		[FieldOffset(Offset = "0x70")]
		private ZoneHomeMainlineEntryItemModel m_viewModel;

		// Token: 0x04035AE6 RID: 219878
		[Token(Token = "0x4035AE6")]
		[FieldOffset(Offset = "0x78")]
		private ActivityThemeData m_themeData;

		// Token: 0x04035AE7 RID: 219879
		[Token(Token = "0x4035AE7")]
		private const string CHAPTER_NAME_FORMAT = "theme_{0}";

		// Token: 0x04035AE8 RID: 219880
		[Token(Token = "0x4035AE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetThemeLogo;

		// Token: 0x04035AE9 RID: 219881
		[Token(Token = "0x4035AE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035AEA RID: 219882
		[Token(Token = "0x4035AEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderMainlineProcessingPart;

		// Token: 0x04035AEB RID: 219883
		[Token(Token = "0x4035AEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderMainlineActDisplayPart;

		// Token: 0x04035AEC RID: 219884
		[Token(Token = "0x4035AEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnThemeClicked;

		// Token: 0x04035AED RID: 219885
		[Token(Token = "0x4035AED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetChapterSpriteName;

		// Token: 0x04035AEE RID: 219886
		[Token(Token = "0x4035AEE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
