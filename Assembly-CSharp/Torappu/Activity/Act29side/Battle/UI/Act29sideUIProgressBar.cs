using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Activity.Act29side.Battle.UI
{
	// Token: 0x020074B4 RID: 29876
	[Token(Token = "0x20074B4")]
	public class Act29sideUIProgressBar : MonoBehaviour
	{
		// Token: 0x17006355 RID: 25429
		// (get) Token: 0x0602A21D RID: 172573 RVA: 0x000D7850 File Offset: 0x000D5A50
		[Token(Token = "0x17006355")]
		public bool isActive
		{
			[Token(Token = "0x602A21D")]
			[Address(RVA = "0x25D44D0", Offset = "0x25D30D0", VA = "0x1825D44D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A21E RID: 172574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A21E")]
		[Address(RVA = "0x25D3A60", Offset = "0x25D2660", VA = "0x1825D3A60")]
		public void Init(Act29sideUIPlugin.ProgressBarInfo info)
		{
		}

		// Token: 0x0602A21F RID: 172575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A21F")]
		[Address(RVA = "0x25D39A0", Offset = "0x25D25A0", VA = "0x1825D39A0")]
		public void Active()
		{
		}

		// Token: 0x0602A220 RID: 172576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A220")]
		[Address(RVA = "0x25D39B0", Offset = "0x25D25B0", VA = "0x1825D39B0")]
		public void Inactive()
		{
		}

		// Token: 0x0602A221 RID: 172577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A221")]
		[Address(RVA = "0x25D4000", Offset = "0x25D2C00", VA = "0x1825D4000")]
		public void UpdateProgressBar()
		{
		}

		// Token: 0x0602A222 RID: 172578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A222")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public Act29sideUIProgressBar()
		{
		}

		// Token: 0x0403C84C RID: 247884
		[Token(Token = "0x403C84C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _enthuBarColor;

		// Token: 0x0403C84D RID: 247885
		[Token(Token = "0x403C84D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _depressedBarColor;

		// Token: 0x0403C84E RID: 247886
		[Token(Token = "0x403C84E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _emptyBarColor;

		// Token: 0x0403C84F RID: 247887
		[Token(Token = "0x403C84F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _enthuPredictColor;

		// Token: 0x0403C850 RID: 247888
		[Token(Token = "0x403C850")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _depressedPredictColor;

		// Token: 0x0403C851 RID: 247889
		[Token(Token = "0x403C851")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _predictMark;

		// Token: 0x0403C852 RID: 247890
		[Token(Token = "0x403C852")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _progressBarBackground;

		// Token: 0x0403C853 RID: 247891
		[Token(Token = "0x403C853")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _progressBarProcessing;

		// Token: 0x0403C854 RID: 247892
		[Token(Token = "0x403C854")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _blurMask;

		// Token: 0x0403C855 RID: 247893
		[Token(Token = "0x403C855")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _markInactiveLeft;

		// Token: 0x0403C856 RID: 247894
		[Token(Token = "0x403C856")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAtlasImage _markInactiveRight;

		// Token: 0x0403C857 RID: 247895
		[Token(Token = "0x403C857")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAtlasImage _markActiveRightEnthu;

		// Token: 0x0403C858 RID: 247896
		[Token(Token = "0x403C858")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAtlasImage _markActiveRightDepressed;

		// Token: 0x0403C859 RID: 247897
		[Token(Token = "0x403C859")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _decoEnthu;

		// Token: 0x0403C85A RID: 247898
		[Token(Token = "0x403C85A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _decoDepressed;

		// Token: 0x0403C85B RID: 247899
		[Token(Token = "0x403C85B")]
		[FieldOffset(Offset = "0xB8")]
		private Act29SideManager m_manager;

		// Token: 0x0403C85C RID: 247900
		[Token(Token = "0x403C85C")]
		[FieldOffset(Offset = "0xC0")]
		private Act29SideManager.AudioType m_type;

		// Token: 0x0403C85D RID: 247901
		[Token(Token = "0x403C85D")]
		[FieldOffset(Offset = "0xC4")]
		private float m_progress;

		// Token: 0x0403C85E RID: 247902
		[Token(Token = "0x403C85E")]
		[FieldOffset(Offset = "0xC8")]
		private float m_width;

		// Token: 0x0403C85F RID: 247903
		[Token(Token = "0x403C85F")]
		[FieldOffset(Offset = "0xCC")]
		private float m_audioBuffLength;

		// Token: 0x0403C860 RID: 247904
		[Token(Token = "0x403C860")]
		[FieldOffset(Offset = "0xD0")]
		private float m_tweenTime;

		// Token: 0x0403C861 RID: 247905
		[Token(Token = "0x403C861")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_isActive;

		// Token: 0x0403C862 RID: 247906
		[Token(Token = "0x403C862")]
		[FieldOffset(Offset = "0xD5")]
		private bool m_needFadingOut;

		// Token: 0x0403C863 RID: 247907
		[Token(Token = "0x403C863")]
		[FieldOffset(Offset = "0xD6")]
		private bool m_fadingOutOver;

		// Token: 0x0403C864 RID: 247908
		[Token(Token = "0x403C864")]
		[FieldOffset(Offset = "0xD7")]
		private bool m_isFadingIn;

		// Token: 0x0403C865 RID: 247909
		[Token(Token = "0x403C865")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_fadingInOver;

		// Token: 0x0403C866 RID: 247910
		[Token(Token = "0x403C866")]
		[FieldOffset(Offset = "0xD9")]
		private bool m_hideRightMark;

		// Token: 0x0403C867 RID: 247911
		[Token(Token = "0x403C867")]
		[FieldOffset(Offset = "0xE0")]
		private RectTransform m_rect;

		// Token: 0x0403C868 RID: 247912
		[Token(Token = "0x403C868")]
		private const float PREDICT_MARK_SCALER = 0.66f;

		// Token: 0x0403C869 RID: 247913
		[Token(Token = "0x403C869")]
		private const float BLUR_MASK_MARGIN = 5f;
	}
}
