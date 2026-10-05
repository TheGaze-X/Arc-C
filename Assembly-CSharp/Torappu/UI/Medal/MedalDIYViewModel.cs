using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200491E RID: 18718
	[Token(Token = "0x200491E")]
	public class MedalDIYViewModel : IHotfixable
	{
		// Token: 0x0601C384 RID: 115588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C384")]
		[Address(RVA = "0x15B07C0", Offset = "0x15AF3C0", VA = "0x1815B07C0")]
		public void InitData(string frameId)
		{
		}

		// Token: 0x0601C385 RID: 115589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C385")]
		[Address(RVA = "0x15B0D30", Offset = "0x15AF930", VA = "0x1815B0D30")]
		public void UpdateStatus(ICollection<string> selectedMedalIds)
		{
		}

		// Token: 0x0601C386 RID: 115590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C386")]
		[Address(RVA = "0x15B0700", Offset = "0x15AF300", VA = "0x1815B0700")]
		public DIYMedalModel GetMedalModel(string id)
		{
			return null;
		}

		// Token: 0x0601C387 RID: 115591 RVA: 0x000A7928 File Offset: 0x000A5B28
		[Token(Token = "0x601C387")]
		[Address(RVA = "0x15B0C50", Offset = "0x15AF850", VA = "0x1815B0C50")]
		public bool TryGetTokenValidPos(string medalId, out HexPoint validPos)
		{
			return default(bool);
		}

		// Token: 0x0601C388 RID: 115592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C388")]
		[Address(RVA = "0x15B0640", Offset = "0x15AF240", VA = "0x1815B0640")]
		public void ConfirmTokenPos(string medalId, HexPoint pos)
		{
		}

		// Token: 0x0601C389 RID: 115593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C389")]
		[Address(RVA = "0x15B0AB0", Offset = "0x15AF6B0", VA = "0x1815B0AB0")]
		public void RemoveTokenPos(string medalId)
		{
		}

		// Token: 0x0601C38A RID: 115594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C38A")]
		[Address(RVA = "0x15B0340", Offset = "0x15AEF40", VA = "0x1815B0340")]
		public void AdjustMedalList(ListDict<string, float> removedMedalLerps)
		{
		}

		// Token: 0x0601C38B RID: 115595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C38B")]
		[Address(RVA = "0x15B0B50", Offset = "0x15AF750", VA = "0x1815B0B50")]
		public void ResetAllTokens()
		{
		}

		// Token: 0x0601C38C RID: 115596 RVA: 0x000A7940 File Offset: 0x000A5B40
		[Token(Token = "0x601C38C")]
		[Address(RVA = "0x15B1330", Offset = "0x15AFF30", VA = "0x1815B1330")]
		private static int _MedalModelComparer(DIYMedalModel lhs, DIYMedalModel rhs)
		{
			return 0;
		}

		// Token: 0x0601C38D RID: 115597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C38D")]
		[Address(RVA = "0x15B1410", Offset = "0x15B0010", VA = "0x1815B1410")]
		public MedalDIYViewModel()
		{
		}

		// Token: 0x04024E89 RID: 151177
		[Token(Token = "0x4024E89")]
		[FieldOffset(Offset = "0x10")]
		public string frameId;

		// Token: 0x04024E8A RID: 151178
		[Token(Token = "0x4024E8A")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, DIYMedalModel> medals;

		// Token: 0x04024E8B RID: 151179
		[Token(Token = "0x4024E8B")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, HexPoint> tokens;

		// Token: 0x04024E8C RID: 151180
		[Token(Token = "0x4024E8C")]
		[FieldOffset(Offset = "0x28")]
		public List<DIYMedalModel> cardList;

		// Token: 0x04024E8D RID: 151181
		[Token(Token = "0x4024E8D")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_sharedIds;

		// Token: 0x04024E8E RID: 151182
		[Token(Token = "0x4024E8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04024E8F RID: 151183
		[Token(Token = "0x4024E8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x04024E90 RID: 151184
		[Token(Token = "0x4024E90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMedalModel;

		// Token: 0x04024E91 RID: 151185
		[Token(Token = "0x4024E91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetTokenValidPos;

		// Token: 0x04024E92 RID: 151186
		[Token(Token = "0x4024E92")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConfirmTokenPos;

		// Token: 0x04024E93 RID: 151187
		[Token(Token = "0x4024E93")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RemoveTokenPos;

		// Token: 0x04024E94 RID: 151188
		[Token(Token = "0x4024E94")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AdjustMedalList;

		// Token: 0x04024E95 RID: 151189
		[Token(Token = "0x4024E95")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetAllTokens;

		// Token: 0x04024E96 RID: 151190
		[Token(Token = "0x4024E96")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__MedalModelComparer;

		// Token: 0x04024E97 RID: 151191
		[Token(Token = "0x4024E97")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
