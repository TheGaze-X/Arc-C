using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052FD RID: 21245
	[Token(Token = "0x20052FD")]
	public class RoguelikeMenuRelicAdapterObject : RoguelikeMenuObject<RoguelikeMenuRelicViewModel>
	{
		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x0601F56C RID: 128364 RVA: 0x000B1930 File Offset: 0x000AFB30
		[Token(Token = "0x17004986")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F56C")]
			[Address(RVA = "0x1912C00", Offset = "0x1911800", VA = "0x181912C00", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F56D RID: 128365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F56D")]
		[Address(RVA = "0x1912660", Offset = "0x1911260", VA = "0x181912660", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x0601F56E RID: 128366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F56E")]
		[Address(RVA = "0x1912A70", Offset = "0x1911670", VA = "0x181912A70")]
		private void _OnLayoutBoundUpdated()
		{
		}

		// Token: 0x0601F56F RID: 128367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F56F")]
		[Address(RVA = "0x1912950", Offset = "0x1911550", VA = "0x181912950", Slot = "16")]
		public override void Render(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F570 RID: 128368 RVA: 0x000B1948 File Offset: 0x000AFB48
		[Token(Token = "0x601F570")]
		[Address(RVA = "0x1912880", Offset = "0x1911480", VA = "0x181912880", Slot = "9")]
		public override bool IsSelected()
		{
			return default(bool);
		}

		// Token: 0x0601F571 RID: 128369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F571")]
		[Address(RVA = "0x19128E0", Offset = "0x19114E0", VA = "0x1819128E0", Slot = "10")]
		public override void OpenSelf()
		{
		}

		// Token: 0x0601F572 RID: 128370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F572")]
		[Address(RVA = "0x1912B80", Offset = "0x1911780", VA = "0x181912B80")]
		public RoguelikeMenuRelicAdapterObject()
		{
		}

		// Token: 0x0601F573 RID: 128371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F573")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0601F574 RID: 128372 RVA: 0x000B1960 File Offset: 0x000AFB60
		[Token(Token = "0x601F574")]
		[Address(RVA = "0x1912A50", Offset = "0x1911650", VA = "0x181912A50")]
		private bool <>xLuaBaseProxy_IsSelected()
		{
			return default(bool);
		}

		// Token: 0x0601F575 RID: 128373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F575")]
		[Address(RVA = "0x1912A60", Offset = "0x1911660", VA = "0x181912A60")]
		private void <>xLuaBaseProxy_OpenSelf()
		{
		}

		// Token: 0x0402A1C0 RID: 172480
		[Token(Token = "0x402A1C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeMenuRelicLayout _layout;

		// Token: 0x0402A1C1 RID: 172481
		[Token(Token = "0x402A1C1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _showTrap;

		// Token: 0x0402A1C2 RID: 172482
		[Token(Token = "0x402A1C2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _numLimit;

		// Token: 0x0402A1C3 RID: 172483
		[Token(Token = "0x402A1C3")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeMenuRelicViewModel m_cachedModel;

		// Token: 0x0402A1C4 RID: 172484
		[Token(Token = "0x402A1C4")]
		[FieldOffset(Offset = "0x40")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x0402A1C5 RID: 172485
		[Token(Token = "0x402A1C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A1C6 RID: 172486
		[Token(Token = "0x402A1C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A1C7 RID: 172487
		[Token(Token = "0x402A1C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnLayoutBoundUpdated;

		// Token: 0x0402A1C8 RID: 172488
		[Token(Token = "0x402A1C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A1C9 RID: 172489
		[Token(Token = "0x402A1C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsSelected;

		// Token: 0x0402A1CA RID: 172490
		[Token(Token = "0x402A1CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OpenSelf;

		// Token: 0x0402A1CB RID: 172491
		[Token(Token = "0x402A1CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
