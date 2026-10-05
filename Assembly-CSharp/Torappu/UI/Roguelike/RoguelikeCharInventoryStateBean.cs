using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054AD RID: 21677
	[Token(Token = "0x20054AD")]
	public class RoguelikeCharInventoryStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0601FE3E RID: 130622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE3E")]
		[Address(RVA = "0x1A002E0", Offset = "0x19FEEE0", VA = "0x181A002E0")]
		public void AttachPluginContexts(List<IRoguelikeCharCardViewPluginContext> pluginContexts)
		{
		}

		// Token: 0x0601FE3F RID: 130623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE3F")]
		[Address(RVA = "0x1A00360", Offset = "0x19FEF60", VA = "0x181A00360")]
		public void InitInventoryProperty(string topicId)
		{
		}

		// Token: 0x0601FE40 RID: 130624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE40")]
		[Address(RVA = "0x1A006A0", Offset = "0x19FF2A0", VA = "0x181A006A0")]
		private List<RoguelikeCharCardViewModel> _GetAllCharList()
		{
			return null;
		}

		// Token: 0x0601FE41 RID: 130625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE41")]
		[Address(RVA = "0x1A008C0", Offset = "0x19FF4C0", VA = "0x181A008C0")]
		public RoguelikeCharInventoryStateBean()
		{
		}

		// Token: 0x0402B024 RID: 176164
		[Token(Token = "0x402B024")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeSelectCharProperty property;

		// Token: 0x0402B025 RID: 176165
		[Token(Token = "0x402B025")]
		[FieldOffset(Offset = "0x20")]
		private List<IRoguelikeCharCardViewPluginContext> m_pluginContexts;

		// Token: 0x0402B026 RID: 176166
		[Token(Token = "0x402B026")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AttachPluginContexts;

		// Token: 0x0402B027 RID: 176167
		[Token(Token = "0x402B027")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitInventoryProperty;

		// Token: 0x0402B028 RID: 176168
		[Token(Token = "0x402B028")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetAllCharList;

		// Token: 0x0402B029 RID: 176169
		[Token(Token = "0x402B029")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
