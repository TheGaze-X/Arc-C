using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063D2 RID: 25554
	[Token(Token = "0x20063D2")]
	public class AutoChessServiceBattleInfo : IHotfixable
	{
		// Token: 0x17005709 RID: 22281
		// (get) Token: 0x06024D8B RID: 150923 RVA: 0x000C5A60 File Offset: 0x000C3C60
		[Token(Token = "0x17005709")]
		public bool valid
		{
			[Token(Token = "0x6024D8B")]
			[Address(RVA = "0x1FBDA60", Offset = "0x1FBC660", VA = "0x181FBDA60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06024D8C RID: 150924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D8C")]
		[Address(RVA = "0x1FBD790", Offset = "0x1FBC390", VA = "0x181FBD790")]
		public void Fill(AutoChessBattleAllStateSyncData allStateSyncData, string sceneId)
		{
		}

		// Token: 0x06024D8D RID: 150925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D8D")]
		[Address(RVA = "0x1FBD8F0", Offset = "0x1FBC4F0", VA = "0x181FBD8F0")]
		public void Reset()
		{
		}

		// Token: 0x06024D8E RID: 150926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D8E")]
		[Address(RVA = "0x1FBD9C0", Offset = "0x1FBC5C0", VA = "0x181FBD9C0")]
		public AutoChessServiceBattleInfo()
		{
		}

		// Token: 0x04033839 RID: 211001
		[Token(Token = "0x4033839")]
		[FieldOffset(Offset = "0x10")]
		public bool started;

		// Token: 0x0403383A RID: 211002
		[Token(Token = "0x403383A")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403383B RID: 211003
		[Token(Token = "0x403383B")]
		[FieldOffset(Offset = "0x20")]
		public string sceneId;

		// Token: 0x0403383C RID: 211004
		[Token(Token = "0x403383C")]
		[FieldOffset(Offset = "0x28")]
		public string modeId;

		// Token: 0x0403383D RID: 211005
		[Token(Token = "0x403383D")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessBattleSceneData battleSceneData;

		// Token: 0x0403383E RID: 211006
		[Token(Token = "0x403383E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_valid;

		// Token: 0x0403383F RID: 211007
		[Token(Token = "0x403383F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Fill;

		// Token: 0x04033840 RID: 211008
		[Token(Token = "0x4033840")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04033841 RID: 211009
		[Token(Token = "0x4033841")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
