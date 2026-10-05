using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004353 RID: 17235
	[Token(Token = "0x2004353")]
	public class SandboxV2RacerInventoryListAdapter : LoopScrollAdapter<SandboxV2RacerInventoryListAdapter.ViewHolder, KeyValuePair<string, SandboxV2RacerModel>>
	{
		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x0601A758 RID: 108376 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A759 RID: 108377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003ED0")]
		public string selectedInstId
		{
			[Token(Token = "0x601A758")]
			[Address(RVA = "0x138FB50", Offset = "0x138E750", VA = "0x18138FB50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A759")]
			[Address(RVA = "0x138FBB0", Offset = "0x138E7B0", VA = "0x18138FBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A75A RID: 108378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A75A")]
		[Address(RVA = "0x138F6E0", Offset = "0x138E2E0", VA = "0x18138F6E0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601A75B RID: 108379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A75B")]
		[Address(RVA = "0x138F790", Offset = "0x138E390", VA = "0x18138F790", Slot = "9")]
		protected override void OnNewItemAlloc(GameObject newItem)
		{
		}

		// Token: 0x0601A75C RID: 108380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A75C")]
		[Address(RVA = "0x138F8F0", Offset = "0x138E4F0", VA = "0x18138F8F0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SandboxV2RacerInventoryListAdapter.ViewHolder holder, KeyValuePair<string, SandboxV2RacerModel> pair)
		{
		}

		// Token: 0x0601A75D RID: 108381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A75D")]
		[Address(RVA = "0x138FAE0", Offset = "0x138E6E0", VA = "0x18138FAE0")]
		public SandboxV2RacerInventoryListAdapter()
		{
		}

		// Token: 0x0601A75E RID: 108382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A75E")]
		[Address(RVA = "0x138F8E0", Offset = "0x138E4E0", VA = "0x18138F8E0")]
		private void <>xLuaBaseProxy_OnNewItemAlloc(GameObject P0)
		{
		}

		// Token: 0x04021A78 RID: 137848
		[Token(Token = "0x4021A78")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x04021A7A RID: 137850
		[Token(Token = "0x4021A7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedInstId;

		// Token: 0x04021A7B RID: 137851
		[Token(Token = "0x4021A7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedInstId;

		// Token: 0x04021A7C RID: 137852
		[Token(Token = "0x4021A7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04021A7D RID: 137853
		[Token(Token = "0x4021A7D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnNewItemAlloc;

		// Token: 0x04021A7E RID: 137854
		[Token(Token = "0x4021A7E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04021A7F RID: 137855
		[Token(Token = "0x4021A7F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004354 RID: 17236
		[Token(Token = "0x2004354")]
		public class ViewHolder
		{
			// Token: 0x0601A75F RID: 108383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A75F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04021A80 RID: 137856
			[Token(Token = "0x4021A80")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2RacerInventoryItemView view;
		}
	}
}
