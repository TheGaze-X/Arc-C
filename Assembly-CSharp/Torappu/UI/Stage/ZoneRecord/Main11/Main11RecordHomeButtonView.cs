using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A25 RID: 27173
	[Token(Token = "0x2006A25")]
	public class Main11RecordHomeButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005BA7 RID: 23463
		// (get) Token: 0x06026D74 RID: 159092 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D75 RID: 159093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BA7")]
		public Action<string> onBtnClicked
		{
			[Token(Token = "0x6026D74")]
			[Address(RVA = "0x21F05F0", Offset = "0x21EF1F0", VA = "0x1821F05F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026D75")]
			[Address(RVA = "0x21F0650", Offset = "0x21EF250", VA = "0x1821F0650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026D76 RID: 159094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D76")]
		[Address(RVA = "0x21EFDA0", Offset = "0x21EE9A0", VA = "0x1821EFDA0")]
		public void Render(ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026D77 RID: 159095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D77")]
		[Address(RVA = "0x21EFCC0", Offset = "0x21EE8C0", VA = "0x1821EFCC0")]
		public void OnButtonClicked()
		{
		}

		// Token: 0x06026D78 RID: 159096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D78")]
		[Address(RVA = "0x21F0180", Offset = "0x21EED80", VA = "0x1821F0180")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D79 RID: 159097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D79")]
		[Address(RVA = "0x21F0430", Offset = "0x21EF030", VA = "0x1821F0430")]
		private void _UpdateButtonGlow(Main11RecordHomeButtonView.Main11RecordHomeButtonGlowTweenWrapper tween, bool glow)
		{
		}

		// Token: 0x06026D7A RID: 159098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D7A")]
		[Address(RVA = "0x21F0540", Offset = "0x21EF140", VA = "0x1821F0540")]
		public Main11RecordHomeButtonView()
		{
		}

		// Token: 0x04036E5C RID: 224860
		[Token(Token = "0x4036E5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04036E5D RID: 224861
		[Token(Token = "0x4036E5D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x04036E5E RID: 224862
		[Token(Token = "0x4036E5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Main11RecordHomeButtonView.StageDiffImage[] _panelDiffGroup;

		// Token: 0x04036E5F RID: 224863
		[Token(Token = "0x4036E5F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasBtnPrevGlow;

		// Token: 0x04036E60 RID: 224864
		[Token(Token = "0x4036E60")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _trackPointReward;

		// Token: 0x04036E61 RID: 224865
		[Token(Token = "0x4036E61")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textRecordName;

		// Token: 0x04036E62 RID: 224866
		[Token(Token = "0x4036E62")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedRecordId;

		// Token: 0x04036E63 RID: 224867
		[Token(Token = "0x4036E63")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<ZoneRecordViewModel.RecordDiffIconType, GameObject> m_diffImgDict;

		// Token: 0x04036E64 RID: 224868
		[Token(Token = "0x4036E64")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04036E65 RID: 224869
		[Token(Token = "0x4036E65")]
		[FieldOffset(Offset = "0x60")]
		private Main11RecordHomeButtonView.Main11RecordHomeButtonGlowTweenWrapper m_glowTween;

		// Token: 0x04036E66 RID: 224870
		[Token(Token = "0x4036E66")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_rewardTrackProperty;

		// Token: 0x04036E68 RID: 224872
		[Token(Token = "0x4036E68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnClicked;

		// Token: 0x04036E69 RID: 224873
		[Token(Token = "0x4036E69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnClicked;

		// Token: 0x04036E6A RID: 224874
		[Token(Token = "0x4036E6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036E6B RID: 224875
		[Token(Token = "0x4036E6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnButtonClicked;

		// Token: 0x04036E6C RID: 224876
		[Token(Token = "0x4036E6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036E6D RID: 224877
		[Token(Token = "0x4036E6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateButtonGlow;

		// Token: 0x04036E6E RID: 224878
		[Token(Token = "0x4036E6E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A26 RID: 27174
		[Token(Token = "0x2006A26")]
		[Serializable]
		private struct StageDiffImage
		{
			// Token: 0x04036E6F RID: 224879
			[Token(Token = "0x4036E6F")]
			[FieldOffset(Offset = "0x0")]
			public ZoneRecordViewModel.RecordDiffIconType stageDiff;

			// Token: 0x04036E70 RID: 224880
			[Token(Token = "0x4036E70")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelImage;
		}

		// Token: 0x02006A27 RID: 27175
		[Token(Token = "0x2006A27")]
		private class Main11RecordHomeButtonGlowTweenWrapper : IHotfixable
		{
			// Token: 0x06026D7B RID: 159099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D7B")]
			[Address(RVA = "0x21EF950", Offset = "0x21EE550", VA = "0x1821EF950")]
			public void SetCanvasGroup(CanvasGroup canvas)
			{
			}

			// Token: 0x06026D7C RID: 159100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D7C")]
			[Address(RVA = "0x21EF9D0", Offset = "0x21EE5D0", VA = "0x1821EF9D0")]
			public void SetTween()
			{
			}

			// Token: 0x06026D7D RID: 159101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D7D")]
			[Address(RVA = "0x21EF8D0", Offset = "0x21EE4D0", VA = "0x1821EF8D0")]
			public void KillTween()
			{
			}

			// Token: 0x06026D7E RID: 159102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D7E")]
			[Address(RVA = "0x21EFC60", Offset = "0x21EE860", VA = "0x1821EFC60")]
			public Main11RecordHomeButtonGlowTweenWrapper()
			{
			}

			// Token: 0x04036E71 RID: 224881
			[Token(Token = "0x4036E71")]
			[FieldOffset(Offset = "0x10")]
			private CanvasGroup m_glowCanvasGroup;

			// Token: 0x04036E72 RID: 224882
			[Token(Token = "0x4036E72")]
			[FieldOffset(Offset = "0x18")]
			private Sequence m_tween;

			// Token: 0x04036E73 RID: 224883
			[Token(Token = "0x4036E73")]
			private const float GLOW_TWEEN_DUR = 1f;

			// Token: 0x04036E74 RID: 224884
			[Token(Token = "0x4036E74")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetCanvasGroup;

			// Token: 0x04036E75 RID: 224885
			[Token(Token = "0x4036E75")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetTween;

			// Token: 0x04036E76 RID: 224886
			[Token(Token = "0x4036E76")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_KillTween;

			// Token: 0x04036E77 RID: 224887
			[Token(Token = "0x4036E77")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
