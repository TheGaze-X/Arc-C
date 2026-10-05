using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Medal;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005991 RID: 22929
	[Token(Token = "0x2005991")]
	public class CrisisV2AchievementView : DataBinder<CrisisV2AchievementProperty>, IHotfixable
	{
		// Token: 0x17004E9F RID: 20127
		// (get) Token: 0x060216C8 RID: 136904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060216C9 RID: 136905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E9F")]
		public UIPage page
		{
			[Token(Token = "0x60216C8")]
			[Address(RVA = "0x1BBDA70", Offset = "0x1BBC670", VA = "0x181BBDA70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60216C9")]
			[Address(RVA = "0x1BBDAD0", Offset = "0x1BBC6D0", VA = "0x181BBDAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060216CA RID: 136906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216CA")]
		[Address(RVA = "0x1BBCA70", Offset = "0x1BBB670", VA = "0x181BBCA70", Slot = "7")]
		public override void OnValueChanged(CrisisV2AchievementProperty property)
		{
		}

		// Token: 0x060216CB RID: 136907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216CB")]
		[Address(RVA = "0x1BBC950", Offset = "0x1BBB550", VA = "0x181BBC950")]
		public void EventOnNextBtnClicked()
		{
		}

		// Token: 0x060216CC RID: 136908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216CC")]
		[Address(RVA = "0x1BBC9E0", Offset = "0x1BBB5E0", VA = "0x181BBC9E0")]
		public void EventOnPrevBtnClicked()
		{
		}

		// Token: 0x060216CD RID: 136909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216CD")]
		[Address(RVA = "0x1BBC8C0", Offset = "0x1BBB4C0", VA = "0x181BBC8C0")]
		public void EventOnMedalGroupClicked()
		{
		}

		// Token: 0x060216CE RID: 136910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216CE")]
		[Address(RVA = "0x1BBC830", Offset = "0x1BBB430", VA = "0x181BBC830")]
		public void EventOnHistoryClicked()
		{
		}

		// Token: 0x060216CF RID: 136911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216CF")]
		[Address(RVA = "0x1BBCD30", Offset = "0x1BBB930", VA = "0x181BBCD30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060216D0 RID: 136912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D0")]
		[Address(RVA = "0x1BBD1E0", Offset = "0x1BBBDE0", VA = "0x181BBD1E0")]
		private void _RenderInfo(CrisisV2AchievementSeasonViewModel model, bool showSwitchBtn)
		{
		}

		// Token: 0x060216D1 RID: 136913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D1")]
		[Address(RVA = "0x1BBD010", Offset = "0x1BBBC10", VA = "0x181BBD010")]
		private void _RenderDiagram(CrisisV2AchievementSeasonViewModel model, bool isFastMode)
		{
		}

		// Token: 0x060216D2 RID: 136914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216D2")]
		[Address(RVA = "0x1BBD9F0", Offset = "0x1BBC5F0", VA = "0x181BBD9F0")]
		public CrisisV2AchievementView()
		{
		}

		// Token: 0x0402D97A RID: 186746
		[Token(Token = "0x402D97A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402D97B RID: 186747
		[Token(Token = "0x402D97B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCode;

		// Token: 0x0402D97C RID: 186748
		[Token(Token = "0x402D97C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _panelEmpty;

		// Token: 0x0402D97D RID: 186749
		[Token(Token = "0x402D97D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _panelInfo;

		// Token: 0x0402D97E RID: 186750
		[Token(Token = "0x402D97E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textRuneCount;

		// Token: 0x0402D97F RID: 186751
		[Token(Token = "0x402D97F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CrisisV2AchievementRuneAdapter _runeAdapter;

		// Token: 0x0402D980 RID: 186752
		[Token(Token = "0x402D980")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CrisisV2AchievementCommentAdapter _commentAdapter;

		// Token: 0x0402D981 RID: 186753
		[Token(Token = "0x402D981")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textTotalScore;

		// Token: 0x0402D982 RID: 186754
		[Token(Token = "0x402D982")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgRankIcon;

		// Token: 0x0402D983 RID: 186755
		[Token(Token = "0x402D983")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _imgMapBkg;

		// Token: 0x0402D984 RID: 186756
		[Token(Token = "0x402D984")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgTitle;

		// Token: 0x0402D985 RID: 186757
		[Token(Token = "0x402D985")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _medalGroupContainer;

		// Token: 0x0402D986 RID: 186758
		[Token(Token = "0x402D986")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _panelSwitchBtn;

		// Token: 0x0402D987 RID: 186759
		[Token(Token = "0x402D987")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x0402D988 RID: 186760
		[Token(Token = "0x402D988")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textPlayerNickName;

		// Token: 0x0402D989 RID: 186761
		[Token(Token = "0x402D989")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0402D98A RID: 186762
		[Token(Token = "0x402D98A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CrisisV2DiagramView _diagramPrefab;

		// Token: 0x0402D98B RID: 186763
		[Token(Token = "0x402D98B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _diagramContainer;

		// Token: 0x0402D98C RID: 186764
		[Token(Token = "0x402D98C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelSnapshootEmpty;

		// Token: 0x0402D98D RID: 186765
		[Token(Token = "0x402D98D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelSnapshootNotEmpty;

		// Token: 0x0402D98E RID: 186766
		[Token(Token = "0x402D98E")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402D98F RID: 186767
		[Token(Token = "0x402D98F")]
		[FieldOffset(Offset = "0xD0")]
		private UIMedalGroupView m_medalGroup;

		// Token: 0x0402D990 RID: 186768
		[Token(Token = "0x402D990")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInited;

		// Token: 0x0402D991 RID: 186769
		[Token(Token = "0x402D991")]
		[FieldOffset(Offset = "0xE0")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0402D992 RID: 186770
		[Token(Token = "0x402D992")]
		[FieldOffset(Offset = "0xE8")]
		private CrisisV2DiagramView m_diagramView;

		// Token: 0x0402D994 RID: 186772
		[Token(Token = "0x402D994")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402D995 RID: 186773
		[Token(Token = "0x402D995")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402D996 RID: 186774
		[Token(Token = "0x402D996")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402D997 RID: 186775
		[Token(Token = "0x402D997")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClicked;

		// Token: 0x0402D998 RID: 186776
		[Token(Token = "0x402D998")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnPrevBtnClicked;

		// Token: 0x0402D999 RID: 186777
		[Token(Token = "0x402D999")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnMedalGroupClicked;

		// Token: 0x0402D99A RID: 186778
		[Token(Token = "0x402D99A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnHistoryClicked;

		// Token: 0x0402D99B RID: 186779
		[Token(Token = "0x402D99B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D99C RID: 186780
		[Token(Token = "0x402D99C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderInfo;

		// Token: 0x0402D99D RID: 186781
		[Token(Token = "0x402D99D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderDiagram;

		// Token: 0x0402D99E RID: 186782
		[Token(Token = "0x402D99E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
