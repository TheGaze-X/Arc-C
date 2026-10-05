using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x02001606 RID: 5638
	[Token(Token = "0x2001606")]
	public class LuaUIState : PopupFloatState, IContextHost
	{
		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06007FF4 RID: 32756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F28")]
		public Transform root
		{
			[Token(Token = "0x6007FF4")]
			[Address(RVA = "0x28936C0", Offset = "0x28922C0", VA = "0x1828936C0", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06007FF5 RID: 32757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F29")]
		public string mainDialog
		{
			[Token(Token = "0x6007FF5")]
			[Address(RVA = "0x2893660", Offset = "0x2892260", VA = "0x182893660", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007FF6 RID: 32758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF6")]
		[Address(RVA = "0x28933B0", Offset = "0x2891FB0", VA = "0x1828933B0", Slot = "34")]
		public void OnLeaveContext()
		{
		}

		// Token: 0x06007FF7 RID: 32759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FF7")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007FF8 RID: 32760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FF8")]
		[Address(RVA = "0x2893570", Offset = "0x2892170", VA = "0x182893570", Slot = "33")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x06007FF9 RID: 32761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FF9")]
		[Address(RVA = "0x2893020", Offset = "0x2891C20", VA = "0x182893020", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FFA")]
		[Address(RVA = "0x28932E0", Offset = "0x2891EE0", VA = "0x1828932E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FFB")]
		[Address(RVA = "0x2893430", Offset = "0x2892030", VA = "0x182893430", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FFC")]
		[Address(RVA = "0x2893080", Offset = "0x2891C80", VA = "0x182893080")]
		public void HandleOpenState(string stateType)
		{
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FFD")]
		[Address(RVA = "0x2892FC0", Offset = "0x2891BC0", VA = "0x182892FC0", Slot = "37")]
		public IDictionary<string, Type> CompDeclaration()
		{
			return null;
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FFE")]
		[Address(RVA = "0x2893510", Offset = "0x2892110", VA = "0x182893510", Slot = "38")]
		public UnityEngine.Object UICompDialogHost()
		{
			return null;
		}

		// Token: 0x06007FFF RID: 32767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FFF")]
		[Address(RVA = "0x2893600", Offset = "0x2892200", VA = "0x182893600")]
		public LuaUIState()
		{
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008000")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06008001 RID: 32769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008001")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04008169 RID: 33129
		[Token(Token = "0x4008169")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _mainDialog;

		// Token: 0x0400816A RID: 33130
		[Token(Token = "0x400816A")]
		[FieldOffset(Offset = "0x78")]
		private LuaUIContext m_context;

		// Token: 0x0400816B RID: 33131
		[Token(Token = "0x400816B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_root;

		// Token: 0x0400816C RID: 33132
		[Token(Token = "0x400816C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_mainDialog;

		// Token: 0x0400816D RID: 33133
		[Token(Token = "0x400816D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLeaveContext;

		// Token: 0x0400816E RID: 33134
		[Token(Token = "0x400816E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0400816F RID: 33135
		[Token(Token = "0x400816F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x04008170 RID: 33136
		[Token(Token = "0x4008170")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04008171 RID: 33137
		[Token(Token = "0x4008171")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04008172 RID: 33138
		[Token(Token = "0x4008172")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04008173 RID: 33139
		[Token(Token = "0x4008173")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HandleOpenState;

		// Token: 0x04008174 RID: 33140
		[Token(Token = "0x4008174")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CompDeclaration;

		// Token: 0x04008175 RID: 33141
		[Token(Token = "0x4008175")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UICompDialogHost;

		// Token: 0x04008176 RID: 33142
		[Token(Token = "0x4008176")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
