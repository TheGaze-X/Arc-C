using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A3F RID: 31295
	[Token(Token = "0x2007A3F")]
	public class Act13sidePrestigeProgressView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BD92 RID: 179602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD92")]
		[Address(RVA = "0x27CEF50", Offset = "0x27CDB50", VA = "0x1827CEF50")]
		public void Render(string actId, string orgId, int prestigeCount)
		{
		}

		// Token: 0x170066CF RID: 26319
		// (get) Token: 0x0602BD93 RID: 179603 RVA: 0x000DD688 File Offset: 0x000DB888
		// (set) Token: 0x0602BD94 RID: 179604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066CF")]
		public float sliderVal
		{
			[Token(Token = "0x602BD93")]
			[Address(RVA = "0x27CF310", Offset = "0x27CDF10", VA = "0x1827CF310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x602BD94")]
			[Address(RVA = "0x27CF380", Offset = "0x27CDF80", VA = "0x1827CF380")]
			set
			{
			}
		}

		// Token: 0x0602BD95 RID: 179605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BD95")]
		[Address(RVA = "0x27CEEB0", Offset = "0x27CDAB0", VA = "0x1827CEEB0")]
		public Tweener PlaySliderAnim(float targetVal)
		{
			return null;
		}

		// Token: 0x0602BD96 RID: 179606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD96")]
		[Address(RVA = "0x27CF2A0", Offset = "0x27CDEA0", VA = "0x1827CF2A0")]
		public Act13sidePrestigeProgressView()
		{
		}

		// Token: 0x0403F7C9 RID: 260041
		[Token(Token = "0x403F7C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textNextStage;

		// Token: 0x0403F7CA RID: 260042
		[Token(Token = "0x403F7CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgSlider;

		// Token: 0x0403F7CB RID: 260043
		[Token(Token = "0x403F7CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _sliderAnimDuration;

		// Token: 0x0403F7CC RID: 260044
		[Token(Token = "0x403F7CC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Ease _animEase;

		// Token: 0x0403F7CD RID: 260045
		[Token(Token = "0x403F7CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F7CE RID: 260046
		[Token(Token = "0x403F7CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sliderVal;

		// Token: 0x0403F7CF RID: 260047
		[Token(Token = "0x403F7CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_sliderVal;

		// Token: 0x0403F7D0 RID: 260048
		[Token(Token = "0x403F7D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlaySliderAnim;

		// Token: 0x0403F7D1 RID: 260049
		[Token(Token = "0x403F7D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
