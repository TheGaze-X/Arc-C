using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044CF RID: 17615
	[Token(Token = "0x20044CF")]
	public class RoguelikeTopicEndingState : PopupFloatState
	{
		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x0601AE54 RID: 110164 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE55 RID: 110165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FDC")]
		public RoguelikeTopicEndingStyle style
		{
			[Token(Token = "0x601AE54")]
			[Address(RVA = "0x140D500", Offset = "0x140C100", VA = "0x18140D500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AE55")]
			[Address(RVA = "0x140D560", Offset = "0x140C160", VA = "0x18140D560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601AE56 RID: 110166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE56")]
		[Address(RVA = "0x140CD10", Offset = "0x140B910", VA = "0x18140CD10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601AE57 RID: 110167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE57")]
		[Address(RVA = "0x140CED0", Offset = "0x140BAD0", VA = "0x18140CED0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601AE58 RID: 110168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE58")]
		[Address(RVA = "0x140CDF0", Offset = "0x140B9F0", VA = "0x18140CDF0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601AE59 RID: 110169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AE59")]
		[Address(RVA = "0x140CCB0", Offset = "0x140B8B0", VA = "0x18140CCB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601AE5A RID: 110170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE5A")]
		[Address(RVA = "0x140D330", Offset = "0x140BF30", VA = "0x18140D330")]
		private void _LoadControllerIfNot(string topicId)
		{
		}

		// Token: 0x0601AE5B RID: 110171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE5B")]
		[Address(RVA = "0x140CFB0", Offset = "0x140BBB0", VA = "0x18140CFB0")]
		private void _Init()
		{
		}

		// Token: 0x0601AE5C RID: 110172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE5C")]
		[Address(RVA = "0x140CA40", Offset = "0x140B640", VA = "0x18140CA40")]
		public void EventOnComplete()
		{
		}

		// Token: 0x0601AE5D RID: 110173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE5D")]
		[Address(RVA = "0x140D4A0", Offset = "0x140C0A0", VA = "0x18140D4A0")]
		public RoguelikeTopicEndingState()
		{
		}

		// Token: 0x0601AE5E RID: 110174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE5E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601AE5F RID: 110175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE5F")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601AE60 RID: 110176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE60")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04022770 RID: 141168
		[Token(Token = "0x4022770")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04022771 RID: 141169
		[Token(Token = "0x4022771")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeTopicEndingControllerBase m_controller;

		// Token: 0x04022773 RID: 141171
		[Token(Token = "0x4022773")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_style;

		// Token: 0x04022774 RID: 141172
		[Token(Token = "0x4022774")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_style;

		// Token: 0x04022775 RID: 141173
		[Token(Token = "0x4022775")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022776 RID: 141174
		[Token(Token = "0x4022776")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04022777 RID: 141175
		[Token(Token = "0x4022777")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04022778 RID: 141176
		[Token(Token = "0x4022778")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022779 RID: 141177
		[Token(Token = "0x4022779")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadControllerIfNot;

		// Token: 0x0402277A RID: 141178
		[Token(Token = "0x402277A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0402277B RID: 141179
		[Token(Token = "0x402277B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnComplete;

		// Token: 0x0402277C RID: 141180
		[Token(Token = "0x402277C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
