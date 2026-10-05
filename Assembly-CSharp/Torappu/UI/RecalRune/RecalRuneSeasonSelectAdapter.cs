using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047AB RID: 18347
	[Token(Token = "0x20047AB")]
	public class RecalRuneSeasonSelectAdapter : LoopScrollAdapter<RecalRuneSeasonSelectAdapter.ViewHolder, RecalRuneSeasonItemViewModel>
	{
		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x0601BC82 RID: 113794 RVA: 0x000A6380 File Offset: 0x000A4580
		[Token(Token = "0x1700420D")]
		public float itemShowDuration
		{
			[Token(Token = "0x601BC82")]
			[Address(RVA = "0x152E610", Offset = "0x152D210", VA = "0x18152E610")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x0601BC83 RID: 113795 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BC84 RID: 113796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700420E")]
		public Func<int, float> itemShowSyncer
		{
			[Token(Token = "0x601BC83")]
			[Address(RVA = "0x152E6C0", Offset = "0x152D2C0", VA = "0x18152E6C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BC84")]
			[Address(RVA = "0x152E720", Offset = "0x152D320", VA = "0x18152E720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BC85 RID: 113797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BC85")]
		[Address(RVA = "0x152E330", Offset = "0x152CF30", VA = "0x18152E330", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601BC86 RID: 113798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC86")]
		[Address(RVA = "0x152E3F0", Offset = "0x152CFF0", VA = "0x18152E3F0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RecalRuneSeasonSelectAdapter.ViewHolder holder, RecalRuneSeasonItemViewModel data)
		{
		}

		// Token: 0x0601BC87 RID: 113799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC87")]
		[Address(RVA = "0x152E5A0", Offset = "0x152D1A0", VA = "0x18152E5A0")]
		public RecalRuneSeasonSelectAdapter()
		{
		}

		// Token: 0x04024206 RID: 147974
		[Token(Token = "0x4024206")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RecalRuneSeasonSelectSeasonItemView _itemPrefab;

		// Token: 0x04024208 RID: 147976
		[Token(Token = "0x4024208")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemShowDuration;

		// Token: 0x04024209 RID: 147977
		[Token(Token = "0x4024209")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemShowSyncer;

		// Token: 0x0402420A RID: 147978
		[Token(Token = "0x402420A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_itemShowSyncer;

		// Token: 0x0402420B RID: 147979
		[Token(Token = "0x402420B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0402420C RID: 147980
		[Token(Token = "0x402420C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402420D RID: 147981
		[Token(Token = "0x402420D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047AC RID: 18348
		[Token(Token = "0x20047AC")]
		public class ViewHolder
		{
			// Token: 0x0601BC88 RID: 113800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BC88")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402420E RID: 147982
			[Token(Token = "0x402420E")]
			[FieldOffset(Offset = "0x10")]
			public RecalRuneSeasonSelectSeasonItemView view;
		}
	}
}
