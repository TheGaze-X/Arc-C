using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200444D RID: 17485
	[Token(Token = "0x200444D")]
	public class SandboxV2ToolSelectListAdapter : LoopScrollAdapter<SandboxV2ToolSelectListViewHolder, SandboxV2SquadToolModel>, IHotfixable
	{
		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x0601AB81 RID: 109441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB82 RID: 109442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F6D")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x601AB81")]
			[Address(RVA = "0x13E7800", Offset = "0x13E6400", VA = "0x1813E7800")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB82")]
			[Address(RVA = "0x13E78C0", Offset = "0x13E64C0", VA = "0x1813E78C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x0601AB83 RID: 109443 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB84 RID: 109444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F6E")]
		public SandboxV2ToolSelectModel toolSelectModel
		{
			[Token(Token = "0x601AB83")]
			[Address(RVA = "0x13E7860", Offset = "0x13E6460", VA = "0x1813E7860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AB84")]
			[Address(RVA = "0x13E7940", Offset = "0x13E6540", VA = "0x1813E7940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AB85 RID: 109445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB85")]
		[Address(RVA = "0x13E72F0", Offset = "0x13E5EF0", VA = "0x1813E72F0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601AB86 RID: 109446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB86")]
		[Address(RVA = "0x13E73B0", Offset = "0x13E5FB0", VA = "0x1813E73B0", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, SandboxV2ToolSelectListViewHolder holder, SandboxV2SquadToolModel data)
		{
		}

		// Token: 0x0601AB87 RID: 109447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB87")]
		[Address(RVA = "0x13E7790", Offset = "0x13E6390", VA = "0x1813E7790")]
		public SandboxV2ToolSelectListAdapter()
		{
		}

		// Token: 0x040221F4 RID: 139764
		[Token(Token = "0x40221F4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2ToolSelectItemView _itemPrefab;

		// Token: 0x040221F7 RID: 139767
		[Token(Token = "0x40221F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x040221F8 RID: 139768
		[Token(Token = "0x40221F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x040221F9 RID: 139769
		[Token(Token = "0x40221F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_toolSelectModel;

		// Token: 0x040221FA RID: 139770
		[Token(Token = "0x40221FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_toolSelectModel;

		// Token: 0x040221FB RID: 139771
		[Token(Token = "0x40221FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040221FC RID: 139772
		[Token(Token = "0x40221FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040221FD RID: 139773
		[Token(Token = "0x40221FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
