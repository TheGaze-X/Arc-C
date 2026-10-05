using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F25 RID: 24357
	[Token(Token = "0x2005F25")]
	public class SpCharInfoViewModel : IHotfixable
	{
		// Token: 0x17005371 RID: 21361
		// (get) Token: 0x0602347E RID: 144510 RVA: 0x000C0768 File Offset: 0x000BE968
		[Token(Token = "0x17005371")]
		public bool hasMissionInProgress
		{
			[Token(Token = "0x602347E")]
			[Address(RVA = "0x1DE46C0", Offset = "0x1DE32C0", VA = "0x181DE46C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602347F RID: 144511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602347F")]
		[Address(RVA = "0x1DE4060", Offset = "0x1DE2C60", VA = "0x181DE4060")]
		public void LoadData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06023480 RID: 144512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023480")]
		[Address(RVA = "0x1DE43C0", Offset = "0x1DE2FC0", VA = "0x181DE43C0")]
		private void _LoadSpCharInfo(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06023481 RID: 144513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023481")]
		[Address(RVA = "0x1DE4130", Offset = "0x1DE2D30", VA = "0x181DE4130")]
		private void _LoadMissionInfo()
		{
		}

		// Token: 0x06023482 RID: 144514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023482")]
		[Address(RVA = "0x1DE4660", Offset = "0x1DE3260", VA = "0x181DE4660")]
		public SpCharInfoViewModel()
		{
		}

		// Token: 0x04030A3E RID: 199230
		[Token(Token = "0x4030A3E")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04030A3F RID: 199231
		[Token(Token = "0x4030A3F")]
		[FieldOffset(Offset = "0x18")]
		public bool hasSpCharInDB;

		// Token: 0x04030A40 RID: 199232
		[Token(Token = "0x4030A40")]
		[FieldOffset(Offset = "0x20")]
		public string spCharNames;

		// Token: 0x04030A41 RID: 199233
		[Token(Token = "0x4030A41")]
		[FieldOffset(Offset = "0x28")]
		public string missionUnlockSpCharName;

		// Token: 0x04030A42 RID: 199234
		[Token(Token = "0x4030A42")]
		[FieldOffset(Offset = "0x30")]
		public bool isMissionUnlocked;

		// Token: 0x04030A43 RID: 199235
		[Token(Token = "0x4030A43")]
		[FieldOffset(Offset = "0x31")]
		public bool hasMissionFullfilled;

		// Token: 0x04030A44 RID: 199236
		[Token(Token = "0x4030A44")]
		[FieldOffset(Offset = "0x32")]
		public bool isAllMissionComplete;

		// Token: 0x04030A45 RID: 199237
		[Token(Token = "0x4030A45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasMissionInProgress;

		// Token: 0x04030A46 RID: 199238
		[Token(Token = "0x4030A46")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030A47 RID: 199239
		[Token(Token = "0x4030A47")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSpCharInfo;

		// Token: 0x04030A48 RID: 199240
		[Token(Token = "0x4030A48")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadMissionInfo;

		// Token: 0x04030A49 RID: 199241
		[Token(Token = "0x4030A49")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
