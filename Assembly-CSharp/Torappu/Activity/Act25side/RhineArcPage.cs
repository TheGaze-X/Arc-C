using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074F0 RID: 29936
	[Token(Token = "0x20074F0")]
	public class RhineArcPage : StateEnginePage
	{
		// Token: 0x0602A30E RID: 172814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A30E")]
		[Address(RVA = "0x25D82A0", Offset = "0x25D6EA0", VA = "0x1825D82A0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602A30F RID: 172815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A30F")]
		[Address(RVA = "0x25D8530", Offset = "0x25D7130", VA = "0x1825D8530")]
		public RhineArcPage()
		{
		}

		// Token: 0x0602A311 RID: 172817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A311")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0403CA13 RID: 248339
		[Token(Token = "0x403CA13")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403CA14 RID: 248340
		[Token(Token = "0x403CA14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403CA15 RID: 248341
		[Token(Token = "0x403CA15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074F1 RID: 29937
		[Token(Token = "0x20074F1")]
		public class Param
		{
			// Token: 0x0602A312 RID: 172818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A312")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403CA16 RID: 248342
			[Token(Token = "0x403CA16")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403CA17 RID: 248343
			[Token(Token = "0x403CA17")]
			[FieldOffset(Offset = "0x18")]
			public RhineArcPage.EnterType enterType;

			// Token: 0x0403CA18 RID: 248344
			[Token(Token = "0x403CA18")]
			[FieldOffset(Offset = "0x20")]
			public string selectAreaId;
		}

		// Token: 0x020074F2 RID: 29938
		[Token(Token = "0x20074F2")]
		public enum EnterType
		{
			// Token: 0x0403CA1A RID: 248346
			[Token(Token = "0x403CA1A")]
			ENUM,
			// Token: 0x0403CA1B RID: 248347
			[Token(Token = "0x403CA1B")]
			FROM_ENTRY,
			// Token: 0x0403CA1C RID: 248348
			[Token(Token = "0x403CA1C")]
			FROM_RESEARCH
		}
	}
}
