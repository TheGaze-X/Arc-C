using System;
using Il2CppDummyDll;
using Torappu.UI.CrisisV2;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067F5 RID: 26613
	[Token(Token = "0x20067F5")]
	public class ZoneHomeToDoCrisisV2Model : ZoneHomeToDoItemModel
	{
		// Token: 0x0602624D RID: 156237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602624D")]
		[Address(RVA = "0x2145E70", Offset = "0x2144A70", VA = "0x182145E70")]
		public static ZoneHomeToDoCrisisV2Model LoadData(CrisisV2ServerDataWrapper crisisData)
		{
			return null;
		}

		// Token: 0x0602624E RID: 156238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602624E")]
		[Address(RVA = "0x2146120", Offset = "0x2144D20", VA = "0x182146120")]
		private static ZoneHomeToDoCrisisV2Model.TempStageModel _LoadTempModel(string seasonId, CrisisV2ServerDataWrapper crisisData)
		{
			return null;
		}

		// Token: 0x0602624F RID: 156239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602624F")]
		[Address(RVA = "0x2146540", Offset = "0x2145140", VA = "0x182146540")]
		public ZoneHomeToDoCrisisV2Model()
		{
		}

		// Token: 0x04035B89 RID: 220041
		[Token(Token = "0x4035B89")]
		[FieldOffset(Offset = "0x38")]
		public ZoneHomeToDoCrisisV2Model.TempStageModel tempStageModel;

		// Token: 0x04035B8A RID: 220042
		[Token(Token = "0x4035B8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035B8B RID: 220043
		[Token(Token = "0x4035B8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadTempModel;

		// Token: 0x04035B8C RID: 220044
		[Token(Token = "0x4035B8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067F6 RID: 26614
		[Token(Token = "0x20067F6")]
		public class TempStageModel
		{
			// Token: 0x06026250 RID: 156240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026250")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TempStageModel()
			{
			}

			// Token: 0x04035B8D RID: 220045
			[Token(Token = "0x4035B8D")]
			[FieldOffset(Offset = "0x10")]
			public string seasonId;

			// Token: 0x04035B8E RID: 220046
			[Token(Token = "0x4035B8E")]
			[FieldOffset(Offset = "0x18")]
			public string mapId;

			// Token: 0x04035B8F RID: 220047
			[Token(Token = "0x4035B8F")]
			[FieldOffset(Offset = "0x20")]
			public string stageName;

			// Token: 0x04035B90 RID: 220048
			[Token(Token = "0x4035B90")]
			[FieldOffset(Offset = "0x28")]
			public string stageId;

			// Token: 0x04035B91 RID: 220049
			[Token(Token = "0x4035B91")]
			[FieldOffset(Offset = "0x30")]
			public long nextSyncTs;
		}
	}
}
