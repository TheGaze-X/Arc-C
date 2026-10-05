using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075D7 RID: 30167
	[Token(Token = "0x20075D7")]
	public class Act24sideMissionLoopAdapter : LoopScrollAdapter<Act24sideMissionLoopAdapter.ViewHolder, Act24sideMissionObjViewModel>
	{
		// Token: 0x170063E4 RID: 25572
		// (get) Token: 0x0602A79D RID: 173981 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A79E RID: 173982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063E4")]
		public Action<string> onClickCompleteBtn
		{
			[Token(Token = "0x602A79D")]
			[Address(RVA = "0x2626D10", Offset = "0x2625910", VA = "0x182626D10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A79E")]
			[Address(RVA = "0x2626DD0", Offset = "0x26259D0", VA = "0x182626DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170063E5 RID: 25573
		// (get) Token: 0x0602A79F RID: 173983 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A7A0 RID: 173984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063E5")]
		public Action<string> onClickDetailBtn
		{
			[Token(Token = "0x602A79F")]
			[Address(RVA = "0x2626D70", Offset = "0x2625970", VA = "0x182626D70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A7A0")]
			[Address(RVA = "0x2626E50", Offset = "0x2625A50", VA = "0x182626E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A7A1 RID: 173985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7A1")]
		[Address(RVA = "0x2626A80", Offset = "0x2625680", VA = "0x182626A80", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act24sideMissionLoopAdapter.ViewHolder holder, Act24sideMissionObjViewModel data)
		{
		}

		// Token: 0x0602A7A2 RID: 173986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7A2")]
		[Address(RVA = "0x26269D0", Offset = "0x26255D0", VA = "0x1826269D0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602A7A3 RID: 173987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7A3")]
		[Address(RVA = "0x2626CA0", Offset = "0x26258A0", VA = "0x182626CA0")]
		public Act24sideMissionLoopAdapter()
		{
		}

		// Token: 0x0403D228 RID: 250408
		[Token(Token = "0x403D228")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _missionObjPrefab;

		// Token: 0x0403D22B RID: 250411
		[Token(Token = "0x403D22B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickCompleteBtn;

		// Token: 0x0403D22C RID: 250412
		[Token(Token = "0x403D22C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickCompleteBtn;

		// Token: 0x0403D22D RID: 250413
		[Token(Token = "0x403D22D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClickDetailBtn;

		// Token: 0x0403D22E RID: 250414
		[Token(Token = "0x403D22E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClickDetailBtn;

		// Token: 0x0403D22F RID: 250415
		[Token(Token = "0x403D22F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403D230 RID: 250416
		[Token(Token = "0x403D230")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0403D231 RID: 250417
		[Token(Token = "0x403D231")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075D8 RID: 30168
		[Token(Token = "0x20075D8")]
		public class ViewHolder
		{
			// Token: 0x0602A7A4 RID: 173988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7A4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403D232 RID: 250418
			[Token(Token = "0x403D232")]
			[FieldOffset(Offset = "0x10")]
			public Act24sideMissionObjView view;
		}
	}
}
