using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Emoticon;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F0A RID: 28426
	[Token(Token = "0x2006F0A")]
	public class ActMultiV3EmoticonController : EmoticonPagerPanelBaseController
	{
		// Token: 0x06028607 RID: 165383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028607")]
		[Address(RVA = "0x23AB6F0", Offset = "0x23AA2F0", VA = "0x1823AB6F0", Slot = "8")]
		protected override void _OnSendEmoji(string themeId, string emojiItem)
		{
		}

		// Token: 0x06028608 RID: 165384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028608")]
		[Address(RVA = "0x23AB430", Offset = "0x23AA030", VA = "0x1823AB430")]
		public GOPositionHolder GetPanelPos(ActMultiV3EmoticonController.LeftChatPosType leftChatPosType)
		{
			return null;
		}

		// Token: 0x06028609 RID: 165385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028609")]
		[Address(RVA = "0x23AB5B0", Offset = "0x23AA1B0", VA = "0x1823AB5B0")]
		public GOPositionHolder GetReceiveEmojiPosData(ActMultiV3EmoticonController.LeftChatPosType leftChatPosType, PlayerIndex pos)
		{
			return null;
		}

		// Token: 0x0602860A RID: 165386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602860A")]
		[Address(RVA = "0x23AB850", Offset = "0x23AA450", VA = "0x1823AB850")]
		public ActMultiV3EmoticonController()
		{
		}

		// Token: 0x040396A1 RID: 235169
		[Token(Token = "0x40396A1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<ActMultiV3EmoticonController.PanelPosData> _panelPosTypeDataList;

		// Token: 0x040396A2 RID: 235170
		[Token(Token = "0x40396A2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<ActMultiV3EmoticonController.ReceiveEmojiPosData> _receiveEmojiPosDataList;

		// Token: 0x040396A3 RID: 235171
		[Token(Token = "0x40396A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnSendEmoji;

		// Token: 0x040396A4 RID: 235172
		[Token(Token = "0x40396A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPanelPos;

		// Token: 0x040396A5 RID: 235173
		[Token(Token = "0x40396A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetReceiveEmojiPosData;

		// Token: 0x040396A6 RID: 235174
		[Token(Token = "0x40396A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F0B RID: 28427
		[Token(Token = "0x2006F0B")]
		public enum LeftChatPosType
		{
			// Token: 0x040396A8 RID: 235176
			[Token(Token = "0x40396A8")]
			NONE,
			// Token: 0x040396A9 RID: 235177
			[Token(Token = "0x40396A9")]
			SMALL,
			// Token: 0x040396AA RID: 235178
			[Token(Token = "0x40396AA")]
			BIG
		}

		// Token: 0x02006F0C RID: 28428
		[Token(Token = "0x2006F0C")]
		[Serializable]
		public class PanelPosData
		{
			// Token: 0x0602860B RID: 165387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602860B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PanelPosData()
			{
			}

			// Token: 0x040396AB RID: 235179
			[Token(Token = "0x40396AB")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3EmoticonController.LeftChatPosType posType;

			// Token: 0x040396AC RID: 235180
			[Token(Token = "0x40396AC")]
			[FieldOffset(Offset = "0x18")]
			public GOPositionHolder panelPos;
		}

		// Token: 0x02006F0D RID: 28429
		[Token(Token = "0x2006F0D")]
		[Serializable]
		public class ReceiveEmojiPosData
		{
			// Token: 0x0602860C RID: 165388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602860C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ReceiveEmojiPosData()
			{
			}

			// Token: 0x040396AD RID: 235181
			[Token(Token = "0x40396AD")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3EmoticonController.LeftChatPosType posType;

			// Token: 0x040396AE RID: 235182
			[Token(Token = "0x40396AE")]
			[FieldOffset(Offset = "0x14")]
			public PlayerIndex index;

			// Token: 0x040396AF RID: 235183
			[Token(Token = "0x40396AF")]
			[FieldOffset(Offset = "0x18")]
			public GOPositionHolder emojiItemPos;
		}

		// Token: 0x02006F0E RID: 28430
		[Token(Token = "0x2006F0E")]
		public class ActMultiV3EmoticonConfig : IEmoticonCustomConfig, IHotfixable
		{
			// Token: 0x0602860D RID: 165389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602860D")]
			[Address(RVA = "0x23AB050", Offset = "0x23A9C50", VA = "0x1823AB050", Slot = "4")]
			public string GetFocusEmoticonThemeId(ValueBundle vb)
			{
				return null;
			}

			// Token: 0x0602860E RID: 165390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602860E")]
			[Address(RVA = "0x23AB2C0", Offset = "0x23A9EC0", VA = "0x1823AB2C0", Slot = "5")]
			public void SaveSendEmoticonThemeId(ValueBundle vb, string themeId)
			{
			}

			// Token: 0x0602860F RID: 165391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602860F")]
			[Address(RVA = "0x23AAFA0", Offset = "0x23A9BA0", VA = "0x1823AAFA0", Slot = "6")]
			public List<string> GetEnabledEmoticonList(ValueBundle vb)
			{
				return null;
			}

			// Token: 0x06028610 RID: 165392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028610")]
			[Address(RVA = "0x23AB3D0", Offset = "0x23A9FD0", VA = "0x1823AB3D0")]
			public ActMultiV3EmoticonConfig()
			{
			}

			// Token: 0x040396B0 RID: 235184
			[Token(Token = "0x40396B0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetFocusEmoticonThemeId;

			// Token: 0x040396B1 RID: 235185
			[Token(Token = "0x40396B1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SaveSendEmoticonThemeId;

			// Token: 0x040396B2 RID: 235186
			[Token(Token = "0x40396B2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetEnabledEmoticonList;

			// Token: 0x040396B3 RID: 235187
			[Token(Token = "0x40396B3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
