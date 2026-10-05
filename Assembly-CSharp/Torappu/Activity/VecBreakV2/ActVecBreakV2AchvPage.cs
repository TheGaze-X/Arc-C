using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DBF RID: 28095
	[Token(Token = "0x2006DBF")]
	public class ActVecBreakV2AchvPage : StateEnginePage
	{
		// Token: 0x17005E84 RID: 24196
		// (get) Token: 0x06027FFF RID: 163839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028000 RID: 163840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E84")]
		public Dictionary<string, VecBreakV2SeasonAchvInfo> seasonInfoMap
		{
			[Token(Token = "0x6027FFF")]
			[Address(RVA = "0x23469A0", Offset = "0x23455A0", VA = "0x1823469A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028000")]
			[Address(RVA = "0x2346A00", Offset = "0x2345600", VA = "0x182346A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028001 RID: 163841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028001")]
		[Address(RVA = "0x2346860", Offset = "0x2345460", VA = "0x182346860", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06028002 RID: 163842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028002")]
		[Address(RVA = "0x2346940", Offset = "0x2345540", VA = "0x182346940")]
		public ActVecBreakV2AchvPage()
		{
		}

		// Token: 0x06028003 RID: 163843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028003")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04038B70 RID: 232304
		[Token(Token = "0x4038B70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_seasonInfoMap;

		// Token: 0x04038B71 RID: 232305
		[Token(Token = "0x4038B71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_seasonInfoMap;

		// Token: 0x04038B72 RID: 232306
		[Token(Token = "0x4038B72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04038B73 RID: 232307
		[Token(Token = "0x4038B73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DC0 RID: 28096
		[Token(Token = "0x2006DC0")]
		public class Params
		{
			// Token: 0x06028004 RID: 163844 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028004")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04038B74 RID: 232308
			[Token(Token = "0x4038B74")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, VecBreakV2SeasonAchvInfo> seasonInfoMap;
		}
	}
}
