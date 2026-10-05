using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047C4 RID: 18372
	[Token(Token = "0x20047C4")]
	public class RecalRuneStageRuneSelectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BCFA RID: 113914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCFA")]
		[Address(RVA = "0x1533800", Offset = "0x1532400", VA = "0x181533800")]
		public void Render(RecalRuneStageRuneViewModel model, bool fastMode)
		{
		}

		// Token: 0x0601BCFB RID: 113915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCFB")]
		[Address(RVA = "0x15340C0", Offset = "0x1532CC0", VA = "0x1815340C0")]
		private void _Init(RecalRuneStageRuneViewModel model, RecalRuneStageRuneItemViewModel focusedItem, bool fastMode)
		{
		}

		// Token: 0x0601BCFC RID: 113916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCFC")]
		[Address(RVA = "0x1534630", Offset = "0x1533230", VA = "0x181534630")]
		private void _Update(IRecalRuneRuneGroup iGroup, RecalRuneStageRuneItemViewModel focusedItem, bool fastMode)
		{
		}

		// Token: 0x0601BCFD RID: 113917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCFD")]
		[Address(RVA = "0x1533B30", Offset = "0x1532730", VA = "0x181533B30")]
		private void _Focus(RecalRuneStageRuneItemViewModel focusedItem)
		{
		}

		// Token: 0x0601BCFE RID: 113918 RVA: 0x000A6578 File Offset: 0x000A4778
		[Token(Token = "0x601BCFE")]
		[Address(RVA = "0x1534050", Offset = "0x1532C50", VA = "0x181534050")]
		private float _GetScrollPos()
		{
			return 0f;
		}

		// Token: 0x0601BCFF RID: 113919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCFF")]
		[Address(RVA = "0x15345B0", Offset = "0x15331B0", VA = "0x1815345B0")]
		private void _SetScrollPos(float pos)
		{
		}

		// Token: 0x0601BD00 RID: 113920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD00")]
		[Address(RVA = "0x1534720", Offset = "0x1533320", VA = "0x181534720")]
		public RecalRuneStageRuneSelectView()
		{
		}

		// Token: 0x040242E7 RID: 148199
		[Token(Token = "0x40242E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x040242E8 RID: 148200
		[Token(Token = "0x40242E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _visionRect;

		// Token: 0x040242E9 RID: 148201
		[Token(Token = "0x40242E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x040242EA RID: 148202
		[Token(Token = "0x40242EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _essentialGroupHolder;

		// Token: 0x040242EB RID: 148203
		[Token(Token = "0x40242EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _rewardingGroupHolder;

		// Token: 0x040242EC RID: 148204
		[Token(Token = "0x40242EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RecalRuneStageRuneSelectGroupView _groupPrefab;

		// Token: 0x040242ED RID: 148205
		[Token(Token = "0x40242ED")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<IRecalRuneRuneGroup, RecalRuneStageRuneSelectGroupView> m_groupInstances;

		// Token: 0x040242EE RID: 148206
		[Token(Token = "0x40242EE")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_focusTween;

		// Token: 0x040242EF RID: 148207
		[Token(Token = "0x40242EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040242F0 RID: 148208
		[Token(Token = "0x40242F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x040242F1 RID: 148209
		[Token(Token = "0x40242F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Update;

		// Token: 0x040242F2 RID: 148210
		[Token(Token = "0x40242F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Focus;

		// Token: 0x040242F3 RID: 148211
		[Token(Token = "0x40242F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetScrollPos;

		// Token: 0x040242F4 RID: 148212
		[Token(Token = "0x40242F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetScrollPos;

		// Token: 0x040242F5 RID: 148213
		[Token(Token = "0x40242F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
