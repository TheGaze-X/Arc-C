using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.ChatBox;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C61 RID: 15457
	[Token(Token = "0x2003C61")]
	public class TuningChatNarrationComp : IHotfixable
	{
		// Token: 0x06018272 RID: 98930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018272")]
		[Address(RVA = "0x1090570", Offset = "0x108F170", VA = "0x181090570")]
		public TuningChatNarrationComp()
		{
		}

		// Token: 0x0401D5D9 RID: 120281
		[Token(Token = "0x401D5D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C62 RID: 15458
		[Token(Token = "0x2003C62")]
		public struct Options
		{
			// Token: 0x0401D5DA RID: 120282
			[Token(Token = "0x401D5DA")]
			[FieldOffset(Offset = "0x0")]
			public float preDelay;

			// Token: 0x0401D5DB RID: 120283
			[Token(Token = "0x401D5DB")]
			[FieldOffset(Offset = "0x4")]
			public bool needHandle;

			// Token: 0x0401D5DC RID: 120284
			[Token(Token = "0x401D5DC")]
			[FieldOffset(Offset = "0x8")]
			public TuningChatController.TuningChatItemMeta meta;

			// Token: 0x0401D5DD RID: 120285
			[Token(Token = "0x401D5DD")]
			[FieldOffset(Offset = "0x10")]
			public Action<int, string, string> onNarrationHandle;

			// Token: 0x0401D5DE RID: 120286
			[Token(Token = "0x401D5DE")]
			[FieldOffset(Offset = "0x18")]
			public Action onNarrationHandled;
		}

		// Token: 0x02003C63 RID: 15459
		[Token(Token = "0x2003C63")]
		public class VirtualView : AVGChatConditionVirtualView<TuningChatPredelayComp>
		{
			// Token: 0x06018273 RID: 98931 RVA: 0x00099918 File Offset: 0x00097B18
			[Token(Token = "0x6018273")]
			[Address(RVA = "0x10A3550", Offset = "0x10A2150", VA = "0x1810A3550", Slot = "19")]
			public override PlayConfig BeforePlaying()
			{
				return default(PlayConfig);
			}

			// Token: 0x06018274 RID: 98932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018274")]
			[Address(RVA = "0x10A3BF0", Offset = "0x10A27F0", VA = "0x1810A3BF0")]
			public VirtualView(TuningChatNarrationComp.Options options)
			{
			}

			// Token: 0x06018275 RID: 98933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018275")]
			[Address(RVA = "0x10A3960", Offset = "0x10A2560", VA = "0x1810A3960", Slot = "20")]
			protected override IEnumerator PlayCondition()
			{
				return null;
			}

			// Token: 0x06018276 RID: 98934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018276")]
			[Address(RVA = "0x10A3AE0", Offset = "0x10A26E0", VA = "0x1810A3AE0", Slot = "21")]
			protected override void ShowAsLog()
			{
			}

			// Token: 0x0401D5DF RID: 120287
			[Token(Token = "0x401D5DF")]
			[FieldOffset(Offset = "0x20")]
			private Action<int, string, string> m_onNarrationHandle;

			// Token: 0x0401D5E0 RID: 120288
			[Token(Token = "0x401D5E0")]
			[FieldOffset(Offset = "0x28")]
			public Action m_onNarrationHandled;

			// Token: 0x0401D5E1 RID: 120289
			[Token(Token = "0x401D5E1")]
			[FieldOffset(Offset = "0x30")]
			private TuningChatController.TuningChatItemMeta m_meta;

			// Token: 0x0401D5E2 RID: 120290
			[Token(Token = "0x401D5E2")]
			[FieldOffset(Offset = "0x38")]
			private bool m_needHandle;

			// Token: 0x0401D5E3 RID: 120291
			[Token(Token = "0x401D5E3")]
			[FieldOffset(Offset = "0x3C")]
			private float m_preDelay;

			// Token: 0x0401D5E4 RID: 120292
			[Token(Token = "0x401D5E4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_BeforePlaying;

			// Token: 0x0401D5E5 RID: 120293
			[Token(Token = "0x401D5E5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D5E6 RID: 120294
			[Token(Token = "0x401D5E6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_PlayCondition;

			// Token: 0x0401D5E7 RID: 120295
			[Token(Token = "0x401D5E7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ShowAsLog;
		}
	}
}
