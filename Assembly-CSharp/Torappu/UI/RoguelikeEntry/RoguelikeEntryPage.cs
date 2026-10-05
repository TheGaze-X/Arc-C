using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x02004462 RID: 17506
	[Token(Token = "0x2004462")]
	public class RoguelikeEntryPage : StateEnginePage, IHotfixable
	{
		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x0601AC35 RID: 109621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FA7")]
		public string topicIdOnOpen
		{
			[Token(Token = "0x601AC35")]
			[Address(RVA = "0x13D84C0", Offset = "0x13D70C0", VA = "0x1813D84C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AC36 RID: 109622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC36")]
		[Address(RVA = "0x13D7D80", Offset = "0x13D6980", VA = "0x1813D7D80", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601AC37 RID: 109623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC37")]
		[Address(RVA = "0x13D7FB0", Offset = "0x13D6BB0", VA = "0x1813D7FB0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601AC38 RID: 109624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC38")]
		[Address(RVA = "0x13D7CD0", Offset = "0x13D68D0", VA = "0x1813D7CD0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601AC39 RID: 109625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC39")]
		[Address(RVA = "0x13D7F40", Offset = "0x13D6B40", VA = "0x1813D7F40", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601AC3A RID: 109626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC3A")]
		[Address(RVA = "0x13D8070", Offset = "0x13D6C70", VA = "0x1813D8070")]
		public void TriggerBGMSignal(string topicId)
		{
		}

		// Token: 0x0601AC3B RID: 109627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC3B")]
		[Address(RVA = "0x13D7C70", Offset = "0x13D6870", VA = "0x1813D7C70")]
		public string GetBgmInstIdAlias()
		{
			return null;
		}

		// Token: 0x0601AC3C RID: 109628 RVA: 0x000A34A0 File Offset: 0x000A16A0
		[Token(Token = "0x601AC3C")]
		[Address(RVA = "0x13D8390", Offset = "0x13D6F90", VA = "0x1813D8390")]
		private long _GetBGMInstId()
		{
			return 0L;
		}

		// Token: 0x0601AC3D RID: 109629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC3D")]
		[Address(RVA = "0x13D82F0", Offset = "0x13D6EF0", VA = "0x1813D82F0")]
		private void _ClearBGM()
		{
		}

		// Token: 0x0601AC3E RID: 109630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC3E")]
		[Address(RVA = "0x13D7AF0", Offset = "0x13D66F0", VA = "0x1813D7AF0")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601AC3F RID: 109631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC3F")]
		[Address(RVA = "0x13D8460", Offset = "0x13D7060", VA = "0x1813D8460")]
		public RoguelikeEntryPage()
		{
		}

		// Token: 0x0601AC41 RID: 109633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC41")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601AC42 RID: 109634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC42")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601AC43 RID: 109635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC43")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601AC44 RID: 109636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC44")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04022360 RID: 140128
		[Token(Token = "0x4022360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UICommonPageEffectHolder[] _effectHolders;

		// Token: 0x04022361 RID: 140129
		[Token(Token = "0x4022361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string m_topicIdFromSavedInst;

		// Token: 0x04022362 RID: 140130
		[Token(Token = "0x4022362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string m_bgmInstIdAlias;

		// Token: 0x04022363 RID: 140131
		[Token(Token = "0x4022363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicIdOnOpen;

		// Token: 0x04022364 RID: 140132
		[Token(Token = "0x4022364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04022365 RID: 140133
		[Token(Token = "0x4022365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04022366 RID: 140134
		[Token(Token = "0x4022366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04022367 RID: 140135
		[Token(Token = "0x4022367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04022368 RID: 140136
		[Token(Token = "0x4022368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TriggerBGMSignal;

		// Token: 0x04022369 RID: 140137
		[Token(Token = "0x4022369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetBgmInstIdAlias;

		// Token: 0x0402236A RID: 140138
		[Token(Token = "0x402236A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x0402236B RID: 140139
		[Token(Token = "0x402236B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x0402236C RID: 140140
		[Token(Token = "0x402236C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0402236D RID: 140141
		[Token(Token = "0x402236D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004463 RID: 17507
		[Token(Token = "0x2004463")]
		public class Params
		{
			// Token: 0x0601AC45 RID: 109637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC45")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0402236E RID: 140142
			[Token(Token = "0x402236E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string topicId;
		}
	}
}
