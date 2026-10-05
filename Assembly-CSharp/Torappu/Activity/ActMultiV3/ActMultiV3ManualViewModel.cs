using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F7B RID: 28539
	[Token(Token = "0x2006F7B")]
	public class ActMultiV3ManualViewModel : IHotfixable
	{
		// Token: 0x06028828 RID: 165928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028828")]
		[Address(RVA = "0x23C9DB0", Offset = "0x23C89B0", VA = "0x1823C9DB0")]
		public void InitData(string actId)
		{
		}

		// Token: 0x06028829 RID: 165929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028829")]
		[Address(RVA = "0x23C9EE0", Offset = "0x23C8AE0", VA = "0x1823C9EE0")]
		public void LoadData()
		{
		}

		// Token: 0x0602882A RID: 165930 RVA: 0x000D1EC8 File Offset: 0x000D00C8
		[Token(Token = "0x602882A")]
		[Address(RVA = "0x23C9D10", Offset = "0x23C8910", VA = "0x1823C9D10")]
		public bool HasTabTrackPoint(ManualTabType selectedTabType)
		{
			return default(bool);
		}

		// Token: 0x0602882B RID: 165931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602882B")]
		[Address(RVA = "0x23C9F80", Offset = "0x23C8B80", VA = "0x1823C9F80")]
		public ActMultiV3ManualViewModel()
		{
		}

		// Token: 0x04039ABE RID: 236222
		[Token(Token = "0x4039ABE")]
		[FieldOffset(Offset = "0x10")]
		public ManualTabType selectedTabType;

		// Token: 0x04039ABF RID: 236223
		[Token(Token = "0x4039ABF")]
		[FieldOffset(Offset = "0x14")]
		public int initSeqNum;

		// Token: 0x04039AC0 RID: 236224
		[Token(Token = "0x4039AC0")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x04039AC1 RID: 236225
		[Token(Token = "0x4039AC1")]
		[FieldOffset(Offset = "0x20")]
		public ActMultiV3ManualProfileModel profileModel;

		// Token: 0x04039AC2 RID: 236226
		[Token(Token = "0x4039AC2")]
		[FieldOffset(Offset = "0x28")]
		public ActMultiV3ManualMissionModel missionModel;

		// Token: 0x04039AC3 RID: 236227
		[Token(Token = "0x4039AC3")]
		[FieldOffset(Offset = "0x30")]
		public ActMultiV3ManualAlbumModel albumModel;

		// Token: 0x04039AC4 RID: 236228
		[Token(Token = "0x4039AC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04039AC5 RID: 236229
		[Token(Token = "0x4039AC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039AC6 RID: 236230
		[Token(Token = "0x4039AC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HasTabTrackPoint;

		// Token: 0x04039AC7 RID: 236231
		[Token(Token = "0x4039AC7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
