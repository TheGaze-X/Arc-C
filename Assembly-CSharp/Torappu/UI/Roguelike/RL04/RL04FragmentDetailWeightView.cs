using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056C8 RID: 22216
	[Token(Token = "0x20056C8")]
	public class RL04FragmentDetailWeightView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020957 RID: 133463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020957")]
		[Address(RVA = "0x1AAF490", Offset = "0x1AAE090", VA = "0x181AAF490")]
		public void Render(RL04FragmentDetailWeightViewModel model)
		{
		}

		// Token: 0x06020958 RID: 133464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020958")]
		[Address(RVA = "0x1AAF910", Offset = "0x1AAE510", VA = "0x181AAF910")]
		private void _TryPlayLoopAnim()
		{
		}

		// Token: 0x06020959 RID: 133465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020959")]
		[Address(RVA = "0x1AAF9B0", Offset = "0x1AAE5B0", VA = "0x181AAF9B0")]
		public RL04FragmentDetailWeightView()
		{
		}

		// Token: 0x0402C28F RID: 180879
		[Token(Token = "0x402C28F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayoutElement _elementLimitWeight;

		// Token: 0x0402C290 RID: 180880
		[Token(Token = "0x402C290")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLimitWeight;

		// Token: 0x0402C291 RID: 180881
		[Token(Token = "0x402C291")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayoutElement _elementOverWeight;

		// Token: 0x0402C292 RID: 180882
		[Token(Token = "0x402C292")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textOverWeight;

		// Token: 0x0402C293 RID: 180883
		[Token(Token = "0x402C293")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _sliderWeight;

		// Token: 0x0402C294 RID: 180884
		[Token(Token = "0x402C294")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _sliderWeightWithoutFragment;

		// Token: 0x0402C295 RID: 180885
		[Token(Token = "0x402C295")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _textCurrWeight;

		// Token: 0x0402C296 RID: 180886
		[Token(Token = "0x402C296")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _panelNormal;

		// Token: 0x0402C297 RID: 180887
		[Token(Token = "0x402C297")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _panelLimitWeight;

		// Token: 0x0402C298 RID: 180888
		[Token(Token = "0x402C298")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject[] _panelOverWeight;

		// Token: 0x0402C299 RID: 180889
		[Token(Token = "0x402C299")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] _panelNotOverWeight;

		// Token: 0x0402C29A RID: 180890
		[Token(Token = "0x402C29A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x0402C29B RID: 180891
		[Token(Token = "0x402C29B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C29C RID: 180892
		[Token(Token = "0x402C29C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryPlayLoopAnim;

		// Token: 0x0402C29D RID: 180893
		[Token(Token = "0x402C29D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
