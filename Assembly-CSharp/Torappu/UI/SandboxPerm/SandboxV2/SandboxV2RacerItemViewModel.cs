using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004368 RID: 17256
	[Token(Token = "0x2004368")]
	public class SandboxV2RacerItemViewModel : SandboxV2RacerModel
	{
		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x0601A7B0 RID: 108464 RVA: 0x000A1EF8 File Offset: 0x000A00F8
		[Token(Token = "0x17003EE1")]
		public override bool isTemp
		{
			[Token(Token = "0x601A7B0")]
			[Address(RVA = "0x13957F0", Offset = "0x13943F0", VA = "0x1813957F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x0601A7B1 RID: 108465 RVA: 0x000A1F10 File Offset: 0x000A0110
		// (set) Token: 0x0601A7B2 RID: 108466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EE2")]
		public override bool isMarked
		{
			[Token(Token = "0x601A7B1")]
			[Address(RVA = "0x1395790", Offset = "0x1394390", VA = "0x181395790", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601A7B2")]
			[Address(RVA = "0x1395910", Offset = "0x1394510", VA = "0x181395910", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x0601A7B3 RID: 108467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EE3")]
		public override string name
		{
			[Token(Token = "0x601A7B3")]
			[Address(RVA = "0x13958B0", Offset = "0x13944B0", VA = "0x1813958B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x0601A7B4 RID: 108468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EE4")]
		public override List<SandboxV2RacerMedalModel> medalList
		{
			[Token(Token = "0x601A7B4")]
			[Address(RVA = "0x1395850", Offset = "0x1394450", VA = "0x181395850", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A7B5 RID: 108469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7B5")]
		[Address(RVA = "0x1395240", Offset = "0x1393E40", VA = "0x181395240")]
		public void LoadData(string topicId, SandboxV2RacingData gameData, string instId, PlayerSandboxV2.Racing.RacerInfo playerRacer)
		{
		}

		// Token: 0x0601A7B6 RID: 108470 RVA: 0x000A1F28 File Offset: 0x000A0128
		[Token(Token = "0x601A7B6")]
		[Address(RVA = "0x13950D0", Offset = "0x1393CD0", VA = "0x1813950D0", Slot = "10")]
		public override int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0601A7B7 RID: 108471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7B7")]
		[Address(RVA = "0x13956E0", Offset = "0x13942E0", VA = "0x1813956E0")]
		public SandboxV2RacerItemViewModel()
		{
		}

		// Token: 0x0601A7B8 RID: 108472 RVA: 0x000A1F40 File Offset: 0x000A0140
		[Token(Token = "0x601A7B8")]
		[Address(RVA = "0x13956D0", Offset = "0x13942D0", VA = "0x1813956D0")]
		private int <>xLuaBaseProxy_CompareTo(object P0)
		{
			return 0;
		}

		// Token: 0x04021B28 RID: 138024
		[Token(Token = "0x4021B28")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isMarked;

		// Token: 0x04021B29 RID: 138025
		[Token(Token = "0x4021B29")]
		[FieldOffset(Offset = "0x60")]
		private string m_name;

		// Token: 0x04021B2A RID: 138026
		[Token(Token = "0x4021B2A")]
		[FieldOffset(Offset = "0x68")]
		private List<SandboxV2RacerMedalModel> m_medalList;

		// Token: 0x04021B2B RID: 138027
		[Token(Token = "0x4021B2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTemp;

		// Token: 0x04021B2C RID: 138028
		[Token(Token = "0x4021B2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMarked;

		// Token: 0x04021B2D RID: 138029
		[Token(Token = "0x4021B2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isMarked;

		// Token: 0x04021B2E RID: 138030
		[Token(Token = "0x4021B2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x04021B2F RID: 138031
		[Token(Token = "0x4021B2F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_medalList;

		// Token: 0x04021B30 RID: 138032
		[Token(Token = "0x4021B30")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021B31 RID: 138033
		[Token(Token = "0x4021B31")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04021B32 RID: 138034
		[Token(Token = "0x4021B32")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
