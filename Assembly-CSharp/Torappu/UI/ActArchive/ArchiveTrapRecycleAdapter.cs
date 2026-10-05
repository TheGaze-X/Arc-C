using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C5B RID: 27739
	[Token(Token = "0x2006C5B")]
	public class ArchiveTrapRecycleAdapter : RecycleLoopScrollAdapter<ArchiveTrapRecycleAdapter.ViewHolder, TrapItemModel>
	{
		// Token: 0x17005D8E RID: 23950
		// (get) Token: 0x06027981 RID: 162177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027982 RID: 162178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D8E")]
		public ArchiveTrapController controller
		{
			[Token(Token = "0x6027981")]
			[Address(RVA = "0x22C7550", Offset = "0x22C6150", VA = "0x1822C7550")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027982")]
			[Address(RVA = "0x22C7610", Offset = "0x22C6210", VA = "0x1822C7610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005D8F RID: 23951
		// (get) Token: 0x06027983 RID: 162179 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027984 RID: 162180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D8F")]
		public string selectItemId
		{
			[Token(Token = "0x6027983")]
			[Address(RVA = "0x22C75B0", Offset = "0x22C61B0", VA = "0x1822C75B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027984")]
			[Address(RVA = "0x22C7690", Offset = "0x22C6290", VA = "0x1822C7690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027985 RID: 162181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027985")]
		[Address(RVA = "0x22C71E0", Offset = "0x22C5DE0", VA = "0x1822C71E0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ArchiveTrapRecycleAdapter.ViewHolder holder, TrapItemModel data)
		{
		}

		// Token: 0x06027986 RID: 162182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027986")]
		[Address(RVA = "0x22C7350", Offset = "0x22C5F50", VA = "0x1822C7350", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06027987 RID: 162183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027987")]
		[Address(RVA = "0x22C74E0", Offset = "0x22C60E0", VA = "0x1822C74E0")]
		public ArchiveTrapRecycleAdapter()
		{
		}

		// Token: 0x04038270 RID: 230000
		[Token(Token = "0x4038270")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ArchiveTrapListItemView _itemPrefab;

		// Token: 0x04038273 RID: 230003
		[Token(Token = "0x4038273")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04038274 RID: 230004
		[Token(Token = "0x4038274")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04038275 RID: 230005
		[Token(Token = "0x4038275")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectItemId;

		// Token: 0x04038276 RID: 230006
		[Token(Token = "0x4038276")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectItemId;

		// Token: 0x04038277 RID: 230007
		[Token(Token = "0x4038277")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04038278 RID: 230008
		[Token(Token = "0x4038278")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04038279 RID: 230009
		[Token(Token = "0x4038279")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C5C RID: 27740
		[Token(Token = "0x2006C5C")]
		public class ViewHolder
		{
			// Token: 0x06027988 RID: 162184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027988")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403827A RID: 230010
			[Token(Token = "0x403827A")]
			[FieldOffset(Offset = "0x10")]
			public ArchiveTrapListItemView trapItem;
		}
	}
}
