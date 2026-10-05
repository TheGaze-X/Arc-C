using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200709E RID: 28830
	[Token(Token = "0x200709E")]
	public abstract class ActMultiV3BattleFinishMapModel : IHotfixable
	{
		// Token: 0x06028FB1 RID: 167857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FB1")]
		[Address(RVA = "0x2472420", Offset = "0x2471020", VA = "0x182472420")]
		protected ActMultiV3BattleFinishMapModel()
		{
		}

		// Token: 0x17006119 RID: 24857
		// (get) Token: 0x06028FB2 RID: 167858
		[Token(Token = "0x17006119")]
		public abstract ActMultiV3MapModeType modeType { [Token(Token = "0x6028FB2")] get; }

		// Token: 0x06028FB3 RID: 167859
		[Token(Token = "0x6028FB3")]
		public abstract void LoadData(ActMultiV3BattleFinishMapModel.Input input);

		// Token: 0x06028FB4 RID: 167860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FB4")]
		[Address(RVA = "0x2472330", Offset = "0x2470F30", VA = "0x182472330")]
		protected ActMultiV3TargetMissionData FindTargetData(ActMultiV3Data actData, ActMultiV3MapData mapData, int targetIdx)
		{
			return null;
		}

		// Token: 0x06028FB5 RID: 167861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FB5")]
		[Address(RVA = "0x2471F40", Offset = "0x2470B40", VA = "0x182471F40")]
		public static ActMultiV3BattleFinishMapModel Create(ActMultiV3BattleFinishMapModel.Input input)
		{
			return null;
		}

		// Token: 0x0403A7EC RID: 239596
		[Token(Token = "0x403A7EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403A7ED RID: 239597
		[Token(Token = "0x403A7ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindTargetData;

		// Token: 0x0403A7EE RID: 239598
		[Token(Token = "0x403A7EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0200709F RID: 28831
		[Token(Token = "0x200709F")]
		public class Input
		{
			// Token: 0x06028FB6 RID: 167862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028FB6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403A7EF RID: 239599
			[Token(Token = "0x403A7EF")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3MapModeType modeType;

			// Token: 0x0403A7F0 RID: 239600
			[Token(Token = "0x403A7F0")]
			[FieldOffset(Offset = "0x18")]
			public ActMultiV3Data actData;

			// Token: 0x0403A7F1 RID: 239601
			[Token(Token = "0x403A7F1")]
			[FieldOffset(Offset = "0x20")]
			public BattleFinishRspData finishRspData;

			// Token: 0x0403A7F2 RID: 239602
			[Token(Token = "0x403A7F2")]
			[FieldOffset(Offset = "0x28")]
			public ActMultiV3MapData mapData;
		}
	}
}
