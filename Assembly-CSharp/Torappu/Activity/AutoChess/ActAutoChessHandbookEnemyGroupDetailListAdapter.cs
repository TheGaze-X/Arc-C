using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007121 RID: 28961
	[Token(Token = "0x2007121")]
	public class ActAutoChessHandbookEnemyGroupDetailListAdapter : LoopScrollAdapter<ActAutoChessHandbookEnemyGroupDetailListAdapter.ViewHolder, EnemyHandBookEverViewModel>, IHotfixable
	{
		// Token: 0x0602922C RID: 168492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602922C")]
		[Address(RVA = "0x2484730", Offset = "0x2483330", VA = "0x182484730", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602922D RID: 168493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602922D")]
		[Address(RVA = "0x24847E0", Offset = "0x24833E0", VA = "0x1824847E0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ActAutoChessHandbookEnemyGroupDetailListAdapter.ViewHolder holder, EnemyHandBookEverViewModel data)
		{
		}

		// Token: 0x0602922E RID: 168494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602922E")]
		[Address(RVA = "0x2484900", Offset = "0x2483500", VA = "0x182484900")]
		public ActAutoChessHandbookEnemyGroupDetailListAdapter()
		{
		}

		// Token: 0x0403ABE4 RID: 240612
		[Token(Token = "0x403ABE4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x0403ABE5 RID: 240613
		[Token(Token = "0x403ABE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0403ABE6 RID: 240614
		[Token(Token = "0x403ABE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403ABE7 RID: 240615
		[Token(Token = "0x403ABE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007122 RID: 28962
		[Token(Token = "0x2007122")]
		public class ViewHolder
		{
			// Token: 0x0602922F RID: 168495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602922F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403ABE8 RID: 240616
			[Token(Token = "0x403ABE8")]
			[FieldOffset(Offset = "0x10")]
			public ActAutoChessHandbookEnemyDetailItemView itemView;
		}
	}
}
