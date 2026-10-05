using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066FA RID: 26362
	[Token(Token = "0x20066FA")]
	public class HandBookV2MapForceCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700599A RID: 22938
		// (get) Token: 0x06025D64 RID: 154980 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025D65 RID: 154981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700599A")]
		public UIStringEvent onCardClick
		{
			[Token(Token = "0x6025D64")]
			[Address(RVA = "0x20C5C10", Offset = "0x20C4810", VA = "0x1820C5C10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025D65")]
			[Address(RVA = "0x20C5C70", Offset = "0x20C4870", VA = "0x1820C5C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025D66 RID: 154982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D66")]
		[Address(RVA = "0x20C5240", Offset = "0x20C3E40", VA = "0x1820C5240")]
		public void OnCardClick()
		{
		}

		// Token: 0x06025D67 RID: 154983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D67")]
		[Address(RVA = "0x20C5350", Offset = "0x20C3F50", VA = "0x1820C5350")]
		public void PlayFadeOut(bool isFadeOut)
		{
		}

		// Token: 0x06025D68 RID: 154984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D68")]
		[Address(RVA = "0x20C5470", Offset = "0x20C4070", VA = "0x1820C5470")]
		public void Render(HandBookV2ForceViewModel viewModel)
		{
		}

		// Token: 0x06025D69 RID: 154985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D69")]
		[Address(RVA = "0x20C5AB0", Offset = "0x20C46B0", VA = "0x1820C5AB0")]
		private void _UpdateTrackPoint(List<string> charIdList)
		{
		}

		// Token: 0x06025D6A RID: 154986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D6A")]
		[Address(RVA = "0x20C5B70", Offset = "0x20C4770", VA = "0x1820C5B70")]
		public HandBookV2MapForceCardView()
		{
		}

		// Token: 0x0403530F RID: 217871
		[Token(Token = "0x403530F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _clickAreaGo;

		// Token: 0x04035310 RID: 217872
		[Token(Token = "0x4035310")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textForceName;

		// Token: 0x04035311 RID: 217873
		[Token(Token = "0x4035311")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textForceCode;

		// Token: 0x04035312 RID: 217874
		[Token(Token = "0x4035312")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCollect;

		// Token: 0x04035313 RID: 217875
		[Token(Token = "0x4035313")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgCharCount;

		// Token: 0x04035314 RID: 217876
		[Token(Token = "0x4035314")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCharCount;

		// Token: 0x04035315 RID: 217877
		[Token(Token = "0x4035315")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _updatedTrackPoint;

		// Token: 0x04035316 RID: 217878
		[Token(Token = "0x4035316")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x04035317 RID: 217879
		[Token(Token = "0x4035317")]
		private const string CARD_FADE_OUT = "card_fade_out";

		// Token: 0x04035318 RID: 217880
		[Token(Token = "0x4035318")]
		[FieldOffset(Offset = "0x58")]
		private TrackPointViewProperty m_updatedTrackPointProperty;

		// Token: 0x04035319 RID: 217881
		[Token(Token = "0x4035319")]
		[FieldOffset(Offset = "0x60")]
		private HandBookV2ForceViewModel m_forceViewModel;

		// Token: 0x0403531A RID: 217882
		[Token(Token = "0x403531A")]
		[FieldOffset(Offset = "0x68")]
		private HandbookTeamData m_forceData;

		// Token: 0x0403531C RID: 217884
		[Token(Token = "0x403531C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCardClick;

		// Token: 0x0403531D RID: 217885
		[Token(Token = "0x403531D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCardClick;

		// Token: 0x0403531E RID: 217886
		[Token(Token = "0x403531E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x0403531F RID: 217887
		[Token(Token = "0x403531F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayFadeOut;

		// Token: 0x04035320 RID: 217888
		[Token(Token = "0x4035320")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035321 RID: 217889
		[Token(Token = "0x4035321")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateTrackPoint;

		// Token: 0x04035322 RID: 217890
		[Token(Token = "0x4035322")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
