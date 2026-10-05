using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007461 RID: 29793
	[Token(Token = "0x2007461")]
	public class Act36sideZoneMapCardBackView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006324 RID: 25380
		// (get) Token: 0x0602A074 RID: 172148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006324")]
		public Image imgBack
		{
			[Token(Token = "0x602A074")]
			[Address(RVA = "0x25A0E90", Offset = "0x259FA90", VA = "0x1825A0E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A075 RID: 172149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A075")]
		[Address(RVA = "0x25A0D90", Offset = "0x259F990", VA = "0x1825A0D90")]
		private void _SampleAnim(float sampleVal)
		{
		}

		// Token: 0x0602A076 RID: 172150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A076")]
		[Address(RVA = "0x25A0BA0", Offset = "0x259F7A0", VA = "0x1825A0BA0")]
		public void Render(int pageIndex)
		{
		}

		// Token: 0x0602A077 RID: 172151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A077")]
		[Address(RVA = "0x25A0C10", Offset = "0x259F810", VA = "0x1825A0C10")]
		public void UpdateFocusPage(float pageIndex)
		{
		}

		// Token: 0x0602A078 RID: 172152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A078")]
		[Address(RVA = "0x25A0B30", Offset = "0x259F730", VA = "0x1825A0B30")]
		public void OnCardClick()
		{
		}

		// Token: 0x0602A079 RID: 172153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A079")]
		[Address(RVA = "0x25A0E30", Offset = "0x259FA30", VA = "0x1825A0E30")]
		public Act36sideZoneMapCardBackView()
		{
		}

		// Token: 0x0403C4A8 RID: 246952
		[Token(Token = "0x403C4A8")]
		private const float PAGE_INDEX_MAX = 2f;

		// Token: 0x0403C4A9 RID: 246953
		[Token(Token = "0x403C4A9")]
		private const float PAGE_INDEX_MIN = -2f;

		// Token: 0x0403C4AA RID: 246954
		[Token(Token = "0x403C4AA")]
		private const float SAMPLE_FACTOR = 0.25f;

		// Token: 0x0403C4AB RID: 246955
		[Token(Token = "0x403C4AB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBack;

		// Token: 0x0403C4AC RID: 246956
		[Token(Token = "0x403C4AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _floatPanel;

		// Token: 0x0403C4AD RID: 246957
		[Token(Token = "0x403C4AD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _scaleSampleAnim;

		// Token: 0x0403C4AE RID: 246958
		[Token(Token = "0x403C4AE")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<int> onCardClick;

		// Token: 0x0403C4AF RID: 246959
		[Token(Token = "0x403C4AF")]
		[FieldOffset(Offset = "0x40")]
		private int m_pageIndex;

		// Token: 0x0403C4B0 RID: 246960
		[Token(Token = "0x403C4B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_imgBack;

		// Token: 0x0403C4B1 RID: 246961
		[Token(Token = "0x403C4B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SampleAnim;

		// Token: 0x0403C4B2 RID: 246962
		[Token(Token = "0x403C4B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C4B3 RID: 246963
		[Token(Token = "0x403C4B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateFocusPage;

		// Token: 0x0403C4B4 RID: 246964
		[Token(Token = "0x403C4B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x0403C4B5 RID: 246965
		[Token(Token = "0x403C4B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
