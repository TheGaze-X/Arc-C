using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.ToDoNotify
{
	// Token: 0x02001C53 RID: 7251
	[Token(Token = "0x2001C53")]
	public abstract class BuildingToDoNotifyItemBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x0600B46F RID: 46191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AE")]
		protected BuildingToDoNotifyItemModel viewModel
		{
			[Token(Token = "0x600B46F")]
			[Address(RVA = "0x32F3DB0", Offset = "0x32F29B0", VA = "0x1832F3DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B470")]
		[Address(RVA = "0x32F3900", Offset = "0x32F2500", VA = "0x1832F3900", Slot = "4")]
		public virtual void Render(BuildingToDoCategory category, BuildingToDoNotifyItemModel itemModel, bool isSelected, BuildingToDoNotifyView.ItemClickStatusData itemClickStatusData)
		{
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B471")]
		[Address(RVA = "0x32F3CD0", Offset = "0x32F28D0", VA = "0x1832F3CD0")]
		private IEnumerator _tryPlayItemOutAnim(UIAnimationLocation anim)
		{
			return null;
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B472")]
		[Address(RVA = "0x32F3BA0", Offset = "0x32F27A0", VA = "0x1832F3BA0")]
		private void _OnAnimEnd()
		{
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B473")]
		[Address(RVA = "0x32F3880", Offset = "0x32F2480", VA = "0x1832F3880")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0600B474 RID: 46196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B474")]
		[Address(RVA = "0x32F3C70", Offset = "0x32F2870", VA = "0x1832F3C70")]
		protected BuildingToDoNotifyItemBase()
		{
		}

		// Token: 0x0400B01E RID: 45086
		[Token(Token = "0x400B01E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _outAnim;

		// Token: 0x0400B01F RID: 45087
		[Token(Token = "0x400B01F")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_animTween;

		// Token: 0x0400B020 RID: 45088
		[Token(Token = "0x400B020")]
		[FieldOffset(Offset = "0x30")]
		private BuildingToDoNotifyItemModel m_viewModel;

		// Token: 0x0400B021 RID: 45089
		[Token(Token = "0x400B021")]
		[FieldOffset(Offset = "0x38")]
		private BuildingToDoNotifyView.ItemClickStatusData m_itemClickStatusData;

		// Token: 0x0400B022 RID: 45090
		[Token(Token = "0x400B022")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isPlayingAnim;

		// Token: 0x0400B023 RID: 45091
		[Token(Token = "0x400B023")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<BuildingToDoNotifyItemModel> onClicked;

		// Token: 0x0400B024 RID: 45092
		[Token(Token = "0x400B024")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action onAnimEnd;

		// Token: 0x0400B025 RID: 45093
		[Token(Token = "0x400B025")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x0400B026 RID: 45094
		[Token(Token = "0x400B026")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B027 RID: 45095
		[Token(Token = "0x400B027")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__tryPlayItemOutAnim;

		// Token: 0x0400B028 RID: 45096
		[Token(Token = "0x400B028")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnAnimEnd;

		// Token: 0x0400B029 RID: 45097
		[Token(Token = "0x400B029")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0400B02A RID: 45098
		[Token(Token = "0x400B02A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
