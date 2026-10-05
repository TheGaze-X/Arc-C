using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005352 RID: 21330
	[Token(Token = "0x2005352")]
	public class RoguelikeMenuTaskViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x0601F72E RID: 128814 RVA: 0x000B1F18 File Offset: 0x000B0118
		[Token(Token = "0x170049BB")]
		public int progress
		{
			[Token(Token = "0x601F72E")]
			[Address(RVA = "0x192ACB0", Offset = "0x19298B0", VA = "0x18192ACB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x0601F72F RID: 128815 RVA: 0x000B1F30 File Offset: 0x000B0130
		[Token(Token = "0x170049BC")]
		public bool isComplete
		{
			[Token(Token = "0x601F72F")]
			[Address(RVA = "0x192AC40", Offset = "0x1929840", VA = "0x18192AC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601F730 RID: 128816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F730")]
		[Address(RVA = "0x192A930", Offset = "0x1929530", VA = "0x18192A930", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F731 RID: 128817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F731")]
		[Address(RVA = "0x192ABA0", Offset = "0x19297A0", VA = "0x18192ABA0")]
		public RoguelikeMenuTaskViewModel()
		{
		}

		// Token: 0x0601F732 RID: 128818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F732")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402A4F3 RID: 173299
		[Token(Token = "0x402A4F3")]
		[FieldOffset(Offset = "0x18")]
		public string taskId;

		// Token: 0x0402A4F4 RID: 173300
		[Token(Token = "0x402A4F4")]
		[FieldOffset(Offset = "0x20")]
		public string taskTitle;

		// Token: 0x0402A4F5 RID: 173301
		[Token(Token = "0x402A4F5")]
		[FieldOffset(Offset = "0x28")]
		public string taskDesc;

		// Token: 0x0402A4F6 RID: 173302
		[Token(Token = "0x402A4F6")]
		[FieldOffset(Offset = "0x30")]
		public int maxProgress;

		// Token: 0x0402A4F7 RID: 173303
		[Token(Token = "0x402A4F7")]
		[FieldOffset(Offset = "0x34")]
		public int currProgress;

		// Token: 0x0402A4F8 RID: 173304
		[Token(Token = "0x402A4F8")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeTaskRarity taskRarity;

		// Token: 0x0402A4F9 RID: 173305
		[Token(Token = "0x402A4F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0402A4FA RID: 173306
		[Token(Token = "0x402A4FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isComplete;

		// Token: 0x0402A4FB RID: 173307
		[Token(Token = "0x402A4FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A4FC RID: 173308
		[Token(Token = "0x402A4FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
