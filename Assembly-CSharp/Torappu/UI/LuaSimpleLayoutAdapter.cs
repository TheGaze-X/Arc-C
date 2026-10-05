using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039BD RID: 14781
	[Token(Token = "0x20039BD")]
	[LuaCallCSharp(GenFlag.No)]
	public class LuaSimpleLayoutAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x060175A8 RID: 95656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175A8")]
		[Address(RVA = "0xFB1CD0", Offset = "0xFB08D0", VA = "0x180FB1CD0")]
		private LuaSimpleLayoutAdapter(ILuaSimpleLayoutAdapter impl)
		{
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x060175A9 RID: 95657 RVA: 0x00096258 File Offset: 0x00094458
		[Token(Token = "0x170037ED")]
		public override int count
		{
			[Token(Token = "0x60175A9")]
			[Address(RVA = "0xFB1D50", Offset = "0xFB0950", VA = "0x180FB1D50", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060175AA RID: 95658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60175AA")]
		[Address(RVA = "0xFB19C0", Offset = "0xFB05C0", VA = "0x180FB19C0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060175AB RID: 95659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175AB")]
		[Address(RVA = "0xFB1C60", Offset = "0xFB0860", VA = "0x180FB1C60")]
		private void _DisposeImpl()
		{
		}

		// Token: 0x060175AC RID: 95660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175AC")]
		[Address(RVA = "0xFB1920", Offset = "0xFB0520", VA = "0x180FB1920")]
		public void DisposeFromLua()
		{
		}

		// Token: 0x060175AD RID: 95661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60175AD")]
		[Address(RVA = "0xFB1760", Offset = "0xFB0360", VA = "0x180FB1760")]
		public static LuaSimpleLayoutAdapter BindAdapterToLayout(ILuaSimpleLayoutAdapter luaAdapter, SimpleLayoutContent layout)
		{
			return null;
		}

		// Token: 0x0401C32F RID: 115503
		[Token(Token = "0x401C32F")]
		[FieldOffset(Offset = "0x20")]
		private ILuaSimpleLayoutAdapter m_impl;

		// Token: 0x0401C330 RID: 115504
		[Token(Token = "0x401C330")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C331 RID: 115505
		[Token(Token = "0x401C331")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0401C332 RID: 115506
		[Token(Token = "0x401C332")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401C333 RID: 115507
		[Token(Token = "0x401C333")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DisposeImpl;

		// Token: 0x0401C334 RID: 115508
		[Token(Token = "0x401C334")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DisposeFromLua;

		// Token: 0x0401C335 RID: 115509
		[Token(Token = "0x401C335")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_BindAdapterToLayout;
	}
}
