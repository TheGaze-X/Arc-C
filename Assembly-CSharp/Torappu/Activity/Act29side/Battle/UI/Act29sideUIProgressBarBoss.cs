using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Activity.Act29side.Battle.UI
{
	// Token: 0x020074B5 RID: 29877
	[Token(Token = "0x20074B5")]
	public class Act29sideUIProgressBarBoss : MonoBehaviour
	{
		// Token: 0x0602A225 RID: 172581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A225")]
		[Address(RVA = "0x25D2330", Offset = "0x25D0F30", VA = "0x1825D2330")]
		public void Init(Act29sideUIPlugin.ProgressBarInfo info)
		{
		}

		// Token: 0x0602A226 RID: 172582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A226")]
		[Address(RVA = "0x25D27B0", Offset = "0x25D13B0", VA = "0x1825D27B0")]
		public void UpdateProgressBar()
		{
		}

		// Token: 0x0602A227 RID: 172583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A227")]
		[Address(RVA = "0x25D3560", Offset = "0x25D2160", VA = "0x1825D3560")]
		private void _DoFade(bool isFadeIn, ref UIAtlasImage atlas, ref Tween tween)
		{
		}

		// Token: 0x0602A228 RID: 172584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A228")]
		[Address(RVA = "0x25D2ED0", Offset = "0x25D1AD0", VA = "0x1825D2ED0")]
		private void _DoFadeIn(Act29SideManager.AudioType audioType)
		{
		}

		// Token: 0x0602A229 RID: 172585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A229")]
		[Address(RVA = "0x25D3070", Offset = "0x25D1C70", VA = "0x1825D3070")]
		private void _DoFadeOut(Act29SideManager.AudioType audioType)
		{
		}

		// Token: 0x0602A22A RID: 172586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A22A")]
		[Address(RVA = "0x25D2E00", Offset = "0x25D1A00", VA = "0x1825D2E00")]
		private void _CloseAllTweens()
		{
		}

		// Token: 0x0602A22B RID: 172587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A22B")]
		[Address(RVA = "0x25D36E0", Offset = "0x25D22E0", VA = "0x1825D36E0")]
		private void _SwitchToBossDeadStage()
		{
		}

		// Token: 0x0602A22C RID: 172588 RVA: 0x000D7868 File Offset: 0x000D5A68
		[Token(Token = "0x602A22C")]
		[Address(RVA = "0x25D36C0", Offset = "0x25D22C0", VA = "0x1825D36C0")]
		private Act29SideManager.AudioType _GetOppositeAudioType(Act29SideManager.AudioType audioType)
		{
			return Act29SideManager.AudioType.None;
		}

		// Token: 0x0602A22D RID: 172589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A22D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public Act29sideUIProgressBarBoss()
		{
		}

		// Token: 0x0403C86A RID: 247914
		[Token(Token = "0x403C86A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _enthuBarColor;

		// Token: 0x0403C86B RID: 247915
		[Token(Token = "0x403C86B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _depressedBarColor;

		// Token: 0x0403C86C RID: 247916
		[Token(Token = "0x403C86C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _emptyBarColor;

		// Token: 0x0403C86D RID: 247917
		[Token(Token = "0x403C86D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _enthuPredictColor;

		// Token: 0x0403C86E RID: 247918
		[Token(Token = "0x403C86E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _depressedPredictColor;

		// Token: 0x0403C86F RID: 247919
		[Token(Token = "0x403C86F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _predictMark;

		// Token: 0x0403C870 RID: 247920
		[Token(Token = "0x403C870")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _progressBarBackground;

		// Token: 0x0403C871 RID: 247921
		[Token(Token = "0x403C871")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _progressBarProcessing;

		// Token: 0x0403C872 RID: 247922
		[Token(Token = "0x403C872")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _progressMark;

		// Token: 0x0403C873 RID: 247923
		[Token(Token = "0x403C873")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _progressMarkDepressed;

		// Token: 0x0403C874 RID: 247924
		[Token(Token = "0x403C874")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAtlasImage _progressMarkEnthu;

		// Token: 0x0403C875 RID: 247925
		[Token(Token = "0x403C875")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAtlasImage _progressMarkEmpty;

		// Token: 0x0403C876 RID: 247926
		[Token(Token = "0x403C876")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAtlasImage _blurMask;

		// Token: 0x0403C877 RID: 247927
		[Token(Token = "0x403C877")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _anchor;

		// Token: 0x0403C878 RID: 247928
		[Token(Token = "0x403C878")]
		[FieldOffset(Offset = "0xB0")]
		private Act29SideManager m_manager;

		// Token: 0x0403C879 RID: 247929
		[Token(Token = "0x403C879")]
		[FieldOffset(Offset = "0xB8")]
		private Act29SideManager.AudioType m_audiotypeLastTick;

		// Token: 0x0403C87A RID: 247930
		[Token(Token = "0x403C87A")]
		[FieldOffset(Offset = "0xBC")]
		private Act29SideManager.AudioType m_audiotypeNextTrigger;

		// Token: 0x0403C87B RID: 247931
		[Token(Token = "0x403C87B")]
		[FieldOffset(Offset = "0xC0")]
		private float m_tweenTime;

		// Token: 0x0403C87C RID: 247932
		[Token(Token = "0x403C87C")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_lockProgressMark;

		// Token: 0x0403C87D RID: 247933
		[Token(Token = "0x403C87D")]
		[FieldOffset(Offset = "0xC5")]
		private bool m_endAudioStage;

		// Token: 0x0403C87E RID: 247934
		[Token(Token = "0x403C87E")]
		[FieldOffset(Offset = "0xC6")]
		private bool m_isBossDead;

		// Token: 0x0403C87F RID: 247935
		[Token(Token = "0x403C87F")]
		[FieldOffset(Offset = "0xC7")]
		private bool m_firstFadeIn;

		// Token: 0x0403C880 RID: 247936
		[Token(Token = "0x403C880")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_markEnthuTweenFI;

		// Token: 0x0403C881 RID: 247937
		[Token(Token = "0x403C881")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_markDepressedTweenFI;

		// Token: 0x0403C882 RID: 247938
		[Token(Token = "0x403C882")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_markEmptyTweenFO;

		// Token: 0x0403C883 RID: 247939
		[Token(Token = "0x403C883")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_markPredictTweenFO;

		// Token: 0x0403C884 RID: 247940
		[Token(Token = "0x403C884")]
		[FieldOffset(Offset = "0xE8")]
		private Sequence seq_1;

		// Token: 0x0403C885 RID: 247941
		[Token(Token = "0x403C885")]
		[FieldOffset(Offset = "0xF0")]
		private Sequence seq_2;

		// Token: 0x0403C886 RID: 247942
		[Token(Token = "0x403C886")]
		private const float BLUR_MASK_MARGIN = 5f;
	}
}
