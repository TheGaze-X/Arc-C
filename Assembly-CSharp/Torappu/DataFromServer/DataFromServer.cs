using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataFromServer
{
	// Token: 0x020016F6 RID: 5878
	[Token(Token = "0x20016F6")]
	public abstract class DataFromServer<DataType> : IDataConfig, IHotfixable
	{
		// Token: 0x060094C4 RID: 38084 RVA: 0x00039FC0 File Offset: 0x000381C0
		[Token(Token = "0x60094C4")]
		public DataFromServerStorage.DataChunk.Config GetDataChunkConfig()
		{
			return default(DataFromServerStorage.DataChunk.Config);
		}

		// Token: 0x060094C5 RID: 38085
		[Token(Token = "0x60094C5")]
		public abstract string GetDataId();

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060094C6 RID: 38086 RVA: 0x00039FD8 File Offset: 0x000381D8
		[Token(Token = "0x17000FEC")]
		protected virtual bool clearWhenLogin
		{
			[Token(Token = "0x60094C6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060094C7 RID: 38087 RVA: 0x00039FF0 File Offset: 0x000381F0
		[Token(Token = "0x17000FED")]
		protected virtual bool clearWhenCrossDay
		{
			[Token(Token = "0x60094C7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x0003A008 File Offset: 0x00038208
		[Token(Token = "0x60094C8")]
		protected virtual bool OnCustomDataValidCheck(DataFromServerStorage.DataChunk chunk)
		{
			return default(bool);
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094C9")]
		public DataType GetData()
		{
			return null;
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x0003A020 File Offset: 0x00038220
		[Token(Token = "0x60094CA")]
		public bool CheckIfDataValid()
		{
			return default(bool);
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x0003A038 File Offset: 0x00038238
		[Token(Token = "0x60094CB")]
		public ServerDataValidStatus CheckDataValidStatus()
		{
			return default(ServerDataValidStatus);
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CC")]
		public void UpdateData(DataType data)
		{
		}

		// Token: 0x060094CD RID: 38093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094CD")]
		protected DataFromServer()
		{
		}

		// Token: 0x04008AD3 RID: 35539
		[Token(Token = "0x4008AD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataChunkConfig;

		// Token: 0x04008AD4 RID: 35540
		[Token(Token = "0x4008AD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_clearWhenLogin;

		// Token: 0x04008AD5 RID: 35541
		[Token(Token = "0x4008AD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_clearWhenCrossDay;

		// Token: 0x04008AD6 RID: 35542
		[Token(Token = "0x4008AD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCustomDataValidCheck;

		// Token: 0x04008AD7 RID: 35543
		[Token(Token = "0x4008AD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x04008AD8 RID: 35544
		[Token(Token = "0x4008AD8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfDataValid;

		// Token: 0x04008AD9 RID: 35545
		[Token(Token = "0x4008AD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckDataValidStatus;

		// Token: 0x04008ADA RID: 35546
		[Token(Token = "0x4008ADA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04008ADB RID: 35547
		[Token(Token = "0x4008ADB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
