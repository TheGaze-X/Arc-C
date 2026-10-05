using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B74 RID: 23412
	[Token(Token = "0x2005B74")]
	public class SocialGetCrisisV2View : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021FCF RID: 139215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FCF")]
		[Address(RVA = "0x1C81D90", Offset = "0x1C80990", VA = "0x181C81D90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021FD0 RID: 139216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD0")]
		[Address(RVA = "0x1C81AE0", Offset = "0x1C806E0", VA = "0x181C81AE0")]
		public void Render(SocialGetCrisisV2ViewModel model)
		{
		}

		// Token: 0x06021FD1 RID: 139217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FD1")]
		[Address(RVA = "0x1C81E90", Offset = "0x1C80A90", VA = "0x181C81E90")]
		public SocialGetCrisisV2View()
		{
		}

		// Token: 0x0402E95A RID: 190810
		[Token(Token = "0x402E95A")]
		private const int ICON_COUNT = 3;

		// Token: 0x0402E95B RID: 190811
		[Token(Token = "0x402E95B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _crisisUsedTime;

		// Token: 0x0402E95C RID: 190812
		[Token(Token = "0x402E95C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SocialGetHeadIconView _charHeadIconPrefab;

		// Token: 0x0402E95D RID: 190813
		[Token(Token = "0x402E95D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _charHeadIconContainer;

		// Token: 0x0402E95E RID: 190814
		[Token(Token = "0x402E95E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _highestScoreToggle;

		// Token: 0x0402E95F RID: 190815
		[Token(Token = "0x402E95F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _highestScoreText;

		// Token: 0x0402E960 RID: 190816
		[Token(Token = "0x402E960")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402E961 RID: 190817
		[Token(Token = "0x402E961")]
		[FieldOffset(Offset = "0x48")]
		private List<SocialGetHeadIconView> m_headIconList;

		// Token: 0x0402E962 RID: 190818
		[Token(Token = "0x402E962")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E963 RID: 190819
		[Token(Token = "0x402E963")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E964 RID: 190820
		[Token(Token = "0x402E964")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
