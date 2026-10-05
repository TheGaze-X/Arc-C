using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004976 RID: 18806
	[Token(Token = "0x2004976")]
	public class MedalGroupTemplateListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C57A RID: 116090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C57A")]
		[Address(RVA = "0x15CE710", Offset = "0x15CD310", VA = "0x1815CE710")]
		public void ToGroup(string groupId)
		{
		}

		// Token: 0x0601C57B RID: 116091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C57B")]
		[Address(RVA = "0x15CE850", Offset = "0x15CD450", VA = "0x1815CE850")]
		private void _ToGroupPos(int index)
		{
		}

		// Token: 0x0601C57C RID: 116092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C57C")]
		[Address(RVA = "0x15CE650", Offset = "0x15CD250", VA = "0x1815CE650")]
		public void Render(MedalListViewModel listViewModel)
		{
		}

		// Token: 0x0601C57D RID: 116093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C57D")]
		[Address(RVA = "0x15CEA90", Offset = "0x15CD690", VA = "0x1815CEA90")]
		public MedalGroupTemplateListView()
		{
		}

		// Token: 0x04025170 RID: 151920
		[Token(Token = "0x4025170")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MedalGroupListLoopAdapter _recycleList;

		// Token: 0x04025171 RID: 151921
		[Token(Token = "0x4025171")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x04025172 RID: 151922
		[Token(Token = "0x4025172")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_cacheTween;

		// Token: 0x04025173 RID: 151923
		[Token(Token = "0x4025173")]
		[FieldOffset(Offset = "0x30")]
		private List<MedalGroupViewModel> m_cacheGroupList;

		// Token: 0x04025174 RID: 151924
		[Token(Token = "0x4025174")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ToGroup;

		// Token: 0x04025175 RID: 151925
		[Token(Token = "0x4025175")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ToGroupPos;

		// Token: 0x04025176 RID: 151926
		[Token(Token = "0x4025176")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025177 RID: 151927
		[Token(Token = "0x4025177")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
