using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059A8 RID: 22952
	[Token(Token = "0x20059A8")]
	public class CrisisV2MapBagBgView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602174F RID: 137039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602174F")]
		[Address(RVA = "0x1BC2D80", Offset = "0x1BC1980", VA = "0x181BC2D80")]
		private void _SetPos(Vector2 pos, Vector2 size)
		{
		}

		// Token: 0x06021750 RID: 137040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021750")]
		[Address(RVA = "0x1BC2820", Offset = "0x1BC1420", VA = "0x181BC2820")]
		public void Init(Vector2 bagPos, Vector2 bagSize)
		{
		}

		// Token: 0x06021751 RID: 137041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021751")]
		[Address(RVA = "0x1BC29F0", Offset = "0x1BC15F0", VA = "0x181BC29F0")]
		public void Render(CrisisV2MapBagModel bagModel, bool isVisible, string tutorialKey)
		{
		}

		// Token: 0x06021752 RID: 137042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021752")]
		[Address(RVA = "0x1BC2C40", Offset = "0x1BC1840", VA = "0x181BC2C40")]
		private void _RegisterTutorialGoIfNeed(string key)
		{
		}

		// Token: 0x06021753 RID: 137043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021753")]
		[Address(RVA = "0x1BC2E50", Offset = "0x1BC1A50", VA = "0x181BC2E50")]
		public CrisisV2MapBagBgView()
		{
		}

		// Token: 0x0402DA95 RID: 187029
		[Token(Token = "0x402DA95")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgDimension;

		// Token: 0x0402DA96 RID: 187030
		[Token(Token = "0x402DA96")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _dimensionAtlas;

		// Token: 0x0402DA97 RID: 187031
		[Token(Token = "0x402DA97")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x0402DA98 RID: 187032
		[Token(Token = "0x402DA98")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelFocus;

		// Token: 0x0402DA99 RID: 187033
		[Token(Token = "0x402DA99")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DA9A RID: 187034
		[Token(Token = "0x402DA9A")]
		[FieldOffset(Offset = "0x50")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402DA9B RID: 187035
		[Token(Token = "0x402DA9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetPos;

		// Token: 0x0402DA9C RID: 187036
		[Token(Token = "0x402DA9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402DA9D RID: 187037
		[Token(Token = "0x402DA9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DA9E RID: 187038
		[Token(Token = "0x402DA9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGoIfNeed;

		// Token: 0x0402DA9F RID: 187039
		[Token(Token = "0x402DA9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
