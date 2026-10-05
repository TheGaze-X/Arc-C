using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C55 RID: 23637
	[Token(Token = "0x2005C55")]
	public class ClimbTowerEntryMissionGridAdapter : RecycleLoopScrollAdapter<ClimbTowerEntryMissionGridAdapter.ViewHolder, ClimbTowerEntryMissionItemViewModel>, IHotfixable
	{
		// Token: 0x17005065 RID: 20581
		// (get) Token: 0x06022406 RID: 140294 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022407 RID: 140295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005065")]
		public Action<string> onMissionItemClicked
		{
			[Token(Token = "0x6022406")]
			[Address(RVA = "0x1CB9650", Offset = "0x1CB8250", VA = "0x181CB9650")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022407")]
			[Address(RVA = "0x1CB9710", Offset = "0x1CB8310", VA = "0x181CB9710")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005066 RID: 20582
		// (get) Token: 0x06022408 RID: 140296 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022409 RID: 140297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005066")]
		public UIPage page
		{
			[Token(Token = "0x6022408")]
			[Address(RVA = "0x1CB96B0", Offset = "0x1CB82B0", VA = "0x181CB96B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022409")]
			[Address(RVA = "0x1CB9790", Offset = "0x1CB8390", VA = "0x181CB9790")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602240A RID: 140298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602240A")]
		[Address(RVA = "0x1CB92C0", Offset = "0x1CB7EC0", VA = "0x181CB92C0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ClimbTowerEntryMissionGridAdapter.ViewHolder holder, ClimbTowerEntryMissionItemViewModel data)
		{
		}

		// Token: 0x0602240B RID: 140299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602240B")]
		[Address(RVA = "0x1CB9510", Offset = "0x1CB8110", VA = "0x181CB9510", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602240C RID: 140300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602240C")]
		[Address(RVA = "0x1CB95E0", Offset = "0x1CB81E0", VA = "0x181CB95E0")]
		public ClimbTowerEntryMissionGridAdapter()
		{
		}

		// Token: 0x0402F048 RID: 192584
		[Token(Token = "0x402F048")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ClimbTowerEntryMissionItemView _itemPrefab;

		// Token: 0x0402F04B RID: 192587
		[Token(Token = "0x402F04B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onMissionItemClicked;

		// Token: 0x0402F04C RID: 192588
		[Token(Token = "0x402F04C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onMissionItemClicked;

		// Token: 0x0402F04D RID: 192589
		[Token(Token = "0x402F04D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F04E RID: 192590
		[Token(Token = "0x402F04E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F04F RID: 192591
		[Token(Token = "0x402F04F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402F050 RID: 192592
		[Token(Token = "0x402F050")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402F051 RID: 192593
		[Token(Token = "0x402F051")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C56 RID: 23638
		[Token(Token = "0x2005C56")]
		public class ViewHolder
		{
			// Token: 0x0602240D RID: 140301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602240D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402F052 RID: 192594
			[Token(Token = "0x402F052")]
			[FieldOffset(Offset = "0x10")]
			public ClimbTowerEntryMissionItemView itemView;
		}
	}
}
