using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007628 RID: 30248
	[Token(Token = "0x2007628")]
	public class Act20sideCartShowPage : StateEnginePage
	{
		// Token: 0x1700642C RID: 25644
		// (get) Token: 0x0602A94A RID: 174410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700642C")]
		public string actId
		{
			[Token(Token = "0x602A94A")]
			[Address(RVA = "0x2655D60", Offset = "0x2654960", VA = "0x182655D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700642D RID: 25645
		// (get) Token: 0x0602A94B RID: 174411 RVA: 0x000D9218 File Offset: 0x000D7418
		[Token(Token = "0x1700642D")]
		public bool isRetro
		{
			[Token(Token = "0x602A94B")]
			[Address(RVA = "0x2655E00", Offset = "0x2654A00", VA = "0x182655E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700642E RID: 25646
		// (get) Token: 0x0602A94C RID: 174412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700642E")]
		public string zoneId
		{
			[Token(Token = "0x602A94C")]
			[Address(RVA = "0x2655E80", Offset = "0x2654A80", VA = "0x182655E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A94D RID: 174413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A94D")]
		[Address(RVA = "0x2655740", Offset = "0x2654340", VA = "0x182655740", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602A94E RID: 174414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A94E")]
		[Address(RVA = "0x2655990", Offset = "0x2654590", VA = "0x182655990")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x0602A94F RID: 174415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A94F")]
		[Address(RVA = "0x26558F0", Offset = "0x26544F0", VA = "0x1826558F0")]
		private void _CommonQuit()
		{
		}

		// Token: 0x0602A950 RID: 174416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A950")]
		[Address(RVA = "0x2655D00", Offset = "0x2654900", VA = "0x182655D00")]
		public Act20sideCartShowPage()
		{
		}

		// Token: 0x0602A953 RID: 174419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A953")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0403D4E3 RID: 251107
		[Token(Token = "0x403D4E3")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403D4E4 RID: 251108
		[Token(Token = "0x403D4E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403D4E5 RID: 251109
		[Token(Token = "0x403D4E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRetro;

		// Token: 0x0403D4E6 RID: 251110
		[Token(Token = "0x403D4E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403D4E7 RID: 251111
		[Token(Token = "0x403D4E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403D4E8 RID: 251112
		[Token(Token = "0x403D4E8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0403D4E9 RID: 251113
		[Token(Token = "0x403D4E9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CommonQuit;

		// Token: 0x0403D4EA RID: 251114
		[Token(Token = "0x403D4EA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007629 RID: 30249
		[Token(Token = "0x2007629")]
		public class Param : ICustomPageParam, IHotfixable
		{
			// Token: 0x0602A954 RID: 174420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A954")]
			[Address(RVA = "0x2664EC0", Offset = "0x2663AC0", VA = "0x182664EC0")]
			public Param()
			{
			}

			// Token: 0x0403D4EB RID: 251115
			[Token(Token = "0x403D4EB")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403D4EC RID: 251116
			[Token(Token = "0x403D4EC")]
			[FieldOffset(Offset = "0x18")]
			public bool isRetro;

			// Token: 0x0403D4ED RID: 251117
			[Token(Token = "0x403D4ED")]
			[FieldOffset(Offset = "0x20")]
			public string zoneId;

			// Token: 0x0403D4EE RID: 251118
			[Token(Token = "0x403D4EE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
