using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B74 RID: 19316
	[Token(Token = "0x2004B74")]
	public class HomeSecretaryChangeSkinStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D134 RID: 119092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D134")]
		[Address(RVA = "0x16A3D80", Offset = "0x16A2980", VA = "0x1816A3D80")]
		public void LoadData(HomeSecretaryChangeSkinStateBean.InputParams param)
		{
		}

		// Token: 0x0601D135 RID: 119093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D135")]
		[Address(RVA = "0x16A3FA0", Offset = "0x16A2BA0", VA = "0x1816A3FA0")]
		public HomeSecretaryChangeSkinStateBean()
		{
		}

		// Token: 0x04026273 RID: 156275
		[Token(Token = "0x4026273")]
		[FieldOffset(Offset = "0x10")]
		public HomeSecretarySkinChangeViewProperty skinChangeViewProperty;

		// Token: 0x04026274 RID: 156276
		[Token(Token = "0x4026274")]
		[FieldOffset(Offset = "0x18")]
		public bool backToRotationStateByConfirm;

		// Token: 0x04026275 RID: 156277
		[Token(Token = "0x4026275")]
		[FieldOffset(Offset = "0x20")]
		public string backToRotationStatePresetInstId;

		// Token: 0x04026276 RID: 156278
		[Token(Token = "0x4026276")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026277 RID: 156279
		[Token(Token = "0x4026277")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B75 RID: 19317
		[Token(Token = "0x2004B75")]
		public struct InputParams
		{
			// Token: 0x0601D136 RID: 119094 RVA: 0x000AA460 File Offset: 0x000A8660
			[Token(Token = "0x601D136")]
			[Address(RVA = "0x16AA5F0", Offset = "0x16A91F0", VA = "0x1816AA5F0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04026278 RID: 156280
			[Token(Token = "0x4026278")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HomeSecretaryChangeSkinStateBean.InputParams EMPTY;

			// Token: 0x04026279 RID: 156281
			[Token(Token = "0x4026279")]
			[FieldOffset(Offset = "0x0")]
			public List<string> selectedCharIds;

			// Token: 0x0402627A RID: 156282
			[Token(Token = "0x402627A")]
			[FieldOffset(Offset = "0x8")]
			public List<string> selectedSkinTags;

			// Token: 0x0402627B RID: 156283
			[Token(Token = "0x402627B")]
			[FieldOffset(Offset = "0x10")]
			public string presetInstId;

			// Token: 0x0402627C RID: 156284
			[Token(Token = "0x402627C")]
			[FieldOffset(Offset = "0x18")]
			public bool showSelectCharBtn;
		}
	}
}
