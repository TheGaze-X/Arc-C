using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200327E RID: 12926
	[Token(Token = "0x200327E")]
	public class EmptyEffect : Effect
	{
		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x060147F2 RID: 83954 RVA: 0x00086EF8 File Offset: 0x000850F8
		[Token(Token = "0x17003063")]
		public override bool allowAutoReuse
		{
			[Token(Token = "0x60147F2")]
			[Address(RVA = "0xCB08C0", Offset = "0xCAF4C0", VA = "0x180CB08C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x060147F3 RID: 83955 RVA: 0x00086F10 File Offset: 0x00085110
		[Token(Token = "0x17003064")]
		public override int preloadCnt
		{
			[Token(Token = "0x60147F3")]
			[Address(RVA = "0xCB0AA0", Offset = "0xCAF6A0", VA = "0x180CB0AA0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x060147F4 RID: 83956 RVA: 0x00086F28 File Offset: 0x00085128
		[Token(Token = "0x17003065")]
		protected override Effect.SpawnLocation spawnLocation
		{
			[Token(Token = "0x60147F4")]
			[Address(RVA = "0xCB0B00", Offset = "0xCAF700", VA = "0x180CB0B00", Slot = "10")]
			get
			{
				return Effect.SpawnLocation.NONE;
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x060147F5 RID: 83957 RVA: 0x00086F40 File Offset: 0x00085140
		[Token(Token = "0x17003066")]
		protected override bool useBodyDirection
		{
			[Token(Token = "0x60147F5")]
			[Address(RVA = "0xCB0B60", Offset = "0xCAF760", VA = "0x180CB0B60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x060147F6 RID: 83958 RVA: 0x00086F58 File Offset: 0x00085158
		[Token(Token = "0x17003067")]
		protected override bool holdByOwner
		{
			[Token(Token = "0x60147F6")]
			[Address(RVA = "0xCB09E0", Offset = "0xCAF5E0", VA = "0x180CB09E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x060147F7 RID: 83959 RVA: 0x00086F70 File Offset: 0x00085170
		[Token(Token = "0x17003068")]
		protected override bool overwriteHeight
		{
			[Token(Token = "0x60147F7")]
			[Address(RVA = "0xCB0A40", Offset = "0xCAF640", VA = "0x180CB0A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x060147F8 RID: 83960 RVA: 0x00086F88 File Offset: 0x00085188
		[Token(Token = "0x17003069")]
		protected override float heightOffset
		{
			[Token(Token = "0x60147F8")]
			[Address(RVA = "0xCB0980", Offset = "0xCAF580", VA = "0x180CB0980", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x060147F9 RID: 83961 RVA: 0x00086FA0 File Offset: 0x000851A0
		[Token(Token = "0x1700306A")]
		protected internal override float delayToRecycle
		{
			[Token(Token = "0x60147F9")]
			[Address(RVA = "0xCB0920", Offset = "0xCAF520", VA = "0x180CB0920", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060147FA RID: 83962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147FA")]
		[Address(RVA = "0xCB0840", Offset = "0xCAF440", VA = "0x180CB0840")]
		public EmptyEffect()
		{
		}

		// Token: 0x060147FB RID: 83963 RVA: 0x00086FB8 File Offset: 0x000851B8
		[Token(Token = "0x60147FB")]
		[Address(RVA = "0xCB0830", Offset = "0xCAF430", VA = "0x180CB0830")]
		private bool <>xLuaBaseProxy_get_overwriteHeight()
		{
			return default(bool);
		}

		// Token: 0x060147FC RID: 83964 RVA: 0x00086FD0 File Offset: 0x000851D0
		[Token(Token = "0x60147FC")]
		[Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
		private float <>xLuaBaseProxy_get_heightOffset()
		{
			return 0f;
		}

		// Token: 0x060147FD RID: 83965 RVA: 0x00086FE8 File Offset: 0x000851E8
		[Token(Token = "0x60147FD")]
		[Address(RVA = "0xCB0810", Offset = "0xCAF410", VA = "0x180CB0810")]
		private float <>xLuaBaseProxy_get_delayToRecycle()
		{
			return 0f;
		}

		// Token: 0x040183BA RID: 99258
		[Token(Token = "0x40183BA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _delayToFinish;

		// Token: 0x040183BB RID: 99259
		[Token(Token = "0x40183BB")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private bool _allowAutoReuse;

		// Token: 0x040183BC RID: 99260
		[Token(Token = "0x40183BC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int _preloadCnt;

		// Token: 0x040183BD RID: 99261
		[Token(Token = "0x40183BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allowAutoReuse;

		// Token: 0x040183BE RID: 99262
		[Token(Token = "0x40183BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preloadCnt;

		// Token: 0x040183BF RID: 99263
		[Token(Token = "0x40183BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_spawnLocation;

		// Token: 0x040183C0 RID: 99264
		[Token(Token = "0x40183C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_useBodyDirection;

		// Token: 0x040183C1 RID: 99265
		[Token(Token = "0x40183C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_holdByOwner;

		// Token: 0x040183C2 RID: 99266
		[Token(Token = "0x40183C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_overwriteHeight;

		// Token: 0x040183C3 RID: 99267
		[Token(Token = "0x40183C3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_heightOffset;

		// Token: 0x040183C4 RID: 99268
		[Token(Token = "0x40183C4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x040183C5 RID: 99269
		[Token(Token = "0x40183C5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
