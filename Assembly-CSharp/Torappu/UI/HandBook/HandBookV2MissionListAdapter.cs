using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006714 RID: 26388
	[Token(Token = "0x2006714")]
	public class HandBookV2MissionListAdapter : RecycleLoopScrollAdapter<HandBookV2MissionListItemHolder, HandBookV2MissionListItemModel>
	{
		// Token: 0x06025DDB RID: 155099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DDB")]
		[Address(RVA = "0x20E5A70", Offset = "0x20E4670", VA = "0x1820E5A70", Slot = "13")]
		public override void UpdateView(int position, GameObject view, HandBookV2MissionListItemHolder holder, HandBookV2MissionListItemModel data)
		{
		}

		// Token: 0x06025DDC RID: 155100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025DDC")]
		[Address(RVA = "0x20E5BD0", Offset = "0x20E47D0", VA = "0x1820E5BD0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06025DDD RID: 155101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DDD")]
		[Address(RVA = "0x20E5C80", Offset = "0x20E4880", VA = "0x1820E5C80")]
		public HandBookV2MissionListAdapter()
		{
		}

		// Token: 0x0403541A RID: 218138
		[Token(Token = "0x403541A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x0403541B RID: 218139
		[Token(Token = "0x403541B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent _btnGetClickEvent;

		// Token: 0x0403541C RID: 218140
		[Token(Token = "0x403541C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403541D RID: 218141
		[Token(Token = "0x403541D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403541E RID: 218142
		[Token(Token = "0x403541E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
