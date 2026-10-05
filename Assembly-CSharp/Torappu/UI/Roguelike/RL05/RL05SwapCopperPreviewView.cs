using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055BA RID: 21946
	[Token(Token = "0x20055BA")]
	public class RL05SwapCopperPreviewView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602037E RID: 131966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602037E")]
		[Address(RVA = "0x1A5CA90", Offset = "0x1A5B690", VA = "0x181A5CA90")]
		public void Render(RoguelikeSwapCopperViewModel model)
		{
		}

		// Token: 0x0602037F RID: 131967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602037F")]
		[Address(RVA = "0x1A5CBF0", Offset = "0x1A5B7F0", VA = "0x181A5CBF0")]
		private void _InitIfNot(string topicId)
		{
		}

		// Token: 0x06020380 RID: 131968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020380")]
		[Address(RVA = "0x1A5CDC0", Offset = "0x1A5B9C0", VA = "0x181A5CDC0")]
		public RL05SwapCopperPreviewView()
		{
		}

		// Token: 0x0402B94D RID: 178509
		[Token(Token = "0x402B94D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyOldItem;

		// Token: 0x0402B94E RID: 178510
		[Token(Token = "0x402B94E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _oldItemContainer;

		// Token: 0x0402B94F RID: 178511
		[Token(Token = "0x402B94F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _willBeSwapTagObj;

		// Token: 0x0402B950 RID: 178512
		[Token(Token = "0x402B950")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _newItemContainer;

		// Token: 0x0402B951 RID: 178513
		[Token(Token = "0x402B951")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x0402B952 RID: 178514
		[Token(Token = "0x402B952")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL05SwapCopperPreviewItemView _oldItemPreviewView;

		// Token: 0x0402B953 RID: 178515
		[Token(Token = "0x402B953")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RL05SwapCopperPreviewItemView _newItemPreviewView;

		// Token: 0x0402B954 RID: 178516
		[Token(Token = "0x402B954")]
		[FieldOffset(Offset = "0x50")]
		private RL05CommonCopperItemWithFrameView m_oldItemView;

		// Token: 0x0402B955 RID: 178517
		[Token(Token = "0x402B955")]
		[FieldOffset(Offset = "0x58")]
		private RL05CommonCopperItemWithFrameView m_newItemView;

		// Token: 0x0402B956 RID: 178518
		[Token(Token = "0x402B956")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0402B957 RID: 178519
		[Token(Token = "0x402B957")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402B958 RID: 178520
		[Token(Token = "0x402B958")]
		[FieldOffset(Offset = "0x78")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0402B959 RID: 178521
		[Token(Token = "0x402B959")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B95A RID: 178522
		[Token(Token = "0x402B95A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B95B RID: 178523
		[Token(Token = "0x402B95B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
