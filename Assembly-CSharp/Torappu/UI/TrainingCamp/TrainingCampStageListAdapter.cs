using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D1A RID: 15642
	[Token(Token = "0x2003D1A")]
	public class TrainingCampStageListAdapter : LoopScrollAdapter<TrainingCampStageListAdapter.ViewHolder, TrainingCampStageListItemViewModel>
	{
		// Token: 0x06018628 RID: 99880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018628")]
		[Address(RVA = "0x10D2190", Offset = "0x10D0D90", VA = "0x1810D2190", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06018629 RID: 99881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018629")]
		[Address(RVA = "0x10D2250", Offset = "0x10D0E50", VA = "0x1810D2250", Slot = "13")]
		public override void UpdateView(int position, GameObject view, TrainingCampStageListAdapter.ViewHolder holder, TrainingCampStageListItemViewModel data)
		{
		}

		// Token: 0x0601862A RID: 99882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601862A")]
		[Address(RVA = "0x10D23B0", Offset = "0x10D0FB0", VA = "0x1810D23B0")]
		public TrainingCampStageListAdapter()
		{
		}

		// Token: 0x0401DD11 RID: 122129
		[Token(Token = "0x401DD11")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TrainingCampStageListItemView _viewPrefab;

		// Token: 0x0401DD12 RID: 122130
		[Token(Token = "0x401DD12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401DD13 RID: 122131
		[Token(Token = "0x401DD13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401DD14 RID: 122132
		[Token(Token = "0x401DD14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D1B RID: 15643
		[Token(Token = "0x2003D1B")]
		public class ViewHolder
		{
			// Token: 0x0601862B RID: 99883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601862B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0401DD15 RID: 122133
			[Token(Token = "0x401DD15")]
			[FieldOffset(Offset = "0x10")]
			public TrainingCampStageListItemView view;
		}
	}
}
