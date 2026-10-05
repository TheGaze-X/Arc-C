using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003223 RID: 12835
	[Token(Token = "0x2003223")]
	public class ColorModifier : Effect.Behaviour
	{
		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x060145BB RID: 83387 RVA: 0x000869A0 File Offset: 0x00084BA0
		[Token(Token = "0x17003037")]
		public Color color
		{
			[Token(Token = "0x60145BB")]
			[Address(RVA = "0xC9ACE0", Offset = "0xC998E0", VA = "0x180C9ACE0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x060145BC RID: 83388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145BC")]
		[Address(RVA = "0xC9AA60", Offset = "0xC99660", VA = "0x180C9AA60", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145BD RID: 83389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145BD")]
		[Address(RVA = "0xC9AB70", Offset = "0xC99770", VA = "0x180C9AB70")]
		private void Update()
		{
		}

		// Token: 0x060145BE RID: 83390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145BE")]
		[Address(RVA = "0xC9A810", Offset = "0xC99410", VA = "0x180C9A810", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060145BF RID: 83391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145BF")]
		[Address(RVA = "0xC9A910", Offset = "0xC99510", VA = "0x180C9A910", Slot = "8")]
		public override void OnPaused(bool paused)
		{
		}

		// Token: 0x060145C0 RID: 83392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C0")]
		[Address(RVA = "0xC9AC70", Offset = "0xC99870", VA = "0x180C9AC70")]
		public ColorModifier()
		{
		}

		// Token: 0x060145C1 RID: 83393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C1")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060145C2 RID: 83394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C2")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x060145C3 RID: 83395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C3")]
		[Address(RVA = "0xC9AB60", Offset = "0xC99760", VA = "0x180C9AB60")]
		private void <>xLuaBaseProxy_OnPaused(bool P0)
		{
		}

		// Token: 0x04018041 RID: 98369
		[Token(Token = "0x4018041")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _color;

		// Token: 0x04018042 RID: 98370
		[Token(Token = "0x4018042")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _pauseIfOwnerDisappear;

		// Token: 0x04018043 RID: 98371
		[Token(Token = "0x4018043")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x04018044 RID: 98372
		[Token(Token = "0x4018044")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018045 RID: 98373
		[Token(Token = "0x4018045")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018046 RID: 98374
		[Token(Token = "0x4018046")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018047 RID: 98375
		[Token(Token = "0x4018047")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPaused;

		// Token: 0x04018048 RID: 98376
		[Token(Token = "0x4018048")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
