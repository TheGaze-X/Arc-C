using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BE3 RID: 15331
	[Token(Token = "0x2003BE3")]
	public class UniEquipArchiveCharacterCardAdapter : LoopScrollAdapter<UniEquipArchiveCharacterCardAdapter.ViewHolder, UniEquipArchiveCharacterItemViewModel>
	{
		// Token: 0x06017FE2 RID: 98274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017FE2")]
		[Address(RVA = "0x105FD30", Offset = "0x105E930", VA = "0x18105FD30", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06017FE3 RID: 98275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FE3")]
		[Address(RVA = "0x105FE60", Offset = "0x105EA60", VA = "0x18105FE60", Slot = "13")]
		public override void UpdateView(int position, GameObject view, UniEquipArchiveCharacterCardAdapter.ViewHolder holder, UniEquipArchiveCharacterItemViewModel data)
		{
		}

		// Token: 0x06017FE4 RID: 98276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FE4")]
		[Address(RVA = "0x1060030", Offset = "0x105EC30", VA = "0x181060030")]
		public UniEquipArchiveCharacterCardAdapter()
		{
		}

		// Token: 0x0401D0CF RID: 118991
		[Token(Token = "0x401D0CF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UniEquipArchiveCharacterItemView _viewPrefab;

		// Token: 0x0401D0D0 RID: 118992
		[Token(Token = "0x401D0D0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x0401D0D1 RID: 118993
		[Token(Token = "0x401D0D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0401D0D2 RID: 118994
		[Token(Token = "0x401D0D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401D0D3 RID: 118995
		[Token(Token = "0x401D0D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BE4 RID: 15332
		[Token(Token = "0x2003BE4")]
		public class ViewHolder
		{
			// Token: 0x06017FE5 RID: 98277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017FE5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0401D0D4 RID: 118996
			[Token(Token = "0x401D0D4")]
			[FieldOffset(Offset = "0x10")]
			public UniEquipArchiveCharacterItemView view;
		}
	}
}
