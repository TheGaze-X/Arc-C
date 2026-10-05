using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059AE RID: 22958
	[Token(Token = "0x20059AE")]
	public class CrisisV2MapNodePreviewBagItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021777 RID: 137079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021777")]
		[Address(RVA = "0x1BD1C70", Offset = "0x1BD0870", VA = "0x181BD1C70")]
		public void Render(CrisisV2MapBagModel bagModel, bool isAllSelected, CrisisV2Progress nodeProgress)
		{
		}

		// Token: 0x06021778 RID: 137080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021778")]
		[Address(RVA = "0x1BD1B00", Offset = "0x1BD0700", VA = "0x181BD1B00")]
		public void OnBagIconClicked()
		{
		}

		// Token: 0x06021779 RID: 137081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021779")]
		[Address(RVA = "0x1BD1F60", Offset = "0x1BD0B60", VA = "0x181BD1F60")]
		public CrisisV2MapNodePreviewBagItem()
		{
		}

		// Token: 0x0402DB34 RID: 187188
		[Token(Token = "0x402DB34")]
		private const string TOTAL_SCORE_FORMAT = "/{0}";

		// Token: 0x0402DB35 RID: 187189
		[Token(Token = "0x402DB35")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _bagIcon;

		// Token: 0x0402DB36 RID: 187190
		[Token(Token = "0x402DB36")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _bagDimensionObject;

		// Token: 0x0402DB37 RID: 187191
		[Token(Token = "0x402DB37")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _bkgToggle;

		// Token: 0x0402DB38 RID: 187192
		[Token(Token = "0x402DB38")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _triangleDecor;

		// Token: 0x0402DB39 RID: 187193
		[Token(Token = "0x402DB39")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _currentScore;

		// Token: 0x0402DB3A RID: 187194
		[Token(Token = "0x402DB3A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _totalScore;

		// Token: 0x0402DB3B RID: 187195
		[Token(Token = "0x402DB3B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _completedDecor;

		// Token: 0x0402DB3C RID: 187196
		[Token(Token = "0x402DB3C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _iconUnselectColor;

		// Token: 0x0402DB3D RID: 187197
		[Token(Token = "0x402DB3D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _iconSelectColor;

		// Token: 0x0402DB3E RID: 187198
		[Token(Token = "0x402DB3E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _bkgUnselectColor;

		// Token: 0x0402DB3F RID: 187199
		[Token(Token = "0x402DB3F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _bkgSelectColor;

		// Token: 0x0402DB40 RID: 187200
		[Token(Token = "0x402DB40")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DB41 RID: 187201
		[Token(Token = "0x402DB41")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedBagId;

		// Token: 0x0402DB42 RID: 187202
		[Token(Token = "0x402DB42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DB43 RID: 187203
		[Token(Token = "0x402DB43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBagIconClicked;

		// Token: 0x0402DB44 RID: 187204
		[Token(Token = "0x402DB44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
