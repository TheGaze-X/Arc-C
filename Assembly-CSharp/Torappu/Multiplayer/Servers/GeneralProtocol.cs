using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.SocketNetwork;
using XLua;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x0200158D RID: 5517
	[Token(Token = "0x200158D")]
	public static class GeneralProtocol
	{
		// Token: 0x06007DB9 RID: 32185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DB9")]
		[Address(RVA = "0x2841F50", Offset = "0x2840B50", VA = "0x182841F50")]
		public static void Register(ProtocolSuite suite)
		{
		}

		// Token: 0x04007ED0 RID: 32464
		[Token(Token = "0x4007ED0")]
		public const uint MSG_NOTIFY = 3U;

		// Token: 0x0200158E RID: 5518
		[Token(Token = "0x200158E")]
		public class MsgNotifyRet : Protocol
		{
			// Token: 0x06007DBA RID: 32186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DBA")]
			[Address(RVA = "0x2842FF0", Offset = "0x2841BF0", VA = "0x182842FF0")]
			public MsgNotifyRet()
			{
			}

			// Token: 0x06007DBB RID: 32187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DBB")]
			[Address(RVA = "0x2842F50", Offset = "0x2841B50", VA = "0x182842F50", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007DBC RID: 32188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DBC")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007ED1 RID: 32465
			[Token(Token = "0x4007ED1")]
			public const uint ID = 4U;

			// Token: 0x04007ED2 RID: 32466
			[Token(Token = "0x4007ED2")]
			[FieldOffset(Offset = "0x18")]
			public string msg;

			// Token: 0x04007ED3 RID: 32467
			[Token(Token = "0x4007ED3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007ED4 RID: 32468
			[Token(Token = "0x4007ED4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}

		// Token: 0x0200158F RID: 5519
		[Token(Token = "0x200158F")]
		public enum RetCode
		{
			// Token: 0x04007ED6 RID: 32470
			[Token(Token = "0x4007ED6")]
			RetCodeOK,
			// Token: 0x04007ED7 RID: 32471
			[Token(Token = "0x4007ED7")]
			RetCodeSceneNotExist = 101,
			// Token: 0x04007ED8 RID: 32472
			[Token(Token = "0x4007ED8")]
			RetCodeSceneJoinFailed,
			// Token: 0x04007ED9 RID: 32473
			[Token(Token = "0x4007ED9")]
			RetCodeTeamNotExist = 601,
			// Token: 0x04007EDA RID: 32474
			[Token(Token = "0x4007EDA")]
			RetCodeTeamJoinFailed,
			// Token: 0x04007EDB RID: 32475
			[Token(Token = "0x4007EDB")]
			RetCodeTeamSceneStartFailed,
			// Token: 0x04007EDC RID: 32476
			[Token(Token = "0x4007EDC")]
			RetCodeTeamFull,
			// Token: 0x04007EDD RID: 32477
			[Token(Token = "0x4007EDD")]
			RetCodeTeamSceneStartFailedFull,
			// Token: 0x04007EDE RID: 32478
			[Token(Token = "0x4007EDE")]
			ClientCodeNetLost = 901
		}
	}
}
