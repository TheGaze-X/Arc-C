using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200672D RID: 26413
	[Token(Token = "0x200672D")]
	public class HandBookV2MissionTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170059BC RID: 22972
		// (get) Token: 0x06025E1A RID: 155162 RVA: 0x000C94E0 File Offset: 0x000C76E0
		[Token(Token = "0x170059BC")]
		public bool isShow
		{
			[Token(Token = "0x6025E1A")]
			[Address(RVA = "0x20E68C0", Offset = "0x20E54C0", VA = "0x1820E68C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025E1B RID: 155163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E1B")]
		[Address(RVA = "0x20E5EB0", Offset = "0x20E4AB0", VA = "0x1820E5EB0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025E1C RID: 155164 RVA: 0x000C94F8 File Offset: 0x000C76F8
		[Token(Token = "0x6025E1C")]
		[Address(RVA = "0x20E5E40", Offset = "0x20E4A40", VA = "0x1820E5E40")]
		public static bool GetTrackPointState(Dictionary<string, int> favorMap)
		{
			return default(bool);
		}

		// Token: 0x06025E1D RID: 155165 RVA: 0x000C9510 File Offset: 0x000C7710
		[Token(Token = "0x6025E1D")]
		[Address(RVA = "0x20E5F90", Offset = "0x20E4B90", VA = "0x1820E5F90")]
		private static bool _GetTrackPointStateUsingMap(Dictionary<string, int> forceId2FavorSumMap)
		{
			return default(bool);
		}

		// Token: 0x06025E1E RID: 155166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E1E")]
		[Address(RVA = "0x20E6220", Offset = "0x20E4E20", VA = "0x1820E6220")]
		private static void _RefreshFavorSumMap(Dictionary<string, int> forceId2FavorSumMap)
		{
		}

		// Token: 0x06025E1F RID: 155167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E1F")]
		[Address(RVA = "0x20E6860", Offset = "0x20E5460", VA = "0x1820E6860")]
		public HandBookV2MissionTrackPoint()
		{
		}

		// Token: 0x04035495 RID: 218261
		[Token(Token = "0x4035495")]
		[FieldOffset(Offset = "0x10")]
		private bool m_availFlag;

		// Token: 0x04035496 RID: 218262
		[Token(Token = "0x4035496")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, int> m_forceId2FavorSumMap;

		// Token: 0x04035497 RID: 218263
		[Token(Token = "0x4035497")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04035498 RID: 218264
		[Token(Token = "0x4035498")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04035499 RID: 218265
		[Token(Token = "0x4035499")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTrackPointState;

		// Token: 0x0403549A RID: 218266
		[Token(Token = "0x403549A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetTrackPointStateUsingMap;

		// Token: 0x0403549B RID: 218267
		[Token(Token = "0x403549B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshFavorSumMap;

		// Token: 0x0403549C RID: 218268
		[Token(Token = "0x403549C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
