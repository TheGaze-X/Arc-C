using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Multiplayer.Mode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Multiplayer.UI
{
	// Token: 0x02001568 RID: 5480
	[Token(Token = "0x2001568")]
	internal class MultiplayerReplayMainState : State
	{
		// Token: 0x06007D4B RID: 32075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D4B")]
		[Address(RVA = "0x2849480", Offset = "0x2848080", VA = "0x182849480")]
		public void EventOpenFile()
		{
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D4C")]
		[Address(RVA = "0x2849A60", Offset = "0x2848660", VA = "0x182849A60")]
		public void EventPlay()
		{
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D4D")]
		[Address(RVA = "0x28493F0", Offset = "0x2847FF0", VA = "0x1828493F0")]
		public void EventNetPlay()
		{
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D4E")]
		[Address(RVA = "0x2849C90", Offset = "0x2848890", VA = "0x182849C90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D4F")]
		[Address(RVA = "0x2849CF0", Offset = "0x28488F0", VA = "0x182849CF0")]
		public MultiplayerReplayMainState()
		{
		}

		// Token: 0x04007E0C RID: 32268
		[Token(Token = "0x4007E0C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _videoInfo;

		// Token: 0x04007E0D RID: 32269
		[Token(Token = "0x4007E0D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _actId;

		// Token: 0x04007E0E RID: 32270
		[Token(Token = "0x4007E0E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Dropdown _playerList;

		// Token: 0x04007E0F RID: 32271
		[Token(Token = "0x4007E0F")]
		[FieldOffset(Offset = "0x68")]
		private IMultiplayerBattleVideo m_video;

		// Token: 0x04007E10 RID: 32272
		[Token(Token = "0x4007E10")]
		[FieldOffset(Offset = "0x70")]
		private List<string> m_players;

		// Token: 0x04007E11 RID: 32273
		[Token(Token = "0x4007E11")]
		[FieldOffset(Offset = "0x78")]
		private string m_replayActId;

		// Token: 0x04007E12 RID: 32274
		[Token(Token = "0x4007E12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOpenFile;

		// Token: 0x04007E13 RID: 32275
		[Token(Token = "0x4007E13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventPlay;

		// Token: 0x04007E14 RID: 32276
		[Token(Token = "0x4007E14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventNetPlay;

		// Token: 0x04007E15 RID: 32277
		[Token(Token = "0x4007E15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04007E16 RID: 32278
		[Token(Token = "0x4007E16")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
