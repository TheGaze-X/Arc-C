using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F91 RID: 24465
	[Token(Token = "0x2005F91")]
	public class CharacterInfoHolderLayoutGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023651 RID: 144977 RVA: 0x000C0B40 File Offset: 0x000BED40
		[Token(Token = "0x6023651")]
		[Address(RVA = "0x1DFF030", Offset = "0x1DFDC30", VA = "0x181DFF030")]
		public float ReturnTotalHeight()
		{
			return 0f;
		}

		// Token: 0x06023652 RID: 144978 RVA: 0x000C0B58 File Offset: 0x000BED58
		[Token(Token = "0x6023652")]
		[Address(RVA = "0x1DFF090", Offset = "0x1DFDC90", VA = "0x181DFF090")]
		private float _CalcHeight(int startIndex, int endIndex)
		{
			return 0f;
		}

		// Token: 0x06023653 RID: 144979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023653")]
		[Address(RVA = "0x1DFEF30", Offset = "0x1DFDB30", VA = "0x181DFEF30")]
		public void RefreshViewHeight(CharacterInfoHolderLayoutGroup.ViewObj view, float startHeight, float targetHeight, float duration = 0.3f)
		{
		}

		// Token: 0x06023654 RID: 144980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023654")]
		[Address(RVA = "0x1DFEFD0", Offset = "0x1DFDBD0", VA = "0x181DFEFD0")]
		public void RegisterViews(List<CharacterInfoHolderLayoutGroup.ViewObj> viewLists)
		{
		}

		// Token: 0x06023655 RID: 144981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023655")]
		[Address(RVA = "0x1DFEED0", Offset = "0x1DFDAD0", VA = "0x181DFEED0")]
		public void NotifyRebuild()
		{
		}

		// Token: 0x06023656 RID: 144982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023656")]
		[Address(RVA = "0x1DFF120", Offset = "0x1DFDD20", VA = "0x181DFF120")]
		public CharacterInfoHolderLayoutGroup()
		{
		}

		// Token: 0x04030E67 RID: 200295
		[Token(Token = "0x4030E67")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _spacing;

		// Token: 0x04030E68 RID: 200296
		[Token(Token = "0x4030E68")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _topHeight;

		// Token: 0x04030E69 RID: 200297
		[Token(Token = "0x4030E69")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<CharacterInfoHolderLayoutGroup.ViewObj> viewPool;

		// Token: 0x04030E6A RID: 200298
		[Token(Token = "0x4030E6A")]
		[FieldOffset(Offset = "0x28")]
		private bool m_lockFlag;

		// Token: 0x04030E6B RID: 200299
		[Token(Token = "0x4030E6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnTotalHeight;

		// Token: 0x04030E6C RID: 200300
		[Token(Token = "0x4030E6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CalcHeight;

		// Token: 0x04030E6D RID: 200301
		[Token(Token = "0x4030E6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshViewHeight;

		// Token: 0x04030E6E RID: 200302
		[Token(Token = "0x4030E6E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterViews;

		// Token: 0x04030E6F RID: 200303
		[Token(Token = "0x4030E6F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyRebuild;

		// Token: 0x04030E70 RID: 200304
		[Token(Token = "0x4030E70")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F92 RID: 24466
		[Token(Token = "0x2005F92")]
		public abstract class ViewObj : MonoBehaviour
		{
			// Token: 0x06023657 RID: 144983
			[Token(Token = "0x6023657")]
			public abstract float GetHeight();

			// Token: 0x06023658 RID: 144984
			[Token(Token = "0x6023658")]
			public abstract bool IsActive();

			// Token: 0x06023659 RID: 144985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023659")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			protected ViewObj()
			{
			}

			// Token: 0x04030E71 RID: 200305
			[Token(Token = "0x4030E71")]
			[FieldOffset(Offset = "0x18")]
			public int index;
		}
	}
}
