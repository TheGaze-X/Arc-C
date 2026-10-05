using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006206 RID: 25094
	[Token(Token = "0x2006206")]
	public class BattleFinishHandBookStageView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700556A RID: 21866
		// (get) Token: 0x06024355 RID: 148309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024354 RID: 148308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700556A")]
		public Action onClick
		{
			[Token(Token = "0x6024355")]
			[Address(RVA = "0x1F14DC0", Offset = "0x1F139C0", VA = "0x181F14DC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024354")]
			[Address(RVA = "0x1F14E20", Offset = "0x1F13A20", VA = "0x181F14E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024356 RID: 148310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024356")]
		[Address(RVA = "0x1F14C90", Offset = "0x1F13890", VA = "0x181F14C90")]
		public IEnumerator RenderViewAysnc(BattleFinishHandBookStageViewModel battleFinishModel)
		{
			return null;
		}

		// Token: 0x06024357 RID: 148311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024357")]
		[Address(RVA = "0x1F14BF0", Offset = "0x1F137F0", VA = "0x181F14BF0")]
		public void EventOnPageClicked()
		{
		}

		// Token: 0x06024358 RID: 148312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024358")]
		[Address(RVA = "0x1F14D60", Offset = "0x1F13960", VA = "0x181F14D60")]
		public BattleFinishHandBookStageView()
		{
		}

		// Token: 0x04032582 RID: 206210
		[Token(Token = "0x4032582")]
		private const float ITEM_DISPLAY_DELAY = 1f;

		// Token: 0x04032583 RID: 206211
		[Token(Token = "0x4032583")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04032584 RID: 206212
		[Token(Token = "0x4032584")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BattleFinishRankGroup _rankGroup;

		// Token: 0x04032585 RID: 206213
		[Token(Token = "0x4032585")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BattleFinishIllustView _illustView;

		// Token: 0x04032586 RID: 206214
		[Token(Token = "0x4032586")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _dropItemsContent;

		// Token: 0x04032587 RID: 206215
		[Token(Token = "0x4032587")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _dropListGo;

		// Token: 0x04032588 RID: 206216
		[Token(Token = "0x4032588")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isAnim;

		// Token: 0x0403258A RID: 206218
		[Token(Token = "0x403258A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0403258B RID: 206219
		[Token(Token = "0x403258B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0403258C RID: 206220
		[Token(Token = "0x403258C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderViewAysnc;

		// Token: 0x0403258D RID: 206221
		[Token(Token = "0x403258D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnPageClicked;

		// Token: 0x0403258E RID: 206222
		[Token(Token = "0x403258E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006207 RID: 25095
		[Token(Token = "0x2006207")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06024359 RID: 148313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024359")]
			[Address(RVA = "0x1F04B70", Offset = "0x1F03770", VA = "0x181F04B70")]
			public Adapter(HandBookDropInfoViewModel dropInfoModel)
			{
			}

			// Token: 0x1700556B RID: 21867
			// (get) Token: 0x0602435A RID: 148314 RVA: 0x000C3708 File Offset: 0x000C1908
			[Token(Token = "0x1700556B")]
			public override int count
			{
				[Token(Token = "0x602435A")]
				[Address(RVA = "0x1F04BF0", Offset = "0x1F037F0", VA = "0x181F04BF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602435B RID: 148315 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602435B")]
			[Address(RVA = "0x1F04990", Offset = "0x1F03590", VA = "0x181F04990", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403258F RID: 206223
			[Token(Token = "0x403258F")]
			[FieldOffset(Offset = "0x20")]
			private HandBookDropInfoViewModel m_dropInfoModel;

			// Token: 0x04032590 RID: 206224
			[Token(Token = "0x4032590")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032591 RID: 206225
			[Token(Token = "0x4032591")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032592 RID: 206226
			[Token(Token = "0x4032592")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
