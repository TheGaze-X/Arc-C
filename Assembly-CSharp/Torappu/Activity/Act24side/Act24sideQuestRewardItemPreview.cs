using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007600 RID: 30208
	[Token(Token = "0x2007600")]
	public class Act24sideQuestRewardItemPreview : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A879 RID: 174201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A879")]
		[Address(RVA = "0x262FD50", Offset = "0x262E950", VA = "0x18262FD50", Slot = "4")]
		protected virtual void _InitIfNot()
		{
		}

		// Token: 0x0602A87A RID: 174202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A87A")]
		[Address(RVA = "0x262FC10", Offset = "0x262E810", VA = "0x18262FC10")]
		public void Render(StageRewardViewModel viewModel, bool isStageComplete)
		{
		}

		// Token: 0x0602A87B RID: 174203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A87B")]
		[Address(RVA = "0x262FEE0", Offset = "0x262EAE0", VA = "0x18262FEE0")]
		public Act24sideQuestRewardItemPreview()
		{
		}

		// Token: 0x0403D38C RID: 250764
		[Token(Token = "0x403D38C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _itemCardContainer;

		// Token: 0x0403D38D RID: 250765
		[Token(Token = "0x403D38D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float _cardScaleFactor;

		// Token: 0x0403D38E RID: 250766
		[Token(Token = "0x403D38E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameObject _completeTagGo;

		// Token: 0x0403D38F RID: 250767
		[Token(Token = "0x403D38F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected GameObject _alreadyHaveTagGo;

		// Token: 0x0403D390 RID: 250768
		[Token(Token = "0x403D390")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _itemAlphaHanlder;

		// Token: 0x0403D391 RID: 250769
		[Token(Token = "0x403D391")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _alreadyHaveAlpha;

		// Token: 0x0403D392 RID: 250770
		[Token(Token = "0x403D392")]
		[FieldOffset(Offset = "0x48")]
		protected UIItemCard m_itemCard;

		// Token: 0x0403D393 RID: 250771
		[Token(Token = "0x403D393")]
		[FieldOffset(Offset = "0x50")]
		protected UIItemViewModel m_viewModel;

		// Token: 0x0403D394 RID: 250772
		[Token(Token = "0x403D394")]
		[FieldOffset(Offset = "0x58")]
		protected bool m_isInited;

		// Token: 0x0403D395 RID: 250773
		[Token(Token = "0x403D395")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D396 RID: 250774
		[Token(Token = "0x403D396")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D397 RID: 250775
		[Token(Token = "0x403D397")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
