using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F60 RID: 28512
	[Token(Token = "0x2006F60")]
	public class ActMultiV3ActivityMissionAdapter : LoopScrollAdapter<ActMultiV3ActivityMissionAdapter.ViewHolder, ActMultiV3MissionViewModel>
	{
		// Token: 0x060287C9 RID: 165833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60287C9")]
		[Address(RVA = "0x23BE390", Offset = "0x23BCF90", VA = "0x1823BE390", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060287CA RID: 165834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287CA")]
		[Address(RVA = "0x23BE440", Offset = "0x23BD040", VA = "0x1823BE440", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ActMultiV3ActivityMissionAdapter.ViewHolder holder, ActMultiV3MissionViewModel data)
		{
		}

		// Token: 0x060287CB RID: 165835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287CB")]
		[Address(RVA = "0x23BE5A0", Offset = "0x23BD1A0", VA = "0x1823BE5A0")]
		public ActMultiV3ActivityMissionAdapter()
		{
		}

		// Token: 0x040399B2 RID: 235954
		[Token(Token = "0x40399B2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _missionObjPrefab;

		// Token: 0x040399B3 RID: 235955
		[Token(Token = "0x40399B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040399B4 RID: 235956
		[Token(Token = "0x40399B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040399B5 RID: 235957
		[Token(Token = "0x40399B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F61 RID: 28513
		[Token(Token = "0x2006F61")]
		public class ViewHolder
		{
			// Token: 0x060287CC RID: 165836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287CC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040399B6 RID: 235958
			[Token(Token = "0x40399B6")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3ActivityMissionItemView view;
		}
	}
}
