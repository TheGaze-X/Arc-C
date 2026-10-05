using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CD1 RID: 27857
	[Token(Token = "0x2006CD1")]
	public class TemplateMissionAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17005DD3 RID: 24019
		// (get) Token: 0x06027BC9 RID: 162761 RVA: 0x000CF318 File Offset: 0x000CD518
		[Token(Token = "0x17005DD3")]
		public override int totalCount
		{
			[Token(Token = "0x6027BC9")]
			[Address(RVA = "0x22E9690", Offset = "0x22E8290", VA = "0x1822E9690", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06027BCA RID: 162762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BCA")]
		[Address(RVA = "0x22E92C0", Offset = "0x22E7EC0", VA = "0x1822E92C0", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x06027BCB RID: 162763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027BCB")]
		[Address(RVA = "0x22E9520", Offset = "0x22E8120", VA = "0x1822E9520", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06027BCC RID: 162764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BCC")]
		[Address(RVA = "0x22E9630", Offset = "0x22E8230", VA = "0x1822E9630")]
		public TemplateMissionAdapter()
		{
		}

		// Token: 0x040385A0 RID: 230816
		[Token(Token = "0x40385A0")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public List<TemplateMissionViewModel> missionItemList;

		// Token: 0x040385A1 RID: 230817
		[Token(Token = "0x40385A1")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public UIStringEvent onMissionGetRewardClick;

		// Token: 0x040385A2 RID: 230818
		[Token(Token = "0x40385A2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemObj;

		// Token: 0x040385A3 RID: 230819
		[Token(Token = "0x40385A3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MonoBehaviour _plugin;

		// Token: 0x040385A4 RID: 230820
		[Token(Token = "0x40385A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x040385A5 RID: 230821
		[Token(Token = "0x40385A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040385A6 RID: 230822
		[Token(Token = "0x40385A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040385A7 RID: 230823
		[Token(Token = "0x40385A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
