using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord
{
	// Token: 0x02006A00 RID: 27136
	[Token(Token = "0x2006A00")]
	public abstract class RecordAllRewardsTemplateAdapter<ViewHolder> : RecycleLoopScrollAdapter<ViewHolder, ZoneRecordViewModel> where ViewHolder : RecordAllRewardTemplateViewHolder, new()
	{
		// Token: 0x06026CCB RID: 158923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026CCB")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06026CCC RID: 158924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CCC")]
		public override void UpdateView(int position, GameObject viewObj, ViewHolder holder, ZoneRecordViewModel data)
		{
		}

		// Token: 0x06026CCD RID: 158925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CCD")]
		protected RecordAllRewardsTemplateAdapter()
		{
		}

		// Token: 0x04036CF8 RID: 224504
		[Token(Token = "0x4036CF8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject _prefabItem;

		// Token: 0x04036CF9 RID: 224505
		[Token(Token = "0x4036CF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04036CFA RID: 224506
		[Token(Token = "0x4036CFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04036CFB RID: 224507
		[Token(Token = "0x4036CFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
