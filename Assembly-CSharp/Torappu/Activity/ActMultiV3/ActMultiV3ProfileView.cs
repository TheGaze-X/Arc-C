using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Friend;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F57 RID: 28503
	[Token(Token = "0x2006F57")]
	public class ActMultiV3ProfileView : UIStylerApplier<NameCardV2SkinStyle>, IHotfixable
	{
		// Token: 0x060287A8 RID: 165800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A8")]
		[Address(RVA = "0x23D0430", Offset = "0x23CF030", VA = "0x1823D0430")]
		public void Render(ActMultiV3ManualProfileModel profileModel)
		{
		}

		// Token: 0x060287A9 RID: 165801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A9")]
		[Address(RVA = "0x23D03A0", Offset = "0x23CEFA0", VA = "0x1823D03A0")]
		public void OnClickTitle()
		{
		}

		// Token: 0x060287AA RID: 165802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287AA")]
		[Address(RVA = "0x23D0300", Offset = "0x23CEF00", VA = "0x1823D0300", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x060287AB RID: 165803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287AB")]
		[Address(RVA = "0x23D0950", Offset = "0x23CF550", VA = "0x1823D0950")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287AC RID: 165804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287AC")]
		[Address(RVA = "0x23D0A70", Offset = "0x23CF670", VA = "0x1823D0A70")]
		public ActMultiV3ProfileView()
		{
		}

		// Token: 0x0403994A RID: 235850
		[Token(Token = "0x403994A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Profile")]
		private Text _completeMatchText;

		// Token: 0x0403994B RID: 235851
		[Token(Token = "0x403994B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Profile")]
		private Text _assistPlayerText;

		// Token: 0x0403994C RID: 235852
		[Token(Token = "0x403994C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Profile")]
		private Text _praisedText;

		// Token: 0x0403994D RID: 235853
		[Token(Token = "0x403994D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Profile")]
		private Text _titleText;

		// Token: 0x0403994E RID: 235854
		[Token(Token = "0x403994E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Profile")]
		private GameObject _newTrackPointObj;

		// Token: 0x0403994F RID: 235855
		[Token(Token = "0x403994F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Profile")]
		private RectTransform _newTrackPointContainer;

		// Token: 0x04039950 RID: 235856
		[Token(Token = "0x4039950")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Profile - Namecard")]
		private Text _doctorLevel;

		// Token: 0x04039951 RID: 235857
		[Token(Token = "0x4039951")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Profile - Namecard")]
		private Text _doctorName;

		// Token: 0x04039952 RID: 235858
		[Token(Token = "0x4039952")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Profile - Namecard")]
		private Text _doctorUid;

		// Token: 0x04039953 RID: 235859
		[Token(Token = "0x4039953")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Profile - Namecard")]
		private GameObject _doctorUidGo;

		// Token: 0x04039954 RID: 235860
		[Token(Token = "0x4039954")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Profile - Namecard")]
		private Image _bgImg;

		// Token: 0x04039955 RID: 235861
		[Token(Token = "0x4039955")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Profile - Namecard")]
		private Transform _avatarContainer;

		// Token: 0x04039956 RID: 235862
		[Token(Token = "0x4039956")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04039957 RID: 235863
		[Token(Token = "0x4039957")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedLoadSeqNum;

		// Token: 0x04039958 RID: 235864
		[Token(Token = "0x4039958")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039959 RID: 235865
		[Token(Token = "0x4039959")]
		[FieldOffset(Offset = "0x98")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0403995A RID: 235866
		[Token(Token = "0x403995A")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_newTitleObj;

		// Token: 0x0403995B RID: 235867
		[Token(Token = "0x403995B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403995C RID: 235868
		[Token(Token = "0x403995C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickTitle;

		// Token: 0x0403995D RID: 235869
		[Token(Token = "0x403995D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0403995E RID: 235870
		[Token(Token = "0x403995E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403995F RID: 235871
		[Token(Token = "0x403995F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
