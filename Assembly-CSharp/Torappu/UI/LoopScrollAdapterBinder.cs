using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003978 RID: 14712
	[Token(Token = "0x2003978")]
	public abstract class LoopScrollAdapterBinder : IHotfixable
	{
		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x060173AD RID: 95149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060173AE RID: 95150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003780")]
		private protected LoopScrollAdapter<GetComponentCache, object> adapter
		{
			[Token(Token = "0x60173AD")]
			[Address(RVA = "0xF8F520", Offset = "0xF8E120", VA = "0x180F8F520")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60173AE")]
			[Address(RVA = "0xF8F580", Offset = "0xF8E180", VA = "0x180F8F580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060173AF RID: 95151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173AF")]
		[Address(RVA = "0xF8F0A0", Offset = "0xF8DCA0", VA = "0x180F8F0A0")]
		public void BehaviourOnly_BindAdapter(LoopScrollAdapter<GetComponentCache, object> adapter, GameObject prefab)
		{
		}

		// Token: 0x060173B0 RID: 95152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60173B0")]
		[Address(RVA = "0xF8F290", Offset = "0xF8DE90", VA = "0x180F8F290")]
		public GameObject BehaviourOnly_CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x060173B1 RID: 95153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173B1")]
		[Address(RVA = "0xF8F3A0", Offset = "0xF8DFA0", VA = "0x180F8F3A0")]
		public void BehaviourOnly_UpdateView(int position, GameObject view, GetComponentCache holder, object data)
		{
		}

		// Token: 0x060173B2 RID: 95154
		[Token(Token = "0x60173B2")]
		protected abstract void UpdateView(int position, GameObject view, GetComponentCache holder, object data);

		// Token: 0x060173B3 RID: 95155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173B3")]
		[Address(RVA = "0xF8F470", Offset = "0xF8E070", VA = "0x180F8F470")]
		protected LoopScrollAdapterBinder()
		{
		}

		// Token: 0x0401C0A8 RID: 114856
		[Token(Token = "0x401C0A8")]
		[FieldOffset(Offset = "0x10")]
		private GameObject m_prefab;

		// Token: 0x0401C0A9 RID: 114857
		[Token(Token = "0x401C0A9")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isViewTemplateInHierarchy;

		// Token: 0x0401C0AB RID: 114859
		[Token(Token = "0x401C0AB")]
		[FieldOffset(Offset = "0x28")]
		protected readonly List<object> dataSource;

		// Token: 0x0401C0AC RID: 114860
		[Token(Token = "0x401C0AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x0401C0AD RID: 114861
		[Token(Token = "0x401C0AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_adapter;

		// Token: 0x0401C0AE RID: 114862
		[Token(Token = "0x401C0AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BehaviourOnly_BindAdapter;

		// Token: 0x0401C0AF RID: 114863
		[Token(Token = "0x401C0AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BehaviourOnly_CreateView;

		// Token: 0x0401C0B0 RID: 114864
		[Token(Token = "0x401C0B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BehaviourOnly_UpdateView;

		// Token: 0x0401C0B1 RID: 114865
		[Token(Token = "0x401C0B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003979 RID: 14713
		[Token(Token = "0x2003979")]
		public interface IBinderHost
		{
			// Token: 0x060173B4 RID: 95156
			[Token(Token = "0x60173B4")]
			void LoopScrollAdapterBinderOnly_Bind(LoopScrollAdapterBinder binder);
		}
	}
}
