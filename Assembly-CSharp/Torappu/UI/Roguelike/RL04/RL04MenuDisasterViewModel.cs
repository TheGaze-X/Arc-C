using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056EA RID: 22250
	[Token(Token = "0x20056EA")]
	public class RL04MenuDisasterViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x06020A1E RID: 133662 RVA: 0x000B69A0 File Offset: 0x000B4BA0
		[Token(Token = "0x17004C7A")]
		public bool haveDisaster
		{
			[Token(Token = "0x6020A1E")]
			[Address(RVA = "0x1AC2B20", Offset = "0x1AC1720", VA = "0x181AC2B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x06020A1F RID: 133663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C7B")]
		public string disasterId
		{
			[Token(Token = "0x6020A1F")]
			[Address(RVA = "0x1AC29E0", Offset = "0x1AC15E0", VA = "0x181AC29E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x06020A20 RID: 133664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C7C")]
		public string disasterName
		{
			[Token(Token = "0x6020A20")]
			[Address(RVA = "0x1AC2AB0", Offset = "0x1AC16B0", VA = "0x181AC2AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x06020A21 RID: 133665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C7D")]
		public string disasterIconId
		{
			[Token(Token = "0x6020A21")]
			[Address(RVA = "0x1AC2970", Offset = "0x1AC1570", VA = "0x181AC2970")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x06020A22 RID: 133666 RVA: 0x000B69B8 File Offset: 0x000B4BB8
		[Token(Token = "0x17004C7E")]
		public int disasterLevel
		{
			[Token(Token = "0x6020A22")]
			[Address(RVA = "0x1AC2A40", Offset = "0x1AC1640", VA = "0x181AC2A40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x06020A23 RID: 133667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C7F")]
		public string disasterDesc
		{
			[Token(Token = "0x6020A23")]
			[Address(RVA = "0x1AC2890", Offset = "0x1AC1490", VA = "0x181AC2890")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x06020A24 RID: 133668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C80")]
		public string disasterFuncDesc
		{
			[Token(Token = "0x6020A24")]
			[Address(RVA = "0x1AC2900", Offset = "0x1AC1500", VA = "0x181AC2900")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020A25 RID: 133669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A25")]
		[Address(RVA = "0x1AC2350", Offset = "0x1AC0F50", VA = "0x181AC2350", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06020A26 RID: 133670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A26")]
		[Address(RVA = "0x1AC2630", Offset = "0x1AC1230", VA = "0x181AC2630")]
		private void _LoadDisasterData(string topicId, PlayerRoguelikeV2.CurrentData playerRoguelike)
		{
		}

		// Token: 0x06020A27 RID: 133671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A27")]
		[Address(RVA = "0x1AC2830", Offset = "0x1AC1430", VA = "0x181AC2830")]
		public RL04MenuDisasterViewModel()
		{
		}

		// Token: 0x06020A28 RID: 133672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A28")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402C432 RID: 181298
		[Token(Token = "0x402C432")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402C433 RID: 181299
		[Token(Token = "0x402C433")]
		[FieldOffset(Offset = "0x20")]
		public string currentZoneId;

		// Token: 0x0402C434 RID: 181300
		[Token(Token = "0x402C434")]
		[FieldOffset(Offset = "0x28")]
		public string currentZoneName;

		// Token: 0x0402C435 RID: 181301
		[Token(Token = "0x402C435")]
		[FieldOffset(Offset = "0x30")]
		public string currentZoneIconId;

		// Token: 0x0402C436 RID: 181302
		[Token(Token = "0x402C436")]
		[FieldOffset(Offset = "0x38")]
		public int disperseStep;

		// Token: 0x0402C437 RID: 181303
		[Token(Token = "0x402C437")]
		[FieldOffset(Offset = "0x40")]
		private string m_disasterId;

		// Token: 0x0402C438 RID: 181304
		[Token(Token = "0x402C438")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeDisasterData m_disasterData;

		// Token: 0x0402C439 RID: 181305
		[Token(Token = "0x402C439")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_haveDisaster;

		// Token: 0x0402C43A RID: 181306
		[Token(Token = "0x402C43A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_disasterId;

		// Token: 0x0402C43B RID: 181307
		[Token(Token = "0x402C43B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_disasterName;

		// Token: 0x0402C43C RID: 181308
		[Token(Token = "0x402C43C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_disasterIconId;

		// Token: 0x0402C43D RID: 181309
		[Token(Token = "0x402C43D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_disasterLevel;

		// Token: 0x0402C43E RID: 181310
		[Token(Token = "0x402C43E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_disasterDesc;

		// Token: 0x0402C43F RID: 181311
		[Token(Token = "0x402C43F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_disasterFuncDesc;

		// Token: 0x0402C440 RID: 181312
		[Token(Token = "0x402C440")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C441 RID: 181313
		[Token(Token = "0x402C441")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadDisasterData;

		// Token: 0x0402C442 RID: 181314
		[Token(Token = "0x402C442")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
