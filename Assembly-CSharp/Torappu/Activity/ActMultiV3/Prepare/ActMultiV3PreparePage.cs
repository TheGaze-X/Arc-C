using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200702E RID: 28718
	[Token(Token = "0x200702E")]
	public class ActMultiV3PreparePage : StateEnginePage
	{
		// Token: 0x1700604B RID: 24651
		// (get) Token: 0x06028C49 RID: 166985 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C4A RID: 166986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700604B")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x6028C49")]
			[Address(RVA = "0x240E5B0", Offset = "0x240D1B0", VA = "0x18240E5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028C4A")]
			[Address(RVA = "0x240E610", Offset = "0x240D210", VA = "0x18240E610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028C4B RID: 166987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C4B")]
		[Address(RVA = "0x240E440", Offset = "0x240D040", VA = "0x18240E440", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06028C4C RID: 166988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C4C")]
		[Address(RVA = "0x240E550", Offset = "0x240D150", VA = "0x18240E550")]
		public ActMultiV3PreparePage()
		{
		}

		// Token: 0x06028C4D RID: 166989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C4D")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0403A21B RID: 238107
		[Token(Token = "0x403A21B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0403A21D RID: 238109
		[Token(Token = "0x403A21D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x0403A21E RID: 238110
		[Token(Token = "0x403A21E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dialogMgr;

		// Token: 0x0403A21F RID: 238111
		[Token(Token = "0x403A21F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403A220 RID: 238112
		[Token(Token = "0x403A220")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200702F RID: 28719
		[Token(Token = "0x200702F")]
		public class Param
		{
			// Token: 0x06028C4E RID: 166990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028C4E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403A221 RID: 238113
			[Token(Token = "0x403A221")]
			[FieldOffset(Offset = "0x10")]
			public string activityId;
		}
	}
}
