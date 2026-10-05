using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004422 RID: 17442
	[Token(Token = "0x2004422")]
	public class SandboxV2CharRepoListAdapter : LoopScrollAdapter<SandboxV2CharRepoListViewHolder, SandboxV2CharViewModel>, IHotfixable
	{
		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x0601AA2F RID: 109103 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA30 RID: 109104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F1B")]
		public Action<int> onSlotClick
		{
			[Token(Token = "0x601AA2F")]
			[Address(RVA = "0x13C0600", Offset = "0x13BF200", VA = "0x1813C0600")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA30")]
			[Address(RVA = "0x13C06E0", Offset = "0x13BF2E0", VA = "0x1813C06E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x0601AA31 RID: 109105 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA32 RID: 109106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F1C")]
		public Action<int> onDineClick
		{
			[Token(Token = "0x601AA31")]
			[Address(RVA = "0x13C05A0", Offset = "0x13BF1A0", VA = "0x1813C05A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA32")]
			[Address(RVA = "0x13C0660", Offset = "0x13BF260", VA = "0x1813C0660")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AA33 RID: 109107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AA33")]
		[Address(RVA = "0x13C01D0", Offset = "0x13BEDD0", VA = "0x1813C01D0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601AA34 RID: 109108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA34")]
		[Address(RVA = "0x13C0290", Offset = "0x13BEE90", VA = "0x1813C0290", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, SandboxV2CharRepoListViewHolder holder, SandboxV2CharViewModel data)
		{
		}

		// Token: 0x0601AA35 RID: 109109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA35")]
		[Address(RVA = "0x13C0530", Offset = "0x13BF130", VA = "0x1813C0530")]
		public SandboxV2CharRepoListAdapter()
		{
		}

		// Token: 0x04021FA1 RID: 139169
		[Token(Token = "0x4021FA1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2CharRepoCharItemView _itemPrefab;

		// Token: 0x04021FA4 RID: 139172
		[Token(Token = "0x4021FA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSlotClick;

		// Token: 0x04021FA5 RID: 139173
		[Token(Token = "0x4021FA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSlotClick;

		// Token: 0x04021FA6 RID: 139174
		[Token(Token = "0x4021FA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onDineClick;

		// Token: 0x04021FA7 RID: 139175
		[Token(Token = "0x4021FA7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onDineClick;

		// Token: 0x04021FA8 RID: 139176
		[Token(Token = "0x4021FA8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04021FA9 RID: 139177
		[Token(Token = "0x4021FA9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04021FAA RID: 139178
		[Token(Token = "0x4021FAA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
