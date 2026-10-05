using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200631E RID: 25374
	[Token(Token = "0x200631E")]
	public class AutoChessShopPage : StateEnginePage
	{
		// Token: 0x17005633 RID: 22067
		// (get) Token: 0x06024963 RID: 149859 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024964 RID: 149860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005633")]
		public string activityId
		{
			[Token(Token = "0x6024963")]
			[Address(RVA = "0x1F78110", Offset = "0x1F76D10", VA = "0x181F78110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024964")]
			[Address(RVA = "0x1F781D0", Offset = "0x1F76DD0", VA = "0x181F781D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005634 RID: 22068
		// (get) Token: 0x06024965 RID: 149861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005634")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x6024965")]
			[Address(RVA = "0x1F78170", Offset = "0x1F76D70", VA = "0x181F78170")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024966 RID: 149862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024966")]
		[Address(RVA = "0x1F77F40", Offset = "0x1F76B40", VA = "0x181F77F40", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06024967 RID: 149863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024967")]
		[Address(RVA = "0x1F780B0", Offset = "0x1F76CB0", VA = "0x181F780B0")]
		public AutoChessShopPage()
		{
		}

		// Token: 0x06024968 RID: 149864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024968")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x040330C1 RID: 209089
		[Token(Token = "0x40330C1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x040330C2 RID: 209090
		[Token(Token = "0x40330C2")]
		[FieldOffset(Offset = "0xF8")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x040330C4 RID: 209092
		[Token(Token = "0x40330C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x040330C5 RID: 209093
		[Token(Token = "0x40330C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x040330C6 RID: 209094
		[Token(Token = "0x40330C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x040330C7 RID: 209095
		[Token(Token = "0x40330C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040330C8 RID: 209096
		[Token(Token = "0x40330C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200631F RID: 25375
		[Token(Token = "0x200631F")]
		public class ParamsInput
		{
			// Token: 0x06024969 RID: 149865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024969")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ParamsInput()
			{
			}

			// Token: 0x040330C9 RID: 209097
			[Token(Token = "0x40330C9")]
			[FieldOffset(Offset = "0x10")]
			public string activityId;
		}
	}
}
