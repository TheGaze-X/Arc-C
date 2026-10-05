using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200762A RID: 30250
	[Token(Token = "0x200762A")]
	public class Act20sideCarVotePage : StateEnginePage
	{
		// Token: 0x0602A955 RID: 174421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A955")]
		[Address(RVA = "0x2652DA0", Offset = "0x26519A0", VA = "0x182652DA0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602A956 RID: 174422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A956")]
		[Address(RVA = "0x2653170", Offset = "0x2651D70", VA = "0x182653170")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x0602A957 RID: 174423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A957")]
		[Address(RVA = "0x2653080", Offset = "0x2651C80", VA = "0x182653080")]
		private void _CommonDissmiss()
		{
		}

		// Token: 0x0602A958 RID: 174424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A958")]
		[Address(RVA = "0x2653560", Offset = "0x2652160", VA = "0x182653560")]
		public Act20sideCarVotePage()
		{
		}

		// Token: 0x0602A95B RID: 174427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A95B")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0403D4EF RID: 251119
		[Token(Token = "0x403D4EF")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403D4F0 RID: 251120
		[Token(Token = "0x403D4F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403D4F1 RID: 251121
		[Token(Token = "0x403D4F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0403D4F2 RID: 251122
		[Token(Token = "0x403D4F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CommonDissmiss;

		// Token: 0x0403D4F3 RID: 251123
		[Token(Token = "0x403D4F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200762B RID: 30251
		[Token(Token = "0x200762B")]
		public class Params : IHotfixable
		{
			// Token: 0x0602A95C RID: 174428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A95C")]
			[Address(RVA = "0x2664F20", Offset = "0x2663B20", VA = "0x182664F20")]
			public Params()
			{
			}

			// Token: 0x0403D4F4 RID: 251124
			[Token(Token = "0x403D4F4")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403D4F5 RID: 251125
			[Token(Token = "0x403D4F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
