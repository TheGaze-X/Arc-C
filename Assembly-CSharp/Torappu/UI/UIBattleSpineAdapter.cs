using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003859 RID: 14425
	[Token(Token = "0x2003859")]
	public class UIBattleSpineAdapter : UISpineHolder.Adapter, IHotfixable
	{
		// Token: 0x06016D9A RID: 93594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D9A")]
		[Address(RVA = "0xF3EC70", Offset = "0xF3D870", VA = "0x180F3EC70")]
		public void UpdateParam(UIBattleSpineAdapter.BattleSpineInput input)
		{
		}

		// Token: 0x06016D9B RID: 93595 RVA: 0x000933C0 File Offset: 0x000915C0
		[Token(Token = "0x6016D9B")]
		[Address(RVA = "0xF3EAE0", Offset = "0xF3D6E0", VA = "0x180F3EAE0", Slot = "4")]
		public override UISpineHolder.SpineID GetSpineID()
		{
			return default(UISpineHolder.SpineID);
		}

		// Token: 0x06016D9C RID: 93596 RVA: 0x000933D8 File Offset: 0x000915D8
		[Token(Token = "0x6016D9C")]
		[Address(RVA = "0xF3EB80", Offset = "0xF3D780", VA = "0x180F3EB80", Slot = "5")]
		public override Misc.TRS GetTransformParam()
		{
			return default(Misc.TRS);
		}

		// Token: 0x06016D9D RID: 93597 RVA: 0x000933F0 File Offset: 0x000915F0
		[Token(Token = "0x6016D9D")]
		[Address(RVA = "0xF3EA00", Offset = "0xF3D600", VA = "0x180F3EA00", Slot = "6")]
		public override UISpineHolder.SpineAnimParam GetAnimParam()
		{
			return default(UISpineHolder.SpineAnimParam);
		}

		// Token: 0x06016D9E RID: 93598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D9E")]
		[Address(RVA = "0xF3ED40", Offset = "0xF3D940", VA = "0x180F3ED40")]
		public UIBattleSpineAdapter()
		{
		}

		// Token: 0x06016D9F RID: 93599 RVA: 0x00093408 File Offset: 0x00091608
		[Token(Token = "0x6016D9F")]
		[Address(RVA = "0xF3EC30", Offset = "0xF3D830", VA = "0x180F3EC30")]
		private Misc.TRS <>xLuaBaseProxy_GetTransformParam()
		{
			return default(Misc.TRS);
		}

		// Token: 0x0401B8E9 RID: 112873
		[Token(Token = "0x401B8E9")]
		[FieldOffset(Offset = "0x48")]
		private UIBattleSpineAdapter.BattleSpineInput m_cachedInput;

		// Token: 0x0401B8EA RID: 112874
		[Token(Token = "0x401B8EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateParam;

		// Token: 0x0401B8EB RID: 112875
		[Token(Token = "0x401B8EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSpineID;

		// Token: 0x0401B8EC RID: 112876
		[Token(Token = "0x401B8EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTransformParam;

		// Token: 0x0401B8ED RID: 112877
		[Token(Token = "0x401B8ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetAnimParam;

		// Token: 0x0401B8EE RID: 112878
		[Token(Token = "0x401B8EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200385A RID: 14426
		[Token(Token = "0x200385A")]
		public struct BattleSpineInput
		{
			// Token: 0x0401B8EF RID: 112879
			[Token(Token = "0x401B8EF")]
			[FieldOffset(Offset = "0x0")]
			public string skinId;

			// Token: 0x0401B8F0 RID: 112880
			[Token(Token = "0x401B8F0")]
			[FieldOffset(Offset = "0x8")]
			public bool overrideTransform;

			// Token: 0x0401B8F1 RID: 112881
			[Token(Token = "0x401B8F1")]
			[FieldOffset(Offset = "0xC")]
			public Misc.TRS transformParam;

			// Token: 0x0401B8F2 RID: 112882
			[Token(Token = "0x401B8F2")]
			[FieldOffset(Offset = "0x34")]
			public bool overrideAnimParam;

			// Token: 0x0401B8F3 RID: 112883
			[Token(Token = "0x401B8F3")]
			[FieldOffset(Offset = "0x38")]
			public UISpineHolder.SpineAnimParam animParam;
		}
	}
}
